Imports System.IO
Imports System.Drawing.Printing
Imports QRCoder
Imports System.Windows.Interop
Imports System.Runtime.InteropServices
Imports System.Messaging
Imports OB_GYN_Clinic.FilePaths

Public Class UC_Transactions
    Dim filePathPrescription As String = PrescriptionFile
    Dim filePathVitamins As String = VitaminsFile
    Dim filePathReceipt As String = ReceiptFile
    Dim filePathPatient As String = PatientsFile
    Dim filePathSchedule As String = ScheduleFile

    Private WithEvents listBoxResultsName As New ListBox()
    Private WithEvents listBoxResultsVitamin As New ListBox()
    Private Patients As New AddPatient()
    Private uca As New UC_Appointments()
    Private ReusableMethods As New UniversalMethods
    Private totalPrice As Double = 0
    Dim initialFee As Double = 2000.0
    Dim followUpFee As Double = 500.0

    'Add Pres
    Dim lastAddedPrice As Double

    Private Sub UC_Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPrescription.Enabled = False

        AddHandler dgvPrescriptions.CellClick, AddressOf dgvPrescriptions_CellClick

        pnlRecipient.Controls.Add(listBoxResultsName)
        listBoxResultsName.Visible = False
        listBoxResultsName.BringToFront()
        AddHandler listBoxResultsName.SelectedIndexChanged, AddressOf ListBoxResultsName_SelectedIndexChanged
        AddHandler txbSearchName.TextChanged, AddressOf txbSearchName_TextChanged
        Dim listBoxX As Integer = txbSearchName.Left
        Dim listBoxY As Integer = txbSearchName.Bottom
        Dim listBoxWidth As Integer = txbSearchName.Width
        listBoxResultsName.Location = New Point(listBoxX, listBoxY)
        listBoxResultsName.Width = listBoxWidth

        pnlPrescription.Controls.Add(listBoxResultsVitamin)
        listBoxResultsVitamin.Visible = False
        listBoxResultsVitamin.BringToFront()
        AddHandler listBoxResultsVitamin.SelectedIndexChanged, AddressOf ListBoxResultsVitamins_SelectedIndexChanged
        AddHandler txbSearchVitamin.TextChanged, AddressOf txbSearchVitamin_TextChanged
        listBoxX = txbSearchVitamin.Left
        listBoxY = txbSearchVitamin.Bottom
        listBoxWidth = txbSearchVitamin.Width
        listBoxResultsVitamin.Location = New Point(listBoxX, listBoxY)
        listBoxResultsVitamin.Width = listBoxWidth
    End Sub

    Private Function SearchName(ByVal name As String) As Boolean
        Dim patientList As List(Of String) = ReusableMethods.PatientsListBox(filePathPatient)

        For i As Integer = 0 To patientList.Count - 1
            Dim currentItem As String = patientList(i)
            If currentItem.ToLower().Equals(name.ToLower()) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If ReusableMethods.IsNullOrEmpty(txbSearchName.Text) Then

            Dim patientName As String = ReusableMethods.RetrieveData(0, txbSearchName.Text, filePathPrescription, 0)
            Dim prescriptionDuration As String = ReusableMethods.RetrieveData(1, txbSearchName.Text, filePathPrescription, 0).ToString

            If txbSearchName.Text.Equals(patientName) Then
                If DateTime.Today < ReusableMethods.TryParseDate(prescriptionDuration) Then
                    MessageBox.Show($"Patient was already prescribe vitamins durating until {prescriptionDuration}, Try another patient!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txbOBDoctor.Clear()
                    txbSearchName.Clear()
                    txbTrimester.Clear()
                    Return
                End If
                Return
            End If

            If SearchName(txbSearchName.Text) Then

                Dim name As String = ReusableMethods.GetName(txbSearchName.Text, 0)

                'OB DOCTOR
                txbOBDoctor.Text = ReusableMethods.RetrieveData(14, name, filePathPatient, 1)
                'TRIMESTER
                Dim lastMenstrualString As String = ReusableMethods.RetrieveData(13, name, filePathPatient, 1)
                Dim lastMenstrualDate As DateTime = ReusableMethods.TryParseDate(lastMenstrualString)
                Dim trimester As String = uca.CheckTrimester(lastMenstrualDate)
                txbTrimester.Text = trimester
                lblSearchNameError.Text = ""
            Else
                lblSearchNameError.Text = "Unregistered Patient"
            End If
        Else
            lblSearchNameError.Text = "*Enter a Patient"
        End If
    End Sub

    Private Sub AdjustListBoxHeight(listBox As ListBox)
        Dim itemHeight As Integer = listBox.ItemHeight
        Dim visibleItems As Integer = Math.Min(listBox.Items.Count, 5) ' Limit to 5 visible items
        Dim listBoxHeight As Integer = visibleItems * itemHeight
        listBox.Height = listBoxHeight
    End Sub

    Private Sub txbSearchVitamin_TextChanged(sender As Object, e As EventArgs) Handles txbSearchVitamin.TextChanged
        Dim searchText As String = txbSearchVitamin.Text.ToLower()

        Dim searchResults As New List(Of String)()

        If searchText.Length > 0 Then
            listBoxResultsVitamin.Items.Clear()
            Dim vitaminNames As List(Of String) = VitaminsListBox()

            For Each item As String In vitaminNames
                If item.ToLower().Contains(searchText) Then
                    searchResults.Add(item)
                End If
            Next

            listBoxResultsVitamin.Items.AddRange(searchResults.ToArray())
            listBoxResultsVitamin.Visible = searchResults.Count > 0
        Else
            listBoxResultsVitamin.Items.Clear()
            listBoxResultsVitamin.Visible = False
        End If

        AdjustListBoxHeight(listBoxResultsVitamin)
        listBoxResultsVitamin.Visible = listBoxResultsVitamin.Items.Count > 0
    End Sub

    Private Sub ListBoxResultsVitamins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxResultsVitamin.SelectedIndexChanged
        If listBoxResultsVitamin.SelectedIndex <> -1 Then
            txbSearchVitamin.Text = listBoxResultsVitamin.SelectedItem.ToString()
            listBoxResultsVitamin.Visible = False
            listBoxResultsVitamin.Focus()
            txbSearchVitamin.Focus()
            txbSearchVitamin.SelectAll()
        End If
    End Sub

    Private Sub txbSearchName_TextChanged(sender As Object, e As EventArgs) Handles txbSearchName.TextChanged
        Dim searchText As String = txbSearchName.Text.ToLower()
        Dim searchResults As New List(Of String)()

        If searchText.Length > 0 Then
            listBoxResultsName.Items.Clear()
            Dim patientNames As List(Of String) = ReusableMethods.PatientsListBox(filePathPatient)

            For Each item As String In patientNames
                If item.ToLower().Contains(searchText) Then
                    searchResults.Add(item)
                End If
            Next

            listBoxResultsName.Items.AddRange(searchResults.ToArray())
            listBoxResultsName.Visible = searchResults.Count > 0
        Else
            listBoxResultsName.Items.Clear()
            listBoxResultsName.Visible = False
        End If

        AdjustListBoxHeight(listBoxResultsName)
        listBoxResultsName.Visible = listBoxResultsName.Items.Count > 0
    End Sub

    Private Sub ListBoxResultsName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxResultsName.SelectedIndexChanged
        If listBoxResultsName.SelectedIndex <> -1 Then
            txbSearchName.Text = listBoxResultsName.SelectedItem.ToString()
            listBoxResultsName.Visible = False
            listBoxResultsName.Focus()
            txbSearchName.Focus()
            txbSearchName.SelectAll()
        End If
    End Sub

    Private Sub rbInitial_CheckedChanged(sender As Object, e As EventArgs) Handles rbInitial.CheckedChanged
        If rbInitial.Checked Then
            totalPrice = initialFee
        ElseIf rbFollowUp.Checked Then
            totalPrice = followUpFee
        End If
        lblTotalPrice.Text = Format(totalPrice, "Currency")
    End Sub

    Private Sub rbFollowUp_CheckedChanged(sender As Object, e As EventArgs) Handles rbFollowUp.CheckedChanged
        If rbFollowUp.Checked Then
            totalPrice = followUpFee
        ElseIf rbInitial.Checked Then
            totalPrice = initialFee
        End If
        lblTotalPrice.Text = Format(totalPrice, "Currency")
    End Sub

    Private Sub rbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes.CheckedChanged
        Dim discountRate As Double
        Dim discountedPrice As Double
        If rbYes.Checked Then
            discountRate = totalPrice * 0.2
            discountedPrice = totalPrice - discountRate
        End If
        lblTotalPrice.Text = Format(discountedPrice, "Currency")
    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        If rbNo.Checked Then
        End If
        lblTotalPrice.Text = Format(totalPrice, "Currency")
    End Sub

    Private Sub pnlRecipient_MouseEnter(sender As Object, e As EventArgs) Handles pnlRecipient.MouseEnter
        listBoxResultsName.Visible = False
    End Sub

    Private Function VitaminsListBox() As List(Of String)
        Dim vitaminNames As New List(Of String)()

        If File.Exists(filePathVitamins) Then
            Using reader As New StreamReader(filePathVitamins)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values() As String = line.Split(","c)

                    If values.Length >= 5 Then
                        vitaminNames.Add(values(0))
                    End If
                End While
            End Using
        Else
            MessageBox.Show("The file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return vitaminNames
    End Function

    Private Sub btnPrescription_Click(sender As Object, e As EventArgs) Handles btnPrescription.Click
        If ReusableMethods.IsNullOrEmpty(txbSearchName.Text) AndAlso ReusableMethods.IsNullOrEmpty(txbOBDoctor.Text) AndAlso ReusableMethods.IsNullOrEmpty(txbTrimester.Text) AndAlso ReusableMethods.IsAnyRadioButtonChecked(gpbTypesOfCheckUp) AndAlso ReusableMethods.IsAnyRadioButtonChecked(gpbPhilHealthMember) Then
            pnlPrescription.Enabled = True
            lblErrorRecipient.Text = ""
            pnlRecipient.Enabled = False
        Else
            lblErrorRecipient.Text = "*You have to fill required field"
        End If

    End Sub

    Private Sub btnAddToPrescription_Click(sender As Object, e As EventArgs) Handles btnAddToPrescription.Click

        If ReusableMethods.IsNullOrEmpty(txbSearchVitamin.Text) OrElse ReusableMethods.IsNullOrEmpty(txbQuantity.Text) Then
            lblErrorPrescription.Text = " "

            Dim price As Double
            Dim quantity As Double

            If Double.TryParse(ReusableMethods.TryParsePrice(ReusableMethods.RetrieveData(3, txbSearchVitamin.Text, filePathVitamins, 0)), price) AndAlso
               Double.TryParse(txbQuantity.Text, quantity) Then

                Dim totalPriceForItem As Double = price * quantity

                dgvPrescriptions.Rows.Add(txbSearchVitamin.Text, price, txbQuantity.Text, totalPriceForItem)
                txbSearchVitamin.Clear()
                txbQuantity.Clear()

                lastAddedPrice = totalPriceForItem
                totalPrice += totalPriceForItem


                lblTotalPrice.Text = Format(totalPrice.ToString(), "Currency")

            Else
                lblErrorPrescription.Text = "Invalid Price or Quantity."
            End If
        Else
            lblErrorPrescription.Text = "*Fill all the required field"
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        Dim xPos As Single = 10
        Dim yPos As Single = 10

        Dim receiptContent As String = File.ReadAllText(filePathReceipt)

        e.Graphics.DrawString(receiptContent, font, brush, xPos, yPos)

        ' Dispose of the font and brush objects
        font.Dispose()
        brush.Dispose()
    End Sub

    Private Function CalculateTotalPrice() As Double
        Dim totalPrice As Decimal = 0

        For Each row As DataGridViewRow In dgvPrescriptions.Rows
            If Not row.IsNewRow Then
                Dim price As Decimal
                If Decimal.TryParse(row.Cells("Total").Value.ToString(), price) Then
                    totalPrice += price
                End If
            End If
        Next

        Return totalPrice
    End Function

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click

        Dim bill As Boolean
        For Each row As DataGridViewRow In dgvPrescriptions.Rows
            If Not row.IsNewRow Then
                Dim vitaminName As String = row.Cells("Vitamin").Value.ToString()
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)

                Dim vitaminStocks As String = ReusableMethods.RetrieveData(4, vitaminName, filePathVitamins, 0)

                If quantity <= Val(vitaminStocks) Then
                    bill = True
                Else
                    MessageBox.Show($"Insufficient {vitaminName} stocks!. Only [{vitaminStocks}] vitamin stocks left. Check Inventory first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

        Next

        If ReusableMethods.IsNullOrEmpty(txbPayment.Text) Then
            If dgvPrescriptions.Rows.Count > 0 Then
                Dim totalPrice As Decimal = CalculateTotalPrice()
                Dim payment As Decimal

                If Decimal.TryParse(ReusableMethods.TryParsePrice(lblTotalPrice.Text), payment) AndAlso Decimal.TryParse(txbPayment.Text, payment) Then
                    Dim actualPayment As Decimal = Decimal.Parse(txbPayment.Text)
                    Dim remainingBalance As Decimal

                    If actualPayment >= lblTotalPrice.Text Then
                        remainingBalance = actualPayment - lblTotalPrice.Text
                        Dim result As DialogResult = MessageBox.Show($"Payment successful! Remaining balance: {remainingBalance}", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result = DialogResult.OK Then
                            Try
                                Dim receiptContent As String = GenerateReceiptContent(txbSearchName.Text, txbOBDoctor.Text, txbTrimester.Text, remainingBalance, txbPayment.Text)
                                File.WriteAllText(filePathReceipt, receiptContent)
                                MessageBox.Show("Receipt saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ' WRITER
                                Dim name As String = txbSearchName.Text.Trim()
                                Dim nextAppointment As String = ReusableMethods.RetrieveData(1, name, filePathSchedule, 0)

                                Using writer As New StreamWriter(filePathPrescription, True)
                                    writer.Write($"{name},{nextAppointment}")

                                    ' Store vitamins
                                    For Each row As DataGridViewRow In dgvPrescriptions.Rows
                                        If Not row.IsNewRow Then
                                            Dim vitaminName As String = row.Cells("Vitamin").Value.ToString()
                                            Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                                            writer.Write($",{vitaminName},{quantity}")
                                        End If
                                    Next

                                    writer.WriteLine()
                                End Using

                                txbSearchVitamin.Clear()
                                txbQuantity.Clear()
                                pnlPrescription.Enabled = False
                                txbPayment.ReadOnly = False

                                Dim qr As New QRCode()
                                qr.ShowDialog()

                            Catch ex As Exception
                                MessageBox.Show($"Error saving receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try

                            ' Update inventory for each sold vitamin
                            For Each row As DataGridViewRow In dgvPrescriptions.Rows
                                If Not row.IsNewRow Then
                                    Dim vitaminName As String = row.Cells("Vitamin").Value.ToString()
                                    Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                                    If bill Then
                                        UpdateInventory(vitaminName, quantity)
                                    End If
                                End If

                            Next
                        End If
                    Else
                        lblInsufficientPayment.Text = "Insufficient payment amount!"
                    End If

                    txbPayment.Text = remainingBalance.ToString()
                Else
                    lblInsufficientPayment.Text = "Invalid input! Please enter valid numeric values."
                End If
            Else
                lblInsufficientPayment.Text = "Enter a drug to prescribe."
            End If
        Else
            lblInsufficientPayment.Text = "Payment should be settled first before Billing."
        End If
    End Sub

    Private Function GenerateReceiptContent(ByVal name As String, ByVal doctor As String, ByVal trimester As String, ByVal change As Double, ByVal payment As Double) As String
        Dim receiptContent As New System.Text.StringBuilder()

        Dim checkup As String
        Dim checkupBill As String

        If rbInitial.Checked Then
            checkup = "Initial Check-Up"
            checkupBill = "2000.00"
        Else
            checkup = "Follow-Up Check-Up"
            checkupBill = "500.00"
        End If

        ' Clinic information
        Dim clinicName As String = "New OB Master Gyn Clinic"
        Dim clinicAddress As String = "456 Maligaya Street, Tarlac City, Philippines"
        Dim clinicContact As String = "(123) 456-7890"
        Dim clinicInfo As String = $"{clinicName}{Environment.NewLine}" &
                               $"{clinicAddress}{Environment.NewLine}" &
                               $"Contact: {clinicContact}{Environment.NewLine}" &
                               $"Clinic #: 54321 | Doctor #: 5678{Environment.NewLine}" &
                               $"Doctor: {doctor} | Date: {DateTime.Now.ToString("MM/dd/yyyy")} {Environment.NewLine}" &
                               $"Patient: {name} | {trimester} {Environment.NewLine}" &
                               $"Type of Check-Up: {checkup}"

        ' Receipt header
        receiptContent.AppendLine("==================================")
        receiptContent.AppendLine(clinicInfo)
        receiptContent.AppendLine("-----------------------------------------------------------")
        receiptContent.AppendLine("Item                               Price      Qty     Total")
        receiptContent.AppendLine("-----------------------------------------------------------")
        receiptContent.AppendLine("Check-Up Bill: Php. " + checkupBill)
        receiptContent.AppendLine("Next Appointment: " + ReusableMethods.RetrieveData(1, name, filePathSchedule, 0)).ToString()

        ' Prescription details
        For Each row As DataGridViewRow In dgvPrescriptions.Rows
            If Not row.IsNewRow Then
                Dim vitaminName As String = row.Cells("Vitamin").Value.ToString()
                Dim price As Double = Convert.ToDouble(row.Cells("Price").Value)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                Dim dosage As String = row.Cells("DailyDosage").Value
                Dim totalPriceForItem As Double = price * quantity

                Dim formattedItem As String = $"{vitaminName}: {price:C} x {quantity} = {totalPriceForItem:C} | {dosage}"
                receiptContent.AppendLine(formattedItem)
            End If
        Next

        ' Total amount
        Dim totalAmount As Double = lblTotalPrice.Text
        ' Append total to receipt content
        Dim formattedTotal As String = $"Total:                                           {totalAmount:C}"
        Dim formattedChange As String = $"Change:                                             {change:C}"
        Dim formattedPayment As String = $"Payment:                                        {payment:C}"
        receiptContent.AppendLine("-----------------------------------------------------------")
        receiptContent.AppendLine(formattedTotal)
        receiptContent.AppendLine(formattedPayment)
        receiptContent.AppendLine(formattedChange)
        receiptContent.AppendLine("=================================")
        receiptContent.AppendLine("Thank you for choosing New OB-GYN Clinic!")

        Return receiptContent.ToString()
    End Function

    Private Sub UpdateInventory(vitaminName As String, quantityToSubtract As Integer)
        Try
            Dim lines As List(Of String) = File.ReadAllLines(filePathVitamins).ToList()

            For i As Integer = 0 To lines.Count - 1
                Dim parts As String() = lines(i).Split(","c)
                If parts.Length >= 5 AndAlso parts(0).Trim() = vitaminName Then
                    Dim currentQuantity As Integer
                    If Integer.TryParse(parts(parts.Length - 1).Trim(), currentQuantity) Then
                        Dim newQuantity As Integer = currentQuantity - quantityToSubtract
                        parts(parts.Length - 1) = newQuantity.ToString()
                        lines(i) = String.Join(",", parts)
                        Exit For
                    End If
                End If
            Next

            File.WriteAllLines(filePathVitamins, lines)
        Catch ex As Exception
            MessageBox.Show($"Error updating inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvPrescriptions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrescriptions.CellClick
        Try
            If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 AndAlso e.RowIndex < dgvPrescriptions.Rows.Count - 1 Then
                If dgvPrescriptions.Rows(e.RowIndex).Cells(0).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(dgvPrescriptions.Rows(e.RowIndex).Cells(0).Value.ToString()) Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you wish to remove this vitamin?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        Dim vitaminName As String = dgvPrescriptions.Rows(e.RowIndex).Cells(0).Value.ToString()
                        ReusableMethods.RemovePatientFromDataGridView(vitaminName, dgvPrescriptions)

                        Dim total As Integer
                        Dim deduct As Integer
                        For Each row As DataGridViewRow In dgvPrescriptions.Rows
                            If Not row.IsNewRow Then
                                total = Convert.ToInt32(row.Cells("Total").Value)
                            End If
                            deduct += Total
                        Next
                        lblTotalPrice.Text = Val(lblTotalPrice.Text) - deduct
                    End If
                Else
                    lblInsufficientPayment.Text = "The cell clicked is empty. Please select a valid cell."
                End If
            Else
                lblInsufficientPayment.Text = "Click a valid vitamin row to be removed."
            End If
        Catch ex As Exception
            lblInsufficientPayment.Text = $"An error occurred: {ex.Message}"
        End Try
    End Sub

    Private Sub dgvPrescriptions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrescriptions.CellContentClick

    End Sub
End Class