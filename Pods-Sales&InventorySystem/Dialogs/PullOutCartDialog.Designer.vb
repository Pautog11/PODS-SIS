<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PullOutCartDialog
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SaveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.SupplierNameComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuppliersLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VendorComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.AccountHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DeliveryPulloutDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReferennceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tran_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delivery_reference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.atp_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expiry_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rrc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.AccountHeaderLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DeliveryPulloutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SaveButton.Location = New System.Drawing.Point(827, 551)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(150, 35)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        '
        'DatePicker
        '
        Me.DatePicker.BorderRadius = 15
        Me.DatePicker.Checked = True
        Me.DatePicker.FillColor = System.Drawing.Color.White
        Me.DatePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DatePicker.Location = New System.Drawing.Point(765, 5)
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
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(733, 14)
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
        Me.TotalPrice.Location = New System.Drawing.Point(58, 14)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(28, 15)
        Me.TotalPrice.TabIndex = 2
        Me.TotalPrice.Text = "0.00"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, 14)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(27, 15)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Total"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.DatePicker)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.TotalPrice)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(974, 44)
        Me.Guna2Panel1.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.AddProduct)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(681, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(293, 44)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'AddProduct
        '
        Me.AddProduct.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddProduct.BackColor = System.Drawing.Color.Transparent
        Me.AddProduct.BorderRadius = 15
        Me.AddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddProduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddProduct.ForeColor = System.Drawing.Color.White
        Me.AddProduct.Location = New System.Drawing.Point(140, 7)
        Me.AddProduct.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Size = New System.Drawing.Size(150, 35)
        Me.AddProduct.TabIndex = 7
        Me.AddProduct.Text = "Add"
        '
        'SupplierNameComboBox
        '
        Me.SupplierNameComboBox.BackColor = System.Drawing.Color.Transparent
        Me.SupplierNameComboBox.BorderRadius = 10
        Me.SupplierNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SupplierNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierNameComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierNameComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierNameComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SupplierNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.SupplierNameComboBox.ItemHeight = 30
        Me.SupplierNameComboBox.Location = New System.Drawing.Point(106, 4)
        Me.SupplierNameComboBox.Name = "SupplierNameComboBox"
        Me.SupplierNameComboBox.Size = New System.Drawing.Size(178, 36)
        Me.SupplierNameComboBox.TabIndex = 1
        '
        'SuppliersLabel
        '
        Me.SuppliersLabel.BackColor = System.Drawing.Color.Transparent
        Me.SuppliersLabel.Location = New System.Drawing.Point(15, 16)
        Me.SuppliersLabel.Name = "SuppliersLabel"
        Me.SuppliersLabel.Size = New System.Drawing.Size(77, 15)
        Me.SuppliersLabel.TabIndex = 0
        Me.SuppliersLabel.Text = "Suppliers Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VendorComboBox)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 44)
        Me.Panel1.TabIndex = 3
        '
        'VendorComboBox
        '
        Me.VendorComboBox.BackColor = System.Drawing.Color.Transparent
        Me.VendorComboBox.BorderRadius = 10
        Me.VendorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.VendorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VendorComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VendorComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VendorComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.VendorComboBox.ForeColor = System.Drawing.Color.Black
        Me.VendorComboBox.ItemHeight = 30
        Me.VendorComboBox.Location = New System.Drawing.Point(106, 4)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(178, 36)
        Me.VendorComboBox.TabIndex = 3
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(15, 15)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(79, 15)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "Venodors Name"
        '
        'AccountHeaderLayoutPanel
        '
        Me.AccountHeaderLayoutPanel.ColumnCount = 2
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.AccountHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountHeaderLayoutPanel.Location = New System.Drawing.Point(3, 103)
        Me.AccountHeaderLayoutPanel.Name = "AccountHeaderLayoutPanel"
        Me.AccountHeaderLayoutPanel.RowCount = 1
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountHeaderLayoutPanel.Size = New System.Drawing.Size(974, 44)
        Me.AccountHeaderLayoutPanel.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.DeliveryPulloutDataGridView, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SaveButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AccountHeaderLayoutPanel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(980, 592)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'DeliveryPulloutDataGridView
        '
        Me.DeliveryPulloutDataGridView.AllowUserToAddRows = False
        Me.DeliveryPulloutDataGridView.AllowUserToDeleteRows = False
        Me.DeliveryPulloutDataGridView.AllowUserToResizeColumns = False
        Me.DeliveryPulloutDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DeliveryPulloutDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeliveryPulloutDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DeliveryPulloutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tran_id, Me.pid, Me.delivery_reference, Me.product, Me.atp_number, Me.batch_number, Me.expiry_date, Me.rrc, Me.cost_price, Me.quantity, Me.total, Me.from, Me.target})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DeliveryPulloutDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DeliveryPulloutDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliveryPulloutDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryPulloutDataGridView.Location = New System.Drawing.Point(0, 150)
        Me.DeliveryPulloutDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.DeliveryPulloutDataGridView.MultiSelect = False
        Me.DeliveryPulloutDataGridView.Name = "DeliveryPulloutDataGridView"
        Me.DeliveryPulloutDataGridView.ReadOnly = True
        Me.DeliveryPulloutDataGridView.RowHeadersVisible = False
        Me.DeliveryPulloutDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DeliveryPulloutDataGridView.Size = New System.Drawing.Size(980, 392)
        Me.DeliveryPulloutDataGridView.TabIndex = 4
        Me.DeliveryPulloutDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryPulloutDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DeliveryPulloutDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DeliveryPulloutDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DeliveryPulloutDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DeliveryPulloutDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryPulloutDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryPulloutDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryPulloutDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DeliveryPulloutDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryPulloutDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DeliveryPulloutDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DeliveryPulloutDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.DeliveryPulloutDataGridView.ThemeStyle.ReadOnly = True
        Me.DeliveryPulloutDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryPulloutDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DeliveryPulloutDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryPulloutDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DeliveryPulloutDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.DeliveryPulloutDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryPulloutDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(974, 44)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SuppliersLabel)
        Me.Panel2.Controls.Add(Me.SupplierNameComboBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 44)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ReferennceTextBox)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(487, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(487, 44)
        Me.Panel3.TabIndex = 1
        '
        'ReferennceTextBox
        '
        Me.ReferennceTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ReferennceTextBox.BorderRadius = 10
        Me.ReferennceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ReferennceTextBox.DefaultText = ""
        Me.ReferennceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ReferennceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ReferennceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ReferennceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ReferennceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReferennceTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ReferennceTextBox.ForeColor = System.Drawing.Color.Black
        Me.ReferennceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReferennceTextBox.Location = New System.Drawing.Point(278, 5)
        Me.ReferennceTextBox.MaxLength = 20
        Me.ReferennceTextBox.Name = "ReferennceTextBox"
        Me.ReferennceTextBox.PlaceholderText = ""
        Me.ReferennceTextBox.SelectedText = ""
        Me.ReferennceTextBox.ShortcutsEnabled = False
        Me.ReferennceTextBox.Size = New System.Drawing.Size(200, 36)
        Me.ReferennceTextBox.TabIndex = 19
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(174, 16)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(93, 15)
        Me.Guna2HtmlLabel4.TabIndex = 6
        Me.Guna2HtmlLabel4.Text = "Reference Number"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'tran_id
        '
        Me.tran_id.HeaderText = "Dev id"
        Me.tran_id.Name = "tran_id"
        Me.tran_id.ReadOnly = True
        '
        'pid
        '
        Me.pid.HeaderText = "PID"
        Me.pid.Name = "pid"
        Me.pid.ReadOnly = True
        '
        'delivery_reference
        '
        Me.delivery_reference.HeaderText = "DELIVERY REFERENCE"
        Me.delivery_reference.Name = "delivery_reference"
        Me.delivery_reference.ReadOnly = True
        '
        'product
        '
        Me.product.HeaderText = "PRODUCT"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'atp_number
        '
        Me.atp_number.HeaderText = "ATP NUMBER"
        Me.atp_number.Name = "atp_number"
        Me.atp_number.ReadOnly = True
        '
        'batch_number
        '
        Me.batch_number.HeaderText = "BATCH NUMBER"
        Me.batch_number.Name = "batch_number"
        Me.batch_number.ReadOnly = True
        '
        'expiry_date
        '
        Me.expiry_date.HeaderText = "EXPIRATION DATE"
        Me.expiry_date.Name = "expiry_date"
        Me.expiry_date.ReadOnly = True
        '
        'rrc
        '
        Me.rrc.HeaderText = "RRC"
        Me.rrc.Name = "rrc"
        Me.rrc.ReadOnly = True
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
        'from
        '
        Me.from.HeaderText = "FROM"
        Me.from.Name = "from"
        Me.from.ReadOnly = True
        '
        'target
        '
        Me.target.HeaderText = "TARGET"
        Me.target.Name = "target"
        Me.target.ReadOnly = True
        '
        'PullOutCartDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 592)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PullOutCartDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pull Out Cart Dialog"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AccountHeaderLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DeliveryPulloutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SupplierNameComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SuppliersLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AccountHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DeliveryPulloutDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VendorComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ReferennceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tran_id As DataGridViewTextBoxColumn
    Friend WithEvents pid As DataGridViewTextBoxColumn
    Friend WithEvents delivery_reference As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents atp_number As DataGridViewTextBoxColumn
    Friend WithEvents batch_number As DataGridViewTextBoxColumn
    Friend WithEvents expiry_date As DataGridViewTextBoxColumn
    Friend WithEvents rrc As DataGridViewTextBoxColumn
    Friend WithEvents cost_price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents from As DataGridViewTextBoxColumn
    Friend WithEvents target As DataGridViewTextBoxColumn
End Class
