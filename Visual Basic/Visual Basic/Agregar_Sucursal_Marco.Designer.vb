<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Sucursal_Marco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Sucursal_Marco))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextDomicilioSucursal = New System.Windows.Forms.TextBox()
        Me.TextNameSucursal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEncargados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(98, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Encargado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(31, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 22)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Domicilio Completo:"
        '
        'TextDomicilioSucursal
        '
        Me.TextDomicilioSucursal.Location = New System.Drawing.Point(221, 168)
        Me.TextDomicilioSucursal.Multiline = True
        Me.TextDomicilioSucursal.Name = "TextDomicilioSucursal"
        Me.TextDomicilioSucursal.Size = New System.Drawing.Size(229, 75)
        Me.TextDomicilioSucursal.TabIndex = 51
        '
        'TextNameSucursal
        '
        Me.TextNameSucursal.Location = New System.Drawing.Point(221, 121)
        Me.TextNameSucursal.Name = "TextNameSucursal"
        Me.TextNameSucursal.Size = New System.Drawing.Size(229, 20)
        Me.TextNameSucursal.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(18, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 22)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Nombre de la sucursal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poplar Std", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(105, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(280, 57)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Agregar Sucursal"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnAceptar.Font = New System.Drawing.Font("Zing Rust Demo Base", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAceptar.Location = New System.Drawing.Point(149, 333)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(113, 40)
        Me.BtnAceptar.TabIndex = 55
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnVolver.Font = New System.Drawing.Font("Zing Rust Demo Base", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolver.Location = New System.Drawing.Point(309, 333)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(113, 40)
        Me.BtnVolver.TabIndex = 56
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(221, 273)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(229, 21)
        Me.ComboBox1.TabIndex = 57
        '
        'ComboBoxEncargados
        '
        Me.ComboBoxEncargados.FormattingEnabled = True
        Me.ComboBoxEncargados.Location = New System.Drawing.Point(576, 135)
        Me.ComboBoxEncargados.Name = "ComboBoxEncargados"
        Me.ComboBoxEncargados.Size = New System.Drawing.Size(214, 21)
        Me.ComboBoxEncargados.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(605, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Seleccione al encargado"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Peru
        Me.BtnEliminar.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminar.Location = New System.Drawing.Point(576, 172)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(102, 34)
        Me.BtnEliminar.TabIndex = 60
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'B
        '
        Me.B.BackColor = System.Drawing.Color.Peru
        Me.B.Font = New System.Drawing.Font("Zing Rust Demo Base", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.B.Location = New System.Drawing.Point(698, 172)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(92, 34)
        Me.B.TabIndex = 61
        Me.B.Text = "Modificar"
        Me.B.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(634, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poplar Std", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(529, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 42)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Modificar datos sucursal"
        '
        'Agregar_Sucursal_Marco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(858, 405)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxEncargados)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextDomicilioSucursal)
        Me.Controls.Add(Me.TextNameSucursal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Agregar_Sucursal_Marco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_Sucursal_Marco"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextDomicilioSucursal As TextBox
    Friend WithEvents TextNameSucursal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBoxEncargados As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents B As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
