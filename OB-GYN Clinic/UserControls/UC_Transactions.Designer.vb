<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Transactions
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Transactions))
        Me.pnlRecipient = New System.Windows.Forms.Panel()
        Me.lblSearchNameError = New System.Windows.Forms.Label()
        Me.lblErrorRecipient = New System.Windows.Forms.Label()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.txbTrimester = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbOBDoctor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPrescription = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbSearchName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gpbTypesOfCheckUp = New System.Windows.Forms.GroupBox()
        Me.rbInitial = New System.Windows.Forms.RadioButton()
        Me.rbFollowUp = New System.Windows.Forms.RadioButton()
        Me.gpbPhilHealthMember = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.lblErrorPrescription = New System.Windows.Forms.Label()
        Me.pnlPrescription = New System.Windows.Forms.Panel()
        Me.lblInsufficientPayment = New System.Windows.Forms.Label()
        Me.txbPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnAddToPrescription = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvPrescriptions = New System.Windows.Forms.DataGridView()
        Me.Vitamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyDosage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txbSearchVitamin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.pnlRecipient.SuspendLayout()
        Me.gpbTypesOfCheckUp.SuspendLayout()
        Me.gpbPhilHealthMember.SuspendLayout()
        Me.pnlPrescription.SuspendLayout()
        CType(Me.dgvPrescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRecipient
        '
        Me.pnlRecipient.BackColor = System.Drawing.Color.White
        Me.pnlRecipient.Controls.Add(Me.lblSearchNameError)
        Me.pnlRecipient.Controls.Add(Me.lblErrorRecipient)
        Me.pnlRecipient.Controls.Add(Me.btnSearch)
        Me.pnlRecipient.Controls.Add(Me.txbTrimester)
        Me.pnlRecipient.Controls.Add(Me.txbOBDoctor)
        Me.pnlRecipient.Controls.Add(Me.btnPrescription)
        Me.pnlRecipient.Controls.Add(Me.Label9)
        Me.pnlRecipient.Controls.Add(Me.Label2)
        Me.pnlRecipient.Controls.Add(Me.Label3)
        Me.pnlRecipient.Controls.Add(Me.Label6)
        Me.pnlRecipient.Controls.Add(Me.txbSearchName)
        Me.pnlRecipient.Controls.Add(Me.gpbTypesOfCheckUp)
        Me.pnlRecipient.Controls.Add(Me.gpbPhilHealthMember)
        Me.pnlRecipient.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRecipient.Location = New System.Drawing.Point(49, 57)
        Me.pnlRecipient.Name = "pnlRecipient"
        Me.pnlRecipient.Size = New System.Drawing.Size(312, 567)
        Me.pnlRecipient.TabIndex = 14
        '
        'lblSearchNameError
        '
        Me.lblSearchNameError.AutoSize = True
        Me.lblSearchNameError.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchNameError.ForeColor = System.Drawing.Color.Red
        Me.lblSearchNameError.Location = New System.Drawing.Point(38, 121)
        Me.lblSearchNameError.Name = "lblSearchNameError"
        Me.lblSearchNameError.Size = New System.Drawing.Size(0, 15)
        Me.lblSearchNameError.TabIndex = 39
        '
        'lblErrorRecipient
        '
        Me.lblErrorRecipient.AutoSize = True
        Me.lblErrorRecipient.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorRecipient.ForeColor = System.Drawing.Color.Red
        Me.lblErrorRecipient.Location = New System.Drawing.Point(38, 474)
        Me.lblErrorRecipient.Name = "lblErrorRecipient"
        Me.lblErrorRecipient.Size = New System.Drawing.Size(0, 15)
        Me.lblErrorRecipient.TabIndex = 31
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = Global.OB_GYN_Clinic.My.Resources.Resources.search_FILL0_wght400_GRAD0_opsz24
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnSearch.BorderThickness = 1
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.Transparent
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(243, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 27)
        Me.btnSearch.TabIndex = 29
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
        Me.txbTrimester.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTrimester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbTrimester.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbTrimester.Location = New System.Drawing.Point(38, 214)
        Me.txbTrimester.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbTrimester.Name = "txbTrimester"
        Me.txbTrimester.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTrimester.PlaceholderText = ""
        Me.txbTrimester.ReadOnly = True
        Me.txbTrimester.SelectedText = ""
        Me.txbTrimester.Size = New System.Drawing.Size(237, 27)
        Me.txbTrimester.TabIndex = 28
        '
        'txbOBDoctor
        '
        Me.txbOBDoctor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbOBDoctor.DefaultText = ""
        Me.txbOBDoctor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbOBDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbOBDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbOBDoctor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbOBDoctor.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbOBDoctor.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbOBDoctor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbOBDoctor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbOBDoctor.Location = New System.Drawing.Point(38, 160)
        Me.txbOBDoctor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbOBDoctor.Name = "txbOBDoctor"
        Me.txbOBDoctor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbOBDoctor.PlaceholderText = ""
        Me.txbOBDoctor.ReadOnly = True
        Me.txbOBDoctor.SelectedText = ""
        Me.txbOBDoctor.Size = New System.Drawing.Size(237, 27)
        Me.txbOBDoctor.TabIndex = 27
        '
        'btnPrescription
        '
        Me.btnPrescription.BackColor = System.Drawing.Color.RosyBrown
        Me.btnPrescription.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.btnPrescription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown
        Me.btnPrescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown
        Me.btnPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrescription.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrescription.ForeColor = System.Drawing.Color.White
        Me.btnPrescription.Location = New System.Drawing.Point(38, 503)
        Me.btnPrescription.Name = "btnPrescription"
        Me.btnPrescription.Size = New System.Drawing.Size(237, 33)
        Me.btnPrescription.TabIndex = 6
        Me.btnPrescription.Text = "Prescribe"
        Me.btnPrescription.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Trimester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Recipient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "OB Doctor"
        '
        'txbSearchName
        '
        Me.txbSearchName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbSearchName.DefaultText = ""
        Me.txbSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbSearchName.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbSearchName.Font = New System.Drawing.Font("Century Gothic", 7.8!)
        Me.txbSearchName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbSearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbSearchName.Location = New System.Drawing.Point(38, 90)
        Me.txbSearchName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbSearchName.Name = "txbSearchName"
        Me.txbSearchName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbSearchName.PlaceholderText = ""
        Me.txbSearchName.SelectedText = ""
        Me.txbSearchName.Size = New System.Drawing.Size(237, 27)
        Me.txbSearchName.TabIndex = 16
        '
        'gpbTypesOfCheckUp
        '
        Me.gpbTypesOfCheckUp.Controls.Add(Me.rbInitial)
        Me.gpbTypesOfCheckUp.Controls.Add(Me.rbFollowUp)
        Me.gpbTypesOfCheckUp.Location = New System.Drawing.Point(38, 260)
        Me.gpbTypesOfCheckUp.Name = "gpbTypesOfCheckUp"
        Me.gpbTypesOfCheckUp.Size = New System.Drawing.Size(238, 98)
        Me.gpbTypesOfCheckUp.TabIndex = 37
        Me.gpbTypesOfCheckUp.TabStop = False
        Me.gpbTypesOfCheckUp.Text = "Types pf Check-Up"
        '
        'rbInitial
        '
        Me.rbInitial.AutoSize = True
        Me.rbInitial.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInitial.Location = New System.Drawing.Point(25, 32)
        Me.rbInitial.Name = "rbInitial"
        Me.rbInitial.Size = New System.Drawing.Size(121, 21)
        Me.rbInitial.TabIndex = 36
        Me.rbInitial.TabStop = True
        Me.rbInitial.Text = "Initial Check-up"
        Me.rbInitial.UseVisualStyleBackColor = True
        '
        'rbFollowUp
        '
        Me.rbFollowUp.AutoSize = True
        Me.rbFollowUp.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFollowUp.Location = New System.Drawing.Point(25, 59)
        Me.rbFollowUp.Name = "rbFollowUp"
        Me.rbFollowUp.Size = New System.Drawing.Size(146, 21)
        Me.rbFollowUp.TabIndex = 35
        Me.rbFollowUp.TabStop = True
        Me.rbFollowUp.Text = "Follow Up Check-up"
        Me.rbFollowUp.UseVisualStyleBackColor = True
        '
        'gpbPhilHealthMember
        '
        Me.gpbPhilHealthMember.Controls.Add(Me.rbNo)
        Me.gpbPhilHealthMember.Controls.Add(Me.rbYes)
        Me.gpbPhilHealthMember.Location = New System.Drawing.Point(39, 369)
        Me.gpbPhilHealthMember.Name = "gpbPhilHealthMember"
        Me.gpbPhilHealthMember.Size = New System.Drawing.Size(237, 95)
        Me.gpbPhilHealthMember.TabIndex = 38
        Me.gpbPhilHealthMember.TabStop = False
        Me.gpbPhilHealthMember.Text = "PhilHealth Member"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(24, 56)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(46, 21)
        Me.rbNo.TabIndex = 33
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.Location = New System.Drawing.Point(24, 29)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(49, 21)
        Me.rbYes.TabIndex = 34
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'lblErrorPrescription
        '
        Me.lblErrorPrescription.AutoSize = True
        Me.lblErrorPrescription.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorPrescription.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPrescription.Location = New System.Drawing.Point(32, 144)
        Me.lblErrorPrescription.Name = "lblErrorPrescription"
        Me.lblErrorPrescription.Size = New System.Drawing.Size(0, 15)
        Me.lblErrorPrescription.TabIndex = 30
        '
        'pnlPrescription
        '
        Me.pnlPrescription.BackColor = System.Drawing.Color.White
        Me.pnlPrescription.Controls.Add(Me.lblInsufficientPayment)
        Me.pnlPrescription.Controls.Add(Me.txbPayment)
        Me.pnlPrescription.Controls.Add(Me.btnBill)
        Me.pnlPrescription.Controls.Add(Me.Guna2Separator3)
        Me.pnlPrescription.Controls.Add(Me.lblTotalPrice)
        Me.pnlPrescription.Controls.Add(Me.Guna2Separator4)
        Me.pnlPrescription.Controls.Add(Me.btnAddToPrescription)
        Me.pnlPrescription.Controls.Add(Me.Label8)
        Me.pnlPrescription.Controls.Add(Me.lblErrorPrescription)
        Me.pnlPrescription.Controls.Add(Me.Label7)
        Me.pnlPrescription.Controls.Add(Me.txbQuantity)
        Me.pnlPrescription.Controls.Add(Me.lblTotal)
        Me.pnlPrescription.Controls.Add(Me.dgvPrescriptions)
        Me.pnlPrescription.Controls.Add(Me.txbSearchVitamin)
        Me.pnlPrescription.Controls.Add(Me.Label4)
        Me.pnlPrescription.Enabled = False
        Me.pnlPrescription.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPrescription.Location = New System.Drawing.Point(396, 57)
        Me.pnlPrescription.Name = "pnlPrescription"
        Me.pnlPrescription.Size = New System.Drawing.Size(678, 567)
        Me.pnlPrescription.TabIndex = 15
        '
        'lblInsufficientPayment
        '
        Me.lblInsufficientPayment.AutoSize = True
        Me.lblInsufficientPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblInsufficientPayment.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsufficientPayment.ForeColor = System.Drawing.Color.Red
        Me.lblInsufficientPayment.Location = New System.Drawing.Point(366, 427)
        Me.lblInsufficientPayment.Name = "lblInsufficientPayment"
        Me.lblInsufficientPayment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsufficientPayment.Size = New System.Drawing.Size(0, 17)
        Me.lblInsufficientPayment.TabIndex = 42
        '
        'txbPayment
        '
        Me.txbPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbPayment.DefaultText = ""
        Me.txbPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPayment.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbPayment.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbPayment.Location = New System.Drawing.Point(369, 455)
        Me.txbPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbPayment.Name = "txbPayment"
        Me.txbPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbPayment.PlaceholderText = ""
        Me.txbPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txbPayment.SelectedText = ""
        Me.txbPayment.Size = New System.Drawing.Size(275, 34)
        Me.txbPayment.TabIndex = 35
        '
        'btnBill
        '
        Me.btnBill.BackColor = System.Drawing.Color.RosyBrown
        Me.btnBill.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.btnBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown
        Me.btnBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown
        Me.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBill.ForeColor = System.Drawing.Color.White
        Me.btnBill.Location = New System.Drawing.Point(369, 503)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(275, 33)
        Me.btnBill.TabIndex = 33
        Me.btnBill.Text = "Billing"
        Me.btnBill.UseVisualStyleBackColor = False
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.Location = New System.Drawing.Point(35, 409)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(609, 10)
        Me.Guna2Separator3.TabIndex = 14
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(96, 425)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(0, 17)
        Me.lblTotalPrice.TabIndex = 41
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.Location = New System.Drawing.Point(35, 161)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(609, 10)
        Me.Guna2Separator4.TabIndex = 40
        '
        'btnAddToPrescription
        '
        Me.btnAddToPrescription.BackColor = System.Drawing.Color.RosyBrown
        Me.btnAddToPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToPrescription.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToPrescription.ForeColor = System.Drawing.Color.White
        Me.btnAddToPrescription.Location = New System.Drawing.Point(369, 100)
        Me.btnAddToPrescription.Name = "btnAddToPrescription"
        Me.btnAddToPrescription.Size = New System.Drawing.Size(275, 33)
        Me.btnAddToPrescription.TabIndex = 39
        Me.btnAddToPrescription.Text = "Add"
        Me.btnAddToPrescription.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(248, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Vitamin"
        '
        'txbQuantity
        '
        Me.txbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbQuantity.DefaultText = ""
        Me.txbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbQuantity.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbQuantity.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbQuantity.Location = New System.Drawing.Point(251, 100)
        Me.txbQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbQuantity.Name = "txbQuantity"
        Me.txbQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbQuantity.PlaceholderText = ""
        Me.txbQuantity.SelectedText = ""
        Me.txbQuantity.Size = New System.Drawing.Size(112, 33)
        Me.txbQuantity.TabIndex = 36
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(43, 425)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 17)
        Me.lblTotal.TabIndex = 35
        Me.lblTotal.Text = "Total: "
        '
        'dgvPrescriptions
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        Me.dgvPrescriptions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrescriptions.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrescriptions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrescriptions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Vitamin, Me.Price, Me.Quantity, Me.Total, Me.DailyDosage})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrescriptions.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPrescriptions.GridColor = System.Drawing.Color.LightGray
        Me.dgvPrescriptions.Location = New System.Drawing.Point(35, 177)
        Me.dgvPrescriptions.Name = "dgvPrescriptions"
        Me.dgvPrescriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrescriptions.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPrescriptions.RowHeadersVisible = False
        Me.dgvPrescriptions.RowHeadersWidth = 51
        Me.dgvPrescriptions.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrescriptions.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrescriptions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgvPrescriptions.RowTemplate.Height = 23
        Me.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrescriptions.Size = New System.Drawing.Size(609, 226)
        Me.dgvPrescriptions.TabIndex = 32
        '
        'Vitamin
        '
        Me.Vitamin.HeaderText = "Vitamin"
        Me.Vitamin.MinimumWidth = 6
        Me.Vitamin.Name = "Vitamin"
        Me.Vitamin.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'DailyDosage
        '
        Me.DailyDosage.HeaderText = "Daily Dosage"
        Me.DailyDosage.MinimumWidth = 6
        Me.DailyDosage.Name = "DailyDosage"
        '
        'txbSearchVitamin
        '
        Me.txbSearchVitamin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbSearchVitamin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbSearchVitamin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbSearchVitamin.DefaultText = ""
        Me.txbSearchVitamin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbSearchVitamin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbSearchVitamin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbSearchVitamin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbSearchVitamin.FocusedState.BorderColor = System.Drawing.Color.MistyRose
        Me.txbSearchVitamin.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbSearchVitamin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbSearchVitamin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbSearchVitamin.Location = New System.Drawing.Point(35, 100)
        Me.txbSearchVitamin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbSearchVitamin.Name = "txbSearchVitamin"
        Me.txbSearchVitamin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbSearchVitamin.PlaceholderText = ""
        Me.txbSearchVitamin.SelectedText = ""
        Me.txbSearchVitamin.Size = New System.Drawing.Size(206, 33)
        Me.txbSearchVitamin.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Prescription"
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        '
        'UC_Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.Controls.Add(Me.pnlRecipient)
        Me.Controls.Add(Me.pnlPrescription)
        Me.Name = "UC_Transactions"
        Me.Size = New System.Drawing.Size(1117, 667)
        Me.pnlRecipient.ResumeLayout(False)
        Me.pnlRecipient.PerformLayout()
        Me.gpbTypesOfCheckUp.ResumeLayout(False)
        Me.gpbTypesOfCheckUp.PerformLayout()
        Me.gpbPhilHealthMember.ResumeLayout(False)
        Me.gpbPhilHealthMember.PerformLayout()
        Me.pnlPrescription.ResumeLayout(False)
        Me.pnlPrescription.PerformLayout()
        CType(Me.dgvPrescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRecipient As Panel
    Friend WithEvents btnPrescription As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbSearchName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbOBDoctor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbTrimester As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlPrescription As Panel
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label4 As Label
    Friend WithEvents txbSearchVitamin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvPrescriptions As DataGridView
    Friend WithEvents lblErrorPrescription As Label
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PageSetupDialog As PageSetupDialog
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txbQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnAddToPrescription As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbInitial As RadioButton
    Friend WithEvents rbFollowUp As RadioButton
    Friend WithEvents gpbPhilHealthMember As GroupBox
    Friend WithEvents gpbTypesOfCheckUp As GroupBox
    Friend WithEvents lblErrorRecipient As Label
    Friend WithEvents lblSearchNameError As Label
    Friend WithEvents txbPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBill As Button
    Friend WithEvents lblInsufficientPayment As Label
    Friend WithEvents Vitamin As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents DailyDosage As DataGridViewTextBoxColumn
End Class
