﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryProductDialog
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddDeliveryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.SubcategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.QuantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CostTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BarcodeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProductComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.AccountDialogLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.AccountDialogLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel2.Controls.Add(Me.AddDeliveryButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 220)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(497, 55)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'AddDeliveryButton
        '
        Me.AddDeliveryButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddDeliveryButton.BackColor = System.Drawing.Color.Transparent
        Me.AddDeliveryButton.BorderRadius = 15
        Me.AddDeliveryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddDeliveryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddDeliveryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddDeliveryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddDeliveryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddDeliveryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddDeliveryButton.ForeColor = System.Drawing.Color.White
        Me.AddDeliveryButton.Location = New System.Drawing.Point(366, 8)
        Me.AddDeliveryButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddDeliveryButton.Name = "AddDeliveryButton"
        Me.AddDeliveryButton.Size = New System.Drawing.Size(128, 37)
        Me.AddDeliveryButton.TabIndex = 3
        Me.AddDeliveryButton.Text = "Add"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2ToggleSwitch1)
        Me.Guna2Panel1.Controls.Add(Me.SubcategoryComboBox)
        Me.Guna2Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Guna2Panel1.Controls.Add(Me.QuantityTextBox)
        Me.Guna2Panel1.Controls.Add(Me.CostTextBox)
        Me.Guna2Panel1.Controls.Add(Me.BarcodeTextBox)
        Me.Guna2Panel1.Controls.Add(Me.ProductComboBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(497, 220)
        Me.Guna2Panel1.TabIndex = 9
        '
        'Guna2ToggleSwitch1
        '
        Me.Guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.Location = New System.Drawing.Point(226, 74)
        Me.Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1"
        Me.Guna2ToggleSwitch1.Size = New System.Drawing.Size(35, 20)
        Me.Guna2ToggleSwitch1.TabIndex = 10
        Me.Guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'SubcategoryComboBox
        '
        Me.SubcategoryComboBox.BackColor = System.Drawing.Color.Transparent
        Me.SubcategoryComboBox.BorderColor = System.Drawing.Color.Gray
        Me.SubcategoryComboBox.BorderRadius = 10
        Me.SubcategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SubcategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubcategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubcategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubcategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SubcategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SubcategoryComboBox.ItemHeight = 30
        Me.SubcategoryComboBox.Location = New System.Drawing.Point(268, 23)
        Me.SubcategoryComboBox.Name = "SubcategoryComboBox"
        Me.SubcategoryComboBox.Size = New System.Drawing.Size(200, 36)
        Me.SubcategoryComboBox.TabIndex = 6
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.BackColor = System.Drawing.Color.Transparent
        Me.CategoryComboBox.BorderColor = System.Drawing.Color.Gray
        Me.CategoryComboBox.BorderRadius = 10
        Me.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CategoryComboBox.ItemHeight = 30
        Me.CategoryComboBox.Location = New System.Drawing.Point(20, 23)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(200, 36)
        Me.CategoryComboBox.TabIndex = 5
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
        Me.QuantityTextBox.Location = New System.Drawing.Point(268, 107)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTextBox.PlaceholderText = "Quantity"
        Me.QuantityTextBox.SelectedText = ""
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 36)
        Me.QuantityTextBox.TabIndex = 4
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
        Me.CostTextBox.Location = New System.Drawing.Point(20, 107)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CostTextBox.PlaceholderText = "Cost"
        Me.CostTextBox.SelectedText = ""
        Me.CostTextBox.Size = New System.Drawing.Size(200, 36)
        Me.CostTextBox.TabIndex = 3
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
        Me.BarcodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(268, 65)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BarcodeTextBox.PlaceholderText = "Barcode"
        Me.BarcodeTextBox.SelectedText = ""
        Me.BarcodeTextBox.Size = New System.Drawing.Size(200, 36)
        Me.BarcodeTextBox.TabIndex = 2
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
        Me.ProductComboBox.Location = New System.Drawing.Point(20, 65)
        Me.ProductComboBox.Name = "ProductComboBox"
        Me.ProductComboBox.Size = New System.Drawing.Size(200, 36)
        Me.ProductComboBox.TabIndex = 1
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
        Me.AccountDialogLayoutPanel.Size = New System.Drawing.Size(497, 275)
        Me.AccountDialogLayoutPanel.TabIndex = 19
        '
        'DeliveryProductDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 275)
        Me.Controls.Add(Me.AccountDialogLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeliveryProductDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delivery Product Dialog"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.AccountDialogLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents AddDeliveryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents AccountDialogLayoutPanel As TableLayoutPanel
    Friend WithEvents CostTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BarcodeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProductComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents QuantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SubcategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
