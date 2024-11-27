<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DosageFormDialog
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DosageFormTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddDosageFormButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Description (Optional)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dosage Form"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DescriptionTextBox.BorderRadius = 10
        Me.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescriptionTextBox.DefaultText = ""
        Me.DescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(97, 114)
        Me.DescriptionTextBox.MaxLength = 50
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescriptionTextBox.PlaceholderText = ""
        Me.DescriptionTextBox.SelectedText = ""
        Me.DescriptionTextBox.ShortcutsEnabled = False
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 36)
        Me.DescriptionTextBox.TabIndex = 5
        '
        'DosageFormTextBox
        '
        Me.DosageFormTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DosageFormTextBox.BorderRadius = 10
        Me.DosageFormTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DosageFormTextBox.DefaultText = ""
        Me.DosageFormTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DosageFormTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DosageFormTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DosageFormTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DosageFormTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DosageFormTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DosageFormTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DosageFormTextBox.Location = New System.Drawing.Point(97, 50)
        Me.DosageFormTextBox.MaxLength = 25
        Me.DosageFormTextBox.Name = "DosageFormTextBox"
        Me.DosageFormTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DosageFormTextBox.PlaceholderText = "Ex, Tablet, Capsule, Etc"
        Me.DosageFormTextBox.SelectedText = ""
        Me.DosageFormTextBox.ShortcutsEnabled = False
        Me.DosageFormTextBox.Size = New System.Drawing.Size(200, 36)
        Me.DosageFormTextBox.TabIndex = 4
        '
        'AddDosageFormButton
        '
        Me.AddDosageFormButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddDosageFormButton.BackColor = System.Drawing.Color.Transparent
        Me.AddDosageFormButton.BorderRadius = 15
        Me.AddDosageFormButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddDosageFormButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddDosageFormButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddDosageFormButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddDosageFormButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddDosageFormButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddDosageFormButton.ForeColor = System.Drawing.Color.White
        Me.AddDosageFormButton.Location = New System.Drawing.Point(251, 206)
        Me.AddDosageFormButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddDosageFormButton.Name = "AddDosageFormButton"
        Me.AddDosageFormButton.Size = New System.Drawing.Size(128, 37)
        Me.AddDosageFormButton.TabIndex = 8
        Me.AddDosageFormButton.Text = "Add"
        '
        'DosageFormDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 255)
        Me.Controls.Add(Me.AddDosageFormButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.DosageFormTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DosageFormDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DosageFormDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DescriptionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DosageFormTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddDosageFormButton As Guna.UI2.WinForms.Guna2Button
End Class
