Imports System.Data.SqlClient
Public Class Form3
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Por favor, llene todos los campos")
            Exit Sub
        End If

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "INSERT INTO Usuario(nombre,apellido,usuario,tipo_usr,nacimiento,contrasenia) VALUES(@name,@surname,@usr,@tipo_usr,@nac,@pwd);"
            myCmd.Parameters.AddWithValue("@name", TextBox4.Text)
            myCmd.Parameters.AddWithValue("@surname", TextBox3.Text)
            myCmd.Parameters.AddWithValue("@usr", TextBox1.Text)
            myCmd.Parameters.AddWithValue("@pwd", TextBox2.Text)
            myCmd.Parameters.AddWithValue("@tipo_usr", ComboBox1.Text)
            myCmd.Parameters.AddWithValue("@nac", DateTimePicker1.Value)

            Dim sePuede = verificar()

            If sePuede = 1 Then
                MsgBox("El Usuario Ya existe")
                Exit Sub
            ElseIf sePuede = -1 Then
                MsgBox("Algo Salió")
                Exit Sub
            End If

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            myCmd.ExecuteNonQuery()
            MsgBox("Usuario creado Exitosamente")
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "No se pudo registrar el usuario")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Public Function verificar() As Integer
        If TextBox1.Text = "" Then
            MsgBox("Por favor, llene todos los campos")
            Return -1
        End If

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Usuario WHERE usuario = @usr"
            myCmd.Parameters.AddWithValue("@usr", TextBox1.Text)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then 'Si las filas es igual a 0 es porque no se encontró nada
                Return 0
            Else
                Return 1
            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
            Return -1
        End Try
        Return -1
    End Function
End Class