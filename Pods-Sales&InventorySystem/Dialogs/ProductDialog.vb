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
            'PriceTextBox.Text = _data.Item("price")
            'CostTextBox.Text = _data.Item("cost")
            StockLevelTextBox.Text = _data.Item("stock_level")

            Dim productid As DataTable = BaseProduct.Fillproductinfo(_data("id"))
            'MsgBox(_data.Item("id"))
            If productid.Rows.Count > 0 Then
                Dim row As DataRow = productid.Rows(0)
                DosageTextBox.Text = If(row("dosage_form") Is DBNull.Value, String.Empty, row("dosage_form").ToString())
                StrengthTextBox.Text = If(row("strength") Is DBNull.Value, String.Empty, row("strength").ToString())
                ManufacturerTextBox.Text = If(row("manufacturer") Is DBNull.Value, String.Empty, row("manufacturer").ToString())
            End If
            DeleteProductButton.Visible = False
        Else
            DeleteProductButton.Visible = False
        End If
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim controls As Object() = {
            BarcodeTextBox, ProductNameTextBox, StockLevelTextBox
        }
        Dim types As DataInput() = {
            DataInput.STRING_INTEGER, DataInput.STRING_NAME, DataInput.STRING_INTEGER
        }
        Dim result As New List(Of Object())
        For i = 0 To controls.Count - 1
            result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
        Next

        'If Val(PriceTextBox.Text) <= Val(CostTextBox.Text) Then
        '    MessageBox.Show("Price should not be less than or equal to the cost price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return
        'End If


        If Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim data As New Dictionary(Of String, String) From {
                {"id", _data?.Item("id")},
                {"subcategory_id", SubCategoryComboBox.SelectedItem("id")},
                {"sku", If(String.IsNullOrEmpty(SkuTextBox.Text), "", SkuTextBox.Text)},
                {"barcode", result(0)(1)},
                {"product_name", result(1)(1)},
                {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)},' result(3)(1)},   'If(String.IsNullOrEmpty(ProductDescriptionTextBox.Text), "", ProductDescriptionTextBox.Text)}
                {"product_price", 0},'If(String.IsNullOrEmpty(PriceTextBox.Text), "", PriceTextBox.Text)},
                {"product_cost", 0},'If(String.IsNullOrEmpty(CostTextBox.Text), "", CostTextBox.Text)},
                {"stock_level", result(2)(1)}
            }

            Dim putangina As Boolean = False
            Dim item As New Dictionary(Of String, String)

            If Not String.IsNullOrEmpty(DosageTextBox.Text) AndAlso Not String.IsNullOrEmpty(StrengthTextBox.Text) AndAlso Not String.IsNullOrEmpty(ManufacturerTextBox.Text) Then
                Dim textboxes As Object() = {
                    DosageTextBox, StrengthTextBox, ManufacturerTextBox
                }
                Dim types1 As DataInput() = {
                    DataInput.STRING_STRING, DataInput.STRING_INTEGER, DataInput.STRING_NAME
                }
                Dim res As New List(Of Object())
                For i = 0 To textboxes.Count - 1
                    res.Add(InputValidation.ValidateInputString(textboxes(i), types1(i)))
                Next

                item("dosage") = res(0)(1) 'If(String.IsNullOrEmpty(DosageTextBox.Text), Nothing, DosageTextBox.Text)
                item("strength") = res(1)(1) 'If(String.IsNullOrEmpty(StrengthTextBox.Text), Nothing, StrengthTextBox.Text)
                item("manufacturer") = res(2)(1) 'If(String.IsNullOrEmpty(ManufacturerTextBox.Text), Nothing, ManufacturerTextBox.Text)
            End If



            Dim baseCommand As BaseProduct '(data) 'With {.Items = item}
            baseCommand = New BaseProduct(data) With {.Items = item}
            Dim invoker As ICommandInvoker = Nothing
            If BaseProduct.Exists(result(1)(1)) = 0 AndAlso BaseProduct.BarcodeExists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                invoker = New AddCommand(baseCommand)
            ElseIf _data IsNot Nothing Then
                invoker = New UpdateCommand(baseCommand)
            Else
                MessageBox.Show("Product exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
