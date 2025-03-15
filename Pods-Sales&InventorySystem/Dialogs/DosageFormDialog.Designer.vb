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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DosageFormDialog))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DosageFormTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddDosageFormButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'DescriptionTextBox
        '
        resources.ApplyResources(Me.DescriptionTextBox, "DescriptionTextBox")
        Me.DescriptionTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DescriptionTextBox.BorderRadius = 10
        Me.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescriptionTextBox.DefaultText = ""
        Me.DescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.ForeColor = System.Drawing.Color.Black
        Me.DescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.MaxLength = 50
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescriptionTextBox.PlaceholderText = ""
        Me.DescriptionTextBox.SelectedText = ""
        Me.DescriptionTextBox.ShortcutsEnabled = False
        '
        'DosageFormTextBox
        '
        resources.ApplyResources(Me.DosageFormTextBox, "DosageFormTextBox")
        Me.DosageFormTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DosageFormTextBox.BorderRadius = 10
        Me.DosageFormTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DosageFormTextBox.DefaultText = ""
        Me.DosageFormTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DosageFormTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DosageFormTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DosageFormTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DosageFormTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DosageFormTextBox.ForeColor = System.Drawing.Color.Black
        Me.DosageFormTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DosageFormTextBox.MaxLength = 25
        Me.DosageFormTextBox.Name = "DosageFormTextBox"
        Me.DosageFormTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DosageFormTextBox.PlaceholderText = "Ex, Tablet, Capsule, Etc"
        Me.DosageFormTextBox.SelectedText = ""
        Me.DosageFormTextBox.ShortcutsEnabled = False
        '
        'AddDosageFormButton
        '
        resources.ApplyResources(Me.AddDosageFormButton, "AddDosageFormButton")
        Me.AddDosageFormButton.BackColor = System.Drawing.Color.Transparent
        Me.AddDosageFormButton.BorderRadius = 15
        Me.AddDosageFormButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddDosageFormButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddDosageFormButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddDosageFormButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddDosageFormButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddDosageFormButton.ForeColor = System.Drawing.Color.White
        Me.AddDosageFormButton.Name = "AddDosageFormButton"
        '
        'DosageFormDialog
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DescriptionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DosageFormTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddDosageFormButton As Guna.UI2.WinForms.Guna2Button
End Class
