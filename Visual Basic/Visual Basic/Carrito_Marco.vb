Public Class Carrito_Marco
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Nombre.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            ' Nothing selected!
        Else

            Dim Enlace As New EnlaceBD


            Dim Nombre As String = ListBox1.SelectedItem()
            TextBox1.Text = Nombre

            Dim Id_Producto As Integer = Enlace.GetIDProducto(Nombre)

            Dim NombreProducto As DataRow = Enlace.GetProductosInventario(Id_Producto).Rows.Item(0)
            Dim PrecioProducto As DataRow = Enlace.GetProductosInventario2(Id_Producto).Rows.Item(0)

            TextBox2.Text = NombreProducto("Categoria").ToString()
            TextBox3.Text = PrecioProducto("Precio").ToString()
            TextBox5.Text = NombreProducto("Descripcion").ToString()
            TextBox6.Text = PrecioProducto("Descuento").ToString()
            ''ListBox1.Items.Add(NombreProducto("Descripcion").ToString())

        End If

    End Sub

    Private Sub Carrito_Marco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable
        clientes = Enlace.GetProductos2()
        Dim cont As Integer = 1

        Dim rows As Integer = clientes.Rows.Count
        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                cont = cont + 1
                ListBox1.Items.Add(tempcliente("Nombre").ToString())


            End While


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menu_Usuario2Marco.Show()
        Me.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox5.Text) Or String.IsNullOrEmpty(TextBox6.Text) Or String.IsNullOrEmpty(TextBox3.Text) Or String.IsNullOrEmpty(TextBox4.Text) Then

            MessageBox.Show("No se ha añadido, revise de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        Dim Enlace As New EnlaceBD
        Dim UsuarioData As LogInData = LogInData.Instance


        Dim fk_Usuario As Integer = UsuarioData.getIdUsuario()

        Dim Nombre As String = ListBox1.SelectedItem()

        Dim Id_Producto As Integer = Enlace.GetIDProducto(Nombre)

        Dim Precio As Decimal = TextBox3.Text
        Dim Descuento As Decimal = TextBox6.Text
        Dim Descripcion As String = TextBox5.Text
        Dim Categoria As String = TextBox2.Text
        Dim Cantidad As Decimal = TextBox4.Text


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim Carrito As New DataTable
        Carrito = Enlace.GetCarritoIndividual()
        Dim cont As Integer = 1
        Dim Flag As Boolean = False
        Dim rows As Integer = Carrito.Rows.Count
        Dim id_usuario As Integer = UsuarioData.getIdUsuario()

        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = Carrito.Rows.Item(cont - 1)
                cont = cont + 1
                If tempcliente("fk_Usuario").ToString() = id_usuario Then

                    Flag = False
                Else
                    Flag = True

                End If

            End While
        Else
            Flag = True
        End If
        If Flag = True Then
            Enlace.AddCarrito(fk_Usuario)
            UsuarioData.setContador(0)
        End If




        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim clientes As New DataTable
        clientes = Enlace.GetCarritoPRO(fk_Usuario)
        Dim cont2 As Integer = 1
        Dim Flag2 As Boolean = False

        Dim rows2 As Integer = clientes.Rows.Count
        If rows2 > 0 Then
            While cont2 <= rows2
                Dim tempcliente As DataRow = clientes.Rows.Item(cont2 - 1)
                cont2 = cont2 + 1
                If tempcliente("Nombre").ToString() = Nombre Then

                    Flag2 = False
                    MessageBox.Show("El producto " + tempcliente("Nombre").ToString() + " Ya existe porfavor Coloca otro")
                    Return
                Else
                    Flag2 = True

                End If

            End While
        Else
            Flag2 = True
        End If

        If Flag2 = True Then
            Enlace.SetCarrito(fk_Usuario, Id_Producto, Precio, Descuento, Cantidad, Nombre, Categoria, Descripcion)
            MessageBox.Show("Producto agregado al carrito")
        End If









    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Ver_Carrito_Marco.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
End Class