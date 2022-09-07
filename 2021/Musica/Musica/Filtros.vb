Imports MySql.Data.MySqlClient

Public Class Filtros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String = "SELECT c.titulo, c.album, c.fecha_lanzamiento, c.genero, a.nombre FROM cancion c, artista a WHERE c.Artista_idArtista = a.idArtista "

        If TextBox1.Text <> "" Then
            consulta = consulta & " AND a.nombre LIKE @artista"
        End If

        If TextBox2.Text <> "" Then
            consulta = consulta & " AND c.titulo LIKE @titulo"
        End If

        If ComboBox1.SelectedIndex <> -1 Then
            consulta = consulta & " AND c.genero = @genero"
        End If
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.Parameters.AddWithValue("@artista", "%" + TextBox1.Text + "%") 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@titulo", "%" + TextBox2.Text + "%") 'Enviamos parámetro a evaluar
            comando.Parameters.AddWithValue("@genero", ComboBox1.SelectedItem) 'Enviamos parámetro a evaluar
            comando.CommandText = consulta 'Escribimos la consulta SQL deseada
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("Error al cargar artistas")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub Filtros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGenero()
    End Sub

    Public Sub CargarGenero()
        IniciarConexion()
        Try
            comando = New MySqlCommand 'Inicializamos nuevamente un comando
            comando.Connection = conexion 'Le asignamos la conexion declarada en el módulo
            comando.CommandText = "SELECT DISTINCT genero FROM cancion" 'Escribimos la consulta SQL deseada
            Dim dt As DataTable = New DataTable 'Inicializamos nueva instancia de una Tabla de datos
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando) 'Ejecutamos el comando con todas sus propiedades establecidas arriba
            da.Fill(dt) 'La consulta ejecutada la guardamos en la Tabla de datos

            For Each row As DataRow In dt.Rows 'Por cada de la fila de la tabla, accederemos a su información
                ComboBox1.Items.Add(row.ItemArray(0))
            Next

        Catch ex As Exception
            MsgBox("Error al cargar artistas")
        Finally
            conexion.Close()
        End Try
    End Sub
End Class