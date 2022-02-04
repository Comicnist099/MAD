Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class AñadirUsuariosLogin
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        LoginMarco.Show()
        Me.Close()
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        If String.IsNullOrEmpty(TextName.Text) Or String.IsNullOrEmpty(TextEmail.Text) Or String.IsNullOrEmpty(TextContraseña.Text) Or String.IsNullOrEmpty(TextApellidoPaterno.Text) Or String.IsNullOrEmpty(TextApellidoMaterno.Text) Or String.IsNullOrEmpty(TextCURP.Text) Or String.IsNullOrEmpty(TextCelular.Text) Or String.IsNullOrEmpty(TextDomicilio.Text) Or String.IsNullOrEmpty(TextUsuario.Text) Then
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
            Return
        End If

        Dim Enlace As New EnlaceBD


        Dim idusuario As Integer
        Enlace.AddUserLogin(TextName.Text, TextApellidoPaterno.Text, TextApellidoMaterno.Text, DateTimePicker1.Text, TextEmail.Text, TextDomicilio.Text, TextUsuario.Text, TextContraseña.Text, TextCURP.Text, TextCelular.Text, ComboBoxMetodoPago.Text)
        idusuario = Enlace.GetIdUsuario(TextUsuario.Text)
        Dim UsuarioData As LogInData = LogInData.Instance

        MessageBox.Show("Usuario dado de alta")
        Funciones.CleanTextBoxs(Me)

    End Sub

    Private Sub TextName_TextChanged(sender As Object, e As EventArgs) Handles TextName.TextChanged

    End Sub

    Private Sub ComboBoxMetodoPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxMetodoPago.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged

    End Sub

    Private Sub TextApellidoPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextApellidoPaterno.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextApellidoMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextApellidoMaterno.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBoxMetodoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMetodoPago.SelectedIndexChanged

    End Sub

    Private Sub TextCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCelular.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextCelular_TextChanged(sender As Object, e As EventArgs) Handles TextCelular.TextChanged

    End Sub
End Class