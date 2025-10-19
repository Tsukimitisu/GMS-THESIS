<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckInOut
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
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGVinfo = New System.Windows.Forms.DataGridView()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCheckin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCheckout = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DGVinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtSearch.Location = New System.Drawing.Point(277, 62)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(395, 36)
        Me.txtSearch.TabIndex = 264
        Me.txtSearch.TextOffset = New System.Drawing.Point(8, 0)
        '
        'DGVinfo
        '
        Me.DGVinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVinfo.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGVinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVinfo.Location = New System.Drawing.Point(57, 120)
        Me.DGVinfo.Name = "DGVinfo"
        Me.DGVinfo.ReadOnly = True
        Me.DGVinfo.Size = New System.Drawing.Size(1005, 493)
        Me.DGVinfo.TabIndex = 263
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
        Me.GunaPanel3.TabIndex = 262
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
        Me.Guna2Button1.Location = New System.Drawing.Point(130, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(206, 37)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Check IN / Check OUT"
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
        Me.Guna2Button2.Size = New System.Drawing.Size(130, 37)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Attendance >"
        '
        'btnCheckin
        '
        Me.btnCheckin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheckin.BorderRadius = 20
        Me.btnCheckin.BorderThickness = 3
        Me.btnCheckin.CheckedState.Parent = Me.btnCheckin
        Me.btnCheckin.CustomImages.Parent = Me.btnCheckin
        Me.btnCheckin.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheckin.Font = New System.Drawing.Font("Madani Arabic DEMO", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCheckin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCheckin.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnCheckin.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCheckin.HoverState.Parent = Me.btnCheckin
        Me.btnCheckin.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnCheckin.Location = New System.Drawing.Point(692, 48)
        Me.btnCheckin.Name = "btnCheckin"
        Me.btnCheckin.ShadowDecoration.Parent = Me.btnCheckin
        Me.btnCheckin.Size = New System.Drawing.Size(175, 60)
        Me.btnCheckin.TabIndex = 267
        Me.btnCheckin.Text = "CHECK IN"
        Me.btnCheckin.TextOffset = New System.Drawing.Point(0, 3)
        '
        'btnCheckout
        '
        Me.btnCheckout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCheckout.BorderRadius = 20
        Me.btnCheckout.BorderThickness = 3
        Me.btnCheckout.CheckedState.Parent = Me.btnCheckout
        Me.btnCheckout.CustomImages.Parent = Me.btnCheckout
        Me.btnCheckout.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCheckout.Font = New System.Drawing.Font("Madani Arabic DEMO", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCheckout.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnCheckout.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnCheckout.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCheckout.HoverState.Parent = Me.btnCheckout
        Me.btnCheckout.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnCheckout.Location = New System.Drawing.Point(887, 48)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.ShadowDecoration.Parent = Me.btnCheckout
        Me.btnCheckout.Size = New System.Drawing.Size(175, 60)
        Me.btnCheckout.TabIndex = 268
        Me.btnCheckout.Text = "CHECK OUT"
        Me.btnCheckout.TextOffset = New System.Drawing.Point(0, 3)
        '
        'CheckInOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 624)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnCheckin)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DGVinfo)
        Me.Controls.Add(Me.GunaPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckInOut"
        Me.Text = "CheckInOut"
        CType(Me.DGVinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGVinfo As System.Windows.Forms.DataGridView
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheckin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheckout As Guna.UI2.WinForms.Guna2Button
End Class
