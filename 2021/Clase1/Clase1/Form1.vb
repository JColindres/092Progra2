Public Class Form1

    'Variable Global
    Dim resultado As Object
    Dim operando1 As Object
    Dim operando2 As Object


    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles Suma.Click

        operando1 = InputBox("Escriba el primer numero")
        operando2 = InputBox("Escriba el segundo numero")
        If IsNumeric(operando1) And IsNumeric(operando2) Then
            resultado = Val(operando1) + Val(operando2)
            MessageBox.Show("La respuesta es: " & resultado)
        End If
        If Not IsNumeric(operando1) Or Not IsNumeric(operando2) Then
            MessageBox.Show("Los operandos no son de tipo numerico")
        End If
    End Sub

    Private Sub Resta_Click(sender As Object, e As EventArgs) Handles Resta.Click

        operando1 = InputBox("Escriba el primer numero")
        operando2 = InputBox("Escriba el segundo numero")
        If IsNumeric(operando1) And IsNumeric(operando2) Then
            resultado = Val(operando1) - Val(operando2)
            MessageBox.Show(resultado)
        End If
        If Not IsNumeric(operando1) Or Not IsNumeric(operando2) Then
            MessageBox.Show("Los operandos no son de tipo numerico")
        End If
    End Sub

    Private Sub Multiplicacion_Click(sender As Object, e As EventArgs) Handles Multiplicacion.Click

        operando1 = InputBox("Escriba el primer numero")
        operando2 = InputBox("Escriba el segundo numero")
        If IsNumeric(operando1) And IsNumeric(operando2) Then
            resultado = Val(operando1) * Val(operando2)
            MessageBox.Show(resultado)
        End If
        If Not IsNumeric(operando1) Or Not IsNumeric(operando2) Then
            MessageBox.Show("Los operandos no son de tipo numerico")
        End If
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click

        operando1 = InputBox("Escriba el primer numero")
        operando2 = InputBox("Escriba el segundo numero")
        If IsNumeric(operando1) And IsNumeric(operando2) Then
            resultado = Val(operando1) / Val(operando2)
            MessageBox.Show(resultado)
        End If
        If Not IsNumeric(operando1) Or Not IsNumeric(operando2) Then
            MessageBox.Show("Los operandos no son de tipo numerico")
        End If
    End Sub

    Private Sub Pot_Click(sender As Object, e As EventArgs) Handles Pot.Click

        operando1 = InputBox("Escriba el primer numero")
        operando2 = InputBox("Escriba el segundo numero")
        If IsNumeric(operando1) And IsNumeric(operando2) Then
            resultado = Val(operando1) ^ Val(operando2)
            MessageBox.Show(resultado)
        End If
        If Not IsNumeric(operando1) Or Not IsNumeric(operando2) Then
            MessageBox.Show("Los operandos no son de tipo numerico")
        End If
    End Sub
End Class
