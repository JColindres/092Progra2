Imports System.Data.SqlClient

Public Class Form4
    Private myConn As SqlConnection
    Private myCmd As SqlCommand

    Dim id_libro As Integer

    Dim libro As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
                                FROM Libro, Prestamo, Genero, Editorial																	 
                                WHERE Prestamo.id_libro = Libro.id_libro																 
                                AND Libro.id_editorial = Editorial.id_editorial															
                                AND Libro.genero = Genero.id_genero																				 
                                GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre"

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                'guardaremos la info en las variables del módulo
                Dim titulo = row.ItemArray(0)
                Dim autor = row.ItemArray(1)
                Dim genero = row.ItemArray(2)
                Dim editorial = row.ItemArray(3)
                Dim disp = row.ItemArray(4)
                If disp > 0 Then
                    DataGridView1.Rows.Add(titulo, autor, genero, editorial, disp)
                End If
            Next

            myConn.Close()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Genero"

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter2 As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table2 As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter2.Fill(table2)

            For Each row As DataRow In table2.Rows 'Por cada de la fila de la tabla, accederemos a su información
                'guardaremos la info en las variables del módulo
                Dim genero = row.ItemArray(1)
                ComboBox1.Items.Add(genero)
            Next

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            If ComboBox1.SelectedIndex <> -1 And TextBox1.Text = Nothing Then
                myCmd.CommandText = "SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
                                FROM Libro, Prestamo, Genero, Editorial																	 
                                WHERE Prestamo.id_libro = Libro.id_libro																 
                                AND Libro.id_editorial = Editorial.id_editorial															
                                AND Libro.genero = Genero.id_genero
                                AND Genero.nombre = @genero
                                GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre"
                myCmd.Parameters.AddWithValue("@genero", ComboBox1.Text)
            ElseIf TextBox1.Text <> Nothing And ComboBox1.SelectedIndex = -1 Then
                myCmd.CommandText = "SELECT DISTINCT Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
                                FROM Libro, Prestamo, Genero, Editorial																	 
                                WHERE Prestamo.id_libro = Libro.id_libro																 
                                AND Libro.id_editorial = Editorial.id_editorial															
                                AND Libro.genero = Genero.id_genero
                                AND Libro.titulo LIKE @titulo
                                GROUP BY Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre"
                myCmd.Parameters.AddWithValue("@titulo", "%" + TextBox1.Text + "%")
            Else
                MsgBox("Solo está permitido un tipo de búsqueda")
                Exit Sub
            End If


            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                'guardaremos la info en las variables del módulo
                Dim titulo = row.ItemArray(0)
                Dim autor = row.ItemArray(1)
                Dim genero = row.ItemArray(2)
                Dim editorial = row.ItemArray(3)
                Dim disp = row.ItemArray(4)
                If disp > 0 Then
                    DataGridView1.Rows.Add(titulo, autor, genero, editorial, disp)
                End If
            Next

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try




    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        libro = DataGridView1.Item(0, e.RowIndex).Value.ToString()

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT DISTINCT Libro.id_libro, Libro.titulo AS [Titulo], Libro.autor AS [Autor], Genero.nombre AS [Género], Editorial.nombre AS [Editorial], Libro.cantidad - COUNT(Prestamo.id_libro) AS [Disponibles]
                                FROM Libro, Prestamo, Genero, Editorial																	 
                                WHERE Prestamo.id_libro = Libro.id_libro																 
                                AND Libro.id_editorial = Editorial.id_editorial															
                                AND Libro.genero = Genero.id_genero
                                AND Libro.titulo = @libro
                                GROUP BY Libro.id_libro, Prestamo.id_libro, Libro.titulo, Libro.cantidad, Libro.autor, Genero.nombre, Editorial.nombre"
            myCmd.Parameters.AddWithValue("@libro", libro)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                'guardaremos la info en las variables del módulo
                id_libro = row.ItemArray(0)
            Next

            myConn.Close()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "INSERT INTO Prestamo(id_usuario,id_libro,estatus) VALUES(@usr,@lib,1);"
            myCmd.Parameters.AddWithValue("@usr", id_usuario_sesion)
            myCmd.Parameters.AddWithValue("@lib", id_libro)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            myCmd.ExecuteNonQuery()
            MsgBox("Se prestó " & libro & " Exitosamente")
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "No se pudo prestar el libro")
        End Try

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Form4_Load(e, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class