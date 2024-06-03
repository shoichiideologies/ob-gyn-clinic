Imports System.IO
Imports System.IO.Packaging
Imports System.Runtime.CompilerServices
Imports System.Windows.Automation.Peers
Imports System.Xml
Imports QRCoder

Public Class UC_Appointments
    Dim ReusableMethods As New UniversalMethods()
    Dim filePathVitamins As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Vitamins.txt"
    Dim filePathReceipt As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Receipt.txt"
    Dim filePathPatient As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Patients.txt"
    Dim filePathSchedule As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Schedule.txt"

    Public Function CheckTrimester(ByVal lastMenstrualDate As DateTime) As String
        Dim daysSinceLastMenstrual As Integer = (DateTime.Today - lastMenstrualDate.Date).TotalDays

        If (daysSinceLastMenstrual >= 0 AndAlso daysSinceLastMenstrual <= 95) Then
            Return "First Trimester"
        ElseIf (daysSinceLastMenstrual > 95 AndAlso daysSinceLastMenstrual <= 190) Then
            Return "Second Trimester"
        ElseIf (daysSinceLastMenstrual > 190 AndAlso daysSinceLastMenstrual <= 270) Then
            Return "Third Trimester"
        Else
            Return "Invalid Trimester"
        End If
    End Function

    Private Function ScheduleAppointment(ByVal trimester As String, ByVal lastCheckUp As DateTime) As DateTime

        If trimester.Equals("First Trimester") Then
            lastCheckUp = lastCheckUp.AddDays(30)
        ElseIf trimester.Equals("Second Trimester") Then
            lastCheckUp = lastCheckUp.AddDays(20)
        ElseIf trimester.Equals("Third Trimester") Then
            lastCheckUp = lastCheckUp.AddDays(10)
        End If
        Return lastCheckUp.Date
    End Function

    Private Sub dgvPatients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellClick

        Dim clickedCellValue As String = dgvPatients.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
        txbPatientName.Text = clickedCellValue

        Dim lastMenstrualString As String = ReusableMethods.RetrieveData(13, ReusableMethods.GetName(clickedCellValue, 0), filePathPatient, 1)
        txbLastMenstrualCycle.Text = ReusableMethods.TryParseDate(lastMenstrualString)

        Dim initialCheckUpString As String = ReusableMethods.RetrieveData(15, ReusableMethods.GetName(clickedCellValue, 0), filePathPatient, 1)
        txbLastCheckUp.Text = ReusableMethods.TryParseDate(initialCheckUpString)

        Dim lastMenstrualDate As DateTime = ReusableMethods.TryParseDate(lastMenstrualString)
        Dim trimester As String = CheckTrimester(lastMenstrualDate)
        txbTrimester.Text = trimester

        Dim nextAppointment As DateTime = ScheduleAppointment(trimester, ReusableMethods.TryParseDate(initialCheckUpString))
        dtpNextAppointment.Text = nextAppointment.ToShortDateString()

        Dim appointment As String = CheckIfOfficeHours(nextAppointment)
        txbScheduledOB.Text = ReusableMethods.GetDoctor(appointment)
    End Sub

    Private Function CheckIfOfficeHours(ByVal dateString As String) As String
        Dim dateTime As DateTime = ReusableMethods.TryParseDate(dateString)

        If dateTime.DayOfWeek = DayOfWeek.Monday Then
            Return dateTime.AddDays(1)
        ElseIf dateTime.DayOfWeek = DayOfWeek.Sunday Then
            Return dateTime.AddDays(2)
        End If
        Return dateTime
    End Function

    Private Sub UC_Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReusableMethods.DisplayPatients(dgvPatients)
        ReusableMethods.DisplayAppointments(dgvPatientsAppointments)
    End Sub

    Private Function LastAppointment(ByVal patient As String, ByVal filePath As String) As Boolean
        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            For Each line As String In lines
                Dim parts() As String = line.Split(","c)
                Dim patientInFile As String = parts(0).Trim()
                If String.Equals(patientInFile, patient, StringComparison.OrdinalIgnoreCase) Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub DeletePreviousAppointment(ByVal patient As String, ByVal filePath As String)
        If File.Exists(filePath) Then
            Dim lines As New List(Of String)(File.ReadAllLines(filePath))
            Dim indexToRemove As Integer = -1
            For i As Integer = 0 To lines.Count - 1
                Dim parts() As String = lines(i).Split(","c)
                Dim patientInFile As String = parts(0).Trim()
                If String.Equals(patientInFile, patient, StringComparison.OrdinalIgnoreCase) Then
                    indexToRemove = i
                    Exit For
                End If
            Next

            If indexToRemove <> -1 Then
                lines.RemoveAt(indexToRemove)
                File.WriteAllLines(filePath, lines)
            End If
        Else
            MessageBox.Show("The data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim appointmentDate As DateTime

        If DateTime.TryParse(dtpNextAppointment.Text, appointmentDate) Then
            If appointmentDate < DateTime.Now Then
                MessageBox.Show("The appointment date is in the past.", "Invalid Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf appointmentDate > Convert.ToDateTime(txbLastMenstrualCycle.Text).AddDays(300) Then
                MessageBox.Show("The appointment date is beyond pregnancy.", "Invalid Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If appointmentDate.DayOfWeek = DayOfWeek.Monday OrElse appointmentDate.DayOfWeek = DayOfWeek.Sunday Then
                Dim result As DialogResult = MessageBox.Show("Your Appointment will be adjusted from " & dtpNextAppointment.Text & " (" & ReusableMethods.GetDayOfTheWeek(dtpNextAppointment.Text) & ") to " & CheckIfOfficeHours(dtpNextAppointment.Text) & " (" & ReusableMethods.GetDayOfTheWeek(CheckIfOfficeHours(dtpNextAppointment.Text)) & ")" & " for the following reason(s):" & Environment.NewLine & Environment.NewLine & "(1) The Initial Appointment is set to a Non-Working day." & Environment.NewLine & "(2) No Doctor is Available.", "Appointment Adjustment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                If result = DialogResult.OK Then
                    dtpNextAppointment.Text = CheckIfOfficeHours(dtpNextAppointment.Text)
                Else
                    Return
                End If
            End If

            Dim patientName As String = txbPatientName.Text.Trim()
            Dim appointmentDateStr As String = dtpNextAppointment.Text

            If Not String.IsNullOrWhiteSpace(patientName) AndAlso Not String.IsNullOrWhiteSpace(appointmentDateStr) Then
                If LastAppointment(patientName, filePathSchedule) Then
                    DeletePreviousAppointment(patientName, filePathSchedule)
                End If

                Using writer As New StreamWriter(filePathSchedule, True)
                    writer.WriteLine($"{patientName},{appointmentDateStr}")
                    MessageBox.Show($"You have successfully scheduled an appointment with {patientName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Else
                MessageBox.Show("Please enter patient name and appointment date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter a valid appointment date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class