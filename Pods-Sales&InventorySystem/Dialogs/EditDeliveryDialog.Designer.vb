<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDeliveryDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AccountDialogLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UpdateDeliveryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BatchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProductTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SellingTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.QuantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CostTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BarcodeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VoidButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AccountDialogLayoutPanel.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountDialogLayoutPanel
        '
        Me.AccountDialogLayoutPanel.ColumnCount = 1
        Me.AccountDialogLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountDialogLayoutPanel.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.AccountDialogLayoutPanel.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.AccountDialogLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountDialogLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AccountDialogLayoutPanel.Name = "AccountDialogLayoutPanel"
        Me.AccountDialogLayoutPanel.RowCount = 2
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.AccountDialogLayoutPanel.Size = New System.Drawing.Size(340, 464)
        Me.AccountDialogLayoutPanel.TabIndex = 20
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel2.Controls.Add(Me.UpdateDeliveryButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.AddProductButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.VoidButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 409)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(340, 55)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'UpdateDeliveryButton
        '
        Me.UpdateDeliveryButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UpdateDeliveryButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateDeliveryButton.BorderRadius = 15
        Me.UpdateDeliveryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdateDeliveryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdateDeliveryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdateDeliveryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdateDeliveryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.UpdateDeliveryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UpdateDeliveryButton.ForeColor = System.Drawing.Color.White
        Me.UpdateDeliveryButton.Location = New System.Drawing.Point(209, 8)
        Me.UpdateDeliveryButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.UpdateDeliveryButton.Name = "UpdateDeliveryButton"
        Me.UpdateDeliveryButton.Size = New System.Drawing.Size(128, 37)
        Me.UpdateDeliveryButton.TabIndex = 3
        Me.UpdateDeliveryButton.Text = "Update"
        '
        'AddProductButton
        '
        Me.AddProductButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddProductButton.BackColor = System.Drawing.Color.Transparent
        Me.AddProductButton.BorderRadius = 15
        Me.AddProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddProductButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddProductButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddProductButton.ForeColor = System.Drawing.Color.White
        Me.AddProductButton.Location = New System.Drawing.Point(75, 8)
        Me.AddProductButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(128, 37)
        Me.AddProductButton.TabIndex = 4
        Me.AddProductButton.Text = "Add"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.BatchTextBox)
        Me.Guna2Panel1.Controls.Add(Me.ProductTextBox)
        Me.Guna2Panel1.Controls.Add(Me.DateTimePicker)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.SellingTextBox)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Guna2Panel1.Controls.Add(Me.CostTextBox)
        Me.Guna2Panel1.Controls.Add(Me.BarcodeTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(340, 409)
        Me.Guna2Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Batch number"
        '
        'BatchTextBox
        '
        Me.BatchTextBox.BorderColor = System.Drawing.Color.Gray
        Me.BatchTextBox.BorderRadius = 10
        Me.BatchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BatchTextBox.DefaultText = ""
        Me.BatchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BatchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BatchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BatchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BatchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BatchTextBox.ForeColor = System.Drawing.Color.Black
        Me.BatchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchTextBox.Location = New System.Drawing.Point(29, 291)
        Me.BatchTextBox.MaxLength = 20
        Me.BatchTextBox.Name = "BatchTextBox"
        Me.BatchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BatchTextBox.PlaceholderText = "0"
        Me.BatchTextBox.SelectedText = ""
        Me.BatchTextBox.ShortcutsEnabled = False
        Me.BatchTextBox.Size = New System.Drawing.Size(270, 36)
        Me.BatchTextBox.TabIndex = 39
        '
        'ProductTextBox
        '
        Me.ProductTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ProductTextBox.BorderRadius = 10
        Me.ProductTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductTextBox.DefaultText = ""
        Me.ProductTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProductTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProductTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProductTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProductTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductTextBox.Location = New System.Drawing.Point(29, 109)
        Me.ProductTextBox.MaxLength = 13
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductTextBox.PlaceholderText = "Ex. Biogesic"
        Me.ProductTextBox.SelectedText = ""
        Me.ProductTextBox.ShortcutsEnabled = False
        Me.ProductTextBox.Size = New System.Drawing.Size(270, 36)
        Me.ProductTextBox.TabIndex = 36
        '
        'DateTimePicker
        '
        Me.DateTimePicker.BorderRadius = 15
        Me.DateTimePicker.Checked = True
        Me.DateTimePicker.FillColor = System.Drawing.Color.White
        Me.DateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker.Location = New System.Drawing.Point(29, 349)
        Me.DateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(270, 36)
        Me.DateTimePicker.TabIndex = 35
        Me.DateTimePicker.Value = New Date(2024, 11, 22, 23, 47, 10, 904)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Selling Price"
        '
        'SellingTextBox
        '
        Me.SellingTextBox.BorderColor = System.Drawing.Color.Gray
        Me.SellingTextBox.BorderRadius = 10
        Me.SellingTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SellingTextBox.DefaultText = ""
        Me.SellingTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SellingTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SellingTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SellingTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SellingTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SellingTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SellingTextBox.ForeColor = System.Drawing.Color.Black
        Me.SellingTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SellingTextBox.Location = New System.Drawing.Point(29, 172)
        Me.SellingTextBox.MaxLength = 13
        Me.SellingTextBox.Name = "SellingTextBox"
        Me.SellingTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SellingTextBox.PlaceholderText = "0.00"
        Me.SellingTextBox.SelectedText = ""
        Me.SellingTextBox.ShortcutsEnabled = False
        Me.SellingTextBox.Size = New System.Drawing.Size(126, 36)
        Me.SellingTextBox.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Expiration Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Cost Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Product"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Barcode"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(151, 71)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(15, 18)
        Me.Guna2HtmlLabel1.TabIndex = 22
        Me.Guna2HtmlLabel1.Text = "or"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(29, 77)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(270, 10)
        Me.Guna2Separator1.TabIndex = 21
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.BorderColor = System.Drawing.Color.Gray
        Me.QuantityTextBox.BorderRadius = 10
        Me.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityTextBox.DefaultText = ""
        Me.QuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.QuantityTextBox.ForeColor = System.Drawing.Color.Black
        Me.QuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTextBox.Location = New System.Drawing.Point(29, 231)
        Me.QuantityTextBox.MaxLength = 3
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTextBox.PlaceholderText = "0"
        Me.QuantityTextBox.SelectedText = ""
        Me.QuantityTextBox.ShortcutsEnabled = False
        Me.QuantityTextBox.Size = New System.Drawing.Size(270, 36)
        Me.QuantityTextBox.TabIndex = 3
        '
        'CostTextBox
        '
        Me.CostTextBox.BorderColor = System.Drawing.Color.Gray
        Me.CostTextBox.BorderRadius = 10
        Me.CostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CostTextBox.DefaultText = ""
        Me.CostTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CostTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CostTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CostTextBox.ForeColor = System.Drawing.Color.Black
        Me.CostTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostTextBox.Location = New System.Drawing.Point(168, 172)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CostTextBox.PlaceholderText = "0.00"
        Me.CostTextBox.SelectedText = ""
        Me.CostTextBox.ShortcutsEnabled = False
        Me.CostTextBox.Size = New System.Drawing.Size(131, 36)
        Me.CostTextBox.TabIndex = 3
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.BorderColor = System.Drawing.Color.Gray
        Me.BarcodeTextBox.BorderRadius = 10
        Me.BarcodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BarcodeTextBox.DefaultText = ""
        Me.BarcodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BarcodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BarcodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BarcodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BarcodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarcodeTextBox.ForeColor = System.Drawing.Color.Black
        Me.BarcodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(29, 33)
        Me.BarcodeTextBox.MaxLength = 13
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BarcodeTextBox.PlaceholderText = "Scan Here"
        Me.BarcodeTextBox.SelectedText = ""
        Me.BarcodeTextBox.ShortcutsEnabled = False
        Me.BarcodeTextBox.Size = New System.Drawing.Size(270, 36)
        Me.BarcodeTextBox.TabIndex = 2
        '
        'VoidButton
        '
        Me.VoidButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.VoidButton.BackColor = System.Drawing.Color.Transparent
        Me.VoidButton.BorderRadius = 15
        Me.VoidButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.VoidButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.VoidButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.VoidButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.VoidButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.VoidButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VoidButton.ForeColor = System.Drawing.Color.White
        Me.VoidButton.Location = New System.Drawing.Point(209, 56)
        Me.VoidButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.VoidButton.Name = "VoidButton"
        Me.VoidButton.Size = New System.Drawing.Size(128, 37)
        Me.VoidButton.TabIndex = 5
        Me.VoidButton.Text = "Void"
        '
        'EditDeliveryDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 464)
        Me.Controls.Add(Me.AccountDialogLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditDeliveryDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EditDeliveryDialog"
        Me.AccountDialogLayoutPanel.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccountDialogLayoutPanel As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents UpdateDeliveryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BatchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProductTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents SellingTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents QuantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CostTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BarcodeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VoidButton As Guna.UI2.WinForms.Guna2Button
End Class
