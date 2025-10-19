Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form1
    Dim isPasswordVisible As Boolean = False

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        RegisterFrm.Show()
    End Sub

    Private Sub seePassbtn_Click(sender As System.Object, e As System.EventArgs) Handles seePassbtn.Click
        If isPasswordVisible Then
            txtPassword.PasswordChar = "*"c
            seePassbtn.Image = My.Resources.eye
            isPasswordVisible = False
        Else
            txtPassword.PasswordChar = ControlChars.NullChar
            seePassbtn.Image = My.Resources.hidden
            isPasswordVisible = True
        End If
    End Sub

    Private Sub Loginbtn_Click_1(sender As System.Object, e As System.EventArgs) Handles Loginbtn.Click
        If OpenConnection() Then
            Try
                Dim username As String = txtUser.Text.Trim()
                Dim password As String = txtPassword.Text.Trim()

                If username = "" OrElse password = "" Then
                    MsgBox("❌ Please enter both username and password.", MsgBoxStyle.Critical, "Missing Input")
                    Exit Sub
                End If

                Dim query As String = "SELECT password, status FROM accounts WHERE username = @username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    Dim hashedPassword As String = reader("password").ToString()
                    Dim userStatus As String = reader("status").ToString()

                    ' ✅ Status must be Accepted
                    If userStatus.ToLower() <> "accepted" Then
                        MsgBox("⚠️ Your account status is '" & userStatus & "'. You cannot log in until it is Accepted.", MsgBoxStyle.Exclamation, "Login Blocked")
                        reader.Close()
                        Exit Sub
                    End If

                    ' ✅ Check password
                    If BCrypt.Net.BCrypt.Verify(password, hashedPassword) Then
                        reader.Close()
                        MsgBox("✅ Login successful!", MsgBoxStyle.Information, "Welcome")
                        Me.Close()
                        dashboardFrm.Show()
                    Else
                        reader.Close()
                        MsgBox("❌ Invalid username or password.", MsgBoxStyle.Critical, "Login Failed")
                    End If
                Else
                    reader.Close()
                    MsgBox("❌ Invalid username or password.", MsgBoxStyle.Critical, "Login Failed")
                End If

                cmd.Dispose()
            Catch ex As Exception
                MsgBox("❌ Login error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtPassword.Clear()
        txtUser.Clear()
    End Sub

    Private Sub GunaTransfarantPictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles GunaTransfarantPictureBox2.Click
        Application.Exit()
    End Sub
End Class
