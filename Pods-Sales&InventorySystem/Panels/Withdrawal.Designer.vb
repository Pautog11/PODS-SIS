<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnAndPullout
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
        Me.ReturnandPulloutTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Returns = New System.Windows.Forms.TabPage()
        Me.Returns1 = New Pods_Sales_InventorySystem.Returns()
        Me.PullOuts = New System.Windows.Forms.TabPage()
        Me.PullOuts1 = New Pods_Sales_InventorySystem.PullOuts()
        Me.Disposal = New System.Windows.Forms.TabPage()
        Me.ReturnandPulloutTabControl.SuspendLayout()
        Me.Returns.SuspendLayout()
        Me.PullOuts.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReturnandPulloutTabControl
        '
        Me.ReturnandPulloutTabControl.Controls.Add(Me.Disposal)
        Me.ReturnandPulloutTabControl.Controls.Add(Me.PullOuts)
        Me.ReturnandPulloutTabControl.Controls.Add(Me.Returns)
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
        Me.Returns.Controls.Add(Me.Returns1)
        Me.Returns.Location = New System.Drawing.Point(4, 44)
        Me.Returns.Margin = New System.Windows.Forms.Padding(0)
        Me.Returns.Name = "Returns"
        Me.Returns.Size = New System.Drawing.Size(1014, 532)
        Me.Returns.TabIndex = 6
        Me.Returns.Text = "Returns"
        Me.Returns.UseVisualStyleBackColor = True
        '
        'Returns1
        '
        Me.Returns1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Returns1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Returns1.Location = New System.Drawing.Point(0, 0)
        Me.Returns1.Margin = New System.Windows.Forms.Padding(0)
        Me.Returns1.Name = "Returns1"
        Me.Returns1.Size = New System.Drawing.Size(1014, 532)
        Me.Returns1.TabIndex = 0
        '
        'PullOuts
        '
        Me.PullOuts.Controls.Add(Me.PullOuts1)
        Me.PullOuts.Location = New System.Drawing.Point(4, 44)
        Me.PullOuts.Margin = New System.Windows.Forms.Padding(0)
        Me.PullOuts.Name = "PullOuts"
        Me.PullOuts.Size = New System.Drawing.Size(1014, 532)
        Me.PullOuts.TabIndex = 7
        Me.PullOuts.Text = "Pull Outs"
        Me.PullOuts.UseVisualStyleBackColor = True
        '
        'PullOuts1
        '
        Me.PullOuts1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PullOuts1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PullOuts1.Location = New System.Drawing.Point(0, 0)
        Me.PullOuts1.Margin = New System.Windows.Forms.Padding(0)
        Me.PullOuts1.Name = "PullOuts1"
        Me.PullOuts1.Size = New System.Drawing.Size(1014, 532)
        Me.PullOuts1.TabIndex = 0
        '
        'Disposal
        '
        Me.Disposal.Location = New System.Drawing.Point(4, 44)
        Me.Disposal.Name = "Disposal"
        Me.Disposal.Padding = New System.Windows.Forms.Padding(3)
        Me.Disposal.Size = New System.Drawing.Size(1014, 532)
        Me.Disposal.TabIndex = 8
        Me.Disposal.Text = "Disposal"
        Me.Disposal.UseVisualStyleBackColor = True
        '
        'ReturnAndPullout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReturnandPulloutTabControl)
        Me.Name = "ReturnAndPullout"
        Me.Size = New System.Drawing.Size(1022, 580)
        Me.ReturnandPulloutTabControl.ResumeLayout(False)
        Me.Returns.ResumeLayout(False)
        Me.PullOuts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReturnandPulloutTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Returns As TabPage
    Friend WithEvents PullOuts As TabPage
    Friend WithEvents PullOuts1 As PullOuts
    Friend WithEvents Returns1 As Returns
    Friend WithEvents Disposal As TabPage
End Class
