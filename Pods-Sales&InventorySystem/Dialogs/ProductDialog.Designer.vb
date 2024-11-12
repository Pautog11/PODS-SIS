<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ManufacturerTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StrengthTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DosageTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SkuTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CostTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SubCategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StockLevelTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DescriptionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProductNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BarcodeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(571, 373)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteProductButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddProductButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 318)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(571, 55)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'DeleteProductButton
        '
        Me.DeleteProductButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteProductButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteProductButton.BorderRadius = 15
        Me.DeleteProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteProductButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeleteProductButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteProductButton.ForeColor = System.Drawing.Color.White
        Me.DeleteProductButton.Location = New System.Drawing.Point(440, 9)
        Me.DeleteProductButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.DeleteProductButton.Name = "DeleteProductButton"
        Me.DeleteProductButton.Size = New System.Drawing.Size(128, 35)
        Me.DeleteProductButton.TabIndex = 6
        Me.DeleteProductButton.Text = "Delete"
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
        Me.AddProductButton.Location = New System.Drawing.Point(306, 8)
        Me.AddProductButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(128, 37)
        Me.AddProductButton.TabIndex = 5
        Me.AddProductButton.Text = "Add"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.ManufacturerTextBox)
        Me.Guna2Panel1.Controls.Add(Me.StrengthTextBox)
        Me.Guna2Panel1.Controls.Add(Me.DosageTextBox)
        Me.Guna2Panel1.Controls.Add(Me.SkuTextBox)
        Me.Guna2Panel1.Controls.Add(Me.CostTextBox)
        Me.Guna2Panel1.Controls.Add(Me.SubCategoryComboBox)
        Me.Guna2Panel1.Controls.Add(Me.StockLevelTextBox)
        Me.Guna2Panel1.Controls.Add(Me.PriceTextBox)
        Me.Guna2Panel1.Controls.Add(Me.DescriptionTextBox)
        Me.Guna2Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Guna2Panel1.Controls.Add(Me.BarcodeTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(571, 318)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2ComboBox1.BorderRadius = 10
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Milligrams", "Grams", "Micrograms", "Milliliters", "Liters", "Milligrams", "Percentage"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(418, 224)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(115, 36)
        Me.Guna2ComboBox1.TabIndex = 15
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ManufacturerTextBox.BorderRadius = 10
        Me.ManufacturerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ManufacturerTextBox.DefaultText = ""
        Me.ManufacturerTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ManufacturerTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ManufacturerTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ManufacturerTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ManufacturerTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ManufacturerTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ManufacturerTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(64, 266)
        Me.ManufacturerTextBox.MaxLength = 10
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ManufacturerTextBox.PlaceholderText = "Manufacturer"
        Me.ManufacturerTextBox.SelectedText = ""
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(200, 36)
        Me.ManufacturerTextBox.TabIndex = 14
        '
        'StrengthTextBox
        '
        Me.StrengthTextBox.BorderColor = System.Drawing.Color.Gray
        Me.StrengthTextBox.BorderRadius = 10
        Me.StrengthTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StrengthTextBox.DefaultText = ""
        Me.StrengthTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StrengthTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StrengthTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StrengthTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StrengthTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StrengthTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StrengthTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StrengthTextBox.Location = New System.Drawing.Point(333, 224)
        Me.StrengthTextBox.MaxLength = 4
        Me.StrengthTextBox.Name = "StrengthTextBox"
        Me.StrengthTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StrengthTextBox.PlaceholderText = "Strength"
        Me.StrengthTextBox.SelectedText = ""
        Me.StrengthTextBox.Size = New System.Drawing.Size(79, 36)
        Me.StrengthTextBox.TabIndex = 13
        '
        'DosageTextBox
        '
        Me.DosageTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DosageTextBox.BorderRadius = 10
        Me.DosageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DosageTextBox.DefaultText = ""
        Me.DosageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DosageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DosageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DosageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DosageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DosageTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DosageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DosageTextBox.Location = New System.Drawing.Point(64, 224)
        Me.DosageTextBox.MaxLength = 10
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DosageTextBox.PlaceholderText = "Dosage Form"
        Me.DosageTextBox.SelectedText = ""
        Me.DosageTextBox.Size = New System.Drawing.Size(200, 36)
        Me.DosageTextBox.TabIndex = 12
        '
        'SkuTextBox
        '
        Me.SkuTextBox.BorderColor = System.Drawing.Color.Gray
        Me.SkuTextBox.BorderRadius = 10
        Me.SkuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SkuTextBox.DefaultText = ""
        Me.SkuTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SkuTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SkuTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SkuTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SkuTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkuTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SkuTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SkuTextBox.Location = New System.Drawing.Point(64, 118)
        Me.SkuTextBox.MaxLength = 13
        Me.SkuTextBox.Name = "SkuTextBox"
        Me.SkuTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SkuTextBox.PlaceholderText = "Sku"
        Me.SkuTextBox.SelectedText = ""
        Me.SkuTextBox.Size = New System.Drawing.Size(200, 36)
        Me.SkuTextBox.TabIndex = 11
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
        Me.CostTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostTextBox.Location = New System.Drawing.Point(333, 118)
        Me.CostTextBox.MaxLength = 4
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CostTextBox.PlaceholderText = "Cost"
        Me.CostTextBox.SelectedText = ""
        Me.CostTextBox.Size = New System.Drawing.Size(200, 36)
        Me.CostTextBox.TabIndex = 10
        '
        'SubCategoryComboBox
        '
        Me.SubCategoryComboBox.BackColor = System.Drawing.Color.Transparent
        Me.SubCategoryComboBox.BorderColor = System.Drawing.Color.Gray
        Me.SubCategoryComboBox.BorderRadius = 10
        Me.SubCategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SubCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubCategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SubCategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SubCategoryComboBox.ItemHeight = 30
        Me.SubCategoryComboBox.Location = New System.Drawing.Point(64, 34)
        Me.SubCategoryComboBox.Name = "SubCategoryComboBox"
        Me.SubCategoryComboBox.Size = New System.Drawing.Size(200, 36)
        Me.SubCategoryComboBox.TabIndex = 9
        '
        'StockLevelTextBox
        '
        Me.StockLevelTextBox.BorderColor = System.Drawing.Color.Gray
        Me.StockLevelTextBox.BorderRadius = 10
        Me.StockLevelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StockLevelTextBox.DefaultText = ""
        Me.StockLevelTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StockLevelTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StockLevelTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StockLevelTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StockLevelTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockLevelTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StockLevelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockLevelTextBox.Location = New System.Drawing.Point(333, 160)
        Me.StockLevelTextBox.MaxLength = 3
        Me.StockLevelTextBox.Name = "StockLevelTextBox"
        Me.StockLevelTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StockLevelTextBox.PlaceholderText = "Stock Level"
        Me.StockLevelTextBox.SelectedText = ""
        Me.StockLevelTextBox.Size = New System.Drawing.Size(200, 36)
        Me.StockLevelTextBox.TabIndex = 8
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BorderColor = System.Drawing.Color.Gray
        Me.PriceTextBox.BorderRadius = 10
        Me.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceTextBox.DefaultText = ""
        Me.PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTextBox.Location = New System.Drawing.Point(333, 76)
        Me.PriceTextBox.MaxLength = 4
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceTextBox.PlaceholderText = "Price"
        Me.PriceTextBox.SelectedText = ""
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 36)
        Me.PriceTextBox.TabIndex = 7
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DescriptionTextBox.BorderRadius = 10
        Me.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescriptionTextBox.DefaultText = ""
        Me.DescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(333, 34)
        Me.DescriptionTextBox.MaxLength = 20
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescriptionTextBox.PlaceholderText = "Description"
        Me.DescriptionTextBox.SelectedText = ""
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 36)
        Me.DescriptionTextBox.TabIndex = 5
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ProductNameTextBox.BorderRadius = 10
        Me.ProductNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductNameTextBox.DefaultText = ""
        Me.ProductNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProductNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProductNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProductNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(64, 160)
        Me.ProductNameTextBox.MaxLength = 15
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductNameTextBox.PlaceholderText = "Product Name"
        Me.ProductNameTextBox.SelectedText = ""
        Me.ProductNameTextBox.Size = New System.Drawing.Size(200, 36)
        Me.ProductNameTextBox.TabIndex = 4
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
        Me.BarcodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(64, 76)
        Me.BarcodeTextBox.MaxLength = 13
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BarcodeTextBox.PlaceholderText = "Barcode"
        Me.BarcodeTextBox.SelectedText = ""
        Me.BarcodeTextBox.Size = New System.Drawing.Size(200, 36)
        Me.BarcodeTextBox.TabIndex = 3
        '
        'ProductDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 373)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Dialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AddProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents StockLevelTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DescriptionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProductNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BarcodeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubCategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CostTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SkuTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ManufacturerTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StrengthTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DosageTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
