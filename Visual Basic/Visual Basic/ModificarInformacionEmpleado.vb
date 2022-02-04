Imports System.Text.RegularExpressions
Public Class ModificarInformacionAdmin
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        If String.IsNullOrEmpty(TextName.Text) Or String.IsNullOrEmpty(TextEmail.Text) Or String.IsNullOrEmpty(TextContraseña.Text) Or String.IsNullOrEmpty(TextApellidoPaterno.Text) Or String.IsNullOrEmpty(TextApellidoMaterno.Text) Or String.IsNullOrEmpty(TextCURP.Text) Or String.IsNullOrEmpty(TextCelular.Text) Or String.IsNullOrEmpty(TextRFC.Text) Or String.IsNullOrEmpty(TextDomicilio.Text) Or String.IsNullOrEmpty(TextUsuario.Text) Then
            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextCelular.Text.Length < 8 Then

            MsgBox("Revise la escritura del telefono")
            Return
        End If

        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = regex.IsMatch(TextEmail.Text.Trim)
        If Not isvalid Then
            MessageBox.Show("Por favor revise la escritura del Correo")
        Else



            Dim UsuarioData As LogInData = LogInData.Instance

            Dim Enlace As New EnlaceBD
            Dim idempleado As Integer = UsuarioData.getIdUsuario()
            Dim empleado As DataRow = Enlace.GetUsuariosbyuser(idempleado).Rows.Item(0)
            Enlace.ModificarEmpleado(idempleado, TextName.Text, TextApellidoPaterno.Text, TextApellidoMaterno.Text, TextRFC.Text, DateTimePicker1.Text, ComboBoxAgregar.Text, TextEmail.Text, TextDomicilio.Text, TextUsuario.Text, TextContraseña.Text, TextCURP.Text, TextCelular.Text)

            MessageBox.Show("Se ha modificado el usuario")



        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu_UsuarioMarco.Show()
        Me.Close()
    End Sub

    Private Sub TextName_TextChanged(sender As Object, e As EventArgs) Handles TextName.TextChanged

    End Sub

    Private Sub TextName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextApellidoPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextApellidoPaterno.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextApellidoMaterno_TextChanged(sender As Object, e As EventArgs) Handles TextApellidoMaterno.TextChanged

    End Sub

    Private Sub TextApellidoMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextApellidoMaterno.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCelular.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextContraseña_TextChanged(sender As Object, e As EventArgs) Handles TextContraseña.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextCelular_TextChanged(sender As Object, e As EventArgs) Handles TextCelular.TextChanged

    End Sub
End Class