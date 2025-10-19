<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberlist
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
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.loadingBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GenerateID = New Guna.UI2.WinForms.Guna2Button()
        Me.DGVinfo = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPanel3.SuspendLayout()
        Me.loadingBar.SuspendLayout()
        CType(Me.DGVinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GunaPanel3.TabIndex = 269
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
        Me.Guna2Button1.Size = New System.Drawing.Size(123, 37)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Member List"
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
        Me.Guna2Button2.Text = "Manage Member >"
        '
        'loadingBar
        '
        Me.loadingBar.Animated = True
        Me.loadingBar.BackColor = System.Drawing.Color.Transparent
        Me.loadingBar.Controls.Add(Me.GunaLabel1)
        Me.loadingBar.FillColor = System.Drawing.Color.Transparent
        Me.loadingBar.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadingBar.Location = New System.Drawing.Point(473, 249)
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
        Me.loadingBar.TabIndex = 275
        Me.loadingBar.Value = 1
        Me.loadingBar.Visible = False
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
        'GenerateID
        '
        Me.GenerateID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GenerateID.BorderRadius = 20
        Me.GenerateID.BorderThickness = 3
        Me.GenerateID.CheckedState.Parent = Me.GenerateID
        Me.GenerateID.CustomImages.Parent = Me.GenerateID
        Me.GenerateID.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GenerateID.Font = New System.Drawing.Font("Madani Arabic DEMO", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GenerateID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GenerateID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GenerateID.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GenerateID.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GenerateID.HoverState.Parent = Me.GenerateID
        Me.GenerateID.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GenerateID.ImageOffset = New System.Drawing.Point(5, -4)
        Me.GenerateID.ImageSize = New System.Drawing.Size(30, 30)
        Me.GenerateID.Location = New System.Drawing.Point(725, 42)
        Me.GenerateID.Name = "GenerateID"
        Me.GenerateID.ShadowDecoration.Parent = Me.GenerateID
        Me.GenerateID.Size = New System.Drawing.Size(164, 56)
        Me.GenerateID.TabIndex = 274
        Me.GenerateID.Text = "Generate ID"
        '
        'DGVinfo
        '
        Me.DGVinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVinfo.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGVinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVinfo.Location = New System.Drawing.Point(57, 110)
        Me.DGVinfo.Name = "DGVinfo"
        Me.DGVinfo.ReadOnly = True
        Me.DGVinfo.Size = New System.Drawing.Size(1005, 493)
        Me.DGVinfo.TabIndex = 273
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
        Me.txtSearch.Location = New System.Drawing.Point(350, 53)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(359, 36)
        Me.txtSearch.TabIndex = 270
        Me.txtSearch.TextOffset = New System.Drawing.Point(8, 0)
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
        Me.btnDelete.Location = New System.Drawing.Point(991, 41)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(70, 60)
        Me.btnDelete.TabIndex = 272
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
        Me.btnEdit.Location = New System.Drawing.Point(905, 41)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(70, 60)
        Me.btnEdit.TabIndex = 271
        Me.btnEdit.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'memberlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 624)
        Me.Controls.Add(Me.loadingBar)
        Me.Controls.Add(Me.GenerateID)
        Me.Controls.Add(Me.DGVinfo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GunaPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "memberlist"
        Me.Text = "meberlist"
        Me.GunaPanel3.ResumeLayout(False)
        Me.loadingBar.ResumeLayout(False)
        Me.loadingBar.PerformLayout()
        CType(Me.DGVinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loadingBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GenerateID As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVinfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
