Public Class Ver_Carrito_Marco
    Dim strEnvio As String

    Private Sub Ver_Carrito_Marco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim id_Usuario As Integer = UsuarioData.getIdUsuario()
        clientes = Enlace.GetCarrito(id_Usuario)
        Dim cont As Integer = 1

        Dim rows As Integer = clientes.Rows.Count
        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                cont = cont + 1
                ListBox1.Items.Add(tempcliente("Nombre").ToString())


            End While


            Dim TotalCompra As DataRow = Enlace.GetTotalCarrito(id_Usuario).Rows.Item(0)
            TextBox11.Text = TotalCompra("Total").ToString()

            Dim clientes2 As New DataTable
            clientes2 = Enlace.GetSucursal()
            Dim cont2 As Integer = 1

            Dim rows2 As Integer = clientes2.Rows.Count
            If rows2 > 0 Then
                While cont2 <= rows2
                    Dim tempcliente As DataRow = clientes2.Rows.Item(cont2 - 1)
                    cont2 = cont2 + 1
                    ComboBox1.Items.Add(tempcliente("Nombre").ToString())


                End While


            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Carrito_Marco.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Enlace As New EnlaceBD
        Dim Nombre As String = ListBox1.SelectedItem()
        Dim answer As Integer
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim id_Usuario As Integer = UsuarioData.getIdUsuario()

        answer = MsgBox("Estas seguro de querer eliminar este producto del carrito?", vbQuestion + vbYesNo + vbDefaultButton2, "Aviso")
        If answer = vbYes Then
            Dim Id_Producto As Integer = Enlace.GetIDProducto(Nombre)
            Enlace.EliminarProductosCarritos(Id_Producto, id_Usuario)

            ListBox1.Items.Clear()

            Dim clientes As New DataTable
            clientes = Enlace.GetCarrito(id_Usuario)
            Dim cont As Integer = 1

            Dim rows As Integer = clientes.Rows.Count
            If rows > 0 Then
                While cont <= rows
                    Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                    cont = cont + 1
                    ListBox1.Items.Add(tempcliente("Nombre").ToString())


                End While

                MessageBox.Show("producto eliminado")


                Dim TotalCompra As DataRow = Enlace.GetTotalCarrito(id_Usuario).Rows.Item(0)
                TextBox11.Text = TotalCompra("Total").ToString()
            End If

        Else
            Exit Sub


        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            ' Nothing selected!
        Else

            Dim Enlace As New EnlaceBD



            Dim Nombre As String = ListBox1.SelectedItem()
            TextBox1.Text = Nombre

            Dim Id_Producto As Integer = Enlace.GetIDProducto(Nombre)
            Dim UsuarioData As LogInData = LogInData.Instance
            Dim id_Usuario As Integer = UsuarioData.getIdUsuario()
            Dim NombreProducto As DataRow = Enlace.GetCarritoProductos(Id_Producto, id_Usuario).Rows.Item(0)


            TextBox7.Text = NombreProducto("Categoria").ToString()
            TextBox5.Text = NombreProducto("Descripcion").ToString()
            TextBox8.Text = NombreProducto("Nombre").ToString()
            TextBox3.Text = NombreProducto("Precio").ToString()
            TextBox6.Text = NombreProducto("Descuento").ToString()
            TextBox4.Text = NombreProducto("Cantidad").ToString()
            TextBox2.Text = NombreProducto("PrecioDescuentado2").ToString()
            TextBox1.Text = NombreProducto("Total").ToString()
            TextBox9.Text = NombreProducto("TotalDescuentado").ToString()
            TextBox10.Text = NombreProducto("Ahorrado").ToString()



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim UsuarioData As LogInData = LogInData.Instance
        Dim Enlace As New EnlaceBD


        Dim fk_Usuario As Integer = UsuarioData.getIdUsuario()

        Dim clientes As New DataTable
        clientes = Enlace.GetCarritoPRO(fk_Usuario)
        Dim cont As Integer = 1
        Dim Flag As Boolean = False

        Dim rows As Integer = clientes.Rows.Count


        Dim Envio As String = strEnvio
        Dim NameSucursal As String = ComboBox1.Text




        If RadioButton1.Checked Or RadioButton2.Checked Then
            If RadioButton1.Checked Then
                UsuarioData.setSucursal(NameSucursal)


            End If
            If rows = 0 Then
                MessageBox.Show("No se puede generar un recibo sin productos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Ver_Recibo.Show()
                Me.Close()

            End If
        Else

            MessageBox.Show("Falta seleccionar el metodo de envio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If









    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        strEnvio = "DOMICILIO"

        ComboBox1.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        strEnvio = "SUCURSAL"

        ComboBox1.Visible = True


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class