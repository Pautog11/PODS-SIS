Imports System.Windows.Forms

Public Class NonMedicalDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub NonMedicalDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubCategoryComboBox.DataSource = BaseProduct.FillBySubCategory.DefaultView
        SubCategoryComboBox.DisplayMember = "subcategory"
        SubCategoryComboBox.SelectedItem = "id"

        If _data IsNot Nothing Then
            AddProductButton.Text = "Update"
            SubCategoryComboBox.Text = BaseProduct.SubcategoryName(_data.Item("subcategory_id"))
            SkuTextBox.Text = _data.Item("sku")
            BarcodeTextBox.Text = _data.Item("barcode")
            ProductNameTextBox.Text = _data.Item("product_name")
            DescriptionTextBox.Text = _data.Item("description")
            StockLevelTextBox.Text = _data.Item("stock_level")
        End If
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim controls As Object() = {
           SubCategoryComboBox, BarcodeTextBox, ProductNameTextBox, StockLevelTextBox
       }
        Dim types As DataInput() = {
           DataInput.STRING_STRING, DataInput.STRING_INTEGER, DataInput.STRING_NAME, DataInput.STRING_INTEGER
        }
        Dim result As New List(Of Object())
        For i = 0 To controls.Count - 1
            result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            If Not CType(result(i), Object())(0) AndAlso Not String.IsNullOrEmpty(controls(i).Text) Then
                Exit Sub
            End If
        Next

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim data As New Dictionary(Of String, String) From {
                {"id", _data?.Item("id")},
                {"subcategory_id", SubCategoryComboBox.SelectedItem("id")},
                {"sku", If(String.IsNullOrEmpty(SkuTextBox.Text), "", SkuTextBox.Text)},
                {"barcode", result(1)(1)},
                {"product_name", result(2)(1)},
                {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)},' result(3)(1)},   'If(String.IsNullOrEmpty(ProductDescriptionTextBox.Text), "", ProductDescriptionTextBox.Text)}
                {"product_price", 0},'If(String.IsNullOrEmpty(PriceTextBox.Text), "", PriceTextBox.Text)},
                {"product_cost", 0},'If(String.IsNullOrEmpty(CostTextBox.Text), "", CostTextBox.Text)},
                {"stock_level", result(3)(1)}
            }

            Dim baseCommand As BaseProduct '(data) 'With {.Items = item}
            baseCommand = New BaseProduct(data)
            Dim invoker As ICommandInvoker = Nothing
            If BaseProduct.Exists(result(2)(1)) = 0 AndAlso BaseProduct.BarcodeExists(result(1)(1)) = 0 AndAlso _data Is Nothing Then
                invoker = New AddCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            ElseIf _data IsNot Nothing AndAlso BaseProduct.Exists(result(2)(1)) = 0 Then
                invoker = New UpdateCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Product exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
