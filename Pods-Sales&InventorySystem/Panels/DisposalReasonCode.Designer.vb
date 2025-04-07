<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisposalReasonCode
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
        Me.DisposalDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AccountHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AddButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DisposalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountHeaderLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DisposalDataGridView.Size = New System.Drawing.Size(853, 574)
        Me.DisposalDataGridView.TabIndex = 4
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
        'AccountHeaderLayoutPanel
        '
        Me.AccountHeaderLayoutPanel.ColumnCount = 2
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.AddButton, 1, 0)
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.SearchTextBox, 0, 0)
        Me.AccountHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountHeaderLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.AccountHeaderLayoutPanel.Name = "AccountHeaderLayoutPanel"
        Me.AccountHeaderLayoutPanel.RowCount = 1
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.AccountHeaderLayoutPanel.Size = New System.Drawing.Size(847, 44)
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
        Me.AddButton.Location = New System.Drawing.Point(694, 4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(150, 35)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
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
        Me.SearchTextBox.Location = New System.Drawing.Point(3, 4)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.PlaceholderText = "Search"
        Me.SearchTextBox.SelectedText = ""
        Me.SearchTextBox.ShortcutsEnabled = False
        Me.SearchTextBox.Size = New System.Drawing.Size(200, 36)
        Me.SearchTextBox.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.DisposalDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AccountHeaderLayoutPanel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(853, 624)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'DisposalReasonCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "DisposalReasonCode"
        Me.Size = New System.Drawing.Size(853, 624)
        CType(Me.DisposalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountHeaderLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisposalDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AccountHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents AddButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
