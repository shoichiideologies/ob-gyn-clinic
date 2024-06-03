Imports System.Data.SqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class AddVitamins
    Dim ReusableMethods As New UniversalMethods
    Dim filePathVitamins As String = "C:\Users\ACER\OneDrive - Tarlac State University\Desktop\Angelo Miranda\OB-GYN Clinic\Vitamins.txt"
    Private WithEvents ltbVitamins As New ListBox()

    Private Sub UpdateStockQuantity(vitaminName As String, additionalQuantity As Integer)
        Dim lines() As String = File.ReadAllLines(filePathVitamins)

        For i As Integer = 0 To lines.Length - 1
            Dim parts() As String = lines(i).Split(","c)

            If parts.Length >= 5 AndAlso parts(1) = vitaminName Then
                Dim currentQuantity As Integer = 0
                If Integer.TryParse(parts(4), currentQuantity) Then
                    Dim newQuantity As Integer = currentQuantity + additionalQuantity
                    parts(4) = newQuantity.ToString()
                    lines(i) = String.Join(",", parts)
                    File.WriteAllLines(filePathVitamins, lines)
                    MessageBox.Show("You have successfully added a Vitamin Stocks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit For

                Else
                    MessageBox.Show("Invalid quantity format in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
            End If
        Next
    End Sub

    Private Sub btnAddVitamin_Click(sender As Object, e As EventArgs) Handles btnAddVitamin.Click
        If gpbAddStocks.Enabled Then
            Dim stocks As Integer
            If Not String.IsNullOrEmpty(txbStocksScientificName.Text) OrElse Not String.IsNullOrEmpty(txbStocksQuantity.Text) Then
                If Integer.TryParse(txbStocksQuantity.Text, stocks) Then
                    Dim vitamin As String = txbStocksScientificName.Text
                    Dim vitaminStocks As Integer = ReusableMethods.RetrieveData(4, vitamin, filePathVitamins, 1)
                    UpdateStockQuantity(vitamin, stocks)
                Else
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf grbDrugDetails.Enabled Then
            Dim vitamin As New Vitamins(cbbAppropriateTrimester.Text, cbbVitaminType.Text, txbManufactureName.Text, txbStocksScientificName.Text, txbPricePerPiece.Text, txbQuantity.Text)
            Dim patientInfo As String = $"{vitamin.Vitamin1},{vitamin.ManufactureName1},{vitamin.ScientificName1},{vitamin.PricePerPiece1},{vitamin.Quantity1}"

            Using writer As New StreamWriter(filePathVitamins, True)
                writer.WriteLine(patientInfo)
                MessageBox.Show("You have successfully added a Vitamin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Using
        End If
    End Sub

    Private Sub ltbVitamins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbVitamins.SelectedIndexChanged
        If ltbVitamins.SelectedIndex <> -1 Then
            txbStocksScientificName.Text = ltbVitamins.SelectedItem.ToString()
            ltbVitamins.Visible = False
            ltbVitamins.Focus()
            txbStocksScientificName.Focus()
            txbStocksScientificName.SelectAll()
        End If
    End Sub

    Private Sub txbScientificName_TextChanged(sender As Object, e As EventArgs) Handles txbStocksScientificName.TextChanged
        Dim searchText As String = txbStocksScientificName.Text.ToLower()

        Dim searchResults As New List(Of String)()

        If searchText.Length > 0 Then
            ltbVitamins.Items.Clear()
            Dim vitaminNames As List(Of String) = VitaminsListBox()

            For Each item As String In vitaminNames
                If item.ToLower().Contains(searchText) Then
                    searchResults.Add(item)
                End If
            Next

            ltbVitamins.Items.AddRange(searchResults.ToArray())
            ltbVitamins.Visible = searchResults.Count > 0
        Else
            ltbVitamins.Items.Clear()
            ltbVitamins.Visible = False
        End If

        AdjustListBoxHeight(ltbVitamins)
        ltbVitamins.Visible = ltbVitamins.Items.Count > 0
    End Sub

    Private Function VitaminsListBox() As List(Of String)
        Dim vitaminNames As New List(Of String)()

        If File.Exists(filePathVitamins) Then
            Using reader As New StreamReader(filePathVitamins)
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

    Private Sub AdjustListBoxHeight(listBox As ListBox)
        Dim itemHeight As Integer = listBox.ItemHeight
        Dim visibleItems As Integer = Math.Min(listBox.Items.Count, 2) ' Limit to 5 visible items
        Dim listBoxHeight As Integer = visibleItems * itemHeight
        listBox.Height = listBoxHeight
    End Sub

    Private Sub AddVitamins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpbAddStocks.Controls.Add(ltbVitamins)
        ltbVitamins.Visible = False
        ltbVitamins.BringToFront()
        AddHandler ltbVitamins.SelectedIndexChanged, AddressOf ltbVitamins_SelectedIndexChanged
        AddHandler txbStocksScientificName.TextChanged, AddressOf txbScientificName_TextChanged
        Dim listBoxX As Integer = txbStocksScientificName.Left
        Dim listBoxY As Integer = txbStocksScientificName.Bottom
        Dim listBoxWidth As Integer = txbStocksScientificName.Width
        ltbVitamins.Location = New Point(listBoxX, listBoxY)
        ltbVitamins.Width = listBoxWidth
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        If ReusableMethods.IsNullOrEmpty(txbStocksScientificName.Text) Then

            If SearchName(txbStocksScientificName.Text) Then

            Else
                lblError.Text = "Unregistered Patient"
            End If
        Else
            lblError.Text = "*Enter a Patient"
        End If
    End Sub

    Private Function SearchName(ByVal name As String) As Boolean
        Dim vitaminsList As List(Of String) = ReusableMethods.VitaminsListBox(filePathVitamins)

        For i As Integer = 0 To vitaminsList.Count - 1
            Dim currentItem As String = vitaminsList(i)
            If currentItem.ToLower().Equals(name.ToLower()) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub grbDrugDetails_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grbDrugDetails.MouseDoubleClick
        EnableGroupBox(grbDrugDetails)
        DisableGroupBox(gpbAddStocks)
        ClearComponents(gpbAddStocks)
    End Sub

    Private Sub gpbAddStocks_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles gpbAddStocks.MouseDoubleClick
        EnableGroupBox(gpbAddStocks)
        DisableGroupBox(grbDrugDetails)
        ClearComponents(grbDrugDetails)
    End Sub

    Private Sub EnableGroupBox(groupBox As GroupBox)
        For Each control As Control In groupBox.Controls
            control.Enabled = True
        Next
    End Sub

    Private Sub DisableGroupBox(groupBox As GroupBox)
        For Each control As Control In groupBox.Controls
            control.Enabled = False
        Next
    End Sub

    Private Sub ClearComponents(groupBox As GroupBox)
        For Each control As Control In groupBox.Controls
            If TypeOf control Is Guna2TextBox Then
                DirectCast(control, Guna2TextBox).Clear()
            ElseIf TypeOf control Is ComboBox Then
                DirectCast(control, ComboBox).SelectedIndex = -1
            End If
        Next
    End Sub

End Class