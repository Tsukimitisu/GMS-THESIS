<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equipmentList
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
        Me.DGVinfo = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.loadingBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DGVinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel3.SuspendLayout()
        Me.loadingBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVinfo
        '
        Me.DGVinfo.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGVinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVinfo.Location = New System.Drawing.Point(57, 121)
        Me.DGVinfo.Name = "DGVinfo"
        Me.DGVinfo.ReadOnly = True
        Me.DGVinfo.Size = New System.Drawing.Size(1005, 493)
        Me.DGVinfo.TabIndex = 280
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.BorderThickness = 2
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Tw Cen MT", 12.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.txtSearch.Location = New System.Drawing.Point(539, 65)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(359, 36)
        Me.txtSearch.TabIndex = 277
        Me.txtSearch.TextOffset = New System.Drawing.Point(8, 0)
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.White
        Me.GunaPanel3.Controls.Add(Me.Guna2Button1)
        Me.GunaPanel3.Controls.Add(Me.Guna2Button2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1119, 37)
        Me.GunaPanel3.TabIndex = 276
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2Button1.Location = New System.Drawing.Point(174, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(149, 37)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Equipment List"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button2.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2Button2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(174, 37)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Gym Equipment >"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(42, 96)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(79, 14)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Generating ID..."
        '
        'loadingBar
        '
        Me.loadingBar.Animated = True
        Me.loadingBar.BackColor = System.Drawing.Color.Transparent
        Me.loadingBar.Controls.Add(Me.GunaLabel1)
        Me.loadingBar.FillColor = System.Drawing.Color.Transparent
        Me.loadingBar.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadingBar.Location = New System.Drawing.Point(473, 260)
        Me.loadingBar.Name = "loadingBar"
        Me.loadingBar.ProgressColor = System.Drawing.Color.CornflowerBlue
        Me.loadingBar.ProgressColor2 = System.Drawing.Color.AliceBlue
        Me.loadingBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.loadingBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.loadingBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.loadingBar.ShadowDecoration.BorderRadius = 10
        Me.loadingBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.loadingBar.ShadowDecoration.Parent = Me.loadingBar
        Me.loadingBar.ShowPercentage = True
        Me.loadingBar.Size = New System.Drawing.Size(163, 149)
        Me.loadingBar.TabIndex = 282
        Me.loadingBar.Value = 1
        Me.loadingBar.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDelete.BorderRadius = 20
        Me.btnDelete.BorderThickness = 3
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Madani Arabic DEMO", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Image = Global.GymManagementSystem.My.Resources.Resources.Delete
        Me.btnDelete.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnDelete.Location = New System.Drawing.Point(991, 52)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(70, 60)
        Me.btnDelete.TabIndex = 279
        Me.btnDelete.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'btnEdit
        '
        Me.btnEdit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.BorderRadius = 20
        Me.btnEdit.BorderThickness = 3
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Madani Arabic DEMO", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Image = Global.GymManagementSystem.My.Resources.Resources.editing
        Me.btnEdit.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnEdit.Location = New System.Drawing.Point(905, 52)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(70, 60)
        Me.btnEdit.TabIndex = 278
        Me.btnEdit.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'equipmentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 624)
        Me.Controls.Add(Me.DGVinfo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.loadingBar)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "equipmentList"
        Me.Text = "equipmentList"
        CType(Me.DGVinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel3.ResumeLayout(False)
        Me.loadingBar.ResumeLayout(False)
        Me.loadingBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVinfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents loadingBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
End Class
