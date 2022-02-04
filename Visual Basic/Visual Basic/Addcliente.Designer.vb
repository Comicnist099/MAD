<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addcliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addcliente))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRFC = New System.Windows.Forms.TextBox()
        Me.TxtCURP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTPFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellidoM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApellidoP = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(14, 426)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 14)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Domicilio: "
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TextBox2.Location = New System.Drawing.Point(73, 423)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 22)
        Me.TextBox2.TabIndex = 113
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(328, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 14)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Fecha de alta o modificacion:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(489, 219)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 22)
        Me.DateTimePicker1.TabIndex = 111
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(397, 317)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(343, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 14)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Genero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(343, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "No.Medidor:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TextBox1.Location = New System.Drawing.Point(416, 276)
        Me.TextBox1.MaxLength = 13
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 22)
        Me.TextBox1.TabIndex = 107
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(12, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 14)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "Usuario: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(14, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 14)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "CURP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(12, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Email: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Nombre: "
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(361, 379)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Padding = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Size = New System.Drawing.Size(160, 65)
        Me.BtnBack.TabIndex = 102
        Me.BtnBack.Text = "Regresar"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(554, 379)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Padding = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Size = New System.Drawing.Size(160, 65)
        Me.BtnAdd.TabIndex = 101
        Me.BtnAdd.Text = "Agregar"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(14, 380)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 14)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Constraseña: "
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtContraseña.Location = New System.Drawing.Point(94, 377)
        Me.TxtContraseña.MaxLength = 20
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(201, 22)
        Me.TxtContraseña.TabIndex = 99
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(63, 316)
        Me.TxtNombreUsuario.MaxLength = 20
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(201, 22)
        Me.TxtNombreUsuario.TabIndex = 98
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(343, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 14)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "No.Servicio:"
        '
        'TxtRFC
        '
        Me.TxtRFC.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtRFC.Location = New System.Drawing.Point(416, 249)
        Me.TxtRFC.MaxLength = 13
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.Size = New System.Drawing.Size(75, 22)
        Me.TxtRFC.TabIndex = 96
        '
        'TxtCURP
        '
        Me.TxtCURP.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtCURP.Location = New System.Drawing.Point(58, 255)
        Me.TxtCURP.MaxLength = 18
        Me.TxtCURP.Name = "TxtCURP"
        Me.TxtCURP.Size = New System.Drawing.Size(232, 22)
        Me.TxtCURP.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(328, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 14)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Fecha de Nacimiento: "
        '
        'DTPFechaNacimiento
        '
        Me.DTPFechaNacimiento.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaNacimiento.Location = New System.Drawing.Point(454, 188)
        Me.DTPFechaNacimiento.Name = "DTPFechaNacimiento"
        Me.DTPFechaNacimiento.Size = New System.Drawing.Size(145, 22)
        Me.DTPFechaNacimiento.TabIndex = 93
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtEmail.Location = New System.Drawing.Point(49, 191)
        Me.TxtEmail.MaxLength = 50
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(201, 22)
        Me.TxtEmail.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(531, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 14)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Apellido Materno: "
        '
        'TxtApellidoM
        '
        Me.TxtApellidoM.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtApellidoM.Location = New System.Drawing.Point(629, 131)
        Me.TxtApellidoM.MaxLength = 30
        Me.TxtApellidoM.Name = "TxtApellidoM"
        Me.TxtApellidoM.Size = New System.Drawing.Size(147, 22)
        Me.TxtApellidoM.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(279, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 14)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Apellido Paterno: "
        '
        'TxtApellidoP
        '
        Me.TxtApellidoP.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtApellidoP.Location = New System.Drawing.Point(374, 131)
        Me.TxtApellidoP.MaxLength = 30
        Me.TxtApellidoP.Name = "TxtApellidoP"
        Me.TxtApellidoP.Size = New System.Drawing.Size(147, 22)
        Me.TxtApellidoP.TabIndex = 88
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.TxtNombre.Location = New System.Drawing.Point(63, 130)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(201, 22)
        Me.TxtNombre.TabIndex = 87
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-1, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 87)
        Me.Panel2.TabIndex = 86
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, -14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(197, 124)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Addcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtRFC)
        Me.Controls.Add(Me.TxtCURP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTPFechaNacimiento)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtApellidoM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtApellidoP)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Addcliente"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtRFC As TextBox
    Friend WithEvents TxtCURP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DTPFechaNacimiento As DateTimePicker
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellidoM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellidoP As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
