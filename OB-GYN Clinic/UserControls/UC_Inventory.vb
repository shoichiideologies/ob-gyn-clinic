Imports System.IO

Public Class UC_Inventory
    Private Sub AddVitamin_Click(sender As Object, e As EventArgs) Handles AddVitamin.Click
        Dim add As New AddVitamins()
        add.ShowDialog()
    End Sub

    Public Sub LoadDataFromFile()
        Dim filePath As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Vitamins.txt"

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values() As String = line.Split(","c)

                    If values.Length > 0 Then
                        Dim rowIndex As Integer = dgvVitaminList.Rows.Add()
                        Dim row As DataGridViewRow = dgvVitaminList.Rows(rowIndex)

                        For i As Integer = 0 To Math.Min(values.Length - 1, dgvVitaminList.Columns.Count - 1)
                            row.Cells(i).Value = values(i)
                        Next
                    Else
                        MessageBox.Show("Empty line found in the data file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End While
            End Using
        Else
            MessageBox.Show("The data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UC_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataFromFile()
    End Sub
End Class
