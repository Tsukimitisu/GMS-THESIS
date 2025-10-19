Imports MySql.Data.MySqlClient
Imports System.Data

Public Class PaymentRecords

    Private Sub PaymentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentRecords()
    End Sub

    Public Sub LoadPaymentRecords()
        If OpenConnection() Then
            Try
                Dim query As String =
                    "SELECT m.MemberID AS 'ID', m.FullName AS 'Name', m.ContactNo AS 'Contact', " &
                    "p.PlanName AS 'Fitness Plan', m.Balance AS 'Balance' " &
                    "FROM Members m " &
                    "INNER JOIN MembershipPlans p ON m.PlanID = p.PlanID " &
                    "ORDER BY m.FullName"

                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DGVinfo.DataSource = dt

                ' Style (optional)
                DGVinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DGVinfo.RowTemplate.Height = 35
                DGVinfo.ReadOnly = True
                DGVinfo.AllowUserToAddRows = False

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
                MsgBox("❌ Error loading records: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    ' When Edit button is clicked
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If DGVinfo.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = DGVinfo.CurrentRow

            Dim payForm As New PaymentForm()
            payForm.LoadSelectedStudent(selectedRow)
            payForm.ShowDialog()
        Else
            MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
