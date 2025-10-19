Public Class dashboardFrm

    
   
    Private Sub dashboardFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ManagePanel.Visible = False
        EquipmentPanel.Visible = False
        AttendancePanel.Visible = False

        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New Dashboard
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub


    Private Sub btnManageMember_Click(sender As System.Object, e As System.EventArgs) Handles btnManageMember.Click
        If ManagePanel.Visible = False Then
            ManagePanel.Visible = True
        Else
            ManagePanel.Visible = False
        End If

        If EquipmentPanel.Visible = True Then
            EquipmentPanel.Visible = False
        End If

        If AttendancePanel.Visible = True Then
            AttendancePanel.Visible = False
        End If

    End Sub

    Sub HideMenu()
        If ManagePanel.Visible = True Then
            ManagePanel.Visible = False
        ElseIf EquipmentPanel.Visible = True Then
            EquipmentPanel.Visible = False
        ElseIf AttendancePanel.Visible = True Then
            AttendancePanel.Visible = False
        End If

    End Sub

    Private Sub btnEquipment_Click(sender As System.Object, e As System.EventArgs) Handles btnEquipment.Click
        If EquipmentPanel.Visible = False Then
            EquipmentPanel.Visible = True
        Else
            EquipmentPanel.Visible = False
        End If

        If AttendancePanel.Visible = True Then
            AttendancePanel.Visible = False
        End If

        If ManagePanel.Visible = True Then
            ManagePanel.Visible = False
        End If

    End Sub

    Private Sub btnAttendance_Click(sender As System.Object, e As System.EventArgs) Handles btnAttendance.Click
        If AttendancePanel.Visible = False Then
            AttendancePanel.Visible = True
        Else
            AttendancePanel.Visible = False
        End If

        If ManagePanel.Visible = True Then
            ManagePanel.Visible = False
        End If

        If EquipmentPanel.Visible = True Then
            EquipmentPanel.Visible = False
        End If

    End Sub

    Private Sub GunaButton3_Click(sender As System.Object, e As System.EventArgs) Handles btnAllmember.Click
        HideMenu()

        panelDisplayfrm.Controls.Clear()

        Dim DisplayMemberForm As New memberlist

        DisplayMemberForm.TopLevel = False
        DisplayMemberForm.FormBorderStyle = FormBorderStyle.None
        DisplayMemberForm.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayMemberForm)
        DisplayMemberForm.Show()
    End Sub

 

    Private Sub GunaButton4_Click(sender As System.Object, e As System.EventArgs) Handles btnAddMember.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayMemberForm As New MembershipForm
        DisplayMemberForm.TopLevel = False
        DisplayMemberForm.FormBorderStyle = FormBorderStyle.None
        DisplayMemberForm.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayMemberForm)
        DisplayMemberForm.Show()
    End Sub

    Private Sub GunaButton6_Click(sender As System.Object, e As System.EventArgs) Handles btnEquipmentList.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New equipmentList
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()

    End Sub

    Private Sub GunaButton2_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEquipment.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New GymEquipmentAdd
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As System.Object, e As System.EventArgs)
        HideMenu()
    End Sub

    Private Sub GunaButton9_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckIn.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New CheckInOut
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub

    Private Sub GunaButton8_Click(sender As System.Object, e As System.EventArgs) Handles btnView.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New ViewAttendance
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As System.Object, e As System.EventArgs) Handles btnDashboard.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New Dashboard
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub


    Private Sub btnStatus_Click(sender As System.Object, e As System.EventArgs) Handles btnStatus.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New MemberStatus
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub

    Private Sub btnPayment_Click(sender As System.Object, e As System.EventArgs) Handles btnPayment.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New PaymentRecords
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub

    Private Sub btnAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnAccount.Click
        HideMenu()
        panelDisplayfrm.Controls.Clear()

        Dim DisplayUpdate As New Accountmanage
        DisplayUpdate.TopLevel = False
        DisplayUpdate.FormBorderStyle = FormBorderStyle.None
        DisplayUpdate.Dock = DockStyle.Fill

        panelDisplayfrm.Controls.Add(DisplayUpdate)
        DisplayUpdate.Show()
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles GunaTransfarantPictureBox1.Click
        Application.Exit()
    End Sub

    Public Sub ShowInPanel(frm As Form)
        panelDisplayfrm.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        panelDisplayfrm.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub panelDisplayfrm_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles panelDisplayfrm.Paint

    End Sub
End Class