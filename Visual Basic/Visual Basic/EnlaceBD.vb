Imports System.Data
Imports System.Data.SqlClient
Public Class EnlaceBD
    Private aux As String
    Private conexion As SqlConnection
    'Private conexionNomina As SqlConnection
    Private tabla As DataTable = New DataTable
    Private adaptador As SqlDataAdapter = New SqlDataAdapter
    Private comandosql As SqlCommand = New SqlCommand
    Private Sub conectar()
        'Dim DBConnection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("SQL").ConnectionString)
        conexion = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("desarrollo").ConnectionString)
    End Sub
    Private Sub desconectar()
        conexion.Close()
    End Sub
    'Éstas funciones ya venían en la clase que nos pasó Villarreal
    Public ReadOnly Property obtenertabla() As DataTable
        Get
            Return tabla
        End Get
    End Property
    Public Function ingresar()

    End Function
    Public Function ValidaUsuario(ByVal User As String, ByVal Pass As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sps_Sys_ValidaUsuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@strNomUsuario", SqlDbType.VarChar, 20)
            parametro1.Value = User
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@strClave", SqlDbType.VarChar, 20)
            parametro2.Value = Pass

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)


        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function AgregaInventario(ByVal dFecha As Date, ByVal strCliente As String, ByVal strNoParte As String,
                                     ByVal strProducto As String, ByVal iPiezasAlm As Integer, ByVal iPiezasCuar As _
                                     Integer, ByVal iPiezasTot As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Fecha", SqlDbType.SmallDateTime, 15)
            parametro1.Value = dFecha
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Cliente", SqlDbType.VarChar, 60)
            parametro2.Value = strCliente
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NoParte", SqlDbType.VarChar, 20)
            parametro3.Value = strNoParte
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Producto", SqlDbType.VarChar, 50)
            parametro4.Value = strProducto
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@PiezasAlm", SqlDbType.Int, 8)
            parametro5.Value = iPiezasAlm
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@PiezasCuar", SqlDbType.Int, 8)
            parametro6.Value = iPiezasCuar
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@PiezasTot", SqlDbType.Int, 8)
            parametro7.Value = iPiezasTot
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@strUsuario", SqlDbType.VarChar, 20)
            'If Session("UserID") Is Nothing Then
            'parametro8.Value = "generic user"
            'Else
            'parametro8.Value = Session("UserID")
            'End If

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function LimpiaInventarioMes(ByVal dFecha As Date) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Delete", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Fecha", SqlDbType.SmallDateTime, 15)
            parametro1.Value = dFecha

            conexion.Open()
            adaptador.DeleteCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ConsultaInventarioInicial(ByVal dFecha As Date, ByVal strCliente As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Fecha", SqlDbType.SmallDateTime, 15)
            parametro1.Value = dFecha
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Cliente", SqlDbType.VarChar, 60)
            parametro2.Value = strCliente

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ConsultaTonelaje() As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function GeneraAnalisis1(ByVal dFechaI As Date, ByVal dFechaF As Date, ByVal Tienda As Integer, ByVal Depto As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("dbo.cumhoGeneraAnalisis1", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@FechaIni", SqlDbType.SmallDateTime, 15)
            parametro1.Value = dFechaI
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@FechaFin", SqlDbType.SmallDateTime, 15)
            parametro2.Value = dFechaF
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@pTienda", SqlDbType.Int, 8)
            parametro3.Value = Tienda
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@pDepto", SqlDbType.VarChar, 10)
            parametro4.Value = Depto

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ObtenTiendas(ByVal Tienda As Integer) As Boolean
        Dim estado As Boolean = True
        Dim Qry As String = ""

        Qry = "SELECT Id, Nombre FROM Tienda"
        Try
            conectar()
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.Text

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function




    Public Function Get_FromEmpleado(ByVal Opcion As String, ByVal ID As Integer) As String
        Try
            Dim response As String = "-1"
            conectar()
            comandosql = New SqlCommand("sp_BuscarEnEmpleado", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 20)
            parametro1.Value = Opcion
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = ID
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@fullName", SqlDbType.VarChar, 90)
            parametro3.Value = "NULL"
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Error"
        Finally
            desconectar()
        End Try
    End Function


    Public Function Get_FromDomicilio(ByVal opcion As String, ByVal id As Integer) As String
        Dim response As String
        Try
            conectar()
            comandosql = New SqlCommand("sp_BuscarEnDomicilio", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 20)
            parametro1.Value = opcion
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function



    Public Function Get_EmpleadoIDFromUsuario(ByVal username As String) As Integer
        Try
            Dim id As Integer = 0
            conectar()
            comandosql = New SqlCommand("sp_EmpleadoidUsu", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@user", SqlDbType.VarChar, 20)
            parametro1.Value = username

            adaptador.SelectCommand = comandosql
            conexion.Open()
            id = CInt(comandosql.ExecuteScalar())
            conexion.Close()
            Return id
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            desconectar()
        End Try
    End Function
    Public Function Get_EmpleadoID(ByVal fullname As String) As Integer
        Dim response As String
        Try
            conectar()
            comandosql = New SqlCommand("sp_BuscarEnEmpleado", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 20)
            parametro1.Value = "ID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fullName", SqlDbType.VarChar, 90)
            parametro2.Value = fullname
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro3.Value = 0
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "Error"
            Return response
        Finally
            desconectar()
        End Try
    End Function
    Public Function Get_DomicilioID(ByVal calle As String, ByVal número As Integer, ByVal colonia As String, ByVal municipio As String, ByVal estadoR As String) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_BuscarEnDomicilio", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.Char, 20)
            parametro1.Value = "ID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = 0
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20)
            parametro3.Value = calle
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@numero", SqlDbType.Int)
            parametro4.Value = número
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 50)
            parametro5.Value = colonia
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@municipio", SqlDbType.VarChar, 35)
            parametro6.Value = municipio
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            parametro7.Value = estadoR
            conexion.Open()
            response = comandosql.ExecuteScalar()
            conexion.Close()
            Return response

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "Error"
            Return response
        Finally
            desconectar()
        End Try
    End Function
    Public Function Get_UsuarioID(ByVal userName As String, ByVal password As String) As Integer
        Dim response As String
        Try
            conectar()
            comandosql = New SqlCommand("sp_idUsuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            parametro1.Value = userName
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 15)
            parametro2.Value = password

            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "Error"
            Return response
        Finally
            desconectar()
        End Try
    End Function


    Public Function Add_Domicilio(ByVal calle As String, ByVal número As Integer, ByVal colonia As String, ByVal municipio As String, ByVal estadoR As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Gestion_Domicilio", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = 0
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@calle", SqlDbType.VarChar, 20)
            parametro3.Value = calle
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@numero", SqlDbType.Int)
            parametro4.Value = número
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@colonia", SqlDbType.VarChar, 50)
            parametro5.Value = colonia
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@municipio", SqlDbType.VarChar, 35)
            parametro6.Value = municipio
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            parametro7.Value = estadoR
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function nombreCompleto(ByVal Empleado As Integer) As String

        Try
            Dim nom As String = "Usuario no existe"
            conectar()
            comandosql = New SqlCommand("sp_nombreEmpleado", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro.Value = Empleado
            conexion.Open()
            adaptador.SelectCommand = comandosql
            Dim reader As SqlDataReader = comandosql.ExecuteReader()
            reader.Read()
            If (reader.HasRows) Then
                If (reader.GetName(0) = "Nombre") Then
                    nom = reader.GetString(0)
                End If
            End If
            Return nom
            conexion.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "nombre no encontrado"
        Finally
            desconectar()
        End Try

    End Function



    Public Function ReporteGeneral(ByVal Empresa As String, ByVal Año As Integer, ByVal Mes As Integer) As DataTable
        Dim data As New DataTable
        Try

            conectar()

            comandosql = New SqlCommand("sp_ReporteGeneral", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Empresa", SqlDbType.Char, 50)
            parametro1.Value = Empresa
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro2.Value = Año
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Mes", SqlDbType.Int)
            parametro3.Value = Mes

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)


        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data

    End Function




    Public Function GetPassword(ByVal Usuario As String, ByVal Activo As Boolean) As String
        Dim response As String
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "LogIn"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario


            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function

    Public Function GetPasswordCientes(ByVal Usuario As String, ByVal Activo As Boolean) As String
        Dim response As String
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "LogIn"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario


            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function



    Public Function ActiveUser(ByVal Usuario As String, ByVal Activo As Boolean) As Boolean
        Dim Estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = If(Activo, "Rehabilitate", "Disable")
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 20)
            parametro2.Value = Usuario

            conexion.Open()
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
        Finally
            desconectar()
        End Try
        Return Estado
    End Function


    Public Function HabilitarEmpleado(ByVal Usuario As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Activo"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
            Return estado
        Finally

            desconectar()

        End Try
        Return estado
    End Function

    Public Function HabilitarUsuarios(ByVal Usuario As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Activo"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
            Return estado
        Finally

            desconectar()

        End Try
        Return estado
    End Function


    Public Function DesabilitarUsuarios(ByVal Usuario As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Disable"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
            Return estado
        Finally

            desconectar()

        End Try
        Return estado
    End Function


    Public Function DesabilitarEmpleados(ByVal Usuario As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Disable"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
            Return estado
        Finally

            desconectar()

        End Try
        Return estado
    End Function

    Public Function Desabilitar(ByVal Usuario As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Disable"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
            Return estado
        Finally

            desconectar()

        End Try
        Return estado
    End Function


    Public Function DesconectarTodos() As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "DisconnectAll"
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
            Return estado
        Finally

            desconectar()

        End Try
        Return estado
    End Function

    Public Function ConectarUsuario(ByVal id As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Connect"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdUsuario", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
            Return estado
        Finally

            desconectar()

        End Try
        Return estado
    End Function
    Public Function getProductoByVal(idusuario As Integer) As Integer

        Dim idempleado As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@OPC", SqlDbType.VarChar, 20)
            parametro1.Value = "SearchProducto"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro2.Value = idusuario
            conexion.Open()
            idempleado = CStr(comandosql.ExecuteScalar())

            conexion.Close()
            Return idempleado
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return idempleado
        Finally
            desconectar()
        End Try
    End Function

    Public Function GetIDProducto(ByVal nombreUsuario As String) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30)
            parametro2.Value = nombreUsuario
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function

    Public Function GetIDSucursal(ByVal nombreUsuario As String) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Surcursales", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30)
            parametro2.Value = nombreUsuario
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function









    Public Function EsUser(ByVal Usuario As String) As Boolean
        Dim response As Boolean = False
        Dim idusuario As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario

            conexion.Open()
            idusuario = CStr(comandosql.ExecuteScalar())

            conexion.Close()

            If idusuario > 0 Then
                response = True
            End If

            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Finally
            desconectar()
        End Try
        Return response
    End Function

    Public Function EsUserUsuarios(ByVal Usuario As String) As Boolean
        Dim response As Boolean = False
        Dim idusuario As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = Usuario

            conexion.Open()
            idusuario = CStr(comandosql.ExecuteScalar())

            conexion.Close()

            If idusuario > 0 Then
                response = True
            End If

            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Finally
            desconectar()
        End Try
        Return response
    End Function
    Public Function getidempleado(ByVal idusuario As Integer) As Integer

        Dim idempleado As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@OPC", SqlDbType.VarChar, 20)
            parametro1.Value = "SearchUser"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = idusuario
            conexion.Open()
            idempleado = CStr(comandosql.ExecuteScalar())

            conexion.Close()
            Return idempleado
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return idempleado
        Finally
            desconectar()
        End Try
    End Function

    Public Function getidcliente(ByVal idusuario As Integer) As Integer

        Dim idcliente As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Clientes", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SearchUser"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDUsuario", SqlDbType.VarChar, 20)
            parametro2.Value = idusuario
            conexion.Open()
            idcliente = CStr(comandosql.ExecuteScalar())

            conexion.Close()
            Return idcliente
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return idcliente
        Finally
            desconectar()
        End Try
    End Function


    Public Function getTODOSUsuarios() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function getTODOSEmpleados() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "TODOS2"

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetEmpleadosbyName(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "TODOS3"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function getRol(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "rol"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function esEmpladosActivo(ByVal Nombre As String) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll4"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 20)
            parametro2.Value = Nombre
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function esEmpleadoActivo(ByVal Nombre As String) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll5"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 20)
            parametro2.Value = Nombre
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function esUsuarioActivo(ByVal Nombre As String) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll2"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 20)
            parametro2.Value = Nombre
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function esUsuario(ByVal id As Integer) As Boolean
        Dim idempleado As Integer
        Dim response As Boolean = False
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SearchUser"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Usuario", SqlDbType.Int)
            parametro2.Value = id

            conexion.Open()
            idempleado = CStr(comandosql.ExecuteScalar())

            conexion.Close()

            If idempleado > 0 Then
                response = True
            End If

            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Finally
            desconectar()
        End Try
        Return response
    End Function

    Public Function esempleado(ByVal id As Integer) As Boolean
        Dim idempleado As Integer
        Dim response As Boolean = False
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SearchUser"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id

            conexion.Open()
            idempleado = CStr(comandosql.ExecuteScalar())

            conexion.Close()

            If idempleado > 0 Then
                response = True
            End If

            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Finally
            desconectar()
        End Try
        Return response
    End Function

    Public Function GetTODOSusuarios(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectTODOS"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Usuario", SqlDbType.Int)
            parametro2.Value = id


            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetUsuariosbyuser(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Usuario", SqlDbType.Int)
            parametro2.Value = id

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function SetCarrito(ByVal fk_Usuario As Integer, ByVal fk_Producto As Integer, ByVal Precio As Decimal, ByVal Descuento As Decimal, ByVal Cantidad As Decimal, ByVal Nombre As String, ByVal Categoria As String, ByVal Descripcion As String) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "EJEMPLO"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.Int)
            parametro2.Value = fk_Usuario
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@fk_Producto", SqlDbType.Int)
            parametro3.Value = fk_Producto
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Precio", SqlDbType.Decimal)
            parametro4.Value = Precio
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Descuento", SqlDbType.Decimal)
            parametro5.Value = Descuento
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Cantidad", SqlDbType.Decimal)
            parametro6.Value = Cantidad
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro7.Value = Nombre
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Categoria", SqlDbType.VarChar, 20)
            parametro8.Value = Categoria
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 20)
            parametro9.Value = Descripcion



            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetEmpleadobyuser(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetClientebyuser(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Clientes", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdCliente", SqlDbType.VarChar, 20)
            parametro2.Value = id

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetUserUsuario(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Usuario", SqlDbType.Int)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function



    Public Function GetProductoPrecio(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Selectprecio"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Producto", SqlDbType.Int)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function






    Public Function GetProducto(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Producto", SqlDbType.Int)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetUser(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetUser2(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select2"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetUser3(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select3"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function RememberUser(ByVal Usuario As String, ByVal Recordar As Boolean) As Boolean
        Dim Estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuarios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = If(Recordar, "RememberSession", "ForgetSession")
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 20)
            parametro2.Value = Usuario

            conexion.Open()
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False
        Finally
            desconectar()
        End Try
        Return Estado
    End Function


    Public Function GetUserRemembered() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuarios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "LogInDefault"

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetIdUsuarioUsuarios(ByVal nombreUsuario As String) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = nombreUsuario
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function
    Public Function GetIdUsuario(ByVal nombreUsuario As String) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro2.Value = nombreUsuario
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function

    Public Function EliminarProductosCarritos(ByVal id As Integer, ByVal id_Nombre As Integer) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "EliminarProducto"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Producto", SqlDbType.Int)
            parametro2.Value = id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.Int)
            parametro3.Value = id_Nombre
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function



    Public Function EliminarEmpleados(ByVal id As Integer) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Delete"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function

    Public Function EliminarUsuarios(ByVal id As Integer) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Delete"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Usuario", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function

    Public Function EliminarSucursal(ByVal id As Integer) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Surcursales", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Delete"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@id_Sucursal", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function
    Public Function EliminarProductos(ByVal id As Integer) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Delete"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Producto", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function

    Public Function ModificarProducto(ByVal Id_Producto As Integer, ByVal fk_Empleado As Integer, ByVal Precio As Decimal, ByVal Descuento As Decimal, ByVal Nombre As String, ByVal Descripcion As String, ByVal Categoria As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@fk_Empleado", SqlDbType.Int)
            parametro3.Value = fk_Empleado
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Precio", SqlDbType.Decimal)
            parametro4.Value = Precio
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Descuento", SqlDbType.Decimal)
            parametro5.Value = Descuento
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro6.Value = Nombre
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 20)
            parametro7.Value = Descripcion
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Categoria", SqlDbType.VarChar, 20)
            parametro8.Value = Categoria
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@ID_Producto", SqlDbType.VarChar, 20)
            parametro9.Value = Id_Producto

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function GetIdDomicilio(ByVal casa As Integer) As Integer
        Dim response As Integer
        Try
            conectar()
            comandosql = New SqlCommand("sp_Domicilios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetID"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@No_Casa", SqlDbType.Int)
            parametro2.Value = casa
            conexion.Open()
            response = CStr(comandosql.ExecuteScalar())
            conexion.Close()
            Return response
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = "-1"
            Return response
        Finally
            desconectar()
        End Try
    End Function

    Public Function AddPuesto(ByVal puesto As String, ByVal nivel As Decimal) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Puestos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NombrePuesto", SqlDbType.VarChar, 20)
            parametro2.Value = puesto
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Nivel", SqlDbType.Decimal)
            parametro3.Value = nivel
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function AddEmpleado(ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal rfc As String, ByVal FechaNac As Date, ByVal Rol As String, ByVal Correo As String, ByVal Domicilio As String, ByVal Name_Usuario As String, ByVal Contrasena As String, ByVal CURP As String, ByVal Celular As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 40)
            parametro3.Value = rfc
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro4.Value = Nombre
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 20)
            parametro5.Value = ApellidoP
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 20)
            parametro6.Value = ApellidoM
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Fecha_de_Nacimiento", SqlDbType.Date)
            parametro7.Value = FechaNac
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Rol", SqlDbType.VarChar, 50)
            parametro8.Value = Rol
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30)
            parametro9.Value = Correo
            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 30)
            parametro10.Value = Domicilio
            Dim parametro11 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro11.Value = Name_Usuario
            Dim parametro12 As SqlParameter = comandosql.Parameters.Add("@Contrasena", SqlDbType.VarChar, 30)
            parametro12.Value = Contrasena
            Dim parametro13 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 30)
            parametro13.Value = CURP
            Dim parametro14 As SqlParameter = comandosql.Parameters.Add("@Celular", SqlDbType.VarChar, 30)
            parametro14.Value = Celular
            estado = True


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function AddCarrito(ByVal Fk_Usuario As Integer) As Boolean

        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "InsertCarrito"
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.Int)
            parametro3.Value = Fk_Usuario
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try

    End Function



    Public Function AddUserLogin(ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal FechaNac As Date, ByVal Correo As String, ByVal Domicilio As String, ByVal Name_Usuario As String, ByVal Contrasena As String, ByVal CURP As String, ByVal Celular As String, ByVal MetodoPago As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro2.Value = Nombre
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 20)
            parametro3.Value = ApellidoP
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 20)
            parametro4.Value = ApellidoM
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Fecha_de_Nacimiento", SqlDbType.Date)
            parametro5.Value = FechaNac
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30)
            parametro6.Value = Correo
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 30)
            parametro7.Value = Domicilio
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro8.Value = Name_Usuario
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Contrasena", SqlDbType.VarChar, 30)
            parametro9.Value = Contrasena
            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 30)
            parametro10.Value = CURP
            Dim parametro11 As SqlParameter = comandosql.Parameters.Add("@Celular", SqlDbType.VarChar, 30)
            parametro11.Value = Celular
            Dim parametro12 As SqlParameter = comandosql.Parameters.Add("@MetodoPago", SqlDbType.VarChar, 50)
            parametro12.Value = MetodoPago
            estado = True


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ModificarUsuario(ByVal Id As Integer, ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal FechaNac As Date, ByVal Correo As String, ByVal Domicilio As String, ByVal Name_Usuario As String, ByVal Contrasena As String, ByVal CURP As String, ByVal Celular As String, ByVal MetodoPago As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Usuario", SqlDbType.Int)
            parametro2.Value = Id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro3.Value = Nombre
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 20)
            parametro4.Value = ApellidoP
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 20)
            parametro5.Value = ApellidoM
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Fecha_de_Nacimiento", SqlDbType.Date)
            parametro6.Value = FechaNac
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30)
            parametro7.Value = Correo
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 30)
            parametro8.Value = Domicilio
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro9.Value = Name_Usuario
            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@Contrasena", SqlDbType.VarChar, 30)
            parametro10.Value = Contrasena
            Dim parametro11 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 30)
            parametro11.Value = CURP
            Dim parametro12 As SqlParameter = comandosql.Parameters.Add("@Celular", SqlDbType.VarChar, 15)
            parametro12.Value = Celular
            Dim parametro13 As SqlParameter = comandosql.Parameters.Add("@MetodoPago", SqlDbType.VarChar, 15)
            parametro13.Value = MetodoPago


            estado = True


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function ModificarUsuario2(ByVal Id As Integer, ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal FechaNac As Date, ByVal Correo As String, ByVal Domicilio As String, ByVal Name_Usuario As String, ByVal Contrasena As String, ByVal CURP As String, ByVal Celular As String, ByVal MetodoPago As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Usuario", SqlDbType.Int)
            parametro2.Value = Id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro3.Value = Nombre
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 20)
            parametro4.Value = ApellidoP
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 20)
            parametro5.Value = ApellidoM
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Fecha_de_Nacimiento", SqlDbType.Date)
            parametro6.Value = FechaNac
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30)
            parametro7.Value = Correo
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 30)
            parametro8.Value = Domicilio
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro9.Value = Name_Usuario
            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@Contrasena", SqlDbType.VarChar, 30)
            parametro10.Value = Contrasena
            Dim parametro11 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 30)
            parametro11.Value = CURP
            Dim parametro12 As SqlParameter = comandosql.Parameters.Add("@Celular", SqlDbType.VarChar, 15)
            parametro12.Value = Celular
            Dim parametro13 As SqlParameter = comandosql.Parameters.Add("@MetodoPago", SqlDbType.VarChar, 15)
            parametro13.Value = MetodoPago


            estado = True


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ModificarEmpleado(ByVal Id As Integer, ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal rfc As String, ByVal FechaNac As Date, ByVal Rol As String, ByVal Correo As String, ByVal Domicilio As String, ByVal Name_Usuario As String, ByVal Contrasena As String, ByVal CURP As String, ByVal Celular As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 40)
            parametro3.Value = rfc
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro4.Value = Nombre
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 20)
            parametro5.Value = ApellidoP
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 20)
            parametro6.Value = ApellidoM
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Fecha_de_Nacimiento", SqlDbType.Date)
            parametro7.Value = FechaNac
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Rol", SqlDbType.VarChar, 50)
            parametro8.Value = Rol
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30)
            parametro9.Value = Correo
            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 30)
            parametro10.Value = Domicilio
            Dim parametro11 As SqlParameter = comandosql.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 30)
            parametro11.Value = Name_Usuario
            Dim parametro12 As SqlParameter = comandosql.Parameters.Add("@Contrasena", SqlDbType.VarChar, 30)
            parametro12.Value = Contrasena
            Dim parametro13 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 30)
            parametro13.Value = CURP
            Dim parametro14 As SqlParameter = comandosql.Parameters.Add("@Celular", SqlDbType.VarChar, 30)
            parametro14.Value = Celular
            Dim parametro15 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro15.Value = Id
            estado = True


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function AddHoras(ByVal fk_Empleado As Integer, ByVal HoraEntrada As String, ByVal HoraSalida As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Horas", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Id_Empleado", SqlDbType.VarChar, 20)
            parametro3.Value = fk_Empleado
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Hora_Entrada", SqlDbType.VarChar, 20)
            parametro4.Value = HoraEntrada
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Hora_Salida", SqlDbType.VarChar, 20)
            parametro5.Value = HoraSalida

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado

    End Function




    Public Function AddProducto(ByVal fk_Empleado As Integer, ByVal Precio As Decimal, ByVal Descuento As Decimal, ByVal Nombre As String, ByVal Descripcion As String, ByVal Categoria As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@fk_Empleado", SqlDbType.Int)
            parametro3.Value = fk_Empleado
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Precio", SqlDbType.Decimal)
            parametro4.Value = Precio
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Descuento", SqlDbType.Decimal)
            parametro5.Value = Descuento
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro6.Value = Nombre
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 20)
            parametro7.Value = Descripcion
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Categoria", SqlDbType.VarChar, 20)
            parametro8.Value = Categoria



            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function AddSucursal(ByVal fk_Empleado As Integer, ByVal Nombre As String, ByVal Domicilio As String, ByVal Combo As String) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Surcursales", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Registro_Empleado", SqlDbType.Int)
            parametro2.Value = fk_Empleado
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30)
            parametro3.Value = Nombre
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 30)
            parametro4.Value = Domicilio
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@fk_Encargado", SqlDbType.VarChar, 30)
            parametro5.Value = Combo



            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function ModificarSucursal(ByVal fk_Empleado As Integer, ByVal Nombre As String, ByVal Domicilio As String, ByVal Combo As Integer, ByVal id_Sucursal As Integer) As Boolean
        Dim estado As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_Surcursales", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Registro_Empleado", SqlDbType.Int)
            parametro2.Value = fk_Empleado
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30)
            parametro3.Value = Nombre
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Domicilio", SqlDbType.VarChar, 30)
            parametro4.Value = Domicilio
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@fk_Encargado", SqlDbType.Int)
            parametro5.Value = Combo
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@id_Sucursal", SqlDbType.Int)
            parametro6.Value = id_Sucursal



            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function AddConsumo(ByVal idcontrato As Integer, ByVal fecha As String, ByVal kw As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Consumos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdContrato", SqlDbType.Int)
            parametro2.Value = idcontrato
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@FechaInicio", SqlDbType.Date)
            parametro3.Value = fecha
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@KW", SqlDbType.Decimal)
            parametro4.Value = kw


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function AddTarifa(ByVal tipo As String, ByVal basico As Integer, ByVal intermedio As Integer, ByVal excesivo As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Tarifas", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            If tipo = "Industrial" Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit)
                parametro2.Value = True
            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit)
                parametro2.Value = False
            End If
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@PrecioBasico", SqlDbType.Int)
            parametro3.Value = basico
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@PrecioInter", SqlDbType.Int)
            parametro4.Value = intermedio
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@PrecioExc", SqlDbType.Int)
            parametro5.Value = excesivo

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function AddCliente(ByVal idusuario As Integer, ByVal genero As Boolean, ByVal email As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Clientes", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Insert"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdUsuario", SqlDbType.Int)
            parametro2.Value = idusuario
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 30)
            parametro3.Value = email
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Genero", SqlDbType.Bit)
            parametro4.Value = genero

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function habilitar(ByVal usuario As String, ByVal habilitado As Boolean) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuarios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            If habilitado = True Then
                Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 20)
                parametro1.Value = "Rehabilitate"
            Else
                Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 20)
                parametro1.Value = "Disable"
            End If

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 20)
            parametro2.Value = usuario

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function EditCliente(ByVal id As Integer, ByVal genero As Boolean, ByVal email As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Clientes", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdCliente", SqlDbType.Int)
            parametro2.Value = id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 30)
            parametro3.Value = email
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Genero", SqlDbType.Bit)
            parametro4.Value = genero

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function InsertMetodo(ByVal metodo As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Recibos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "InsertMetodoDePago"
            If metodo = "Efectivo" Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@MetodoPago", SqlDbType.Char)
                parametro2.Value = "E"

            End If
            If metodo = "Tarjeta de débito" Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@MetodoPago", SqlDbType.Char)
                parametro2.Value = "D"

            End If
            If metodo = "Tarjeta de crédito" Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@MetodoPago", SqlDbType.Char)
                parametro2.Value = "C"

            End If
            If metodo = "Transferencia bancaria" Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@MetodoPago", SqlDbType.Char)
                parametro2.Value = "B"

            End If


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function EditUsuario(ByVal id As Integer, ByVal nombre As String, ByVal appat As String, ByVal apmat As String, ByVal usuario As String, ByVal contraseña As String, ByVal fechanac As String, ByVal curp As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuarios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdUsuario", SqlDbType.Int)
            parametro2.Value = id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ApPat", SqlDbType.VarChar, 30)
            parametro3.Value = appat
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@ApMat", SqlDbType.VarChar, 30)
            parametro4.Value = apmat
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 30)
            parametro5.Value = usuario
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 30)
            parametro6.Value = contraseña
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@FechaNacimiento", SqlDbType.Date)
            parametro7.Value = fechanac
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 30)
            parametro8.Value = curp
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30)
            parametro9.Value = nombre


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function EditDomicilio(ByVal id As Integer, ByVal calle As String, ByVal casa As Integer, ByVal colonia As String, ByVal municipio As String, ByVal estado As String) As Boolean
        Dim response As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Domicilios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdDomicilio", SqlDbType.Int)
            parametro2.Value = id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 30)
            parametro3.Value = calle
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@No_Casa", SqlDbType.Int)
            parametro4.Value = casa
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 30)
            parametro5.Value = colonia
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Municipio", SqlDbType.VarChar, 30)
            parametro6.Value = municipio
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Estado", SqlDbType.VarChar, 30)
            parametro7.Value = estado



            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = False
        Finally
            desconectar()
        End Try
        Return response
    End Function

    Public Function AddUsuario(ByVal nombre As String, ByVal appat As String, ByVal apmat As String, ByVal usuario As String, ByVal contraseña As String, ByVal fechanacimiento As String, ByVal curp As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuarios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 20)
            parametro1.Value = "Insert"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro2.Value = nombre
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ApPat", SqlDbType.VarChar, 20)
            parametro3.Value = appat
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@ApMat", SqlDbType.VarChar, 20)
            parametro4.Value = apmat
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 20)
            parametro5.Value = usuario
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 20)
            parametro6.Value = contraseña
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@FechaNacimiento", SqlDbType.Date)
            parametro7.Value = fechanacimiento
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 20)
            parametro8.Value = curp
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function AddDomicilio(ByVal calle As String, ByVal casa As Integer, ByVal colonia As String, ByVal municipio As String, ByVal estado As String) As Boolean
        Dim response As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Domicilios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 20)
            parametro1.Value = "Insert"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 50)
            parametro2.Value = calle
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@No_Casa", SqlDbType.Int)
            parametro3.Value = casa
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 50)
            parametro4.Value = colonia
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@Municipio", SqlDbType.VarChar, 20)
            parametro5.Value = municipio
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@Estado", SqlDbType.VarChar, 20)
            parametro6.Value = estado

            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = False
        Finally
            desconectar()
        End Try
        Return response
    End Function
    Public Function AddContrato(ByVal idcliente As Integer, ByVal iddomicilio As Integer, ByVal idtarifa As Integer, ByVal medidor As Integer) As Boolean
        Dim response As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Contratos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 20)
            parametro1.Value = "Insert"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdCliente", SqlDbType.Int)
            parametro2.Value = idcliente
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@IdDomicilio", SqlDbType.Int)
            parametro3.Value = iddomicilio
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@IdTarifa", SqlDbType.Int)
            parametro4.Value = idtarifa
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@No_Medidor", SqlDbType.Int)
            parametro5.Value = medidor


            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            response = False
        Finally
            desconectar()
        End Try
        Return response
    End Function


    Public Function GetPuestos() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Puestos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = "X"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetPuesto(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Puestos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = "S"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdPuesto", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetEmpleados() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetDesactivados() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuarios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAllInactive"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function






    Public Function GetConsumosbycliente(ByVal cliente As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Consumos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAllByClient"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdCliente", SqlDbType.Int)
            parametro2.Value = cliente
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetCarrito(ByVal id_Usuario As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "ListaCarrito"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.Int)
            parametro2.Value = id_Usuario
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function getpagado(ByVal fk_Usuario As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Pagado"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.Int)
            parametro2.Value = fk_Usuario
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetCarritoIndividual() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "GetCarrito"

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetCarritoPRO(ByVal Id_Usuario As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "CarritoPro"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.Int)
            parametro2.Value = Id_Usuario
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function



    Public Function GetProductos2() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll2"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetSucursal2(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Surcursales", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@id_Sucursal", SqlDbType.Int)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function



    Public Function GetTotalCarrito(ByVal id_Nombre As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Total"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.VarChar, 20)
            parametro2.Value = id_Nombre
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetCarritoProductos(ByVal ID As Integer, ByVal id_Usuario As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Carrito", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "individual"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@fk_Producto", SqlDbType.Int)
            parametro2.Value = ID
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@fk_Usuario", SqlDbType.Int)
            parametro3.Value = id_Usuario

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function




    Public Function GetProductosInventario(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "CARRITO"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Producto", SqlDbType.VarChar, 20)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetProductosInventario2(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "CARRITO2"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID_Producto", SqlDbType.VarChar, 20)
            parametro2.Value = ID

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function




    Public Function GetClientes() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll2"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetEmpleadosDatos(ByVal ID As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll3"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = ID
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetClienteUsuarios() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll3"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetProductos() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Producto", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetSucursal() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Surcursales", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll2"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetTarifas() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Tarifas", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll"
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetEmpleado(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetRecibobyconsumo(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Recibos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Searchbyconsumo"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdConsumo", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetRecibobyservicio(ByVal servicio As Integer, ByVal fecha As String) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Recibos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Search"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdContrato", SqlDbType.Int)
            parametro2.Value = servicio
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Fecha", SqlDbType.Date)
            parametro3.Value = fecha
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetRecibos(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Recibos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 30)
            parametro1.Value = "SelectAllByClient"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdCliente", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetRecibosbycontrato(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Recibos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 30)
            parametro1.Value = "Search1"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdContrato", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetDomicilio(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Domicilios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdDomicilio", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetDomicilios() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Domicilios", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll"

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetContratos() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Contratos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectAll"

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetContratosbycliente(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Contratos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "SelectByClient"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdCliente", SqlDbType.Int)
            parametro2.Value = id

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetTarifa(ByVal id As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_Tarifas", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdTarifa", SqlDbType.Int)
            parametro2.Value = id
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetReportesConsumos(ByVal año As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ReporteConsumos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro1.Value = año


            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetReportesTarifas(ByVal año As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ReporteTarifas", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro1.Value = año


            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetConsumoHistorico(ByVal año As Integer, ByVal medidor As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ConsumoHistorico", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro1.Value = año
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@No_Medidor", SqlDbType.Int)
            parametro2.Value = medidor
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetConsumoHistorico1(ByVal año As Integer, ByVal servicio As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ConsumoHistorico", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro1.Value = año
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@No_Servicio", SqlDbType.Int)
            parametro2.Value = servicio
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function GetHistorial() As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_RegistroHistorico", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Select"

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetReportes(ByVal servicio As String, ByVal año As Integer, ByVal mes As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ReporteGeneral", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Mes", SqlDbType.Int)
            parametro1.Value = mes
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro2.Value = año
            If servicio = "Industrial" Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit)
                parametro3.Value = True
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit)
                parametro3.Value = False
            End If


            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function GetReportes1(ByVal año As Integer, ByVal mes As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ReporteGeneral", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Mes", SqlDbType.Int)
            parametro1.Value = mes
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro2.Value = año
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetReportes2(ByVal servicio As String, ByVal año As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ReporteGeneral", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro1.Value = año

            If servicio = "Industrial" Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit)
                parametro2.Value = True
            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit)
                parametro2.Value = False
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function
    Public Function GetReportes3(ByVal año As Integer) As DataTable
        Dim data As New DataTable
        Try
            conectar()
            comandosql = New SqlCommand("sp_ReporteGeneral", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Año", SqlDbType.Int)
            parametro1.Value = año


            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
        Return data
    End Function


    Public Function EditPuesto(ByVal id As Integer, ByVal puesto As String, ByVal nivel As Decimal) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Puestos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = "U"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdPuesto", SqlDbType.Int)
            parametro2.Value = id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NombrePuesto", SqlDbType.VarChar, 20)
            parametro3.Value = puesto
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Nivel", SqlDbType.Decimal)
            parametro4.Value = nivel
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function EditEmpleado(ByVal id As Integer, ByVal rfc As String, ByVal admin As Boolean) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Empleados", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Update"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int)
            parametro2.Value = id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            parametro3.Value = rfc
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Administrador", SqlDbType.Bit)
            parametro4.Value = admin
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function



    Public Function Pagar(ByVal id As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Recibos", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 20)
            parametro1.Value = "Pagar"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IdRecibo", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function Edit_Usuario(ByVal id As Integer, ByVal userName As String, ByVal password As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Gestion_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1)
            parametro1.Value = "U"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            parametro3.Value = userName
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 15)
            parametro4.Value = password
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function Delete_Empleado(ByVal id As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Gestion_Empleado", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1)
            parametro1.Value = "D"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function Delete_Usuario(ByVal userName As String, ByVal password As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Gestion_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1)
            parametro1.Value = "B"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            parametro2.Value = userName
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@contraseña", SqlDbType.VarChar, 15)
            parametro3.Value = password
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function Delete_Usuario(ByVal id As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_Gestion_Usuario", conexion)
            comandosql.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1)
            parametro1.Value = "D"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@ID", SqlDbType.Int)
            parametro2.Value = id
            conexion.Open()
            adaptador.InsertCommand = comandosql
            comandosql.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

End Class
