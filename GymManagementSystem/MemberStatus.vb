Imports MySql.Data.MySqlClient
Imports System.Data

Public Class MemberStatus

    Public Sub LoadMemberStatus()
        If OpenConnection() Then
            Try
                Dim query As String =
                    "SELECT MemberID, FullName AS 'Member Name', Email, ContactNo, Status " &
                    "FROM members " &
                    "ORDER BY FullName ASC"

                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DGVinfo.DataSource = dt

                ' 🔹 Hide MemberID column
                If DGVinfo.Columns.Contains("MemberID") Then
                    DGVinfo.Columns("MemberID").Visible = False
                End If

                ' 🔹 Center align Status column text
                If DGVinfo.Columns.Contains("Status") Then
                    DGVinfo.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVinfo.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                ' 🔹 Apply styling to DGV
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
                MsgBox("❌ Error loading member status: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    ' 🔹 Color cells dynamically
    Private Sub DGVinfo_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVinfo.CellFormatting
        If DGVinfo.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString().ToLower()

            If status = "active" Then
                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.ForeColor = Color.Black
            ElseIf status = "inactive" Or status = "expired" Then
                e.CellStyle.BackColor = Color.LightCoral
                e.CellStyle.ForeColor = Color.White
            Else
                e.CellStyle.BackColor = Color.LightGray
                e.CellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub

    ' 🔹 Form Load
    Private Sub MemberStatus_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadMemberStatus()
    End Sub

End Class
