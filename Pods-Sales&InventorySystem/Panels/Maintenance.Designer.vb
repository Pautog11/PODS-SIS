<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maintenance
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MaintenaceTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Accounts = New System.Windows.Forms.TabPage()
        Me.Account1 = New Pods_Sales_InventorySystem.Account()
        Me.Categories = New System.Windows.Forms.TabPage()
        Me.Category1 = New Pods_Sales_InventorySystem.Category()
        Me.SubCategory = New System.Windows.Forms.TabPage()
        Me.SubCategory1 = New Pods_Sales_InventorySystem.SubCategory()
        Me.Suppliers = New System.Windows.Forms.TabPage()
        Me.Supplier1 = New Pods_Sales_InventorySystem.Supplier()
        Me.Deliveries = New System.Windows.Forms.TabPage()
        Me.Delivery1 = New Pods_Sales_InventorySystem.Delivery()
        Me.MaintenaceTabControl.SuspendLayout()
        Me.Accounts.SuspendLayout()
        Me.Categories.SuspendLayout()
        Me.SubCategory.SuspendLayout()
        Me.Suppliers.SuspendLayout()
        Me.Deliveries.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaintenaceTabControl
        '
        Me.MaintenaceTabControl.Controls.Add(Me.Accounts)
        Me.MaintenaceTabControl.Controls.Add(Me.Categories)
        Me.MaintenaceTabControl.Controls.Add(Me.SubCategory)
        Me.MaintenaceTabControl.Controls.Add(Me.Suppliers)
        Me.MaintenaceTabControl.Controls.Add(Me.Deliveries)
        Me.MaintenaceTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaintenaceTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.MaintenaceTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MaintenaceTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.MaintenaceTabControl.Name = "MaintenaceTabControl"
        Me.MaintenaceTabControl.SelectedIndex = 0
        Me.MaintenaceTabControl.Size = New System.Drawing.Size(907, 580)
        Me.MaintenaceTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.MaintenaceTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MaintenaceTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.MaintenaceTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.MaintenaceTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MaintenaceTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.MaintenaceTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.MaintenaceTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.MaintenaceTabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MaintenaceTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.MaintenaceTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.MaintenaceTabControl.TabIndex = 0
        Me.MaintenaceTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.MaintenaceTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Accounts
        '
        Me.Accounts.Controls.Add(Me.Account1)
        Me.Accounts.Location = New System.Drawing.Point(4, 44)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(899, 532)
        Me.Accounts.TabIndex = 6
        Me.Accounts.Text = "Accounts"
        Me.Accounts.UseVisualStyleBackColor = True
        '
        'Account1
        '
        Me.Account1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Account1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Account1.Location = New System.Drawing.Point(0, 0)
        Me.Account1.Name = "Account1"
        Me.Account1.Size = New System.Drawing.Size(899, 532)
        Me.Account1.TabIndex = 0
        '
        'Categories
        '
        Me.Categories.Controls.Add(Me.Category1)
        Me.Categories.Location = New System.Drawing.Point(4, 44)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(899, 532)
        Me.Categories.TabIndex = 7
        Me.Categories.Text = "Categories"
        Me.Categories.UseVisualStyleBackColor = True
        '
        'Category1
        '
        Me.Category1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Category1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Category1.Location = New System.Drawing.Point(0, 0)
        Me.Category1.Name = "Category1"
        Me.Category1.Size = New System.Drawing.Size(899, 532)
        Me.Category1.TabIndex = 0
        '
        'SubCategory
        '
        Me.SubCategory.Controls.Add(Me.SubCategory1)
        Me.SubCategory.Location = New System.Drawing.Point(4, 44)
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.Size = New System.Drawing.Size(899, 532)
        Me.SubCategory.TabIndex = 3
        Me.SubCategory.Text = "Sub Categories"
        Me.SubCategory.UseVisualStyleBackColor = True
        '
        'SubCategory1
        '
        Me.SubCategory1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubCategory1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubCategory1.Location = New System.Drawing.Point(0, 0)
        Me.SubCategory1.Margin = New System.Windows.Forms.Padding(0)
        Me.SubCategory1.Name = "SubCategory1"
        Me.SubCategory1.Size = New System.Drawing.Size(899, 532)
        Me.SubCategory1.TabIndex = 0
        '
        'Suppliers
        '
        Me.Suppliers.Controls.Add(Me.Supplier1)
        Me.Suppliers.Location = New System.Drawing.Point(4, 44)
        Me.Suppliers.Name = "Suppliers"
        Me.Suppliers.Size = New System.Drawing.Size(899, 532)
        Me.Suppliers.TabIndex = 4
        Me.Suppliers.Text = "Suppliers"
        Me.Suppliers.UseVisualStyleBackColor = True
        '
        'Supplier1
        '
        Me.Supplier1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Supplier1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Supplier1.Location = New System.Drawing.Point(0, 0)
        Me.Supplier1.Margin = New System.Windows.Forms.Padding(0)
        Me.Supplier1.Name = "Supplier1"
        Me.Supplier1.Size = New System.Drawing.Size(899, 532)
        Me.Supplier1.TabIndex = 0
        '
        'Deliveries
        '
        Me.Deliveries.Controls.Add(Me.Delivery1)
        Me.Deliveries.Location = New System.Drawing.Point(4, 44)
        Me.Deliveries.Name = "Deliveries"
        Me.Deliveries.Size = New System.Drawing.Size(899, 532)
        Me.Deliveries.TabIndex = 5
        Me.Deliveries.Text = "Deliveries"
        Me.Deliveries.UseVisualStyleBackColor = True
        '
        'Delivery1
        '
        Me.Delivery1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Delivery1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Delivery1.Location = New System.Drawing.Point(0, 0)
        Me.Delivery1.Margin = New System.Windows.Forms.Padding(0)
        Me.Delivery1.Name = "Delivery1"
        Me.Delivery1.Size = New System.Drawing.Size(899, 532)
        Me.Delivery1.TabIndex = 0
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MaintenaceTabControl)
        Me.Name = "Maintenance"
        Me.Size = New System.Drawing.Size(907, 580)
        Me.MaintenaceTabControl.ResumeLayout(False)
        Me.Accounts.ResumeLayout(False)
        Me.Categories.ResumeLayout(False)
        Me.SubCategory.ResumeLayout(False)
        Me.Suppliers.ResumeLayout(False)
        Me.Deliveries.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaintenaceTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents SubCategory As TabPage
    Friend WithEvents Suppliers As TabPage
    Friend WithEvents Supplier1 As Supplier
    Friend WithEvents Deliveries As TabPage
    Friend WithEvents Delivery1 As Delivery
    Friend WithEvents SubCategory1 As SubCategory
    Friend WithEvents Accounts As TabPage
    Friend WithEvents Account1 As Account
    Friend WithEvents Categories As TabPage
    Friend WithEvents Category1 As Category
End Class
