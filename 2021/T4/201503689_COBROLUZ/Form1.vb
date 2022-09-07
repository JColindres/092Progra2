Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If (Txt_Nombre.Text = "") Then

            MsgBox("Ingrese su nombre por favor", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            Txt_Nombre.Focus()

        End If

        If (Txt_NIT.Text = "") Then

            MsgBox("Ingrese su NIT por favor", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            Txt_Nombre.Focus()

        End If

        If (Txt_watts.Text = "") Then

            MsgBox("Ingrese el consumo de kilowatts por favor", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            Txt_Nombre.Focus()

        End If

        If (Txt_saldant.Text = "") Then

            MsgBox("Ingrese el saldo anterior por favor, de no existir colocar 0", vbQuestion)

            Limpiar_Entradas()

            Exit Sub

            Txt_saldant.Focus()

        End If

        If (indice < 11) Then

            Cliente(indice) = Txt_Nombre.Text
            Servicio(indice) = ComboBox_Servicio.Text
            Tarifa(indice) = ComboBox_Tarifa.Text
            SaldoAnterior(indice) = Txt_saldant.Text


            If Str(ComboBox_Servicio.Text = "Residencial") Then

                Select Case Val(Txt_watts.Text)

                    Case 1 To 100
                        total_pagoini = Val(Txt_watts.Text) * Residencial1
                    Case 101 To 300
                        total_pagoini = Val(Txt_watts.Text) * Residencial2
                    Case >= 301
                        total_pagoini = Val(Txt_watts.Text) * Residencial3

                End Select

                PagoInicial(indice) = Math.Round(total_pagoini, 2)

            End If

            If Str(ComboBox_Servicio.Text = "Industrial") Then

                Select Case Val(Txt_watts.Text)

                    Case 1 To 100
                        total_pagoini = Val(Txt_watts.Text) * Industrial1
                    Case 101 To 300
                        total_pagoini = Val(Txt_watts.Text) * Industrial2
                    Case >= 301
                        total_pagoini = Val(Txt_watts.Text) * Industrial3

                End Select

                PagoInicial(indice) = Math.Round(total_pagoini, 2)

            End If

            If Val(Txt_saldant.Text) > 0 Then

                total_recargo = (Val(Txt_saldant.Text) * mora_aplicada)
                Mora(indice) = (mora_aplicada * 100).ToString + "%"

            ElseIf Val(Txt_saldant.Text) <= 0 Then

                Mora(indice) = "No se aplica mora"

            End If

            total_conmora = Val(Txt_saldant.Text) + total_recargo
            PMora(indice) = Math.Round(total_conmora, 2)



            Select Case ComboBox_Tarifa.Text
                Case "Social"


                    total_pagopar = (Val(Txt_saldant.Text) + total_pagoini) + total_recargo
                    PagoParcial(indice) = total_pagopar


                    total_tarifa = total_pagopar * descuento_social
                    Descuento(indice) = (descuento_social * 100).ToString + "%"

                    total_pagofin = total_pagopar - total_tarifa
                    PagoTotal(indice) = Math.Round(total_pagofin, 2)


                Case "No Social"

                    'Acá me quede programando, únicamente me falta lo último
                    total_tarifa = total_pagoini - (total_pagoini * descuento_nosocial)
                    Descuento(indice) = (descuento_nosocial * 100).ToString + "%"

                    PagoInicial(indice) = Math.Round(total_tarifa, 2)

                    total_pagopar = total_tarifa + total_conmora
                    PagoParcial(indice) = Math.Round(total_pagopar, 2)

                    total_pagofin = total_pagopar

                    PagoTotal(indice) = Math.Round(total_pagofin, 2)
                    MsgBox("Recuerde que el descuento fue aplicado a su tarifa en el pago inicial de mes, por lo que el pago parcial y el total reflejarán el mismo valor", vbExclamation, "Recordatorio")

            End Select

            mostrar()

            indice = indice + 1

        End If

        If (indice > 10) Then

            MsgBox("Limite de 11 ingresos alcanzado")

        End If

        Limpiar_Entradas()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click

        LimpiarV()

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click

        Limpiar_Entradas()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub
    Dim arreglo(3) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        arreglo(0) = "Hola"
        arreglo(1) = "como"
        arreglo(2) = "estas"

        MsgBox(arreglo(0) + ", " + arreglo(1) + arreglo(2) + "?")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(arreglo(0) + ", " + arreglo(1) + arreglo(2) + "?")

        ReDim arreglo(0 To arreglo.Length - 1)

        MsgBox(arreglo(0) + ", " + arreglo(1) + arreglo(2) + "?")

        For index = 0 To arreglo.Length - 1
            arreglo(index) = ""
        Next


        MsgBox(arreglo(0) + ", " + arreglo(1) + arreglo(2) + "?")

        arreglo(0) = "Hola"
        arreglo(1) = "como"
        arreglo(2) = "estas"

        MsgBox(arreglo(0) + ", " + arreglo(1) + arreglo(2) + "?")

    End Sub
End Class
