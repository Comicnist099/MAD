Public Class ModificarInformacionClienteMarco
    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If String.IsNullOrEmpty(TextNameMod.Text) Or String.IsNullOrEmpty(TextEmailMod.Text) Or String.IsNullOrEmpty(TextPasswordMod.Text) Or String.IsNullOrEmpty(TextApellidoPaternoMod.Text) Or String.IsNullOrEmpty(TextApellidoMaternoMod.Text) Or String.IsNullOrEmpty(TextCURPMod.Text) Or String.IsNullOrEmpty(TextCelularMod.Text) Or String.IsNullOrEmpty(TextDomicilioMod.Text) Or String.IsNullOrEmpty(TextUsuarioMod.Text) Then
            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim nombre As String = TextNameMod.Text
        Dim apellidoP As String = TextApellidoPaternoMod.Text
        Dim apellidoM As String = TextApellidoMaternoMod.Text
        Dim Nacimiento As String = DateTimePickerMod.Text
        Dim Correo As String = TextEmailMod.Text
        Dim Domicilio As String = TextDomicilioMod.Text
        Dim Usuario As String = TextUsuarioMod.Text
        Dim Contra As String = TextPasswordMod.Text
        Dim Curp As String = TextCURPMod.Text
        Dim cel As String = TextCelularMod.Text
        Dim metodo As String = ComboBoxMetodoPago.Text
        Dim Enlace As New EnlaceBD
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim idusuario As Integer = UsuarioData.getIdUsuario


        Enlace.ModificarUsuario2(idusuario, nombre, apellidoP, apellidoM, Nacimiento, Correo, Domicilio, Usuario, Contra, Curp, cel, metodo)


        MessageBox.Show("Se han modificado sus datos")
        Funciones.CleanTextBoxs(Me)

    End Sub

    Private Sub ModificarInformacionClienteMarco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Menu_Usuario2Marco.Show()
        Me.Close()
    End Sub

    Private Sub TextNameMod_TextChanged(sender As Object, e As EventArgs) Handles TextNameMod.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextRFCMod_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextCelularMod_TextChanged(sender As Object, e As EventArgs) Handles TextCelularMod.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextApellidoPaternoMod_TextChanged(sender As Object, e As EventArgs) Handles TextApellidoPaternoMod.TextChanged

    End Sub

    Private Sub DateTimePickerMod_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerMod.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class