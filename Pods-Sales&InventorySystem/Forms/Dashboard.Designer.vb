<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.DashboardTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DashboardPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.DashboardTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Maintenance = New System.Windows.Forms.TabPage()
        Me.Maintenance1 = New Pods_Sales_InventorySystem.Maintenance()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DashboardTableLayoutPanel.SuspendLayout()
        Me.DashboardPanel.SuspendLayout()
        Me.DashboardTabControl.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Maintenance.SuspendLayout()
        Me.SuspendLayout()
        '
        'DashboardTableLayoutPanel
        '
        Me.DashboardTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.DashboardTableLayoutPanel.ColumnCount = 2
        Me.DashboardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.DashboardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DashboardTableLayoutPanel.Controls.Add(Me.DashboardPanel, 0, 1)
        Me.DashboardTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashboardTableLayoutPanel.Name = "DashboardTableLayoutPanel"
        Me.DashboardTableLayoutPanel.RowCount = 2
        Me.DashboardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.DashboardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DashboardTableLayoutPanel.Size = New System.Drawing.Size(800, 450)
        Me.DashboardTableLayoutPanel.TabIndex = 0
        '
        'DashboardPanel
        '
        Me.DashboardTableLayoutPanel.SetColumnSpan(Me.DashboardPanel, 2)
        Me.DashboardPanel.Controls.Add(Me.DashboardTabControl)
        Me.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardPanel.Location = New System.Drawing.Point(4, 35)
        Me.DashboardPanel.Name = "DashboardPanel"
        Me.DashboardPanel.Size = New System.Drawing.Size(792, 411)
        Me.DashboardPanel.TabIndex = 0
        '
        'DashboardTabControl
        '
        Me.DashboardTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DashboardTabControl.Controls.Add(Me.Home)
        Me.DashboardTabControl.Controls.Add(Me.Maintenance)
        Me.DashboardTabControl.Controls.Add(Me.TabPage1)
        Me.DashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.DashboardTabControl.Location = New System.Drawing.Point(0, 0)
        Me.DashboardTabControl.Name = "DashboardTabControl"
        Me.DashboardTabControl.SelectedIndex = 0
        Me.DashboardTabControl.Size = New System.Drawing.Size(792, 411)
        Me.DashboardTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.DashboardTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DashboardTabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.DashboardTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.DashboardTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DashboardTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.DashboardTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.DashboardTabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.DashboardTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.DashboardTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.DashboardTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.DashboardTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DashboardTabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.DashboardTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.DashboardTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DashboardTabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.DashboardTabControl.TabIndex = 0
        Me.DashboardTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'Home
        '
        Me.Home.Controls.Add(Me.TableLayoutPanel1)
        Me.Home.Location = New System.Drawing.Point(184, 4)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(3)
        Me.Home.Size = New System.Drawing.Size(604, 403)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(598, 397)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Maintenance
        '
        Me.Maintenance.Controls.Add(Me.Maintenance1)
        Me.Maintenance.Location = New System.Drawing.Point(184, 4)
        Me.Maintenance.Name = "Maintenance"
        Me.Maintenance.Padding = New System.Windows.Forms.Padding(3)
        Me.Maintenance.Size = New System.Drawing.Size(604, 403)
        Me.Maintenance.TabIndex = 1
        Me.Maintenance.Text = "Maintenance"
        Me.Maintenance.UseVisualStyleBackColor = True
        '
        'Maintenance1
        '
        Me.Maintenance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Maintenance1.Location = New System.Drawing.Point(3, 3)
        Me.Maintenance1.Name = "Maintenance1"
        Me.Maintenance1.Size = New System.Drawing.Size(598, 397)
        Me.Maintenance1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(604, 403)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DashboardTableLayoutPanel)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.DashboardTableLayoutPanel.ResumeLayout(False)
        Me.DashboardPanel.ResumeLayout(False)
        Me.DashboardTabControl.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Maintenance.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardTableLayoutPanel As TableLayoutPanel
    Friend WithEvents DashboardPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DashboardTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Home As TabPage
    Friend WithEvents Maintenance As TabPage
    Friend WithEvents Maintenance1 As Maintenance
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
