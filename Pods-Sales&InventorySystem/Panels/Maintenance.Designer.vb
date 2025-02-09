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
        Me.Categories = New System.Windows.Forms.TabPage()
        Me.Category1 = New Pods_Sales_InventorySystem.Category()
        Me.SubCategory = New System.Windows.Forms.TabPage()
        Me.SubCategory1 = New Pods_Sales_InventorySystem.SubCategory()
        Me.Suppliers = New System.Windows.Forms.TabPage()
        Me.Supplier1 = New Pods_Sales_InventorySystem.Supplier()
        Me.Vat = New System.Windows.Forms.TabPage()
        Me.Vat1 = New Pods_Sales_InventorySystem.Vat()
        Me.Discounts = New System.Windows.Forms.TabPage()
        Me.Discount1 = New Pods_Sales_InventorySystem.Discount()
        Me.Dosage = New System.Windows.Forms.TabPage()
        Me.Dosage1 = New Pods_Sales_InventorySystem.Dosage()
        Me.Dosage_Form = New System.Windows.Forms.TabPage()
        Me.DosageForm1 = New Pods_Sales_InventorySystem.DosageForm()
        Me.Accounts = New System.Windows.Forms.TabPage()
        Me.Account1 = New Pods_Sales_InventorySystem.Account()
        Me.MaintenaceTabControl.SuspendLayout()
        Me.Categories.SuspendLayout()
        Me.SubCategory.SuspendLayout()
        Me.Suppliers.SuspendLayout()
        Me.Vat.SuspendLayout()
        Me.Discounts.SuspendLayout()
        Me.Dosage.SuspendLayout()
        Me.Dosage_Form.SuspendLayout()
        Me.Accounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaintenaceTabControl
        '
        Me.MaintenaceTabControl.Controls.Add(Me.Accounts)
        Me.MaintenaceTabControl.Controls.Add(Me.Categories)
        Me.MaintenaceTabControl.Controls.Add(Me.SubCategory)
        Me.MaintenaceTabControl.Controls.Add(Me.Suppliers)
        Me.MaintenaceTabControl.Controls.Add(Me.Vat)
        Me.MaintenaceTabControl.Controls.Add(Me.Discounts)
        Me.MaintenaceTabControl.Controls.Add(Me.Dosage)
        Me.MaintenaceTabControl.Controls.Add(Me.Dosage_Form)
        Me.MaintenaceTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaintenaceTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.MaintenaceTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MaintenaceTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.MaintenaceTabControl.Name = "MaintenaceTabControl"
        Me.MaintenaceTabControl.SelectedIndex = 0
        Me.MaintenaceTabControl.Size = New System.Drawing.Size(1315, 649)
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
        'Categories
        '
        Me.Categories.Controls.Add(Me.Category1)
        Me.Categories.Location = New System.Drawing.Point(4, 44)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(1307, 601)
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
        Me.Category1.Size = New System.Drawing.Size(1307, 601)
        Me.Category1.TabIndex = 0
        '
        'SubCategory
        '
        Me.SubCategory.Controls.Add(Me.SubCategory1)
        Me.SubCategory.Location = New System.Drawing.Point(4, 44)
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.Size = New System.Drawing.Size(1307, 601)
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
        Me.SubCategory1.Size = New System.Drawing.Size(1307, 601)
        Me.SubCategory1.TabIndex = 0
        '
        'Suppliers
        '
        Me.Suppliers.Controls.Add(Me.Supplier1)
        Me.Suppliers.Location = New System.Drawing.Point(4, 44)
        Me.Suppliers.Name = "Suppliers"
        Me.Suppliers.Size = New System.Drawing.Size(1307, 601)
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
        Me.Supplier1.Size = New System.Drawing.Size(1307, 601)
        Me.Supplier1.TabIndex = 0
        '
        'Vat
        '
        Me.Vat.Controls.Add(Me.Vat1)
        Me.Vat.Location = New System.Drawing.Point(4, 44)
        Me.Vat.Name = "Vat"
        Me.Vat.Size = New System.Drawing.Size(1307, 601)
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
        Me.Vat1.Size = New System.Drawing.Size(1307, 601)
        Me.Vat1.TabIndex = 0
        '
        'Discounts
        '
        Me.Discounts.Controls.Add(Me.Discount1)
        Me.Discounts.Location = New System.Drawing.Point(4, 44)
        Me.Discounts.Name = "Discounts"
        Me.Discounts.Size = New System.Drawing.Size(1307, 601)
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
        Me.Discount1.Size = New System.Drawing.Size(1307, 601)
        Me.Discount1.TabIndex = 0
        '
        'Dosage
        '
        Me.Dosage.Controls.Add(Me.Dosage1)
        Me.Dosage.Location = New System.Drawing.Point(4, 84)
        Me.Dosage.Margin = New System.Windows.Forms.Padding(0)
        Me.Dosage.Name = "Dosage"
        Me.Dosage.Size = New System.Drawing.Size(1307, 561)
        Me.Dosage.TabIndex = 10
        Me.Dosage.Text = "Dosage"
        Me.Dosage.UseVisualStyleBackColor = True
        '
        'Dosage1
        '
        Me.Dosage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dosage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dosage1.Location = New System.Drawing.Point(0, 0)
        Me.Dosage1.Margin = New System.Windows.Forms.Padding(0)
        Me.Dosage1.Name = "Dosage1"
        Me.Dosage1.Size = New System.Drawing.Size(1307, 561)
        Me.Dosage1.TabIndex = 0
        '
        'Dosage_Form
        '
        Me.Dosage_Form.Controls.Add(Me.DosageForm1)
        Me.Dosage_Form.Location = New System.Drawing.Point(4, 84)
        Me.Dosage_Form.Name = "Dosage_Form"
        Me.Dosage_Form.Size = New System.Drawing.Size(1307, 561)
        Me.Dosage_Form.TabIndex = 11
        Me.Dosage_Form.Text = "Dosage Form"
        Me.Dosage_Form.UseVisualStyleBackColor = True
        '
        'DosageForm1
        '
        Me.DosageForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DosageForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DosageForm1.Location = New System.Drawing.Point(0, 0)
        Me.DosageForm1.Name = "DosageForm1"
        Me.DosageForm1.Size = New System.Drawing.Size(1307, 561)
        Me.DosageForm1.TabIndex = 0
        '
        'Accounts
        '
        Me.Accounts.BackColor = System.Drawing.Color.White
        Me.Accounts.Controls.Add(Me.Account1)
        Me.Accounts.Location = New System.Drawing.Point(4, 84)
        Me.Accounts.Margin = New System.Windows.Forms.Padding(0)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(1307, 561)
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
        Me.Account1.Size = New System.Drawing.Size(1307, 561)
        Me.Account1.TabIndex = 0
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MaintenaceTabControl)
        Me.Name = "Maintenance"
        Me.Size = New System.Drawing.Size(1315, 649)
        Me.MaintenaceTabControl.ResumeLayout(False)
        Me.Categories.ResumeLayout(False)
        Me.SubCategory.ResumeLayout(False)
        Me.Suppliers.ResumeLayout(False)
        Me.Vat.ResumeLayout(False)
        Me.Discounts.ResumeLayout(False)
        Me.Dosage.ResumeLayout(False)
        Me.Dosage_Form.ResumeLayout(False)
        Me.Accounts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaintenaceTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents SubCategory As TabPage
    Friend WithEvents Suppliers As TabPage
    Friend WithEvents Supplier1 As Supplier
    Friend WithEvents SubCategory1 As SubCategory
    Friend WithEvents Categories As TabPage
    Friend WithEvents Category1 As Category
    Friend WithEvents Vat As TabPage
    Friend WithEvents Discounts As TabPage
    Private WithEvents Vat1 As Vat
    Friend WithEvents Discount1 As Discount
    Friend WithEvents Dosage As TabPage
    Friend WithEvents Dosage1 As Dosage
    Friend WithEvents Dosage_Form As TabPage
    Friend WithEvents DosageForm1 As DosageForm
    Friend WithEvents Accounts As TabPage
    Friend WithEvents Account1 As Account
End Class
