<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorDialog
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
        Me.LastnameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddVendorButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CompanyComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContactTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LastnameTextBox.Location = New System.Drawing.Point(28, 147)
        Me.LastnameTextBox.MaxLength = 20
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastnameTextBox.PlaceholderText = "Ex. Dela Cruz"
        Me.LastnameTextBox.SelectedText = ""
        Me.LastnameTextBox.ShortcutsEnabled = False
        Me.LastnameTextBox.Size = New System.Drawing.Size(311, 36)
        Me.LastnameTextBox.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Lastname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Firstname"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.FirstNameTextBox.BorderRadius = 10
        Me.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTextBox.DefaultText = ""
        Me.FirstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(28, 92)
        Me.FirstNameTextBox.MaxLength = 20
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameTextBox.PlaceholderText = "Ex. Juan"
        Me.FirstNameTextBox.SelectedText = ""
        Me.FirstNameTextBox.ShortcutsEnabled = False
        Me.FirstNameTextBox.Size = New System.Drawing.Size(311, 36)
        Me.FirstNameTextBox.TabIndex = 34
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel2.Controls.Add(Me.AddVendorButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 270)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(376, 55)
        Me.FlowLayoutPanel2.TabIndex = 41
        '
        'AddVendorButton
        '
        Me.AddVendorButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddVendorButton.BackColor = System.Drawing.Color.Transparent
        Me.AddVendorButton.BorderRadius = 15
        Me.AddVendorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddVendorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddVendorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddVendorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddVendorButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddVendorButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddVendorButton.ForeColor = System.Drawing.Color.White
        Me.AddVendorButton.Location = New System.Drawing.Point(245, 8)
        Me.AddVendorButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddVendorButton.Name = "AddVendorButton"
        Me.AddVendorButton.Size = New System.Drawing.Size(128, 37)
        Me.AddVendorButton.TabIndex = 3
        Me.AddVendorButton.Text = "Add"
        '
        'CompanyComboBox
        '
        Me.CompanyComboBox.BackColor = System.Drawing.Color.Transparent
        Me.CompanyComboBox.BorderColor = System.Drawing.Color.Gray
        Me.CompanyComboBox.BorderRadius = 10
        Me.CompanyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompanyComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompanyComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompanyComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CompanyComboBox.ForeColor = System.Drawing.Color.Black
        Me.CompanyComboBox.ItemHeight = 30
        Me.CompanyComboBox.Location = New System.Drawing.Point(28, 34)
        Me.CompanyComboBox.Name = "CompanyComboBox"
        Me.CompanyComboBox.Size = New System.Drawing.Size(311, 36)
        Me.CompanyComboBox.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Company"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ContactTextBox.BorderRadius = 10
        Me.ContactTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContactTextBox.DefaultText = ""
        Me.ContactTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ContactTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ContactTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContactTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContactTextBox.ForeColor = System.Drawing.Color.Black
        Me.ContactTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContactTextBox.Location = New System.Drawing.Point(28, 205)
        Me.ContactTextBox.MaxLength = 13
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ContactTextBox.PlaceholderText = "Ex. 09** *** ****"
        Me.ContactTextBox.SelectedText = ""
        Me.ContactTextBox.ShortcutsEnabled = False
        Me.ContactTextBox.Size = New System.Drawing.Size(311, 36)
        Me.ContactTextBox.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Phone Number"
        '
        'VendorDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 325)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CompanyComboBox)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.LastnameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendorDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendor Dialog"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LastnameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents AddVendorButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CompanyComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContactTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
