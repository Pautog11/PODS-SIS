<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PulloutDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewtblcategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pods = New Pods_Sales_InventorySystem.pods()
        Me.ViewtblcategoriesTableAdapter = New Pods_Sales_InventorySystem.podsTableAdapters.viewtblcategoriesTableAdapter()
        CType(Me.PulloutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewtblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PulloutDataGridView
        '
        Me.PulloutDataGridView.AllowUserToAddRows = False
        Me.PulloutDataGridView.AllowUserToDeleteRows = False
        Me.PulloutDataGridView.AllowUserToResizeColumns = False
        Me.PulloutDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.PulloutDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PulloutDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PulloutDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PulloutDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CATEGORYDataGridViewTextBoxColumn, Me.DESCRIPTIONDataGridViewTextBoxColumn})
        Me.PulloutDataGridView.DataSource = Me.ViewtblcategoriesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PulloutDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.PulloutDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PulloutDataGridView.Location = New System.Drawing.Point(8, 8)
        Me.PulloutDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.PulloutDataGridView.MultiSelect = False
        Me.PulloutDataGridView.Name = "PulloutDataGridView"
        Me.PulloutDataGridView.ReadOnly = True
        Me.PulloutDataGridView.RowHeadersVisible = False
        Me.PulloutDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.PulloutDataGridView.Size = New System.Drawing.Size(584, 334)
        Me.PulloutDataGridView.TabIndex = 34
        Me.PulloutDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PulloutDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PulloutDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PulloutDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PulloutDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PulloutDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PulloutDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PulloutDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PulloutDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PulloutDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulloutDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PulloutDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PulloutDataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.PulloutDataGridView.ThemeStyle.ReadOnly = True
        Me.PulloutDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PulloutDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PulloutDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulloutDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PulloutDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.PulloutDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PulloutDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CATEGORYDataGridViewTextBoxColumn
        '
        Me.CATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY"
        Me.CATEGORYDataGridViewTextBoxColumn.Name = "CATEGORYDataGridViewTextBoxColumn"
        Me.CATEGORYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.DESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.Name = "DESCRIPTIONDataGridViewTextBoxColumn"
        Me.DESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewtblcategoriesBindingSource
        '
        Me.ViewtblcategoriesBindingSource.DataMember = "viewtblcategories"
        Me.ViewtblcategoriesBindingSource.DataSource = Me.Pods
        '
        'Pods
        '
        Me.Pods.DataSetName = "pods"
        Me.Pods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewtblcategoriesTableAdapter
        '
        Me.ViewtblcategoriesTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PulloutDataGridView)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PulloutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewtblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PulloutDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Pods As pods
    Friend WithEvents ViewtblcategoriesBindingSource As BindingSource
    Friend WithEvents ViewtblcategoriesTableAdapter As podsTableAdapters.viewtblcategoriesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
