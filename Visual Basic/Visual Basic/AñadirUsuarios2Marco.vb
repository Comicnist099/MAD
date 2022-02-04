Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AñadirUsuarios2Marco
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
        Dim clientes As New DataTable
        clientes = Enlace.GetClientes()

        Dim idusuario As Integer
        Enlace.AddUserLogin(TextName.Text, TextApellidoPaterno.Text, TextApellidoMaterno.Text, DateTimePicker1.Text, TextEmail.Text, TextDomicilio.Text, TextUsuario.Text, TextContraseña.Text, TextCURP.Text, TextCelular.Text, ComboBoxMetodoPago.Text)
        idusuario = Enlace.GetIdUsuario(TextUsuario.Text)
        Dim UsuarioData As LogInData = LogInData.Instance

        MessageBox.Show("Usuario dado de alta")

        ListBox1.Items.Clear()

        Dim clientes2 As New DataTable
        clientes2 = Enlace.GetClienteUsuarios()
        Dim cont As Integer = 1

        Dim rows As Integer = clientes2.Rows.Count
        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = clientes2.Rows.Item(cont - 1)
                cont = cont + 1
                ListBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


            End While


        End If





        Funciones.CleanTextBoxs(Me)




    End Sub

    Private Sub AñadirUsuarios2Marco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable
        clientes = Enlace.GetClienteUsuarios()
        Dim cont As Integer = 1

        Dim rows As Integer = clientes.Rows.Count
        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                cont = cont + 1
                ListBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


            End While


        End If
    End Sub


    Private Sub TextID_TextChanged(sender As Object, e As EventArgs)





    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If String.IsNullOrEmpty(TextName.Text) Or String.IsNullOrEmpty(TextEmail.Text) Or String.IsNullOrEmpty(TextContraseña.Text) Or String.IsNullOrEmpty(TextApellidoPaterno.Text) Or String.IsNullOrEmpty(TextApellidoMaterno.Text) Or String.IsNullOrEmpty(TextCURP.Text) Or String.IsNullOrEmpty(TextCelular.Text) Or String.IsNullOrEmpty(TextDomicilio.Text) Or String.IsNullOrEmpty(TextUsuario.Text) Then
            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim Enlace As New EnlaceBD
        Dim idUsuario As Integer = Enlace.GetIdUsuarioUsuarios(ListBox1.Text)
        Dim Usuario As DataRow = Enlace.GetUsuariosbyuser(idUsuario).Rows.Item(0)





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



        If String.IsNullOrEmpty(ListBox1.Text) Then
            MessageBox.Show("Coloque el nombre de usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Enlace.ModificarUsuario(idUsuario, TextName.Text, TextApellidoPaterno.Text, TextApellidoMaterno.Text, DateTimePicker1.Text, TextEmail.Text, TextDomicilio.Text, TextUsuario.Text, TextContraseña.Text, TextCURP.Text, TextCelular.Text, ComboBoxMetodoPago.Text)


        End If
        ListBox1.Items.Clear()

        Dim clientes As New DataTable
        clientes = Enlace.GetClienteUsuarios()
        Dim cont As Integer = 1

        Dim rows As Integer = clientes.Rows.Count
        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                cont = cont + 1
                ListBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


            End While


        End If


        MessageBox.Show("Usuario Modificado")


    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If String.IsNullOrEmpty(ListBox1.Text) Then
            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim Enlace As New EnlaceBD
        Dim idUsuario As Integer = Enlace.GetIdUsuarioUsuarios(ListBox1.Text)
        Dim empleado As DataRow = Enlace.GetUsuariosbyuser(idUsuario).Rows.Item(0)

        Dim answer As Integer

        answer = MsgBox("Estas seguro de querer eliminar a este usuario?", vbQuestion + vbYesNo + vbDefaultButton2, "Aviso")

        If answer = vbYes Then
            Enlace.EliminarUsuarios(idUsuario)


            ListBox1.Items.Clear()

            Dim clientes As New DataTable
            clientes = Enlace.GetClienteUsuarios()
            Dim cont As Integer = 1

            Dim rows As Integer = clientes.Rows.Count
            If rows > 0 Then
                While cont <= rows
                    Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                    cont = cont + 1
                    ListBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


                End While


            End If

        Else
            Exit Sub


        End If
        MessageBox.Show("Usuario Eliminado")

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged

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

    Private Sub TextApellidoMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextApellidoMaterno.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextCURP_TextChanged(sender As Object, e As EventArgs) Handles TextCURP.TextChanged

    End Sub

    Private Sub TextCelular_TextChanged(sender As Object, e As EventArgs) Handles TextCelular.TextChanged

    End Sub

    Private Sub ComboBoxMetodoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMetodoPago.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxMetodoPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxMetodoPago.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu_Usuario3Marco_Admin.Show()
        Me.Close()
    End Sub

    Private Sub TextCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCelular.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextDomicilio_TextChanged(sender As Object, e As EventArgs) Handles TextDomicilio.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            ' Nothing selected!
        Else

            Dim Enlace As New EnlaceBD


            Dim Nombre As String = ListBox1.SelectedItem()

            Dim Id_Producto As Integer = Enlace.GetIdUsuarioUsuarios(Nombre)

            Dim tempcliente As DataRow = Enlace.GetTODOSusuarios(Id_Producto).Rows.Item(0)


            Dim cont As Integer = 1
            Dim clientes As New DataTable
            clientes = Enlace.esUsuarioActivo(Nombre)

            Dim tempcliente2 As DataRow = clientes.Rows.Item(cont - 1)



            TextBoxNombre.Text = tempcliente("Nombre").ToString()
            TextBoxApP.Text = tempcliente("Apellido_P").ToString()
            TextBoxApM.Text = tempcliente("Apellido_M").ToString()
            TextBox3.Text = tempcliente("CURP").ToString()
            TextBox1.Text = tempcliente("Domicilio").ToString()
            TextFechaNacimiento.Text = tempcliente("Fecha_de_Nacimiento").ToString()
            TextBox2.Text = tempcliente("Celular").ToString()
            TextCorreo.Text = tempcliente("Correo").ToString()


        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub
End Class