<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PricingDialog
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UpdatePricetButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CostPriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SellingPriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProductTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Cost Price"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(301, 260)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdatePricetButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 205)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(301, 55)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'UpdatePricetButton
        '
        Me.UpdatePricetButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UpdatePricetButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdatePricetButton.BorderRadius = 15
        Me.UpdatePricetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdatePricetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdatePricetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdatePricetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdatePricetButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.UpdatePricetButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UpdatePricetButton.ForeColor = System.Drawing.Color.White
        Me.UpdatePricetButton.Location = New System.Drawing.Point(163, 8)
        Me.UpdatePricetButton.Margin = New System.Windows.Forms.Padding(3, 8, 10, 3)
        Me.UpdatePricetButton.Name = "UpdatePricetButton"
        Me.UpdatePricetButton.Size = New System.Drawing.Size(128, 37)
        Me.UpdatePricetButton.TabIndex = 5
        Me.UpdatePricetButton.Text = "Update"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.CostPriceTextBox)
        Me.Guna2Panel1.Controls.Add(Me.SellingPriceTextBox)
        Me.Guna2Panel1.Controls.Add(Me.ProductTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(301, 205)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Selling Price"
        '
        'CostPriceTextBox
        '
        Me.CostPriceTextBox.BorderColor = System.Drawing.Color.Gray
        Me.CostPriceTextBox.BorderRadius = 10
        Me.CostPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CostPriceTextBox.DefaultText = ""
        Me.CostPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CostPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CostPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CostPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostPriceTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CostPriceTextBox.ForeColor = System.Drawing.Color.Black
        Me.CostPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostPriceTextBox.Location = New System.Drawing.Point(25, 148)
        Me.CostPriceTextBox.MaxLength = 7
        Me.CostPriceTextBox.Name = "CostPriceTextBox"
        Me.CostPriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CostPriceTextBox.PlaceholderText = ""
        Me.CostPriceTextBox.ReadOnly = True
        Me.CostPriceTextBox.SelectedText = ""
        Me.CostPriceTextBox.ShortcutsEnabled = False
        Me.CostPriceTextBox.Size = New System.Drawing.Size(248, 36)
        Me.CostPriceTextBox.TabIndex = 8
        '
        'SellingPriceTextBox
        '
        Me.SellingPriceTextBox.BorderColor = System.Drawing.Color.Gray
        Me.SellingPriceTextBox.BorderRadius = 10
        Me.SellingPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SellingPriceTextBox.DefaultText = ""
        Me.SellingPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SellingPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SellingPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SellingPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SellingPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SellingPriceTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SellingPriceTextBox.ForeColor = System.Drawing.Color.Black
        Me.SellingPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SellingPriceTextBox.Location = New System.Drawing.Point(25, 91)
        Me.SellingPriceTextBox.MaxLength = 7
        Me.SellingPriceTextBox.Name = "SellingPriceTextBox"
        Me.SellingPriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SellingPriceTextBox.PlaceholderText = ""
        Me.SellingPriceTextBox.SelectedText = ""
        Me.SellingPriceTextBox.ShortcutsEnabled = False
        Me.SellingPriceTextBox.Size = New System.Drawing.Size(248, 36)
        Me.SellingPriceTextBox.TabIndex = 4
        '
        'ProductTextBox
        '
        Me.ProductTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ProductTextBox.BorderRadius = 10
        Me.ProductTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductTextBox.DefaultText = ""
        Me.ProductTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProductTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProductTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProductTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProductTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductTextBox.Location = New System.Drawing.Point(25, 36)
        Me.ProductTextBox.MaxLength = 100
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductTextBox.PlaceholderText = ""
        Me.ProductTextBox.ReadOnly = True
        Me.ProductTextBox.SelectedText = ""
        Me.ProductTextBox.ShortcutsEnabled = False
        Me.ProductTextBox.Size = New System.Drawing.Size(248, 36)
        Me.ProductTextBox.TabIndex = 3
        '
        'PricingDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 260)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PricingDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pricing Dialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UpdatePricetButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CostPriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SellingPriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProductTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
