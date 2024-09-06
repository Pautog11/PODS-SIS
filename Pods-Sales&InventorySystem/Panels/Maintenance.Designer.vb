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
        Me.Categories = New System.Windows.Forms.TabPage()
        Me.SubCategory = New System.Windows.Forms.TabPage()
        Me.Products = New System.Windows.Forms.TabPage()
        Me.Account1 = New Pods_Sales_InventorySystem.Account()
        Me.MaintenaceTabControl.SuspendLayout()
        Me.Accounts.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaintenaceTabControl
        '
        Me.MaintenaceTabControl.Controls.Add(Me.Accounts)
        Me.MaintenaceTabControl.Controls.Add(Me.Categories)
        Me.MaintenaceTabControl.Controls.Add(Me.SubCategory)
        Me.MaintenaceTabControl.Controls.Add(Me.Products)
        Me.MaintenaceTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaintenaceTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.MaintenaceTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MaintenaceTabControl.Name = "MaintenaceTabControl"
        Me.MaintenaceTabControl.SelectedIndex = 0
        Me.MaintenaceTabControl.Size = New System.Drawing.Size(869, 580)
        Me.MaintenaceTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.MaintenaceTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MaintenaceTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.MaintenaceTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.MaintenaceTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MaintenaceTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.MaintenaceTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.MaintenaceTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.MaintenaceTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaintenaceTabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.MaintenaceTabControl.TabIndex = 0
        Me.MaintenaceTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.MaintenaceTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Accounts
        '
        Me.Accounts.Controls.Add(Me.Account1)
        Me.Accounts.Location = New System.Drawing.Point(4, 44)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Padding = New System.Windows.Forms.Padding(3)
        Me.Accounts.Size = New System.Drawing.Size(861, 532)
        Me.Accounts.TabIndex = 0
        Me.Accounts.Text = "Accounts"
        Me.Accounts.UseVisualStyleBackColor = True
        '
        'Categories
        '
        Me.Categories.Location = New System.Drawing.Point(4, 44)
        Me.Categories.Name = "Categories"
        Me.Categories.Padding = New System.Windows.Forms.Padding(3)
        Me.Categories.Size = New System.Drawing.Size(861, 532)
        Me.Categories.TabIndex = 1
        Me.Categories.Text = "Categories"
        Me.Categories.UseVisualStyleBackColor = True
        '
        'SubCategory
        '
        Me.SubCategory.Location = New System.Drawing.Point(4, 44)
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.Size = New System.Drawing.Size(861, 532)
        Me.SubCategory.TabIndex = 3
        Me.SubCategory.Text = "Sub Category"
        Me.SubCategory.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.Products.Location = New System.Drawing.Point(4, 44)
        Me.Products.Name = "Products"
        Me.Products.Size = New System.Drawing.Size(861, 532)
        Me.Products.TabIndex = 2
        Me.Products.Text = "Products"
        Me.Products.UseVisualStyleBackColor = True
        '
        'Account1
        '
        Me.Account1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Account1.Location = New System.Drawing.Point(3, 3)
        Me.Account1.Name = "Account1"
        Me.Account1.Size = New System.Drawing.Size(855, 526)
        Me.Account1.TabIndex = 0
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MaintenaceTabControl)
        Me.Name = "Maintenance"
        Me.Size = New System.Drawing.Size(869, 580)
        Me.MaintenaceTabControl.ResumeLayout(False)
        Me.Accounts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaintenaceTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Accounts As TabPage
    Friend WithEvents Categories As TabPage
    Friend WithEvents SubCategory As TabPage
    Friend WithEvents Products As TabPage
    Friend WithEvents Account1 As Account
End Class
