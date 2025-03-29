Imports System.Windows.Forms

Public Class ProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Private Exp As Integer = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub
    Private Sub ProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ct As DataTable = BaseCategory.FillByCategory
            CategoryComboBox.DataSource = ct.DefaultView
            CategoryComboBox.DisplayMember = "category"
            CategoryComboBox.SelectedItem = "id"

            'Dim sc As DataTable = BaseProduct.FillBySubCategory(_data.Item("subcategory_id"))
            'SubCategoryComboBox.DataSource = sc.DefaultView
            'SubCategoryComboBox.DisplayMember = "subcategory"
            'SubCategoryComboBox.SelectedItem = "id"

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

            Exp = 0
            ManufacturerTextBox.Enabled = False
            StrengthTextBox.Enabled = False
            DoseComboBox.Enabled = False
            DosageFormComboBox.Enabled = False

            If _data IsNot Nothing Then
                AddProductButton.Text = "Update"
                CategoryComboBox.Text = _data.Item("category_id")

                Dim sc As DataTable = BaseProduct.FillBySubCategory(_data.Item("subcategory_id"))
                SubCategoryComboBox.DataSource = sc.DefaultView
                SubCategoryComboBox.DisplayMember = "subcategory"
                SubCategoryComboBox.SelectedItem = "id"
                SubCategoryComboBox.Text = _data.Item("subcategory_id")

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
                    DoseComboBox.Text = If(row("dose") Is DBNull.Value, String.Empty, row("dose").ToString())
                End If

                If BaseDelivery.EnableExp(_data.Item("id")) = 1 Then
                    CheckBox.Checked = True
                    ManufacturerTextBox.Enabled = True
                    StrengthTextBox.Enabled = True
                    DoseComboBox.Enabled = True
                    DosageFormComboBox.Enabled = True
                End If

                'DeleteProductButton.Visible = False
            Else
                If ct.Rows.Count > 0 Then
                    CategoryComboBox.SelectedIndex = -1
                End If

                'If sc.Rows.Count > 0 Then
                '    SubCategoryComboBox.SelectedIndex = -1
                'End If
                DeleteProductButton.Visible = False
            End If
            DeleteProductButton.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Try
            Dim controls As Object() = {CategoryComboBox, SubCategoryComboBox, ProductNameTextBox, StockLevelTextBox, ManufacturerTextBox, StrengthTextBox, DosageFormComboBox, DoseComboBox}
            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_STRING, DataInput.STRING_PRODUCTNAME, DataInput.STRING_INTEGER, DataInput.STRING_STRING, DataInput.STRING_DECIMAL, DataInput.STRING_STRING, DataInput.STRING_STRING}
            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                If Not CheckBox.Checked Then
                    If controls(i) Is ManufacturerTextBox OrElse
                        controls(i) Is StrengthTextBox OrElse
                        controls(i) Is DoseComboBox OrElse
                        controls(i) Is DosageFormComboBox Then
                        Continue For
                    End If
                End If
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                Else
                    Throw New Exception
                End If
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"subcategory_id", SubCategoryComboBox.SelectedItem("id")},
                    {"barcode", If(String.IsNullOrEmpty(BarcodeTextBox.Text), "", BarcodeTextBox.Text)},
                    {"product_name", result(2)(1)},
                    {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)},
                    {"critical_level", result(3)(1)},
                    {"expiration", Exp},
                    {"dosage_form", DosageFormComboBox.Text},
                    {"strength", StrengthTextBox.Text},
                    {"dose", DoseComboBox.Text},
                    {"manufacturer", ManufacturerTextBox.Text}
                }

                If Not CheckBox.Checked Then
                    data("dosage_form") = ""
                    data("strength") = ""
                    data("dose") = ""
                    data("manufacturer") = ""
                End If

                Dim baseCommand As BaseProduct
                baseCommand = New BaseProduct(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseProduct.Exists(result(2)(1), If(String.IsNullOrEmpty(BarcodeTextBox.Text), "", BarcodeTextBox.Text)) = 0 AndAlso BaseProduct.BarcodeExist(BarcodeTextBox.Text) = 0 AndAlso _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                ElseIf _data IsNot Nothing Then
                    If BaseProduct.IdBarcodeExist(_data.Item("id"), BarcodeTextBox.Text) = 1 Then
                        invoker = New UpdateCommand(baseCommand)
                        invoker?.Execute()
                        _subject.NotifyObserver()
                        Me.Close()
                        Exit Sub
                    End If
                    If BaseProduct.Exists(result(1)(1), If(String.IsNullOrEmpty(BarcodeTextBox.Text), "", BarcodeTextBox.Text)) = 0 Then
                        If Not String.IsNullOrEmpty(BarcodeTextBox.Text) Then
                            If BaseProduct.BarcodeExist(BarcodeTextBox.Text) = 0 Then
                                invoker = New UpdateCommand(baseCommand)
                                invoker?.Execute()
                                _subject.NotifyObserver()
                                Me.Close()
                                Exit Sub
                            Else
                                MessageBox.Show("Barcode is exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        Else
                            invoker = New UpdateCommand(baseCommand)
                            invoker?.Execute()
                            _subject.NotifyObserver()
                            Me.Close()
                            Exit Sub
                        End If
                    End If
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

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If CheckBox.Checked Then
            Exp = 1
            ManufacturerTextBox.Enabled = True
            StrengthTextBox.Enabled = True
            DoseComboBox.Enabled = True
            DosageFormComboBox.Enabled = True
        Else
            Exp = 0
            ManufacturerTextBox.Enabled = False
            StrengthTextBox.Enabled = False
            DoseComboBox.Enabled = False
            DosageFormComboBox.Enabled = False
        End If
    End Sub

    Private Sub CategoryComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectionChangeCommitted
        Dim dt As DataTable = BaseProduct.Filltite(CategoryComboBox.SelectedItem("id"))
        SubCategoryComboBox.DataSource = dt.DefaultView
        SubCategoryComboBox.DisplayMember = "subcategory"
        SubCategoryComboBox.SelectedItem = "id"
        If dt.Rows.Count > 0 Then
            SubCategoryComboBox.SelectedIndex = -1
        End If
    End Sub
End Class
