Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub ArtistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtistaToolStripMenuItem.Click
        Artista.Show()
    End Sub

    Private Sub CancionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancionesToolStripMenuItem.Click
        Canciones.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Datos_Artistas()
    End Sub

    Public Sub Cargar_Datos_Artistas()
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT DISTINCT * FROM Artista" 'Escribimos la consulta SQL deseada
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox("Error al cargar artistas")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim id_artista = Val(DataGridView1.Rows.Item(e.RowIndex).Cells(0).Value.ToString)

        Cargar_Canciones(id_artista)
    End Sub

    Public Sub Cargar_Canciones(id As Integer)
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT * FROM Cancion WHERE Artista_idArtista = @id" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@id", id) 'Enviamos parámetro a evaluar
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            DataGridView2.DataSource = dt
            DataGridView2.Columns(0).Visible = False
            DataGridView2.Columns(6).Visible = False

        Catch ex As Exception
            MsgBox("Error al cargar artistas")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        AxWindowsMediaPlayer1.URL = DataGridView2.Rows.Item(e.RowIndex).Cells(5).Value.ToString
        AxWindowsMediaPlayer1.Ctlcontrols.play()

        Dim id_cancion = Val(DataGridView2.Rows.Item(e.RowIndex).Cells(0).Value.ToString)
        mensaje_reproducir(id_cancion)
    End Sub

    Public Sub mensaje_reproducir(id As Integer)
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT A.nombre, C.titulo, A.img_cover
                                    FROM Artista A, Cancion C
                                    WHERE A.idArtista = C.Artista_idArtista
                                    AND C.idCancion = @id" 'Escribimos la consulta SQL deseada
            comando.Parameters.AddWithValue("@id", id) 'Enviamos parámetro a evaluar
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            For Each row As DataRow In dt.Rows 'Por cada de la fila de la tabla, accederemos a su información
                Label1.Text = "Reproduciendose:"

                Label2.Text = "Artista: " + row.ItemArray(0)
                Label3.Text = "Canción: " + row.ItemArray(1)

                Dim original As Image = Image.FromFile(row.ItemArray(2))
                Dim resized As Image = ResizeImage(original, New Size(200, 150))
                PictureBox1.Image = resized
                Exit For
            Next

        Catch ex As Exception
            MsgBox("Error al cargar artistas")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub FiltrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrosToolStripMenuItem.Click
        Filtros.Show()
    End Sub
End Class
