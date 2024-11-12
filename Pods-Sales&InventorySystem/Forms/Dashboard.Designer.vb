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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.DashboardTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.SettingButton = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.DashboardPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.DashboardTabControl = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotificationDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Sales = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Accounts = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Products = New System.Windows.Forms.TabPage()
        Me.Product1 = New Pods_Sales_InventorySystem.Product()
        Me.Maintenance = New System.Windows.Forms.TabPage()
        Me.Maintenance1 = New Pods_Sales_InventorySystem.Maintenance()
        Me.Inventory = New System.Windows.Forms.TabPage()
        Me.Inventory1 = New Pods_Sales_InventorySystem.Inventory()
        Me.Activity = New System.Windows.Forms.TabPage()
        Me.AuditTrail1 = New Pods_Sales_InventorySystem.Activity()
        Me.Transaction = New System.Windows.Forms.TabPage()
        Me.Transaction1 = New Pods_Sales_InventorySystem.Transaction()
        Me.Sales_Report = New System.Windows.Forms.TabPage()
        Me.Witdrawal = New System.Windows.Forms.TabPage()
        Me.ReturnAndPullout1 = New Pods_Sales_InventorySystem.ReturnAndPullout()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardTableLayoutPanel.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.DashboardPanel.SuspendLayout()
        Me.DashboardTabControl.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NotificationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Products.SuspendLayout()
        Me.Maintenance.SuspendLayout()
        Me.Inventory.SuspendLayout()
        Me.Activity.SuspendLayout()
        Me.Transaction.SuspendLayout()
        Me.Witdrawal.SuspendLayout()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DashboardTableLayoutPanel
        '
        Me.DashboardTableLayoutPanel.ColumnCount = 2
        Me.DashboardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.DashboardTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DashboardTableLayoutPanel.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.DashboardTableLayoutPanel.Controls.Add(Me.Guna2ImageButton1, 0, 0)
        Me.DashboardTableLayoutPanel.Controls.Add(Me.DashboardPanel, 1, 1)
        Me.DashboardTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashboardTableLayoutPanel.Name = "DashboardTableLayoutPanel"
        Me.DashboardTableLayoutPanel.RowCount = 2
        Me.DashboardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DashboardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DashboardTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DashboardTableLayoutPanel.Size = New System.Drawing.Size(1318, 608)
        Me.DashboardTableLayoutPanel.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2ControlBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2ControlBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SettingButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(180, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1138, 40)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1093, 0)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 37)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1048, 0)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 37)
        Me.Guna2ControlBox3.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1003, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 37)
        Me.Guna2ControlBox1.TabIndex = 3
        '
        'SettingButton
        '
        Me.SettingButton.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.SettingButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingButton.HoverState.ImageSize = New System.Drawing.Size(13, 13)
        Me.SettingButton.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.icon_setting
        Me.SettingButton.ImageOffset = New System.Drawing.Point(0, 0)
        Me.SettingButton.ImageRotate = 0!
        Me.SettingButton.ImageSize = New System.Drawing.Size(13, 13)
        Me.SettingButton.Location = New System.Drawing.Point(964, 0)
        Me.SettingButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.PressedState.ImageSize = New System.Drawing.Size(13, 13)
        Me.SettingButton.Size = New System.Drawing.Size(39, 37)
        Me.SettingButton.TabIndex = 4
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(180, 40)
        Me.Guna2ImageButton1.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.icon_pods
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(180, 40)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(180, 35)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(180, 40)
        Me.Guna2ImageButton1.TabIndex = 2
        '
        'DashboardPanel
        '
        Me.DashboardTableLayoutPanel.SetColumnSpan(Me.DashboardPanel, 2)
        Me.DashboardPanel.Controls.Add(Me.DashboardTabControl)
        Me.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardPanel.Location = New System.Drawing.Point(3, 43)
        Me.DashboardPanel.Name = "DashboardPanel"
        Me.DashboardPanel.Size = New System.Drawing.Size(1312, 562)
        Me.DashboardPanel.TabIndex = 0
        '
        'DashboardTabControl
        '
        Me.DashboardTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DashboardTabControl.Controls.Add(Me.Home)
        Me.DashboardTabControl.Controls.Add(Me.Products)
        Me.DashboardTabControl.Controls.Add(Me.Maintenance)
        Me.DashboardTabControl.Controls.Add(Me.Inventory)
        Me.DashboardTabControl.Controls.Add(Me.Activity)
        Me.DashboardTabControl.Controls.Add(Me.Transaction)
        Me.DashboardTabControl.Controls.Add(Me.Sales_Report)
        Me.DashboardTabControl.Controls.Add(Me.Witdrawal)
        Me.DashboardTabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardTabControl.ItemSize = New System.Drawing.Size(180, 40)
        Me.DashboardTabControl.Location = New System.Drawing.Point(0, 0)
        Me.DashboardTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.DashboardTabControl.Name = "DashboardTabControl"
        Me.DashboardTabControl.SelectedIndex = 0
        Me.DashboardTabControl.Size = New System.Drawing.Size(1312, 562)
        Me.DashboardTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.DashboardTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DashboardTabControl.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.DashboardTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.DashboardTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DashboardTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.DashboardTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent
        Me.DashboardTabControl.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.DashboardTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Black
        Me.DashboardTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent
        Me.DashboardTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent
        Me.DashboardTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DashboardTabControl.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.DashboardTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.DashboardTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DashboardTabControl.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.DashboardTabControl.TabIndex = 0
        Me.DashboardTabControl.TabMenuBackColor = System.Drawing.Color.White
        '
        'Home
        '
        Me.Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Home.Controls.Add(Me.TableLayoutPanel1)
        Me.Home.ForeColor = System.Drawing.Color.Black
        Me.Home.Location = New System.Drawing.Point(184, 4)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(3)
        Me.Home.Size = New System.Drawing.Size(1124, 554)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.NotificationDataGridView, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1116, 546)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NotificationDataGridView
        '
        Me.NotificationDataGridView.AllowUserToAddRows = False
        Me.NotificationDataGridView.AllowUserToDeleteRows = False
        Me.NotificationDataGridView.AllowUserToResizeColumns = False
        Me.NotificationDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.NotificationDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.NotificationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotificationDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.NotificationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.total})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NotificationDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.NotificationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotificationDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NotificationDataGridView.Location = New System.Drawing.Point(743, 103)
        Me.NotificationDataGridView.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.NotificationDataGridView.MultiSelect = False
        Me.NotificationDataGridView.Name = "NotificationDataGridView"
        Me.NotificationDataGridView.ReadOnly = True
        Me.NotificationDataGridView.RowHeadersVisible = False
        Me.NotificationDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.NotificationDataGridView.Size = New System.Drawing.Size(373, 443)
        Me.NotificationDataGridView.TabIndex = 7
        Me.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.NotificationDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.NotificationDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.NotificationDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NotificationDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NotificationDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.NotificationDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificationDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.NotificationDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.NotificationDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.NotificationDataGridView.ThemeStyle.ReadOnly = True
        Me.NotificationDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.NotificationDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.NotificationDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificationDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.NotificationDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.NotificationDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NotificationDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'total
        '
        Me.total.HeaderText = "Notifications"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Sales)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(743, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(373, 100)
        Me.Panel3.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.profit
        Me.PictureBox3.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(93, 72)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'Sales
        '
        Me.Sales.AutoSize = True
        Me.Sales.Location = New System.Drawing.Point(161, 47)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(13, 13)
        Me.Sales.TabIndex = 2
        Me.Sales.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(374, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(366, 100)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.cart
        Me.PictureBox2.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Accounts)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 100)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pods_Sales_InventorySystem.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Accounts
        '
        Me.Accounts.AutoSize = True
        Me.Accounts.Location = New System.Drawing.Point(161, 47)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(13, 13)
        Me.Accounts.TabIndex = 0
        Me.Accounts.Text = "0"
        '
        'Panel4
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel4, 2)
        Me.Panel4.Controls.Add(Me.Chart1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 103)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(737, 440)
        Me.Panel4.TabIndex = 8
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(737, 440)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Products
        '
        Me.Products.Controls.Add(Me.Product1)
        Me.Products.Location = New System.Drawing.Point(184, 4)
        Me.Products.Name = "Products"
        Me.Products.Size = New System.Drawing.Size(1124, 554)
        Me.Products.TabIndex = 3
        Me.Products.Text = "Products"
        Me.Products.UseVisualStyleBackColor = True
        '
        'Product1
        '
        Me.Product1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Product1.Location = New System.Drawing.Point(0, 0)
        Me.Product1.Name = "Product1"
        Me.Product1.Size = New System.Drawing.Size(1124, 554)
        Me.Product1.TabIndex = 0
        '
        'Maintenance
        '
        Me.Maintenance.Controls.Add(Me.Maintenance1)
        Me.Maintenance.Location = New System.Drawing.Point(184, 4)
        Me.Maintenance.Name = "Maintenance"
        Me.Maintenance.Padding = New System.Windows.Forms.Padding(3)
        Me.Maintenance.Size = New System.Drawing.Size(1124, 554)
        Me.Maintenance.TabIndex = 1
        Me.Maintenance.Text = "Maintenance"
        Me.Maintenance.UseVisualStyleBackColor = True
        '
        'Maintenance1
        '
        Me.Maintenance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Maintenance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Maintenance1.Location = New System.Drawing.Point(3, 3)
        Me.Maintenance1.Margin = New System.Windows.Forms.Padding(0)
        Me.Maintenance1.Name = "Maintenance1"
        Me.Maintenance1.Size = New System.Drawing.Size(1118, 548)
        Me.Maintenance1.TabIndex = 0
        '
        'Inventory
        '
        Me.Inventory.Controls.Add(Me.Inventory1)
        Me.Inventory.Location = New System.Drawing.Point(184, 4)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Size = New System.Drawing.Size(1124, 554)
        Me.Inventory.TabIndex = 4
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'Inventory1
        '
        Me.Inventory1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Inventory1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inventory1.Location = New System.Drawing.Point(0, 0)
        Me.Inventory1.Name = "Inventory1"
        Me.Inventory1.Size = New System.Drawing.Size(1124, 554)
        Me.Inventory1.TabIndex = 0
        '
        'Activity
        '
        Me.Activity.Controls.Add(Me.AuditTrail1)
        Me.Activity.Location = New System.Drawing.Point(184, 4)
        Me.Activity.Name = "Activity"
        Me.Activity.Padding = New System.Windows.Forms.Padding(3)
        Me.Activity.Size = New System.Drawing.Size(1124, 554)
        Me.Activity.TabIndex = 2
        Me.Activity.Text = "Activity"
        Me.Activity.UseVisualStyleBackColor = True
        '
        'AuditTrail1
        '
        Me.AuditTrail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuditTrail1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuditTrail1.Location = New System.Drawing.Point(3, 3)
        Me.AuditTrail1.Name = "AuditTrail1"
        Me.AuditTrail1.Size = New System.Drawing.Size(1118, 548)
        Me.AuditTrail1.TabIndex = 0
        '
        'Transaction
        '
        Me.Transaction.Controls.Add(Me.Transaction1)
        Me.Transaction.Location = New System.Drawing.Point(184, 4)
        Me.Transaction.Name = "Transaction"
        Me.Transaction.Size = New System.Drawing.Size(1124, 554)
        Me.Transaction.TabIndex = 5
        Me.Transaction.Text = "Transaction"
        Me.Transaction.UseVisualStyleBackColor = True
        '
        'Transaction1
        '
        Me.Transaction1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Transaction1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Transaction1.Location = New System.Drawing.Point(0, 0)
        Me.Transaction1.Name = "Transaction1"
        Me.Transaction1.Size = New System.Drawing.Size(1124, 554)
        Me.Transaction1.TabIndex = 0
        '
        'Sales_Report
        '
        Me.Sales_Report.Location = New System.Drawing.Point(184, 4)
        Me.Sales_Report.Name = "Sales_Report"
        Me.Sales_Report.Size = New System.Drawing.Size(1124, 554)
        Me.Sales_Report.TabIndex = 6
        Me.Sales_Report.Text = "Sales Report"
        Me.Sales_Report.UseVisualStyleBackColor = True
        '
        'Witdrawal
        '
        Me.Witdrawal.Controls.Add(Me.ReturnAndPullout1)
        Me.Witdrawal.Location = New System.Drawing.Point(184, 4)
        Me.Witdrawal.Name = "Witdrawal"
        Me.Witdrawal.Size = New System.Drawing.Size(1124, 554)
        Me.Witdrawal.TabIndex = 7
        Me.Witdrawal.Text = "Witdrawal"
        Me.Witdrawal.UseVisualStyleBackColor = True
        '
        'ReturnAndPullout1
        '
        Me.ReturnAndPullout1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReturnAndPullout1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReturnAndPullout1.Location = New System.Drawing.Point(0, 0)
        Me.ReturnAndPullout1.Name = "ReturnAndPullout1"
        Me.ReturnAndPullout1.Size = New System.Drawing.Size(1124, 554)
        Me.ReturnAndPullout1.TabIndex = 0
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(113, 48)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 608)
        Me.Controls.Add(Me.DashboardTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.DashboardTableLayoutPanel.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.DashboardPanel.ResumeLayout(False)
        Me.DashboardTabControl.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.NotificationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Products.ResumeLayout(False)
        Me.Maintenance.ResumeLayout(False)
        Me.Inventory.ResumeLayout(False)
        Me.Activity.ResumeLayout(False)
        Me.Transaction.ResumeLayout(False)
        Me.Witdrawal.ResumeLayout(False)
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardTableLayoutPanel As TableLayoutPanel
    Friend WithEvents DashboardPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DashboardTabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Home As TabPage
    Friend WithEvents Maintenance As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Accounts As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Activity As TabPage
    Friend WithEvents AuditTrail1 As Activity
    Friend WithEvents Products As TabPage
    Friend WithEvents Product1 As Product
    Friend WithEvents Sales As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Inventory As TabPage
    Friend WithEvents SettingButton As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Inventory1 As Inventory
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Maintenance1 As Maintenance
    Friend WithEvents Transaction As TabPage
    Friend WithEvents Sales_Report As TabPage
    Friend WithEvents Witdrawal As TabPage
    Friend WithEvents NotificationDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Transaction1 As Transaction
    Friend WithEvents ReturnAndPullout1 As ReturnAndPullout
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
