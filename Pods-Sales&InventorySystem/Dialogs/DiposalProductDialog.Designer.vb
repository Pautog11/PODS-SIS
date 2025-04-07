<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiposalProductDialog
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
        Me.RrcComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StocksTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BatchNumberTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ExpiryDateTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CostTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DisposalDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddButton = New Guna.UI2.WinForms.Guna2Button()
        Me.RemoveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DisposalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RrcComboBox
        '
        Me.RrcComboBox.BackColor = System.Drawing.Color.Transparent
        Me.RrcComboBox.BorderColor = System.Drawing.Color.Gray
        Me.RrcComboBox.BorderRadius = 10
        Me.RrcComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RrcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RrcComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RrcComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RrcComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RrcComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RrcComboBox.ItemHeight = 30
        Me.RrcComboBox.Location = New System.Drawing.Point(248, 27)
        Me.RrcComboBox.Name = "RrcComboBox"
        Me.RrcComboBox.Size = New System.Drawing.Size(203, 36)
        Me.RrcComboBox.TabIndex = 35
        '
        'StocksTextBox
        '
        Me.StocksTextBox.BorderColor = System.Drawing.Color.Gray
        Me.StocksTextBox.BorderRadius = 10
        Me.StocksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StocksTextBox.DefaultText = ""
        Me.StocksTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StocksTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StocksTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StocksTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StocksTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StocksTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StocksTextBox.ForeColor = System.Drawing.Color.Black
        Me.StocksTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StocksTextBox.Location = New System.Drawing.Point(482, 27)
        Me.StocksTextBox.MaxLength = 4
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.PlaceholderText = ""
        Me.StocksTextBox.ReadOnly = True
        Me.StocksTextBox.SelectedText = ""
        Me.StocksTextBox.ShortcutsEnabled = False
        Me.StocksTextBox.Size = New System.Drawing.Size(205, 36)
        Me.StocksTextBox.TabIndex = 33
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SearchTextBox.BorderColor = System.Drawing.Color.Gray
        Me.SearchTextBox.BorderRadius = 15
        Me.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTextBox.DefaultText = ""
        Me.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchTextBox.ForeColor = System.Drawing.Color.Black
        Me.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(10, 7)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.SearchTextBox.MaxLength = 20
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.PlaceholderText = "Search"
        Me.SearchTextBox.SelectedText = ""
        Me.SearchTextBox.ShortcutsEnabled = False
        Me.SearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.SearchTextBox.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RrcComboBox)
        Me.Panel1.Controls.Add(Me.ProductTextBox)
        Me.Panel1.Controls.Add(Me.StocksTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Panel1.Controls.Add(Me.BatchNumberTextBox)
        Me.Panel1.Controls.Add(Me.ExpiryDateTextBox)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CostTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 246)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 196)
        Me.Panel1.TabIndex = 35
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
        Me.ProductTextBox.Location = New System.Drawing.Point(17, 27)
        Me.ProductTextBox.MaxLength = 4
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.PlaceholderText = ""
        Me.ProductTextBox.ReadOnly = True
        Me.ProductTextBox.SelectedText = ""
        Me.ProductTextBox.ShortcutsEnabled = False
        Me.ProductTextBox.Size = New System.Drawing.Size(199, 36)
        Me.ProductTextBox.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Product"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Batch Number"
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
        Me.QuantityTextBox.Location = New System.Drawing.Point(482, 82)
        Me.QuantityTextBox.MaxLength = 4
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PlaceholderText = "0"
        Me.QuantityTextBox.SelectedText = ""
        Me.QuantityTextBox.ShortcutsEnabled = False
        Me.QuantityTextBox.Size = New System.Drawing.Size(205, 36)
        Me.QuantityTextBox.TabIndex = 15
        '
        'BatchNumberTextBox
        '
        Me.BatchNumberTextBox.BorderColor = System.Drawing.Color.Gray
        Me.BatchNumberTextBox.BorderRadius = 10
        Me.BatchNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BatchNumberTextBox.DefaultText = ""
        Me.BatchNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BatchNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BatchNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BatchNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BatchNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchNumberTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BatchNumberTextBox.ForeColor = System.Drawing.Color.Black
        Me.BatchNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchNumberTextBox.Location = New System.Drawing.Point(17, 82)
        Me.BatchNumberTextBox.MaxLength = 50
        Me.BatchNumberTextBox.Name = "BatchNumberTextBox"
        Me.BatchNumberTextBox.PlaceholderText = ""
        Me.BatchNumberTextBox.ReadOnly = True
        Me.BatchNumberTextBox.SelectedText = ""
        Me.BatchNumberTextBox.ShortcutsEnabled = False
        Me.BatchNumberTextBox.Size = New System.Drawing.Size(199, 36)
        Me.BatchNumberTextBox.TabIndex = 31
        '
        'ExpiryDateTextBox
        '
        Me.ExpiryDateTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ExpiryDateTextBox.BorderRadius = 10
        Me.ExpiryDateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ExpiryDateTextBox.DefaultText = ""
        Me.ExpiryDateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ExpiryDateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ExpiryDateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ExpiryDateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ExpiryDateTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpiryDateTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExpiryDateTextBox.ForeColor = System.Drawing.Color.Black
        Me.ExpiryDateTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpiryDateTextBox.Location = New System.Drawing.Point(17, 137)
        Me.ExpiryDateTextBox.MaxLength = 4
        Me.ExpiryDateTextBox.Name = "ExpiryDateTextBox"
        Me.ExpiryDateTextBox.PlaceholderText = ""
        Me.ExpiryDateTextBox.ReadOnly = True
        Me.ExpiryDateTextBox.SelectedText = ""
        Me.ExpiryDateTextBox.ShortcutsEnabled = False
        Me.ExpiryDateTextBox.Size = New System.Drawing.Size(203, 36)
        Me.ExpiryDateTextBox.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Rrc"
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
        Me.CostTextBox.Location = New System.Drawing.Point(252, 82)
        Me.CostTextBox.MaxLength = 4
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.PlaceholderText = "0.00"
        Me.CostTextBox.ReadOnly = True
        Me.CostTextBox.SelectedText = ""
        Me.CostTextBox.ShortcutsEnabled = False
        Me.CostTextBox.Size = New System.Drawing.Size(203, 36)
        Me.CostTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Expiration Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(479, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Stocks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Quantity"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SearchTextBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DisposalDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(698, 493)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'DisposalDataGridView
        '
        Me.DisposalDataGridView.AllowUserToAddRows = False
        Me.DisposalDataGridView.AllowUserToDeleteRows = False
        Me.DisposalDataGridView.AllowUserToResizeColumns = False
        Me.DisposalDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DisposalDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DisposalDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DisposalDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DisposalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisposalDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisposalDataGridView.Location = New System.Drawing.Point(0, 50)
        Me.DisposalDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.DisposalDataGridView.MultiSelect = False
        Me.DisposalDataGridView.Name = "DisposalDataGridView"
        Me.DisposalDataGridView.ReadOnly = True
        Me.DisposalDataGridView.RowHeadersVisible = False
        Me.DisposalDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DisposalDataGridView.Size = New System.Drawing.Size(698, 196)
        Me.DisposalDataGridView.TabIndex = 33
        Me.DisposalDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DisposalDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DisposalDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DisposalDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DisposalDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DisposalDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DisposalDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisposalDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisposalDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DisposalDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisposalDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DisposalDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DisposalDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.DisposalDataGridView.ThemeStyle.ReadOnly = True
        Me.DisposalDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DisposalDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DisposalDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisposalDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DisposalDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.DisposalDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisposalDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.AddButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RemoveButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 442)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(698, 51)
        Me.FlowLayoutPanel1.TabIndex = 26
        '
        'AddButton
        '
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddButton.BackColor = System.Drawing.Color.Transparent
        Me.AddButton.BorderRadius = 15
        Me.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(538, 8)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(3, 8, 10, 3)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(150, 35)
        Me.AddButton.TabIndex = 16
        Me.AddButton.Text = "Add"
        '
        'RemoveButton
        '
        Me.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RemoveButton.BackColor = System.Drawing.Color.Transparent
        Me.RemoveButton.BorderRadius = 15
        Me.RemoveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RemoveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RemoveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RemoveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RemoveButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.RemoveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RemoveButton.ForeColor = System.Drawing.Color.White
        Me.RemoveButton.Location = New System.Drawing.Point(375, 8)
        Me.RemoveButton.Margin = New System.Windows.Forms.Padding(3, 8, 10, 3)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(150, 35)
        Me.RemoveButton.TabIndex = 17
        Me.RemoveButton.Text = "Remove"
        '
        'DiposalProductDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 493)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiposalProductDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DiposalProductDialog"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DisposalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RrcComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents StocksTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents QuantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BatchNumberTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ExpiryDateTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CostTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DisposalDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AddButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RemoveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
End Class
