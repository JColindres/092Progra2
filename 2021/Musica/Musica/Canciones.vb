Imports MySql.Data.MySqlClient

Public Class Canciones

    Dim id_artista = 0
    Dim paths As String()
    Dim filenames As String()

    Private Sub Canciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Artistas_Nombre()

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT DISTINCT * FROM Artista WHERE nombre = @nombre" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@nombre", ComboBox1.SelectedItem) 'Enviamos parámetro a evaluar
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            For Each row As DataRow In dt.Rows 'Por cada de la fila de la tabla, accederemos a su información
                id_artista = row.ItemArray(0)
                'Cargar Imagen
                Dim original As Image = Image.FromFile(row.ItemArray(4))
                Dim resized As Image = ResizeImage(original, New Size(200, 150))
                PictureBox1.Image = resized
            Next

        Catch ex As Exception
            MsgBox("Error al cargar artistas")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            paths = OpenFileDialog1.SafeFileNames
            filenames = OpenFileDialog1.FileNames
            For i As Integer = 0 To filenames.Length - 1
                DataGridView1.Rows.Add(System.IO.Path.GetFileNameWithoutExtension(filenames(i)), filenames(i))
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        IniciarConexion()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    comando = New MySqlCommand 'Inicializamos nuevamente un comando
                    comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
                    comando.CommandText = "INSERT INTO Cancion (titulo, album, fecha_lanzamiento, genero, ubicacion, Artista_idArtista) VALUES (@titulo, @album, @fecha_lanzamiento, @genero, @ubicacion, @Artista_idArtista)" 'Escribimos la consulta SQL deseada
                    comando.Parameters.AddWithValue("@titulo", row.Cells(0).Value.ToString) 'Enviamos parámetro a evaluar
                    comando.Parameters.AddWithValue("@album", TextBox1.Text) 'Enviamos parámetro a evaluar
                    comando.Parameters.AddWithValue("@fecha_lanzamiento", DateTimePicker1.Value.ToString("yyyy/MM/dd")) 'Enviamos parámetro a evaluar
                    comando.Parameters.AddWithValue("@genero", TextBox2.Text) 'Enviamos parámetro a evaluar
                    comando.Parameters.AddWithValue("@ubicacion", row.Cells(1).Value.ToString) 'Enviamos parámetro a evaluar
                    comando.Parameters.AddWithValue("@Artista_idArtista", id_artista) 'Enviamos parámetro a evaluar

                    comando.ExecuteNonQuery()
                End If


            Next
            MsgBox("¡Cancion(es) registrada(s) con éxito!")
        Catch ex As Exception
            MsgBox("Error al registrar cancion(es)")
        Finally
            conexion.Close()
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            Canciones_Load(e, e)
        End Try
    End Sub
End Class