<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VatDialog
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
        Me.VatTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddAccountButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'VatTextBox
        '
        Me.VatTextBox.BorderColor = System.Drawing.Color.Gray
        Me.VatTextBox.BorderRadius = 10
        Me.VatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VatTextBox.DefaultText = ""
        Me.VatTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VatTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VatTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VatTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VatTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VatTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VatTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VatTextBox.Location = New System.Drawing.Point(59, 59)
        Me.VatTextBox.Name = "VatTextBox"
        Me.VatTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VatTextBox.PlaceholderText = "Vat"
        Me.VatTextBox.SelectedText = ""
        Me.VatTextBox.Size = New System.Drawing.Size(173, 36)
        Me.VatTextBox.TabIndex = 23
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
        Me.AddAccountButton.Location = New System.Drawing.Point(159, 179)
        Me.AddAccountButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddAccountButton.Name = "AddAccountButton"
        Me.AddAccountButton.Size = New System.Drawing.Size(128, 37)
        Me.AddAccountButton.TabIndex = 24
        Me.AddAccountButton.Text = "Update"
        '
        'VatDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 228)
        Me.Controls.Add(Me.AddAccountButton)
        Me.Controls.Add(Me.VatTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VatDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "VatDialog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VatTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddAccountButton As Guna.UI2.WinForms.Guna2Button
End Class
