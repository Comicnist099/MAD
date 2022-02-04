Public Class Agregar_Horas_Marco
    Private Sub Agregar_Horas_Marco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Enlace As New EnlaceBD
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim fk_Empleado As Integer = UsuarioData.getIdUsuario()
        Dim Dato As DataTable = Enlace.GetEmpleadosDatos(fk_Empleado)
        Dim tempcliente As DataRow = Dato.Rows.Item(0)
        TextBoxNombre.Text = tempcliente("Nombre").ToString()
        TextBoxApP.Text = tempcliente("Apellido_P").ToString()
        TextBoxApM.Text = tempcliente("Apellido_M").ToString()
        TextCURP.Text = tempcliente("CURP").ToString()
        TextRFC.Text = tempcliente("RFC").ToString()
        TextDomicilio.Text = tempcliente("Domicilio").ToString()
        TextFechaNacimiento.Text = tempcliente("Fecha_de_Nacimiento").ToString()
        TextCelular.Text = tempcliente("Celular").ToString()
        TextCorreo.Text = tempcliente("Correo").ToString()





        'Dim count As Integer = 0
        'While count < 60
        'minutoscombo.Items.Add(count)
        'count = count + 1

        'End While

        'Dim count2 As Integer = 0
        'While count2 < 24
        'ComboBoxHora.Items.Add(count2)
        'count2 = count2 + 1

        'End While


    End Sub

    Private Sub ComboBoxHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxHora.SelectedIndexChanged

    End Sub

    Private Sub LabelHoras_Click(sender As Object, e As EventArgs) Handles LabelHoras.Click

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click

        If String.IsNullOrEmpty(ComboBoxHora.Text) Or String.IsNullOrEmpty(minutoscombo.Text) Or String.IsNullOrEmpty(Combopm.Text) Then

            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If
        Dim TemHoraSalida = LabelHoras.Text
        Dim Enlace As New EnlaceBD
        Dim TemHoraEntradaCompleta = ComboBoxHora.Text + ":" + minutoscombo.Text + ":00 " + Combopm.Text



        Dim UsuarioData As LogInData = LogInData.Instance
        Dim fk_Empleado As Integer = UsuarioData.getIdUsuario()
        Enlace.GetEmpleadosDatos(fk_Empleado)

        'Dim idProducto As Integer
        Enlace.AddHoras(fk_Empleado, TemHoraEntradaCompleta, TemHoraSalida)
        'idProducto = Enlace.GetIdUsuario(TextUsuario.Text)
        Dim UsuarioData2 As LogInData = LogInData.Instance

        MessageBox.Show("Tenga un Excelente día gracias por trabajar con Tiendas Marco  ", "Horas Trabajadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)




        LoginMarco.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelHoras.Text = TimeOfDay


    End Sub

    Private Sub Agregar_Horas_Marco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress





    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub TextBoxApM_TextChanged(sender As Object, e As EventArgs) Handles TextBoxApM.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UsuarioData As LogInData = LogInData.Instance
        Funciones.CleanTextBoxs(Me)

        If UsuarioData.getPuesto() = "Admin" Then

            Menu_Usuario3Marco_Admin.Show()
        Else
            Menu_UsuarioMarco.Show()
        End If
        Me.Close()
    End Sub

    Private Sub BtnRegistrarHora_Click(sender As Object, e As EventArgs)

    End Sub
End Class