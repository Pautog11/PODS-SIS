<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionDialog
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TransactionDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.DiscountComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VatableTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChangeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CashTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TotalTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VatTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SubtotalTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Reference_number = New System.Windows.Forms.Label()
        Me.AddTransactionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchItemButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddItemTransactionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ReturnButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.TransactionDataGridView)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.TableLayoutPanel1.SetRowSpan(Me.Guna2Panel3, 2)
        Me.Guna2Panel3.Size = New System.Drawing.Size(778, 545)
        Me.Guna2Panel3.TabIndex = 20
        '
        'TransactionDataGridView
        '
        Me.TransactionDataGridView.AllowUserToAddRows = False
        Me.TransactionDataGridView.AllowUserToDeleteRows = False
        Me.TransactionDataGridView.AllowUserToResizeColumns = False
        Me.TransactionDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.TransactionDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TransactionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TransactionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.product, Me.price, Me.quantity, Me.total, Me.CASH})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.TransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransactionDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TransactionDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.TransactionDataGridView.MultiSelect = False
        Me.TransactionDataGridView.Name = "TransactionDataGridView"
        Me.TransactionDataGridView.ReadOnly = True
        Me.TransactionDataGridView.RowHeadersVisible = False
        Me.TransactionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TransactionDataGridView.Size = New System.Drawing.Size(778, 545)
        Me.TransactionDataGridView.TabIndex = 6
        Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TransactionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TransactionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransactionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransactionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TransactionDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TransactionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TransactionDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.TransactionDataGridView.ThemeStyle.ReadOnly = True
        Me.TransactionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TransactionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TransactionDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TransactionDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.TransactionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransactionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'product
        '
        Me.product.HeaderText = "PRODUCT"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "PRICE"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
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
        'CASH
        '
        Me.CASH.HeaderText = "CASH"
        Me.CASH.Name = "CASH"
        Me.CASH.ReadOnly = True
        Me.CASH.Visible = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.DiscountComboBox)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label13)
        Me.Guna2Panel2.Controls.Add(Me.VatableTextBox)
        Me.Guna2Panel2.Controls.Add(Me.Label12)
        Me.Guna2Panel2.Controls.Add(Me.ChangeTextBox)
        Me.Guna2Panel2.Controls.Add(Me.CashTextBox)
        Me.Guna2Panel2.Controls.Add(Me.TotalTextBox)
        Me.Guna2Panel2.Controls.Add(Me.VatTextBox)
        Me.Guna2Panel2.Controls.Add(Me.SubtotalTextBox)
        Me.Guna2Panel2.Controls.Add(Me.DateLabel)
        Me.Guna2Panel2.Controls.Add(Me.Reference_number)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(778, 55)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(350, 490)
        Me.Guna2Panel2.TabIndex = 13
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
        Me.Guna2Button1.Location = New System.Drawing.Point(11, 441)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(150, 35)
        Me.Guna2Button1.TabIndex = 21
        Me.Guna2Button1.Text = "Save"
        '
        'DiscountComboBox
        '
        Me.DiscountComboBox.BackColor = System.Drawing.Color.Transparent
        Me.DiscountComboBox.BorderRadius = 15
        Me.DiscountComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DiscountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiscountComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DiscountComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DiscountComboBox.ItemHeight = 30
        Me.DiscountComboBox.Location = New System.Drawing.Point(167, 204)
        Me.DiscountComboBox.Name = "DiscountComboBox"
        Me.DiscountComboBox.Size = New System.Drawing.Size(125, 36)
        Me.DiscountComboBox.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(71, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "CHANGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "CASH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "TOTAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "DISCOUNT %"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "SUBTOTAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(71, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 15)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "VAT"
        '
        'VatableTextBox
        '
        Me.VatableTextBox.BorderRadius = 15
        Me.VatableTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VatableTextBox.DefaultText = ""
        Me.VatableTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VatableTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VatableTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VatableTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VatableTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VatableTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VatableTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VatableTextBox.Location = New System.Drawing.Point(167, 78)
        Me.VatableTextBox.Name = "VatableTextBox"
        Me.VatableTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VatableTextBox.PlaceholderText = ""
        Me.VatableTextBox.SelectedText = ""
        Me.VatableTextBox.Size = New System.Drawing.Size(125, 36)
        Me.VatableTextBox.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(71, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 15)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "VATable"
        '
        'ChangeTextBox
        '
        Me.ChangeTextBox.BorderRadius = 15
        Me.ChangeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ChangeTextBox.DefaultText = ""
        Me.ChangeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ChangeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ChangeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ChangeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ChangeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChangeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChangeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChangeTextBox.Location = New System.Drawing.Point(167, 330)
        Me.ChangeTextBox.Name = "ChangeTextBox"
        Me.ChangeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ChangeTextBox.PlaceholderText = ""
        Me.ChangeTextBox.SelectedText = ""
        Me.ChangeTextBox.Size = New System.Drawing.Size(125, 36)
        Me.ChangeTextBox.TabIndex = 28
        '
        'CashTextBox
        '
        Me.CashTextBox.BorderRadius = 15
        Me.CashTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CashTextBox.DefaultText = ""
        Me.CashTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CashTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CashTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CashTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CashTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CashTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CashTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CashTextBox.Location = New System.Drawing.Point(167, 288)
        Me.CashTextBox.Name = "CashTextBox"
        Me.CashTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CashTextBox.PlaceholderText = ""
        Me.CashTextBox.SelectedText = ""
        Me.CashTextBox.Size = New System.Drawing.Size(125, 36)
        Me.CashTextBox.TabIndex = 27
        '
        'TotalTextBox
        '
        Me.TotalTextBox.BorderRadius = 15
        Me.TotalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalTextBox.DefaultText = ""
        Me.TotalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TotalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TotalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TotalTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalTextBox.Location = New System.Drawing.Point(167, 246)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TotalTextBox.PlaceholderText = ""
        Me.TotalTextBox.SelectedText = ""
        Me.TotalTextBox.Size = New System.Drawing.Size(125, 36)
        Me.TotalTextBox.TabIndex = 21
        '
        'VatTextBox
        '
        Me.VatTextBox.BorderRadius = 15
        Me.VatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VatTextBox.DefaultText = ""
        Me.VatTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VatTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VatTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VatTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VatTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VatTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VatTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VatTextBox.Location = New System.Drawing.Point(167, 120)
        Me.VatTextBox.Name = "VatTextBox"
        Me.VatTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VatTextBox.PlaceholderText = ""
        Me.VatTextBox.SelectedText = ""
        Me.VatTextBox.Size = New System.Drawing.Size(125, 36)
        Me.VatTextBox.TabIndex = 20
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.BorderRadius = 15
        Me.SubtotalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubtotalTextBox.DefaultText = ""
        Me.SubtotalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SubtotalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SubtotalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubtotalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubtotalTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubtotalTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SubtotalTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(167, 162)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubtotalTextBox.PlaceholderText = ""
        Me.SubtotalTextBox.SelectedText = ""
        Me.SubtotalTextBox.Size = New System.Drawing.Size(125, 36)
        Me.SubtotalTextBox.TabIndex = 19
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(88, 51)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(45, 13)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "Label2"
        '
        'Reference_number
        '
        Me.Reference_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Reference_number.AutoSize = True
        Me.Reference_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reference_number.Location = New System.Drawing.Point(109, 29)
        Me.Reference_number.Name = "Reference_number"
        Me.Reference_number.Size = New System.Drawing.Size(51, 15)
        Me.Reference_number.TabIndex = 0
        Me.Reference_number.Text = "Label1"
        '
        'AddTransactionButton
        '
        Me.AddTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddTransactionButton.BackColor = System.Drawing.Color.Transparent
        Me.AddTransactionButton.BorderRadius = 15
        Me.AddTransactionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddTransactionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddTransactionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddTransactionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddTransactionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddTransactionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddTransactionButton.ForeColor = System.Drawing.Color.White
        Me.AddTransactionButton.Location = New System.Drawing.Point(197, 10)
        Me.AddTransactionButton.Name = "AddTransactionButton"
        Me.AddTransactionButton.Size = New System.Drawing.Size(150, 35)
        Me.AddTransactionButton.TabIndex = 7
        Me.AddTransactionButton.Text = "Proceed"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.SearchItemButton)
        Me.Guna2Panel1.Controls.Add(Me.AddItemTransactionButton)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(778, 55)
        Me.Guna2Panel1.TabIndex = 12
        '
        'SearchItemButton
        '
        Me.SearchItemButton.BorderRadius = 15
        Me.SearchItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SearchItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SearchItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SearchItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SearchItemButton.FillColor = System.Drawing.Color.White
        Me.SearchItemButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchItemButton.ForeColor = System.Drawing.Color.White
        Me.SearchItemButton.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.search
        Me.SearchItemButton.Location = New System.Drawing.Point(12, 9)
        Me.SearchItemButton.Name = "SearchItemButton"
        Me.SearchItemButton.Size = New System.Drawing.Size(52, 36)
        Me.SearchItemButton.TabIndex = 24
        '
        'AddItemTransactionButton
        '
        Me.AddItemTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddItemTransactionButton.BackColor = System.Drawing.Color.Transparent
        Me.AddItemTransactionButton.BorderRadius = 15
        Me.AddItemTransactionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddItemTransactionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddItemTransactionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddItemTransactionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddItemTransactionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddItemTransactionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddItemTransactionButton.ForeColor = System.Drawing.Color.White
        Me.AddItemTransactionButton.Location = New System.Drawing.Point(620, 9)
        Me.AddItemTransactionButton.Name = "AddItemTransactionButton"
        Me.AddItemTransactionButton.Size = New System.Drawing.Size(150, 35)
        Me.AddItemTransactionButton.TabIndex = 11
        Me.AddItemTransactionButton.Text = "Add"
        '
        'Guna2ImageButton2
        '
        Me.Guna2ImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton2.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ImageButton2.HoverState.ImageSize = New System.Drawing.Size(345, 55)
        Me.Guna2ImageButton2.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.icon_pods
        Me.Guna2ImageButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton2.ImageRotate = 0!
        Me.Guna2ImageButton2.ImageSize = New System.Drawing.Size(345, 55)
        Me.Guna2ImageButton2.Location = New System.Drawing.Point(778, 0)
        Me.Guna2ImageButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ImageButton2.Name = "Guna2ImageButton2"
        Me.Guna2ImageButton2.PressedState.ImageSize = New System.Drawing.Size(345, 55)
        Me.Guna2ImageButton2.Size = New System.Drawing.Size(350, 55)
        Me.Guna2ImageButton2.TabIndex = 19
        Me.Guna2ImageButton2.UseTransparentBackground = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2ImageButton2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1128, 600)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.AddTransactionButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReturnButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(778, 545)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(350, 55)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'ReturnButton
        '
        Me.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ReturnButton.BackColor = System.Drawing.Color.Transparent
        Me.ReturnButton.BorderRadius = 15
        Me.ReturnButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ReturnButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ReturnButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ReturnButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ReturnButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ReturnButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ReturnButton.ForeColor = System.Drawing.Color.White
        Me.ReturnButton.Location = New System.Drawing.Point(41, 10)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(150, 35)
        Me.ReturnButton.TabIndex = 8
        Me.ReturnButton.Text = "Return"
        '
        'TransactionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 600)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransactionDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction Dialog"
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TransactionDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents CASH As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents AddItemTransactionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DiscountComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents VatableTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ChangeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CashTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TotalTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VatTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubtotalTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents Reference_number As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AddTransactionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReturnButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SearchItemButton As Guna.UI2.WinForms.Guna2Button
End Class
