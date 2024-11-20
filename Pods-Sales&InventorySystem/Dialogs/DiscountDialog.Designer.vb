<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountDialog
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
        Me.AddDiscountButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DiscountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddDiscountButton
        '
        Me.AddDiscountButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddDiscountButton.BackColor = System.Drawing.Color.Transparent
        Me.AddDiscountButton.BorderRadius = 15
        Me.AddDiscountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddDiscountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddDiscountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddDiscountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddDiscountButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddDiscountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddDiscountButton.ForeColor = System.Drawing.Color.White
        Me.AddDiscountButton.Location = New System.Drawing.Point(163, 125)
        Me.AddDiscountButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddDiscountButton.Name = "AddDiscountButton"
        Me.AddDiscountButton.Size = New System.Drawing.Size(128, 37)
        Me.AddDiscountButton.TabIndex = 6
        Me.AddDiscountButton.Text = "Add"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DiscountTextBox.BorderRadius = 10
        Me.DiscountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DiscountTextBox.DefaultText = ""
        Me.DiscountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DiscountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DiscountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DiscountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.Location = New System.Drawing.Point(54, 60)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DiscountTextBox.PlaceholderText = "0"
        Me.DiscountTextBox.SelectedText = ""
        Me.DiscountTextBox.Size = New System.Drawing.Size(200, 36)
        Me.DiscountTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Discount %"
        '
        'DiscountDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 176)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.AddDiscountButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiscountDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DiscountDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddDiscountButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DiscountTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
