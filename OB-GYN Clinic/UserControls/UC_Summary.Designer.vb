<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Summary
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Summary))
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lsvOutOfStocks = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelStocks = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblVitaminName = New System.Windows.Forms.Label()
        Me.lblStocks = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lsvSchedules = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelPatientCount = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PanelDoctorOfTheDay = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDoctorToday = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelTodayDate = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.PanelQuotes = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guna2Panel3.SuspendLayout()
        Me.PanelStocks.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.PanelPatientCount.SuspendLayout()
        Me.PanelDoctorOfTheDay.SuspendLayout()
        Me.PanelTodayDate.SuspendLayout()
        Me.PanelQuotes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.lsvOutOfStocks)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel3.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel3.CustomizableEdges.BottomRight = False
        Me.Guna2Panel3.CustomizableEdges.TopLeft = False
        Me.Guna2Panel3.CustomizableEdges.TopRight = False
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(748, 270)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(324, 354)
        Me.Guna2Panel3.TabIndex = 11
        '
        'lsvOutOfStocks
        '
        Me.lsvOutOfStocks.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lsvOutOfStocks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvOutOfStocks.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvOutOfStocks.FullRowSelect = True
        Me.lsvOutOfStocks.GridLines = True
        Me.lsvOutOfStocks.HideSelection = False
        Me.lsvOutOfStocks.Location = New System.Drawing.Point(28, 55)
        Me.lsvOutOfStocks.Name = "lsvOutOfStocks"
        Me.lsvOutOfStocks.Size = New System.Drawing.Size(267, 276)
        Me.lsvOutOfStocks.TabIndex = 2
        Me.lsvOutOfStocks.UseCompatibleStateImageBehavior = False
        Me.lsvOutOfStocks.View = System.Windows.Forms.View.Tile
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Vitamin Stocks"
        '
        'PanelStocks
        '
        Me.PanelStocks.BackColor = System.Drawing.Color.White
        Me.PanelStocks.BorderColor = System.Drawing.Color.Gainsboro
        Me.PanelStocks.BorderThickness = 1
        Me.PanelStocks.Controls.Add(Me.lblVitaminName)
        Me.PanelStocks.Controls.Add(Me.lblStocks)
        Me.PanelStocks.Controls.Add(Me.Label2)
        Me.PanelStocks.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.PanelStocks.CustomizableEdges.BottomLeft = False
        Me.PanelStocks.CustomizableEdges.BottomRight = False
        Me.PanelStocks.CustomizableEdges.TopLeft = False
        Me.PanelStocks.CustomizableEdges.TopRight = False
        Me.PanelStocks.FillColor = System.Drawing.Color.White
        Me.PanelStocks.Location = New System.Drawing.Point(384, 491)
        Me.PanelStocks.Name = "PanelStocks"
        Me.PanelStocks.Size = New System.Drawing.Size(333, 133)
        Me.PanelStocks.TabIndex = 10
        '
        'lblVitaminName
        '
        Me.lblVitaminName.AutoSize = True
        Me.lblVitaminName.BackColor = System.Drawing.Color.Transparent
        Me.lblVitaminName.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVitaminName.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblVitaminName.Location = New System.Drawing.Point(131, 86)
        Me.lblVitaminName.Name = "lblVitaminName"
        Me.lblVitaminName.Size = New System.Drawing.Size(47, 37)
        Me.lblVitaminName.TabIndex = 7
        Me.lblVitaminName.Text = """ """
        Me.lblVitaminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStocks
        '
        Me.lblStocks.AutoSize = True
        Me.lblStocks.BackColor = System.Drawing.Color.Transparent
        Me.lblStocks.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStocks.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblStocks.Location = New System.Drawing.Point(38, 49)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(26, 19)
        Me.lblStocks.TabIndex = 6
        Me.lblStocks.Text = """ """
        Me.lblStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(87, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Running out of Stocks"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.lsvSchedules)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel1.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel1.CustomizableEdges.BottomRight = False
        Me.Guna2Panel1.CustomizableEdges.TopLeft = False
        Me.Guna2Panel1.CustomizableEdges.TopRight = False
        Me.Guna2Panel1.Location = New System.Drawing.Point(38, 174)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(314, 450)
        Me.Guna2Panel1.TabIndex = 9
        '
        'lsvSchedules
        '
        Me.lsvSchedules.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lsvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvSchedules.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvSchedules.FullRowSelect = True
        Me.lsvSchedules.GridLines = True
        Me.lsvSchedules.HideSelection = False
        Me.lsvSchedules.Location = New System.Drawing.Point(28, 64)
        Me.lsvSchedules.Name = "lsvSchedules"
        Me.lsvSchedules.Size = New System.Drawing.Size(260, 363)
        Me.lsvSchedules.TabIndex = 1
        Me.lsvSchedules.UseCompatibleStateImageBehavior = False
        Me.lsvSchedules.View = System.Windows.Forms.View.Tile
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Upcoming Schedules"
        '
        'PanelPatientCount
        '
        Me.PanelPatientCount.BackColor = System.Drawing.Color.White
        Me.PanelPatientCount.BorderColor = System.Drawing.Color.Gainsboro
        Me.PanelPatientCount.BorderThickness = 1
        Me.PanelPatientCount.Controls.Add(Me.lblFirst)
        Me.PanelPatientCount.Controls.Add(Me.Label4)
        Me.PanelPatientCount.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.PanelPatientCount.CustomizableEdges.BottomLeft = False
        Me.PanelPatientCount.CustomizableEdges.BottomRight = False
        Me.PanelPatientCount.CustomizableEdges.TopLeft = False
        Me.PanelPatientCount.CustomizableEdges.TopRight = False
        Me.PanelPatientCount.FillColor = System.Drawing.Color.White
        Me.PanelPatientCount.Location = New System.Drawing.Point(38, 41)
        Me.PanelPatientCount.Name = "PanelPatientCount"
        Me.PanelPatientCount.Size = New System.Drawing.Size(169, 103)
        Me.PanelPatientCount.TabIndex = 12
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.BackColor = System.Drawing.Color.Transparent
        Me.lblFirst.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblFirst.Location = New System.Drawing.Point(12, 56)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(43, 34)
        Me.lblFirst.TabIndex = 4
        Me.lblFirst.Text = """ """
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Patient Count"
        '
        'PanelDoctorOfTheDay
        '
        Me.PanelDoctorOfTheDay.BackColor = System.Drawing.Color.White
        Me.PanelDoctorOfTheDay.BorderColor = System.Drawing.Color.Gainsboro
        Me.PanelDoctorOfTheDay.BorderThickness = 1
        Me.PanelDoctorOfTheDay.Controls.Add(Me.lblDoctorToday)
        Me.PanelDoctorOfTheDay.Controls.Add(Me.Label6)
        Me.PanelDoctorOfTheDay.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.PanelDoctorOfTheDay.CustomizableEdges.BottomLeft = False
        Me.PanelDoctorOfTheDay.CustomizableEdges.BottomRight = False
        Me.PanelDoctorOfTheDay.CustomizableEdges.TopLeft = False
        Me.PanelDoctorOfTheDay.CustomizableEdges.TopRight = False
        Me.PanelDoctorOfTheDay.FillColor = System.Drawing.Color.White
        Me.PanelDoctorOfTheDay.Location = New System.Drawing.Point(233, 41)
        Me.PanelDoctorOfTheDay.Name = "PanelDoctorOfTheDay"
        Me.PanelDoctorOfTheDay.Size = New System.Drawing.Size(243, 103)
        Me.PanelDoctorOfTheDay.TabIndex = 13
        '
        'lblDoctorToday
        '
        Me.lblDoctorToday.AutoSize = True
        Me.lblDoctorToday.BackColor = System.Drawing.Color.Transparent
        Me.lblDoctorToday.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorToday.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblDoctorToday.Location = New System.Drawing.Point(28, 69)
        Me.lblDoctorToday.Name = "lblDoctorToday"
        Me.lblDoctorToday.Size = New System.Drawing.Size(21, 16)
        Me.lblDoctorToday.TabIndex = 4
        Me.lblDoctorToday.Text = """ """
        Me.lblDoctorToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(49, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Doctor Of The Day"
        '
        'PanelTodayDate
        '
        Me.PanelTodayDate.BackColor = System.Drawing.Color.White
        Me.PanelTodayDate.BorderColor = System.Drawing.Color.Gainsboro
        Me.PanelTodayDate.BorderThickness = 1
        Me.PanelTodayDate.Controls.Add(Me.lblDateToday)
        Me.PanelTodayDate.Controls.Add(Me.label)
        Me.PanelTodayDate.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.PanelTodayDate.CustomizableEdges.BottomLeft = False
        Me.PanelTodayDate.CustomizableEdges.BottomRight = False
        Me.PanelTodayDate.CustomizableEdges.TopLeft = False
        Me.PanelTodayDate.CustomizableEdges.TopRight = False
        Me.PanelTodayDate.FillColor = System.Drawing.Color.White
        Me.PanelTodayDate.Location = New System.Drawing.Point(503, 41)
        Me.PanelTodayDate.Name = "PanelTodayDate"
        Me.PanelTodayDate.Size = New System.Drawing.Size(214, 103)
        Me.PanelTodayDate.TabIndex = 14
        '
        'lblDateToday
        '
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.BackColor = System.Drawing.Color.Transparent
        Me.lblDateToday.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblDateToday.Location = New System.Drawing.Point(16, 74)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(21, 16)
        Me.lblDateToday.TabIndex = 5
        Me.lblDateToday.Text = """ """
        Me.lblDateToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Black
        Me.label.Location = New System.Drawing.Point(78, 15)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(53, 18)
        Me.label.TabIndex = 0
        Me.label.Text = "Today"
        '
        'PanelQuotes
        '
        Me.PanelQuotes.BackColor = System.Drawing.Color.White
        Me.PanelQuotes.BorderColor = System.Drawing.Color.Gainsboro
        Me.PanelQuotes.BorderThickness = 1
        Me.PanelQuotes.Controls.Add(Me.Label5)
        Me.PanelQuotes.Controls.Add(Me.Label8)
        Me.PanelQuotes.Controls.Add(Me.Label9)
        Me.PanelQuotes.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.PanelQuotes.CustomizableEdges.BottomLeft = False
        Me.PanelQuotes.CustomizableEdges.BottomRight = False
        Me.PanelQuotes.CustomizableEdges.TopLeft = False
        Me.PanelQuotes.CustomizableEdges.TopRight = False
        Me.PanelQuotes.FillColor = System.Drawing.Color.White
        Me.PanelQuotes.Location = New System.Drawing.Point(748, 41)
        Me.PanelQuotes.Name = "PanelQuotes"
        Me.PanelQuotes.Size = New System.Drawing.Size(324, 204)
        Me.PanelQuotes.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(43, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 128)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label8.Location = New System.Drawing.Point(43, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(92, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Word of the day"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OB_GYN_Clinic.My.Resources.Resources.NOMG__4_
        Me.PictureBox1.Location = New System.Drawing.Point(384, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataSource = GetType(OB_GYN_Clinic.Patient)
        '
        'UC_Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelQuotes)
        Me.Controls.Add(Me.PanelTodayDate)
        Me.Controls.Add(Me.PanelDoctorOfTheDay)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.PanelStocks)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PanelPatientCount)
        Me.Name = "UC_Summary"
        Me.Size = New System.Drawing.Size(1117, 667)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.PanelStocks.ResumeLayout(False)
        Me.PanelStocks.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.PanelPatientCount.ResumeLayout(False)
        Me.PanelPatientCount.PerformLayout()
        Me.PanelDoctorOfTheDay.ResumeLayout(False)
        Me.PanelDoctorOfTheDay.PerformLayout()
        Me.PanelTodayDate.ResumeLayout(False)
        Me.PanelTodayDate.PerformLayout()
        Me.PanelQuotes.ResumeLayout(False)
        Me.PanelQuotes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelStocks As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PanelPatientCount As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelDoctorOfTheDay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblDoctorToday As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelTodayDate As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents label As Label
    Friend WithEvents PanelQuotes As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lsvSchedules As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lsvOutOfStocks As ListView
    Friend WithEvents lblStocks As Label
    Friend WithEvents lblVitaminName As Label
    Friend WithEvents Label5 As Label
End Class
