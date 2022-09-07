Public Class Form1



    Private Sub HiloCrudo_CheckedChanged(sender As Object, e As EventArgs) Handles HiloCrudo.CheckedChanged
        If HiloCrudo.Checked = True Then
            txtHilo.Enabled = True
            txtHilo.Text = "0"
        Else
            txtHilo.Enabled = False
            txtHilo.Text = "0"
        End If
    End Sub

    Private Sub Algodón_CheckedChanged(sender As Object, e As EventArgs) Handles Algodón.CheckedChanged
        If Algodón.Checked = True Then
            txtAlgodon.Enabled = True
            txtAlgodon.Text = "0"
        Else
            txtAlgodon.Enabled = False
            txtAlgodon.Text = "0"
        End If
    End Sub

    Private Sub Seda_CheckedChanged(sender As Object, e As EventArgs) Handles Seda.CheckedChanged
        If Seda.Checked = True Then
            txtSeda.Enabled = True
            txtSeda.Text = "0"
        Else
            txtSeda.Enabled = False
            txtSeda.Text = "0"
        End If
    End Sub

    Private Sub Lino_CheckedChanged(sender As Object, e As EventArgs) Handles Lino.CheckedChanged
        If Lino.Checked = True Then
            txtLino.Enabled = True
            txtLino.Text = "0"
        Else
            txtLino.Enabled = False
            txtLino.Text = "0"
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        lblPrecioCosto.Text = "0.00"
        precioCosto = 0.00
        sumaYardas = Val(txtAlgodon.Text) + Val(txtHilo.Text) + Val(txtLino.Text) + Val(txtSeda.Text)

        If King.Checked = True Then
            If sumaYardas = matKing Then
                precioCosto = precioKing + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtSeda.Text) * precioSeda
                'Falta poner else de que faltan o sobran materiales (msgbox) <--- ustedes lo hacen
            End If
        ElseIf Queen.Checked = True Then
            If sumaYardas = matQuen Then
                precioCosto = precioQueen + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtSeda.Text) * precioSeda
                'Falta poner else de que faltan o sobran materiales (msgbox) <--- ustedes lo hacen
            End If
        ElseIf Matrimonial.Checked = True Then
            If sumaYardas = matMat Then
                precioCosto = precioMatr + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtSeda.Text) * precioSeda
                'Falta poner else de que faltan o sobran materiales (msgbox) <--- ustedes lo hacen
            End If
        ElseIf Imperial.Checked = True Then
            If sumaYardas = matImp Then
                precioCosto = precioImp + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtSeda.Text) * precioSeda
                'Falta poner else de que faltan o sobran materiales (msgbox) <--- ustedes lo hacen
            End If
        End If

        lblPrecioCosto.Text = Str(precioCosto)
    End Sub
End Class
