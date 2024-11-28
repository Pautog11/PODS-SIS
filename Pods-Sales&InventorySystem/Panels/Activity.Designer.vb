<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Activity
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
        Me.AccountLogs = New System.Windows.Forms.TabPage()
        Me.AccountLog1 = New Pods_Sales_InventorySystem.AccountLog()
        Me.AuditTrail = New System.Windows.Forms.TabPage()
        Me.AuditTrail1 = New Pods_Sales_InventorySystem.AuditTrail()
        Me.AuditTrailTabControl.SuspendLayout()
        Me.AccountLogs.SuspendLayout()
        Me.AuditTrail.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuditTrailTabControl
        '
        Me.AuditTrailTabControl.Controls.Add(Me.AccountLogs)
        Me.AuditTrailTabControl.Controls.Add(Me.AuditTrail)
        Me.AuditTrailTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuditTrailTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.AuditTrailTabControl.Location = New System.Drawing.Point(0, 0)
        Me.AuditTrailTabControl.Name = "AuditTrailTabControl"
        Me.AuditTrailTabControl.SelectedIndex = 0
        Me.AuditTrailTabControl.Size = New System.Drawing.Size(969, 552)
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
        Me.AuditTrailTabControl.TabIndex = 0
        Me.AuditTrailTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AuditTrailTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'AccountLogs
        '
        Me.AccountLogs.Controls.Add(Me.AccountLog1)
        Me.AccountLogs.Location = New System.Drawing.Point(4, 44)
        Me.AccountLogs.Name = "AccountLogs"
        Me.AccountLogs.Size = New System.Drawing.Size(961, 504)
        Me.AccountLogs.TabIndex = 0
        Me.AccountLogs.Text = "Account Logs"
        Me.AccountLogs.UseVisualStyleBackColor = True
        '
        'AccountLog1
        '
        Me.AccountLog1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountLog1.Location = New System.Drawing.Point(0, 0)
        Me.AccountLog1.Name = "AccountLog1"
        Me.AccountLog1.Size = New System.Drawing.Size(961, 504)
        Me.AccountLog1.TabIndex = 0
        '
        'AuditTrail
        '
        Me.AuditTrail.Controls.Add(Me.AuditTrail1)
        Me.AuditTrail.Location = New System.Drawing.Point(4, 44)
        Me.AuditTrail.Name = "AuditTrail"
        Me.AuditTrail.Size = New System.Drawing.Size(961, 504)
        Me.AuditTrail.TabIndex = 1
        Me.AuditTrail.Text = "Audit Trail"
        Me.AuditTrail.UseVisualStyleBackColor = True
        '
        'AuditTrail1
        '
        Me.AuditTrail1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuditTrail1.Location = New System.Drawing.Point(0, 0)
        Me.AuditTrail1.Name = "AuditTrail1"
        Me.AuditTrail1.Size = New System.Drawing.Size(961, 504)
        Me.AuditTrail1.TabIndex = 0
        '
        'Activity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AuditTrailTabControl)
        Me.Name = "Activity"
        Me.Size = New System.Drawing.Size(969, 552)
        Me.AuditTrailTabControl.ResumeLayout(False)
        Me.AccountLogs.ResumeLayout(False)
        Me.AuditTrail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AuditTrailTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents AccountLogs As TabPage
    Friend WithEvents AccountLog1 As AccountLog
    Friend WithEvents AuditTrail As TabPage
    Friend WithEvents AuditTrail1 As AuditTrail
End Class
