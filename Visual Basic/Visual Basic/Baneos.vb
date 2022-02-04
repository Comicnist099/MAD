Public Class Baneos
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextEstado.TextChanged

    End Sub

    Private Sub BtnBaneado_Click(sender As Object, e As EventArgs) Handles BtnBaneado.Click
        Dim Enlace As New EnlaceBD
        Dim Nombre As String = ListBox1.SelectedItem()

        Dim cont As Integer = 1
        Dim clientes As New DataTable
        clientes = Enlace.esUsuarioActivo(Nombre)

        Dim tempcliente2 As DataRow = clientes.Rows.Item(cont - 1)


        Enlace.DesabilitarUsuarios(Nombre)
        TextEstado.Text = tempcliente2("Estado").ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Menu_Usuario3Marco_Admin.Show()
        Me.Close()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Baneos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable
        clientes = Enlace.getTODOSUsuarios()
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
            TextCURP.Text = tempcliente("CURP").ToString()
            TextDomicilio.Text = tempcliente("Domicilio").ToString()
            TextFechaNacimiento.Text = tempcliente("Fecha_de_Nacimiento").ToString()
            TextCelular.Text = tempcliente("Celular").ToString()
            TextCorreo.Text = tempcliente("Correo").ToString()
            TextEstado.Text = tempcliente2("Estado").ToString()

        End If

    End Sub

    Private Sub BrnDesvanear_Click(sender As Object, e As EventArgs) Handles BrnDesvanear.Click

        Dim Enlace As New EnlaceBD
        Dim Nombre As String = ListBox1.SelectedItem()

        Dim cont As Integer = 1
        Dim clientes As New DataTable
        clientes = Enlace.esUsuarioActivo(Nombre)

        Dim tempcliente2 As DataRow = clientes.Rows.Item(cont - 1)


        Enlace.HabilitarUsuarios(Nombre)
        TextEstado.Text = tempcliente2("Estado").ToString()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextFechaNacimiento_TextChanged(sender As Object, e As EventArgs) Handles TextFechaNacimiento.TextChanged

    End Sub

    Private Sub TextDomicilio_TextChanged(sender As Object, e As EventArgs) Handles TextDomicilio.TextChanged

    End Sub

    Private Sub TextCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextCorreo.TextChanged

    End Sub

    Private Sub TextCelular_TextChanged(sender As Object, e As EventArgs) Handles TextCelular.TextChanged

    End Sub

    Private Sub TextCURP_TextChanged(sender As Object, e As EventArgs) Handles TextCURP.TextChanged

    End Sub

    Private Sub TextBoxApM_TextChanged(sender As Object, e As EventArgs) Handles TextBoxApM.TextChanged

    End Sub

    Private Sub TextBoxApP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxApP.TextChanged

    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub
End Class