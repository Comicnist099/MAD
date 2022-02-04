<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Horas_Marco
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Horas_Marco))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelHoras = New System.Windows.Forms.Label()
        Me.minutoscombo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxHora = New System.Windows.Forms.ComboBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combopm = New System.Windows.Forms.ComboBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApP = New System.Windows.Forms.TextBox()
        Me.TextBoxApM = New System.Windows.Forms.TextBox()
        Me.TextCURP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextRFC = New System.Windows.Forms.TextBox()
        Me.TextCelular = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.TextDomicilio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ":"
        '
        'LabelHoras
        '
        Me.LabelHoras.BackColor = System.Drawing.Color.Transparent
        Me.LabelHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHoras.Location = New System.Drawing.Point(85, 80)
        Me.LabelHoras.Name = "LabelHoras"
        Me.LabelHoras.Size = New System.Drawing.Size(371, 80)
        Me.LabelHoras.TabIndex = 6
        Me.LabelHoras.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'minutoscombo
        '
        Me.minutoscombo.FormattingEnabled = True
        Me.minutoscombo.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.minutoscombo.Location = New System.Drawing.Point(189, 269)
        Me.minutoscombo.Name = "minutoscombo"
        Me.minutoscombo.Size = New System.Drawing.Size(64, 21)
        Me.minutoscombo.TabIndex = 7
        '
        'ComboBoxHora
        '
        Me.ComboBoxHora.FormattingEnabled = True
        Me.ComboBoxHora.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxHora.Location = New System.Drawing.Point(103, 269)
        Me.ComboBoxHora.Name = "ComboBoxHora"
        Me.ComboBoxHora.Size = New System.Drawing.Size(64, 21)
        Me.ComboBoxHora.TabIndex = 8
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnVolver.Font = New System.Drawing.Font("Zing Rust Demo Base", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnVolver.Location = New System.Drawing.Point(840, 328)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(109, 44)
        Me.BtnVolver.TabIndex = 9
        Me.BtnVolver.Text = "SALIR"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(160, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 19)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Hora de salida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(160, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Hora de entrada"
        '
        'Combopm
        '
        Me.Combopm.FormattingEnabled = True
        Me.Combopm.Items.AddRange(New Object() {"a.m.", "p.m."})
        Me.Combopm.Location = New System.Drawing.Point(281, 269)
        Me.Combopm.Name = "Combopm"
        Me.Combopm.Size = New System.Drawing.Size(64, 21)
        Me.Combopm.TabIndex = 70
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxNombre.Location = New System.Drawing.Point(514, 58)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxNombre.TabIndex = 71
        '
        'TextBoxApP
        '
        Me.TextBoxApP.Enabled = False
        Me.TextBoxApP.Location = New System.Drawing.Point(514, 96)
        Me.TextBoxApP.Name = "TextBoxApP"
        Me.TextBoxApP.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxApP.TabIndex = 72
        '
        'TextBoxApM
        '
        Me.TextBoxApM.Enabled = False
        Me.TextBoxApM.Location = New System.Drawing.Point(514, 136)
        Me.TextBoxApM.Name = "TextBoxApM"
        Me.TextBoxApM.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxApM.TabIndex = 73
        '
        'TextCURP
        '
        Me.TextCURP.Enabled = False
        Me.TextCURP.Location = New System.Drawing.Point(514, 172)
        Me.TextCURP.Name = "TextCURP"
        Me.TextCURP.Size = New System.Drawing.Size(142, 20)
        Me.TextCURP.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(434, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(403, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(403, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Apellido Materno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(451, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "CURP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(461, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "RFC"
        '
        'TextRFC
        '
        Me.TextRFC.Enabled = False
        Me.TextRFC.Location = New System.Drawing.Point(514, 209)
        Me.TextRFC.Name = "TextRFC"
        Me.TextRFC.Size = New System.Drawing.Size(142, 20)
        Me.TextRFC.TabIndex = 80
        '
        'TextCelular
        '
        Me.TextCelular.Enabled = False
        Me.TextCelular.Location = New System.Drawing.Point(775, 59)
        Me.TextCelular.Name = "TextCelular"
        Me.TextCelular.Size = New System.Drawing.Size(142, 20)
        Me.TextCelular.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(721, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Celular"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(721, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Correo"
        '
        'TextCorreo
        '
        Me.TextCorreo.Enabled = False
        Me.TextCorreo.Location = New System.Drawing.Point(776, 93)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(142, 20)
        Me.TextCorreo.TabIndex = 84
        '
        'TextDomicilio
        '
        Me.TextDomicilio.Enabled = False
        Me.TextDomicilio.Location = New System.Drawing.Point(514, 244)
        Me.TextDomicilio.Name = "TextDomicilio"
        Me.TextDomicilio.Size = New System.Drawing.Size(385, 20)
        Me.TextDomicilio.TabIndex = 91
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label14.Location = New System.Drawing.Point(434, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Domicilio"
        '
        'TextFechaNacimiento
        '
        Me.TextFechaNacimiento.Enabled = False
        Me.TextFechaNacimiento.Location = New System.Drawing.Point(514, 270)
        Me.TextFechaNacimiento.Name = "TextFechaNacimiento"
        Me.TextFechaNacimiento.Size = New System.Drawing.Size(65, 20)
        Me.TextFechaNacimiento.TabIndex = 93
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label15.Location = New System.Drawing.Point(386, 273)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 17)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Fecha de nacimiento"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Font = New System.Drawing.Font("Zing Rust Demo Base", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SeaShell
        Me.Button1.Location = New System.Drawing.Point(722, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 44)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "VOLVER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Location = New System.Drawing.Point(389, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 296)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del empleado"
        '
        'Agregar_Horas_Marco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(961, 384)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextFechaNacimiento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextDomicilio)
        Me.Controls.Add(Me.TextCorreo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextCelular)
        Me.Controls.Add(Me.TextRFC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextCURP)
        Me.Controls.Add(Me.TextBoxApM)
        Me.Controls.Add(Me.TextBoxApP)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Combopm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.ComboBoxHora)
        Me.Controls.Add(Me.minutoscombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelHoras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Horas_Marco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_Horas_Marco"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelHoras As Label
    Friend WithEvents minutoscombo As ComboBox
    Friend WithEvents ComboBoxHora As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Combopm As ComboBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApP As TextBox
    Friend WithEvents TextBoxApM As TextBox
    Friend WithEvents TextCURP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextRFC As TextBox
    Friend WithEvents TextCelular As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents TextDomicilio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextFechaNacimiento As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
