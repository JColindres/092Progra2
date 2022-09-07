Imports System.Math

Public Class Form1

    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagoFinal As Double = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Aqui va el codigo relacionado a los calculos de los pagos

        'Verificando cada campo con IF////////////////////////////////////////

        If txtArroz.Text = "" Then 'Verifica que el campo no esté vacío
            MsgBox("No ingresó cantidad de arroz", , "Error - IF")
            txtArroz.Text = "0"
        ElseIf Not IsNumeric(Val(txtArroz.Text)) Then 'Verica que el campo contenga numeros
            MsgBox("No ingresó valores numéricos", , "Error - IF")
            txtArroz.Text = "0"
        End If

        If txtAzucar.Text = "" Then
            MsgBox("No ingresó cantidad de azucar", , "Error - IF")
            txtAzucar.Text = "0"
        ElseIf Not IsNumeric(Val(txtAzucar.Text)) Then
            MsgBox("No ingresó valores numéricos", , "Error - IF")
            txtArroz.Text = "0"
        End If

        If txtFrijol.Text = "" Then
            MsgBox("No ingresó cantidad de frijol", , "Error - IF")
            txtFrijol.Text = "0"
        ElseIf Not IsNumeric(Val(txtFrijol.Text)) Then
            MsgBox("No ingresó valores numéricos", , "Error - IF")
            txtArroz.Text = "0"
        End If

        'Verificando todo junto///////////////////////////////////////////////////////

        If txtFrijol.Text = "" Or txtAzucar.Text = "" Or txtArroz.Text = "" Then
            MsgBox("No ingresó cantidad de algun campo", , "Error - IF único")
            txtFrijol.Text = "0"
            txtArroz.Text = "0"
            txtAzucar.Text = "0"
        ElseIf Not IsNumeric(Val(txtFrijol.Text)) Or Not IsNumeric(Val(txtAzucar.Text)) Or Not IsNumeric(Val(txtArroz.Text)) Then
            MsgBox("No ingresó valores numéricos", , "Error - IF único")
            txtFrijol.Text = "0"
            txtArroz.Text = "0"
            txtAzucar.Text = "0"
        End If

        'Verificando con Select Case///////////////////////////////////////////////////

        'Not False = True

        Select Case txtArroz.Text
            Case Is = ""
                MsgBox("No ingresó cantidad de arroz", , "Error - Select Case")
                txtArroz.Text = "0"
            Case Else
                If Not IsNumeric(txtArroz.Text) Then
                    MsgBox("No ingresó valores numéricos", , "Error - IF en Select Case")
                    txtArroz.Text = "0"
                End If
        End Select

        Select Case txtAzucar.Text
            Case Is = ""
                MsgBox("No ingresó cantidad de arroz", , "Error")
                txtAzucar.Text = "0"
            Case Else
                If Not IsNumeric(txtAzucar.Text) Then
                    MsgBox("No ingresó valores numéricos", , "Error - IF en Select Case")
                    txtAzucar.Text = "0"
                End If
        End Select

        Select Case txtFrijol.Text
            Case Is = ""
                MsgBox("No ingresó cantidad de arroz", , "Error")
                txtFrijol.Text = "0"
            Case Else
                If Not IsNumeric(txtFrijol.Text) Then
                    MsgBox("No ingresó valores numéricos", , "Error - IF en Select Case")
                    txtFrijol.Text = "0"
                End If
        End Select




        pagoSinIVA = (Val(txtArroz.Text) * precioArroz) + (Val(txtFrijol.Text) * precioFrijol) + (Val(txtAzucar.Text) * precioAzucar)



        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA
        descuento = pagoConIVA * 0.025
        pagoFinal = pagoConIVA - descuento


        lblR1.Text = Math.Round(pagoSinIVA, 2)
        lblR2.Text = Round(valorIVA, 2)
        lblR3.Text = Round(pagoConIVA, 2)
        lblR4.Text = Round(descuento, 2)
        lblR5.Text = Round(pagoFinal, 2)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Aqui va el codigo relacionado a limpiar todas las variables

        'Aqui deben limpiar los textbox, los label de resultados y las variables de resultados

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Aqui va el codigo que pregunta si queremos cerrar la app
    End Sub

    Private Sub txtArroz_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Codigo que solo permite ingresar numeros
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If
    End Sub

    Private Sub txtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrijol.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAzucar.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
