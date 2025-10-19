Imports MySql.Data.MySqlClient
Imports System.Data

Public Class equipmentList

    Private Sub equipmentList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadEquipment()
    End Sub

    Public Sub LoadEquipment()
        If OpenConnection() Then
            Try
                Dim query As String =
                    "SELECT EquipmentID, EquipmentName AS 'Equipment Name', Category, PurchaseDate AS 'Purchase Date', ConditionStatus AS 'Condition' " &
                    "FROM GymEquipment " &
                    "ORDER BY EquipmentName ASC"

                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DGVinfo.DataSource = dt

                ' Hide EquipmentID column
                If DGVinfo.Columns.Contains("EquipmentID") Then
                    DGVinfo.Columns("EquipmentID").Visible = False
                End If

                ' Center align Condition column
                If DGVinfo.Columns.Contains("Condition") Then
                    DGVinfo.Columns("Condition").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVinfo.Columns("Condition").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                ' Apply styling
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
                MsgBox("❌ Error loading equipment: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click

    End Sub
End Class