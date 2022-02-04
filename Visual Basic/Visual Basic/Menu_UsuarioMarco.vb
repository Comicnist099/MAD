Public Class Menu_UsuarioMarco
    Private Sub BtnAgregarEmpelado_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnModInfo.Click
        ModificarInformacionAdmin.Show()

        Me.Close()
    End Sub

    Private Sub Menu_UsuarioMarco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCargaProductos_Click(sender As Object, e As EventArgs) Handles BtnCargaProductos.Click
        Agregar_Producto_Marco.Show()
        Me.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Agregar_Horas_Marco.Show()
        Me.Close()
    End Sub

    Private Sub BtnABCSucursales_Click(sender As Object, e As EventArgs) Handles BtnABCSucursales.Click

        Agregar_Sucursal_Marco.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As EventArgs) Handles BtnCatalogo.Click
        CargaMasivaProductos.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Carga_Masiva_Sucursales.Show()
        Me.Close()


    End Sub
End Class