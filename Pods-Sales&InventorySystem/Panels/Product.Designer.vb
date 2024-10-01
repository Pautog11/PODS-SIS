<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ProductsDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ProductHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AddProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ProductSearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProductTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductHeaderLayoutPanel.SuspendLayout()
        Me.ProductTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.AllowUserToAddRows = False
        Me.ProductsDataGridView.AllowUserToDeleteRows = False
        Me.ProductsDataGridView.AllowUserToResizeColumns = False
        Me.ProductsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ProductsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductsDataGridView.Location = New System.Drawing.Point(3, 53)
        Me.ProductsDataGridView.MultiSelect = False
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.ReadOnly = True
        Me.ProductsDataGridView.RowHeadersVisible = False
        Me.ProductsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ProductsDataGridView.Size = New System.Drawing.Size(625, 361)
        Me.ProductsDataGridView.TabIndex = 4
        Me.ProductsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ProductsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ProductsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ProductsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ProductsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ProductsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ProductsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ProductsDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ProductsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ProductsDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.ProductsDataGridView.ThemeStyle.ReadOnly = True
        Me.ProductsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ProductsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ProductsDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ProductsDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.ProductsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ProductHeaderLayoutPanel
        '
        Me.ProductHeaderLayoutPanel.ColumnCount = 2
        Me.ProductHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ProductHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ProductHeaderLayoutPanel.Controls.Add(Me.AddProductButton, 1, 0)
        Me.ProductHeaderLayoutPanel.Controls.Add(Me.ProductSearchTextBox, 0, 0)
        Me.ProductHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductHeaderLayoutPanel.ForeColor = System.Drawing.SystemColors.Control
        Me.ProductHeaderLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.ProductHeaderLayoutPanel.Name = "ProductHeaderLayoutPanel"
        Me.ProductHeaderLayoutPanel.RowCount = 1
        Me.ProductHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ProductHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.ProductHeaderLayoutPanel.Size = New System.Drawing.Size(625, 44)
        Me.ProductHeaderLayoutPanel.TabIndex = 0
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
        Me.AddProductButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddProductButton.ForeColor = System.Drawing.Color.White
        Me.AddProductButton.Location = New System.Drawing.Point(472, 4)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(150, 35)
        Me.AddProductButton.TabIndex = 2
        Me.AddProductButton.Text = "Add"
        '
        'ProductSearchTextBox
        '
        Me.ProductSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProductSearchTextBox.BorderRadius = 15
        Me.ProductSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductSearchTextBox.DefaultText = ""
        Me.ProductSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProductSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProductSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductSearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProductSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductSearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.ProductSearchTextBox.Name = "ProductSearchTextBox"
        Me.ProductSearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductSearchTextBox.PlaceholderText = "Search"
        Me.ProductSearchTextBox.SelectedText = ""
        Me.ProductSearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.ProductSearchTextBox.TabIndex = 3
        '
        'ProductTableLayoutPanel
        '
        Me.ProductTableLayoutPanel.ColumnCount = 1
        Me.ProductTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProductTableLayoutPanel.Controls.Add(Me.ProductsDataGridView, 0, 1)
        Me.ProductTableLayoutPanel.Controls.Add(Me.ProductHeaderLayoutPanel, 0, 0)
        Me.ProductTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ProductTableLayoutPanel.Name = "ProductTableLayoutPanel"
        Me.ProductTableLayoutPanel.RowCount = 2
        Me.ProductTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.ProductTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ProductTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ProductTableLayoutPanel.Size = New System.Drawing.Size(631, 417)
        Me.ProductTableLayoutPanel.TabIndex = 1
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProductTableLayoutPanel)
        Me.Name = "Product"
        Me.Size = New System.Drawing.Size(631, 417)
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductHeaderLayoutPanel.ResumeLayout(False)
        Me.ProductTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductsDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ProductHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents AddProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProductSearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProductTableLayoutPanel As TableLayoutPanel
End Class
