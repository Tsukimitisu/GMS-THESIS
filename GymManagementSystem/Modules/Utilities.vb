Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text

Module Utilities

    ' ==============================
    ' 🔹 Load Form into Panel
    ' ==============================
    Public Sub LoadFormInPanel(mainPanel As Panel, newForm As Form)
        For Each ctrl As Control In mainPanel.Controls
            ctrl.Dispose()
        Next
        mainPanel.Controls.Clear()

        newForm.TopLevel = False
        newForm.FormBorderStyle = FormBorderStyle.None
        newForm.Dock = DockStyle.Fill

        mainPanel.Controls.Add(newForm)
        newForm.Show()
    End Sub

    ' ==============================
    ' 🔹 Hash String (Password / SecAnswer)
    ' ==============================
    Public Function ComputeHash(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    ' ==============================
    ' 🔹 Execute SELECT Query (returns DataTable)
    ' ==============================
    Public Function FetchData(query As String, Optional params As List(Of MySqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            If OpenConnection() Then
                Using cmd As New MySqlCommand(query, conn)
                    If params IsNot Nothing Then
                        cmd.Parameters.AddRange(params.ToArray())
                    End If
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox("❌ Error fetching data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function

    ' ==============================
    ' 🔹 Execute NonQuery (Insert/Update/Delete)
    ' ==============================
    Public Function ExecuteCommand(query As String, Optional params As List(Of MySqlParameter) = Nothing) As Integer
        Dim affected As Integer = 0
        Try
            If OpenConnection() Then
                Using cmd As New MySqlCommand(query, conn)
                    If params IsNot Nothing Then
                        cmd.Parameters.AddRange(params.ToArray())
                    End If
                    affected = cmd.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            MsgBox("❌ Command failed: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            CloseConnection()
        End Try
        Return affected
    End Function

    ' ==============================
    ' 🔹 Message Helper
    ' ==============================
    Public Sub ShowInfo(message As String)
        MsgBox(message, MsgBoxStyle.Information, "Info")
    End Sub

    Public Sub ShowError(message As String)
        MsgBox(message, MsgBoxStyle.Critical, "Error")
    End Sub

    Public Sub ShowSuccess(message As String)
        MsgBox(message, MsgBoxStyle.OkOnly, "Success")
    End Sub


End Module
