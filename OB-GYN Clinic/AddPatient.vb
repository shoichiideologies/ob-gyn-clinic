Imports System.Drawing.Text
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports Guna.UI2.WinForms

Public Class AddPatient
    Dim ReusableMethods As New UniversalMethods()
    Dim filePathPatient As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Patients.txt"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Function IsValidInput(ByVal value As String, ByVal condition As Func(Of String, Boolean)) As Boolean
        Return condition.Invoke(value)
    End Function

    Private Function IsValidAge(ByVal value As String) As Boolean
        Return IsValidInput(value, AddressOf IsNumeric)
    End Function

    Private Function modifyDate(ByVal value As DateTime) As String
        Dim dateString As String = value.ToString("d")
        dateString = dateString.Replace("*", "\").Replace(" ", "\")
        Dim modifiedDate As DateTime
        If DateTime.TryParse(dateString, modifiedDate) Then
            Return modifiedDate.ToString()
        Else
            Return value.ToString()
        End If
    End Function

    Private Function IsValidContactNumber(contactNumber As String) As Boolean
        If IsNumeric(contactNumber) AndAlso contactNumber.Length = 11 Then
            Return True
        End If
        Return False
    End Function

    Private Function IsDateLessThanToday(selectedDate As DateTime) As Boolean
        If selectedDate < DateTime.Today Then
            Return True
        End If
        Return False
    End Function

    Private Function IsValidData() As Boolean
        Dim errorMessages As New List(Of String)

        If String.IsNullOrEmpty(txbPatientFirstName.Text) OrElse
           String.IsNullOrEmpty(txbPatientLastName.Text) OrElse
           String.IsNullOrEmpty(txbAge.Text) OrElse
           String.IsNullOrEmpty(txbCivilStatus.Text) OrElse
           String.IsNullOrEmpty(dtpBirthdate.Text) OrElse
           String.IsNullOrEmpty(txbAddress.Text) OrElse
           String.IsNullOrEmpty(txbFirstBaby.Text) OrElse
           String.IsNullOrEmpty(txbPreferredDelivery.Text) OrElse
           String.IsNullOrEmpty(txbComponyFirstName.Text) OrElse
           String.IsNullOrEmpty(txbComponyLastName.Text) OrElse
           String.IsNullOrEmpty(txbRelationship.Text) OrElse
           String.IsNullOrEmpty(txbContactNumber.Text) OrElse
           String.IsNullOrEmpty(cmbOBDoctors.Text) OrElse
           String.IsNullOrEmpty(dtpLastMenstrualCycle.Text) Then
            errorMessages.Add("All fields are required.")
        Else
            If Not IsValidAge(txbAge.Text) Then
                errorMessages.Add("Invalid Age")
            End If

            If Not IsValidContactNumber(txbContactNumber.Text) Then
                errorMessages.Add("Invalid Contact Number")
            End If

            If Not IsDateLessThanToday(dtpLastMenstrualCycle.Value) Then
                errorMessages.Add("Invalid Menstrual Cycle Date")
            End If
        End If

        If errorMessages.Count > 0 Then
            lblError.Text = String.Join(" | ", errorMessages)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txbAddPatient_Click(sender As Object, e As EventArgs) Handles txbAddPatient.Click
        lblError.Text = ""

        If IsValidData() Then
            WritePatient()
        End If
    End Sub

    Public Sub WritePatient()
        Dim firstNameData As String = ReusableMethods.RetrieveData(1, txbPatientFirstName.Text, filePathPatient, 1)
        Dim lastNameData As String = ReusableMethods.RetrieveData(2, txbPatientLastName.Text, filePathPatient, 2)

        If txbPatientFirstName.Text.Equals(firstNameData) AndAlso txbPatientLastName.Text.Equals(lastNameData) Then
            MessageBox.Show("This patient is already a patient of the clinic!", "Already added", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Continue with adding the new patient
        Dim currentDate As DateTime = DateTime.Now
        Dim patient As New Patient(txbPatientFirstName.Text, txbPatientLastName.Text, txbAge.Text, txbCivilStatus.Text,
                               dtpBirthdate.Text, txbAddress.Text, txbFirstBaby.Text,
                               txbPreferredDelivery.Text, txbComponyFirstName.Text,
                               txbComponyLastName.Text, txbRelationship.Text, txbContactNumber.Text,
                               dtpLastMenstrualCycle.Text, cmbOBDoctors.Text, currentDate)

        Dim patientInfo As String = $"{ReusableMethods.GeneratePatientID()},{patient.PatientFirstName},{patient.PatientLastName},{patient.Age},{patient.CivilStatus},{modifyDate(patient.Birthdate.Date)},{patient.Address},{patient.FirstBaby},{patient.PrefferedDelivery},{patient.CompanyFirstName},{patient.CompanyLastName},{patient.Relationship},{patient.ContactNumber},{modifyDate(patient.LastMenstrualCycle.Date)},{patient.OB},{currentDate}"

        Using writer As New StreamWriter(filePathPatient, True)
            writer.WriteLine(patientInfo)
            MessageBox.Show("You have successfully added a Patient!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using

        Me.Close()
    End Sub

    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        txbAge.ReadOnly = True
        Dim selectedDate As DateTime = dtpBirthdate.Value
        Dim age As Integer = DateTime.Today.Year - selectedDate.Year

        If selectedDate.Date > DateTime.Today.AddYears(-age) Then
            age -= 1
        End If

        txbAge.Text = age.ToString()
        txbAge.ReadOnly = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class