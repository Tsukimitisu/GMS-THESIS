Imports MySql.Data.MySqlClient
Imports System.Data

Public Class ViewAttendance

    ' 🔹 Load all attendance records (with optional search)
    Public Sub LoadAttendance(Optional ByVal searchTerm As String = "")
        If OpenConnection() Then
            Try
                Dim query As String =
    "SELECT a.AttendanceID, m.FullName AS 'Member Name', " &
    "a.CheckInTime, a.CheckOutTime, a.AttendanceCount AS 'Attendance Count' " &
    "FROM attendance a " &
    "INNER JOIN members m ON a.MemberID = m.MemberID " &
    "WHERE a.CheckInTime = (SELECT MAX(CheckInTime) FROM attendance WHERE MemberID = m.MemberID) "

                ' If searching, filter by member name
                If searchTerm <> "" Then
                    query &= "AND m.FullName LIKE @Search "
                End If

                query &= "ORDER BY a.CheckInTime DESC"

                Dim cmd As New MySqlCommand(query, conn)
                If searchTerm <> "" Then
                    cmd.Parameters.AddWithValue("@Search", "%" & searchTerm & "%")
                End If

                Dim da As New MySqlDataAdapter(cmd)
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
                MsgBox("❌ Error loading attendance: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    ' 🔹 Form Load → show all attendance
    Private Sub ViewAttendance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAttendance()
    End Sub

    ' 🔹 Live search while typing
    Private Sub txtSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearch.TextChanged
        LoadAttendance(txtSearch.Text.Trim())
    End Sub

End Class
