<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GymEquipmentAdd
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
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnAddEquipment = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpPurchaseDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEquipmentName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbCondition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaPanel3.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
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
        Me.GunaPanel3.TabIndex = 263
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
        Me.Guna2Button1.Location = New System.Drawing.Point(160, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(148, 37)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Add Equipment"
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
        Me.Guna2Button2.Size = New System.Drawing.Size(160, 37)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Gym Equipment>"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbCondition)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnAddEquipment)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dtpPurchaseDate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtCategory)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtEquipmentName)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(95, 84)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 20
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(929, 476)
        Me.Guna2ShadowPanel1.TabIndex = 264
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnAddEquipment.BorderRadius = 20
        Me.btnAddEquipment.BorderThickness = 2
        Me.btnAddEquipment.CheckedState.Parent = Me.btnAddEquipment
        Me.btnAddEquipment.CustomImages.Parent = Me.btnAddEquipment
        Me.btnAddEquipment.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnAddEquipment.Font = New System.Drawing.Font("Madani Arabic DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEquipment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddEquipment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddEquipment.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnAddEquipment.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddEquipment.HoverState.Parent = Me.btnAddEquipment
        Me.btnAddEquipment.Image = Global.GymManagementSystem.My.Resources.Resources.Addmember
        Me.btnAddEquipment.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAddEquipment.Location = New System.Drawing.Point(394, 384)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.PressedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddEquipment.ShadowDecoration.Parent = Me.btnAddEquipment
        Me.btnAddEquipment.Size = New System.Drawing.Size(140, 60)
        Me.btnAddEquipment.TabIndex = 167
        Me.btnAddEquipment.Text = "Add"
        '
        'dtpPurchaseDate
        '
        Me.dtpPurchaseDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.dtpPurchaseDate.BorderRadius = 10
        Me.dtpPurchaseDate.BorderThickness = 2
        Me.dtpPurchaseDate.CheckedState.Parent = Me.dtpPurchaseDate
        Me.dtpPurchaseDate.FillColor = System.Drawing.Color.White
        Me.dtpPurchaseDate.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurchaseDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.dtpPurchaseDate.HoverState.Parent = Me.dtpPurchaseDate
        Me.dtpPurchaseDate.Location = New System.Drawing.Point(105, 285)
        Me.dtpPurchaseDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpPurchaseDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpPurchaseDate.Name = "dtpPurchaseDate"
        Me.dtpPurchaseDate.ShadowDecoration.Parent = Me.dtpPurchaseDate
        Me.dtpPurchaseDate.Size = New System.Drawing.Size(292, 45)
        Me.dtpPurchaseDate.TabIndex = 166
        Me.dtpPurchaseDate.Value = New Date(2025, 8, 8, 1, 32, 57, 784)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(531, 255)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(98, 23)
        Me.Guna2HtmlLabel4.TabIndex = 165
        Me.Guna2HtmlLabel4.Text = "Condition"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(105, 256)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(140, 23)
        Me.Guna2HtmlLabel5.TabIndex = 165
        Me.Guna2HtmlLabel5.Text = "Purchase Date"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(531, 125)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(96, 23)
        Me.Guna2HtmlLabel3.TabIndex = 165
        Me.Guna2HtmlLabel3.Text = "Category"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("LEMON MILK Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(105, 125)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(152, 23)
        Me.Guna2HtmlLabel2.TabIndex = 165
        Me.Guna2HtmlLabel2.Text = "Equipment Name"
        '
        'txtCategory
        '
        Me.txtCategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCategory.BorderRadius = 10
        Me.txtCategory.BorderThickness = 2
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.DefaultText = ""
        Me.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.DisabledState.Parent = Me.txtCategory
        Me.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.FocusedState.Parent = Me.txtCategory
        Me.txtCategory.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.HoverState.Parent = Me.txtCategory
        Me.txtCategory.Location = New System.Drawing.Point(531, 155)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategory.PlaceholderText = "Contact number"
        Me.txtCategory.SelectedText = ""
        Me.txtCategory.ShadowDecoration.Parent = Me.txtCategory
        Me.txtCategory.Size = New System.Drawing.Size(292, 45)
        Me.txtCategory.TabIndex = 164
        '
        'txtEquipmentName
        '
        Me.txtEquipmentName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtEquipmentName.BorderRadius = 10
        Me.txtEquipmentName.BorderThickness = 2
        Me.txtEquipmentName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEquipmentName.DefaultText = ""
        Me.txtEquipmentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEquipmentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEquipmentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipmentName.DisabledState.Parent = Me.txtEquipmentName
        Me.txtEquipmentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEquipmentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipmentName.FocusedState.Parent = Me.txtEquipmentName
        Me.txtEquipmentName.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipmentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEquipmentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipmentName.HoverState.Parent = Me.txtEquipmentName
        Me.txtEquipmentName.Location = New System.Drawing.Point(105, 155)
        Me.txtEquipmentName.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtEquipmentName.Name = "txtEquipmentName"
        Me.txtEquipmentName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEquipmentName.PlaceholderText = "Full Name"
        Me.txtEquipmentName.SelectedText = ""
        Me.txtEquipmentName.ShadowDecoration.Parent = Me.txtEquipmentName
        Me.txtEquipmentName.Size = New System.Drawing.Size(292, 45)
        Me.txtEquipmentName.TabIndex = 162
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("LEMON MILK Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(42, 27)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(289, 36)
        Me.Guna2HtmlLabel1.TabIndex = 161
        Me.Guna2HtmlLabel1.Text = "Add New Equipment"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(95, 153)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(926, 8)
        Me.Guna2Panel1.TabIndex = 0
        '
        'cmbCondition
        '
        Me.cmbCondition.BackColor = System.Drawing.Color.Transparent
        Me.cmbCondition.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cmbCondition.BorderRadius = 10
        Me.cmbCondition.BorderThickness = 2
        Me.cmbCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCondition.FocusedState.Parent = Me.cmbCondition
        Me.cmbCondition.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!)
        Me.cmbCondition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCondition.FormattingEnabled = True
        Me.cmbCondition.HoverState.Parent = Me.cmbCondition
        Me.cmbCondition.ItemHeight = 30
        Me.cmbCondition.Items.AddRange(New Object() {"Condition", "good", "needs repair", "out of service"})
        Me.cmbCondition.ItemsAppearance.Parent = Me.cmbCondition
        Me.cmbCondition.Location = New System.Drawing.Point(536, 288)
        Me.cmbCondition.Name = "cmbCondition"
        Me.cmbCondition.ShadowDecoration.Parent = Me.cmbCondition
        Me.cmbCondition.Size = New System.Drawing.Size(286, 36)
        Me.cmbCondition.TabIndex = 168
        '
        'GymEquipmentAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 624)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.GunaPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GymEquipmentAdd"
        Me.Text = "GymEquipmentAdd"
        Me.GunaPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEquipmentName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpPurchaseDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAddEquipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCondition As Guna.UI2.WinForms.Guna2ComboBox
End Class
