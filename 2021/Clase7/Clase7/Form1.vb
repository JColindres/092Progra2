Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Hacer la verificacion de los datos (Elegir funcion y cine)
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Los campos estan vacios")
            Exit Sub
        ElseIf IsNumeric(TextBox1.Text) = False Then
            MsgBox("Las entradas no son numeros")
            Exit Sub
        End If



        'Envio de la funcion y cine
        If indice < 9 Then
            'Guardando valores en los vectores
            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox1.SelectedItem

            subtotal_a_pagar(indice) = Val(TextBox1.Text) * calcularSubtotal("1", "A") 'Llamada a la funcion del modulo1
            Label5.Text = Val(Label5.Text) + subtotal_a_pagar(indice)


            vdescuento1(indice) = Math.Round(subtotal_a_pagar(indice) * calculoDescuento1(vfuncion(indice), vcine(indice)), 2) 'Llamada a la funcion del modulo1
            'Calcular el descuento 2 y el total a pagar


            Funcion.Items.Add(vfuncion(indice))
            Cine.Items.Add(vcine(indice))
            SubTotal.Items.Add(subtotal_a_pagar(indice))
            Descuento1.Items.Add(vdescuento1(indice))
        ElseIf indice >= 9 Then

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
        MsgBox(vfuncion(0))
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Button2.Click, Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    'Limpiar entradas
End Class
