<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PullOutProductDialog
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
        Me.ProductComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StocksTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.QuantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PullOutProductSaveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ExdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CostTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'ProductComboBox
        '
        Me.ProductComboBox.BackColor = System.Drawing.Color.Transparent
        Me.ProductComboBox.BorderColor = System.Drawing.Color.Gray
        Me.ProductComboBox.BorderRadius = 10
        Me.ProductComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ProductComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ProductComboBox.ItemHeight = 30
        Me.ProductComboBox.Location = New System.Drawing.Point(41, 12)
        Me.ProductComboBox.Name = "ProductComboBox"
        Me.ProductComboBox.Size = New System.Drawing.Size(200, 36)
        Me.ProductComboBox.TabIndex = 6
        '
        'StocksTextBox
        '
        Me.StocksTextBox.BorderColor = System.Drawing.Color.Gray
        Me.StocksTextBox.BorderRadius = 10
        Me.StocksTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StocksTextBox.DefaultText = ""
        Me.StocksTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StocksTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StocksTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StocksTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StocksTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StocksTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StocksTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StocksTextBox.Location = New System.Drawing.Point(41, 142)
        Me.StocksTextBox.MaxLength = 4
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StocksTextBox.PlaceholderText = "Stocks"
        Me.StocksTextBox.SelectedText = ""
        Me.StocksTextBox.Size = New System.Drawing.Size(200, 36)
        Me.StocksTextBox.TabIndex = 13
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.BorderColor = System.Drawing.Color.Gray
        Me.QuantityTextBox.BorderRadius = 10
        Me.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityTextBox.DefaultText = ""
        Me.QuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.QuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTextBox.Location = New System.Drawing.Point(41, 184)
        Me.QuantityTextBox.MaxLength = 4
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTextBox.PlaceholderText = "Quantity"
        Me.QuantityTextBox.SelectedText = ""
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 36)
        Me.QuantityTextBox.TabIndex = 15
        '
        'PullOutProductSaveButton
        '
        Me.PullOutProductSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PullOutProductSaveButton.BackColor = System.Drawing.Color.Transparent
        Me.PullOutProductSaveButton.BorderRadius = 15
        Me.PullOutProductSaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PullOutProductSaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PullOutProductSaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PullOutProductSaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PullOutProductSaveButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.PullOutProductSaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PullOutProductSaveButton.ForeColor = System.Drawing.Color.White
        Me.PullOutProductSaveButton.Location = New System.Drawing.Point(127, 297)
        Me.PullOutProductSaveButton.Name = "PullOutProductSaveButton"
        Me.PullOutProductSaveButton.Size = New System.Drawing.Size(150, 35)
        Me.PullOutProductSaveButton.TabIndex = 16
        Me.PullOutProductSaveButton.Text = "Save"
        '
        'ExdTextBox
        '
        Me.ExdTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ExdTextBox.BorderRadius = 10
        Me.ExdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ExdTextBox.DefaultText = ""
        Me.ExdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ExdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ExdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ExdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ExdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExdTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExdTextBox.Location = New System.Drawing.Point(41, 56)
        Me.ExdTextBox.MaxLength = 4
        Me.ExdTextBox.Name = "ExdTextBox"
        Me.ExdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ExdTextBox.PlaceholderText = "Expiry date"
        Me.ExdTextBox.SelectedText = ""
        Me.ExdTextBox.Size = New System.Drawing.Size(200, 36)
        Me.ExdTextBox.TabIndex = 18
        '
        'CostTextBox
        '
        Me.CostTextBox.BorderColor = System.Drawing.Color.Gray
        Me.CostTextBox.BorderRadius = 10
        Me.CostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CostTextBox.DefaultText = ""
        Me.CostTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CostTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CostTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CostTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostTextBox.Location = New System.Drawing.Point(41, 98)
        Me.CostTextBox.MaxLength = 4
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CostTextBox.PlaceholderText = "Cost"
        Me.CostTextBox.SelectedText = ""
        Me.CostTextBox.Size = New System.Drawing.Size(200, 36)
        Me.CostTextBox.TabIndex = 19
        '
        'PullOutProductDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 344)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.ExdTextBox)
        Me.Controls.Add(Me.PullOutProductSaveButton)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.StocksTextBox)
        Me.Controls.Add(Me.ProductComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PullOutProductDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PullOutProductDialog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents StocksTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents QuantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PullOutProductSaveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CostTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
