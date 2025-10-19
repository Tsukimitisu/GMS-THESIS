Public Class MembershipForm

    Private Sub btnAddpayment_Click(sender As System.Object, e As System.EventArgs) Handles btnAddpayment.Click

        Dim memberInfo As New Dictionary(Of String, Object)
        memberInfo("FullName") = txtFullName.Text.Trim()
        memberInfo("Email") = txtEmail.Text.Trim()
        memberInfo("Contact") = txtContact.Text.Trim()
        memberInfo("Emergency") = txtEmergency.Text.Trim()
        memberInfo("Address") = txtAddress.Text.Trim()
        memberInfo("Birthdate") = DTPbirthdate.Value
        memberInfo("DateOfRegister") = DTPDateofRegister.Value

        If planMonthly.Checked Then
            memberInfo("PlanName") = "Monthly"
            memberInfo("PlanPrice") = 2000
        ElseIf plan3Month.Checked Then
            memberInfo("PlanName") = "3 Months"
            memberInfo("PlanPrice") = 5500
        ElseIf plan6Month.Checked Then
            memberInfo("PlanName") = "6 Months"
            memberInfo("PlanPrice") = 10500
        ElseIf planAnnual.Checked Then
            memberInfo("PlanName") = "Annual"
            memberInfo("PlanPrice") = 19500
        End If

        ' Billing
        If BillingMonthly.Checked Then
            memberInfo("Billing") = "Monthly"
        ElseIf BillingQuarterly.Checked Then
            memberInfo("Billing") = "Quarterly"
        ElseIf BillingOnetime.Checked Then
            memberInfo("Billing") = "One Time"
        End If

        ' Add-ons
        Dim addons As New List(Of String)
        If AddonPTraining.Checked Then addons.Add("Personal Training")
        If AddonNCoach.Checked Then addons.Add("Nutrient Coach")
        If AddonLRent.Checked Then addons.Add("Locker Rent")
        memberInfo("Addons") = addons

        ' 🔑 Pass memberInfo to DownPaymentFrm
        Dim downFrm As New downpaymentFrm(memberInfo)
        downFrm.StartPosition = FormStartPosition.CenterParent
        downFrm.ShowDialog(Me)

    End Sub

    ' ✅ Clear all fields in MembershipForm
    Public Sub ClearForm()
        ' Textboxes
        txtFullName.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        txtEmergency.Clear()
        txtAddress.Clear()

        ' Date pickers (reset to today)
        DTPbirthdate.Value = Date.Today
        DTPDateofRegister.Value = Date.Today

        ' Radio buttons - uncheck all
        planMonthly.Checked = False
        plan3Month.Checked = False
        plan6Month.Checked = False
        planAnnual.Checked = False

        BillingMonthly.Checked = False
        BillingQuarterly.Checked = False
        BillingOnetime.Checked = False

        ' Checkboxes - uncheck all
        AddonPTraining.Checked = False
        AddonNCoach.Checked = False
        AddonLRent.Checked = False
    End Sub

End Class