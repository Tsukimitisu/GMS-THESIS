Imports MySql.Data.MySqlClient
Imports System.Data

Public Class PaymentForm
    Private memberID As Integer
    Private balance As Decimal

    Public Sub LoadSelectedStudent(row As DataGridViewRow)
        memberID = CInt(row.Cells("ID").Value) ' Keep ID for payments
        lblname.Text = row.Cells("Name").Value.ToString()
        lblFitplan.Text = row.Cells("Fitness Plan").Value.ToString()
        lblBalance.Text = "₱ " & row.Cells("Balance").Value.ToString()

        balance = CDec(row.Cells("Balance").Value)
    End Sub

    ' Process Payment (example)
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Dim paymentAmount As Decimal
        If Not Decimal.TryParse(txtPayment.Text, paymentAmount) OrElse paymentAmount <= 0 Then
            MsgBox("❌ Invalid payment.", MsgBoxStyle.Critical)
            Return
        End If

        If paymentAmount > balance Then
            MsgBox("⚠ Payment cannot exceed balance.", MsgBoxStyle.Exclamation)
            Return
        End If

        If OpenConnection() Then
            Try
                ' Insert into Payments table
                Dim insertQuery As String = "INSERT INTO Payments (MemberID, Amount, PaymentType) VALUES (@MemberID, @Amount, 'Balance')"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    cmd.Parameters.AddWithValue("@Amount", paymentAmount)
                    cmd.ExecuteNonQuery()
                End Using

                ' Update balance
                Dim newBalance As Decimal = balance - paymentAmount
                Dim updateQuery As String = "UPDATE Members SET Balance = @Balance WHERE MemberID = @MemberID"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@Balance", newBalance)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    cmd.ExecuteNonQuery()
                End Using

                lblBalance.Text = "₱ " & newBalance.ToString("N2")
                balance = newBalance

                MsgBox("✅ Payment saved successfully!", MsgBoxStyle.Information)

                ' Refresh PaymentRecords grid
                If Application.OpenForms().OfType(Of PaymentRecords).Any() Then
                    Application.OpenForms().OfType(Of PaymentRecords).First().LoadPaymentRecords()
                End If
                Me.Close()
            Catch ex As Exception
                MsgBox("❌ Error saving payment: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles GunaTransfarantPictureBox1.Click
        Me.Close()

    End Sub
End Class
