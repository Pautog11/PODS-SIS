<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountLog
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
        Me.AccountLogDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AccountHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AccountLogSearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.AccountLogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountHeaderLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountLogDataGridView
        '
        Me.AccountLogDataGridView.AllowUserToAddRows = False
        Me.AccountLogDataGridView.AllowUserToDeleteRows = False
        Me.AccountLogDataGridView.AllowUserToResizeColumns = False
        Me.AccountLogDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.AccountLogDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccountLogDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountLogDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.AccountLogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountLogDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountLogDataGridView.Location = New System.Drawing.Point(5, 57)
        Me.AccountLogDataGridView.MultiSelect = False
        Me.AccountLogDataGridView.Name = "AccountLogDataGridView"
        Me.AccountLogDataGridView.ReadOnly = True
        Me.AccountLogDataGridView.RowHeadersVisible = False
        Me.AccountLogDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AccountLogDataGridView.Size = New System.Drawing.Size(888, 487)
        Me.AccountLogDataGridView.TabIndex = 4
        Me.AccountLogDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AccountLogDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AccountLogDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AccountLogDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AccountLogDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AccountLogDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AccountLogDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountLogDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountLogDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AccountLogDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountLogDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AccountLogDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AccountLogDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.AccountLogDataGridView.ThemeStyle.ReadOnly = True
        Me.AccountLogDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AccountLogDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AccountLogDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountLogDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.AccountLogDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.AccountLogDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountLogDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AccountHeaderLayoutPanel
        '
        Me.AccountHeaderLayoutPanel.ColumnCount = 2
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.AccountLogSearchTextBox, 0, 0)
        Me.AccountHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountHeaderLayoutPanel.Location = New System.Drawing.Point(5, 5)
        Me.AccountHeaderLayoutPanel.Name = "AccountHeaderLayoutPanel"
        Me.AccountHeaderLayoutPanel.RowCount = 1
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.AccountHeaderLayoutPanel.Size = New System.Drawing.Size(888, 44)
        Me.AccountHeaderLayoutPanel.TabIndex = 0
        '
        'AccountLogSearchTextBox
        '
        Me.AccountLogSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AccountLogSearchTextBox.BorderRadius = 15
        Me.AccountLogSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountLogSearchTextBox.DefaultText = ""
        Me.AccountLogSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AccountLogSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AccountLogSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountLogSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountLogSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountLogSearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AccountLogSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountLogSearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.AccountLogSearchTextBox.Name = "AccountLogSearchTextBox"
        Me.AccountLogSearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AccountLogSearchTextBox.PlaceholderText = "Search"
        Me.AccountLogSearchTextBox.SelectedText = ""
        Me.AccountLogSearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.AccountLogSearchTextBox.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.AccountLogDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AccountHeaderLayoutPanel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 546)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'AccountLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AccountLog"
        Me.Size = New System.Drawing.Size(896, 546)
        CType(Me.AccountLogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountHeaderLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccountLogDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AccountHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents AccountLogSearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
