Imports System.Windows.Forms

Public Class ProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub
    Private Sub ProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            'QuantityTextBox.Text = _data.Item("quantity")
            PriceTextBox.Text = _data.Item("price")
            CostTextBox.Text = _data.Item("cost")
            StockLevelTextBox.Text = _data.Item("stock_level")
        Else
            DeleteProductButton.Visible = False
        End If
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim controls As Object() = {
           SkuTextBox, BarcodeTextBox, ProductNameTextBox, DescriptionTextBox, PriceTextBox, CostTextBox, StockLevelTextBox
       }
        Dim types As DataInput() = {
            DataInput.STRING_STRING, DataInput.STRING_STRING, DataInput.STRING_NAME, DataInput.STRING_STRING, DataInput.STRING_PRICE, DataInput.STRING_PRICE, DataInput.STRING_INTEGER
        }
        Dim result As New List(Of Object())
        For i = 0 To controls.Count - 1
            result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
        Next
        If Val(PriceTextBox.Text) <= Val(CostTextBox.Text) Then
            MessageBox.Show("Should not less than from the cost price", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim data As New Dictionary(Of String, String) From {
                {"id", _data?.Item("id")},
                {"subcategory_id", SubCategoryComboBox.SelectedItem("id")},
                {"sku", result(0)(1)},
                {"barcode", result(1)(1)},
                {"product_name", result(2)(1)},
                {"description", result(3)(1)},   'If(String.IsNullOrEmpty(ProductDescriptionTextBox.Text), "", ProductDescriptionTextBox.Text)}
                {"product_price", result(4)(1)},
                {"product_cost", result(5)(1)},
                {"stock_level", result(6)(1)}
            }

            Dim item As New Dictionary(Of String, String) From {
                {"dosage", If(String.IsNullOrEmpty(DosageTextBox.Text), Nothing, DosageTextBox.Text)},
                {"strength", If(String.IsNullOrEmpty(StrengthTextBox.Text), Nothing, StrengthTextBox.Text)},
                {"manufacturer", If(String.IsNullOrEmpty(ManufacturerTextBox.Text), Nothing, ManufacturerTextBox.Text)}
            }


            Dim baseCommand As BaseProduct '(data) 'With {.Items = item}
            baseCommand = New BaseProduct(data) With {.Items = item}
            Dim invoker As ICommandInvoker = Nothing
            If BaseProduct.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                invoker = New AddCommand(baseCommand)
            ElseIf _data IsNot Nothing Then
                invoker = New UpdateCommand(baseCommand)
            Else
                MessageBox.Show("Product exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                For Each ctrl As Guna.UI2.WinForms.Guna2TextBox In controls
                    ctrl.Text = String.Empty
                Next
                Return
            End If
            invoker?.Execute()
            _subject.NotifyObserver()
            Me.Close()
        Else
            MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteProductButton_Click(sender As Object, e As EventArgs) Handles DeleteProductButton.Click
        Dim baseCommand As New BaseProduct(_data)
        Dim invoker As New DeleteCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub
End Class
