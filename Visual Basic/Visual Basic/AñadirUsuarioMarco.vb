Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class AñadirUsuarioMarco
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextUsuario.TextChanged

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim Enlace As New EnlaceBD

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


            Dim clientes As New DataTable
            clientes = Enlace.GetClientes()
            Dim cont As Integer = 1

            Dim rows As Integer = clientes.Rows.Count
            If rows > 0 Then
                ''While cont <= rows
                ''  Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                '' cont = cont + 1
                ''   If pcliente("Usuario").ToString() = TextName.Text Or tempcliente("ID").ToString() = TextCURP.Text Then
                ''  MessageBox.Show("usuario en uso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '' Return


                ''End If

                '' End While


            End If
            Dim idusuario As Integer
            Enlace.AddEmpleado(TextName.Text, TextApellidoPaterno.Text, TextApellidoMaterno.Text, TextRFC.Text, DateTimePicker1.Text, ComboBoxAgregar.Text, TextEmail.Text, TextDomicilio.Text, TextUsuario.Text, TextContraseña.Text, TextCURP.Text, TextCelular.Text)

            idusuario = Enlace.GetIdUsuario(TextUsuario.Text)
            Dim UsuarioData As LogInData = LogInData.Instance
            If UsuarioData.getAccessLevel = True Then
                Menu_Usuario3Marco_Admin.Show()
                Me.Close()
            Else
                '  menu_empleado.Show()
                ' Me.Close()


            End If
            MessageBox.Show("Usuario dado de alta")
            Funciones.CleanTextBoxs(Me)


        End If

        ListBox1.Items.Clear()
        Dim clientes2 As New DataTable
        clientes2 = Enlace.GetClientes()
        Dim cont2 As Integer = 1

        Dim rows2 As Integer = clientes2.Rows.Count
        If rows2 > 0 Then
            While cont2 <= rows2
                Dim tempcliente As DataRow = clientes2.Rows.Item(cont2 - 1)
                cont2 = cont2 + 1

                ListBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


            End While

            Funciones.CleanTextBoxs(Me)
        End If


    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Menu_Usuario3Marco_Admin.Show()
        Me.Close()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If String.IsNullOrEmpty(ListBox1.Text) Then
            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim Enlace As New EnlaceBD



        Dim answer As Integer

        answer = MsgBox("Estas seguro de querer eliminar a este usuario?", vbQuestion + vbYesNo + vbDefaultButton2, "Aviso")

        If answer = vbYes Then

            Dim idempleado As Integer = Enlace.GetIdUsuario(ListBox1.Text)
            Dim empleado As DataRow = Enlace.GetEmpleadobyuser(idempleado).Rows.Item(0)
            Enlace.EliminarEmpleados(idempleado)


            Dim clientes As New DataTable
            clientes = Enlace.GetClientes()
            Dim cont As Integer = 1
            Dim rows As Integer = clientes.Rows.Count
            ListBox1.Items.Clear()
            If rows > 0 Then
                While cont <= rows
                    Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                    cont = cont + 1

                    ListBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


                End While

                MessageBox.Show("Empleado eliminado")
            End If


        Else
            Exit Sub


        End If



    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
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




            Dim Enlace As New EnlaceBD
            Dim idempleado As Integer = Enlace.GetIdUsuario(ListBox1.Text)
            Dim empleado As DataRow = Enlace.GetUsuariosbyuser(idempleado).Rows.Item(0)


            If String.IsNullOrEmpty(ListBox1.Text) Then
                MessageBox.Show("Coloque la id del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Enlace.ModificarEmpleado(idempleado, TextName.Text, TextApellidoPaterno.Text, TextApellidoMaterno.Text, TextRFC.Text, DateTimePicker1.Text, ComboBoxAgregar.Text, TextEmail.Text, TextDomicilio.Text, TextUsuario.Text, TextContraseña.Text, TextCURP.Text, TextCelular.Text)


            End If

            ListBox1.Items.Clear()
            Dim clientes As New DataTable
            clientes = Enlace.GetClientes()
            Dim cont As Integer = 1

            Dim rows As Integer = clientes.Rows.Count
            If rows > 0 Then
                While cont <= rows
                    Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                    cont = cont + 1

                    ListBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


                End While

                MessageBox.Show("Empleado modificado")
                Funciones.CleanTextBoxs(Me)
            End If
        End If


    End Sub

    Private Sub BtnMostrarEmpleados_Click(sender As Object, e As EventArgs)

        ListBox1.Items.Clear()
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable
        clientes = Enlace.GetClientes()
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btcMostrarUsuario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AñadirUsuarioMarco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable
        clientes = Enlace.GetClientes()
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

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub ComboBoxAgregar_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxAgregar.KeyDown
        e.Handled = True
    End Sub

    Private Sub AñadirUsuarioMarco_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        e.Handled = True
    End Sub

    Private Sub TextCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCelular.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxAgregar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAgregar.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxAgregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxAgregar.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextName.KeyDown

    End Sub

    Private Sub TextCelular_TextChanged(sender As Object, e As EventArgs) Handles TextCelular.TextChanged

    End Sub

    Private Sub TextRFC_TextChanged(sender As Object, e As EventArgs) Handles TextRFC.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            ' Nothing selected!
        Else

            Dim Nombre As String = ListBox1.SelectedItem()


            Dim Enlace As New EnlaceBD
            Dim UsuarioData As LogInData = LogInData.Instance

            Dim id_Empleado As Integer = Enlace.GetIdUsuario(Nombre)
            Dim Dato As DataTable = Enlace.GetEmpleadosbyName(id_Empleado)
            Dim tempcliente As DataRow = Dato.Rows.Item(0)


            Dim cont As Integer = 1
            Dim clientes As New DataTable
            clientes = Enlace.esEmpladosActivo(Nombre)


            Dim tempcliente2 As DataRow = clientes.Rows.Item(cont - 1)



            TextBoxNombre.Text = tempcliente("Nombre").ToString()
            TextBoxApP.Text = tempcliente("Apellido_P").ToString()
            TextBoxApM.Text = tempcliente("Apellido_M").ToString()
            TextBox4.Text = tempcliente("CURP").ToString()
            TextBox1.Text = tempcliente("RFC").ToString()
            TextBox2.Text = tempcliente("Domicilio").ToString()
            TextFechaNacimiento.Text = tempcliente("Fecha_de_Nacimiento").ToString()
            TextBox3.Text = tempcliente("Celular").ToString()
            TextCorreo.Text = tempcliente("Correo").ToString()




        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextName_TextChanged(sender As Object, e As EventArgs) Handles TextName.TextChanged

    End Sub
End Class