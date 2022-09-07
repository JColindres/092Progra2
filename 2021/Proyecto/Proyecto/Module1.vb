Imports MySql.Data.MySqlClient

Module Module1
    'Variables de la sesion
    Public id_usuario_sesion As String
    Public nombre_sesion As String
    Public usuario_sesion As String
    Public tipo_usuario_sesion As String


    Dim datosConexion As String = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=1068868;" _
                    & "database=proyecto_201602713"
    Public conexion As MySqlConnection = New MySqlConnection(datosConexion)

    Public comando As MySqlCommand = New MySqlCommand

    Public Sub ProbarConexion()
        Try
            conexion.Open()
            MsgBox("Se ha realizado la conexión correctamente!")
        Catch ex As Exception
            MsgBox("Error en la conexión!")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub IniciarConexion()
        Try
            conexion.Open()
            Console.WriteLine("Se ha realizado la conexión correctamente!")
        Catch ex As Exception
            MsgBox("Error en la conexión!")
        End Try
    End Sub

End Module
