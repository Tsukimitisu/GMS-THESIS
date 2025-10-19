Imports MySql.Data.MySqlClient
Imports System.Data

Public Class downpaymentFrm
    ' Public properties to receive data
    Public Property MemberFullName As String
    Public Property MemberEmail As String
    Public Property MemberContact As String
    Public Property MemberEmergency As String
    Public Property MemberBirthDate As Date
    Public Property MemberAddress As String
    Public Property MemberRegisterDate As Date
    Public Property MemberPlanID As Integer
    Public Property MemberBilling As String


    Private memberInfo As Dictionary(Of String, Object)

    Public Sub New(info As Dictionary(Of String, Object))
        InitializeComponent()
        memberInfo = info
    End Sub

    Private Sub DownPaymentFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show Fitness Plan
        lblFitplan.Text = memberInfo("PlanName").ToString()

        ' Compute total = plan + addons
        Dim totalAmount As Decimal = CDec(memberInfo("PlanPrice"))

        Dim addons As List(Of String) = CType(memberInfo("Addons"), List(Of String))
        For Each addon In addons
            Select Case addon
                Case "Personal Training"
                    totalAmount += 750
                Case "Nutrient Coach"
                    totalAmount += 800
                Case "Locker Rent"
                    totalAmount += 500
            End Select
        Next

        lblAmount.Text = "₱ " & totalAmount.ToString("N2")

        ' Store back to dictionary (optional, so btnPay can use it)
        memberInfo("TotalAmount") = totalAmount
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Dim downPayment As Decimal

        If Not Decimal.TryParse(txtdownpayment.Text, downPayment) Then
            MsgBox("❌ Please enter a valid down payment.", MsgBoxStyle.Critical)
            Return
        End If

        Dim totalAmount As Decimal = CDec(memberInfo("TotalAmount"))
        Dim minDown As Decimal = totalAmount * 0.1D ' Example: 10% required

        If downPayment < minDown Then
            MsgBox("❌ Minimum downpayment is ₱" & minDown.ToString("N2"), MsgBoxStyle.Exclamation)
            Return
        End If

        ' ✅ Calculate balance
        Dim balance As Decimal = totalAmount - downPayment

        If OpenConnection() Then
            Try
                ' Insert new member with Balance
                Dim query As String = "INSERT INTO members " &
    "(FullName, Email, ContactNo, EmergencyContact, BirthDate, Address, " &
    "DateOfRegistration, PlanID, BillingFrequency, Status, Balance) " &
    "VALUES (@FullName, @Email, @ContactNo, @EmergencyContact, @BirthDate, " &
    "@Address, @DateOfRegistration, @PlanID, @BillingFrequency, @Status, @Balance)"


                Dim memberID As Integer

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FullName", memberInfo("FullName"))
                    cmd.Parameters.AddWithValue("@Email", memberInfo("Email"))
                    cmd.Parameters.AddWithValue("@ContactNo", memberInfo("Contact"))
                    cmd.Parameters.AddWithValue("@EmergencyContact", memberInfo("Emergency"))
                    cmd.Parameters.AddWithValue("@BirthDate", CDate(memberInfo("Birthdate")).ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@Address", memberInfo("Address"))
                    cmd.Parameters.AddWithValue("@DateOfRegistration", CDate(memberInfo("DateOfRegister")).ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@PlanID", GetPlanID(memberInfo("PlanName")))
                    cmd.Parameters.AddWithValue("@BillingFrequency", memberInfo("Billing"))
                    cmd.Parameters.AddWithValue("@Status", "Active")
                    cmd.Parameters.AddWithValue("@Balance", balance)
                    cmd.ExecuteNonQuery()

                    ' Get last inserted MemberID
                    memberID = CInt(cmd.LastInsertedId)
                End Using

                ' ✅ Insert into Payments (Downpayment)
                Dim payQuery As String = "INSERT INTO payments (MemberID, Amount, PaymentType) VALUES (@MemberID, @Amount, 'Downpayment')"
                Using cmdPay As New MySqlCommand(payQuery, conn)
                    cmdPay.Parameters.AddWithValue("@MemberID", memberID)
                    cmdPay.Parameters.AddWithValue("@Amount", downPayment)
                    cmdPay.ExecuteNonQuery()
                End Using

                MsgBox("✅ Member added successfully with balance ₱" & balance.ToString("N2"), MsgBoxStyle.Information)

                ' Refresh membership form
                Dim mainForm As MembershipForm = CType(Application.OpenForms("MembershipForm"), MembershipForm)
                If mainForm IsNot Nothing Then
                    mainForm.ClearForm()
                End If
                Me.Close()

            Catch ex As Exception
                MsgBox("❌ Error adding member: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub


    Private Function GetPlanID(planName As String) As Integer
        Select Case planName
            Case "Monthly" : Return 1
            Case "3 Months" : Return 2
            Case "6 Months" : Return 3
            Case "Annual" : Return 4
            Case Else : Return 0
        End Select
    End Function

    Private Sub GunaTransfarantPictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles GunaTransfarantPictureBox1.Click
        Me.Close()

    End Sub
End Class