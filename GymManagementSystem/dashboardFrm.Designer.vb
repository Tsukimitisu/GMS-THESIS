<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardFrm
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
        Me.SidebarPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.AttendancePanel = New Guna.UI.WinForms.GunaPanel()
        Me.EquipmentPanel = New Guna.UI.WinForms.GunaPanel()
        Me.ManagePanel = New Guna.UI.WinForms.GunaPanel()
        Me.panelDisplayfrm = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.btnAccount = New Guna.UI.WinForms.GunaButton()
        Me.btnPayment = New Guna.UI.WinForms.GunaButton()
        Me.btnStatus = New Guna.UI.WinForms.GunaButton()
        Me.btnView = New Guna.UI.WinForms.GunaButton()
        Me.btnCheckIn = New Guna.UI.WinForms.GunaButton()
        Me.btnAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnAddEquipment = New Guna.UI.WinForms.GunaButton()
        Me.btnEquipmentList = New Guna.UI.WinForms.GunaButton()
        Me.btnEquipment = New Guna.UI.WinForms.GunaButton()
        Me.btnAddMember = New Guna.UI.WinForms.GunaButton()
        Me.btnAllmember = New Guna.UI.WinForms.GunaButton()
        Me.btnManageMember = New Guna.UI.WinForms.GunaButton()
        Me.btnDashboard = New Guna.UI.WinForms.GunaButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SidebarPanel.SuspendLayout()
        Me.AttendancePanel.SuspendLayout()
        Me.EquipmentPanel.SuspendLayout()
        Me.ManagePanel.SuspendLayout()
        Me.panelDisplayfrm.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SidebarPanel
        '
        Me.SidebarPanel.AutoScroll = True
        Me.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SidebarPanel.Controls.Add(Me.btnAccount)
        Me.SidebarPanel.Controls.Add(Me.btnPayment)
        Me.SidebarPanel.Controls.Add(Me.btnStatus)
        Me.SidebarPanel.Controls.Add(Me.AttendancePanel)
        Me.SidebarPanel.Controls.Add(Me.btnAttendance)
        Me.SidebarPanel.Controls.Add(Me.EquipmentPanel)
        Me.SidebarPanel.Controls.Add(Me.btnEquipment)
        Me.SidebarPanel.Controls.Add(Me.ManagePanel)
        Me.SidebarPanel.Controls.Add(Me.btnManageMember)
        Me.SidebarPanel.Controls.Add(Me.btnDashboard)
        Me.SidebarPanel.Controls.Add(Me.Guna2Panel2)
        Me.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarPanel.Location = New System.Drawing.Point(0, 0)
        Me.SidebarPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.SidebarPanel.Name = "SidebarPanel"
        Me.SidebarPanel.ShadowDecoration.Parent = Me.SidebarPanel
        Me.SidebarPanel.Size = New System.Drawing.Size(240, 661)
        Me.SidebarPanel.TabIndex = 0
        '
        'AttendancePanel
        '
        Me.AttendancePanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.AttendancePanel.Controls.Add(Me.btnView)
        Me.AttendancePanel.Controls.Add(Me.btnCheckIn)
        Me.AttendancePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AttendancePanel.Location = New System.Drawing.Point(0, 633)
        Me.AttendancePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.AttendancePanel.Name = "AttendancePanel"
        Me.AttendancePanel.Size = New System.Drawing.Size(223, 140)
        Me.AttendancePanel.TabIndex = 7
        '
        'EquipmentPanel
        '
        Me.EquipmentPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.EquipmentPanel.Controls.Add(Me.btnAddEquipment)
        Me.EquipmentPanel.Controls.Add(Me.btnEquipmentList)
        Me.EquipmentPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EquipmentPanel.Location = New System.Drawing.Point(0, 423)
        Me.EquipmentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.EquipmentPanel.Name = "EquipmentPanel"
        Me.EquipmentPanel.Size = New System.Drawing.Size(223, 140)
        Me.EquipmentPanel.TabIndex = 5
        '
        'ManagePanel
        '
        Me.ManagePanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ManagePanel.Controls.Add(Me.btnAddMember)
        Me.ManagePanel.Controls.Add(Me.btnAllmember)
        Me.ManagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ManagePanel.Location = New System.Drawing.Point(0, 213)
        Me.ManagePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ManagePanel.Name = "ManagePanel"
        Me.ManagePanel.Size = New System.Drawing.Size(223, 140)
        Me.ManagePanel.TabIndex = 3
        '
        'panelDisplayfrm
        '
        Me.panelDisplayfrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.panelDisplayfrm.Controls.Add(Me.GunaPanel3)
        Me.panelDisplayfrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDisplayfrm.Location = New System.Drawing.Point(240, 37)
        Me.panelDisplayfrm.Margin = New System.Windows.Forms.Padding(2)
        Me.panelDisplayfrm.Name = "panelDisplayfrm"
        Me.panelDisplayfrm.Size = New System.Drawing.Size(1104, 624)
        Me.panelDisplayfrm.TabIndex = 1
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.White
        Me.GunaPanel3.Controls.Add(Me.Guna2Button2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1104, 37)
        Me.GunaPanel3.TabIndex = 1
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button2.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2Button2.Location = New System.Drawing.Point(5, 3)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(104, 31)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Dashboard"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaPanel2.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel7)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(240, 0)
        Me.GunaPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1104, 37)
        Me.GunaPanel2.TabIndex = 0
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("LEMON MILK Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(445, 9)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(288, 23)
        Me.GunaLabel7.TabIndex = 4
        Me.GunaLabel7.Text = """Let's Make Healthy Happen"""
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.GymManagementSystem.My.Resources.Resources.close
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(1068, 6)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(25, 24)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox1.TabIndex = 23
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'btnAccount
        '
        Me.btnAccount.AnimationHoverSpeed = 0.07!
        Me.btnAccount.AnimationSpeed = 0.03!
        Me.btnAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnAccount.BaseColor = System.Drawing.Color.Transparent
        Me.btnAccount.BorderColor = System.Drawing.Color.Black
        Me.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnAccount.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.White
        Me.btnAccount.Image = Global.GymManagementSystem.My.Resources.Resources.acountmanage
        Me.btnAccount.ImageOffsetX = 10
        Me.btnAccount.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAccount.Location = New System.Drawing.Point(0, 913)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAccount.OnHoverImage = Nothing
        Me.btnAccount.OnPressedColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAccount.Size = New System.Drawing.Size(223, 70)
        Me.btnAccount.TabIndex = 10
        Me.btnAccount.Text = "Account Management"
        '
        'btnPayment
        '
        Me.btnPayment.AnimationHoverSpeed = 0.07!
        Me.btnPayment.AnimationSpeed = 0.03!
        Me.btnPayment.BackColor = System.Drawing.Color.Transparent
        Me.btnPayment.BaseColor = System.Drawing.Color.Transparent
        Me.btnPayment.BorderColor = System.Drawing.Color.Black
        Me.btnPayment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayment.FocusedColor = System.Drawing.Color.Empty
        Me.btnPayment.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Image = Global.GymManagementSystem.My.Resources.Resources.paymentrecord
        Me.btnPayment.ImageOffsetX = 10
        Me.btnPayment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPayment.Location = New System.Drawing.Point(0, 843)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPayment.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPayment.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPayment.OnHoverImage = Nothing
        Me.btnPayment.OnPressedColor = System.Drawing.Color.DarkSlateBlue
        Me.btnPayment.Size = New System.Drawing.Size(223, 70)
        Me.btnPayment.TabIndex = 9
        Me.btnPayment.Text = "Payment Record"
        Me.btnPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStatus
        '
        Me.btnStatus.AnimationHoverSpeed = 0.07!
        Me.btnStatus.AnimationSpeed = 0.03!
        Me.btnStatus.BackColor = System.Drawing.Color.Transparent
        Me.btnStatus.BaseColor = System.Drawing.Color.Transparent
        Me.btnStatus.BorderColor = System.Drawing.Color.Black
        Me.btnStatus.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStatus.FocusedColor = System.Drawing.Color.Empty
        Me.btnStatus.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.ForeColor = System.Drawing.Color.White
        Me.btnStatus.Image = Global.GymManagementSystem.My.Resources.Resources.personstatus
        Me.btnStatus.ImageOffsetX = 10
        Me.btnStatus.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnStatus.Location = New System.Drawing.Point(0, 773)
        Me.btnStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStatus.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStatus.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStatus.OnHoverImage = Nothing
        Me.btnStatus.OnPressedColor = System.Drawing.Color.DarkSlateBlue
        Me.btnStatus.Size = New System.Drawing.Size(223, 70)
        Me.btnStatus.TabIndex = 8
        Me.btnStatus.Text = "Member Status"
        Me.btnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnView
        '
        Me.btnView.AnimationHoverSpeed = 0.07!
        Me.btnView.AnimationSpeed = 0.03!
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnView.BorderColor = System.Drawing.Color.Black
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnView.FocusedColor = System.Drawing.Color.Empty
        Me.btnView.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = Global.GymManagementSystem.My.Resources.Resources.Equipmentlist1
        Me.btnView.ImageOffsetX = 10
        Me.btnView.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnView.Location = New System.Drawing.Point(0, 70)
        Me.btnView.Margin = New System.Windows.Forms.Padding(2)
        Me.btnView.Name = "btnView"
        Me.btnView.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnView.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnView.OnHoverForeColor = System.Drawing.Color.White
        Me.btnView.OnHoverImage = Nothing
        Me.btnView.OnPressedColor = System.Drawing.Color.Black
        Me.btnView.Size = New System.Drawing.Size(223, 70)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View"
        '
        'btnCheckIn
        '
        Me.btnCheckIn.AnimationHoverSpeed = 0.07!
        Me.btnCheckIn.AnimationSpeed = 0.03!
        Me.btnCheckIn.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckIn.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCheckIn.BorderColor = System.Drawing.Color.Black
        Me.btnCheckIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCheckIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCheckIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnCheckIn.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.Image = Global.GymManagementSystem.My.Resources.Resources.inandout
        Me.btnCheckIn.ImageOffsetX = 10
        Me.btnCheckIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCheckIn.Location = New System.Drawing.Point(0, 0)
        Me.btnCheckIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCheckIn.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCheckIn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCheckIn.OnHoverImage = Nothing
        Me.btnCheckIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnCheckIn.Size = New System.Drawing.Size(223, 70)
        Me.btnCheckIn.TabIndex = 0
        Me.btnCheckIn.Text = "Check in/out"
        '
        'btnAttendance
        '
        Me.btnAttendance.AnimationHoverSpeed = 0.07!
        Me.btnAttendance.AnimationSpeed = 0.03!
        Me.btnAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnAttendance.BaseColor = System.Drawing.Color.Transparent
        Me.btnAttendance.BorderColor = System.Drawing.Color.Black
        Me.btnAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnAttendance.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.Image = Global.GymManagementSystem.My.Resources.Resources.attendance
        Me.btnAttendance.ImageOffsetX = 10
        Me.btnAttendance.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAttendance.Location = New System.Drawing.Point(0, 563)
        Me.btnAttendance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAttendance.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAttendance.OnHoverImage = Nothing
        Me.btnAttendance.OnPressedColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAttendance.Size = New System.Drawing.Size(223, 70)
        Me.btnAttendance.TabIndex = 6
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.AnimationHoverSpeed = 0.07!
        Me.btnAddEquipment.AnimationSpeed = 0.03!
        Me.btnAddEquipment.BackColor = System.Drawing.Color.Transparent
        Me.btnAddEquipment.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAddEquipment.BorderColor = System.Drawing.Color.Black
        Me.btnAddEquipment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddEquipment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddEquipment.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddEquipment.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnAddEquipment.ForeColor = System.Drawing.Color.White
        Me.btnAddEquipment.Image = Global.GymManagementSystem.My.Resources.Resources.Gymadd
        Me.btnAddEquipment.ImageOffsetX = 10
        Me.btnAddEquipment.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddEquipment.Location = New System.Drawing.Point(0, 70)
        Me.btnAddEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddEquipment.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAddEquipment.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddEquipment.OnHoverImage = Nothing
        Me.btnAddEquipment.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddEquipment.Size = New System.Drawing.Size(223, 70)
        Me.btnAddEquipment.TabIndex = 1
        Me.btnAddEquipment.Text = "Add Equipment"
        '
        'btnEquipmentList
        '
        Me.btnEquipmentList.AnimationHoverSpeed = 0.07!
        Me.btnEquipmentList.AnimationSpeed = 0.03!
        Me.btnEquipmentList.BackColor = System.Drawing.Color.Transparent
        Me.btnEquipmentList.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEquipmentList.BorderColor = System.Drawing.Color.Black
        Me.btnEquipmentList.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEquipmentList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEquipmentList.FocusedColor = System.Drawing.Color.Empty
        Me.btnEquipmentList.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnEquipmentList.ForeColor = System.Drawing.Color.White
        Me.btnEquipmentList.Image = Global.GymManagementSystem.My.Resources.Resources.Equipmentlist
        Me.btnEquipmentList.ImageOffsetX = 10
        Me.btnEquipmentList.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEquipmentList.Location = New System.Drawing.Point(0, 0)
        Me.btnEquipmentList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEquipmentList.Name = "btnEquipmentList"
        Me.btnEquipmentList.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEquipmentList.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnEquipmentList.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEquipmentList.OnHoverImage = Nothing
        Me.btnEquipmentList.OnPressedColor = System.Drawing.Color.Black
        Me.btnEquipmentList.Size = New System.Drawing.Size(223, 70)
        Me.btnEquipmentList.TabIndex = 0
        Me.btnEquipmentList.Text = "List All Equipment"
        '
        'btnEquipment
        '
        Me.btnEquipment.AnimationHoverSpeed = 0.07!
        Me.btnEquipment.AnimationSpeed = 0.03!
        Me.btnEquipment.BackColor = System.Drawing.Color.Transparent
        Me.btnEquipment.BaseColor = System.Drawing.Color.Transparent
        Me.btnEquipment.BorderColor = System.Drawing.Color.Black
        Me.btnEquipment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEquipment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEquipment.FocusedColor = System.Drawing.Color.Empty
        Me.btnEquipment.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipment.ForeColor = System.Drawing.Color.White
        Me.btnEquipment.Image = Global.GymManagementSystem.My.Resources.Resources.gymEquipment
        Me.btnEquipment.ImageOffsetX = 10
        Me.btnEquipment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEquipment.Location = New System.Drawing.Point(0, 353)
        Me.btnEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEquipment.Name = "btnEquipment"
        Me.btnEquipment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEquipment.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEquipment.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEquipment.OnHoverImage = Nothing
        Me.btnEquipment.OnPressedColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEquipment.Size = New System.Drawing.Size(223, 70)
        Me.btnEquipment.TabIndex = 4
        Me.btnEquipment.Text = "Gym Equipment"
        Me.btnEquipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddMember
        '
        Me.btnAddMember.AnimationHoverSpeed = 0.07!
        Me.btnAddMember.AnimationSpeed = 0.03!
        Me.btnAddMember.BackColor = System.Drawing.Color.Transparent
        Me.btnAddMember.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAddMember.BorderColor = System.Drawing.Color.Black
        Me.btnAddMember.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddMember.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddMember.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnAddMember.ForeColor = System.Drawing.Color.White
        Me.btnAddMember.Image = Global.GymManagementSystem.My.Resources.Resources.Addmember
        Me.btnAddMember.ImageOffsetX = 10
        Me.btnAddMember.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddMember.Location = New System.Drawing.Point(0, 70)
        Me.btnAddMember.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddMember.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAddMember.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddMember.OnHoverImage = Nothing
        Me.btnAddMember.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddMember.Size = New System.Drawing.Size(223, 70)
        Me.btnAddMember.TabIndex = 1
        Me.btnAddMember.Text = "Membership Form"
        '
        'btnAllmember
        '
        Me.btnAllmember.AnimationHoverSpeed = 0.07!
        Me.btnAllmember.AnimationSpeed = 0.03!
        Me.btnAllmember.BackColor = System.Drawing.Color.Transparent
        Me.btnAllmember.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAllmember.BorderColor = System.Drawing.Color.Black
        Me.btnAllmember.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAllmember.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAllmember.FocusedColor = System.Drawing.Color.Empty
        Me.btnAllmember.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnAllmember.ForeColor = System.Drawing.Color.White
        Me.btnAllmember.Image = Global.GymManagementSystem.My.Resources.Resources.memberlist
        Me.btnAllmember.ImageOffsetX = 10
        Me.btnAllmember.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAllmember.Location = New System.Drawing.Point(0, 0)
        Me.btnAllmember.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAllmember.Name = "btnAllmember"
        Me.btnAllmember.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAllmember.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnAllmember.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAllmember.OnHoverImage = Nothing
        Me.btnAllmember.OnPressedColor = System.Drawing.Color.Black
        Me.btnAllmember.Size = New System.Drawing.Size(223, 70)
        Me.btnAllmember.TabIndex = 0
        Me.btnAllmember.Text = "List All Members"
        '
        'btnManageMember
        '
        Me.btnManageMember.AnimationHoverSpeed = 0.07!
        Me.btnManageMember.AnimationSpeed = 0.03!
        Me.btnManageMember.BackColor = System.Drawing.Color.Transparent
        Me.btnManageMember.BaseColor = System.Drawing.Color.Transparent
        Me.btnManageMember.BorderColor = System.Drawing.Color.Black
        Me.btnManageMember.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnManageMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageMember.FocusedColor = System.Drawing.Color.Empty
        Me.btnManageMember.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnManageMember.ForeColor = System.Drawing.Color.White
        Me.btnManageMember.Image = Global.GymManagementSystem.My.Resources.Resources.Managemember
        Me.btnManageMember.ImageOffsetX = 10
        Me.btnManageMember.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnManageMember.Location = New System.Drawing.Point(0, 143)
        Me.btnManageMember.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManageMember.Name = "btnManageMember"
        Me.btnManageMember.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageMember.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnManageMember.OnHoverForeColor = System.Drawing.Color.White
        Me.btnManageMember.OnHoverImage = Nothing
        Me.btnManageMember.OnPressedColor = System.Drawing.Color.DarkSlateBlue
        Me.btnManageMember.Size = New System.Drawing.Size(223, 70)
        Me.btnManageMember.TabIndex = 2
        Me.btnManageMember.Text = "Manage Member"
        '
        'btnDashboard
        '
        Me.btnDashboard.AnimationHoverSpeed = 0.07!
        Me.btnDashboard.AnimationSpeed = 0.03!
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BaseColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BorderColor = System.Drawing.Color.Black
        Me.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FocusedColor = System.Drawing.Color.Empty
        Me.btnDashboard.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.GymManagementSystem.My.Resources.Resources.Dashboard1
        Me.btnDashboard.ImageOffsetX = 10
        Me.btnDashboard.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 73)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDashboard.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDashboard.OnHoverImage = Nothing
        Me.btnDashboard.OnPressedColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDashboard.Size = New System.Drawing.Size(223, 70)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackgroundImage = Global.GymManagementSystem.My.Resources.Resources.GymWhiteBG
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(223, 73)
        Me.Guna2Panel2.TabIndex = 0
        '
        'dashboardFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 661)
        Me.Controls.Add(Me.panelDisplayfrm)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.SidebarPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dashboardFrm"
        Me.Text = "dashboardFrm"
        Me.SidebarPanel.ResumeLayout(False)
        Me.AttendancePanel.ResumeLayout(False)
        Me.EquipmentPanel.ResumeLayout(False)
        Me.ManagePanel.ResumeLayout(False)
        Me.panelDisplayfrm.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SidebarPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ManagePanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnAddMember As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAllmember As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnManageMember As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDashboard As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEquipment As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPayment As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStatus As Guna.UI.WinForms.GunaButton
    Friend WithEvents AttendancePanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnView As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCheckIn As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents EquipmentPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnAddEquipment As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEquipmentList As Guna.UI.WinForms.GunaButton
    Friend WithEvents panelDisplayfrm As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
