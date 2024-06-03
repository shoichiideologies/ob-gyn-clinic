<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Inventory
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvVitaminList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AddVitamin = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Vitamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScientificName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufactureName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricePerPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvVitaminList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVitaminList
        '
        Me.dgvVitaminList.AllowUserToAddRows = False
        Me.dgvVitaminList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "-"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvVitaminList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVitaminList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "-"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVitaminList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVitaminList.ColumnHeadersHeight = 40
        Me.dgvVitaminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvVitaminList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Vitamin, Me.ScientificName, Me.ManufactureName, Me.PricePerPiece, Me.Quantity})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVitaminList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVitaminList.GridColor = System.Drawing.Color.LightGray
        Me.dgvVitaminList.Location = New System.Drawing.Point(91, 70)
        Me.dgvVitaminList.MultiSelect = False
        Me.dgvVitaminList.Name = "dgvVitaminList"
        Me.dgvVitaminList.ReadOnly = True
        Me.dgvVitaminList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVitaminList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVitaminList.RowHeadersVisible = False
        Me.dgvVitaminList.RowHeadersWidth = 70
        Me.dgvVitaminList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvVitaminList.RowTemplate.Height = 40
        Me.dgvVitaminList.Size = New System.Drawing.Size(934, 413)
        Me.dgvVitaminList.TabIndex = 5
        Me.dgvVitaminList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvVitaminList.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVitaminList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvVitaminList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvVitaminList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvVitaminList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvVitaminList.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.dgvVitaminList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvVitaminList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvVitaminList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVitaminList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvVitaminList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvVitaminList.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvVitaminList.ThemeStyle.ReadOnly = True
        Me.dgvVitaminList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvVitaminList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvVitaminList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVitaminList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvVitaminList.ThemeStyle.RowsStyle.Height = 40
        Me.dgvVitaminList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvVitaminList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AddVitamin
        '
        Me.AddVitamin.BackColor = System.Drawing.Color.Transparent
        Me.AddVitamin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddVitamin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddVitamin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddVitamin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddVitamin.FillColor = System.Drawing.Color.LightCoral
        Me.AddVitamin.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddVitamin.ForeColor = System.Drawing.Color.White
        Me.AddVitamin.Location = New System.Drawing.Point(91, 527)
        Me.AddVitamin.Name = "AddVitamin"
        Me.AddVitamin.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddVitamin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.AddVitamin.Size = New System.Drawing.Size(72, 70)
        Me.AddVitamin.TabIndex = 4
        Me.AddVitamin.Text = "+"
        '
        'Vitamin
        '
        Me.Vitamin.HeaderText = "Vitamin"
        Me.Vitamin.MinimumWidth = 6
        Me.Vitamin.Name = "Vitamin"
        Me.Vitamin.ReadOnly = True
        '
        'ScientificName
        '
        Me.ScientificName.HeaderText = "Scientific Name"
        Me.ScientificName.MinimumWidth = 6
        Me.ScientificName.Name = "ScientificName"
        Me.ScientificName.ReadOnly = True
        '
        'ManufactureName
        '
        Me.ManufactureName.HeaderText = "Manufacturer Name"
        Me.ManufactureName.MinimumWidth = 6
        Me.ManufactureName.Name = "ManufactureName"
        Me.ManufactureName.ReadOnly = True
        '
        'PricePerPiece
        '
        Me.PricePerPiece.HeaderText = "Price Per Piece"
        Me.PricePerPiece.MinimumWidth = 6
        Me.PricePerPiece.Name = "PricePerPiece"
        Me.PricePerPiece.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'UC_Vitamins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvVitaminList)
        Me.Controls.Add(Me.AddVitamin)
        Me.Name = "UC_Vitamins"
        Me.Size = New System.Drawing.Size(1117, 667)
        CType(Me.dgvVitaminList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVitaminList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AddVitamin As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Vitamin As DataGridViewTextBoxColumn
    Friend WithEvents ScientificName As DataGridViewTextBoxColumn
    Friend WithEvents ManufactureName As DataGridViewTextBoxColumn
    Friend WithEvents PricePerPiece As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
End Class
