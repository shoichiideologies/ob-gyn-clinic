Imports System.Globalization
Imports System.IO

Public Class UC_Patients
    Dim ReusableMethods As New UniversalMethods()
    Dim filePathPatients As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Patients.txt"
    Dim filePathSchedule As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Schedule.txt"
    Dim filePathPrescription As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Prescription.txt"

    Private Sub addPatient_Click(sender As Object, e As EventArgs) Handles addPatient.Click
        Dim add As New AddPatient()
        add.ShowDialog()
    End Sub

    Public Sub DisplayPatientsInformation()
        If File.Exists(filePathPatients) Then
            Using reader As New StreamReader(filePathPatients)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values() As String = line.Split(","c)

                    If values.Length > 0 Then
                        Dim rowIndex As Integer = dgvPatientsList.Rows.Add()
                        Dim row As DataGridViewRow = dgvPatientsList.Rows(rowIndex)

                        For i As Integer = 0 To Math.Min(values.Length - 1, dgvPatientsList.Columns.Count - 1)
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

    Private Sub UC_Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPatientsInformation()
        PopulateDoctorsComboBox()
    End Sub

    Private Sub PopulateDoctorsComboBox()
        Dim doctorsList As ArrayList = ReusableMethods.Doctors()

        For Each doctor As String In doctorsList
            cmbDoctors.Items.Add(doctor)
        Next

        cmbDoctors.SelectedItem = "All"
    End Sub

    Private Sub cmbDoctors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDoctors.SelectedIndexChanged
        FilterPatientsByDoctor(cmbDoctors.SelectedItem.ToString())
    End Sub

    Private Sub FilterPatientsByDoctor(selectedDoctor As String)
        dgvPatientsList.Rows.Clear()

        If File.Exists(filePathPatients) Then
            Using reader As New StreamReader(filePathPatients)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values() As String = line.Split(","c)

                    If values.Length > 0 Then
                        Dim doctorName As String = values(14).Trim()

                        If selectedDoctor = "All" OrElse doctorName = selectedDoctor Then
                            Dim rowIndex As Integer = dgvPatientsList.Rows.Add()
                            Dim row As DataGridViewRow = dgvPatientsList.Rows(rowIndex)

                            For i As Integer = 0 To Math.Min(values.Length - 1, dgvPatientsList.Columns.Count - 1)
                                row.Cells(i).Value = values(i)
                            Next
                        End If
                    Else
                        MessageBox.Show("Empty line found in the data file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End While
            End Using
        Else
            MessageBox.Show("The data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvPatientsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatientsList.CellClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you wish to delete this patient? Reminder: The following will be prior to the deletion. " + Environment.NewLine + "(1) Patients Personal Information" + Environment.NewLine + "(2) Patients Appointments" + Environment.NewLine + "(3) Patients Schedule", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim patientName As String = dgvPatientsList.Rows(e.RowIndex).Cells(1).Value.ToString()
                ReusableMethods.RemovePatientFromDataGridView(patientName, dgvPatientsList)
                ReusableMethods.RemovePatientFromPatientsFile(patientName, filePathPatients)
                ReusableMethods.RemovePatientAppointmentFromScheduleFile(patientName, filePathSchedule)
                ReusableMethods.RemovePatientPrescriptionsFromScheduleFile(patientName, filePathPrescription)
            End If
        End If
    End Sub

End Class