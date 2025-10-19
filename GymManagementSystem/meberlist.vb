Imports MySql.Data.MySqlClient
Imports System.Data

Public Class memberlist

    Private Sub memberlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadMembers()
    End Sub
    Public Sub LoadMembers()
        Try
            If OpenConnection() Then
                ' Include contact no, emergency contact, balance, but still load Status (hidden later)
                Dim query As String = "SELECT MemberID AS 'ID', FullName AS 'Full Name', " &
                                      "ContactNo AS 'Contact No', EmergencyContact AS 'Emergency Contact', " &
                                      "DateOfRegistration AS 'Registered On', PlanID AS 'Plan', " &
                                      "BillingFrequency AS 'Billing', Status, Balance " &
                                      "FROM members"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                DGVinfo.DataSource = table

                ' Hide Status column
                If DGVinfo.Columns.Contains("Status") Then
                    DGVinfo.Columns("Status").Visible = False
                End If

                ' Format Balance as currency
                If DGVinfo.Columns.Contains("Balance") Then
                    DGVinfo.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    DGVinfo.Columns("Balance").DefaultCellStyle.Format = "C2" ' e.g. ₱1,000.00
                End If

                ' DGV styling
                DGVinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DGVinfo.RowTemplate.Height = 30
                DGVinfo.AllowUserToAddRows = False
                DGVinfo.ReadOnly = True

                CloseConnection()

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

            End If
        Catch ex As Exception
            MsgBox("❌ Error loading members: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub GenerateID_Click(sender As System.Object, e As System.EventArgs) Handles GenerateID.Click
        CType(Application.OpenForms("dashboardFrm"), dashboardFrm).ShowInPanel(New IdForm())
    End Sub
End Class