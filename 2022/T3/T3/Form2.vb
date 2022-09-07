Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox(Form1.Label1.Text)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.compraDolar.Checked Then
            Label1.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.txtCompra.Text, tcDolar))

            'terminar los otros else if que verifiquen qué tipo de cambio estan comprando
        End If



        'otro if donde verifique que tipo de cambio se está vendiendo
    End Sub
End Class