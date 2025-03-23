<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeliveryCartDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AccountHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SupplierNameComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuppliersLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.TransactionDeliveryTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.EditButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddItemButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DeliveryDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expiry_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDIT = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VendorComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddDeductionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.AccountHeaderLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.AccountHeaderLayoutPanel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DeliveryDataGridView, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(967, 542)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'AccountHeaderLayoutPanel
        '
        Me.AccountHeaderLayoutPanel.ColumnCount = 2
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.AccountHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountHeaderLayoutPanel.Location = New System.Drawing.Point(3, 53)
        Me.AccountHeaderLayoutPanel.Name = "AccountHeaderLayoutPanel"
        Me.AccountHeaderLayoutPanel.RowCount = 1
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountHeaderLayoutPanel.Size = New System.Drawing.Size(961, 44)
        Me.AccountHeaderLayoutPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SupplierNameComboBox)
        Me.Panel1.Controls.Add(Me.SuppliersLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 44)
        Me.Panel1.TabIndex = 3
        '
        'SupplierNameComboBox
        '
        Me.SupplierNameComboBox.BackColor = System.Drawing.Color.Transparent
        Me.SupplierNameComboBox.BorderRadius = 5
        Me.SupplierNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SupplierNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierNameComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierNameComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierNameComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SupplierNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.SupplierNameComboBox.ItemHeight = 30
        Me.SupplierNameComboBox.Location = New System.Drawing.Point(92, 5)
        Me.SupplierNameComboBox.Name = "SupplierNameComboBox"
        Me.SupplierNameComboBox.Size = New System.Drawing.Size(157, 36)
        Me.SupplierNameComboBox.TabIndex = 1
        '
        'SuppliersLabel
        '
        Me.SuppliersLabel.BackColor = System.Drawing.Color.Transparent
        Me.SuppliersLabel.Location = New System.Drawing.Point(9, 15)
        Me.SuppliersLabel.Name = "SuppliersLabel"
        Me.SuppliersLabel.Size = New System.Drawing.Size(78, 15)
        Me.SuppliersLabel.TabIndex = 0
        Me.SuppliersLabel.Text = "Company Name"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.AddProductButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.TransactionDeliveryTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(480, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(481, 44)
        Me.FlowLayoutPanel1.TabIndex = 4
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
        Me.AddProductButton.Location = New System.Drawing.Point(328, 3)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(150, 35)
        Me.AddProductButton.TabIndex = 2
        Me.AddProductButton.Text = "Add"
        '
        'TransactionDeliveryTextBox
        '
        Me.TransactionDeliveryTextBox.BorderRadius = 5
        Me.TransactionDeliveryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TransactionDeliveryTextBox.DefaultText = ""
        Me.TransactionDeliveryTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TransactionDeliveryTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TransactionDeliveryTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TransactionDeliveryTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TransactionDeliveryTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransactionDeliveryTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TransactionDeliveryTextBox.ForeColor = System.Drawing.Color.Black
        Me.TransactionDeliveryTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransactionDeliveryTextBox.Location = New System.Drawing.Point(144, 3)
        Me.TransactionDeliveryTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.TransactionDeliveryTextBox.MaxLength = 50
        Me.TransactionDeliveryTextBox.Name = "TransactionDeliveryTextBox"
        Me.TransactionDeliveryTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TransactionDeliveryTextBox.PlaceholderText = ""
        Me.TransactionDeliveryTextBox.SelectedText = ""
        Me.TransactionDeliveryTextBox.ShortcutsEnabled = False
        Me.TransactionDeliveryTextBox.Size = New System.Drawing.Size(166, 36)
        Me.TransactionDeliveryTextBox.TabIndex = 4
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(44, 13)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(94, 15)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Delivery Reference"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.AddItemButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 492)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(967, 50)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.BorderRadius = 15
        Me.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SaveButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(807, 7)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 7, 10, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(150, 35)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        '
        'EditButton
        '
        Me.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.EditButton.BackColor = System.Drawing.Color.Transparent
        Me.EditButton.BorderRadius = 15
        Me.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.EditButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.EditButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(651, 7)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(150, 35)
        Me.EditButton.TabIndex = 7
        Me.EditButton.Text = "Edit"
        '
        'AddItemButton
        '
        Me.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddItemButton.BackColor = System.Drawing.Color.Transparent
        Me.AddItemButton.BorderRadius = 15
        Me.AddItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddItemButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddItemButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddItemButton.ForeColor = System.Drawing.Color.White
        Me.AddItemButton.Location = New System.Drawing.Point(495, 7)
        Me.AddItemButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(150, 35)
        Me.AddItemButton.TabIndex = 8
        Me.AddItemButton.Text = "Add"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.DatePicker)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.TotalPrice)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(967, 50)
        Me.Guna2Panel1.TabIndex = 6
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Red
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(349, 18)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(28, 15)
        Me.Guna2HtmlLabel8.TabIndex = 9
        Me.Guna2HtmlLabel8.Text = "0.00"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(303, 18)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(27, 15)
        Me.Guna2HtmlLabel9.TabIndex = 8
        Me.Guna2HtmlLabel9.Text = "Total"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Red
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(220, 18)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(28, 15)
        Me.Guna2HtmlLabel6.TabIndex = 7
        Me.Guna2HtmlLabel6.Text = "0.00"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(142, 18)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(69, 15)
        Me.Guna2HtmlLabel7.TabIndex = 6
        Me.Guna2HtmlLabel7.Text = "Total returned"
        '
        'DatePicker
        '
        Me.DatePicker.BorderRadius = 15
        Me.DatePicker.Checked = True
        Me.DatePicker.FillColor = System.Drawing.Color.White
        Me.DatePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DatePicker.Location = New System.Drawing.Point(758, 8)
        Me.DatePicker.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.DatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(200, 36)
        Me.DatePicker.TabIndex = 5
        Me.DatePicker.Value = New Date(2025, 2, 21, 14, 59, 33, 737)
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(717, 19)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(26, 15)
        Me.Guna2HtmlLabel3.TabIndex = 4
        Me.Guna2HtmlLabel3.Text = "Date"
        '
        'TotalPrice
        '
        Me.TotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.TotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPrice.ForeColor = System.Drawing.Color.Red
        Me.TotalPrice.Location = New System.Drawing.Point(68, 19)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(28, 15)
        Me.TotalPrice.TabIndex = 2
        Me.TotalPrice.Text = "0.00"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(18, 19)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(42, 15)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Subtotal"
        '
        'DeliveryDataGridView
        '
        Me.DeliveryDataGridView.AllowUserToAddRows = False
        Me.DeliveryDataGridView.AllowUserToDeleteRows = False
        Me.DeliveryDataGridView.AllowUserToResizeColumns = False
        Me.DeliveryDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeliveryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.product, Me.expiry_date, Me.batch_number, Me.price, Me.cost_price, Me.quantity, Me.total, Me.target, Me.EDIT})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DeliveryDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DeliveryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliveryDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.Location = New System.Drawing.Point(0, 150)
        Me.DeliveryDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.DeliveryDataGridView.MultiSelect = False
        Me.DeliveryDataGridView.Name = "DeliveryDataGridView"
        Me.DeliveryDataGridView.ReadOnly = True
        Me.DeliveryDataGridView.RowHeadersVisible = False
        Me.DeliveryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DeliveryDataGridView.Size = New System.Drawing.Size(967, 342)
        Me.DeliveryDataGridView.TabIndex = 4
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DeliveryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.DeliveryDataGridView.ThemeStyle.ReadOnly = True
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'product
        '
        Me.product.HeaderText = "PRODUCT"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'expiry_date
        '
        Me.expiry_date.HeaderText = "EXPIRATION DATE"
        Me.expiry_date.Name = "expiry_date"
        Me.expiry_date.ReadOnly = True
        '
        'batch_number
        '
        Me.batch_number.HeaderText = "BATCH NUMBER"
        Me.batch_number.Name = "batch_number"
        Me.batch_number.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "SELLING PRICE"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'cost_price
        '
        Me.cost_price.HeaderText = "COST PRICE"
        Me.cost_price.Name = "cost_price"
        Me.cost_price.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "QUANTITY"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'target
        '
        Me.target.HeaderText = "TARGET"
        Me.target.Name = "target"
        Me.target.ReadOnly = True
        Me.target.Visible = False
        '
        'EDIT
        '
        Me.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EDIT.HeaderText = ""
        Me.EDIT.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.edit
        Me.EDIT.Name = "EDIT"
        Me.EDIT.ReadOnly = True
        Me.EDIT.Width = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel3, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 100)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(967, 50)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.VendorComboBox)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 50)
        Me.Panel2.TabIndex = 4
        '
        'VendorComboBox
        '
        Me.VendorComboBox.BackColor = System.Drawing.Color.Transparent
        Me.VendorComboBox.BorderRadius = 5
        Me.VendorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.VendorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VendorComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VendorComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VendorComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.VendorComboBox.ForeColor = System.Drawing.Color.Black
        Me.VendorComboBox.ItemHeight = 30
        Me.VendorComboBox.Location = New System.Drawing.Point(94, 6)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(157, 36)
        Me.VendorComboBox.TabIndex = 1
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(14, 15)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(68, 15)
        Me.Guna2HtmlLabel4.TabIndex = 0
        Me.Guna2HtmlLabel4.Text = "Vendor Name"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.AddDeductionButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.Guna2Button1)
        Me.FlowLayoutPanel3.Controls.Add(Me.Guna2TextBox1)
        Me.FlowLayoutPanel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(341, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(623, 44)
        Me.FlowLayoutPanel3.TabIndex = 5
        '
        'AddDeductionButton
        '
        Me.AddDeductionButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddDeductionButton.BackColor = System.Drawing.Color.Transparent
        Me.AddDeductionButton.BorderRadius = 15
        Me.AddDeductionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddDeductionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddDeductionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddDeductionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddDeductionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddDeductionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddDeductionButton.ForeColor = System.Drawing.Color.White
        Me.AddDeductionButton.Location = New System.Drawing.Point(470, 7)
        Me.AddDeductionButton.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.AddDeductionButton.Name = "AddDeductionButton"
        Me.AddDeductionButton.Size = New System.Drawing.Size(150, 35)
        Me.AddDeductionButton.TabIndex = 9
        Me.AddDeductionButton.Text = "Apply"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(307, 7)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(150, 35)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "View"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 5
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(128, 3)
        Me.Guna2TextBox1.MaxLength = 50
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShortcutsEnabled = False
        Me.Guna2TextBox1.Size = New System.Drawing.Size(166, 36)
        Me.Guna2TextBox1.TabIndex = 6
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(53, 15)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(69, 15)
        Me.Guna2HtmlLabel5.TabIndex = 10
        Me.Guna2HtmlLabel5.Text = "Total returned"
        '
        'DeliveryCartDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 542)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeliveryCartDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delivery Cart"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.AccountHeaderLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.DeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AccountHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents AddProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SupplierNameComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SuppliersLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TransactionDeliveryTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DeliveryDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents EditButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddItemButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddDeductionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents expiry_date As DataGridViewTextBoxColumn
    Friend WithEvents batch_number As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents cost_price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents target As DataGridViewTextBoxColumn
    Friend WithEvents EDIT As DataGridViewImageColumn
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VendorComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
