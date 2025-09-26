<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVitamins
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
        Me.grbDrugDetails = New System.Windows.Forms.GroupBox()
        Me.btnScientificName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbbAppropriateTrimester = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbManufactureName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbPricePerPiece = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.cbbVitaminType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.Label()
        Me.txbQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ScientificName = New System.Windows.Forms.Label()
        Me.btnAddVitamin = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.gpbAddStocks = New System.Windows.Forms.GroupBox()
        Me.txbStocksQuantity = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbStocksScientificName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.grbDrugDetails.SuspendLayout()
        Me.gpbAddStocks.SuspendLayout()
        CType(Me.txbStocksQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'grbDrugDetails
        '
        Me.grbDrugDetails.Controls.Add(Me.btnScientificName)
        Me.grbDrugDetails.Controls.Add(Me.cbbAppropriateTrimester)
        Me.grbDrugDetails.Controls.Add(Me.Label1)
        Me.grbDrugDetails.Controls.Add(Me.txbManufactureName)
        Me.grbDrugDetails.Controls.Add(Me.txbPricePerPiece)
        Me.grbDrugDetails.Controls.Add(Me.Label2)
        Me.grbDrugDetails.Controls.Add(Me.lblSurname)
        Me.grbDrugDetails.Controls.Add(Me.cbbVitaminType)
        Me.grbDrugDetails.Controls.Add(Me.lblFirstName)
        Me.grbDrugDetails.Controls.Add(Me.Quantity)
        Me.grbDrugDetails.Controls.Add(Me.txbQuantity)
        Me.grbDrugDetails.Controls.Add(Me.ScientificName)
        Me.grbDrugDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDrugDetails.Location = New System.Drawing.Point(41, 42)
        Me.grbDrugDetails.Name = "grbDrugDetails"
        Me.grbDrugDetails.Size = New System.Drawing.Size(635, 260)
        Me.grbDrugDetails.TabIndex = 1
        Me.grbDrugDetails.TabStop = False
        Me.grbDrugDetails.Text = "Drug Details"
        '
        'btnScientificName
        '
        Me.btnScientificName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnScientificName.DefaultText = ""
        Me.btnScientificName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnScientificName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnScientificName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnScientificName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnScientificName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnScientificName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScientificName.ForeColor = System.Drawing.Color.Black
        Me.btnScientificName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnScientificName.Location = New System.Drawing.Point(336, 57)
        Me.btnScientificName.Name = "btnScientificName"
        Me.btnScientificName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.btnScientificName.PlaceholderText = ""
        Me.btnScientificName.SelectedText = ""
        Me.btnScientificName.Size = New System.Drawing.Size(257, 36)
        Me.btnScientificName.TabIndex = 44
        '
        'cbbAppropriateTrimester
        '
        Me.cbbAppropriateTrimester.BackColor = System.Drawing.Color.Transparent
        Me.cbbAppropriateTrimester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbAppropriateTrimester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbAppropriateTrimester.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbAppropriateTrimester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbAppropriateTrimester.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbAppropriateTrimester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbbAppropriateTrimester.ItemHeight = 30
        Me.cbbAppropriateTrimester.Items.AddRange(New Object() {"First Trimester", "Second Trimester", "Third Trimester"})
        Me.cbbAppropriateTrimester.Location = New System.Drawing.Point(335, 123)
        Me.cbbAppropriateTrimester.Name = "cbbAppropriateTrimester"
        Me.cbbAppropriateTrimester.Size = New System.Drawing.Size(257, 36)
        Me.cbbAppropriateTrimester.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Manufacture Name"
        '
        'txbManufactureName
        '
        Me.txbManufactureName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbManufactureName.DefaultText = ""
        Me.txbManufactureName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbManufactureName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbManufactureName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbManufactureName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbManufactureName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbManufactureName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbManufactureName.ForeColor = System.Drawing.Color.Black
        Me.txbManufactureName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbManufactureName.Location = New System.Drawing.Point(54, 123)
        Me.txbManufactureName.Name = "txbManufactureName"
        Me.txbManufactureName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbManufactureName.PlaceholderText = ""
        Me.txbManufactureName.SelectedText = ""
        Me.txbManufactureName.Size = New System.Drawing.Size(258, 36)
        Me.txbManufactureName.TabIndex = 36
        '
        'txbPricePerPiece
        '
        Me.txbPricePerPiece.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbPricePerPiece.DefaultText = ""
        Me.txbPricePerPiece.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbPricePerPiece.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbPricePerPiece.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPricePerPiece.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbPricePerPiece.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPricePerPiece.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPricePerPiece.ForeColor = System.Drawing.Color.Black
        Me.txbPricePerPiece.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbPricePerPiece.Location = New System.Drawing.Point(335, 189)
        Me.txbPricePerPiece.Name = "txbPricePerPiece"
        Me.txbPricePerPiece.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbPricePerPiece.PlaceholderText = ""
        Me.txbPricePerPiece.SelectedText = ""
        Me.txbPricePerPiece.Size = New System.Drawing.Size(258, 36)
        Me.txbPricePerPiece.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(332, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Appropriate Trimester To Take"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(332, 169)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(100, 16)
        Me.lblSurname.TabIndex = 34
        Me.lblSurname.Text = "Price Per Piece"
        '
        'cbbVitaminType
        '
        Me.cbbVitaminType.BackColor = System.Drawing.Color.Transparent
        Me.cbbVitaminType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbVitaminType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbVitaminType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbVitaminType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbVitaminType.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbVitaminType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbbVitaminType.ItemHeight = 30
        Me.cbbVitaminType.Items.AddRange(New Object() {"Vitamin A", "Vitamin C", "Vitamin D", "Vitamin E", "Vitamin K", "Vitamin C", "Vitamin B1", "Vitamin B2", "Vitamin B3", "Vitamin B5", "Vitamin B6", "Vitamin B7", "Vitamin B9", "Vitamin B12"})
        Me.cbbVitaminType.Location = New System.Drawing.Point(55, 57)
        Me.cbbVitaminType.Name = "cbbVitaminType"
        Me.cbbVitaminType.Size = New System.Drawing.Size(257, 36)
        Me.cbbVitaminType.TabIndex = 35
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(54, 35)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 16)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "Vitamin Type"
        '
        'Quantity
        '
        Me.Quantity.AutoSize = True
        Me.Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(51, 169)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(55, 16)
        Me.Quantity.TabIndex = 3
        Me.Quantity.Text = "Quantity"
        '
        'txbQuantity
        '
        Me.txbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbQuantity.DefaultText = ""
        Me.txbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbQuantity.ForeColor = System.Drawing.Color.Black
        Me.txbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbQuantity.Location = New System.Drawing.Point(54, 191)
        Me.txbQuantity.Name = "txbQuantity"
        Me.txbQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbQuantity.PlaceholderText = ""
        Me.txbQuantity.SelectedText = ""
        Me.txbQuantity.Size = New System.Drawing.Size(258, 36)
        Me.txbQuantity.TabIndex = 3
        '
        'ScientificName
        '
        Me.ScientificName.AutoSize = True
        Me.ScientificName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScientificName.Location = New System.Drawing.Point(332, 37)
        Me.ScientificName.Name = "ScientificName"
        Me.ScientificName.Size = New System.Drawing.Size(100, 16)
        Me.ScientificName.TabIndex = 7
        Me.ScientificName.Text = "Scientific Name"
        '
        'btnAddVitamin
        '
        Me.btnAddVitamin.BackColor = System.Drawing.Color.Transparent
        Me.btnAddVitamin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddVitamin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddVitamin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddVitamin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddVitamin.FillColor = System.Drawing.Color.RosyBrown
        Me.btnAddVitamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddVitamin.ForeColor = System.Drawing.Color.White
        Me.btnAddVitamin.Location = New System.Drawing.Point(223, 469)
        Me.btnAddVitamin.Name = "btnAddVitamin"
        Me.btnAddVitamin.Size = New System.Drawing.Size(293, 36)
        Me.btnAddVitamin.TabIndex = 17
        Me.btnAddVitamin.Text = "Add Vitamin"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderThickness = 1
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(673, 7)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 40
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(38, 305)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 41
        '
        'gpbAddStocks
        '
        Me.gpbAddStocks.Controls.Add(Me.txbStocksQuantity)
        Me.gpbAddStocks.Controls.Add(Me.Label3)
        Me.gpbAddStocks.Controls.Add(Me.Label4)
        Me.gpbAddStocks.Controls.Add(Me.txbStocksScientificName)
        Me.gpbAddStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAddStocks.Location = New System.Drawing.Point(41, 329)
        Me.gpbAddStocks.Name = "gpbAddStocks"
        Me.gpbAddStocks.Size = New System.Drawing.Size(635, 110)
        Me.gpbAddStocks.TabIndex = 43
        Me.gpbAddStocks.TabStop = False
        Me.gpbAddStocks.Text = "Stocks"
        '
        'txbStocksQuantity
        '
        Me.txbStocksQuantity.BackColor = System.Drawing.Color.Transparent
        Me.txbStocksQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbStocksQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.txbStocksQuantity.Location = New System.Drawing.Point(336, 49)
        Me.txbStocksQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbStocksQuantity.Maximum = New Decimal(New Integer() {20000, 0, 0, 0})
        Me.txbStocksQuantity.Name = "txbStocksQuantity"
        Me.txbStocksQuantity.Size = New System.Drawing.Size(257, 36)
        Me.txbStocksQuantity.TabIndex = 44
        Me.txbStocksQuantity.UpDownButtonFillColor = System.Drawing.Color.MistyRose
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Vitamin"
        '
        'txbStocksScientificName
        '
        Me.txbStocksScientificName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbStocksScientificName.DefaultText = ""
        Me.txbStocksScientificName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbStocksScientificName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbStocksScientificName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbStocksScientificName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbStocksScientificName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbStocksScientificName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbStocksScientificName.ForeColor = System.Drawing.Color.Black
        Me.txbStocksScientificName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbStocksScientificName.Location = New System.Drawing.Point(57, 49)
        Me.txbStocksScientificName.Name = "txbStocksScientificName"
        Me.txbStocksScientificName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbStocksScientificName.PlaceholderText = ""
        Me.txbStocksScientificName.SelectedText = ""
        Me.txbStocksScientificName.Size = New System.Drawing.Size(257, 36)
        Me.txbStocksScientificName.TabIndex = 6
        '
        'AddVitamins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 529)
        Me.Controls.Add(Me.gpbAddStocks)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.btnAddVitamin)
        Me.Controls.Add(Me.grbDrugDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddVitamins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddVitamins"
        Me.grbDrugDetails.ResumeLayout(False)
        Me.grbDrugDetails.PerformLayout()
        Me.gpbAddStocks.ResumeLayout(False)
        Me.gpbAddStocks.PerformLayout()
        CType(Me.txbStocksQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents grbDrugDetails As GroupBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txbPricePerPiece As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Quantity As Label
    Friend WithEvents txbQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ScientificName As Label
    Friend WithEvents cbbVitaminType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAddVitamin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbManufactureName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbAppropriateTrimester As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblError As Label
    Friend WithEvents gpbAddStocks As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbStocksScientificName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnScientificName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbStocksQuantity As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
