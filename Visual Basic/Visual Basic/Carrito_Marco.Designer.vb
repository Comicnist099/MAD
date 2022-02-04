<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carrito_Marco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carrito_Marco))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(80, 110)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(178, 316)
        Me.ListBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(324, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(324, 202)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(675, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(111, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(686, 289)
        Me.TextBox4.MaxLength = 2
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(324, 252)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(252, 87)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(675, 202)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(111, 20)
        Me.TextBox6.TabIndex = 6
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Nombre.Location = New System.Drawing.Point(293, 128)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(58, 19)
        Me.Nombre.TabIndex = 8
        Me.Nombre.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(289, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Categoría"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(639, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(698, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(293, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Descripcion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(639, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Descuento"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button2.Font = New System.Drawing.Font("Zing Rust Demo Base", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(791, 433)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 54)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Ver carrito"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button3.Font = New System.Drawing.Font("Zing Rust Demo Base", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(798, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 45)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Atras"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Peru
        Me.Button4.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(502, 381)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 45)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Añadir al carrito"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Zing Rust Demo Base", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Peru
        Me.Label1.Location = New System.Drawing.Point(391, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 43)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Datos del producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Zing Rust Demo Base", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(85, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 55)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Carrito"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Carrito_Marco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(946, 499)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Carrito_Marco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carrito_Marco"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
