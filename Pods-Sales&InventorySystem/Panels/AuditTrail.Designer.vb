<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditTrail
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
        Me.AuditTrailDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AuditTrailHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AuditTrailSearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.AuditTrailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuditTrailHeaderLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuditTrailDataGridView
        '
        Me.AuditTrailDataGridView.AllowUserToAddRows = False
        Me.AuditTrailDataGridView.AllowUserToDeleteRows = False
        Me.AuditTrailDataGridView.AllowUserToResizeColumns = False
        Me.AuditTrailDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.AuditTrailDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AuditTrailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AuditTrailDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.AuditTrailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuditTrailDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AuditTrailDataGridView.Location = New System.Drawing.Point(2, 54)
        Me.AuditTrailDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.AuditTrailDataGridView.MultiSelect = False
        Me.AuditTrailDataGridView.Name = "AuditTrailDataGridView"
        Me.AuditTrailDataGridView.ReadOnly = True
        Me.AuditTrailDataGridView.RowHeadersVisible = False
        Me.AuditTrailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AuditTrailDataGridView.Size = New System.Drawing.Size(894, 520)
        Me.AuditTrailDataGridView.TabIndex = 4
        Me.AuditTrailDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AuditTrailDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AuditTrailDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AuditTrailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AuditTrailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AuditTrailDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AuditTrailDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AuditTrailDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AuditTrailDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AuditTrailDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuditTrailDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AuditTrailDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AuditTrailDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.AuditTrailDataGridView.ThemeStyle.ReadOnly = True
        Me.AuditTrailDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AuditTrailDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AuditTrailDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuditTrailDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.AuditTrailDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.AuditTrailDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AuditTrailDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AuditTrailHeaderLayoutPanel
        '
        Me.AuditTrailHeaderLayoutPanel.ColumnCount = 2
        Me.AuditTrailHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AuditTrailHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AuditTrailHeaderLayoutPanel.Controls.Add(Me.AuditTrailSearchTextBox, 0, 0)
        Me.AuditTrailHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuditTrailHeaderLayoutPanel.Location = New System.Drawing.Point(5, 5)
        Me.AuditTrailHeaderLayoutPanel.Name = "AuditTrailHeaderLayoutPanel"
        Me.AuditTrailHeaderLayoutPanel.RowCount = 1
        Me.AuditTrailHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AuditTrailHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.AuditTrailHeaderLayoutPanel.Size = New System.Drawing.Size(888, 44)
        Me.AuditTrailHeaderLayoutPanel.TabIndex = 0
        '
        'AuditTrailSearchTextBox
        '
        Me.AuditTrailSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AuditTrailSearchTextBox.BorderColor = System.Drawing.Color.Gray
        Me.AuditTrailSearchTextBox.BorderRadius = 15
        Me.AuditTrailSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AuditTrailSearchTextBox.DefaultText = ""
        Me.AuditTrailSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AuditTrailSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AuditTrailSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AuditTrailSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AuditTrailSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AuditTrailSearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AuditTrailSearchTextBox.ForeColor = System.Drawing.Color.Black
        Me.AuditTrailSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AuditTrailSearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.AuditTrailSearchTextBox.Name = "AuditTrailSearchTextBox"
        Me.AuditTrailSearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AuditTrailSearchTextBox.PlaceholderText = "Search"
        Me.AuditTrailSearchTextBox.SelectedText = ""
        Me.AuditTrailSearchTextBox.ShortcutsEnabled = False
        Me.AuditTrailSearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.AuditTrailSearchTextBox.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.AuditTrailDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AuditTrailHeaderLayoutPanel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(823, 576)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'AuditTrail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AuditTrail"
        Me.Size = New System.Drawing.Size(823, 576)
        CType(Me.AuditTrailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuditTrailHeaderLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AuditTrailDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AuditTrailHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents AuditTrailSearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
