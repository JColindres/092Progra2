Public Class Form1
    Private Sub cbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles cbCompra.CheckedChanged
        If cbCompra.Checked = True Then
            txtCompra.Enabled = True
        Else
            txtCompra.Enabled = False
        End If
    End Sub

    Private Sub cbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles cbVenta.CheckedChanged
        If cbVenta.Checked = True Then
            txtVenta.Enabled = True
        Else
            txtVenta.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub
End Class
