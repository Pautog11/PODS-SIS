﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteAccountButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddAccountButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ChangePassButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AccountDialogLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.RoleComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.StatusComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.FirstnameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LastnameLabel = New System.Windows.Forms.Label()
        Me.LastnameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PhonenumberLabel = New System.Windows.Forms.Label()
        Me.Phone_numberTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password2TextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.AccountDialogLayoutPanel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel2.Controls.Add(Me.DeleteAccountButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.AddAccountButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.ChangePassButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 299)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(495, 55)
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
        Me.DeleteAccountButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeleteAccountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteAccountButton.ForeColor = System.Drawing.Color.White
        Me.DeleteAccountButton.Location = New System.Drawing.Point(364, 9)
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
        Me.AddAccountButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddAccountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddAccountButton.ForeColor = System.Drawing.Color.White
        Me.AddAccountButton.Location = New System.Drawing.Point(230, 8)
        Me.AddAccountButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddAccountButton.Name = "AddAccountButton"
        Me.AddAccountButton.Size = New System.Drawing.Size(128, 37)
        Me.AddAccountButton.TabIndex = 3
        Me.AddAccountButton.Text = "Add"
        '
        'ChangePassButton
        '
        Me.ChangePassButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ChangePassButton.BackColor = System.Drawing.Color.Transparent
        Me.ChangePassButton.BorderRadius = 15
        Me.ChangePassButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ChangePassButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ChangePassButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ChangePassButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ChangePassButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ChangePassButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChangePassButton.ForeColor = System.Drawing.Color.White
        Me.ChangePassButton.Location = New System.Drawing.Point(96, 8)
        Me.ChangePassButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.ChangePassButton.Name = "ChangePassButton"
        Me.ChangePassButton.Size = New System.Drawing.Size(128, 37)
        Me.ChangePassButton.TabIndex = 5
        Me.ChangePassButton.Text = "Change Password"
        '
        'AccountDialogLayoutPanel
        '
        Me.AccountDialogLayoutPanel.ColumnCount = 1
        Me.AccountDialogLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountDialogLayoutPanel.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.AccountDialogLayoutPanel.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.AccountDialogLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountDialogLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AccountDialogLayoutPanel.Name = "AccountDialogLayoutPanel"
        Me.AccountDialogLayoutPanel.RowCount = 2
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.AccountDialogLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.AccountDialogLayoutPanel.Size = New System.Drawing.Size(495, 354)
        Me.AccountDialogLayoutPanel.TabIndex = 18
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.Guna2Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(495, 299)
        Me.Guna2Panel1.TabIndex = 9
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.RoleLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.RoleComboBox)
        Me.FlowLayoutPanel3.Controls.Add(Me.StatusLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.StatusComboBox)
        Me.FlowLayoutPanel3.Controls.Add(Me.FirstnameLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.FirstnameTextBox)
        Me.FlowLayoutPanel3.Controls.Add(Me.LastnameLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.LastnameTextBox)
        Me.FlowLayoutPanel3.Controls.Add(Me.PhonenumberLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.Phone_numberTextBox)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(229, 294)
        Me.FlowLayoutPanel3.TabIndex = 25
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Location = New System.Drawing.Point(3, 0)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(29, 13)
        Me.RoleLabel.TabIndex = 43
        Me.RoleLabel.Text = "Role"
        '
        'RoleComboBox
        '
        Me.RoleComboBox.BackColor = System.Drawing.Color.Transparent
        Me.RoleComboBox.BorderColor = System.Drawing.Color.Gray
        Me.RoleComboBox.BorderRadius = 10
        Me.RoleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RoleComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RoleComboBox.ForeColor = System.Drawing.Color.Black
        Me.RoleComboBox.ItemHeight = 30
        Me.RoleComboBox.Location = New System.Drawing.Point(3, 16)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(206, 36)
        Me.RoleComboBox.TabIndex = 22
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(3, 55)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(37, 13)
        Me.StatusLabel.TabIndex = 43
        Me.StatusLabel.Text = "Status"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.BackColor = System.Drawing.Color.Transparent
        Me.StatusComboBox.BorderColor = System.Drawing.Color.Gray
        Me.StatusComboBox.BorderRadius = 10
        Me.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StatusComboBox.ForeColor = System.Drawing.Color.Black
        Me.StatusComboBox.ItemHeight = 30
        Me.StatusComboBox.Location = New System.Drawing.Point(3, 71)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(206, 36)
        Me.StatusComboBox.TabIndex = 27
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Location = New System.Drawing.Point(3, 110)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(52, 13)
        Me.FirstnameLabel.TabIndex = 43
        Me.FirstnameLabel.Text = "Firstname"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.FirstnameTextBox.BorderRadius = 10
        Me.FirstnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstnameTextBox.DefaultText = ""
        Me.FirstnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstnameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FirstnameTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(3, 126)
        Me.FirstnameTextBox.MaxLength = 50
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstnameTextBox.PlaceholderText = "Juan"
        Me.FirstnameTextBox.SelectedText = ""
        Me.FirstnameTextBox.ShortcutsEnabled = False
        Me.FirstnameTextBox.Size = New System.Drawing.Size(206, 36)
        Me.FirstnameTextBox.TabIndex = 23
        '
        'LastnameLabel
        '
        Me.LastnameLabel.AutoSize = True
        Me.LastnameLabel.Location = New System.Drawing.Point(3, 165)
        Me.LastnameLabel.Name = "LastnameLabel"
        Me.LastnameLabel.Size = New System.Drawing.Size(53, 13)
        Me.LastnameLabel.TabIndex = 43
        Me.LastnameLabel.Text = "Lastname"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.LastnameTextBox.BorderRadius = 10
        Me.LastnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastnameTextBox.DefaultText = ""
        Me.LastnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastnameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LastnameTextBox.ForeColor = System.Drawing.Color.Black
        Me.LastnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastnameTextBox.Location = New System.Drawing.Point(3, 181)
        Me.LastnameTextBox.MaxLength = 50
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastnameTextBox.PlaceholderText = "Dela Cruz"
        Me.LastnameTextBox.SelectedText = ""
        Me.LastnameTextBox.ShortcutsEnabled = False
        Me.LastnameTextBox.Size = New System.Drawing.Size(206, 36)
        Me.LastnameTextBox.TabIndex = 24
        '
        'PhonenumberLabel
        '
        Me.PhonenumberLabel.AutoSize = True
        Me.PhonenumberLabel.Location = New System.Drawing.Point(3, 220)
        Me.PhonenumberLabel.Name = "PhonenumberLabel"
        Me.PhonenumberLabel.Size = New System.Drawing.Size(78, 13)
        Me.PhonenumberLabel.TabIndex = 43
        Me.PhonenumberLabel.Text = "Phone Number"
        '
        'Phone_numberTextBox
        '
        Me.Phone_numberTextBox.BorderColor = System.Drawing.Color.Gray
        Me.Phone_numberTextBox.BorderRadius = 10
        Me.Phone_numberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Phone_numberTextBox.DefaultText = ""
        Me.Phone_numberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Phone_numberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Phone_numberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Phone_numberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Phone_numberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Phone_numberTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Phone_numberTextBox.ForeColor = System.Drawing.Color.Black
        Me.Phone_numberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Phone_numberTextBox.Location = New System.Drawing.Point(3, 236)
        Me.Phone_numberTextBox.MaxLength = 13
        Me.Phone_numberTextBox.Name = "Phone_numberTextBox"
        Me.Phone_numberTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Phone_numberTextBox.PlaceholderText = "09** *** ****"
        Me.Phone_numberTextBox.SelectedText = ""
        Me.Phone_numberTextBox.ShortcutsEnabled = False
        Me.Phone_numberTextBox.Size = New System.Drawing.Size(206, 36)
        Me.Phone_numberTextBox.TabIndex = 25
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.AddressLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddressTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.UsernameTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.PasswordLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.PasswordTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Password2TextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2CheckBox1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(261, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(219, 294)
        Me.FlowLayoutPanel1.TabIndex = 24
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(3, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 44
        Me.AddressLabel.Text = "Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BorderColor = System.Drawing.Color.Gray
        Me.AddressTextBox.BorderRadius = 10
        Me.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressTextBox.DefaultText = ""
        Me.AddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddressTextBox.ForeColor = System.Drawing.Color.Black
        Me.AddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTextBox.Location = New System.Drawing.Point(3, 16)
        Me.AddressTextBox.MaxLength = 150
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddressTextBox.PlaceholderText = ""
        Me.AddressTextBox.SelectedText = ""
        Me.AddressTextBox.ShortcutsEnabled = False
        Me.AddressTextBox.Size = New System.Drawing.Size(206, 64)
        Me.AddressTextBox.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Username"
        '
        'UsernameTextBox
        '
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
        Me.UsernameTextBox.Location = New System.Drawing.Point(3, 99)
        Me.UsernameTextBox.MaxLength = 20
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.PlaceholderText = "Juan"
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.ShortcutsEnabled = False
        Me.UsernameTextBox.Size = New System.Drawing.Size(206, 36)
        Me.UsernameTextBox.TabIndex = 22
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(3, 138)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 41
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordTextBox
        '
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
        Me.PasswordTextBox.Location = New System.Drawing.Point(3, 154)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextBox.PlaceholderText = ""
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.ShortcutsEnabled = False
        Me.PasswordTextBox.Size = New System.Drawing.Size(206, 36)
        Me.PasswordTextBox.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Retype pasword"
        '
        'Password2TextBox
        '
        Me.Password2TextBox.BorderColor = System.Drawing.Color.Gray
        Me.Password2TextBox.BorderRadius = 10
        Me.Password2TextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password2TextBox.DefaultText = ""
        Me.Password2TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password2TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password2TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password2TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password2TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password2TextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password2TextBox.ForeColor = System.Drawing.Color.Black
        Me.Password2TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password2TextBox.Location = New System.Drawing.Point(3, 209)
        Me.Password2TextBox.Name = "Password2TextBox"
        Me.Password2TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password2TextBox.PlaceholderText = ""
        Me.Password2TextBox.SelectedText = ""
        Me.Password2TextBox.ShortcutsEnabled = False
        Me.Password2TextBox.Size = New System.Drawing.Size(206, 36)
        Me.Password2TextBox.TabIndex = 24
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(3, 251)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.Guna2CheckBox1.TabIndex = 39
        Me.Guna2CheckBox1.Text = "Show password"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'AccountDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 354)
        Me.Controls.Add(Me.AccountDialogLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Dialog"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.AccountDialogLayoutPanel.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents DeleteAccountButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddAccountButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AccountDialogLayoutPanel As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UsernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents RoleComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents StatusComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents FirstnameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LastnameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Phone_numberTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ChangePassButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Password2TextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents RoleLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents FirstnameLabel As Label
    Friend WithEvents LastnameLabel As Label
    Friend WithEvents PhonenumberLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AddressTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
