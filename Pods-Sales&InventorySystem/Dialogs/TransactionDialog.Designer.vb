<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionDialog
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.AddItemTransactionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddTransactionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TotalTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VatTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SubtotalTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Reference_number = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TransactionDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2ImageButton2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AddTransactionButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1128, 600)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.AddItemTransactionButton)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(778, 55)
        Me.Guna2Panel1.TabIndex = 12
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
        Me.AddTransactionButton.Location = New System.Drawing.Point(975, 555)
        Me.AddTransactionButton.Name = "AddTransactionButton"
        Me.AddTransactionButton.Size = New System.Drawing.Size(150, 35)
        Me.AddTransactionButton.TabIndex = 7
        Me.AddTransactionButton.Text = "Save"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.TotalTextBox)
        Me.Guna2Panel2.Controls.Add(Me.VatTextBox)
        Me.Guna2Panel2.Controls.Add(Me.SubtotalTextBox)
        Me.Guna2Panel2.Controls.Add(Me.DateLabel)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Reference_number)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.DiscountTextBox)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(778, 55)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(350, 490)
        Me.Guna2Panel2.TabIndex = 13
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
        Me.TotalTextBox.Location = New System.Drawing.Point(167, 227)
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
        Me.VatTextBox.Location = New System.Drawing.Point(167, 93)
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
        Me.SubtotalTextBox.Location = New System.Drawing.Point(167, 135)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubtotalTextBox.PlaceholderText = ""
        Me.SubtotalTextBox.SelectedText = ""
        Me.SubtotalTextBox.Size = New System.Drawing.Size(125, 36)
        Me.SubtotalTextBox.TabIndex = 19
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(88, 28)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(39, 13)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total"
        '
        'Reference_number
        '
        Me.Reference_number.AutoSize = True
        Me.Reference_number.Location = New System.Drawing.Point(109, 54)
        Me.Reference_number.Name = "Reference_number"
        Me.Reference_number.Size = New System.Drawing.Size(39, 13)
        Me.Reference_number.TabIndex = 0
        Me.Reference_number.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Vat"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.BorderRadius = 15
        Me.DiscountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DiscountTextBox.DefaultText = ""
        Me.DiscountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DiscountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DiscountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DiscountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.Location = New System.Drawing.Point(167, 177)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DiscountTextBox.PlaceholderText = ""
        Me.DiscountTextBox.SelectedText = ""
        Me.DiscountTextBox.Size = New System.Drawing.Size(125, 36)
        Me.DiscountTextBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Discount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Subtotal"
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
        Me.TransactionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.product, Me.price, Me.quantity, Me.total})
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TransactionDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AddTransactionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddItemTransactionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DateLabel As Label
    Friend WithEvents Reference_number As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DiscountTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents TotalTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VatTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubtotalTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
