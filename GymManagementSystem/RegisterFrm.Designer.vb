<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterFrm
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
        Me.panelRegister = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogin = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.panelHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Registerbtn = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.seePassbtn = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtSecAnswer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSecQuestion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.seepass2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.panelRegister.SuspendLayout()
        Me.panelHome.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seePassbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seepass2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelRegister
        '
        Me.panelRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.panelRegister.Controls.Add(Me.GunaPictureBox1)
        Me.panelRegister.Location = New System.Drawing.Point(0, 0)
        Me.panelRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.panelRegister.Name = "panelRegister"
        Me.panelRegister.Size = New System.Drawing.Size(508, 586)
        Me.panelRegister.TabIndex = 6
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(127, 42)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(258, 29)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Create an Account"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(127, 102)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(98, 18)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Username"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(127, 175)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(95, 18)
        Me.GunaLabel4.TabIndex = 6
        Me.GunaLabel4.Text = "Password"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(165, 543)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(127, 14)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "Do have an account?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnLogin
        '
        Me.btnLogin.AutoSize = True
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(296, 542)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(43, 15)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "Login"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(127, 248)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(169, 18)
        Me.GunaLabel1.TabIndex = 14
        Me.GunaLabel1.Text = "Confirm Password"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(127, 321)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(162, 18)
        Me.GunaLabel6.TabIndex = 17
        Me.GunaLabel6.Text = "Security Question"
        '
        'panelHome
        '
        Me.panelHome.BackColor = System.Drawing.Color.Transparent
        Me.panelHome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelHome.BorderRadius = 20
        Me.panelHome.BorderThickness = 2
        Me.panelHome.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.panelHome.Controls.Add(Me.Registerbtn)
        Me.panelHome.Controls.Add(Me.seePassbtn)
        Me.panelHome.Controls.Add(Me.GunaLabel7)
        Me.panelHome.Controls.Add(Me.txtSecAnswer)
        Me.panelHome.Controls.Add(Me.GunaLabel6)
        Me.panelHome.Controls.Add(Me.txtSecQuestion)
        Me.panelHome.Controls.Add(Me.seepass2)
        Me.panelHome.Controls.Add(Me.GunaLabel1)
        Me.panelHome.Controls.Add(Me.txtConfirmPass)
        Me.panelHome.Controls.Add(Me.btnLogin)
        Me.panelHome.Controls.Add(Me.GunaLabel5)
        Me.panelHome.Controls.Add(Me.GunaLabel4)
        Me.panelHome.Controls.Add(Me.GunaLabel3)
        Me.panelHome.Controls.Add(Me.txtPassword)
        Me.panelHome.Controls.Add(Me.GunaLabel2)
        Me.panelHome.Controls.Add(Me.txtUsername)
        Me.panelHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelHome.ForeColor = System.Drawing.Color.White
        Me.panelHome.Location = New System.Drawing.Point(506, 0)
        Me.panelHome.Margin = New System.Windows.Forms.Padding(2)
        Me.panelHome.Name = "panelHome"
        Me.panelHome.ShadowDecoration.Parent = Me.panelHome
        Me.panelHome.Size = New System.Drawing.Size(504, 584)
        Me.panelHome.TabIndex = 5
        '
        'Registerbtn
        '
        Me.Registerbtn.AnimationHoverSpeed = 0.07!
        Me.Registerbtn.AnimationSpeed = 0.03!
        Me.Registerbtn.BackColor = System.Drawing.Color.Transparent
        Me.Registerbtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Registerbtn.BorderColor = System.Drawing.Color.Indigo
        Me.Registerbtn.BorderSize = 3
        Me.Registerbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Registerbtn.FocusedColor = System.Drawing.Color.Empty
        Me.Registerbtn.Font = New System.Drawing.Font("LEMON MILK Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registerbtn.ForeColor = System.Drawing.Color.Indigo
        Me.Registerbtn.Image = Nothing
        Me.Registerbtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Registerbtn.Location = New System.Drawing.Point(187, 472)
        Me.Registerbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Registerbtn.Name = "Registerbtn"
        Me.Registerbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Registerbtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Registerbtn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Registerbtn.OnHoverImage = Nothing
        Me.Registerbtn.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Registerbtn.Radius = 20
        Me.Registerbtn.Size = New System.Drawing.Size(130, 55)
        Me.Registerbtn.TabIndex = 21
        Me.Registerbtn.Text = "Register"
        Me.Registerbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(127, 398)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(75, 18)
        Me.GunaLabel7.TabIndex = 20
        Me.GunaLabel7.Text = "Answer"
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.GymManagementSystem.My.Resources.Resources.close
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(457, 8)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(25, 24)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox1.TabIndex = 22
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'seePassbtn
        '
        Me.seePassbtn.BackColor = System.Drawing.Color.White
        Me.seePassbtn.BaseColor = System.Drawing.Color.White
        Me.seePassbtn.Image = Global.GymManagementSystem.My.Resources.Resources.eye
        Me.seePassbtn.Location = New System.Drawing.Point(342, 275)
        Me.seePassbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.seePassbtn.Name = "seePassbtn"
        Me.seePassbtn.Size = New System.Drawing.Size(26, 28)
        Me.seePassbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.seePassbtn.TabIndex = 9
        Me.seePassbtn.TabStop = False
        '
        'txtSecAnswer
        '
        Me.txtSecAnswer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtSecAnswer.BorderRadius = 10
        Me.txtSecAnswer.BorderThickness = 3
        Me.txtSecAnswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecAnswer.DefaultText = ""
        Me.txtSecAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecAnswer.DisabledState.Parent = Me.txtSecAnswer
        Me.txtSecAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtSecAnswer.FocusedState.Parent = Me.txtSecAnswer
        Me.txtSecAnswer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSecAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSecAnswer.HoverState.Parent = Me.txtSecAnswer
        Me.txtSecAnswer.IconLeft = Global.GymManagementSystem.My.Resources.Resources.padlockblackfill
        Me.txtSecAnswer.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtSecAnswer.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtSecAnswer.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.txtSecAnswer.Location = New System.Drawing.Point(121, 417)
        Me.txtSecAnswer.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecAnswer.Name = "txtSecAnswer"
        Me.txtSecAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecAnswer.PlaceholderText = "Answer"
        Me.txtSecAnswer.SelectedText = ""
        Me.txtSecAnswer.ShadowDecoration.Parent = Me.txtSecAnswer
        Me.txtSecAnswer.Size = New System.Drawing.Size(254, 37)
        Me.txtSecAnswer.TabIndex = 19
        '
        'txtSecQuestion
        '
        Me.txtSecQuestion.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtSecQuestion.BorderRadius = 10
        Me.txtSecQuestion.BorderThickness = 3
        Me.txtSecQuestion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecQuestion.DefaultText = ""
        Me.txtSecQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQuestion.DisabledState.Parent = Me.txtSecQuestion
        Me.txtSecQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtSecQuestion.FocusedState.Parent = Me.txtSecQuestion
        Me.txtSecQuestion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSecQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSecQuestion.HoverState.Parent = Me.txtSecQuestion
        Me.txtSecQuestion.IconLeft = Global.GymManagementSystem.My.Resources.Resources.padlockblackfill
        Me.txtSecQuestion.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtSecQuestion.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtSecQuestion.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.txtSecQuestion.Location = New System.Drawing.Point(121, 344)
        Me.txtSecQuestion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSecQuestion.Name = "txtSecQuestion"
        Me.txtSecQuestion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecQuestion.PlaceholderText = "Security Question"
        Me.txtSecQuestion.SelectedText = ""
        Me.txtSecQuestion.ShadowDecoration.Parent = Me.txtSecQuestion
        Me.txtSecQuestion.Size = New System.Drawing.Size(254, 37)
        Me.txtSecQuestion.TabIndex = 16
        '
        'seepass2
        '
        Me.seepass2.BackColor = System.Drawing.Color.White
        Me.seepass2.BaseColor = System.Drawing.Color.White
        Me.seepass2.Image = Global.GymManagementSystem.My.Resources.Resources.eye
        Me.seepass2.Location = New System.Drawing.Point(342, 201)
        Me.seepass2.Margin = New System.Windows.Forms.Padding(2)
        Me.seepass2.Name = "seepass2"
        Me.seepass2.Size = New System.Drawing.Size(26, 28)
        Me.seepass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.seepass2.TabIndex = 15
        Me.seepass2.TabStop = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtConfirmPass.BorderRadius = 10
        Me.txtConfirmPass.BorderThickness = 3
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = ""
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtConfirmPass.FocusedState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtConfirmPass.HoverState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.IconLeft = Global.GymManagementSystem.My.Resources.Resources.padlockblackfill
        Me.txtConfirmPass.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtConfirmPass.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtConfirmPass.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.txtConfirmPass.Location = New System.Drawing.Point(121, 271)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(5)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.PlaceholderText = "Confirm Password"
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.ShadowDecoration.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.Size = New System.Drawing.Size(254, 37)
        Me.txtConfirmPass.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.BorderThickness = 3
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.IconLeft = Global.GymManagementSystem.My.Resources.Resources.padlockblackfill
        Me.txtPassword.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtPassword.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtPassword.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.txtPassword.Location = New System.Drawing.Point(121, 197)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(254, 37)
        Me.txtPassword.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtUsername.BorderRadius = 10
        Me.txtUsername.BorderThickness = 3
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.IconLeft = Global.GymManagementSystem.My.Resources.Resources.userblackfill
        Me.txtUsername.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtUsername.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtUsername.Location = New System.Drawing.Point(121, 124)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(254, 37)
        Me.txtUsername.TabIndex = 1
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.GymManagementSystem.My.Resources.Resources.GymViolet
        Me.GunaPictureBox1.Location = New System.Drawing.Point(52, 206)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(404, 145)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 4
        Me.GunaPictureBox1.TabStop = False
        '
        'RegisterFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 581)
        Me.Controls.Add(Me.panelHome)
        Me.Controls.Add(Me.panelRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RegisterFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterFrm"
        Me.panelRegister.ResumeLayout(False)
        Me.panelHome.ResumeLayout(False)
        Me.panelHome.PerformLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seePassbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seepass2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents panelRegister As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents seePassbtn As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents seepass2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtSecQuestion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panelHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSecAnswer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Registerbtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
