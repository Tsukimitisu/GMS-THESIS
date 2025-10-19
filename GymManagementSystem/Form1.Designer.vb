<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Loginbtn = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.btnCreate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.panelRegister = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.seePassbtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.panelHome.SuspendLayout()
        Me.panelRegister.SuspendLayout()
        CType(Me.seePassbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHome
        '
        Me.panelHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.panelHome.BorderRadius = 10
        Me.panelHome.Controls.Add(Me.Loginbtn)
        Me.panelHome.Controls.Add(Me.GunaLabel6)
        Me.panelHome.Controls.Add(Me.btnCreate)
        Me.panelHome.Controls.Add(Me.GunaLabel5)
        Me.panelHome.Controls.Add(Me.seePassbtn)
        Me.panelHome.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.panelHome.Controls.Add(Me.GunaLabel4)
        Me.panelHome.Controls.Add(Me.GunaLabel3)
        Me.panelHome.Controls.Add(Me.txtPassword)
        Me.panelHome.Controls.Add(Me.GunaLabel2)
        Me.panelHome.Controls.Add(Me.GunaLabel1)
        Me.panelHome.Controls.Add(Me.txtUser)
        Me.panelHome.ForeColor = System.Drawing.Color.White
        Me.panelHome.Location = New System.Drawing.Point(0, -6)
        Me.panelHome.Margin = New System.Windows.Forms.Padding(2)
        Me.panelHome.Name = "panelHome"
        Me.panelHome.ShadowDecoration.Parent = Me.panelHome
        Me.panelHome.Size = New System.Drawing.Size(491, 594)
        Me.panelHome.TabIndex = 2
        '
        'Loginbtn
        '
        Me.Loginbtn.AnimationHoverSpeed = 0.07!
        Me.Loginbtn.AnimationSpeed = 0.03!
        Me.Loginbtn.BackColor = System.Drawing.Color.Transparent
        Me.Loginbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loginbtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loginbtn.BorderSize = 3
        Me.Loginbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Loginbtn.FocusedColor = System.Drawing.Color.Empty
        Me.Loginbtn.Font = New System.Drawing.Font("LEMON MILK Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Loginbtn.Image = Nothing
        Me.Loginbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Loginbtn.Location = New System.Drawing.Point(181, 456)
        Me.Loginbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Loginbtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loginbtn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loginbtn.OnHoverImage = Nothing
        Me.Loginbtn.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loginbtn.Radius = 20
        Me.Loginbtn.Size = New System.Drawing.Size(130, 55)
        Me.Loginbtn.TabIndex = 13
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Geoform", 9.000001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(291, 418)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(122, 16)
        Me.GunaLabel6.TabIndex = 12
        Me.GunaLabel6.Text = "Forgot Password?"
        '
        'btnCreate
        '
        Me.btnCreate.AutoSize = True
        Me.btnCreate.Font = New System.Drawing.Font("Geoform", 9.000001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreate.Location = New System.Drawing.Point(297, 536)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(50, 16)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "Create"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Geoform", 9.000001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(139, 536)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(159, 16)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "Don't have an account ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Geoform", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(91, 353)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(86, 20)
        Me.GunaLabel4.TabIndex = 6
        Me.GunaLabel4.Text = "Password"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Geoform", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(91, 262)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(89, 20)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Username"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("LEMON MILK Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(154, 89)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(200, 20)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Sign to your account"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("LEMON MILK Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(173, 31)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(145, 46)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Hello!"
        '
        'panelRegister
        '
        Me.panelRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelRegister.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.panelRegister.Controls.Add(Me.GunaLabel7)
        Me.panelRegister.Controls.Add(Me.GunaPictureBox1)
        Me.panelRegister.Location = New System.Drawing.Point(491, 0)
        Me.panelRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.panelRegister.MaximumSize = New System.Drawing.Size(509, 586)
        Me.panelRegister.MinimumSize = New System.Drawing.Size(509, 586)
        Me.panelRegister.Name = "panelRegister"
        Me.panelRegister.Size = New System.Drawing.Size(509, 586)
        Me.panelRegister.TabIndex = 3
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("LEMON MILK Bold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(28, 330)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(479, 38)
        Me.GunaLabel7.TabIndex = 3
        Me.GunaLabel7.Text = """Let's Make Healthy Happen"""
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_NEGATIVE
        Me.GunaAnimateWindow1.Interval = 4000
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'seePassbtn
        '
        Me.seePassbtn.BackColor = System.Drawing.Color.White
        Me.seePassbtn.BaseColor = System.Drawing.Color.White
        Me.seePassbtn.Image = Global.GymManagementSystem.My.Resources.Resources.eye
        Me.seePassbtn.Location = New System.Drawing.Point(372, 381)
        Me.seePassbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.seePassbtn.Name = "seePassbtn"
        Me.seePassbtn.Size = New System.Drawing.Size(26, 28)
        Me.seePassbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.seePassbtn.TabIndex = 9
        Me.seePassbtn.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTransfarantPictureBox1.Image = Global.GymManagementSystem.My.Resources.Resources.gym
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(196, 123)
        Me.GunaTransfarantPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(98, 106)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 7
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.BorderThickness = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Geoform", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.IconLeft = Global.GymManagementSystem.My.Resources.Resources.padlockblackfill
        Me.txtPassword.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtPassword.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtPassword.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.txtPassword.Location = New System.Drawing.Point(82, 378)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(326, 35)
        Me.txtPassword.TabIndex = 4
        '
        'txtUser
        '
        Me.txtUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtUser.BorderRadius = 10
        Me.txtUser.BorderThickness = 2
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.DefaultText = ""
        Me.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.DisabledState.Parent = Me.txtUser
        Me.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtUser.FocusedState.Parent = Me.txtUser
        Me.txtUser.Font = New System.Drawing.Font("Geoform", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtUser.HoverState.Parent = Me.txtUser
        Me.txtUser.IconLeft = Global.GymManagementSystem.My.Resources.Resources.userblackfill
        Me.txtUser.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtUser.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtUser.Location = New System.Drawing.Point(82, 288)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PlaceholderText = "Username"
        Me.txtUser.SelectedText = ""
        Me.txtUser.ShadowDecoration.Parent = Me.txtUser
        Me.txtUser.Size = New System.Drawing.Size(326, 35)
        Me.txtUser.TabIndex = 1
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.GymManagementSystem.My.Resources.Resources.close
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(478, 5)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(25, 24)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox2.TabIndex = 23
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.GymManagementSystem.My.Resources.Resources.GymLogoWhite
        Me.GunaPictureBox1.Location = New System.Drawing.Point(78, 216)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(352, 101)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1001, 586)
        Me.Controls.Add(Me.panelHome)
        Me.Controls.Add(Me.panelRegister)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.panelHome.ResumeLayout(False)
        Me.panelHome.PerformLayout()
        Me.panelRegister.ResumeLayout(False)
        Me.panelRegister.PerformLayout()
        CType(Me.seePassbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents seePassbtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnCreate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panelRegister As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Loginbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow

End Class
