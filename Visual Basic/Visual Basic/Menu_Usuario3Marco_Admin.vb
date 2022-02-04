Public Class Menu_Usuario3Marco_Admin
    Private Sub Menu_Usuario3Marco_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Agregar_Horas_Marco.Show()
        Me.Close()
    End Sub

    Private Sub BtnAgregarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnAgregarEmpleados.Click
        AñadirUsuarioMarco.Show()
        Me.Close()
    End Sub

    Private Sub BtnAgregarUsuarios_Click(sender As Object, e As EventArgs) Handles BtnAgregarUsuarios.Click

        AñadirUsuarios2Marco.Show()
        Me.Close()

    End Sub

    Private Sub BtnABCSucursales_Click(sender As Object, e As EventArgs) Handles BtnABCSucursales.Click

        Agregar_Sucursal_Marco.Show()
        Me.Close()
    End Sub

    Private Sub BtnCargaProductos_Click(sender As Object, e As EventArgs) Handles BtnCargaProductos.Click
        Agregar_Producto_Marco.Show()
        Me.Close()
    End Sub

    Private Sub BtnBaneados_Click(sender As Object, e As EventArgs) Handles BtnBaneados.Click

        Baneos.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BaneosEmpleados.Show()
        Me.Close()

    End Sub

    Private Sub BtnModInfo_Click(sender As Object, e As EventArgs)
        ModificarInformacionAdmin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As EventArgs) Handles BtnCatalogo.Click

        CargaMasivaProductos.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Carga_Masiva_Sucursales.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reporte_de_Carrito_y_Horas.Show()
        Me.Close()
    End Sub
End Class