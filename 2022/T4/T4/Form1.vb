Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click



        If index < 6 Then
            pago(index) = 500
            descuento(index) = pago(index) * 0.05 * (-1)
            recargo(index) = pago(index) * 0.1
            total(index) = pago(index) + descuento(index) + recargo(index)


            ListBox1.Items.Add(pago(index))
            ListBox2.Items.Add(descuento(index))
            ListBox3.Items.Add(recargo(index))

            DataGridView1.Rows.Add(0, 0, 0, 0, 0, 0, pago(index), descuento(index), recargo(index), total(index))
            index = index + 1
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

    End Sub
End Class
