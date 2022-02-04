Public Class Agregar_Sucursal_Marco
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        If String.IsNullOrEmpty(TextNameSucursal.Text) Or String.IsNullOrEmpty(TextDomicilioSucursal.Text) Or String.IsNullOrEmpty(ComboBox1.Text) Then
            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        Dim Enlace As New EnlaceBD
        Dim Sucursal As New DataTable
        Sucursal = Enlace.GetSucursal()
        Dim cont As Integer = 1
        Dim idempleado As Integer = Enlace.GetIdUsuario(ComboBox1.Text)
        Dim empleado As DataRow = Enlace.GetUsuariosbyuser(idempleado).Rows.Item(0)

        Dim UsuarioData As LogInData = LogInData.Instance
        Dim fk_Empleado As Integer = UsuarioData.getIdUsuario()
        'Dim idProducto As Integer
        Enlace.AddSucursal(fk_Empleado, TextNameSucursal.Text, TextDomicilioSucursal.Text, idempleado)
        'idProducto = Enlace.GetIdUsuario(TextUsuario.Text)
        Dim UsuarioData2 As LogInData = LogInData.Instance
        MessageBox.Show("Se ha agregado sucursal")


        ComboBoxEncargados.Items.Clear()
        Dim clientes2 As New DataTable
        clientes2 = Enlace.GetSucursal()
        Dim cont2 As Integer = 1

        Dim rows2 As Integer = clientes2.Rows.Count
        If rows2 > 0 Then
            While cont2 <= rows2
                Dim tempcliente As DataRow = clientes2.Rows.Item(cont2 - 1)
                cont2 = cont2 + 1
                ComboBoxEncargados.Items.Add(tempcliente("Nombre").ToString())


            End While

        End If

    End Sub

    Private Sub Agregar_Sucursal_Marco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable
        clientes = Enlace.GetClientes()
        Dim cont As Integer = 1

        Dim rows As Integer = clientes.Rows.Count
        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                cont = cont + 1
                ComboBox1.Items.Add(tempcliente("Nombre_Usuario").ToString())


            End While
        End If



        Dim clientes2 As New DataTable
        clientes2 = Enlace.GetSucursal()
        Dim cont2 As Integer = 1

        Dim rows2 As Integer = clientes2.Rows.Count
        If rows2 > 0 Then
            While cont2 <= rows2
                Dim tempcliente As DataRow = clientes2.Rows.Item(cont2 - 1)
                cont2 = cont2 + 1
                ComboBoxEncargados.Items.Add(tempcliente("Nombre").ToString())


            End While


        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Enlace As New EnlaceBD
        Dim Id_Sucursal As Integer = Enlace.GetIDSucursal(ComboBoxEncargados.Text)
        Dim NombreSucursal As DataRow = Enlace.GetSucursal2(Id_Sucursal).Rows.Item(0)

        Dim answer As Integer

        answer = MsgBox("Estas seguro de querer eliminar la sucursal?", vbQuestion + vbYesNo + vbDefaultButton2, "Aviso")
        If answer = vbYes Then
            If String.IsNullOrEmpty(ComboBoxEncargados.Text) Then
                MessageBox.Show("Coloque el nombre de la sucursal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Enlace.EliminarSucursal(Id_Sucursal)

            End If
            ComboBox1.Items.Clear()

        Else
            Exit Sub
        End If


        ComboBoxEncargados.Items.Clear()


        Dim clientes2 As New DataTable
        clientes2 = Enlace.GetSucursal()
        Dim cont2 As Integer = 1

        Dim rows2 As Integer = clientes2.Rows.Count
        If rows2 > 0 Then
            While cont2 <= rows2
                Dim tempcliente As DataRow = clientes2.Rows.Item(cont2 - 1)
                cont2 = cont2 + 1
                ComboBoxEncargados.Items.Add(tempcliente("Nombre").ToString())


            End While


        End If




    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        If String.IsNullOrEmpty(TextNameSucursal.Text) Or String.IsNullOrEmpty(TextDomicilioSucursal.Text) Or String.IsNullOrEmpty(ComboBox1.Text) Then
            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim Enlace As New EnlaceBD
        Dim Id_Sucursal As Integer = Enlace.GetIDSucursal(ComboBoxEncargados.Text)
        Dim NombreSucursal As DataRow = Enlace.GetSucursal2(Id_Sucursal).Rows.Item(0)

        Dim idempleado As Integer = Enlace.GetIdUsuario(ComboBox1.Text)
        Dim empleado As DataRow = Enlace.GetUsuariosbyuser(idempleado).Rows.Item(0)

        Dim UsuarioData As LogInData = LogInData.Instance
        Dim fk_Empleado As Integer = UsuarioData.getIdUsuario()

        If String.IsNullOrEmpty(ComboBoxEncargados.Text) Then
            MessageBox.Show("Coloque el nombre de la sucursal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Enlace.ModificarSucursal(idempleado, TextNameSucursal.Text, TextDomicilioSucursal.Text, fk_Empleado, Id_Sucursal)

        End If



        ComboBoxEncargados.Items.Clear()


        Dim clientes2 As New DataTable
        clientes2 = Enlace.GetSucursal()
        Dim cont2 As Integer = 1

        Dim rows2 As Integer = clientes2.Rows.Count
        If rows2 > 0 Then
            While cont2 <= rows2
                Dim tempcliente As DataRow = clientes2.Rows.Item(cont2 - 1)
                cont2 = cont2 + 1
                ComboBoxEncargados.Items.Add(tempcliente("Nombre").ToString())


            End While


        End If

        MessageBox.Show("Se ha mofificado los datos de la sucursal")





    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim UsuarioData As LogInData = LogInData.Instance

        If UsuarioData.getPuesto() = "Admin" Then

            Menu_Usuario3Marco_Admin.Show()
        Else
            Menu_UsuarioMarco.Show()
        End If
        Me.Close()


    End Sub

    Private Sub ComboBoxEncargados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxEncargados.KeyPress
        e.Handled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBoxEncargados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEncargados.SelectedIndexChanged

    End Sub
End Class