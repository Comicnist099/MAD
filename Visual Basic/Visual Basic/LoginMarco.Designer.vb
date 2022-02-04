<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginMarco
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginMarco))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBoxRecordarme = New System.Windows.Forms.CheckBox()
        Me.LinkCrearCuenta = New System.Windows.Forms.LinkLabel()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(296, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 26)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Entrar como:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Empleado", "Cliente"})
        Me.ComboBox1.Location = New System.Drawing.Point(265, 309)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'CheckBoxRecordarme
        '
        Me.CheckBoxRecordarme.AutoSize = True
        Me.CheckBoxRecordarme.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRecordarme.Location = New System.Drawing.Point(207, 450)
        Me.CheckBoxRecordarme.Name = "CheckBoxRecordarme"
        Me.CheckBoxRecordarme.Size = New System.Drawing.Size(121, 25)
        Me.CheckBoxRecordarme.TabIndex = 18
        Me.CheckBoxRecordarme.Text = "Recordarme"
        Me.CheckBoxRecordarme.UseVisualStyleBackColor = True
        '
        'LinkCrearCuenta
        '
        Me.LinkCrearCuenta.AutoSize = True
        Me.LinkCrearCuenta.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkCrearCuenta.Location = New System.Drawing.Point(396, 454)
        Me.LinkCrearCuenta.Name = "LinkCrearCuenta"
        Me.LinkCrearCuenta.Size = New System.Drawing.Size(141, 21)
        Me.LinkCrearCuenta.TabIndex = 17
        Me.LinkCrearCuenta.TabStop = True
        Me.LinkCrearCuenta.Text = "No tiene cuenta?"
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.BackColor = System.Drawing.Color.SaddleBrown
        Me.ButtonIngresar.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIngresar.ForeColor = System.Drawing.Color.SeaShell
        Me.ButtonIngresar.Location = New System.Drawing.Point(274, 512)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(165, 57)
        Me.ButtonIngresar.TabIndex = 16
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = False
        '
        'TextPassword
        '
        Me.TextPassword.Location = New System.Drawing.Point(282, 416)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(255, 20)
        Me.TextPassword.TabIndex = 15
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(282, 369)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(255, 20)
        Me.TextUsuario.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(148, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poplar Std", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(152, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 57)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SUPERTIENDAS MARCO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(182, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(207, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'LoginMarco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(746, 590)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBoxRecordarme)
        Me.Controls.Add(Me.LinkCrearCuenta)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginMarco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginMarco"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBoxRecordarme As CheckBox
    Friend WithEvents LinkCrearCuenta As LinkLabel
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
