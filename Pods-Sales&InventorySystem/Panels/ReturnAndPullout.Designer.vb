<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnAndPullout
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ReturnandPulloutTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Returns = New System.Windows.Forms.TabPage()
        Me.PullOut = New System.Windows.Forms.TabPage()
        Me.ReturnandPulloutTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReturnandPulloutTabControl
        '
        Me.ReturnandPulloutTabControl.Controls.Add(Me.Returns)
        Me.ReturnandPulloutTabControl.Controls.Add(Me.PullOut)
        Me.ReturnandPulloutTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReturnandPulloutTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.ReturnandPulloutTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ReturnandPulloutTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.ReturnandPulloutTabControl.Name = "ReturnandPulloutTabControl"
        Me.ReturnandPulloutTabControl.SelectedIndex = 0
        Me.ReturnandPulloutTabControl.Size = New System.Drawing.Size(1022, 580)
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
        Me.ReturnandPulloutTabControl.TabIndex = 1
        Me.ReturnandPulloutTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ReturnandPulloutTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Returns
        '
        Me.Returns.Location = New System.Drawing.Point(4, 44)
        Me.Returns.Name = "Returns"
        Me.Returns.Size = New System.Drawing.Size(1014, 532)
        Me.Returns.TabIndex = 6
        Me.Returns.Text = "Returns"
        Me.Returns.UseVisualStyleBackColor = True
        '
        'PullOut
        '
        Me.PullOut.Location = New System.Drawing.Point(4, 44)
        Me.PullOut.Name = "PullOut"
        Me.PullOut.Size = New System.Drawing.Size(1014, 532)
        Me.PullOut.TabIndex = 7
        Me.PullOut.Text = "Pull Out"
        Me.PullOut.UseVisualStyleBackColor = True
        '
        'ReturnAndPullout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReturnandPulloutTabControl)
        Me.Name = "ReturnAndPullout"
        Me.Size = New System.Drawing.Size(1022, 580)
        Me.ReturnandPulloutTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReturnandPulloutTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Returns As TabPage
    Friend WithEvents PullOut As TabPage
End Class
