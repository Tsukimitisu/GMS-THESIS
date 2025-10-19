Imports MySql.Data.MySqlClient
Imports System.Data
Public Class GymEquipmentAdd

    Private Sub btnAddEquipment_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEquipment.Click
        ' ✅ Validate fields
        If String.IsNullOrWhiteSpace(txtEquipmentName.Text) OrElse
           String.IsNullOrWhiteSpace(txtCategory.Text) OrElse
           cmbCondition.SelectedIndex = -1 Then
            MsgBox("⚠ Please fill out all fields before adding equipment.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' ✅ Gather values
        Dim equipmentName As String = txtEquipmentName.Text.Trim()
        Dim category As String = txtCategory.Text.Trim()
        Dim purchaseDate As Date = dtpPurchaseDate.Value
        Dim conditionStatus As String = cmbCondition.SelectedItem.ToString()

        ' ✅ Insert into database
        If OpenConnection() Then
            Try
                Dim query As String = "INSERT INTO GymEquipment (EquipmentName, Category, PurchaseDate, ConditionStatus) " &
                                      "VALUES (@EquipmentName, @Category, @PurchaseDate, @ConditionStatus)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EquipmentName", equipmentName)
                    cmd.Parameters.AddWithValue("@Category", category)
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate)
                    cmd.Parameters.AddWithValue("@ConditionStatus", conditionStatus)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("✅ Equipment added successfully!", MsgBoxStyle.Information)



                ' Clear inputs
                txtEquipmentName.Clear()
                txtCategory.Clear()
                cmbCondition.SelectedIndex = -1

            Catch ex As Exception
                MsgBox("❌ Error adding equipment: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub GymEquipmentAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class