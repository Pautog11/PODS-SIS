<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubCategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StockLevelTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DescriptionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProductNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BarcodeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(533, 298)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteProductButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddProductButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 243)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(533, 55)
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
        Me.DeleteProductButton.Location = New System.Drawing.Point(402, 9)
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
        Me.AddProductButton.Location = New System.Drawing.Point(268, 8)
        Me.AddProductButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(128, 37)
        Me.AddProductButton.TabIndex = 5
        Me.AddProductButton.Text = "Add"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2CheckBox1)
        Me.Guna2Panel1.Controls.Add(Me.CheckBox)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.SubCategoryComboBox)
        Me.Guna2Panel1.Controls.Add(Me.StockLevelTextBox)
        Me.Guna2Panel1.Controls.Add(Me.DescriptionTextBox)
        Me.Guna2Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Guna2Panel1.Controls.Add(Me.BarcodeTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(533, 243)
        Me.Guna2Panel1.TabIndex = 1
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox.CheckedState.BorderRadius = 0
        Me.CheckBox.CheckedState.BorderThickness = 0
        Me.CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox.Location = New System.Drawing.Point(30, 200)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(141, 17)
        Me.CheckBox.TabIndex = 31
        Me.CheckBox.Text = "Recorded as a medicine"
        Me.CheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBox.UncheckedState.BorderRadius = 0
        Me.CheckBox.UncheckedState.BorderThickness = 0
        Me.CheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Category"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.BackColor = System.Drawing.Color.Transparent
        Me.CategoryComboBox.BorderColor = System.Drawing.Color.Gray
        Me.CategoryComboBox.BorderRadius = 10
        Me.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryComboBox.ForeColor = System.Drawing.Color.Black
        Me.CategoryComboBox.ItemHeight = 30
        Me.CategoryComboBox.Location = New System.Drawing.Point(30, 35)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(225, 36)
        Me.CategoryComboBox.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(278, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Critical Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(278, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Description (Optional)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Barcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sub Category"
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
        Me.SubCategoryComboBox.ForeColor = System.Drawing.Color.Black
        Me.SubCategoryComboBox.ItemHeight = 30
        Me.SubCategoryComboBox.Location = New System.Drawing.Point(281, 36)
        Me.SubCategoryComboBox.Name = "SubCategoryComboBox"
        Me.SubCategoryComboBox.Size = New System.Drawing.Size(218, 36)
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
        Me.StockLevelTextBox.ForeColor = System.Drawing.Color.Black
        Me.StockLevelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockLevelTextBox.Location = New System.Drawing.Point(281, 94)
        Me.StockLevelTextBox.MaxLength = 3
        Me.StockLevelTextBox.Name = "StockLevelTextBox"
        Me.StockLevelTextBox.PlaceholderText = "0"
        Me.StockLevelTextBox.SelectedText = ""
        Me.StockLevelTextBox.ShortcutsEnabled = False
        Me.StockLevelTextBox.Size = New System.Drawing.Size(225, 36)
        Me.StockLevelTextBox.TabIndex = 8
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
        Me.DescriptionTextBox.ForeColor = System.Drawing.Color.Black
        Me.DescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(281, 147)
        Me.DescriptionTextBox.MaxLength = 50
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.PlaceholderText = ""
        Me.DescriptionTextBox.SelectedText = ""
        Me.DescriptionTextBox.ShortcutsEnabled = False
        Me.DescriptionTextBox.Size = New System.Drawing.Size(225, 37)
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
        Me.ProductNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProductNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(30, 149)
        Me.ProductNameTextBox.MaxLength = 30
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.PlaceholderText = "Ex. (Biogesic)"
        Me.ProductNameTextBox.SelectedText = ""
        Me.ProductNameTextBox.ShortcutsEnabled = False
        Me.ProductNameTextBox.Size = New System.Drawing.Size(225, 36)
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
        Me.BarcodeTextBox.ForeColor = System.Drawing.Color.Black
        Me.BarcodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(30, 94)
        Me.BarcodeTextBox.MaxLength = 13
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.PlaceholderText = "Scan Here"
        Me.BarcodeTextBox.SelectedText = ""
        Me.BarcodeTextBox.ShortcutsEnabled = False
        Me.BarcodeTextBox.Size = New System.Drawing.Size(225, 36)
        Me.BarcodeTextBox.TabIndex = 3
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(281, 200)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.Guna2CheckBox1.TabIndex = 32
        Me.Guna2CheckBox1.Text = "Expiration date is required"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ProductDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 298)
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
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AddProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents StockLevelTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DescriptionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProductNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BarcodeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubCategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
End Class
