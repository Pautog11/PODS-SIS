<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierDialog
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
        Me.CompanyNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CPTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FooterLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteSupplierButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddSupplierButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CompanyAddressTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FooterLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.CompanyNameTextBox.BorderRadius = 10
        Me.CompanyNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CompanyNameTextBox.DefaultText = ""
        Me.CompanyNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CompanyNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CompanyNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CompanyNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CompanyNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompanyNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CompanyNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.CompanyNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(24, 37)
        Me.CompanyNameTextBox.MaxLength = 50
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompanyNameTextBox.PlaceholderText = "Ex. Unilab"
        Me.CompanyNameTextBox.SelectedText = ""
        Me.CompanyNameTextBox.ShortcutsEnabled = False
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(311, 36)
        Me.CompanyNameTextBox.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.CompanyAddressTextBox)
        Me.Guna2Panel1.Controls.Add(Me.CheckBox)
        Me.Guna2Panel1.Controls.Add(Me.CPTextBox)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(362, 262)
        Me.Guna2Panel1.TabIndex = 7
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox.CheckedState.BorderRadius = 0
        Me.CheckBox.CheckedState.BorderThickness = 0
        Me.CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox.Location = New System.Drawing.Point(24, 226)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(194, 17)
        Me.CheckBox.TabIndex = 32
        Me.CheckBox.Text = "Supplier approves a refund request."
        Me.CheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBox.UncheckedState.BorderRadius = 0
        Me.CheckBox.UncheckedState.BorderThickness = 0
        Me.CheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CPTextBox
        '
        Me.CPTextBox.BorderColor = System.Drawing.Color.Gray
        Me.CPTextBox.BorderRadius = 10
        Me.CPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CPTextBox.DefaultText = ""
        Me.CPTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CPTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CPTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CPTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CPTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CPTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CPTextBox.ForeColor = System.Drawing.Color.Black
        Me.CPTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CPTextBox.Location = New System.Drawing.Point(24, 92)
        Me.CPTextBox.MaxLength = 13
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CPTextBox.PlaceholderText = "Ex. +012-345-6789"
        Me.CPTextBox.SelectedText = ""
        Me.CPTextBox.ShortcutsEnabled = False
        Me.CPTextBox.Size = New System.Drawing.Size(311, 36)
        Me.CPTextBox.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Telephone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Company Name"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FooterLayoutPanel, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(362, 317)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'FooterLayoutPanel
        '
        Me.FooterLayoutPanel.Controls.Add(Me.DeleteSupplierButton)
        Me.FooterLayoutPanel.Controls.Add(Me.AddSupplierButton)
        Me.FooterLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FooterLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FooterLayoutPanel.Location = New System.Drawing.Point(0, 262)
        Me.FooterLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.FooterLayoutPanel.Name = "FooterLayoutPanel"
        Me.FooterLayoutPanel.Size = New System.Drawing.Size(362, 55)
        Me.FooterLayoutPanel.TabIndex = 8
        '
        'DeleteSupplierButton
        '
        Me.DeleteSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteSupplierButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSupplierButton.BorderRadius = 15
        Me.DeleteSupplierButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteSupplierButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteSupplierButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteSupplierButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteSupplierButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeleteSupplierButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteSupplierButton.ForeColor = System.Drawing.Color.White
        Me.DeleteSupplierButton.Location = New System.Drawing.Point(231, 9)
        Me.DeleteSupplierButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.DeleteSupplierButton.Name = "DeleteSupplierButton"
        Me.DeleteSupplierButton.Size = New System.Drawing.Size(128, 35)
        Me.DeleteSupplierButton.TabIndex = 6
        Me.DeleteSupplierButton.Text = "Delete"
        '
        'AddSupplierButton
        '
        Me.AddSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddSupplierButton.BackColor = System.Drawing.Color.Transparent
        Me.AddSupplierButton.BorderRadius = 15
        Me.AddSupplierButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddSupplierButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddSupplierButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddSupplierButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddSupplierButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddSupplierButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddSupplierButton.ForeColor = System.Drawing.Color.White
        Me.AddSupplierButton.Location = New System.Drawing.Point(97, 8)
        Me.AddSupplierButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddSupplierButton.Name = "AddSupplierButton"
        Me.AddSupplierButton.Size = New System.Drawing.Size(128, 37)
        Me.AddSupplierButton.TabIndex = 5
        Me.AddSupplierButton.Text = "Add"
        '
        'CompanyAddressTextBox
        '
        Me.CompanyAddressTextBox.BorderColor = System.Drawing.Color.Gray
        Me.CompanyAddressTextBox.BorderRadius = 10
        Me.CompanyAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CompanyAddressTextBox.DefaultText = ""
        Me.CompanyAddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CompanyAddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CompanyAddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CompanyAddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CompanyAddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompanyAddressTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CompanyAddressTextBox.ForeColor = System.Drawing.Color.Black
        Me.CompanyAddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompanyAddressTextBox.Location = New System.Drawing.Point(24, 147)
        Me.CompanyAddressTextBox.MaxLength = 150
        Me.CompanyAddressTextBox.Multiline = True
        Me.CompanyAddressTextBox.Name = "CompanyAddressTextBox"
        Me.CompanyAddressTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompanyAddressTextBox.PlaceholderText = ""
        Me.CompanyAddressTextBox.SelectedText = ""
        Me.CompanyAddressTextBox.ShortcutsEnabled = False
        Me.CompanyAddressTextBox.Size = New System.Drawing.Size(311, 64)
        Me.CompanyAddressTextBox.TabIndex = 33
        '
        'SupplierDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 317)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SupplierDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Supplier Dialog"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FooterLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CompanyNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FooterLayoutPanel As FlowLayoutPanel
    Friend WithEvents DeleteSupplierButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddSupplierButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CPTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CompanyAddressTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
