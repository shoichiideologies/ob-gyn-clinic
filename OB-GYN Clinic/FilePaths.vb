Imports System.IO

Public Module FilePaths
    ' Base path (where your .exe runs)
    Public ReadOnly BasePath As String = Application.StartupPath

    ' Folder for text files
    Public ReadOnly TextFolder As String = Path.Combine(BasePath, "Text Files")

    ' File paths (directly inside Text Files folder)
    Public ReadOnly PatientsFile As String = Path.Combine(TextFolder, "Patients.txt")
    Public ReadOnly PrescriptionFile As String = Path.Combine(TextFolder, "Prescription.txt")
    Public ReadOnly ReceiptFile As String = Path.Combine(TextFolder, "Receipt.txt")
    Public ReadOnly ScheduleFile As String = Path.Combine(TextFolder, "Schedule.txt")
    Public ReadOnly VitaminsFile As String = Path.Combine(TextFolder, "Vitamins.txt")

    ' Initialize files/folders at startup
    Public Sub InitializeFiles()
        ' Make sure folder exists
        If Not Directory.Exists(TextFolder) Then
            Directory.CreateDirectory(TextFolder)
        End If

        EnsureFile(PatientsFile, "")
        EnsureFile(PrescriptionFile, "")
        EnsureFile(ReceiptFile, "")
        EnsureFile(ScheduleFile, "")
        EnsureFile(VitaminsFile, "")
    End Sub

    ' Creates file if missing, with default content if provided
    Private Sub EnsureFile(filePath As String, defaultContent As String)
        If Not File.Exists(filePath) Then
            File.WriteAllText(filePath, defaultContent)
        End If
    End Sub
End Module

