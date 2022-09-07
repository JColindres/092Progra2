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

    Dim ofd As New OpenFileDialog
    Dim ruta As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ofd.Filter = "Musica en MP3|*.mp3;"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = ofd.FileName
            AxWindowsMediaPlayer1.URL = ruta
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            ListBox1.Items.Add(ruta)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem.ToString
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

End Class
