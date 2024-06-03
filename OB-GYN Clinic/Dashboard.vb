Imports Guna.UI2.WinForms

Public Class Dashboard

    Private Sub AddUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        PanelContainer.Controls.Clear()
        PanelContainer.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub AddUserControlTopPanel(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        TopPanel.Controls.Clear()
        TopPanel.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        btnShow.Visible = False
        btnHide.Visible = True
        Guna2Panel2.Visible = True
        Guna2Panel2.Width = 240
        Guna2Transition1.ShowSync(Guna2Panel2)
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Guna2Panel2.Visible = False
        btnHide.Visible = False
        btnShow.Visible = True
        Guna2Panel2.Width = 53
        Guna2Transition1.ShowSync(Guna2Panel2)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ucd As New UC_Start()
        AddUserControl(ucd)

        lblTitle.Text = ""
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim results As DialogResult = MessageBox.Show("Are you sure you wish to logout?", "Logging out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If results = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim ucs As New UC_Summary()
        AddUserControl(ucs)

        lblTitle.Text = "Summary"
    End Sub

    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Dim ucp As New UC_Patients()
        AddUserControl(ucp)

        lblTitle.Text = "Patients"
    End Sub

    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Dim uca As New UC_Appointments()
        AddUserControl(uca)

        lblTitle.Text = "Appointments"
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Dim uct As New UC_Transactions()
        AddUserControl(uct)

        lblTitle.Text = "Transaction"
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim uci As New UC_Inventory
        AddUserControl(uci)

        lblTitle.Text = "Inventory"
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim uci As New UC_Start
        AddUserControl(uci)

        lblTitle.Text = ""
    End Sub
End Class