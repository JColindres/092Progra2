Public Class Form1
    Private Sub btnTestCon_Click(sender As Object, e As EventArgs) Handles btnTestCon.Click
        ProbarConexion()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
