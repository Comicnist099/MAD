'Esto es un singleton. La clase se declara así:
'Dim Usuario As LogInData = LogInData.Instance
Public Class LogInData
    Private Sub New()
    End Sub
    Public Shared ReadOnly Property Instance As LogInData
        Get
            Static INST As LogInData = New LogInData
            Return INST
        End Get
    End Property
    Private idUsuario As Integer
    Private accessLevel As Boolean
    Private idPuesto As Integer
    Private puesto As String
    Private Nombre As String
    Private Sucursal As String = ""

    Private Contador As Integer


    Public Sub setIdUsuario(ByVal idUsuario As Integer)
        Me.idUsuario = idUsuario
    End Sub


    Public Sub setSucursal(ByVal Sucursal As String)
        Me.Sucursal = Sucursal
    End Sub

    Public Sub setContador(ByVal Contador As Integer)
        Me.Contador = Contador
    End Sub

    Public Sub setAccessLevel(ByVal accessLevel As Boolean)
        Me.accessLevel = accessLevel
    End Sub
    Public Sub setIdPuesto(ByVal idPuesto As Integer)
        Me.idPuesto = idPuesto
    End Sub
    Public Sub setPuesto(ByVal puesto As String)
        Me.puesto = puesto
    End Sub

    Public Sub setNombre(ByVal Nombre As String)
        Me.Nombre = Nombre
    End Sub
    '----------------------------------------------------------------------------------------------------
    Public Function getIdUsuario() As Integer
        Return Me.idUsuario
    End Function

    Public Function getAccessLevel() As Boolean
        Return Me.accessLevel
    End Function
    Public Function getIdPuesto() As Integer
        Return Me.idPuesto
    End Function
    Public Function getPuesto() As String
        Return Me.puesto
    End Function

    Public Function getNombre() As String
        Return Me.Nombre
    End Function

    Public Function getContador() As Integer
        Return Me.Contador
    End Function

    Public Function getSucursal() As String
        Return Me.Sucursal
    End Function


End Class
