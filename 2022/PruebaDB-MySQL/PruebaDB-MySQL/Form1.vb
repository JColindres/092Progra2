Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim myConnectionString As String

        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=1068868;" _
                    & "database=prueba"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            MsgBox("Conexion Exitosa")
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            IniciarConexion()
            comando.Connection = conexion
            comando.CommandText = "SELECT * FROM personas"
            Dim dt As DataTable = New DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            MsgBox("Consulta Exitosa")
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error en la consulta!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nombre As String = "pablo"
        Dim apellido As String = "orellana"
        Try
            IniciarConexion()
            comando.Connection = conexion
            comando.CommandText = "INSERT INTO personas (nombre, apellido) VALUES(@nombre, @apellido)"

            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@apellido", apellido)
            comando.ExecuteNonQuery()
            MsgBox("Registro Exitoso")
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error en el registro!")
        End Try


    End Sub
End Class
