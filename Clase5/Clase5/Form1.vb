Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers = New Integer() {1, 2, 3, 4, 5}

        MsgBox("El tamaño del arreglo es de: " + Str(numbers.Length()))

        For indice As Integer = 0 To (numbers.Length() - 1) Step 2
            MsgBox("El contenido del elemento es: " + Str(numbers(indice)))
            Debug.WriteLine("El contenido del elemento es: " + Str(numbers(indice)))
        Next


        For Each elemento In numbers
            MsgBox("El contenido del elemento es: " + Str(elemento))
            Debug.WriteLine("El contenido del elemento es: " + Str(elemento))

            If elemento = 3 Then
                Exit For
            End If
        Next
    End Sub
End Class
