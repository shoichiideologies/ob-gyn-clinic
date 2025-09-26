<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Patients
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.addPatient = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.dgvPatientsList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstBaby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrefferedDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Relationship = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastMenstrualCycle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBDoctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialCheckUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbDoctors = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.dgvPatientsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addPatient
        '
        Me.addPatient.BackColor = System.Drawing.Color.Transparent
        Me.addPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addPatient.FillColor = System.Drawing.Color.LightCoral
        Me.addPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPatient.ForeColor = System.Drawing.Color.White
        Me.addPatient.Location = New System.Drawing.Point(94, 524)
        Me.addPatient.Name = "addPatient"
        Me.addPatient.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addPatient.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.addPatient.Size = New System.Drawing.Size(72, 70)
        Me.addPatient.TabIndex = 2
        Me.addPatient.Text = "+"
        '
        'dgvPatientsList
        '
        Me.dgvPatientsList.AllowUserToAddRows = False
        Me.dgvPatientsList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "-"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPatientsList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvPatientsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "-"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatientsList.ColumnHeadersHeight = 40
        Me.dgvPatientsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientID, Me.FirstName, Me.LastName, Me.Age, Me.CivilStatus, Me.Birthdate, Me.Address, Me.FirstBaby, Me.PrefferedDelivery, Me.CompanyFirstName, Me.CompanyLastName, Me.Relationship, Me.ContactNumber, Me.LastMenstrualCycle, Me.OBDoctor, Me.InitialCheckUp})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatientsList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPatientsList.GridColor = System.Drawing.Color.LightGray
        Me.dgvPatientsList.Location = New System.Drawing.Point(94, 85)
        Me.dgvPatientsList.MultiSelect = False
        Me.dgvPatientsList.Name = "dgvPatientsList"
        Me.dgvPatientsList.ReadOnly = True
        Me.dgvPatientsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientsList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPatientsList.RowHeadersVisible = False
        Me.dgvPatientsList.RowHeadersWidth = 70
        Me.dgvPatientsList.RowTemplate.Height = 40
        Me.dgvPatientsList.Size = New System.Drawing.Size(934, 413)
        Me.dgvPatientsList.TabIndex = 3
        Me.dgvPatientsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsList.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatientsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPatientsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatientsList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsList.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.dgvPatientsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvPatientsList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPatientsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPatientsList.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvPatientsList.ThemeStyle.ReadOnly = True
        Me.dgvPatientsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPatientsList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPatientsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPatientsList.ThemeStyle.RowsStyle.Height = 40
        Me.dgvPatientsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPatientsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PatientID
        '
        Me.PatientID.HeaderText = "Patient ID"
        Me.PatientID.MinimumWidth = 6
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        Me.PatientID.Width = 85
        '
        'FirstName
        '
        Me.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FirstName.FillWeight = 20.0!
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.MinimumWidth = 6
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FirstName.Width = 92
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.MinimumWidth = 6
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Width = 92
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.MinimumWidth = 6
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Width = 60
        '
        'CivilStatus
        '
        Me.CivilStatus.HeaderText = "Civil Status"
        Me.CivilStatus.MinimumWidth = 6
        Me.CivilStatus.Name = "CivilStatus"
        Me.CivilStatus.ReadOnly = True
        Me.CivilStatus.Width = 92
        '
        'Birthdate
        '
        Me.Birthdate.HeaderText = "Birthdate"
        Me.Birthdate.MinimumWidth = 6
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.ReadOnly = True
        Me.Birthdate.Width = 88
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.MinimumWidth = 6
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 86
        '
        'FirstBaby
        '
        Me.FirstBaby.HeaderText = "First Baby"
        Me.FirstBaby.MinimumWidth = 6
        Me.FirstBaby.Name = "FirstBaby"
        Me.FirstBaby.ReadOnly = True
        Me.FirstBaby.Width = 88
        '
        'PrefferedDelivery
        '
        Me.PrefferedDelivery.HeaderText = "Preffered Delivery"
        Me.PrefferedDelivery.MinimumWidth = 6
        Me.PrefferedDelivery.Name = "PrefferedDelivery"
        Me.PrefferedDelivery.ReadOnly = True
        Me.PrefferedDelivery.Width = 131
        '
        'CompanyFirstName
        '
        Me.CompanyFirstName.HeaderText = "Company First Name"
        Me.CompanyFirstName.MinimumWidth = 6
        Me.CompanyFirstName.Name = "CompanyFirstName"
        Me.CompanyFirstName.ReadOnly = True
        Me.CompanyFirstName.Width = 114
        '
        'CompanyLastName
        '
        Me.CompanyLastName.HeaderText = "Company Last Name"
        Me.CompanyLastName.MinimumWidth = 6
        Me.CompanyLastName.Name = "CompanyLastName"
        Me.CompanyLastName.ReadOnly = True
        Me.CompanyLastName.Width = 114
        '
        'Relationship
        '
        Me.Relationship.HeaderText = "Relationship"
        Me.Relationship.MinimumWidth = 6
        Me.Relationship.Name = "Relationship"
        Me.Relationship.ReadOnly = True
        Me.Relationship.Width = 110
        '
        'ContactNumber
        '
        Me.ContactNumber.HeaderText = "Contact Number"
        Me.ContactNumber.MinimumWidth = 6
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.ReadOnly = True
        Me.ContactNumber.Width = 120
        '
        'LastMenstrualCycle
        '
        Me.LastMenstrualCycle.HeaderText = "Last Menstrual Cycle"
        Me.LastMenstrualCycle.MinimumWidth = 6
        Me.LastMenstrualCycle.Name = "LastMenstrualCycle"
        Me.LastMenstrualCycle.ReadOnly = True
        Me.LastMenstrualCycle.Width = 145
        '
        'OBDoctor
        '
        Me.OBDoctor.HeaderText = "OB Doctor"
        Me.OBDoctor.MinimumWidth = 6
        Me.OBDoctor.Name = "OBDoctor"
        Me.OBDoctor.ReadOnly = True
        Me.OBDoctor.Width = 90
        '
        'InitialCheckUp
        '
        Me.InitialCheckUp.HeaderText = "Initial Check-Up"
        Me.InitialCheckUp.MinimumWidth = 6
        Me.InitialCheckUp.Name = "InitialCheckUp"
        Me.InitialCheckUp.ReadOnly = True
        Me.InitialCheckUp.Width = 118
        '
        'cmbDoctors
        '
        Me.cmbDoctors.AutoRoundedCorners = True
        Me.cmbDoctors.BackColor = System.Drawing.Color.Transparent
        Me.cmbDoctors.BorderRadius = 17
        Me.cmbDoctors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoctors.FocusedColor = System.Drawing.Color.Gainsboro
        Me.cmbDoctors.FocusedState.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmbDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctors.ForeColor = System.Drawing.Color.Black
        Me.cmbDoctors.ItemHeight = 30
        Me.cmbDoctors.Location = New System.Drawing.Point(753, 27)
        Me.cmbDoctors.Name = "cmbDoctors"
        Me.cmbDoctors.Size = New System.Drawing.Size(275, 36)
        Me.cmbDoctors.TabIndex = 4
        '
        'UC_Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.Controls.Add(Me.cmbDoctors)
        Me.Controls.Add(Me.dgvPatientsList)
        Me.Controls.Add(Me.addPatient)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UC_Patients"
        Me.Size = New System.Drawing.Size(1118, 661)
        CType(Me.dgvPatientsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addPatient As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GestationalAgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VitaminsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvPatientsList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents CivilStatus As DataGridViewTextBoxColumn
    Friend WithEvents Birthdate As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents FirstBaby As DataGridViewTextBoxColumn
    Friend WithEvents PrefferedDelivery As DataGridViewTextBoxColumn
    Friend WithEvents CompanyFirstName As DataGridViewTextBoxColumn
    Friend WithEvents CompanyLastName As DataGridViewTextBoxColumn
    Friend WithEvents Relationship As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents LastMenstrualCycle As DataGridViewTextBoxColumn
    Friend WithEvents OBDoctor As DataGridViewTextBoxColumn
    Friend WithEvents InitialCheckUp As DataGridViewTextBoxColumn
    Friend WithEvents cmbDoctors As Guna.UI2.WinForms.Guna2ComboBox
End Class
