Public Class Menu_Usuario2Marco
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        LoginMarco.Show()
        Me.Close()
    End Sub

    Private Sub Menu_Usuario2Marco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCarrito_Click(sender As Object, e As EventArgs) Handles BtnCarrito.Click
        Carrito_Marco.Show()
        Me.Close()
    End Sub

    Private Sub BtnModInfo_Click(sender As Object, e As EventArgs) Handles BtnModInfo.Click
        ModificarInformacionClienteMarco.Show()
        Me.Close()
    End Sub
End Class