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
        Try
            IniciarConexion()
            comando.Connection = conexion
            comando.CommandText = "SELECT * FROM Usuario WHERE username = @username AND password = @password"
            comando.Parameters.AddWithValue("@username", txtUsername.Text)
            comando.Parameters.AddWithValue("@password", txtPwd.Text)
            Dim dt As DataTable = New DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                MsgBox("Se encontró al usuario")
            Else
                MsgBox("Credenciales erroneas")
            End If

            conexion.Close()

        Catch ex As Exception
            MsgBox("Error al buscar al usuario")
        End Try
    End Sub
End Class