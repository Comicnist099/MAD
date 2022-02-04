<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Usuario2Marco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Usuario2Marco))
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnCarrito = New System.Windows.Forms.Button()
        Me.BtnModInfo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(441, 217)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(103, 30)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "Volver"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnCarrito
        '
        Me.BtnCarrito.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnCarrito.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarrito.ForeColor = System.Drawing.Color.White
        Me.BtnCarrito.Location = New System.Drawing.Point(307, 121)
        Me.BtnCarrito.Name = "BtnCarrito"
        Me.BtnCarrito.Size = New System.Drawing.Size(132, 81)
        Me.BtnCarrito.TabIndex = 13
        Me.BtnCarrito.Text = "Carrito"
        Me.BtnCarrito.UseVisualStyleBackColor = False
        '
        'BtnModInfo
        '
        Me.BtnModInfo.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnModInfo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModInfo.ForeColor = System.Drawing.Color.White
        Me.BtnModInfo.Location = New System.Drawing.Point(140, 121)
        Me.BtnModInfo.Name = "BtnModInfo"
        Me.BtnModInfo.Size = New System.Drawing.Size(132, 81)
        Me.BtnModInfo.TabIndex = 12
        Me.BtnModInfo.Text = "Modificar Información"
        Me.BtnModInfo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Zing Rust Demo Base", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(169, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Menu Usuario"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(441, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Menu_Usuario2Marco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(580, 259)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnCarrito)
        Me.Controls.Add(Me.BtnModInfo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu_Usuario2Marco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Usuario2Marco"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnCarrito As Button
    Friend WithEvents BtnModInfo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
