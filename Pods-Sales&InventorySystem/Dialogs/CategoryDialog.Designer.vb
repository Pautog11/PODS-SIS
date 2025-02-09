<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteCategoryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddCategoryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CategoryNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(328, 222)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteCategoryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddCategoryButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 167)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(328, 55)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'DeleteCategoryButton
        '
        Me.DeleteCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteCategoryButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteCategoryButton.BorderRadius = 15
        Me.DeleteCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteCategoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeleteCategoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteCategoryButton.ForeColor = System.Drawing.Color.White
        Me.DeleteCategoryButton.Location = New System.Drawing.Point(197, 9)
        Me.DeleteCategoryButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.DeleteCategoryButton.Name = "DeleteCategoryButton"
        Me.DeleteCategoryButton.Size = New System.Drawing.Size(128, 35)
        Me.DeleteCategoryButton.TabIndex = 6
        Me.DeleteCategoryButton.Text = "Delete"
        '
        'AddCategoryButton
        '
        Me.AddCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddCategoryButton.BackColor = System.Drawing.Color.Transparent
        Me.AddCategoryButton.BorderRadius = 15
        Me.AddCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddCategoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.AddCategoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddCategoryButton.ForeColor = System.Drawing.Color.White
        Me.AddCategoryButton.Location = New System.Drawing.Point(63, 8)
        Me.AddCategoryButton.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.AddCategoryButton.Name = "AddCategoryButton"
        Me.AddCategoryButton.Size = New System.Drawing.Size(128, 37)
        Me.AddCategoryButton.TabIndex = 5
        Me.AddCategoryButton.Text = "Add"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.DescriptionTextBox)
        Me.Guna2Panel1.Controls.Add(Me.CategoryNameTextBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(328, 167)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description (Optional)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category Name"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BorderColor = System.Drawing.Color.Gray
        Me.DescriptionTextBox.BorderRadius = 10
        Me.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescriptionTextBox.DefaultText = ""
        Me.DescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DescriptionTextBox.ForeColor = System.Drawing.Color.Black
        Me.DescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(31, 101)
        Me.DescriptionTextBox.MaxLength = 100
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescriptionTextBox.PlaceholderText = ""
        Me.DescriptionTextBox.SelectedText = ""
        Me.DescriptionTextBox.ShortcutsEnabled = False
        Me.DescriptionTextBox.Size = New System.Drawing.Size(261, 36)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'CategoryNameTextBox
        '
        Me.CategoryNameTextBox.BorderColor = System.Drawing.Color.Gray
        Me.CategoryNameTextBox.BorderRadius = 10
        Me.CategoryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryNameTextBox.DefaultText = ""
        Me.CategoryNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CategoryNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CategoryNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CategoryNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CategoryNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CategoryNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.CategoryNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryNameTextBox.Location = New System.Drawing.Point(32, 37)
        Me.CategoryNameTextBox.MaxLength = 100
        Me.CategoryNameTextBox.Name = "CategoryNameTextBox"
        Me.CategoryNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CategoryNameTextBox.PlaceholderText = "Category Name"
        Me.CategoryNameTextBox.SelectedText = ""
        Me.CategoryNameTextBox.ShortcutsEnabled = False
        Me.CategoryNameTextBox.Size = New System.Drawing.Size(261, 36)
        Me.CategoryNameTextBox.TabIndex = 0
        '
        'CategoryDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 222)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CategoryDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Category Dialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AddCategoryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteCategoryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CategoryNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DescriptionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
