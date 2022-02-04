<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_de_Carrito_y_Horas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_de_Carrito_y_Horas))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poplar Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(69, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(298, 38)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Reporte de horas trabajadas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poplar Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(497, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 38)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Reporte de productos de carrito"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(66, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(291, 262)
        Me.DataGridView1.TabIndex = 118
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(515, 104)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(291, 262)
        Me.DataGridView2.TabIndex = 119
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.SaddleBrown
        Me.ButtonAgregar.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonAgregar.Location = New System.Drawing.Point(132, 372)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(143, 66)
        Me.ButtonAgregar.TabIndex = 120
        Me.ButtonAgregar.Text = "Imprimir reporte de horas"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(592, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 66)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Imprimir reporte de productos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Peru
        Me.Button2.Font = New System.Drawing.Font("Zing Rust Demo Base", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(373, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 54)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Reporte_de_Carrito_y_Horas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(901, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reporte_de_Carrito_y_Horas"
        Me.Text = "Reporte_de_Carrito_y_Horas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
