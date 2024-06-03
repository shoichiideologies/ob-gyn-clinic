Imports System.IO
Imports OB_GYN_Clinic.UC_Summary

Public Class UC_Summary
    Dim ReusableMethod As New UniversalMethods()
    Dim filePathVitamins As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Vitamins.txt"
    Dim filePathReceipt As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Receipt.txt"
    Dim filePathPatient As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Patients.txt"
    Dim filePathSchedule As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Schedule.txt"

    Structure Schedule
        Dim Day As Date
        Dim Name As String
    End Structure

    Private Sub UC_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PatientCount()
        DoctorOfTheDay()
        DateToday()

        Dim result As Tuple(Of String, Integer) = InventoryStocks(filePathVitamins)
        If result IsNot Nothing Then
            lblStocks.Text = result.Item1
            lblVitaminName.Text = result.Item2.ToString()
            'CenterControlInPanel(lblVitaminName, PanelStocks)
            CenterControlInPanel(lblStocks, PanelStocks)
        Else
            lblStocks.Text = "Not found"
        End If

        Dim schedules As List(Of Schedule) = ReusableMethod.AppointmentListBox(filePathSchedule)
        PopulateScheduleListView(schedules)

        Dim birthdays As List(Of Schedule) = ReusableMethod.BirthdayListBox(filePathPatient)
        PopulateBirthdayListView(birthdays)

        Dim outOfStockVitamins As List(Of String) = ReusableMethod.VitaminsListBox(filePathVitamins)
        PopulateOutOfStockListView(filePathVitamins)
    End Sub

    Public Function InventoryStocks(ByVal filepath As String) As Tuple(Of String, Integer)
        Dim lowestQuantity As Integer = Integer.MaxValue
        Dim vitaminNameWithLowestQuantity As String = ""

        If File.Exists(filepath) Then
            Dim lines As String() = File.ReadAllLines(filepath)

            ' Process each line
            For Each line As String In lines
                Dim parts As String() = line.Split(","c)

                ' Ensure the line has enough parts and the last part is a valid integer
                If parts.Length >= 5 AndAlso Integer.TryParse(parts(4).Trim(), Nothing) Then
                    Dim quantity As Integer
                    If Integer.TryParse(parts(4).Trim(), quantity) Then
                        ' Check if the current quantity is lower than the current lowest
                        If quantity < lowestQuantity Then
                            lowestQuantity = quantity
                            ' Update the vitamin name with lowest quantity
                            vitaminNameWithLowestQuantity = parts(1).Trim()
                        End If
                    End If
                End If
            Next
        Else
            MessageBox.Show("File not found: " & filepath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' If no valid quantity found, return -1 or any default value as per requirement
        If lowestQuantity = Integer.MaxValue Then
            lowestQuantity = -1 ' or any other default value
        End If

        Return New Tuple(Of String, Integer)(vitaminNameWithLowestQuantity, lowestQuantity)
    End Function

    Public Sub DateToday()
        Dim todayDate As Date = Date.Today

        Dim weekdayName As String = todayDate.ToString("dddd")
        Dim displayText As String = todayDate.ToString("MMMM dd, yyyy") & Environment.NewLine & " (" & weekdayName & ")"
        lblDateToday.Text = displayText
        CenterControlInPanel(lblDateToday, PanelTodayDate)
    End Sub

    Public Sub DoctorOfTheDay()
        Dim today As String = DateTime.Today
        lblDoctorToday.Text = ReusableMethod.GetDoctor(today)
        CenterControlInPanel(lblDoctorToday, PanelDoctorOfTheDay)
    End Sub

    Public Sub PatientCount()
        If ReusableMethod.PatientsListBox(filePathPatient).Count > 0 Then
            lblFirst.Text = ReusableMethod.PatientsListBox(filePathPatient).Count
            CenterControlInPanel(lblFirst, PanelPatientCount)
        End If
    End Sub

    Private Sub PopulateScheduleListView(schedules As List(Of Schedule))
        lsvSchedules.Items.Clear()
        Dim groupedSchedules = schedules.GroupBy(Function(s) s.Day)

        For Each group In groupedSchedules
            Dim groupHeader As New ListViewGroup(group.Key.ToString("MM-dd-dddd"), HorizontalAlignment.Left)
            lsvSchedules.Groups.Add(groupHeader)

            For Each schedule In group
                Dim item As New ListViewItem(schedule.Name)
                item.Group = groupHeader
                lsvSchedules.Items.Add(item)
            Next
        Next
    End Sub

    Public Sub PopulateBirthdayListView(birthdays As List(Of Schedule))
        lsvOutOfStocks.Items.Clear()
        Dim groupedBirthdays = birthdays.GroupBy(Function(s) s.Day)

        For Each group In groupedBirthdays
            Dim groupHeader As New ListViewGroup(group.Key.ToString("MMMM-dd"), HorizontalAlignment.Left)
            lsvOutOfStocks.Groups.Add(groupHeader)

            For Each schedule In group
                Dim item As New ListViewItem(schedule.Name)
                item.Group = groupHeader
                lsvOutOfStocks.Items.Add(item)
            Next
        Next
    End Sub

    Public Sub PopulateOutOfStockListView(ByVal filepath As String)
        lsvOutOfStocks.Items.Clear()
        lsvOutOfStocks.Groups.Clear()

        ' Dictionary to store dynamically created groups
        Dim groups As New SortedDictionary(Of Integer, ListViewGroup)

        If File.Exists(filepath) Then
            Dim lines As String() = File.ReadAllLines(filepath)

            For Each line As String In lines
                Dim parts As String() = line.Split(","c)

                If parts.Length >= 5 AndAlso Integer.TryParse(parts(4).Trim(), Nothing) Then
                    Dim quantity As Integer
                    If Integer.TryParse(parts(4).Trim(), quantity) Then
                        Dim vitaminName As String = parts(0).Trim() & " | " & parts(1).Trim()
                        Dim item As New ListViewItem(vitaminName)

                        ' Determine the group range for the current quantity
                        Dim lowerBound As Integer
                        If quantity < 500 Then
                            lowerBound = 0
                        Else
                            lowerBound = (quantity \ 500) * 500
                        End If

                        ' Check if the group already exists, if not create it
                        If Not groups.ContainsKey(lowerBound) Then
                            Dim upperBound As Integer = lowerBound + 499
                            Dim groupName As String = If(lowerBound = 0, "Vitamins < 500", $"Vitamins {lowerBound} - {upperBound}")
                            Dim group As New ListViewGroup(groupName, HorizontalAlignment.Left)
                            groups(lowerBound) = group
                        End If

                        ' Assign the item to the appropriate group
                        item.Group = groups(lowerBound)
                        lsvOutOfStocks.Items.Add(item)
                    End If
                End If
            Next

            ' Add the groups to the ListView in sorted order
            For Each group In groups.Values
                lsvOutOfStocks.Groups.Add(group)
            Next
        Else
            MessageBox.Show("File not found: " & filepath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CenterControlInPanel(control As Control, panel As Panel)
        ' Calculate the center coordinates of the panel
        Dim panelCenterX As Integer = panel.Width \ 2
        Dim panelCenterY As Integer = panel.Height \ 2

        ' Adjust the position of the control to be centered in the panel
        control.Left = panelCenterX - (control.Width \ 2)
        control.Top = panelCenterY - (control.Height \ 3)
    End Sub

End Class
