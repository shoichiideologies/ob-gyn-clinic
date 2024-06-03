<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSummary = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAppointments = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPatients = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.PanelContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.UC_Dashboard1 = New OB_GYN_Clinic.UC_Start()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnShow = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnHide = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.TopPanel.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(207, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 28)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.Transparent
        Me.TopPanel.BorderColor = System.Drawing.Color.Transparent
        Me.TopPanel.Controls.Add(Me.Guna2ControlBox2)
        Me.TopPanel.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Transition1.SetDecoration(Me.TopPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TopPanel.Location = New System.Drawing.Point(1108, 1)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(255, 71)
        Me.TopPanel.TabIndex = 5
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1449, 35)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 25)
        Me.Guna2ControlBox2.TabIndex = 6
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Guna2Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2Panel2.BorderRadius = 119
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.btnLogout)
        Me.Guna2Panel2.Controls.Add(Me.btnSummary)
        Me.Guna2Panel2.Controls.Add(Me.btnInventory)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel2.Controls.Add(Me.btnTransaction)
        Me.Guna2Panel2.Controls.Add(Me.btnAppointments)
        Me.Guna2Panel2.Controls.Add(Me.btnPatients)
        Me.Guna2Panel2.Controls.Add(Me.btnStart)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, -3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(240, 748)
        Me.Guna2Panel2.TabIndex = 7
        '
        'PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.OB_GYN_Clinic.My.Resources.Resources.NOMG
        Me.PictureBox1.Location = New System.Drawing.Point(31, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.btnLogout, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogout.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.RosyBrown
        Me.btnLogout.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.OB_GYN_Clinic.My.Resources.Resources.logout_FILL0_wght400_GRAD0_opsz24
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnLogout.Location = New System.Drawing.Point(-3, 707)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.PressedColor = System.Drawing.Color.Transparent
        Me.btnLogout.Size = New System.Drawing.Size(240, 41)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseTransparentBackground = True
        '
        'btnSummary
        '
        Me.btnSummary.BackColor = System.Drawing.Color.Transparent
        Me.btnSummary.BorderColor = System.Drawing.Color.Transparent
        Me.btnSummary.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnSummary.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Transition1.SetDecoration(Me.btnSummary, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnSummary.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnSummary.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnSummary.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnSummary.DisabledState.ForeColor = System.Drawing.Color.Transparent
        Me.btnSummary.FillColor = System.Drawing.Color.Transparent
        Me.btnSummary.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummary.ForeColor = System.Drawing.Color.Black
        Me.btnSummary.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnSummary.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnSummary.HoverState.FillColor = System.Drawing.Color.RosyBrown
        Me.btnSummary.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSummary.Image = Global.OB_GYN_Clinic.My.Resources.Resources.menu_24dp_FILL0_wght400_GRAD0_opsz24
        Me.btnSummary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSummary.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSummary.Location = New System.Drawing.Point(-1, 144)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.PressedColor = System.Drawing.Color.Transparent
        Me.btnSummary.Size = New System.Drawing.Size(238, 41)
        Me.btnSummary.TabIndex = 13
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseTransparentBackground = True
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.BorderColor = System.Drawing.Color.Transparent
        Me.btnInventory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnInventory.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Transition1.SetDecoration(Me.btnInventory, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnInventory.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnInventory.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnInventory.DisabledState.ForeColor = System.Drawing.Color.Transparent
        Me.btnInventory.FillColor = System.Drawing.Color.Transparent
        Me.btnInventory.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.Black
        Me.btnInventory.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnInventory.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnInventory.HoverState.FillColor = System.Drawing.Color.RosyBrown
        Me.btnInventory.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Image = Global.OB_GYN_Clinic.My.Resources.Resources.inventory_2_24dp_FILL0_wght400_GRAD0_opsz24
        Me.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInventory.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnInventory.Location = New System.Drawing.Point(-1, 332)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.PressedColor = System.Drawing.Color.Transparent
        Me.btnInventory.Size = New System.Drawing.Size(238, 41)
        Me.btnInventory.TabIndex = 12
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseTransparentBackground = True
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Location = New System.Drawing.Point(11, 434)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(244, 10)
        Me.Guna2Separator1.TabIndex = 8
        Me.Guna2Separator1.UseTransparentBackground = True
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaction.BorderColor = System.Drawing.Color.Transparent
        Me.btnTransaction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnTransaction.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Transition1.SetDecoration(Me.btnTransaction, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnTransaction.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTransaction.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnTransaction.DisabledState.ForeColor = System.Drawing.Color.Transparent
        Me.btnTransaction.FillColor = System.Drawing.Color.Transparent
        Me.btnTransaction.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnTransaction.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnTransaction.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTransaction.HoverState.FillColor = System.Drawing.Color.RosyBrown
        Me.btnTransaction.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Image = Global.OB_GYN_Clinic.My.Resources.Resources.credit_card_24dp_FILL0_wght400_GRAD0_opsz24__1_
        Me.btnTransaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTransaction.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnTransaction.Location = New System.Drawing.Point(0, 285)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.PressedColor = System.Drawing.Color.Transparent
        Me.btnTransaction.Size = New System.Drawing.Size(238, 41)
        Me.btnTransaction.TabIndex = 11
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.UseTransparentBackground = True
        '
        'btnAppointments
        '
        Me.btnAppointments.BackColor = System.Drawing.Color.Transparent
        Me.btnAppointments.BorderColor = System.Drawing.Color.Transparent
        Me.btnAppointments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAppointments.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Transition1.SetDecoration(Me.btnAppointments, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAppointments.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnAppointments.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnAppointments.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnAppointments.DisabledState.ForeColor = System.Drawing.Color.Transparent
        Me.btnAppointments.FillColor = System.Drawing.Color.Transparent
        Me.btnAppointments.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointments.ForeColor = System.Drawing.Color.Black
        Me.btnAppointments.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnAppointments.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnAppointments.HoverState.FillColor = System.Drawing.Color.RosyBrown
        Me.btnAppointments.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAppointments.Image = Global.OB_GYN_Clinic.My.Resources.Resources.event_available_FILL0_wght400_GRAD0_opsz24
        Me.btnAppointments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAppointments.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAppointments.Location = New System.Drawing.Point(0, 238)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.PressedColor = System.Drawing.Color.Transparent
        Me.btnAppointments.Size = New System.Drawing.Size(238, 41)
        Me.btnAppointments.TabIndex = 10
        Me.btnAppointments.Text = "Appointments"
        Me.btnAppointments.UseTransparentBackground = True
        '
        'btnPatients
        '
        Me.btnPatients.BackColor = System.Drawing.Color.Transparent
        Me.btnPatients.BorderColor = System.Drawing.Color.Transparent
        Me.btnPatients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnPatients.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Transition1.SetDecoration(Me.btnPatients, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnPatients.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnPatients.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnPatients.DisabledState.ForeColor = System.Drawing.Color.Transparent
        Me.btnPatients.FillColor = System.Drawing.Color.Transparent
        Me.btnPatients.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatients.ForeColor = System.Drawing.Color.Black
        Me.btnPatients.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnPatients.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnPatients.HoverState.FillColor = System.Drawing.Color.RosyBrown
        Me.btnPatients.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnPatients.Image = Global.OB_GYN_Clinic.My.Resources.Resources.patient_list_FILL0_wght400_GRAD0_opsz24
        Me.btnPatients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPatients.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnPatients.Location = New System.Drawing.Point(0, 191)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.PressedColor = System.Drawing.Color.Transparent
        Me.btnPatients.Size = New System.Drawing.Size(238, 41)
        Me.btnPatients.TabIndex = 9
        Me.btnPatients.Text = "Patients"
        Me.btnPatients.UseTransparentBackground = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BorderColor = System.Drawing.Color.Transparent
        Me.btnStart.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnStart.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Transition1.SetDecoration(Me.btnStart, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnStart.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnStart.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnStart.DisabledState.ForeColor = System.Drawing.Color.Transparent
        Me.btnStart.FillColor = System.Drawing.Color.Transparent
        Me.btnStart.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnStart.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnStart.HoverState.FillColor = System.Drawing.Color.RosyBrown
        Me.btnStart.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnStart.Image = Global.OB_GYN_Clinic.My.Resources.Resources.space_dashboard_FILL0_wght400_GRAD0_opsz24
        Me.btnStart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStart.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnStart.Location = New System.Drawing.Point(-1, 97)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.PressedColor = System.Drawing.Color.Transparent
        Me.btnStart.Size = New System.Drawing.Size(238, 41)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Home"
        Me.btnStart.UseTransparentBackground = True
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'PanelContainer
        '
        Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelContainer.Controls.Add(Me.UC_Dashboard1)
        Me.Guna2Transition1.SetDecoration(Me.PanelContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelContainer.Location = New System.Drawing.Point(246, 78)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1117, 667)
        Me.PanelContainer.TabIndex = 10
        '
        'UC_Dashboard1
        '
        Me.UC_Dashboard1.BackColor = System.Drawing.Color.Snow
        Me.Guna2Transition1.SetDecoration(Me.UC_Dashboard1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UC_Dashboard1.Location = New System.Drawing.Point(0, 2)
        Me.UC_Dashboard1.Name = "UC_Dashboard1"
        Me.UC_Dashboard1.Size = New System.Drawing.Size(1117, 667)
        Me.UC_Dashboard1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lblTitle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(282, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 47)
        Me.lblTitle.TabIndex = 7
        '
        'btnShow
        '
        Me.btnShow.Animated = True
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Transition1.SetDecoration(Me.btnShow, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnShow.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = Global.OB_GYN_Clinic.My.Resources.Resources.arrow_forward_ios_FILL0_wght400_GRAD0_opsz24
        Me.btnShow.Location = New System.Drawing.Point(31, 418)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnShow.Size = New System.Drawing.Size(46, 44)
        Me.btnShow.TabIndex = 9
        Me.btnShow.UseTransparentBackground = True
        Me.btnShow.Visible = False
        '
        'btnHide
        '
        Me.btnHide.Animated = True
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Transition1.SetDecoration(Me.btnHide, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHide.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHide.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Image = Global.OB_GYN_Clinic.My.Resources.Resources.arrow_back_ios_new_FILL0_wght400_GRAD0_opsz24
        Me.btnHide.Location = New System.Drawing.Point(219, 418)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnHide.Size = New System.Drawing.Size(46, 44)
        Me.btnHide.TabIndex = 8
        Me.btnHide.UseTransparentBackground = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1364, 746)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.PanelContainer)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.TopPanel.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPatients As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAppointments As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnHide As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents PanelContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSummary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UC_Dashboard1 As UC_Start
    Friend WithEvents PictureBox1 As PictureBox
End Class
