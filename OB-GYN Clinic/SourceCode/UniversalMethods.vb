Imports System.Drawing.Text
Imports System.IO
Imports System.Text
Imports OB_GYN_Clinic.UC_Summary
Imports OB_GYN_Clinic.FilePaths

Public Class UniversalMethods
    Public Function IsNullOrEmpty(ByVal text As String) As Boolean
        If String.IsNullOrEmpty(text) Then
            Return False
        End If
        Return True
    End Function

    Public Function IsAnyRadioButtonChecked(groupBox As GroupBox) As Boolean
        For Each rb As RadioButton In groupBox.Controls.OfType(Of RadioButton)()
            If rb.Checked Then
                Return True
            End If
        Next
        Return False
    End Function

    'CHECKING FORMAT
    Public Function TryParseDate(ByVal dateString As String) As Date
        Dim dateObject As Date
        If Date.TryParse(dateString, dateObject) Then
            Return dateObject
        Else
            MessageBox.Show("Error parsing date: " & dateString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Date.MinValue
        End If
    End Function

    Public Function TryParsePrice(ByVal price As String) As Double
        Dim cleanedPrice As String = ""

        ' Remove all characters except dots
        For Each c As Char In price
            If Char.IsDigit(c) OrElse c = "."c Then
                cleanedPrice += c
            End If
        Next

        ' Parse the cleaned price
        Dim parsedPrice As Double = 0
        Double.TryParse(cleanedPrice, parsedPrice)

        Return parsedPrice
    End Function

    'RETURN 
    Public Function GetName(ByVal name As String, ByVal index As Integer) As String
        Dim words() As String = name.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

        If words.Length > 0 Then
            Return words(index)
        Else
            Return "" ' Or throw an exception if there are no words in the input string
        End If
    End Function

    Public Function GetDoctor(ByVal dateTime As String) As String
        Dim parsedDate As DateTime
        If Date.TryParse(dateTime, parsedDate) Then
            Select Case parsedDate.DayOfWeek
                Case DayOfWeek.Tuesday
                    Return "Doctor Foley"
                Case DayOfWeek.Wednesday
                    Return "Phd Doctor Smith"
                Case DayOfWeek.Thursday
                    Return "Doctor Hoffman"
                Case DayOfWeek.Friday
                    Return "Phd Doctor Manlapaz"
                Case DayOfWeek.Saturday
                    Return "Doctor Gibbins"
                Case Else
                    Return "No doctor available" & Environment.NewLine & "Clinic Close"
            End Select
        Else
            Return "Invalid date format"
        End If
    End Function

    Public Function GeneratePatientID() As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim codeBuilder As New StringBuilder()
        Dim random As New Random(Guid.NewGuid().GetHashCode())

        For i As Integer = 1 To 8
            Dim randomCharIndex As Integer = random.Next(0, chars.Length)
            Dim randomChar As Char = chars(randomCharIndex)
            codeBuilder.Append(randomChar)
        Next
        Return codeBuilder.ToString()
    End Function

    Public Function GetDayOfTheWeek(ByVal dateTime As String) As String
        Dim dt = TryParseDate(dateTime)
        Return dt.DayOfWeek.ToString()
    End Function

    Public Function GetPatientIDByName(ByVal patientName As String, ByVal filePath As String) As String

        Dim lines As String() = File.ReadAllLines(filePath)

        For Each line As String In lines
            Dim fields As String() = line.Split(","c)

            Dim patientID As String = $"{fields(0)}"
            If patientID.ToLower() = patientName.ToLower() Then
                Return fields(0)
            End If
        Next

        Return ""
    End Function

    'DISPLAYING OF INFORMATIONS
    Public Sub DisplayPatients(ByVal dgvPatients As DataGridView)
        dgvPatients.Rows.Clear()
        Dim filePathPatient As String = PatientsFile

        Using reader As New StreamReader(filePathPatient)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim values() As String = line.Split(","c)

                If values.Length >= 14 Then
                    dgvPatients.Rows.Add(values(1) + " " + values(2))
                Else
                    MessageBox.Show("The data file does not contain enough values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End While
        End Using
    End Sub

    Public Sub DisplayAppointments(ByVal dgvAppointments As DataGridView)
        Dim filePathSchedule As String = ScheduleFile

        dgvAppointments.Rows.Clear()
        If File.Exists(filePathSchedule) Then
            Using reader As New StreamReader(filePathSchedule)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values() As String = line.Split(","c)

                    If values.Length >= 2 Then
                        dgvAppointments.Rows.Add(values(0), values(1))
                    Else
                        MessageBox.Show("The data file does not contain enough values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End While
            End Using
        Else
            MessageBox.Show("The data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'RETRIEVING
    Public Function RetrieveData(ByVal index As Integer, ByVal lineName As String, ByVal FilePath As String, ByVal column As Integer) As String
        Dim result As String = ""

        If File.Exists(FilePath) Then
            Using reader As New StreamReader(FilePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values() As String = line.Split(","c)

                    If values.Length > 0 AndAlso values(column) = lineName Then
                        If index >= 0 AndAlso index < values.Length Then
                            result = values(index)
                            Exit While
                        Else
                            MessageBox.Show("Index is out of bounds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return ""
                        End If
                    End If
                End While
            End Using
        Else
            MessageBox.Show("The data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return result
    End Function

    'POOL OF RETRIEVE DATA
    Public Function PatientsListBox(ByVal filePath As String) As List(Of String)
        Dim patientNames As New List(Of String)()

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim parts() As String = reader.ReadLine().Split(","c)

                    If parts.Length >= 2 Then
                        patientNames.Add(parts(1) & " " & parts(2))
                    End If
                End While
            End Using
        Else
            MessageBox.Show("The file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return patientNames
    End Function

    Public Function VitaminsListBox(ByVal filePath As String) As List(Of String)
        Dim vitaminNames As New List(Of String)()

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values() As String = line.Split(","c)

                    If values.Length >= 5 Then
                        vitaminNames.Add(values(1))
                    End If
                End While
            End Using
        Else
            MessageBox.Show("The file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return vitaminNames
    End Function

    Public Function AppointmentListBox(ByVal filePath As String) As List(Of Schedule)
        Dim appointments As New List(Of Schedule)()

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Process each line
            For Each line As String In lines
                Dim parts As String() = line.Split(","c)

                Dim schedule As New Schedule()
                If Date.TryParse(parts(1), schedule.Day) Then
                    schedule.Name = parts(0).Trim()
                    appointments.Add(schedule)
                End If
            Next
        Else
            MessageBox.Show("File not found: " & filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return appointments
    End Function

    Public Function BirthdayListBox(ByVal filepath As String) As List(Of Schedule)
        Dim birthdays As New List(Of Schedule)()

        If File.Exists(filepath) Then
            Dim lines As String() = File.ReadAllLines(filepath)

            For Each line As String In lines
                Dim parts As String() = line.Split(","c)

                Dim bday As New Schedule()
                If Date.TryParse(parts(5), bday.Day) Then
                    bday.Name = parts(1).Trim() + " " + parts(2)
                    birthdays.Add(bday)
                End If
            Next
        Else
            MessageBox.Show("File not found: " & filepath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return birthdays
    End Function

    'REMOVAL OF DATA
    Public Sub RemovePatientFromPatientsFile(ByVal patientID As String, ByVal filePath As String)
        Dim patientLines As New List(Of String)(File.ReadAllLines(filePath))
        Dim patientLineToRemove As String = patientLines.FirstOrDefault(Function(line) line.Contains(patientID))

        If patientLineToRemove IsNot Nothing Then
            patientLines.Remove(patientLineToRemove)
            File.WriteAllLines(filePath, patientLines)
            MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Patient not found in the Patients file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub RemovePatientFromDataGridView(ByVal title As String, ByVal dataGridView As DataGridView)
        Try
            For Each row As DataGridViewRow In dataGridView.Rows
                If Not row.IsNewRow AndAlso row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString().Contains(title) Then
                    dataGridView.Rows.Remove(row)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"An error occurred while removing the row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RemovePatientAppointmentFromScheduleFile(ByVal patientName As String, ByVal FilePath As String)
        Dim scheduleLines As New List(Of String)(File.ReadAllLines(FilePath))
        Dim scheduleLineToRemove As String = scheduleLines.FirstOrDefault(Function(line) line.Contains(patientName))

        If scheduleLineToRemove IsNot Nothing Then
            scheduleLines.Remove(scheduleLineToRemove)
            File.WriteAllLines(FilePath, scheduleLines)
            MessageBox.Show("Patient's appointment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Patient's appointment not found in the Schedule file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub RemovePatientPrescriptionsFromScheduleFile(ByVal patientName As String, ByVal FilePath As String)
        Dim prescriptionLines As New List(Of String)(File.ReadAllLines(FilePath))
        Dim prescriptionLineToRemove As String = prescriptionLines.FirstOrDefault(Function(line) line.Contains(patientName))

        If prescriptionLineToRemove IsNot Nothing Then
            prescriptionLines.Remove(prescriptionLineToRemove)
            File.WriteAllLines(FilePath, prescriptionLines)
            MessageBox.Show("Patient's prescriptions deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Patient's prescriptions not found in the Prescription file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'DATA
    Public Function Doctors() As ArrayList
        Dim doctor As New ArrayList()
        doctor.Add("Dr. Smith")
        doctor.Add("Dr. Foley")
        doctor.Add("Dr. Gibbins")
        doctor.Add("Dr. Manlapaz")
        doctor.Add("Dr. Hoffman")
        doctor.Add("All")

        Return doctor
    End Function
End Class
