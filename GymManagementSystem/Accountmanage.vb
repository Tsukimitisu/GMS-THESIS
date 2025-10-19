Imports MySql.Data.MySqlClient
Imports System.Data


Public Class Accountmanage

    Private Sub LoadAccounts()
        If OpenConnection() Then
            Try
                Dim query As String = "SELECT id, username, SecQuestion, SecAnswer, status FROM accounts"
                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DGVinfo.DataSource = dt

                Dim customFont As New Font("Poppins ExtraBold", 11.25, FontStyle.Bold)

                With DGVinfo
                    ' General properties
                    .ReadOnly = True
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .MultiSelect = False
                    .RowHeadersVisible = False
                    .BorderStyle = BorderStyle.None
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .RowTemplate.Height = 35

                    ' Fonts
                    .Font = customFont
                    .DefaultCellStyle.Font = customFont
                    .ColumnHeadersDefaultCellStyle.Font = customFont

                    ' Background
                    .BackgroundColor = Color.FromArgb(248, 249, 251) ' main background
                    .DefaultCellStyle.BackColor = Color.FromArgb(248, 249, 251)
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 250) ' subtle contrast

                    ' Text color
                    .DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64)

                    ' Selection colors (DarkSlateBlue for sidebar dropdown)
                    .DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue
                    .DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke

                    ' Grid/border style (minimal look)
                    .ColumnHeadersBorderStyle = DataGridViewCellBorderStyle.None
                    .CellBorderStyle = DataGridViewCellBorderStyle.None
                    .GridColor = Color.FromArgb(220, 220, 240)
                End With

                With DGVinfo.ColumnHeadersDefaultCellStyle
                    .BackColor = Color.FromArgb(128, 128, 255)
                    .ForeColor = Color.White
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Font = customFont
                End With

                DGVinfo.EnableHeadersVisualStyles = False


            Catch ex As Exception
                MsgBox("❌ Error loading accounts: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub


    Private Sub Accountmanage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAccounts()

    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        If DGVinfo.CurrentRow Is Nothing Then
            MsgBox("⚠ Please select an account.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim accountID As Integer = CInt(DGVinfo.CurrentRow.Cells("id").Value)

        If OpenConnection() Then
            Try
                Dim query As String = "UPDATE accounts SET status = 'Accepted' WHERE id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", accountID)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("✅ Account accepted!", MsgBoxStyle.Information)
                LoadAccounts()
            Catch ex As Exception
                MsgBox("❌ Error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub btnReject_Click(sender As System.Object, e As System.EventArgs) Handles btnReject.Click
        If DGVinfo.CurrentRow Is Nothing Then
            MsgBox("⚠ Please select an account.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim accountID As Integer = CInt(DGVinfo.CurrentRow.Cells("id").Value)

        If OpenConnection() Then
            Try
                Dim query As String = "UPDATE accounts SET status = 'Rejected' WHERE id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", accountID)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("🚫 Account rejected!", MsgBoxStyle.Information)
                LoadAccounts()
            Catch ex As Exception
                MsgBox("❌ Error: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub
End Class