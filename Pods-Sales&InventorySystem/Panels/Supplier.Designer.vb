<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SupplierLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SupplierDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddSupplierButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CategorySearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SupplierLayoutPanel.SuspendLayout()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierLayoutPanel
        '
        Me.SupplierLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.SupplierLayoutPanel.ColumnCount = 1
        Me.SupplierLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SupplierLayoutPanel.Controls.Add(Me.SupplierDataGridView, 0, 1)
        Me.SupplierLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.SupplierLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.SupplierLayoutPanel.Name = "SupplierLayoutPanel"
        Me.SupplierLayoutPanel.RowCount = 2
        Me.SupplierLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.SupplierLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SupplierLayoutPanel.Size = New System.Drawing.Size(752, 502)
        Me.SupplierLayoutPanel.TabIndex = 0
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AllowUserToAddRows = False
        Me.SupplierDataGridView.AllowUserToDeleteRows = False
        Me.SupplierDataGridView.AllowUserToResizeColumns = False
        Me.SupplierDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SupplierDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.SupplierDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.Location = New System.Drawing.Point(4, 55)
        Me.SupplierDataGridView.MultiSelect = False
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        Me.SupplierDataGridView.ReadOnly = True
        Me.SupplierDataGridView.RowHeadersVisible = False
        Me.SupplierDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SupplierDataGridView.Size = New System.Drawing.Size(744, 443)
        Me.SupplierDataGridView.TabIndex = 3
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SupplierDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.SupplierDataGridView.ThemeStyle.ReadOnly = True
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AddSupplierButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CategorySearchTextBox, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(744, 44)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'AddSupplierButton
        '
        Me.AddSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddSupplierButton.BackColor = System.Drawing.Color.Transparent
        Me.AddSupplierButton.BorderRadius = 15
        Me.AddSupplierButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddSupplierButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddSupplierButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddSupplierButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddSupplierButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddSupplierButton.ForeColor = System.Drawing.Color.White
        Me.AddSupplierButton.Location = New System.Drawing.Point(591, 4)
        Me.AddSupplierButton.Name = "AddSupplierButton"
        Me.AddSupplierButton.Size = New System.Drawing.Size(150, 35)
        Me.AddSupplierButton.TabIndex = 6
        Me.AddSupplierButton.Text = "Add"
        '
        'CategorySearchTextBox
        '
        Me.CategorySearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CategorySearchTextBox.BorderRadius = 15
        Me.CategorySearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CategorySearchTextBox.DefaultText = ""
        Me.CategorySearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CategorySearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CategorySearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CategorySearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CategorySearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategorySearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CategorySearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategorySearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.CategorySearchTextBox.Name = "CategorySearchTextBox"
        Me.CategorySearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CategorySearchTextBox.PlaceholderText = "Search"
        Me.CategorySearchTextBox.SelectedText = ""
        Me.CategorySearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.CategorySearchTextBox.TabIndex = 5
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SupplierLayoutPanel)
        Me.Name = "Supplier"
        Me.Size = New System.Drawing.Size(752, 502)
        Me.SupplierLayoutPanel.ResumeLayout(False)
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SupplierLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CategorySearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddSupplierButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupplierDataGridView As Guna.UI2.WinForms.Guna2DataGridView
End Class
