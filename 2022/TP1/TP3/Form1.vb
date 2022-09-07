Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rbSmall.Checked = False And rbMedium.Checked = False And rbLarge.Checked = False Then
            MsgBox("No has elegido tamaño")
            End
        End If

        If rbAlgodon.Checked = False And rbSeda.Checked = False And rbLona.Checked = False Then
            MsgBox("No has elegido material")
            End
        End If

        If txtCantidad.Text = "" Then
            MsgBox("Ingrese una cantidad")
            End
        End If

        Dim tamaño As String
        Dim material As String

        If rbSmall.Checked Then
            tamaño = "Small"
        ElseIf rbMedium.Checked Then
            tamaño = "Medium"
        Else
            tamaño = "Large"
        End If

        If rbSeda.Checked Then
            material = "Seda"
        ElseIf rbAlgodon.Checked Then
            material = "Algodón"
        Else
            material = "Lon"
        End If

        Calcular(material, tamaño, Val(txtCantidad.Text))
        Me.Hide()
        Form2.Show()

    End Sub
End Class
