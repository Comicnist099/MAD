<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarInformacionAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarInformacionAdmin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxAgregar = New System.Windows.Forms.ComboBox()
        Me.TextCelular = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextRFC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextCURP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextDomicilio = New System.Windows.Forms.TextBox()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.TextApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(669, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label12.Location = New System.Drawing.Point(459, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 22)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "Rol:"
        '
        'ComboBoxAgregar
        '
        Me.ComboBoxAgregar.FormattingEnabled = True
        Me.ComboBoxAgregar.Items.AddRange(New Object() {"Empleado", "Admin"})
        Me.ComboBoxAgregar.Location = New System.Drawing.Point(540, 323)
        Me.ComboBoxAgregar.Name = "ComboBoxAgregar"
        Me.ComboBoxAgregar.Size = New System.Drawing.Size(194, 21)
        Me.ComboBoxAgregar.TabIndex = 130
        '
        'TextCelular
        '
        Me.TextCelular.Location = New System.Drawing.Point(540, 291)
        Me.TextCelular.MaxLength = 10
        Me.TextCelular.Name = "TextCelular"
        Me.TextCelular.Size = New System.Drawing.Size(194, 20)
        Me.TextCelular.TabIndex = 129
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label14.Location = New System.Drawing.Point(459, 288)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 22)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "Celular:"
        '
        'TextRFC
        '
        Me.TextRFC.Location = New System.Drawing.Point(194, 291)
        Me.TextRFC.Name = "TextRFC"
        Me.TextRFC.Size = New System.Drawing.Size(200, 20)
        Me.TextRFC.TabIndex = 127
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label13.Location = New System.Drawing.Point(44, 334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 22)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "RFC:"
        '
        'TextCURP
        '
        Me.TextCURP.Location = New System.Drawing.Point(208, 323)
        Me.TextCURP.Name = "TextCURP"
        Me.TextCURP.Size = New System.Drawing.Size(179, 20)
        Me.TextCURP.TabIndex = 125
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label11.Location = New System.Drawing.Point(43, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 22)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "CURP:"
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(540, 223)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(194, 20)
        Me.TextUsuario.TabIndex = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(428, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Usuario:"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.SaddleBrown
        Me.ButtonAgregar.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAgregar.Location = New System.Drawing.Point(226, 436)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(141, 54)
        Me.ButtonAgregar.TabIndex = 121
        Me.ButtonAgregar.Text = "Modificar"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poplar Std", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(198, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(401, 57)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Modificar mi información"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(36, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 22)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Domicilio Completo:"
        '
        'TextDomicilio
        '
        Me.TextDomicilio.Location = New System.Drawing.Point(226, 384)
        Me.TextDomicilio.Name = "TextDomicilio"
        Me.TextDomicilio.Size = New System.Drawing.Size(508, 20)
        Me.TextDomicilio.TabIndex = 118
        '
        'TextContraseña
        '
        Me.TextContraseña.Location = New System.Drawing.Point(540, 255)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.Size = New System.Drawing.Size(194, 20)
        Me.TextContraseña.TabIndex = 117
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(540, 155)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(194, 20)
        Me.TextEmail.TabIndex = 116
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(194, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 115
        '
        'TextApellidoMaterno
        '
        Me.TextApellidoMaterno.Location = New System.Drawing.Point(194, 220)
        Me.TextApellidoMaterno.Name = "TextApellidoMaterno"
        Me.TextApellidoMaterno.Size = New System.Drawing.Size(200, 20)
        Me.TextApellidoMaterno.TabIndex = 114
        '
        'TextApellidoPaterno
        '
        Me.TextApellidoPaterno.Location = New System.Drawing.Point(194, 187)
        Me.TextApellidoPaterno.Name = "TextApellidoPaterno"
        Me.TextApellidoPaterno.Size = New System.Drawing.Size(200, 20)
        Me.TextApellidoPaterno.TabIndex = 113
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(194, 155)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(200, 20)
        Me.TextName.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(428, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(475, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 22)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(10, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 22)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(36, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 22)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Apellido Materno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(36, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 22)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(105, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Nombre:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(62, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 133
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(414, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 54)
        Me.Button1.TabIndex = 134
        Me.Button1.Text = "VOLVER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ModificarInformacionAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(809, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBoxAgregar)
        Me.Controls.Add(Me.TextCelular)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextRFC)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextCURP)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextDomicilio)
        Me.Controls.Add(Me.TextContraseña)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextApellidoMaterno)
        Me.Controls.Add(Me.TextApellidoPaterno)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarInformacionAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarInformacionEmpleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxAgregar As ComboBox
    Friend WithEvents TextCelular As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextRFC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextCURP As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextDomicilio As TextBox
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextApellidoMaterno As TextBox
    Friend WithEvents TextApellidoPaterno As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
