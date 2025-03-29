<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubCategoryDialog
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
        Me.SubCategoryLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SubCategoryDescriptionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubcategoryNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteSubCategoryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddSubCategoryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SubCategoryLayoutPanel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubCategoryLayoutPanel
        '
        Me.SubCategoryLayoutPanel.ColumnCount = 1
        Me.SubCategoryLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SubCategoryLayoutPanel.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.SubCategoryLayoutPanel.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.SubCategoryLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubCategoryLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.SubCategoryLayoutPanel.Name = "SubCategoryLayoutPanel"
        Me.SubCategoryLayoutPanel.RowCount = 2
        Me.SubCategoryLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SubCategoryLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.SubCategoryLayoutPanel.Size = New System.Drawing.Size(287, 282)
        Me.SubCategoryLayoutPanel.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.SubCategoryDescriptionTextBox)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.SubcategoryNameTextBox)
        Me.Guna2Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(287, 227)
        Me.Guna2Panel1.TabIndex = 0
        '
        'SubCategoryDescriptionTextBox
        '
        Me.SubCategoryDescriptionTextBox.BorderColor = System.Drawing.Color.Gray
        Me.SubCategoryDescriptionTextBox.BorderRadius = 10
        Me.SubCategoryDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubCategoryDescriptionTextBox.DefaultText = ""
        Me.SubCategoryDescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SubCategoryDescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SubCategoryDescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubCategoryDescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubCategoryDescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryDescriptionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SubCategoryDescriptionTextBox.ForeColor = System.Drawing.Color.Black
        Me.SubCategoryDescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubCategoryDescriptionTextBox.Location = New System.Drawing.Point(26, 150)
        Me.SubCategoryDescriptionTextBox.MaxLength = 100
        Me.SubCategoryDescriptionTextBox.Multiline = True
        Me.SubCategoryDescriptionTextBox.Name = "SubCategoryDescriptionTextBox"
        Me.SubCategoryDescriptionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubCategoryDescriptionTextBox.PlaceholderText = ""
        Me.SubCategoryDescriptionTextBox.SelectedText = ""
        Me.SubCategoryDescriptionTextBox.ShortcutsEnabled = False
        Me.SubCategoryDescriptionTextBox.Size = New System.Drawing.Size(222, 64)
        Me.SubCategoryDescriptionTextBox.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Description (Optional)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Subcategory Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Category"
        '
        'SubcategoryNameTextBox
        '
        Me.SubcategoryNameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.SubcategoryNameTextBox.BorderRadius = 10
        Me.SubcategoryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubcategoryNameTextBox.DefaultText = ""
        Me.SubcategoryNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SubcategoryNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SubcategoryNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubcategoryNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SubcategoryNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubcategoryNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SubcategoryNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.SubcategoryNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubcategoryNameTextBox.Location = New System.Drawing.Point(26, 91)
        Me.SubcategoryNameTextBox.MaxLength = 50
        Me.SubcategoryNameTextBox.Name = "SubcategoryNameTextBox"
        Me.SubcategoryNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubcategoryNameTextBox.PlaceholderText = "Ex. (Cough and Cold etc.,)"
        Me.SubcategoryNameTextBox.SelectedText = ""
        Me.SubcategoryNameTextBox.ShortcutsEnabled = False
        Me.SubcategoryNameTextBox.Size = New System.Drawing.Size(222, 36)
        Me.SubcategoryNameTextBox.TabIndex = 4
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.BackColor = System.Drawing.Color.Transparent
        Me.CategoryComboBox.BorderColor = System.Drawing.Color.Gray
        Me.CategoryComboBox.BorderRadius = 10
        Me.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryComboBox.ForeColor = System.Drawing.Color.Black
        Me.CategoryComboBox.ItemHeight = 30
        Me.CategoryComboBox.Location = New System.Drawing.Point(26, 35)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(222, 36)
        Me.CategoryComboBox.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteSubCategoryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddSubCategoryButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 227)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(287, 55)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'DeleteSubCategoryButton
        '
        Me.DeleteSubCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteSubCategoryButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteSubCategoryButton.BorderRadius = 15
        Me.DeleteSubCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteSubCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteSubCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteSubCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteSubCategoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeleteSubCategoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteSubCategoryButton.ForeColor = System.Drawing.Color.White
        Me.DeleteSubCategoryButton.Location = New System.Drawing.Point(156, 9)
        Me.DeleteSubCategoryButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.DeleteSubCategoryButton.Name = "DeleteSubCategoryButton"
        Me.DeleteSubCategoryButton.Size = New System.Drawing.Size(128, 35)
        Me.DeleteSubCategoryButton.TabIndex = 6
        Me.DeleteSubCategoryButton.Text = "Delete"
        '
        'AddSubCategoryButton
        '
        Me.AddSubCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddSubCategoryButton.BackColor = System.Drawing.Color.Transparent
        Me.AddSubCategoryButton.BorderRadius = 15
        Me.AddSubCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddSubCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddSubCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddSubCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddSubCategoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddSubCategoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddSubCategoryButton.ForeColor = System.Drawing.Color.White
        Me.AddSubCategoryButton.Location = New System.Drawing.Point(22, 8)
        Me.AddSubCategoryButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddSubCategoryButton.Name = "AddSubCategoryButton"
        Me.AddSubCategoryButton.Size = New System.Drawing.Size(128, 37)
        Me.AddSubCategoryButton.TabIndex = 5
        Me.AddSubCategoryButton.Text = "Add"
        '
        'SubCategoryDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 282)
        Me.Controls.Add(Me.SubCategoryLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubCategoryDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Subcategory Dialog"
        Me.SubCategoryLayoutPanel.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubCategoryLayoutPanel As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DeleteSubCategoryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddSubCategoryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SubcategoryNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SubCategoryDescriptionTextBox As Guna.UI2.WinForms.Guna2TextBox
End Class
