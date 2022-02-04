Imports System.Data.SqlClient
Public Class Agregar_Producto_Marco
    Private Sub TextNameProducto_TextChanged(sender As Object, e As EventArgs) Handles TextNameProducto.TextChanged

    End Sub

    Private Sub TextCategoria_TextChanged(sender As Object, e As EventArgs) Handles TextCategoria.TextChanged

    End Sub

    Private Sub Textdescripcion_TextChanged(sender As Object, e As EventArgs) Handles Textdescripcion.TextChanged

    End Sub

    Private Sub TextPrecio_TextChanged(sender As Object, e As EventArgs) Handles TextPrecio.TextChanged

    End Sub

    Private Sub TextDescuento_TextChanged(sender As Object, e As EventArgs) Handles TextDescuento.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonAceptarPrd_Click(sender As Object, e As EventArgs) Handles ButtonAceptarPrd.Click

        If String.IsNullOrEmpty(TextPrecio.Text) Or String.IsNullOrEmpty(TextDescuento.Text) Or String.IsNullOrEmpty(TextNameProducto.Text) Or String.IsNullOrEmpty(Textdescripcion.Text) Or String.IsNullOrEmpty(TextCategoria.Text) Then

            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        Dim Enlace As New EnlaceBD


        Dim UsuarioData As LogInData = LogInData.Instance
        Dim fk_Empleado As Integer = UsuarioData.getIdUsuario()
        'Dim idProducto As Integer

        Dim clientes As New DataTable
        clientes = Enlace.GetProductos2()
        Dim cont As Integer = 1
        Dim Flag As Boolean = False

        Dim rows As Integer = clientes.Rows.Count
        If rows > 0 Then
            While cont <= rows
                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                cont = cont + 1
                If tempcliente("Nombre").ToString() = TextNameProducto.Text Then

                    Flag = False
                    MessageBox.Show("El producto " + tempcliente("Nombre").ToString() + "Ya existe porfavor Coloca otro")
                    Return
                Else
                    Flag = True

                End If



            End While


        Else
            Flag = True
        End If
        If Flag = True Then
            Enlace.AddProducto(fk_Empleado, TextPrecio.Text, TextDescuento.Text, TextNameProducto.Text, Textdescripcion.Text, TextCategoria.Text)
            'idProducto = Enlace.GetIdUsuario(TextUsuario.Text)
            Dim UsuarioData2 As LogInData = LogInData.Instance
            MessageBox.Show("Producto fue agregado correctamente")
        End If

        ListBox1.Items.Clear()



        clientes = Enlace.GetProductos2()
        Dim cont2 As Integer = 1

        Dim rows2 As Integer = clientes.Rows.Count
        If rows2 > 0 Then
            While cont2 <= rows2
                Dim tempcliente As DataRow = clientes.Rows.Item(cont2 - 1)
                cont2 = cont2 + 1
                ListBox1.Items.Add(tempcliente("Nombre").ToString())


            End While


        End If





        Funciones.CleanTextBoxs(Me)

    End Sub

    Private Sub ButtonAtrasProducto_Click(sender As Object, e As EventArgs) Handles ButtonAtrasProducto.Click
        Dim Enlace As New EnlaceBD
        Dim clientes As New DataTable


        Dim UsuarioData As LogInData = LogInData.Instance
        '    Dim fk_Empleado As Integer = UsuarioData.getIdUsuario()
        Funciones.CleanTextBoxs(Me)

        If UsuarioData.getPuesto() = "Admin" Then

            Menu_Usuario3Marco_Admin.Show()
        Else
            Menu_UsuarioMarco.Show()
        End If

        Me.Close()







    End Sub

    Private Sub BtnMostrarProducto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Agregar_Producto_Marco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click



        Dim Enlace As New EnlaceBD
        Dim Id_Producto As Integer = Enlace.GetIDProducto(ListBox1.Text)
        Dim NombreProducto As DataRow = Enlace.GetProducto(Id_Producto).Rows.Item(0)

        Dim answer As Integer

        answer = MsgBox("Estas seguro de querer eliminar este producto?", vbQuestion + vbYesNo + vbDefaultButton2, "Aviso")
        If answer = vbYes Then


            If String.IsNullOrEmpty(ListBox1.Text) Then
                MessageBox.Show("Coloque la id del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Enlace.EliminarProductos(Id_Producto)

            End If
        Else
            Exit Sub
        End If

        ListBox1.Items.Clear()

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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If String.IsNullOrEmpty(TextPrecio.Text) Or String.IsNullOrEmpty(TextDescuento.Text) Or String.IsNullOrEmpty(TextNameProducto.Text) Or String.IsNullOrEmpty(Textdescripcion.Text) Or String.IsNullOrEmpty(TextCategoria.Text) Then

            MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If
        Dim Enlace As New EnlaceBD
        Dim UsuarioData As LogInData = LogInData.Instance




        Dim fk_Empleado As Integer = UsuarioData.getIdUsuario()
        If String.IsNullOrEmpty(ListBox1.Text) Then
            MessageBox.Show("Coloque el nombre del producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '''''''''''''''''''''
            '''

            Dim Id_Producto As Integer = Enlace.GetIDProducto(ListBox1.Text)
            Dim NombreProducto As DataRow = Enlace.GetProducto(Id_Producto).Rows.Item(0)

            Dim clientes2 As New DataTable
            clientes2 = Enlace.GetProductos2()
            Dim cont2 As Integer = 1
            Dim Flag2 As Boolean = False

            Dim rows2 As Integer = clientes2.Rows.Count
            If rows2 > 0 Then
                While cont2 <= rows2
                    Dim tempcliente As DataRow = clientes2.Rows.Item(cont2 - 1)
                    cont2 = cont2 + 1
                    If tempcliente("Nombre").ToString() = TextNameProducto.Text Then

                        Flag2 = False
                        MessageBox.Show("El producto " + tempcliente("Nombre").ToString() + "Ya existe porfavor Coloca otro")
                        Return
                    Else
                        Flag2 = True

                    End If



                End While


            Else
                Flag2 = True
            End If
            If Flag2 = True Then

                Enlace.ModificarProducto(Id_Producto, fk_Empleado, TextPrecio.Text, TextDescuento.Text, TextNameProducto.Text, Textdescripcion.Text, TextCategoria.Text)

            End If




        End If
        ListBox1.Items.Clear()

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

        '''''''''''''''''''''''''''''''''
        '''








        MessageBox.Show("Producto fue modificado correctamente")
        Funciones.CleanTextBoxs(Me)
    End Sub

    Private Sub TextPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPrecio.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub TextDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextDescuento.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TextNameProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles TextNameProducto.KeyDown

    End Sub

    Private Sub TextNameProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNameProducto.KeyPress

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            ' Nothing selected!
        Else

            Dim Enlace As New EnlaceBD


            Dim Nombre As String = ListBox1.SelectedItem()

            Dim Id_Producto As Integer = Enlace.GetIDProducto(Nombre)

            Dim tempcliente As DataRow = Enlace.GetProducto(Id_Producto).Rows.Item(0)



            Dim tempcliente2 As DataRow = Enlace.GetProductoPrecio(Id_Producto).Rows.Item(0)



            TextBox1.Text = tempcliente("Nombre").ToString()
            TextBox2.Text = tempcliente("Categoria").ToString()
            TextBox3.Text = tempcliente2("Precio").ToString()
            TextBox4.Text = tempcliente2("Descuento").ToString()


        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub BtnModificar_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class