Imports MySql.Data.MySqlClient
Imports System.Data

Public Class CheckInOut

    ' 🔹 Load Attendance Grid
    Public Sub LoadAttendance()
        If OpenConnection() Then
            Try
                Dim query As String = "SELECT m.MemberID, m.FullName AS 'Member Name', " &
                       "a.AttendanceID, a.CheckInTime, a.CheckOutTime, a.AttendanceCount " &
                       "FROM members m " &
                       "LEFT JOIN attendance a ON m.MemberID = a.MemberID " &
                       "AND a.CheckInTime = (SELECT MAX(CheckInTime) FROM attendance WHERE MemberID = m.MemberID) " &
                       "ORDER BY m.FullName"


                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DGVinfo.DataSource = dt


                ' 🔹 Hide AttendanceCount column if it exists
                If DGVinfo.Columns.Contains("AttendanceCount") Then
                    DGVinfo.Columns("AttendanceCount").Visible = False
                End If
                ' ================== DataGridView Info ==================
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



    ' 🔹 Check In Logic
    Public Sub MemberCheckIn(memberID As Integer)
        If OpenConnection() Then
            Try
                ' Check if already checked in without checkout
                Dim activeCheckQuery As String = "SELECT COUNT(*) FROM attendance WHERE MemberID=@MemberID AND CheckOutTime IS NULL"
                Using checkCmd As New MySqlCommand(activeCheckQuery, conn)
                    checkCmd.Parameters.AddWithValue("@MemberID", memberID)
                    Dim activeCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If activeCount > 0 Then
                        MsgBox("⚠ Member is already checked in.", MsgBoxStyle.Exclamation)
                        Return
                    End If
                End Using

                ' Count total past check-ins
                Dim countQuery As String = "SELECT COUNT(*) FROM attendance WHERE MemberID=@MemberID"
                Dim checkCount As Integer
                Using cmd As New MySqlCommand(countQuery, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    checkCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Decide label (Day / Week / Month)
                Dim attendanceLabel As String
                If checkCount < 6 Then
                    attendanceLabel = "Day " & (checkCount + 1).ToString()
                ElseIf checkCount < 30 Then
                    attendanceLabel = "Week " & Math.Ceiling((checkCount + 1) / 7.0)
                Else
                    attendanceLabel = "Month " & Math.Ceiling((checkCount + 1) / 30.0)
                End If

                ' Insert new record
                Dim insertQuery As String =
                    "INSERT INTO attendance (MemberID, CheckInTime, AttendanceCount) " &
                    "VALUES (@MemberID, NOW(), @AttendanceCount)"
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    cmd.Parameters.AddWithValue("@AttendanceCount", attendanceLabel)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("✅ Member checked in successfully!", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox("❌ Error during check-in: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    ' 🔹 Check Out Logic
    Public Sub MemberCheckOut(memberID As Integer)
        If OpenConnection() Then
            Try
                Dim query As String = "UPDATE attendance SET CheckOutTime = NOW() WHERE MemberID=@MemberID AND CheckOutTime IS NULL ORDER BY CheckInTime DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MemberID", memberID)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("✅ Member checked out successfully!", MsgBoxStyle.Information)
                    Else
                        MsgBox("⚠ No active check-in found for this member.", MsgBoxStyle.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("❌ Error during check-out: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub


    ' 🔹 BUTTON HANDLERS
    Private Sub btnCheckin_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckin.Click
        If DGVinfo.SelectedRows.Count = 0 Then
            MsgBox("⚠ Please select a member to check in.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim memberID As Integer = CInt(DGVinfo.SelectedRows(0).Cells("MemberID").Value)
        MemberCheckIn(memberID)
        LoadAttendance()
    End Sub

    Private Sub btnCheckout_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckout.Click
        If DGVinfo.SelectedRows.Count = 0 Then
            MsgBox("⚠ Please select a member to check out.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim memberID As Integer = CInt(DGVinfo.SelectedRows(0).Cells("MemberID").Value)
        MemberCheckOut(memberID)
        LoadAttendance()
    End Sub

    Private Sub CheckInOut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAttendance()
    End Sub
End Class
