<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
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
        Me.AuditTrailTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Sales_Reports = New System.Windows.Forms.TabPage()
        Me.SalesReport1 = New Pods_Sales_InventorySystem.SalesReport()
        Me.Financial_Reports = New System.Windows.Forms.TabPage()
        Me.FinancialReport1 = New Pods_Sales_InventorySystem.FinancialReport()
        Me.AuditTrailTabControl.SuspendLayout()
        Me.Sales_Reports.SuspendLayout()
        Me.Financial_Reports.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuditTrailTabControl
        '
        Me.AuditTrailTabControl.Controls.Add(Me.Sales_Reports)
        Me.AuditTrailTabControl.Controls.Add(Me.Financial_Reports)
        Me.AuditTrailTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuditTrailTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.AuditTrailTabControl.Location = New System.Drawing.Point(0, 0)
        Me.AuditTrailTabControl.Name = "AuditTrailTabControl"
        Me.AuditTrailTabControl.SelectedIndex = 0
        Me.AuditTrailTabControl.Size = New System.Drawing.Size(890, 566)
        Me.AuditTrailTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.AuditTrailTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AuditTrailTabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.AuditTrailTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.AuditTrailTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AuditTrailTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.AuditTrailTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AuditTrailTabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.AuditTrailTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.AuditTrailTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AuditTrailTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.AuditTrailTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.AuditTrailTabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.AuditTrailTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.AuditTrailTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.AuditTrailTabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.AuditTrailTabControl.TabIndex = 1
        Me.AuditTrailTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AuditTrailTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Sales_Reports
        '
        Me.Sales_Reports.Controls.Add(Me.SalesReport1)
        Me.Sales_Reports.Location = New System.Drawing.Point(4, 44)
        Me.Sales_Reports.Name = "Sales_Reports"
        Me.Sales_Reports.Size = New System.Drawing.Size(882, 518)
        Me.Sales_Reports.TabIndex = 0
        Me.Sales_Reports.Text = "Sales Reports"
        Me.Sales_Reports.UseVisualStyleBackColor = True
        '
        'SalesReport1
        '
        Me.SalesReport1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalesReport1.Location = New System.Drawing.Point(0, 0)
        Me.SalesReport1.Name = "SalesReport1"
        Me.SalesReport1.Size = New System.Drawing.Size(882, 518)
        Me.SalesReport1.TabIndex = 0
        '
        'Financial_Reports
        '
        Me.Financial_Reports.Controls.Add(Me.FinancialReport1)
        Me.Financial_Reports.Location = New System.Drawing.Point(4, 44)
        Me.Financial_Reports.Name = "Financial_Reports"
        Me.Financial_Reports.Size = New System.Drawing.Size(882, 518)
        Me.Financial_Reports.TabIndex = 1
        Me.Financial_Reports.Text = "Financial Reports"
        Me.Financial_Reports.UseVisualStyleBackColor = True
        '
        'FinancialReport1
        '
        Me.FinancialReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinancialReport1.Location = New System.Drawing.Point(0, 0)
        Me.FinancialReport1.Name = "FinancialReport1"
        Me.FinancialReport1.Size = New System.Drawing.Size(882, 518)
        Me.FinancialReport1.TabIndex = 0
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AuditTrailTabControl)
        Me.Name = "Reports"
        Me.Size = New System.Drawing.Size(890, 566)
        Me.AuditTrailTabControl.ResumeLayout(False)
        Me.Sales_Reports.ResumeLayout(False)
        Me.Financial_Reports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AuditTrailTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Sales_Reports As TabPage
    Friend WithEvents Financial_Reports As TabPage
    Friend WithEvents SalesReport1 As SalesReport
    Friend WithEvents FinancialReport1 As FinancialReport
End Class
