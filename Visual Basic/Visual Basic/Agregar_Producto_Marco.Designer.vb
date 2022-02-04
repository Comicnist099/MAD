<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agregar_Producto_Marco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Producto_Marco))
        Me.ButtonAceptarPrd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextDescuento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextNameProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonAtrasProducto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonAceptarPrd
        '
        Me.ButtonAceptarPrd.BackColor = System.Drawing.Color.SaddleBrown
        Me.ButtonAceptarPrd.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptarPrd.ForeColor = System.Drawing.Color.SeaShell
        Me.ButtonAceptarPrd.Location = New System.Drawing.Point(111, 404)
        Me.ButtonAceptarPrd.Name = "ButtonAceptarPrd"
        Me.ButtonAceptarPrd.Size = New System.Drawing.Size(119, 36)
        Me.ButtonAceptarPrd.TabIndex = 67
        Me.ButtonAceptarPrd.Text = "Aceptar"
        Me.ButtonAceptarPrd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(309, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 22)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "%"
        '
        'TextDescuento
        '
        Me.TextDescuento.Location = New System.Drawing.Point(136, 341)
        Me.TextDescuento.MaxLength = 2
        Me.TextDescuento.Name = "TextDescuento"
        Me.TextDescuento.Size = New System.Drawing.Size(167, 20)
        Me.TextDescuento.TabIndex = 63
        Me.TextDescuento.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(19, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Descuento:"
        '
        'TextCategoria
        '
        Me.TextCategoria.Location = New System.Drawing.Point(136, 171)
        Me.TextCategoria.Name = "TextCategoria"
        Me.TextCategoria.Size = New System.Drawing.Size(167, 20)
        Me.TextCategoria.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(25, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Categoría:"
        '
        'Textdescripcion
        '
        Me.Textdescripcion.Location = New System.Drawing.Point(136, 207)
        Me.Textdescripcion.Multiline = True
        Me.Textdescripcion.Name = "Textdescripcion"
        Me.Textdescripcion.Size = New System.Drawing.Size(167, 62)
        Me.Textdescripcion.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(13, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 22)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Descripción:"
        '
        'TextNameProducto
        '
        Me.TextNameProducto.Location = New System.Drawing.Point(136, 139)
        Me.TextNameProducto.Name = "TextNameProducto"
        Me.TextNameProducto.Size = New System.Drawing.Size(167, 20)
        Me.TextNameProducto.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(36, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poplar Std", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(247, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(371, 76)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Agregar producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(35, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 22)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Precio:"
        '
        'TextPrecio
        '
        Me.TextPrecio.Location = New System.Drawing.Point(136, 291)
        Me.TextPrecio.Name = "TextPrecio"
        Me.TextPrecio.Size = New System.Drawing.Size(167, 20)
        Me.TextPrecio.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(107, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 22)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "$"
        '
        'ButtonAtrasProducto
        '
        Me.ButtonAtrasProducto.BackColor = System.Drawing.Color.SaddleBrown
        Me.ButtonAtrasProducto.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAtrasProducto.ForeColor = System.Drawing.Color.SeaShell
        Me.ButtonAtrasProducto.Location = New System.Drawing.Point(745, 53)
        Me.ButtonAtrasProducto.Name = "ButtonAtrasProducto"
        Me.ButtonAtrasProducto.Size = New System.Drawing.Size(119, 36)
        Me.ButtonAtrasProducto.TabIndex = 68
        Me.ButtonAtrasProducto.Text = "Atras"
        Me.ButtonAtrasProducto.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Location = New System.Drawing.Point(356, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 307)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del inventario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(397, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 22)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Inventario:"
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnModificar.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Snow
        Me.BtnModificar.Location = New System.Drawing.Point(561, 348)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(119, 36)
        Me.BtnModificar.TabIndex = 74
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnEliminar.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.SeaShell
        Me.BtnEliminar.Location = New System.Drawing.Point(712, 348)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(119, 36)
        Me.BtnEliminar.TabIndex = 76
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(554, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 20)
        Me.TextBox1.TabIndex = 78
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(707, 201)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 20)
        Me.TextBox2.TabIndex = 79
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(548, 292)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 20)
        Me.TextBox3.TabIndex = 80
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(378, 176)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 160)
        Me.ListBox1.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(713, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 19)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Categoria:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label11.Location = New System.Drawing.Point(557, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 19)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Nombre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label12.Location = New System.Drawing.Point(550, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 19)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Precio $:"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(707, 292)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 20)
        Me.TextBox4.TabIndex = 85
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label13.Location = New System.Drawing.Point(709, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 19)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Descuento %:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label14.Location = New System.Drawing.Point(35, 360)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 16)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "(opcional)"
        '
        'Agregar_Producto_Marco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(893, 499)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextPrecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonAtrasProducto)
        Me.Controls.Add(Me.ButtonAceptarPrd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextDescuento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextCategoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Textdescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextNameProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Producto_Marco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_Producto_Marco"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAceptarPrd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextDescuento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Textdescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNameProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonAtrasProducto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
