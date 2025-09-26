<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.gpbAcompany = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txbContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txbComponyLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbComponyFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbRelationship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txbAddPatient = New Guna.UI2.WinForms.Guna2Button()
        Me.grpPersonalInformation = New System.Windows.Forms.GroupBox()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txbPreferredDelivery = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txbPatientLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbPatientFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbCivilStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbFirstBaby = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbOBDoctors = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpLastMenstrualCycle = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gpbAcompany.SuspendLayout()
        Me.grpPersonalInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.gpbAcompany)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.txbAddPatient)
        Me.Panel1.Controls.Add(Me.grpPersonalInformation)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 710)
        Me.Panel1.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderThickness = 1
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(672, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 39
        '
        'gpbAcompany
        '
        Me.gpbAcompany.Controls.Add(Me.Label12)
        Me.gpbAcompany.Controls.Add(Me.txbContactNumber)
        Me.gpbAcompany.Controls.Add(Me.Label10)
        Me.gpbAcompany.Controls.Add(Me.Label11)
        Me.gpbAcompany.Controls.Add(Me.txbComponyLastName)
        Me.gpbAcompany.Controls.Add(Me.txbComponyFirstName)
        Me.gpbAcompany.Controls.Add(Me.Label7)
        Me.gpbAcompany.Controls.Add(Me.txbRelationship)
        Me.gpbAcompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAcompany.Location = New System.Drawing.Point(37, 283)
        Me.gpbAcompany.Name = "gpbAcompany"
        Me.gpbAcompany.Size = New System.Drawing.Size(635, 178)
        Me.gpbAcompany.TabIndex = 9
        Me.gpbAcompany.TabStop = False
        Me.gpbAcompany.Text = "Guardian"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(318, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Contact Number"
        '
        'txbContactNumber
        '
        Me.txbContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbContactNumber.DefaultText = ""
        Me.txbContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txbContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbContactNumber.Location = New System.Drawing.Point(321, 114)
        Me.txbContactNumber.Name = "txbContactNumber"
        Me.txbContactNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbContactNumber.PlaceholderText = ""
        Me.txbContactNumber.SelectedText = ""
        Me.txbContactNumber.Size = New System.Drawing.Size(259, 36)
        Me.txbContactNumber.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(318, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "First Name"
        '
        'txbComponyLastName
        '
        Me.txbComponyLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbComponyLastName.DefaultText = ""
        Me.txbComponyLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbComponyLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbComponyLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbComponyLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbComponyLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbComponyLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbComponyLastName.ForeColor = System.Drawing.Color.Black
        Me.txbComponyLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbComponyLastName.Location = New System.Drawing.Point(321, 56)
        Me.txbComponyLastName.Name = "txbComponyLastName"
        Me.txbComponyLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbComponyLastName.PlaceholderText = ""
        Me.txbComponyLastName.SelectedText = ""
        Me.txbComponyLastName.Size = New System.Drawing.Size(258, 36)
        Me.txbComponyLastName.TabIndex = 11
        '
        'txbComponyFirstName
        '
        Me.txbComponyFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbComponyFirstName.DefaultText = ""
        Me.txbComponyFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbComponyFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbComponyFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbComponyFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbComponyFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbComponyFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbComponyFirstName.ForeColor = System.Drawing.Color.Black
        Me.txbComponyFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbComponyFirstName.Location = New System.Drawing.Point(56, 56)
        Me.txbComponyFirstName.Name = "txbComponyFirstName"
        Me.txbComponyFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbComponyFirstName.PlaceholderText = ""
        Me.txbComponyFirstName.SelectedText = ""
        Me.txbComponyFirstName.Size = New System.Drawing.Size(259, 36)
        Me.txbComponyFirstName.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Relationship"
        '
        'txbRelationship
        '
        Me.txbRelationship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbRelationship.DefaultText = ""
        Me.txbRelationship.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbRelationship.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbRelationship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbRelationship.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbRelationship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.txbRelationship.ForeColor = System.Drawing.Color.Black
        Me.txbRelationship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbRelationship.Location = New System.Drawing.Point(56, 114)
        Me.txbRelationship.Name = "txbRelationship"
        Me.txbRelationship.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbRelationship.PlaceholderText = ""
        Me.txbRelationship.SelectedText = ""
        Me.txbRelationship.Size = New System.Drawing.Size(259, 36)
        Me.txbRelationship.TabIndex = 12
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(34, 608)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 15)
        Me.lblError.TabIndex = 32
        Me.lblError.Text = "*"
        '
        'txbAddPatient
        '
        Me.txbAddPatient.BackColor = System.Drawing.Color.Transparent
        Me.txbAddPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.txbAddPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.txbAddPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txbAddPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txbAddPatient.FillColor = System.Drawing.Color.RosyBrown
        Me.txbAddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAddPatient.ForeColor = System.Drawing.Color.White
        Me.txbAddPatient.Location = New System.Drawing.Point(232, 647)
        Me.txbAddPatient.Name = "txbAddPatient"
        Me.txbAddPatient.Size = New System.Drawing.Size(262, 36)
        Me.txbAddPatient.TabIndex = 16
        Me.txbAddPatient.Text = "Add Patient"
        '
        'grpPersonalInformation
        '
        Me.grpPersonalInformation.Controls.Add(Me.dtpBirthdate)
        Me.grpPersonalInformation.Controls.Add(Me.txbPreferredDelivery)
        Me.grpPersonalInformation.Controls.Add(Me.lblSurname)
        Me.grpPersonalInformation.Controls.Add(Me.lblFirstName)
        Me.grpPersonalInformation.Controls.Add(Me.txbPatientLastName)
        Me.grpPersonalInformation.Controls.Add(Me.Label1)
        Me.grpPersonalInformation.Controls.Add(Me.Label2)
        Me.grpPersonalInformation.Controls.Add(Me.Label9)
        Me.grpPersonalInformation.Controls.Add(Me.txbAge)
        Me.grpPersonalInformation.Controls.Add(Me.txbPatientFirstName)
        Me.grpPersonalInformation.Controls.Add(Me.txbCivilStatus)
        Me.grpPersonalInformation.Controls.Add(Me.Label3)
        Me.grpPersonalInformation.Controls.Add(Me.Label5)
        Me.grpPersonalInformation.Controls.Add(Me.txbAddress)
        Me.grpPersonalInformation.Controls.Add(Me.Label6)
        Me.grpPersonalInformation.Controls.Add(Me.txbFirstBaby)
        Me.grpPersonalInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonalInformation.Location = New System.Drawing.Point(37, 38)
        Me.grpPersonalInformation.Name = "grpPersonalInformation"
        Me.grpPersonalInformation.Size = New System.Drawing.Size(635, 230)
        Me.grpPersonalInformation.TabIndex = 0
        Me.grpPersonalInformation.TabStop = False
        Me.grpPersonalInformation.Text = "Personal "
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.CalendarMonthBackground = System.Drawing.Color.Snow
        Me.dtpBirthdate.CalendarTitleBackColor = System.Drawing.Color.Pink
        Me.dtpBirthdate.CalendarTrailingForeColor = System.Drawing.Color.MistyRose
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthdate.Location = New System.Drawing.Point(57, 115)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(259, 22)
        Me.dtpBirthdate.TabIndex = 5
        '
        'txbPreferredDelivery
        '
        Me.txbPreferredDelivery.AutoCompleteCustomSource.AddRange(New String() {"Caesarean", "Labor"})
        Me.txbPreferredDelivery.BackColor = System.Drawing.Color.Transparent
        Me.txbPreferredDelivery.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txbPreferredDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txbPreferredDelivery.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPreferredDelivery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPreferredDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.txbPreferredDelivery.ForeColor = System.Drawing.Color.Black
        Me.txbPreferredDelivery.ItemHeight = 30
        Me.txbPreferredDelivery.Items.AddRange(New Object() {"Caesarean", "Labor"})
        Me.txbPreferredDelivery.Location = New System.Drawing.Point(426, 174)
        Me.txbPreferredDelivery.Name = "txbPreferredDelivery"
        Me.txbPreferredDelivery.Size = New System.Drawing.Size(156, 36)
        Me.txbPreferredDelivery.TabIndex = 8
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(319, 35)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(72, 16)
        Me.lblSurname.TabIndex = 34
        Me.lblSurname.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(54, 35)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'txbPatientLastName
        '
        Me.txbPatientLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbPatientLastName.DefaultText = ""
        Me.txbPatientLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbPatientLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbPatientLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPatientLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPatientLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPatientLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPatientLastName.ForeColor = System.Drawing.Color.Black
        Me.txbPatientLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPatientLastName.Location = New System.Drawing.Point(322, 55)
        Me.txbPatientLastName.Name = "txbPatientLastName"
        Me.txbPatientLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbPatientLastName.PlaceholderText = ""
        Me.txbPatientLastName.SelectedText = ""
        Me.txbPatientLastName.Size = New System.Drawing.Size(258, 36)
        Me.txbPatientLastName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(423, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Prefered Delivery "
        '
        'txbAge
        '
        Me.txbAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbAge.DefaultText = ""
        Me.txbAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAge.ForeColor = System.Drawing.Color.Black
        Me.txbAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAge.Location = New System.Drawing.Point(321, 115)
        Me.txbAge.Name = "txbAge"
        Me.txbAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbAge.PlaceholderText = ""
        Me.txbAge.SelectedText = ""
        Me.txbAge.Size = New System.Drawing.Size(97, 36)
        Me.txbAge.TabIndex = 3
        '
        'txbPatientFirstName
        '
        Me.txbPatientFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbPatientFirstName.DefaultText = ""
        Me.txbPatientFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbPatientFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbPatientFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPatientFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPatientFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPatientFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPatientFirstName.ForeColor = System.Drawing.Color.Black
        Me.txbPatientFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPatientFirstName.Location = New System.Drawing.Point(57, 55)
        Me.txbPatientFirstName.Name = "txbPatientFirstName"
        Me.txbPatientFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbPatientFirstName.PlaceholderText = ""
        Me.txbPatientFirstName.SelectedText = ""
        Me.txbPatientFirstName.Size = New System.Drawing.Size(259, 36)
        Me.txbPatientFirstName.TabIndex = 1
        '
        'txbCivilStatus
        '
        Me.txbCivilStatus.BackColor = System.Drawing.Color.Transparent
        Me.txbCivilStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txbCivilStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCivilStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbCivilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.txbCivilStatus.ForeColor = System.Drawing.Color.Black
        Me.txbCivilStatus.ItemHeight = 30
        Me.txbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorce"})
        Me.txbCivilStatus.Location = New System.Drawing.Point(424, 115)
        Me.txbCivilStatus.Name = "txbCivilStatus"
        Me.txbCivilStatus.Size = New System.Drawing.Size(157, 36)
        Me.txbCivilStatus.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Civil Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(319, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "First Baby"
        '
        'txbAddress
        '
        Me.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbAddress.DefaultText = ""
        Me.txbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAddress.ForeColor = System.Drawing.Color.Black
        Me.txbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbAddress.Location = New System.Drawing.Point(57, 174)
        Me.txbAddress.Name = "txbAddress"
        Me.txbAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbAddress.PlaceholderText = ""
        Me.txbAddress.SelectedText = ""
        Me.txbAddress.Size = New System.Drawing.Size(260, 36)
        Me.txbAddress.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Birthdate"
        '
        'txbFirstBaby
        '
        Me.txbFirstBaby.AutoCompleteCustomSource.AddRange(New String() {"Yes", "No"})
        Me.txbFirstBaby.BackColor = System.Drawing.Color.Transparent
        Me.txbFirstBaby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txbFirstBaby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txbFirstBaby.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbFirstBaby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbFirstBaby.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.txbFirstBaby.ForeColor = System.Drawing.Color.Black
        Me.txbFirstBaby.ItemHeight = 30
        Me.txbFirstBaby.Items.AddRange(New Object() {"Yes", "No"})
        Me.txbFirstBaby.Location = New System.Drawing.Point(323, 174)
        Me.txbFirstBaby.Name = "txbFirstBaby"
        Me.txbFirstBaby.Size = New System.Drawing.Size(97, 36)
        Me.txbFirstBaby.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbOBDoctors)
        Me.GroupBox1.Controls.Add(Me.dtpLastMenstrualCycle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 487)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 118)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pregnancy "
        '
        'cmbOBDoctors
        '
        Me.cmbOBDoctors.AutoCompleteCustomSource.AddRange(New String() {"Caesarean", "Labor"})
        Me.cmbOBDoctors.BackColor = System.Drawing.Color.Transparent
        Me.cmbOBDoctors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbOBDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOBDoctors.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbOBDoctors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbOBDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.cmbOBDoctors.ForeColor = System.Drawing.Color.Black
        Me.cmbOBDoctors.ItemHeight = 30
        Me.cmbOBDoctors.Items.AddRange(New Object() {"Dr. Smith", "Dr. Foley", "Dr. Gibbins", "Dr. Manlapaz", "Dr. Hoffman"})
        Me.cmbOBDoctors.Location = New System.Drawing.Point(323, 58)
        Me.cmbOBDoctors.Name = "cmbOBDoctors"
        Me.cmbOBDoctors.Size = New System.Drawing.Size(256, 36)
        Me.cmbOBDoctors.TabIndex = 25
        '
        'dtpLastMenstrualCycle
        '
        Me.dtpLastMenstrualCycle.CalendarMonthBackground = System.Drawing.Color.Snow
        Me.dtpLastMenstrualCycle.CalendarTitleBackColor = System.Drawing.Color.Pink
        Me.dtpLastMenstrualCycle.CalendarTrailingForeColor = System.Drawing.Color.MistyRose
        Me.dtpLastMenstrualCycle.CustomFormat = "##/##/##"
        Me.dtpLastMenstrualCycle.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLastMenstrualCycle.Location = New System.Drawing.Point(56, 58)
        Me.dtpLastMenstrualCycle.Name = "dtpLastMenstrualCycle"
        Me.dtpLastMenstrualCycle.Size = New System.Drawing.Size(261, 22)
        Me.dtpLastMenstrualCycle.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Last Menstrual Cycle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(318, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "OB Doctor"
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(720, 710)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPatient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gpbAcompany.ResumeLayout(False)
        Me.gpbAcompany.PerformLayout()
        Me.grpPersonalInformation.ResumeLayout(False)
        Me.grpPersonalInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txbPatientFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbCivilStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txbFirstBaby As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txbAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txbRelationship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbAddPatient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txbPreferredDelivery As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblError As Label
    Friend WithEvents txbPatientLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents grpPersonalInformation As GroupBox
    Friend WithEvents gpbAcompany As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txbContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txbComponyLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbComponyFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents dtpLastMenstrualCycle As DateTimePicker
    Friend WithEvents cmbOBDoctors As Guna.UI2.WinForms.Guna2ComboBox
End Class
