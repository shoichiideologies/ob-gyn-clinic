Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports QRCoder

Public Class QRCode
    Dim filePathReceipt As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Receipt.txt"
    Private Sub QRCodeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateAndDisplayQRCode(filePathReceipt)
    End Sub

    Private Sub GenerateAndDisplayQRCode(filePath As String)
        Try
            If File.Exists(filePath) Then
                Dim receiptContent As String = File.ReadAllText(filePath)

                Dim generator As New QRCodeGenerator()
                Dim qrCodeData As QRCodeData = generator.CreateQrCode(receiptContent, QRCodeGenerator.ECCLevel.Q)
                Dim qrCode As New QRCoder.QRCode(qrCodeData)
                Dim qrCodeImage As Bitmap = qrCode.GetGraphic(6)

                pcbQRCode.Image = qrCodeImage

                MessageBox.Show("QR code generated and displayed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"File not found: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error generating QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDialog As New PrintDialog()
        Dim printDocument As New PrintDocument()

        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        Try
            Using reader As New StreamReader(filePathReceipt)
                Dim line As String = reader.ReadLine()
                Dim yPos As Single = 100

                While line IsNot Nothing
                    graphics.DrawString(line, font, brush, New PointF(100, yPos))
                    yPos += font.GetHeight()
                    line = reader.ReadLine()
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error reading receipt file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
