Public Class Patient
    Public Property PatientFirstName As String
    Public Property PatientLastName As String
    Public Property Age As String
    Public Property CivilStatus As String
    Public Property Birthdate As Date
    Public Property Address As String
    Public Property FirstBaby As String
    Public Property PrefferedDelivery As String
    Public Property CompanyFirstName As String
    Public Property CompanyLastName As String
    Public Property Relationship As String
    Public Property ContactNumber As String
    Public Property LastMenstrualCycle As DateTime
    Public Property OB As String
    Public Property InitialCheckUp As DateTime

    Public Sub New(ByVal patientFirstName As String, ByVal patientLastName As String, ByVal age As String, ByVal civilStatus As String,
                   ByVal birthdate As Date, ByVal address As String, ByVal firstBaby As String, ByVal prefferedDelivery As String,
                   ByVal companyFirstName As String, ByVal companyLastName As String, ByVal relationship As String,
                   ByVal contactNumber As String, ByVal lastMenstrualCycle As Date, ByVal ob As String, ByVal InitialCheckUp As DateTime)
        Me.PatientFirstName = patientFirstName
        Me.PatientLastName = patientLastName
        Me.Age = age
        Me.CivilStatus = civilStatus
        Me.Birthdate = birthdate
        Me.Address = address
        Me.FirstBaby = firstBaby
        Me.PrefferedDelivery = prefferedDelivery
        Me.CompanyFirstName = companyFirstName
        Me.CompanyLastName = companyLastName
        Me.Relationship = relationship
        Me.ContactNumber = contactNumber
        Me.LastMenstrualCycle = lastMenstrualCycle
        Me.OB = ob
        Me.InitialCheckUp = InitialCheckUp
    End Sub
End Class