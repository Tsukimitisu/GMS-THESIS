Imports MySql.Data.MySqlClient

Public Class RegisterFrm
    Dim isPasswordVisible As Boolean = False
    Dim isConfirmPasswordVisible As Boolean = False

    Private Sub seePassbtn_Click(sender As System.Object, e As System.EventArgs) Handles seePassbtn.Click
        If isConfirmPasswordVisible Then
            txtConfirmPass.PasswordChar = "*"c
            seePassbtn.Image = My.Resources.eye
            isConfirmPasswordVisible = False
        Else
            txtConfirmPass.PasswordChar = ControlChars.NullChar
            seePassbtn.Image = My.Resources.hidden
            isConfirmPasswordVisible = True
        End If
    End Sub

    Private Sub seepass2_Click(sender As System.Object, e As System.EventArgs) Handles seepass2.Click
        If isPasswordVisible Then
            txtPassword.PasswordChar = "*"c
            seepass2.Image = My.Resources.eye
            isPasswordVisible = False
        Else
            txtPassword.PasswordChar = ControlChars.NullChar
            seepass2.Image = My.Resources.hidden
            isPasswordVisible = True
        End If
    End Sub

    Private Sub Registerbtn_Click_1(sender As System.Object, e As System.EventArgs) Handles Registerbtn.Click
        If OpenConnection() Then
            Try
                Dim username As String = txtUsername.Text.Trim()
                Dim password As String = txtPassword.Text
                Dim confirmPass As String = txtConfirmPass.Text
                Dim secQuestion As String = txtSecQuestion.Text.Trim()
                Dim secAnswer As String = txtSecAnswer.Text.Trim()

                If username = "" Or password = "" Or confirmPass = "" Or secQuestion = "" Or secAnswer = "" Then
                    MsgBox("❌ All fields are required.", MsgBoxStyle.Critical, "Validation Error")
                    Exit Sub
                End If

                If password <> confirmPass Then
                    MsgBox("❌ Password and Confirm Password do not match.", MsgBoxStyle.Critical, "Validation Error")
                    Exit Sub
                End If

                If password.Length < 8 Then
                    MsgBox("❌ Password must be at least 8 characters long.", MsgBoxStyle.Critical, "Validation Error")
                    Exit Sub
                End If

                If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then
                    MsgBox("❌ Password must contain at least one uppercase letter.", MsgBoxStyle.Critical, "Validation Error")
                    Exit Sub
                End If

                If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") Then
                    MsgBox("❌ Password must contain at least one lowercase letter.", MsgBoxStyle.Critical, "Validation Error")
                    Exit Sub
                End If

                If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[^a-zA-Z0-9]") Then
                    MsgBox("❌ Password must contain at least one special character.", MsgBoxStyle.Critical, "Validation Error")
                    Exit Sub
                End If


                Dim checkQuery As String = "SELECT COUNT(*) FROM accounts WHERE username=@username"
                Dim checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@username", username)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If exists > 0 Then
                    MsgBox("⚠️ Username already exists. Please choose another one.", MsgBoxStyle.Exclamation, "Duplicate Username")
                    Exit Sub
                End If
                checkCmd.Dispose()


                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)
                Dim hashedSecAnswer As String = BCrypt.Net.BCrypt.HashPassword(secAnswer)


                Dim query As String = "INSERT INTO accounts (username, password, SecQuestion, SecAnswer, status) VALUES (@username, @password, @question, @answer, @status)"


                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", hashedPassword)
                cmd.Parameters.AddWithValue("@question", secQuestion)
                cmd.Parameters.AddWithValue("@answer", hashedSecAnswer)
                cmd.Parameters.AddWithValue("@status", "Pending")

                cmd.ExecuteNonQuery()
                cmd.Dispose()

                txtUsername.Clear()
                txtPassword.Clear()
                txtConfirmPass.Clear()
                txtSecQuestion.Clear()
                txtSecAnswer.Clear()

                MsgBox("✅ Account created successfully. Status set to Pending. Please wait for admin approval.", MsgBoxStyle.Information, "Success")
                Form1.Show()
                Me.Close()

            Catch ex As Exception
                MsgBox("❌ Registration error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles GunaTransfarantPictureBox1.Click
        Application.Exit()
    End Sub
End Class
