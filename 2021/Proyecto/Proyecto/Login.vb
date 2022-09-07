Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT * FROM Usuario WHERE username = @username AND password = @password" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@username", txtUsername.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@password", txtPwd.Text) 'Enviamos parámetro a evaluar
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            If dt.Rows.Count() <= 0 Then 'Si las filas es igual a 0 es porque no se encontró nada
                MsgBox("Las credenciales no son validas")
            Else
                For Each row As DataRow In dt.Rows 'Por cada de la fila de la tabla, accederemos a su información
                    'guardaremos la info en las variables del módulo
                    id_usuario_sesion = row.ItemArray(0)
                    nombre_sesion = row.ItemArray(1)
                    usuario_sesion = row.ItemArray(2)
                    tipo_usuario_sesion = row.ItemArray(4)
                    Exit For 'Solo recibimos una fila, por eso nos salimos del for
                Next

                'Verificar tipo de usuario para redirigir al form correspodiente
                If tipo_usuario_sesion = "Administrador" Then
                    'Mostrar Menú del administrador
                    'Me.Hide()
                    MsgBox("Admin") 'Quitar esto
                ElseIf tipo_usuario_sesion = "Cliente" Then
                    'Mostrar Menú del cliente
                    'Me.Hide()
                    MsgBox("Cliente") 'Quitar esto
                End If
            End If


        Catch ex As Exception
            MsgBox("Error al buscar al usuario")
        Finally
            conexion.Close()
        End Try
    End Sub
End Class