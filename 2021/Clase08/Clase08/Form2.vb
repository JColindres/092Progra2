Imports System.Data.SqlClient

Public Class Form2
    Private myConn As SqlConnection
    Private myCmd As SqlCommand


    Private nombreEditorial As String
    Private direccionEditorial As String
    Private telefonoEditorial As Int64

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = nombre_sesion + " " + apellido_sesion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Editorial"

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
                Dim nom = row.ItemArray(1)
                Dim dir = row.ItemArray(2)
                Dim tel = row.ItemArray(3)
                DataGridView1.Rows.Add(nom, dir, tel)
            Next

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id_usuario_sesion = ""
        nombre_sesion = ""
        apellido_sesion = ""
        usuario_sesion = ""
        tipo_usuario_sesion = ""
        nacimiento_sesion = Nothing

        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Por favor, llene todos los campos")
            Exit Sub
        End If

        If Not IsNumeric(Val(TextBox4.Text)) Then
            MsgBox("El campo telefono, debe ser de tipo numerico")
            Exit Sub
        End If
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "INSERT INTO Editorial(nombre,direccion,telefono) VALUES(@name,@dir,@tel);"
            myCmd.Parameters.AddWithValue("@name", TextBox4.Text)
            myCmd.Parameters.AddWithValue("@dir", TextBox3.Text)
            myCmd.Parameters.AddWithValue("@tel", TextBox1.Text)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            myCmd.ExecuteNonQuery()
            MsgBox("Editorial registrada Exitosamente")
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "No se pudo registrar la editorial")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        nombreEditorial = DataGridView1.Item(0, e.RowIndex).Value.ToString()
        direccionEditorial = DataGridView1.Item(1, e.RowIndex).Value.ToString()
        telefonoEditorial = Val(DataGridView1.Item(2, e.RowIndex).Value.ToString())

        TextBox4.Text = nombreEditorial
        TextBox3.Text = direccionEditorial
        TextBox1.Text = Str(telefonoEditorial)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Por favor, llene todos los campos")
            Exit Sub
        End If

        If nombreEditorial = "" Or direccionEditorial = "" Or telefonoEditorial = Nothing Then
            MsgBox("Por favor, seleccione la editorial a modificar")
            Exit Sub
        End If

        If Not IsNumeric(Val(TextBox4.Text)) Then
            MsgBox("El campo telefono, debe ser de tipo numerico")
            Exit Sub
        End If
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "UPDATE Editorial SET nombre = @nuevoNombre, direccion = @nuevaDireccion, telefono = @nuevoTelefono WHERE nombre = @viejoNombre AND direccion = @viejaDireccion AND telefono = @viejoTelefono;"
            myCmd.Parameters.AddWithValue("@nuevoNombre", TextBox4.Text)
            myCmd.Parameters.AddWithValue("@nuevaDireccion", TextBox3.Text)
            myCmd.Parameters.AddWithValue("@nuevoTelefono", TextBox1.Text)

            myCmd.Parameters.AddWithValue("@viejoNombre", nombreEditorial)
            myCmd.Parameters.AddWithValue("@viejaDireccion", direccionEditorial)
            myCmd.Parameters.AddWithValue("@viejoTelefono", telefonoEditorial)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            myCmd.ExecuteNonQuery()
            MsgBox("Editorial modificada Exitosamente")
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "No se pudo modificar la editorial")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Por favor, llene todos los campos")
            Exit Sub
        End If

        If nombreEditorial = "" Or direccionEditorial = "" Or telefonoEditorial = Nothing Then
            MsgBox("Por favor, seleccione la editorial a eliminar")
            Exit Sub
        End If

        If Not IsNumeric(Val(TextBox4.Text)) Then
            MsgBox("El campo telefono, debe ser de tipo numerico")
            Exit Sub
        End If
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=SoulHealer_201602713;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "DELETE FROM Editorial
                                WHERE nombre = @nombre
                                AND direccion = @direccion
                                AND telefono = @telefono;"

            myCmd.Parameters.AddWithValue("@nombre", nombreEditorial)
            myCmd.Parameters.AddWithValue("@direccion", direccionEditorial)
            myCmd.Parameters.AddWithValue("@telefono", telefonoEditorial)

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            myCmd.ExecuteNonQuery()
            MsgBox("Editorial eliminidad Exitosamente")
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "No se pudo eliminar la editorial")
        End Try
    End Sub
End Class