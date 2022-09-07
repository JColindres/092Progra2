Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Validar Todas las Entradas (fecha no es necesario)
        If txtCarnet.Text = "" Then
            MsgBox("Error Campo Carné")
            Exit Sub
        End If

        If cbxIdioma.SelectedIndex = -1 Then
            MsgBox("Error Campo Idioma")
            Exit Sub
        End If

        'Verificar que no hayan más de 8 registros
        If indice < 8 Then
            'Guardar todos los campos de entrada en la matriz
            matriz(0, indice) = txtCarnet.Text
            matriz(1, indice) = txtNombre.Text
            matriz(2, indice) = cbxIdioma.SelectedItem
            matriz(3, indice) = dtpFecha.Value
            matriz(4, indice) = cbxDias.SelectedItem
            matriz(5, indice) = txtHoras.Text

            If rbCheque.Checked Then
                matriz(6, indice) = rbCheque.Text
            ElseIf rbEfectivo.Checked Then
                matriz(6, indice) = rbEfectivo.Text
            End If

            'Realizar calculos del pago parcial, descuento 1, descuento 2 y total
            'Guardar los calculos en las posiciones restantes de la matriz {7,8,9,10}


            'Guardar las posiciones restantes de la matriz en el datagridview >>>------------------>>>---------------->>>
            DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), 0, 0, 0, 0)
            indice = indice + 1
        Else
            MessageBox.Show("Ya se llegó al límite")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()

        Dim uno As Integer = 9 / 4
        Dim dos As Integer = 9 Mod 4

        MessageBox.Show("Div: " & uno & " Mod: " & dos)
    End Sub
End Class
