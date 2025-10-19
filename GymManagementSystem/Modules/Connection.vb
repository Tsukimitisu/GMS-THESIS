Imports MySql.Data.MySqlClient
Imports System.Data
Module Connection
    Public conn As MySqlConnection
    Private connString As String = "Server=localhost; Database=anytimefitness; Uid=root; Pwd=;"

    Public Function OpenConnection() As Boolean
        Try
            conn = New MySqlConnection(connString)
            conn.Open()
            Return True
        Catch ex As Exception
            MsgBox("Database connection failed: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Sub CloseConnection()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error closing connection: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
