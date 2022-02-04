<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_UsuarioMarco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_UsuarioMarco))
        Me.BtnModInfo = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnCargaProductos = New System.Windows.Forms.Button()
        Me.BtnCatalogo = New System.Windows.Forms.Button()
        Me.BtnABCSucursales = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnModInfo
        '
        Me.BtnModInfo.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnModInfo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModInfo.ForeColor = System.Drawing.Color.White
        Me.BtnModInfo.Location = New System.Drawing.Point(104, 147)
        Me.BtnModInfo.Name = "BtnModInfo"
        Me.BtnModInfo.Size = New System.Drawing.Size(114, 72)
        Me.BtnModInfo.TabIndex = 4
        Me.BtnModInfo.Text = "Modificar Información"
        Me.BtnModInfo.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Peru
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(543, 346)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(120, 43)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "Volver"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnCargaProductos
        '
        Me.BtnCargaProductos.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnCargaProductos.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargaProductos.ForeColor = System.Drawing.Color.White
        Me.BtnCargaProductos.Location = New System.Drawing.Point(275, 147)
        Me.BtnCargaProductos.Name = "BtnCargaProductos"
        Me.BtnCargaProductos.Size = New System.Drawing.Size(117, 72)
        Me.BtnCargaProductos.TabIndex = 8
        Me.BtnCargaProductos.Text = "Cargar de productos"
        Me.BtnCargaProductos.UseVisualStyleBackColor = False
        '
        'BtnCatalogo
        '
        Me.BtnCatalogo.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnCatalogo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatalogo.ForeColor = System.Drawing.Color.White
        Me.BtnCatalogo.Location = New System.Drawing.Point(362, 249)
        Me.BtnCatalogo.Name = "BtnCatalogo"
        Me.BtnCatalogo.Size = New System.Drawing.Size(114, 73)
        Me.BtnCatalogo.TabIndex = 9
        Me.BtnCatalogo.Text = "Carga Masiva de productos"
        Me.BtnCatalogo.UseVisualStyleBackColor = False
        '
        'BtnABCSucursales
        '
        Me.BtnABCSucursales.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnABCSucursales.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnABCSucursales.ForeColor = System.Drawing.Color.White
        Me.BtnABCSucursales.Location = New System.Drawing.Point(191, 249)
        Me.BtnABCSucursales.Name = "BtnABCSucursales"
        Me.BtnABCSucursales.Size = New System.Drawing.Size(117, 72)
        Me.BtnABCSucursales.TabIndex = 10
        Me.BtnABCSucursales.Text = "ABC Sucursales"
        Me.BtnABCSucursales.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(543, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 74)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Zing Rust Demo Base", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(141, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 64)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Menu empleados"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(447, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 72)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Carga Masiva Sucursales"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Menu_UsuarioMarco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(689, 401)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnABCSucursales)
        Me.Controls.Add(Me.BtnCatalogo)
        Me.Controls.Add(Me.BtnCargaProductos)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnModInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu_UsuarioMarco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnModInfo As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnCargaProductos As Button
    Friend WithEvents BtnCatalogo As Button
    Friend WithEvents BtnABCSucursales As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
