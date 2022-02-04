Public Class LoginMarco
    Public Const TOTAL_INTENTOS As Integer = 3
    Private intentos As Integer = TOTAL_INTENTOS
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim intentos As Integer = 0
        Enlace.DesconectarTodos()
        'If Tabla.Rows.Count > 0 Then
        'Dim Usuario As DataRow = Tabla.Rows.Item(0)
        'TxtNombreUsuario.Text = Usuario("Nombre").ToString()
        'TxtContraseña.Text = Usuario("Contraseña").ToString()
        'Recordar.Checked = True
        'End If
        If My.Settings.recordar = True Then
            CheckBoxRecordarme.Checked = True
            TextUsuario.Text = My.Settings.nombreusuario
            TextPassword.Text = My.Settings.contraseña

        End If
    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim ComboUsuario As String

        ComboUsuario = ComboBox1.Text
        ''''''''''''''''''''''''''EMPLEADOS''''''''''''''''''''''''''''''''''''''''''''''''''''
        If ComboUsuario = "Empleado" Then
            If String.IsNullOrEmpty(TextUsuario.Text) Or String.IsNullOrEmpty(TextPassword.Text) Then
                MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim Enlace As New EnlaceBD
            Dim Password As String = Enlace.GetPassword(TextUsuario.Text, True)
            If String.IsNullOrEmpty(Password) Then

                MessageBox.Show("Usuario no encontrado o inactivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Funciones.CleanTextBoxs(Me)
                Return
            End If
            If Not Password = TextPassword.Text Then
                intentos = intentos - 1
                MessageBox.Show("Contraseña incorrecta. " + intentos.ToString() + " intentos restantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextPassword.Text = ""
                If intentos = 0 Then
                    MessageBox.Show("El usuario " + TextUsuario.Text + " ha sido deshabilitado.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    If Enlace.EsUser(TextUsuario.Text) Then

                        Dim idusuario As Integer = Enlace.GetIdUsuario(TextUsuario.Text)

                        Dim inusuario As DataRow = Enlace.GetUser(idusuario).Rows.Item(0)


                        'Dim idempleado As Integer = Enlace.getidempleado(idusuario)
                        ' Dim inempleado As DataRow = Enlace.GetEmpleadobyuser(idempleado).Rows.Item(0)
                        Funciones.LogInFillData(TextUsuario.Text)
                        Dim UsuarioData As LogInData = LogInData.Instance
                        If UsuarioData.getPuesto = "Admin" Then
                            MessageBox.Show("SOY ADMIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Else
                            Enlace.Desabilitar(TextUsuario.Text)
                            MessageBox.Show("el Empleado fue desabilitado por motivos de proteccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If


                    End If
                    TextUsuario.Text = ""
                    intentos = TOTAL_INTENTOS


                End If
            Else
                If CheckBoxRecordarme.Checked = True Then
                    My.Settings.nombreusuario = TextUsuario.Text
                    My.Settings.contraseña = TextPassword.Text
                    My.Settings.recordar = True
                    My.Settings.Save()
                    My.Settings.Reload()

                Else
                    My.Settings.nombreusuario = ""
                    My.Settings.contraseña = ""
                    My.Settings.recordar = False
                    My.Settings.Save()
                    My.Settings.Reload()
                End If

                Funciones.LogInFillData(TextUsuario.Text)
                Dim UsuarioData As LogInData = LogInData.Instance

                Dim cont As Integer = 1
                Dim clientes As New DataTable
                clientes = Enlace.esEmpladosActivo(TextUsuario.Text)
                Funciones.CleanTextBoxs(Me)

                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                If tempcliente("Estado").ToString() = "Activo" Then
                    If UsuarioData.getPuesto() = "Admin" Then

                        Menu_Usuario3Marco_Admin.Show()
                    Else
                        Menu_UsuarioMarco.Show()
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("El Empleado esta desactivado parcialmente o baneado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
                '''''''''''''''''''''''''''''''''''''USUARIO''''''''''''''''''''''''''''''''''''''''''''
                ElseIf ComboUsuario = "Cliente" Then

            If String.IsNullOrEmpty(TextUsuario.Text) Or String.IsNullOrEmpty(TextPassword.Text) Then
                MessageBox.Show("Complete los campos vacíos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim Enlace As New EnlaceBD
            Dim Password As String = Enlace.GetPasswordCientes(TextUsuario.Text, True)
            If String.IsNullOrEmpty(Password) Then

                MessageBox.Show("Usuario no encontrado o inactivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Funciones.CleanTextBoxs(Me)
                Return
            End If
            If Not Password = TextPassword.Text Then
                intentos = intentos - 1
                MessageBox.Show("Contraseña incorrecta. " + intentos.ToString() + " intentos restantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextPassword.Text = ""
                If intentos = 0 Then
                    MessageBox.Show("El usuario " + TextUsuario.Text + " ha sido deshabilitado.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    If Enlace.EsUserUsuarios(TextUsuario.Text) Then

                        Dim idusuario As Integer = Enlace.GetIdUsuarioUsuarios(TextUsuario.Text)

                        Dim inusuario As DataRow = Enlace.GetUserUsuario(idusuario).Rows.Item(0)


                        'Dim idempleado As Integer = Enlace.getidem
                        'pleado(idusuario)
                        ' Dim inempleado As DataRow = Enlace.GetEmpleadobyuser(idempleado).Rows.Item(0)
                        If Enlace.esUsuario(idusuario) = False Then
                            Enlace.DesabilitarUsuarios(TextUsuario.Text)
                            MessageBox.Show("el usuario fue desabilitado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim idempleado As Integer = Enlace.getidempleado(idusuario)
                            Dim empleado As DataRow = Enlace.GetUsuariosbyuser(idempleado).Rows.Item(0)

                            Enlace.DesabilitarUsuarios(TextUsuario.Text)

                            MessageBox.Show("el usuario fue desabilitado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                    TextUsuario.Text = ""
                    intentos = TOTAL_INTENTOS


                End If
            Else
                If CheckBoxRecordarme.Checked = True Then
                    My.Settings.nombreusuario = TextUsuario.Text
                    My.Settings.contraseña = TextPassword.Text
                    My.Settings.recordar = True
                    My.Settings.Save()
                    My.Settings.Reload()

                Else
                    My.Settings.nombreusuario = ""
                    My.Settings.contraseña = ""
                    My.Settings.recordar = False
                    My.Settings.Save()
                    My.Settings.Reload()
                End If
                Dim cont As Integer = 1
                Dim clientes As New DataTable
                clientes = Enlace.esUsuarioActivo(TextUsuario.Text)

                Dim tempcliente As DataRow = clientes.Rows.Item(cont - 1)
                If tempcliente("Estado").ToString() = "ACTIVO" Then

                    Funciones.LogInFillDataUSER(TextUsuario.Text)

                    Dim UsuarioData As LogInData = LogInData.Instance

                    Funciones.CleanTextBoxs(Me)

                    UsuarioData.setContador(1)

                    Menu_Usuario2Marco.Show()
                    Me.Close()
                Else
                    MessageBox.Show("el usuario fue desabilitado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If
        Else
            MessageBox.Show("Coloque si pertenece a Empleados o a Clientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If



    End Sub

    Private Sub TextUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextUsuario.TextChanged

    End Sub

    Private Sub TextPassword_TextChanged(sender As Object, e As EventArgs) Handles TextPassword.TextChanged

    End Sub

    Private Sub LoginMarco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Enlace As New EnlaceBD
        Dim intentos As Integer = 0
        Enlace.DesconectarTodos()
        'If Tabla.Rows.Count > 0 Then
        'Dim Usuario As DataRow = Tabla.Rows.Item(0)
        'TxtNombreUsuario.Text = Usuario("Nombre").ToString()
        'TxtContraseña.Text = Usuario("Contraseña").ToString()
        'Recordar.Checked = True
        'End If
        If My.Settings.recordar = True Then
            CheckBoxRecordarme.Checked = True
            TextUsuario.Text = My.Settings.nombreusuario
            TextPassword.Text = My.Settings.contraseña

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged



    End Sub

    Private Sub LinkCrearCuenta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCrearCuenta.LinkClicked
        AñadirUsuariosLogin.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class