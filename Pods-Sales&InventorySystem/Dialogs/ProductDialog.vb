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
        Try
            Dim sc As DataTable = BaseProduct.FillBySubCategory
            SubCategoryComboBox.DataSource = sc.DefaultView
            SubCategoryComboBox.DisplayMember = "subcategory"
            SubCategoryComboBox.SelectedItem = "id"

            Dim dt As DataTable = BaseDosage.FetchDosage
            DoseComboBox.DataSource = dt.DefaultView
            DoseComboBox.DisplayMember = "dasage"
            DoseComboBox.SelectedItem = "id"
            If dt.Rows.Count > 0 Then
                DoseComboBox.SelectedIndex = -1
            End If


            Dim df As DataTable = BaseDosageForm.FetchDosageform
            DosageFormComboBox.DataSource = df.DefaultView
            DosageFormComboBox.DisplayMember = "dosageform"
            DosageFormComboBox.SelectedItem = "id"
            If df.Rows.Count > 0 Then
                DosageFormComboBox.SelectedIndex = -1
            End If

            If _data IsNot Nothing Then
                SubCategoryComboBox.Text = _data.Item("subcategory_id")
                AddProductButton.Text = "Update"

                SkuTextBox.Text = _data.Item("sku")
                BarcodeTextBox.Text = _data.Item("barcode")
                ProductNameTextBox.Text = _data.Item("product_name")
                DescriptionTextBox.Text = _data.Item("description")
                StockLevelTextBox.Text = _data.Item("stock_level")

                Dim productid As DataTable = BaseProduct.Fillproductinfo(_data("id"))

                If productid.Rows.Count > 0 Then
                    Dim row As DataRow = productid.Rows(0)
                    DosageFormComboBox.Text = If(row("dosage_form") Is DBNull.Value, String.Empty, row("dosage_form").ToString())
                    StrengthTextBox.Text = If(row("strength") Is DBNull.Value, String.Empty, row("strength").ToString())
                    ManufacturerTextBox.Text = If(row("manufacturer") Is DBNull.Value, String.Empty, row("manufacturer").ToString())
                    DoseComboBox.Text = BaseProduct.DoseName(If(row("dose") Is DBNull.Value, String.Empty, row("dose").ToString()))
                End If
            Else
                'DeleteProductButton.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Try
            Dim controls As Object() = {
                  SubCategoryComboBox, BarcodeTextBox, ProductNameTextBox, StockLevelTextBox, DosageFormComboBox, StrengthTextBox, DoseComboBox, ManufacturerTextBox
            }
            Dim types As DataInput() = {
                 DataInput.STRING_STRING, DataInput.STRING_INTEGER, DataInput.STRING_NAME, DataInput.STRING_INTEGER, DataInput.STRING_STRING, DataInput.STRING_INTEGER, DataInput.STRING_STRING, DataInput.STRING_NAME
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
                    {"barcode", result(1)(1)},
                    {"product_name", result(2)(1)},
                    {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)},
                    {"critical_level", result(3)(1)}
                }

                Dim baseCommand As BaseProduct '(data) 'With {.Items = item}
                'baseCommand = New BaseProduct(data) With {.Items = item}
                baseCommand = New BaseProduct(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseProduct.Exists(result(2)(1)) = 0 AndAlso BaseProduct.BarcodeExists(result(1)(1)) = 0 AndAlso _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                Else
                    MessageBox.Show("Product exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteProductButton_Click(sender As Object, e As EventArgs) Handles DeleteProductButton.Click
        Dim baseCommand As New BaseProduct(_data)
        Dim invoker As New DeleteCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub
End Class
