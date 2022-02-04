<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baneos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Baneos))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextDomicilio = New System.Windows.Forms.TextBox()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextCelular = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextCURP = New System.Windows.Forms.TextBox()
        Me.TextBoxApM = New System.Windows.Forms.TextBox()
        Me.TextBoxApP = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextEstado = New System.Windows.Forms.TextBox()
        Me.BtnBaneado = New System.Windows.Forms.Button()
        Me.BrnDesvanear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(27, 134)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(171, 329)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Font = New System.Drawing.Font("Zing Rust Demo Base", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SeaShell
        Me.Button1.Location = New System.Drawing.Point(658, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 44)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "VOLVER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Peru
        Me.Label15.Location = New System.Drawing.Point(525, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 23)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Fecha de nacimiento"
        '
        'TextFechaNacimiento
        '
        Me.TextFechaNacimiento.Enabled = False
        Me.TextFechaNacimiento.Location = New System.Drawing.Point(686, 270)
        Me.TextFechaNacimiento.Name = "TextFechaNacimiento"
        Me.TextFechaNacimiento.Size = New System.Drawing.Size(65, 20)
        Me.TextFechaNacimiento.TabIndex = 114
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Peru
        Me.Label14.Location = New System.Drawing.Point(528, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 23)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Domicilio"
        '
        'TextDomicilio
        '
        Me.TextDomicilio.Enabled = False
        Me.TextDomicilio.Location = New System.Drawing.Point(613, 216)
        Me.TextDomicilio.Multiline = True
        Me.TextDomicilio.Name = "TextDomicilio"
        Me.TextDomicilio.Size = New System.Drawing.Size(138, 39)
        Me.TextDomicilio.TabIndex = 112
        '
        'TextCorreo
        '
        Me.TextCorreo.Enabled = False
        Me.TextCorreo.Location = New System.Drawing.Point(613, 174)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(142, 20)
        Me.TextCorreo.TabIndex = 111
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Peru
        Me.Label10.Location = New System.Drawing.Point(543, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 23)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Peru
        Me.Label8.Location = New System.Drawing.Point(539, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 23)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Celular"
        '
        'TextCelular
        '
        Me.TextCelular.Enabled = False
        Me.TextCelular.Location = New System.Drawing.Point(612, 140)
        Me.TextCelular.Name = "TextCelular"
        Me.TextCelular.Size = New System.Drawing.Size(142, 20)
        Me.TextCelular.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Peru
        Me.Label6.Location = New System.Drawing.Point(281, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 23)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "CURP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Peru
        Me.Label5.Location = New System.Drawing.Point(213, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Apellido Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(213, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Peru
        Me.Label2.Location = New System.Drawing.Point(261, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Nombre"
        '
        'TextCURP
        '
        Me.TextCURP.Enabled = False
        Me.TextCURP.Location = New System.Drawing.Point(351, 265)
        Me.TextCURP.Name = "TextCURP"
        Me.TextCURP.Size = New System.Drawing.Size(142, 20)
        Me.TextCURP.TabIndex = 101
        '
        'TextBoxApM
        '
        Me.TextBoxApM.Enabled = False
        Me.TextBoxApM.Location = New System.Drawing.Point(351, 217)
        Me.TextBoxApM.Name = "TextBoxApM"
        Me.TextBoxApM.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxApM.TabIndex = 100
        '
        'TextBoxApP
        '
        Me.TextBoxApP.Enabled = False
        Me.TextBoxApP.Location = New System.Drawing.Point(351, 177)
        Me.TextBoxApP.Name = "TextBoxApP"
        Me.TextBoxApP.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxApP.TabIndex = 99
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxNombre.Location = New System.Drawing.Point(351, 139)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxNombre.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Zing Rust Demo Base", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(184, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 64)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Baneos (usuarios)"
        '
        'TextEstado
        '
        Me.TextEstado.Enabled = False
        Me.TextEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEstado.Location = New System.Drawing.Point(385, 361)
        Me.TextEstado.Name = "TextEstado"
        Me.TextEstado.Size = New System.Drawing.Size(142, 31)
        Me.TextEstado.TabIndex = 118
        '
        'BtnBaneado
        '
        Me.BtnBaneado.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnBaneado.Font = New System.Drawing.Font("Zing Rust Demo Base", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBaneado.ForeColor = System.Drawing.Color.SeaShell
        Me.BtnBaneado.Location = New System.Drawing.Point(312, 398)
        Me.BtnBaneado.Name = "BtnBaneado"
        Me.BtnBaneado.Size = New System.Drawing.Size(125, 44)
        Me.BtnBaneado.TabIndex = 120
        Me.BtnBaneado.Text = "Banear"
        Me.BtnBaneado.UseVisualStyleBackColor = False
        '
        'BrnDesvanear
        '
        Me.BrnDesvanear.BackColor = System.Drawing.Color.SaddleBrown
        Me.BrnDesvanear.Font = New System.Drawing.Font("Zing Rust Demo Base", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrnDesvanear.ForeColor = System.Drawing.Color.SeaShell
        Me.BrnDesvanear.Location = New System.Drawing.Point(472, 398)
        Me.BrnDesvanear.Name = "BrnDesvanear"
        Me.BrnDesvanear.Size = New System.Drawing.Size(121, 44)
        Me.BrnDesvanear.TabIndex = 121
        Me.BrnDesvanear.Text = "Desbanear"
        Me.BrnDesvanear.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Zing Rust Demo Base", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Peru
        Me.Label7.Location = New System.Drawing.Point(46, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 35)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Usuarios "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Zing Rust Demo Base", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(403, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 39)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Estado"
        '
        'Baneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(811, 501)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BrnDesvanear)
        Me.Controls.Add(Me.BtnBaneado)
        Me.Controls.Add(Me.TextEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextFechaNacimiento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextDomicilio)
        Me.Controls.Add(Me.TextCorreo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextCelular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextCURP)
        Me.Controls.Add(Me.TextBoxApM)
        Me.Controls.Add(Me.TextBoxApP)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Baneos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baneos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TextFechaNacimiento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextDomicilio As TextBox
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextCelular As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextCURP As TextBox
    Friend WithEvents TextBoxApM As TextBox
    Friend WithEvents TextBoxApP As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextEstado As TextBox
    Friend WithEvents BtnBaneado As Button
    Friend WithEvents BrnDesvanear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
End Class
