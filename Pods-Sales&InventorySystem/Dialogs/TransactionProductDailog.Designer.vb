﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionProductDailog
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
        Me.QuantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddTransactionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.StocksTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.BarcodeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProductNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VoidButton = New Guna.UI2.WinForms.Guna2Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.QuantityTextBox.ForeColor = System.Drawing.Color.Black
        Me.QuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTextBox.Location = New System.Drawing.Point(27, 269)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTextBox.PlaceholderText = "0"
        Me.QuantityTextBox.SelectedText = ""
        Me.QuantityTextBox.ShortcutsEnabled = False
        Me.QuantityTextBox.Size = New System.Drawing.Size(255, 36)
        Me.QuantityTextBox.TabIndex = 13
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BorderColor = System.Drawing.Color.Gray
        Me.PriceTextBox.BorderRadius = 10
        Me.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceTextBox.DefaultText = ""
        Me.PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PriceTextBox.ForeColor = System.Drawing.Color.Black
        Me.PriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTextBox.Location = New System.Drawing.Point(27, 159)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceTextBox.PlaceholderText = "0.00"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.SelectedText = ""
        Me.PriceTextBox.ShortcutsEnabled = False
        Me.PriceTextBox.Size = New System.Drawing.Size(255, 36)
        Me.PriceTextBox.TabIndex = 12
        '
        'AddTransactionButton
        '
        Me.AddTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddTransactionButton.BackColor = System.Drawing.Color.Transparent
        Me.AddTransactionButton.BorderRadius = 15
        Me.AddTransactionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddTransactionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddTransactionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddTransactionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddTransactionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddTransactionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddTransactionButton.ForeColor = System.Drawing.Color.White
        Me.AddTransactionButton.Location = New System.Drawing.Point(163, 7)
        Me.AddTransactionButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.AddTransactionButton.Name = "AddTransactionButton"
        Me.AddTransactionButton.Size = New System.Drawing.Size(150, 35)
        Me.AddTransactionButton.TabIndex = 16
        Me.AddTransactionButton.Text = "Add"
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
        Me.StocksTextBox.ForeColor = System.Drawing.Color.Black
        Me.StocksTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StocksTextBox.Location = New System.Drawing.Point(27, 214)
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StocksTextBox.PlaceholderText = "0"
        Me.StocksTextBox.ReadOnly = True
        Me.StocksTextBox.SelectedText = ""
        Me.StocksTextBox.ShortcutsEnabled = False
        Me.StocksTextBox.Size = New System.Drawing.Size(255, 36)
        Me.StocksTextBox.TabIndex = 17
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(27, 75)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(255, 10)
        Me.Guna2Separator1.TabIndex = 19
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.BorderColor = System.Drawing.Color.Gray
        Me.BarcodeTextBox.BorderRadius = 10
        Me.BarcodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BarcodeTextBox.DefaultText = ""
        Me.BarcodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BarcodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BarcodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BarcodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BarcodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BarcodeTextBox.ForeColor = System.Drawing.Color.Black
        Me.BarcodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(27, 30)
        Me.BarcodeTextBox.MaxLength = 13
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BarcodeTextBox.PlaceholderText = "Scan Here"
        Me.BarcodeTextBox.SelectedText = ""
        Me.BarcodeTextBox.ShortcutsEnabled = False
        Me.BarcodeTextBox.Size = New System.Drawing.Size(255, 36)
        Me.BarcodeTextBox.TabIndex = 18
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.ProductNameTextBox.BorderRadius = 10
        Me.ProductNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductNameTextBox.DefaultText = ""
        Me.ProductNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProductNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProductNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProductNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProductNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(27, 104)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductNameTextBox.PlaceholderText = "Ex. (Biogesic)"
        Me.ProductNameTextBox.ReadOnly = True
        Me.ProductNameTextBox.SelectedText = ""
        Me.ProductNameTextBox.ShortcutsEnabled = False
        Me.ProductNameTextBox.Size = New System.Drawing.Size(255, 36)
        Me.ProductNameTextBox.TabIndex = 21
        '
        'VoidButton
        '
        Me.VoidButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.VoidButton.BackColor = System.Drawing.Color.Transparent
        Me.VoidButton.BorderRadius = 15
        Me.VoidButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.VoidButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.VoidButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.VoidButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.VoidButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.VoidButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VoidButton.ForeColor = System.Drawing.Color.White
        Me.VoidButton.Location = New System.Drawing.Point(7, 7)
        Me.VoidButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.VoidButton.Name = "VoidButton"
        Me.VoidButton.Size = New System.Drawing.Size(150, 35)
        Me.VoidButton.TabIndex = 22
        Me.VoidButton.Text = "Void"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.AddTransactionButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.VoidButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 322)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(316, 51)
        Me.FlowLayoutPanel1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Barcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Stocks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Quantity"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(144, 71)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(15, 18)
        Me.Guna2HtmlLabel1.TabIndex = 29
        Me.Guna2HtmlLabel1.Text = "or"
        '
        'TransactionProductDailog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 373)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.BarcodeTextBox)
        Me.Controls.Add(Me.StocksTextBox)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransactionProductDailog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction Dailog"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddTransactionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents StocksTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BarcodeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProductNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VoidButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
