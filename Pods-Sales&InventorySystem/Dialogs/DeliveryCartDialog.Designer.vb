<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeliveryCartDialog
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DeliveryDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SaveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AccountHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AddProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SupplierNameComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuppliersLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DeliveryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountHeaderLayoutPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.DeliveryDataGridView, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SaveButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AccountHeaderLayoutPanel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(637, 434)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'DeliveryDataGridView
        '
        Me.DeliveryDataGridView.AllowUserToAddRows = False
        Me.DeliveryDataGridView.AllowUserToDeleteRows = False
        Me.DeliveryDataGridView.AllowUserToResizeColumns = False
        Me.DeliveryDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeliveryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DeliveryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.product, Me.price, Me.quantity, Me.total})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DeliveryDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.DeliveryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliveryDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.Location = New System.Drawing.Point(3, 103)
        Me.DeliveryDataGridView.MultiSelect = False
        Me.DeliveryDataGridView.Name = "DeliveryDataGridView"
        Me.DeliveryDataGridView.ReadOnly = True
        Me.DeliveryDataGridView.RowHeadersVisible = False
        Me.DeliveryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DeliveryDataGridView.Size = New System.Drawing.Size(631, 278)
        Me.DeliveryDataGridView.TabIndex = 4
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DeliveryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DeliveryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DeliveryDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.DeliveryDataGridView.ThemeStyle.ReadOnly = True
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeliveryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.BorderRadius = 15
        Me.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(484, 391)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(150, 35)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        '
        'AccountHeaderLayoutPanel
        '
        Me.AccountHeaderLayoutPanel.ColumnCount = 2
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.AddProductButton, 1, 0)
        Me.AccountHeaderLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.AccountHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountHeaderLayoutPanel.Location = New System.Drawing.Point(3, 53)
        Me.AccountHeaderLayoutPanel.Name = "AccountHeaderLayoutPanel"
        Me.AccountHeaderLayoutPanel.RowCount = 1
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AccountHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.AccountHeaderLayoutPanel.Size = New System.Drawing.Size(631, 44)
        Me.AccountHeaderLayoutPanel.TabIndex = 0
        '
        'AddProductButton
        '
        Me.AddProductButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddProductButton.BackColor = System.Drawing.Color.Transparent
        Me.AddProductButton.BorderRadius = 15
        Me.AddProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddProductButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddProductButton.ForeColor = System.Drawing.Color.White
        Me.AddProductButton.Location = New System.Drawing.Point(478, 4)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(150, 35)
        Me.AddProductButton.TabIndex = 2
        Me.AddProductButton.Text = "Add"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SupplierNameComboBox)
        Me.Panel1.Controls.Add(Me.SuppliersLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 44)
        Me.Panel1.TabIndex = 3
        '
        'SupplierNameComboBox
        '
        Me.SupplierNameComboBox.BackColor = System.Drawing.Color.Transparent
        Me.SupplierNameComboBox.BorderRadius = 5
        Me.SupplierNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SupplierNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierNameComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierNameComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierNameComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SupplierNameComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SupplierNameComboBox.ItemHeight = 30
        Me.SupplierNameComboBox.Location = New System.Drawing.Point(137, 5)
        Me.SupplierNameComboBox.Name = "SupplierNameComboBox"
        Me.SupplierNameComboBox.Size = New System.Drawing.Size(140, 36)
        Me.SupplierNameComboBox.TabIndex = 1
        '
        'SuppliersLabel
        '
        Me.SuppliersLabel.BackColor = System.Drawing.Color.Transparent
        Me.SuppliersLabel.Location = New System.Drawing.Point(15, 15)
        Me.SuppliersLabel.Name = "SuppliersLabel"
        Me.SuppliersLabel.Size = New System.Drawing.Size(77, 15)
        Me.SuppliersLabel.TabIndex = 0
        Me.SuppliersLabel.Text = "Suppliers Name"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Guna2Panel1.Controls.Add(Me.TotalPrice)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(631, 44)
        Me.Guna2Panel1.TabIndex = 6
        '
        'TotalPrice
        '
        Me.TotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.TotalPrice.Location = New System.Drawing.Point(65, 14)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(9, 15)
        Me.TotalPrice.TabIndex = 2
        Me.TotalPrice.Text = "0"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, 14)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(27, 15)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Total"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(422, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'product
        '
        Me.product.HeaderText = "PRODUCT"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "PRICE"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "QUANTITY"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'DeliveryCartDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 434)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeliveryCartDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delivery Cart"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DeliveryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountHeaderLayoutPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DeliveryDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AccountHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents AddProductButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SupplierNameComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SuppliersLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
