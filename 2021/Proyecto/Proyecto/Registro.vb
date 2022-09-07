Imports MySql.Data.MySqlClient

Public Class Registro

    Private Sub Registro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "INSERT INTO Usuario (nombre, username, password, tipo_usuario) VALUES (@nombre, @username, @pwd, @tp)" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@username", txtUsername.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@pwd", txtPwd.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@tp", cbTipo.SelectedItem) 'Enviamos parámetro a evaluar

            Dim resultado = comando.ExecuteNonQuery()
            If resultado = 1 Then
                MsgBox("¡Usuario registrado con éxito!")
            End If


        Catch ex As Exception
            MsgBox("Error al registrar al usuario")
        Finally
            conexion.Close()
        End Try
    End Sub
End Class