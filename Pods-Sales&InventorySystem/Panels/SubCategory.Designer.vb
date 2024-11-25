<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubCategory
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
        Me.SubCategoryTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SubCategoryDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SubCategorySearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.AddSubCategoryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SubCategoryTableLayoutPanel.SuspendLayout()
        CType(Me.SubCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubCategoryTableLayoutPanel
        '
        Me.SubCategoryTableLayoutPanel.ColumnCount = 1
        Me.SubCategoryTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SubCategoryTableLayoutPanel.Controls.Add(Me.SubCategoryDataGridView, 0, 1)
        Me.SubCategoryTableLayoutPanel.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.SubCategoryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubCategoryTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.SubCategoryTableLayoutPanel.Name = "SubCategoryTableLayoutPanel"
        Me.SubCategoryTableLayoutPanel.RowCount = 2
        Me.SubCategoryTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.SubCategoryTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SubCategoryTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SubCategoryTableLayoutPanel.Size = New System.Drawing.Size(789, 602)
        Me.SubCategoryTableLayoutPanel.TabIndex = 2
        '
        'SubCategoryDataGridView
        '
        Me.SubCategoryDataGridView.AllowUserToAddRows = False
        Me.SubCategoryDataGridView.AllowUserToDeleteRows = False
        Me.SubCategoryDataGridView.AllowUserToResizeColumns = False
        Me.SubCategoryDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.SubCategoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubCategoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SubCategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubCategoryDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryDataGridView.Location = New System.Drawing.Point(0, 50)
        Me.SubCategoryDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.SubCategoryDataGridView.MultiSelect = False
        Me.SubCategoryDataGridView.Name = "SubCategoryDataGridView"
        Me.SubCategoryDataGridView.ReadOnly = True
        Me.SubCategoryDataGridView.RowHeadersVisible = False
        Me.SubCategoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SubCategoryDataGridView.Size = New System.Drawing.Size(789, 552)
        Me.SubCategoryDataGridView.TabIndex = 4
        Me.SubCategoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.SubCategoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SubCategoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SubCategoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SubCategoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SubCategoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SubCategoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SubCategoryDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubCategoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SubCategoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SubCategoryDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.SubCategoryDataGridView.ThemeStyle.ReadOnly = True
        Me.SubCategoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.SubCategoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SubCategoryDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubCategoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.SubCategoryDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.SubCategoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SubCategorySearchTextBox, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(783, 44)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'SubCategorySearchTextBox
        '
        Me.SubCategorySearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SubCategorySearchTextBox.BorderColor = System.Drawing.Color.Gray
        Me.SubCategorySearchTextBox.BorderRadius = 15
        Me.SubCategorySearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubCategorySearchTextBox.DefaultText = ""
        Me.SubCategorySearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SubCategorySearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SubCategorySearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubCategorySearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubCategorySearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategorySearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SubCategorySearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategorySearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.SubCategorySearchTextBox.Name = "SubCategorySearchTextBox"
        Me.SubCategorySearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubCategorySearchTextBox.PlaceholderText = "Search"
        Me.SubCategorySearchTextBox.SelectedText = ""
        Me.SubCategorySearchTextBox.ShortcutsEnabled = False
        Me.SubCategorySearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.SubCategorySearchTextBox.TabIndex = 4
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.AddSubCategoryButton)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(391, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(392, 44)
        Me.Guna2Panel1.TabIndex = 5
        '
        'AddSubCategoryButton
        '
        Me.AddSubCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddSubCategoryButton.BackColor = System.Drawing.Color.Transparent
        Me.AddSubCategoryButton.BorderRadius = 15
        Me.AddSubCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddSubCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddSubCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddSubCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddSubCategoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddSubCategoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddSubCategoryButton.ForeColor = System.Drawing.Color.White
        Me.AddSubCategoryButton.Location = New System.Drawing.Point(239, 4)
        Me.AddSubCategoryButton.Name = "AddSubCategoryButton"
        Me.AddSubCategoryButton.Size = New System.Drawing.Size(150, 35)
        Me.AddSubCategoryButton.TabIndex = 3
        Me.AddSubCategoryButton.Text = "Add"
        '
        'SubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SubCategoryTableLayoutPanel)
        Me.Name = "SubCategory"
        Me.Size = New System.Drawing.Size(789, 602)
        Me.SubCategoryTableLayoutPanel.ResumeLayout(False)
        CType(Me.SubCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubCategoryTableLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SubCategorySearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents AddSubCategoryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SubCategoryDataGridView As Guna.UI2.WinForms.Guna2DataGridView
End Class
