<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountDialog
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
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UsernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.IdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RoleComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StatusComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.FirstnameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LastnameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Phone_numberTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddressTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteAccountButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddAccountButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AccountDialogLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.AccountDialogLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.DefaultText = ""
        Me.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.Location = New System.Drawing.Point(4, 45)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextBox.PlaceholderText = "Password"
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.Size = New System.Drawing.Size(173, 36)
        Me.PasswordTextBox.TabIndex = 5
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.UsernameTextBox)
        Me.FlowLayoutPanel3.Controls.Add(Me.PasswordTextBox)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(558, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(180, 298)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox.DefaultText = ""
        Me.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTextBox.Location = New System.Drawing.Point(4, 3)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.PlaceholderText = "Username"
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.Size = New System.Drawing.Size(173, 36)
        Me.UsernameTextBox.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.IdTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.RoleComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.StatusComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.FirstnameTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.LastnameTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Phone_numberTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddressTextBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(188, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(179, 298)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'IdTextBox
        '
        Me.IdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdTextBox.DefaultText = ""
        Me.IdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdTextBox.Location = New System.Drawing.Point(3, 3)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdTextBox.PlaceholderText = "Id"
        Me.IdTextBox.SelectedText = ""
        Me.IdTextBox.Size = New System.Drawing.Size(173, 36)
        Me.IdTextBox.TabIndex = 6
        '
        'RoleComboBox
        '
        Me.RoleComboBox.BackColor = System.Drawing.Color.Transparent
        Me.RoleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoleComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RoleComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.RoleComboBox.ItemHeight = 30
        Me.RoleComboBox.Location = New System.Drawing.Point(3, 45)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(173, 36)
        Me.RoleComboBox.TabIndex = 0
        '
        'StatusComboBox
        '
        Me.StatusComboBox.BackColor = System.Drawing.Color.Transparent
        Me.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StatusComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.StatusComboBox.ItemHeight = 30
        Me.StatusComboBox.Location = New System.Drawing.Point(3, 87)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(173, 36)
        Me.StatusComboBox.TabIndex = 7
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstnameTextBox.DefaultText = ""
        Me.FirstnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstnameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FirstnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(3, 129)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstnameTextBox.PlaceholderText = "Firstname"
        Me.FirstnameTextBox.SelectedText = ""
        Me.FirstnameTextBox.Size = New System.Drawing.Size(173, 36)
        Me.FirstnameTextBox.TabIndex = 1
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastnameTextBox.DefaultText = ""
        Me.LastnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastnameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LastnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastnameTextBox.Location = New System.Drawing.Point(3, 171)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastnameTextBox.PlaceholderText = "Lastname"
        Me.LastnameTextBox.SelectedText = ""
        Me.LastnameTextBox.Size = New System.Drawing.Size(173, 36)
        Me.LastnameTextBox.TabIndex = 3
        '
        'Phone_numberTextBox
        '
        Me.Phone_numberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Phone_numberTextBox.DefaultText = ""
        Me.Phone_numberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Phone_numberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Phone_numberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Phone_numberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Phone_numberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Phone_numberTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Phone_numberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Phone_numberTextBox.Location = New System.Drawing.Point(3, 213)
        Me.Phone_numberTextBox.Name = "Phone_numberTextBox"
        Me.Phone_numberTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Phone_numberTextBox.PlaceholderText = "Phone_number"
        Me.Phone_numberTextBox.SelectedText = ""
        Me.Phone_numberTextBox.Size = New System.Drawing.Size(173, 36)
        Me.Phone_numberTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressTextBox.DefaultText = ""
        Me.AddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTextBox.Location = New System.Drawing.Point(3, 255)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddressTextBox.PlaceholderText = "Address"
        Me.AddressTextBox.SelectedText = ""
        Me.AddressTextBox.Size = New System.Drawing.Size(173, 36)
        Me.AddressTextBox.TabIndex = 4
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel2.Controls.Add(Me.DeleteAccountButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.AddAccountButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 310)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(747, 55)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'DeleteAccountButton
        '
        Me.DeleteAccountButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteAccountButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteAccountButton.BorderRadius = 15
        Me.DeleteAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteAccountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteAccountButton.ForeColor = System.Drawing.Color.White
        Me.DeleteAccountButton.Location = New System.Drawing.Point(616, 9)
        Me.DeleteAccountButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.DeleteAccountButton.Name = "DeleteAccountButton"
        Me.DeleteAccountButton.Size = New System.Drawing.Size(128, 35)
        Me.DeleteAccountButton.TabIndex = 4
        Me.DeleteAccountButton.Text = "Delete"
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
        Me.AddAccountButton.Location = New System.Drawing.Point(482, 8)
        Me.AddAccountButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddAccountButton.Name = "AddAccountButton"
        Me.AddAccountButton.Size = New System.Drawing.Size(128, 37)
        Me.AddAccountButton.TabIndex = 3
        Me.AddAccountButton.Text = "Add"
        '
        'AccountDialogLayoutPanel
        '
        Me.AccountDialogLayoutPanel.ColumnCount = 1
        Me.AccountDialogLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountDialogLayoutPanel.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.AccountDialogLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.AccountDialogLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountDialogLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AccountDialogLayoutPanel.Name = "AccountDialogLayoutPanel"
        Me.AccountDialogLayoutPanel.RowCount = 2
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.AccountDialogLayoutPanel.Size = New System.Drawing.Size(747, 365)
        Me.AccountDialogLayoutPanel.TabIndex = 18
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(741, 304)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'AccountDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 365)
        Me.Controls.Add(Me.AccountDialogLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Account Dialog"
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.AccountDialogLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents UsernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents IdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RoleComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents StatusComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents FirstnameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LastnameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Phone_numberTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddressTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents DeleteAccountButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddAccountButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AccountDialogLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
