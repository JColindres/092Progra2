Module Module1
    Public matriz(10, 7)

    Public indice = 0

    Sub Limpiar()
        Form1.txtCarnet.Clear()
        Form1.txtHoras.Clear()
        Form1.txtNombre.Clear()

        Form1.rbCheque.Checked = False
        Form1.rbEfectivo.Checked = False

        Form1.cbxDias.Text = "Seleccionar un día..."
        Form1.cbxIdioma.Text = "Seleccionar un idioma..."

        Form1.DataGridView1.Rows.Clear()

        ReDim matriz(10, 7)
        indice = 0

    End Sub
End Module
