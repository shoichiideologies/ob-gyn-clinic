<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Appointments
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPatients = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Patients = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlSetAppointment = New System.Windows.Forms.Panel()
        Me.dtpNextAppointment = New System.Windows.Forms.DateTimePicker()
        Me.lblReminder = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txbLastMenstrualCycle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbTrimester = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbPatientName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbScheduledOB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txbLastCheckUp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSchedule = New System.Windows.Forms.Panel()
        Me.dgvPatientsAppointments = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSetAppointment.SuspendLayout()
        Me.pnlSchedule.SuspendLayout()
        CType(Me.dgvPatientsAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPatients
        '
        Me.dgvPatients.AllowUserToAddRows = False
        Me.dgvPatients.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "-"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPatients.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "-"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatients.ColumnHeadersHeight = 27
        Me.dgvPatients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Patients})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatients.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPatients.GridColor = System.Drawing.Color.LightGray
        Me.dgvPatients.Location = New System.Drawing.Point(45, 58)
        Me.dgvPatients.MultiSelect = False
        Me.dgvPatients.Name = "dgvPatients"
        Me.dgvPatients.ReadOnly = True
        Me.dgvPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatients.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPatients.RowHeadersVisible = False
        Me.dgvPatients.RowHeadersWidth = 70
        Me.dgvPatients.RowTemplate.Height = 40
        Me.dgvPatients.Size = New System.Drawing.Size(312, 567)
        Me.dgvPatients.TabIndex = 9
        Me.dgvPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatients.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatients.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatients.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.dgvPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvPatients.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPatients.ThemeStyle.HeaderStyle.Height = 27
        Me.dgvPatients.ThemeStyle.ReadOnly = True
        Me.dgvPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPatients.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatients.ThemeStyle.RowsStyle.Height = 40
        Me.dgvPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Patients
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Patients.DefaultCellStyle = DataGridViewCellStyle3
        Me.Patients.FillWeight = 20.0!
        Me.Patients.HeaderText = "Patients"
        Me.Patients.MinimumWidth = 6
        Me.Patients.Name = "Patients"
        Me.Patients.ReadOnly = True
        Me.Patients.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Patients.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Set Appointment"
        '
        'pnlSetAppointment
        '
        Me.pnlSetAppointment.BackColor = System.Drawing.Color.White
        Me.pnlSetAppointment.Controls.Add(Me.dtpNextAppointment)
        Me.pnlSetAppointment.Controls.Add(Me.lblReminder)
        Me.pnlSetAppointment.Controls.Add(Me.Guna2Separator1)
        Me.pnlSetAppointment.Controls.Add(Me.txbLastMenstrualCycle)
        Me.pnlSetAppointment.Controls.Add(Me.txbTrimester)
        Me.pnlSetAppointment.Controls.Add(Me.txbPatientName)
        Me.pnlSetAppointment.Controls.Add(Me.txbScheduledOB)
        Me.pnlSetAppointment.Controls.Add(Me.Label10)
        Me.pnlSetAppointment.Controls.Add(Me.txbLastCheckUp)
        Me.pnlSetAppointment.Controls.Add(Me.btnSchedule)
        Me.pnlSetAppointment.Controls.Add(Me.Label9)
        Me.pnlSetAppointment.Controls.Add(Me.Label14)
        Me.pnlSetAppointment.Controls.Add(Me.Label2)
        Me.pnlSetAppointment.Controls.Add(Me.Label8)
        Me.pnlSetAppointment.Controls.Add(Me.Label3)
        Me.pnlSetAppointment.Controls.Add(Me.Label6)
        Me.pnlSetAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSetAppointment.Location = New System.Drawing.Point(387, 58)
        Me.pnlSetAppointment.Name = "pnlSetAppointment"
        Me.pnlSetAppointment.Size = New System.Drawing.Size(312, 567)
        Me.pnlSetAppointment.TabIndex = 11
        '
        'dtpNextAppointment
        '
        Me.dtpNextAppointment.AllowDrop = True
        Me.dtpNextAppointment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNextAppointment.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpNextAppointment.Location = New System.Drawing.Point(38, 358)
        Me.dtpNextAppointment.Name = "dtpNextAppointment"
        Me.dtpNextAppointment.Size = New System.Drawing.Size(237, 22)
        Me.dtpNextAppointment.TabIndex = 12
        '
        'lblReminder
        '
        Me.lblReminder.AutoSize = True
        Me.lblReminder.ForeColor = System.Drawing.Color.Red
        Me.lblReminder.Location = New System.Drawing.Point(35, 449)
        Me.lblReminder.Name = "lblReminder"
        Me.lblReminder.Size = New System.Drawing.Size(0, 16)
        Me.lblReminder.TabIndex = 31
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(38, 315)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(237, 10)
        Me.Guna2Separator1.TabIndex = 15
        '
        'txbLastMenstrualCycle
        '
        Me.txbLastMenstrualCycle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbLastMenstrualCycle.DefaultText = ""
        Me.txbLastMenstrualCycle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbLastMenstrualCycle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbLastMenstrualCycle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbLastMenstrualCycle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbLastMenstrualCycle.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbLastMenstrualCycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLastMenstrualCycle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbLastMenstrualCycle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbLastMenstrualCycle.Location = New System.Drawing.Point(38, 215)
        Me.txbLastMenstrualCycle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbLastMenstrualCycle.Name = "txbLastMenstrualCycle"
        Me.txbLastMenstrualCycle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbLastMenstrualCycle.PlaceholderText = ""
        Me.txbLastMenstrualCycle.ReadOnly = True
        Me.txbLastMenstrualCycle.SelectedText = ""
        Me.txbLastMenstrualCycle.Size = New System.Drawing.Size(237, 27)
        Me.txbLastMenstrualCycle.TabIndex = 14
        '
        'txbTrimester
        '
        Me.txbTrimester.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbTrimester.DefaultText = ""
        Me.txbTrimester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbTrimester.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbTrimester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbTrimester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbTrimester.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbTrimester.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTrimester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbTrimester.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbTrimester.Location = New System.Drawing.Point(38, 160)
        Me.txbTrimester.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbTrimester.Name = "txbTrimester"
        Me.txbTrimester.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTrimester.PlaceholderText = ""
        Me.txbTrimester.ReadOnly = True
        Me.txbTrimester.SelectedText = ""
        Me.txbTrimester.Size = New System.Drawing.Size(237, 27)
        Me.txbTrimester.TabIndex = 13
        '
        'txbPatientName
        '
        Me.txbPatientName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbPatientName.DefaultText = ""
        Me.txbPatientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbPatientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbPatientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPatientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPatientName.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPatientName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbPatientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbPatientName.Location = New System.Drawing.Point(38, 104)
        Me.txbPatientName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbPatientName.Name = "txbPatientName"
        Me.txbPatientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbPatientName.PlaceholderText = ""
        Me.txbPatientName.ReadOnly = True
        Me.txbPatientName.SelectedText = ""
        Me.txbPatientName.Size = New System.Drawing.Size(237, 27)
        Me.txbPatientName.TabIndex = 12
        '
        'txbScheduledOB
        '
        Me.txbScheduledOB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbScheduledOB.DefaultText = ""
        Me.txbScheduledOB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbScheduledOB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbScheduledOB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbScheduledOB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbScheduledOB.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbScheduledOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbScheduledOB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbScheduledOB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbScheduledOB.Location = New System.Drawing.Point(38, 418)
        Me.txbScheduledOB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbScheduledOB.Name = "txbScheduledOB"
        Me.txbScheduledOB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbScheduledOB.PlaceholderText = ""
        Me.txbScheduledOB.SelectedText = ""
        Me.txbScheduledOB.Size = New System.Drawing.Size(237, 27)
        Me.txbScheduledOB.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Scheduled OB"
        '
        'txbLastCheckUp
        '
        Me.txbLastCheckUp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbLastCheckUp.DefaultText = ""
        Me.txbLastCheckUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbLastCheckUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbLastCheckUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbLastCheckUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbLastCheckUp.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbLastCheckUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLastCheckUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbLastCheckUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbLastCheckUp.Location = New System.Drawing.Point(38, 272)
        Me.txbLastCheckUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbLastCheckUp.Name = "txbLastCheckUp"
        Me.txbLastCheckUp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbLastCheckUp.PlaceholderText = ""
        Me.txbLastCheckUp.ReadOnly = True
        Me.txbLastCheckUp.SelectedText = ""
        Me.txbLastCheckUp.Size = New System.Drawing.Size(237, 27)
        Me.txbLastCheckUp.TabIndex = 8
        '
        'btnSchedule
        '
        Me.btnSchedule.BackColor = System.Drawing.Color.RosyBrown
        Me.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.btnSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown
        Me.btnSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.ForeColor = System.Drawing.Color.White
        Me.btnSchedule.Location = New System.Drawing.Point(38, 502)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(237, 33)
        Me.btnSchedule.TabIndex = 6
        Me.btnSchedule.Text = "Schedule"
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Last Checkup"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 338)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Next Appointment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Trimester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Last Menstrual Cycle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scheduled Appointments"
        '
        'pnlSchedule
        '
        Me.pnlSchedule.BackColor = System.Drawing.Color.White
        Me.pnlSchedule.Controls.Add(Me.dgvPatientsAppointments)
        Me.pnlSchedule.Controls.Add(Me.Label1)
        Me.pnlSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSchedule.Location = New System.Drawing.Point(728, 58)
        Me.pnlSchedule.Name = "pnlSchedule"
        Me.pnlSchedule.Size = New System.Drawing.Size(342, 567)
        Me.pnlSchedule.TabIndex = 3
        '
        'dgvPatientsAppointments
        '
        Me.dgvPatientsAppointments.AllowUserToAddRows = False
        Me.dgvPatientsAppointments.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.NullValue = "-"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPatientsAppointments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPatientsAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.NullValue = "-"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientsAppointments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPatientsAppointments.ColumnHeadersHeight = 27
        Me.dgvPatientsAppointments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientName, Me.AppointmentDate})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatientsAppointments.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPatientsAppointments.GridColor = System.Drawing.Color.LightGray
        Me.dgvPatientsAppointments.Location = New System.Drawing.Point(36, 72)
        Me.dgvPatientsAppointments.MultiSelect = False
        Me.dgvPatientsAppointments.Name = "dgvPatientsAppointments"
        Me.dgvPatientsAppointments.ReadOnly = True
        Me.dgvPatientsAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientsAppointments.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPatientsAppointments.RowHeadersVisible = False
        Me.dgvPatientsAppointments.RowHeadersWidth = 15
        Me.dgvPatientsAppointments.RowTemplate.Height = 27
        Me.dgvPatientsAppointments.Size = New System.Drawing.Size(270, 471)
        Me.dgvPatientsAppointments.TabIndex = 4
        Me.dgvPatientsAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsAppointments.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientsAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatientsAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPatientsAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatientsAppointments.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsAppointments.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.dgvPatientsAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvPatientsAppointments.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientsAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPatientsAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPatientsAppointments.ThemeStyle.HeaderStyle.Height = 27
        Me.dgvPatientsAppointments.ThemeStyle.ReadOnly = True
        Me.dgvPatientsAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPatientsAppointments.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientsAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatientsAppointments.ThemeStyle.RowsStyle.Height = 27
        Me.dgvPatientsAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPatientsAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "Patient"
        Me.PatientName.MinimumWidth = 6
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'AppointmentDate
        '
        Me.AppointmentDate.HeaderText = "Date"
        Me.AppointmentDate.MinimumWidth = 6
        Me.AppointmentDate.Name = "AppointmentDate"
        Me.AppointmentDate.ReadOnly = True
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.pnlSetAppointment)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgvPatients)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.pnlSchedule)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1117, 667)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1117, 667)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'UC_Appointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Name = "UC_Appointments"
        Me.Size = New System.Drawing.Size(1117, 667)
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSetAppointment.ResumeLayout(False)
        Me.pnlSetAppointment.PerformLayout()
        Me.pnlSchedule.ResumeLayout(False)
        Me.pnlSchedule.PerformLayout()
        CType(Me.dgvPatientsAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPatients As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Patients As DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlSetAppointment As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSchedule As Panel
    Friend WithEvents txbLastCheckUp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbScheduledOB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSchedule As Button
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents dgvPatientsAppointments As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDate As DataGridViewTextBoxColumn
    Friend WithEvents txbLastMenstrualCycle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbTrimester As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbPatientName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblReminder As Label
    Friend WithEvents dtpNextAppointment As DateTimePicker
End Class
