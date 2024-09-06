<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.HomeTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'HomeTableLayout
        '
        Me.HomeTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.HomeTableLayout.ColumnCount = 3
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.HomeTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.HomeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.HomeTableLayout.Name = "HomeTableLayout"
        Me.HomeTableLayout.RowCount = 2
        Me.HomeTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.HomeTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.HomeTableLayout.Size = New System.Drawing.Size(997, 619)
        Me.HomeTableLayout.TabIndex = 1
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HomeTableLayout)
        Me.Name = "Home"
        Me.Size = New System.Drawing.Size(997, 619)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeTableLayout As TableLayoutPanel
End Class
