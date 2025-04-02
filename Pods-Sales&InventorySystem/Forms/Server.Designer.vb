<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server
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
        Me.ServerLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ServerTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.UsernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.TestButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ServerLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServerLayoutPanel
        '
        Me.ServerLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.ServerLayoutPanel.ColumnCount = 1
        Me.ServerLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ServerLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.ServerLayoutPanel.Controls.Add(Me.Guna2Panel1, 0, 1)
        Me.ServerLayoutPanel.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.ServerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServerLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ServerLayoutPanel.Name = "ServerLayoutPanel"
        Me.ServerLayoutPanel.RowCount = 3
        Me.ServerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.ServerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ServerLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.ServerLayoutPanel.Size = New System.Drawing.Size(326, 368)
        Me.ServerLayoutPanel.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2HtmlLabel4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(324, 45)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.IsSelectionEnabled = False
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(20, 13)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(43, 18)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "Server"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.ServerTextBox)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CheckBox1)
        Me.Guna2Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Guna2Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 47)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(324, 264)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(24, 19)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(43, 18)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Server"
        '
        'ServerTextBox
        '
        Me.ServerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ServerTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ServerTextBox.BorderRadius = 10
        Me.ServerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ServerTextBox.DefaultText = ""
        Me.ServerTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ServerTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ServerTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ServerTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ServerTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServerTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ServerTextBox.ForeColor = System.Drawing.Color.Black
        Me.ServerTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServerTextBox.Location = New System.Drawing.Point(27, 43)
        Me.ServerTextBox.Name = "ServerTextBox"
        Me.ServerTextBox.PlaceholderText = ""
        Me.ServerTextBox.SelectedText = ""
        Me.ServerTextBox.Size = New System.Drawing.Size(271, 36)
        Me.ServerTextBox.TabIndex = 6
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(24, 85)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(66, 18)
        Me.Guna2HtmlLabel2.TabIndex = 4
        Me.Guna2HtmlLabel2.Text = "Username"
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(24, 217)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.Guna2CheckBox1.TabIndex = 38
        Me.Guna2CheckBox1.Text = "Show password"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UsernameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.UsernameTextBox.BorderRadius = 10
        Me.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox.DefaultText = ""
        Me.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTextBox.Location = New System.Drawing.Point(27, 109)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PlaceholderText = ""
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.Size = New System.Drawing.Size(271, 36)
        Me.UsernameTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PasswordTextBox.BorderColor = System.Drawing.Color.Gray
        Me.PasswordTextBox.BorderRadius = 10
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.DefaultText = ""
        Me.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.Location = New System.Drawing.Point(27, 175)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PlaceholderText = ""
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.Size = New System.Drawing.Size(271, 36)
        Me.PasswordTextBox.TabIndex = 1
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(24, 151)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(63, 18)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Password"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Button2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TestButton, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 315)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(318, 49)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 15
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(183, 7)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(132, 35)
        Me.Guna2Button2.TabIndex = 5
        Me.Guna2Button2.Text = "Next"
        '
        'TestButton
        '
        Me.TestButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TestButton.BackColor = System.Drawing.Color.Transparent
        Me.TestButton.BorderRadius = 15
        Me.TestButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.TestButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.TestButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.TestButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TestButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.TestButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TestButton.ForeColor = System.Drawing.Color.White
        Me.TestButton.Location = New System.Drawing.Point(24, 7)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(132, 35)
        Me.TestButton.TabIndex = 4
        Me.TestButton.Text = "Test"
        '
        'Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 368)
        Me.Controls.Add(Me.ServerLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Server"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server"
        Me.ServerLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ServerLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UsernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TestButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ServerTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
End Class
