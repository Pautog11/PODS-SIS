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
        Me.ReturnandPulloutTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Category = New System.Windows.Forms.TabPage()
        Me.Category1 = New Pods_Sales_InventorySystem.Category()
        Me.Subcategory = New System.Windows.Forms.TabPage()
        Me.SubCategory1 = New Pods_Sales_InventorySystem.SubCategory()
        Me.Suppliers = New System.Windows.Forms.TabPage()
        Me.SupplierTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Company = New System.Windows.Forms.TabPage()
        Me.Supplier1 = New Pods_Sales_InventorySystem.Supplier()
        Me.Vendor = New System.Windows.Forms.TabPage()
        Me.Vendor1 = New Pods_Sales_InventorySystem.Vendor()
        Me.Vat = New System.Windows.Forms.TabPage()
        Me.Vat1 = New Pods_Sales_InventorySystem.Vat()
        Me.Discounts = New System.Windows.Forms.TabPage()
        Me.Discount1 = New Pods_Sales_InventorySystem.Discount()
        Me.Return_Code = New System.Windows.Forms.TabPage()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.supplier_return_code = New System.Windows.Forms.TabPage()
        Me.ReturnCode1 = New Pods_Sales_InventorySystem.ReturnCode()
        Me.customer_return_code = New System.Windows.Forms.TabPage()
        Me.CustomerReturnCode1 = New Pods_Sales_InventorySystem.CustomerReturnCode()
        Me.disposal_code = New System.Windows.Forms.TabPage()
        Me.Medicine = New System.Windows.Forms.TabPage()
        Me.Guna2TabControl2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Oum = New System.Windows.Forms.TabPage()
        Me.Dosage1 = New Pods_Sales_InventorySystem.Dosage()
        Me.DosageForm = New System.Windows.Forms.TabPage()
        Me.DosageForm1 = New Pods_Sales_InventorySystem.DosageForm()
        Me.Pricing = New System.Windows.Forms.TabPage()
        Me.Pricing1 = New Pods_Sales_InventorySystem.Pricing()
        Me.DisposalReasonCode1 = New Pods_Sales_InventorySystem.DisposalReasonCode()
        Me.MaintenaceTabControl.SuspendLayout()
        Me.Accounts.SuspendLayout()
        Me.Categories.SuspendLayout()
        Me.ReturnandPulloutTabControl.SuspendLayout()
        Me.Category.SuspendLayout()
        Me.Subcategory.SuspendLayout()
        Me.Suppliers.SuspendLayout()
        Me.SupplierTabControl.SuspendLayout()
        Me.Company.SuspendLayout()
        Me.Vendor.SuspendLayout()
        Me.Vat.SuspendLayout()
        Me.Discounts.SuspendLayout()
        Me.Return_Code.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.supplier_return_code.SuspendLayout()
        Me.customer_return_code.SuspendLayout()
        Me.disposal_code.SuspendLayout()
        Me.Medicine.SuspendLayout()
        Me.Guna2TabControl2.SuspendLayout()
        Me.Oum.SuspendLayout()
        Me.DosageForm.SuspendLayout()
        Me.Pricing.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaintenaceTabControl
        '
        Me.MaintenaceTabControl.Controls.Add(Me.Accounts)
        Me.MaintenaceTabControl.Controls.Add(Me.Categories)
        Me.MaintenaceTabControl.Controls.Add(Me.Suppliers)
        Me.MaintenaceTabControl.Controls.Add(Me.Vat)
        Me.MaintenaceTabControl.Controls.Add(Me.Discounts)
        Me.MaintenaceTabControl.Controls.Add(Me.Return_Code)
        Me.MaintenaceTabControl.Controls.Add(Me.Medicine)
        Me.MaintenaceTabControl.Controls.Add(Me.Pricing)
        Me.MaintenaceTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaintenaceTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.MaintenaceTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MaintenaceTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.MaintenaceTabControl.Name = "MaintenaceTabControl"
        Me.MaintenaceTabControl.SelectedIndex = 0
        Me.MaintenaceTabControl.Size = New System.Drawing.Size(1294, 758)
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
        Me.Accounts.BackColor = System.Drawing.Color.White
        Me.Accounts.Controls.Add(Me.Account1)
        Me.Accounts.Location = New System.Drawing.Point(4, 84)
        Me.Accounts.Margin = New System.Windows.Forms.Padding(0)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(1286, 670)
        Me.Accounts.TabIndex = 12
        Me.Accounts.Text = "Accounts"
        '
        'Account1
        '
        Me.Account1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Account1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Account1.Location = New System.Drawing.Point(0, 0)
        Me.Account1.Margin = New System.Windows.Forms.Padding(0)
        Me.Account1.Name = "Account1"
        Me.Account1.Size = New System.Drawing.Size(1286, 670)
        Me.Account1.TabIndex = 0
        '
        'Categories
        '
        Me.Categories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Categories.Controls.Add(Me.ReturnandPulloutTabControl)
        Me.Categories.Location = New System.Drawing.Point(4, 84)
        Me.Categories.Margin = New System.Windows.Forms.Padding(0)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(1286, 670)
        Me.Categories.TabIndex = 7
        Me.Categories.Text = "Categorization"
        Me.Categories.UseVisualStyleBackColor = True
        '
        'ReturnandPulloutTabControl
        '
        Me.ReturnandPulloutTabControl.Controls.Add(Me.Category)
        Me.ReturnandPulloutTabControl.Controls.Add(Me.Subcategory)
        Me.ReturnandPulloutTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReturnandPulloutTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.ReturnandPulloutTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ReturnandPulloutTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.ReturnandPulloutTabControl.Name = "ReturnandPulloutTabControl"
        Me.ReturnandPulloutTabControl.SelectedIndex = 0
        Me.ReturnandPulloutTabControl.Size = New System.Drawing.Size(1284, 668)
        Me.ReturnandPulloutTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.ReturnandPulloutTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ReturnandPulloutTabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.ReturnandPulloutTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.ReturnandPulloutTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ReturnandPulloutTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.ReturnandPulloutTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ReturnandPulloutTabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.ReturnandPulloutTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.ReturnandPulloutTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ReturnandPulloutTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.ReturnandPulloutTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.ReturnandPulloutTabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.ReturnandPulloutTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.ReturnandPulloutTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ReturnandPulloutTabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.ReturnandPulloutTabControl.TabIndex = 2
        Me.ReturnandPulloutTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ReturnandPulloutTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Category
        '
        Me.Category.Controls.Add(Me.Category1)
        Me.Category.Location = New System.Drawing.Point(4, 44)
        Me.Category.Margin = New System.Windows.Forms.Padding(0)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(1276, 620)
        Me.Category.TabIndex = 6
        Me.Category.Text = "Categories"
        Me.Category.UseVisualStyleBackColor = True
        '
        'Category1
        '
        Me.Category1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Category1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Category1.Location = New System.Drawing.Point(0, 0)
        Me.Category1.Margin = New System.Windows.Forms.Padding(0)
        Me.Category1.Name = "Category1"
        Me.Category1.Size = New System.Drawing.Size(1276, 620)
        Me.Category1.TabIndex = 0
        '
        'Subcategory
        '
        Me.Subcategory.Controls.Add(Me.SubCategory1)
        Me.Subcategory.Location = New System.Drawing.Point(4, 44)
        Me.Subcategory.Margin = New System.Windows.Forms.Padding(0)
        Me.Subcategory.Name = "Subcategory"
        Me.Subcategory.Size = New System.Drawing.Size(1276, 620)
        Me.Subcategory.TabIndex = 7
        Me.Subcategory.Text = "Subcategories"
        Me.Subcategory.UseVisualStyleBackColor = True
        '
        'SubCategory1
        '
        Me.SubCategory1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubCategory1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubCategory1.Location = New System.Drawing.Point(0, 0)
        Me.SubCategory1.Margin = New System.Windows.Forms.Padding(0)
        Me.SubCategory1.Name = "SubCategory1"
        Me.SubCategory1.Size = New System.Drawing.Size(1276, 620)
        Me.SubCategory1.TabIndex = 0
        '
        'Suppliers
        '
        Me.Suppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Suppliers.Controls.Add(Me.SupplierTabControl)
        Me.Suppliers.Location = New System.Drawing.Point(4, 84)
        Me.Suppliers.Margin = New System.Windows.Forms.Padding(0)
        Me.Suppliers.Name = "Suppliers"
        Me.Suppliers.Size = New System.Drawing.Size(1286, 670)
        Me.Suppliers.TabIndex = 4
        Me.Suppliers.Text = "Suppliers"
        Me.Suppliers.UseVisualStyleBackColor = True
        '
        'SupplierTabControl
        '
        Me.SupplierTabControl.Controls.Add(Me.Company)
        Me.SupplierTabControl.Controls.Add(Me.Vendor)
        Me.SupplierTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.SupplierTabControl.Location = New System.Drawing.Point(0, 0)
        Me.SupplierTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.SupplierTabControl.Name = "SupplierTabControl"
        Me.SupplierTabControl.SelectedIndex = 0
        Me.SupplierTabControl.Size = New System.Drawing.Size(1284, 668)
        Me.SupplierTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.SupplierTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SupplierTabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.SupplierTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.SupplierTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SupplierTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.SupplierTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SupplierTabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.SupplierTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.SupplierTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SupplierTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.SupplierTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.SupplierTabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.SupplierTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.SupplierTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SupplierTabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.SupplierTabControl.TabIndex = 2
        Me.SupplierTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.SupplierTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Company
        '
        Me.Company.Controls.Add(Me.Supplier1)
        Me.Company.Location = New System.Drawing.Point(4, 44)
        Me.Company.Margin = New System.Windows.Forms.Padding(0)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(1276, 620)
        Me.Company.TabIndex = 6
        Me.Company.Text = "Company"
        Me.Company.UseVisualStyleBackColor = True
        '
        'Supplier1
        '
        Me.Supplier1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Supplier1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Supplier1.Location = New System.Drawing.Point(0, 0)
        Me.Supplier1.Margin = New System.Windows.Forms.Padding(0)
        Me.Supplier1.Name = "Supplier1"
        Me.Supplier1.Size = New System.Drawing.Size(1276, 620)
        Me.Supplier1.TabIndex = 0
        '
        'Vendor
        '
        Me.Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vendor.Controls.Add(Me.Vendor1)
        Me.Vendor.Location = New System.Drawing.Point(4, 44)
        Me.Vendor.Margin = New System.Windows.Forms.Padding(0)
        Me.Vendor.Name = "Vendor"
        Me.Vendor.Size = New System.Drawing.Size(1276, 620)
        Me.Vendor.TabIndex = 7
        Me.Vendor.Text = "Vendor"
        Me.Vendor.UseVisualStyleBackColor = True
        '
        'Vendor1
        '
        Me.Vendor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vendor1.Location = New System.Drawing.Point(0, 0)
        Me.Vendor1.Margin = New System.Windows.Forms.Padding(0)
        Me.Vendor1.Name = "Vendor1"
        Me.Vendor1.Size = New System.Drawing.Size(1274, 618)
        Me.Vendor1.TabIndex = 0
        '
        'Vat
        '
        Me.Vat.Controls.Add(Me.Vat1)
        Me.Vat.Location = New System.Drawing.Point(4, 84)
        Me.Vat.Name = "Vat"
        Me.Vat.Size = New System.Drawing.Size(1286, 670)
        Me.Vat.TabIndex = 8
        Me.Vat.Text = "Vat"
        Me.Vat.UseVisualStyleBackColor = True
        '
        'Vat1
        '
        Me.Vat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vat1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vat1.Location = New System.Drawing.Point(0, 0)
        Me.Vat1.Name = "Vat1"
        Me.Vat1.Size = New System.Drawing.Size(1286, 670)
        Me.Vat1.TabIndex = 0
        '
        'Discounts
        '
        Me.Discounts.Controls.Add(Me.Discount1)
        Me.Discounts.Location = New System.Drawing.Point(4, 84)
        Me.Discounts.Name = "Discounts"
        Me.Discounts.Size = New System.Drawing.Size(1286, 670)
        Me.Discounts.TabIndex = 9
        Me.Discounts.Text = "Discounts"
        Me.Discounts.UseVisualStyleBackColor = True
        '
        'Discount1
        '
        Me.Discount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Discount1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Discount1.Location = New System.Drawing.Point(0, 0)
        Me.Discount1.Name = "Discount1"
        Me.Discount1.Size = New System.Drawing.Size(1286, 670)
        Me.Discount1.TabIndex = 0
        '
        'Return_Code
        '
        Me.Return_Code.BackColor = System.Drawing.Color.White
        Me.Return_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Return_Code.Controls.Add(Me.Guna2TabControl1)
        Me.Return_Code.Location = New System.Drawing.Point(4, 84)
        Me.Return_Code.Margin = New System.Windows.Forms.Padding(0)
        Me.Return_Code.Name = "Return_Code"
        Me.Return_Code.Size = New System.Drawing.Size(1286, 670)
        Me.Return_Code.TabIndex = 13
        Me.Return_Code.Text = "Return Code"
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.supplier_return_code)
        Me.Guna2TabControl1.Controls.Add(Me.customer_return_code)
        Me.Guna2TabControl1.Controls.Add(Me.disposal_code)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1284, 668)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 2
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'supplier_return_code
        '
        Me.supplier_return_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.supplier_return_code.Controls.Add(Me.ReturnCode1)
        Me.supplier_return_code.Location = New System.Drawing.Point(4, 44)
        Me.supplier_return_code.Margin = New System.Windows.Forms.Padding(0)
        Me.supplier_return_code.Name = "supplier_return_code"
        Me.supplier_return_code.Size = New System.Drawing.Size(1276, 620)
        Me.supplier_return_code.TabIndex = 7
        Me.supplier_return_code.Text = "Supplier Return Code"
        Me.supplier_return_code.UseVisualStyleBackColor = True
        '
        'ReturnCode1
        '
        Me.ReturnCode1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReturnCode1.Location = New System.Drawing.Point(0, 0)
        Me.ReturnCode1.Name = "ReturnCode1"
        Me.ReturnCode1.Size = New System.Drawing.Size(1274, 618)
        Me.ReturnCode1.TabIndex = 0
        '
        'customer_return_code
        '
        Me.customer_return_code.Controls.Add(Me.CustomerReturnCode1)
        Me.customer_return_code.Location = New System.Drawing.Point(4, 44)
        Me.customer_return_code.Margin = New System.Windows.Forms.Padding(0)
        Me.customer_return_code.Name = "customer_return_code"
        Me.customer_return_code.Size = New System.Drawing.Size(1276, 620)
        Me.customer_return_code.TabIndex = 6
        Me.customer_return_code.Text = "Customer Return Code"
        Me.customer_return_code.UseVisualStyleBackColor = True
        '
        'CustomerReturnCode1
        '
        Me.CustomerReturnCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerReturnCode1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerReturnCode1.Location = New System.Drawing.Point(0, 0)
        Me.CustomerReturnCode1.Name = "CustomerReturnCode1"
        Me.CustomerReturnCode1.Size = New System.Drawing.Size(1276, 620)
        Me.CustomerReturnCode1.TabIndex = 0
        '
        'disposal_code
        '
        Me.disposal_code.Controls.Add(Me.DisposalReasonCode1)
        Me.disposal_code.Location = New System.Drawing.Point(4, 44)
        Me.disposal_code.Margin = New System.Windows.Forms.Padding(0)
        Me.disposal_code.Name = "disposal_code"
        Me.disposal_code.Size = New System.Drawing.Size(1276, 620)
        Me.disposal_code.TabIndex = 8
        Me.disposal_code.Text = "Disposal Reason Code"
        Me.disposal_code.UseVisualStyleBackColor = True
        '
        'Medicine
        '
        Me.Medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Medicine.Controls.Add(Me.Guna2TabControl2)
        Me.Medicine.Location = New System.Drawing.Point(4, 84)
        Me.Medicine.Name = "Medicine"
        Me.Medicine.Size = New System.Drawing.Size(1286, 670)
        Me.Medicine.TabIndex = 14
        Me.Medicine.Text = "Concentration & Formulation"
        Me.Medicine.UseVisualStyleBackColor = True
        '
        'Guna2TabControl2
        '
        Me.Guna2TabControl2.Controls.Add(Me.Oum)
        Me.Guna2TabControl2.Controls.Add(Me.DosageForm)
        Me.Guna2TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl2.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2TabControl2.Name = "Guna2TabControl2"
        Me.Guna2TabControl2.SelectedIndex = 0
        Me.Guna2TabControl2.Size = New System.Drawing.Size(1284, 668)
        Me.Guna2TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl2.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2TabControl2.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl2.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2TabControl2.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl2.TabIndex = 1
        Me.Guna2TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Oum
        '
        Me.Oum.BackColor = System.Drawing.Color.White
        Me.Oum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Oum.Controls.Add(Me.Dosage1)
        Me.Oum.Location = New System.Drawing.Point(4, 44)
        Me.Oum.Margin = New System.Windows.Forms.Padding(0)
        Me.Oum.Name = "Oum"
        Me.Oum.Size = New System.Drawing.Size(1276, 620)
        Me.Oum.TabIndex = 12
        Me.Oum.Text = "Unit of Measurements"
        '
        'Dosage1
        '
        Me.Dosage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dosage1.Location = New System.Drawing.Point(0, 0)
        Me.Dosage1.Name = "Dosage1"
        Me.Dosage1.Size = New System.Drawing.Size(1274, 618)
        Me.Dosage1.TabIndex = 0
        '
        'DosageForm
        '
        Me.DosageForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DosageForm.Controls.Add(Me.DosageForm1)
        Me.DosageForm.Location = New System.Drawing.Point(4, 44)
        Me.DosageForm.Margin = New System.Windows.Forms.Padding(0)
        Me.DosageForm.Name = "DosageForm"
        Me.DosageForm.Size = New System.Drawing.Size(1276, 620)
        Me.DosageForm.TabIndex = 7
        Me.DosageForm.Text = "Dosage Form"
        Me.DosageForm.UseVisualStyleBackColor = True
        '
        'DosageForm1
        '
        Me.DosageForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DosageForm1.Location = New System.Drawing.Point(0, 0)
        Me.DosageForm1.Name = "DosageForm1"
        Me.DosageForm1.Size = New System.Drawing.Size(1274, 618)
        Me.DosageForm1.TabIndex = 0
        '
        'Pricing
        '
        Me.Pricing.Controls.Add(Me.Pricing1)
        Me.Pricing.Location = New System.Drawing.Point(4, 84)
        Me.Pricing.Name = "Pricing"
        Me.Pricing.Size = New System.Drawing.Size(1286, 670)
        Me.Pricing.TabIndex = 15
        Me.Pricing.Text = "Pricing Adjustment"
        Me.Pricing.UseVisualStyleBackColor = True
        '
        'Pricing1
        '
        Me.Pricing1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pricing1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pricing1.Location = New System.Drawing.Point(0, 0)
        Me.Pricing1.Name = "Pricing1"
        Me.Pricing1.Size = New System.Drawing.Size(1286, 670)
        Me.Pricing1.TabIndex = 0
        '
        'DisposalReasonCode1
        '
        Me.DisposalReasonCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisposalReasonCode1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisposalReasonCode1.Location = New System.Drawing.Point(0, 0)
        Me.DisposalReasonCode1.Margin = New System.Windows.Forms.Padding(0)
        Me.DisposalReasonCode1.Name = "DisposalReasonCode1"
        Me.DisposalReasonCode1.Size = New System.Drawing.Size(1276, 620)
        Me.DisposalReasonCode1.TabIndex = 0
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaintenaceTabControl)
        Me.Name = "Maintenance"
        Me.Size = New System.Drawing.Size(1294, 758)
        Me.MaintenaceTabControl.ResumeLayout(False)
        Me.Accounts.ResumeLayout(False)
        Me.Categories.ResumeLayout(False)
        Me.ReturnandPulloutTabControl.ResumeLayout(False)
        Me.Category.ResumeLayout(False)
        Me.Subcategory.ResumeLayout(False)
        Me.Suppliers.ResumeLayout(False)
        Me.SupplierTabControl.ResumeLayout(False)
        Me.Company.ResumeLayout(False)
        Me.Vendor.ResumeLayout(False)
        Me.Vat.ResumeLayout(False)
        Me.Discounts.ResumeLayout(False)
        Me.Return_Code.ResumeLayout(False)
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.supplier_return_code.ResumeLayout(False)
        Me.customer_return_code.ResumeLayout(False)
        Me.disposal_code.ResumeLayout(False)
        Me.Medicine.ResumeLayout(False)
        Me.Guna2TabControl2.ResumeLayout(False)
        Me.Oum.ResumeLayout(False)
        Me.DosageForm.ResumeLayout(False)
        Me.Pricing.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaintenaceTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Suppliers As TabPage
    Friend WithEvents Categories As TabPage
    Friend WithEvents Vat As TabPage
    Friend WithEvents Discounts As TabPage
    Private WithEvents Vat1 As Vat
    Friend WithEvents Discount1 As Discount
    Friend WithEvents Accounts As TabPage
    Friend WithEvents Account1 As Account
    Friend WithEvents Return_Code As TabPage
    Friend WithEvents ReturnandPulloutTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Category As TabPage
    Friend WithEvents Subcategory As TabPage
    Friend WithEvents Category1 As Category
    Friend WithEvents SubCategory1 As SubCategory
    Friend WithEvents SupplierTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Company As TabPage
    Friend WithEvents Vendor As TabPage
    Friend WithEvents Supplier1 As Supplier
    Friend WithEvents Vendor1 As Vendor
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents customer_return_code As TabPage
    Friend WithEvents supplier_return_code As TabPage
    Friend WithEvents ReturnCode1 As ReturnCode
    Friend WithEvents CustomerReturnCode1 As CustomerReturnCode
    Friend WithEvents Medicine As TabPage
    Friend WithEvents Guna2TabControl2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Oum As TabPage
    Friend WithEvents DosageForm As TabPage
    Friend WithEvents Dosage1 As Dosage
    Friend WithEvents DosageForm1 As DosageForm
    Friend WithEvents Pricing As TabPage
    Friend WithEvents Pricing1 As Pricing
    Friend WithEvents disposal_code As TabPage
    Friend WithEvents DisposalReasonCode1 As DisposalReasonCode
End Class
