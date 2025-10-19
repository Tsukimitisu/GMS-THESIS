Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard

    Private Sub Dashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        If OpenConnection() Then
            Try
                ' ===== 1. Members Counts =====
                Dim totalMembers As Integer = 0
                Dim activeMembers As Integer = 0
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Members", conn)
                    totalMembers = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Members WHERE Status='Active'", conn)
                    activeMembers = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                lblAllmember.Text = totalMembers.ToString()
                lblActivemember.Text = activeMembers.ToString()

                ' ===== 2. Equipment Count =====
                Dim totalEquipment As Integer = 0
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM GymEquipment", conn)
                    totalEquipment = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                lblEquipment.Text = totalEquipment.ToString()

                ' ===== 3. Bar Chart → Members by Status =====
                barChart.Series.Clear()
                barChart.ChartAreas(0).AxisX.Title = "Member Status"
                barChart.ChartAreas(0).AxisY.Title = "Count"
                barChart.Series.Add("Members")
                barChart.Series("Members").Points.AddXY("Active", activeMembers)
                barChart.Series("Members").Points.AddXY("Expired", totalMembers - activeMembers)
                barChart.Series("Members").IsValueShownAsLabel = True
                barChart.Series("Members").ChartType = SeriesChartType.Column
                barChart.Series("Members").Color = Color.SteelBlue

                ' ===== 4. Pie Chart → Equipment by Condition =====
                pieChart.Series.Clear()
                Dim pieSeries As New Series("Equipment")
                pieSeries.ChartType = SeriesChartType.Pie
                pieSeries.IsValueShownAsLabel = True

                Dim eqQuery As String = "SELECT ConditionStatus, COUNT(*) AS Count FROM GymEquipment GROUP BY ConditionStatus"
                Using da As New MySqlDataAdapter(eqQuery, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    For Each row As DataRow In dt.Rows
                        pieSeries.Points.AddXY(row("ConditionStatus").ToString(), CInt(row("Count")))
                    Next
                End Using

                pieChart.Series.Add(pieSeries)

            Catch ex As Exception
                MsgBox("❌ Error loading dashboard data: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub lblAllmember_Click(sender As System.Object, e As System.EventArgs) Handles lblAllmember.Click

    End Sub
End Class
