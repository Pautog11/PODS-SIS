<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnCode
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
        Me.AccountHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AddButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AccountSearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RrcDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AccountHeaderLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RrcDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountHeaderLayoutPanel
        '
        Me.AccountHeaderLayoutPanel.ColumnCount = 2
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.AddButton, 1, 0)
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.AccountSearchTextBox, 0, 0)
        Me.AccountHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountHeaderLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.AccountHeaderLayoutPanel.Name = "AccountHeaderLayoutPanel"
        Me.AccountHeaderLayoutPanel.RowCount = 1
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.AccountHeaderLayoutPanel.Size = New System.Drawing.Size(1126, 44)
        Me.AccountHeaderLayoutPanel.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddButton.BackColor = System.Drawing.Color.Transparent
        Me.AddButton.BorderRadius = 15
        Me.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(973, 4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(150, 35)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        '
        'AccountSearchTextBox
        '
        Me.AccountSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AccountSearchTextBox.BorderColor = System.Drawing.Color.Gray
        Me.AccountSearchTextBox.BorderRadius = 15
        Me.AccountSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountSearchTextBox.DefaultText = ""
        Me.AccountSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AccountSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AccountSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountSearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AccountSearchTextBox.ForeColor = System.Drawing.Color.Black
        Me.AccountSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountSearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.AccountSearchTextBox.Name = "AccountSearchTextBox"
        Me.AccountSearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AccountSearchTextBox.PlaceholderText = "Search"
        Me.AccountSearchTextBox.SelectedText = ""
        Me.AccountSearchTextBox.ShortcutsEnabled = False
        Me.AccountSearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.AccountSearchTextBox.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.RrcDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AccountHeaderLayoutPanel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1132, 669)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'RrcDataGridView
        '
        Me.RrcDataGridView.AllowUserToAddRows = False
        Me.RrcDataGridView.AllowUserToDeleteRows = False
        Me.RrcDataGridView.AllowUserToResizeColumns = False
        Me.RrcDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.RrcDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RrcDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RrcDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.RrcDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RrcDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RrcDataGridView.Location = New System.Drawing.Point(0, 50)
        Me.RrcDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.RrcDataGridView.MultiSelect = False
        Me.RrcDataGridView.Name = "RrcDataGridView"
        Me.RrcDataGridView.ReadOnly = True
        Me.RrcDataGridView.RowHeadersVisible = False
        Me.RrcDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.RrcDataGridView.Size = New System.Drawing.Size(1132, 619)
        Me.RrcDataGridView.TabIndex = 4
        Me.RrcDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.RrcDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.RrcDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.RrcDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.RrcDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.RrcDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.RrcDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RrcDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RrcDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.RrcDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RrcDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.RrcDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.RrcDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.RrcDataGridView.ThemeStyle.ReadOnly = True
        Me.RrcDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.RrcDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RrcDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RrcDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RrcDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.RrcDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RrcDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ReturnCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ReturnCode"
        Me.Size = New System.Drawing.Size(1132, 669)
        Me.AccountHeaderLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RrcDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccountHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents AddButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AccountSearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RrcDataGridView As Guna.UI2.WinForms.Guna2DataGridView
End Class
