Imports MySql.Data.MySqlClient

Public Class Artista
    Dim ruta1 As String
    Dim ruta2 As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bitmap|*.bmp|JPEG|*.jpg|PNG|*.png"
        If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Try
            ruta1 = ofd.FileName
            Dim bmp As New Bitmap(ruta1)
            If Not IsNothing(PictureBox1.Image) Then PictureBox1.Image.Dispose()
            PictureBox1.Image = bmp
            PictureBox1.Image = ResizeImage(PictureBox1.Image, New Size(200, 150))
        Catch
            MsgBox("Not a valid image file.")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bitmap|*.bmp|JPEG|*.jpg|PNG|*.png"
        If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Try
            ruta2 = ofd.FileName
            Dim bmp As New Bitmap(ruta2)
            If Not IsNothing(PictureBox2.Image) Then PictureBox2.Image.Dispose()
            PictureBox2.Image = bmp
            PictureBox2.Image = ResizeImage(PictureBox2.Image, New Size(200, 150))
        Catch
            MsgBox("Not a valid image file.")
        End Try
    End Sub

    Private Sub Artista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim original As Image = Image.FromFile("C:\Users\User\Desktop\Musica\calamardo.jpg")
        Dim resized As Image = ResizeImage(original, New Size(200, 150))
        PictureBox1.Image = resized
        PictureBox2.Image = resized

        Cargar_Artistas_Nombre()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "INSERT INTO Artista (nombre, nacionalidad, año_inicio, img_cover) VALUES (@nombre, @nac, @fecha, @img)" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@nombre", TextBox1.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@nac", TextBox2.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@fecha", DateTimePicker1.Value.ToString("yyyy/MM/dd")) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@img", ruta1) 'Enviamos parámetro a evaluar

            Dim resultado = comando.ExecuteNonQuery()
            If resultado = 1 Then
                MsgBox("¡Artista registrado con éxito!")
            End If

        Catch ex As Exception
            MsgBox("Error al registrar al usuario")
        Finally
            conexion.Close()
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            Artista_Load(e, e)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "UPDATE Artista SET nombre = @nombre, nacionalidad = @nac, año_inicio = @fecha, img_cover = @img WHERE nombre = @viejo" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@nombre", TextBox4.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@nac", TextBox3.Text) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@fecha", DateTimePicker2.Value.ToString("yyyy/MM/dd")) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@img", ruta2) 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@viejo", ComboBox1.SelectedItem) 'Enviamos parámetro a evaluar

            Dim resultado = comando.ExecuteNonQuery()
            If resultado = 1 Then
                MsgBox("¡Artista modificar con éxito!")
            End If

        Catch ex As Exception
            MsgBox("Error al modificar al usuario")
        Finally
            conexion.Close()
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            Artista_Load(e, e)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT DISTINCT * FROM Artista WHERE nombre = @nombre" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@nombre", ComboBox1.SelectedItem) 'Enviamos parámetro a evaluar
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            Dim id_artista = 0
            For Each row As DataRow In dt.Rows 'Por cada de la fila de la tabla, accederemos a su información
                id_artista = row.ItemArray(0)
                Exit For
            Next

            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "DELETE FROM Cancion WHERE Artista_idArtista = @id" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@id", id_artista) 'Enviamos parámetro a evaluar

            Dim resultado1 = comando.ExecuteNonQuery()
            If resultado1 = 1 Then
                MsgBox("¡Canciones eliminadas con éxito!")
            End If


            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "DELETE FROM Artista WHERE nombre = @nombre" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@nombre", ComboBox1.SelectedItem) 'Enviamos parámetro a evaluar

            Dim resultado2 = comando.ExecuteNonQuery()
            If resultado2 = 1 Then
                MsgBox("¡Artista eliminado con éxito!")
            End If

        Catch ex As Exception
            MsgBox("Error al eliminar artista")
        Finally
            conexion.Close()
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            Artista_Load(e, e)
        End Try
    End Sub

    Public Sub Cargar_Artistas_Nombre()
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT DISTINCT * FROM Artista" 'Escribimos la consulta SQL deseada
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            For Each row As DataRow In dt.Rows 'Por cada de la fila de la tabla, accederemos a su información
                ComboBox1.Items.Add(row.ItemArray(1))
            Next

        Catch ex As Exception
            MsgBox("Error al cargar artistas")
        Finally
            conexion.Close()
        End Try
    End Sub

End Class