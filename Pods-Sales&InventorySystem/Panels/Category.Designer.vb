<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CategoryDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AccountSearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddAccountButton = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CategoryDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(892, 591)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CategoryDataGridView
        '
        Me.CategoryDataGridView.AllowUserToAddRows = False
        Me.CategoryDataGridView.AllowUserToDeleteRows = False
        Me.CategoryDataGridView.AllowUserToResizeColumns = False
        Me.CategoryDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.CategoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.CategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDataGridView.Location = New System.Drawing.Point(4, 55)
        Me.CategoryDataGridView.MultiSelect = False
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowHeadersVisible = False
        Me.CategoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CategoryDataGridView.Size = New System.Drawing.Size(884, 532)
        Me.CategoryDataGridView.TabIndex = 2
        Me.CategoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CategoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CategoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CategoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CategoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CategoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CategoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CategoryDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CategoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CategoryDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.CategoryDataGridView.ThemeStyle.ReadOnly = True
        Me.CategoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CategoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CategoryDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CategoryDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.CategoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AddAccountButton, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AccountSearchTextBox, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(884, 44)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'AccountSearchTextBox
        '
        Me.AccountSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AccountSearchTextBox.BorderRadius = 15
        Me.AccountSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountSearchTextBox.DefaultText = ""
        Me.AccountSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AccountSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AccountSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountSearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AccountSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountSearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.AccountSearchTextBox.Name = "AccountSearchTextBox"
        Me.AccountSearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AccountSearchTextBox.PlaceholderText = ""
        Me.AccountSearchTextBox.SelectedText = ""
        Me.AccountSearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.AccountSearchTextBox.TabIndex = 4
        '
        'AddAccountButton
        '
        Me.AddAccountButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddAccountButton.BackColor = System.Drawing.Color.Transparent
        Me.AddAccountButton.BorderRadius = 15
        Me.AddAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddAccountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddAccountButton.ForeColor = System.Drawing.Color.White
        Me.AddAccountButton.Location = New System.Drawing.Point(731, 4)
        Me.AddAccountButton.Name = "AddAccountButton"
        Me.AddAccountButton.Size = New System.Drawing.Size(150, 35)
        Me.AddAccountButton.TabIndex = 5
        Me.AddAccountButton.Text = "Add"
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Category"
        Me.Size = New System.Drawing.Size(892, 591)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CategoryDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AccountSearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddAccountButton As Guna.UI2.WinForms.Guna2Button
End Class
