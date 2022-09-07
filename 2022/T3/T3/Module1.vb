Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPM = 0.38
    Public Const tcEuro = 7.89
    Public Const tcCCR = 0.012

    Const comisionCompra = 2.5 / 100
    Const comisionVenta = 3 / 100

    Dim total_parcial = 0
    Dim total

    Sub limpiar()
        Form1.txtCompra.Clear()
        Form1.txtVenta.Clear()
        Form1.cbCompra.Checked = False
        Form1.cbVenta.Checked = False

        Form2.Label1.Text = "Limpio"


    End Sub

    Function calcularCompra(cantidadCompra As Double, tipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            total_parcial = cantidadCompra / tipoCompra
            total = total_parcial * comisionCompra + total_parcial

        End If

        Return Math.Round(total, 2)
    End Function

    Function calcularVenta(cantidadVenta As Double, tipoVenta As Double) As Double
        If cantidadVenta > 0 Then
            total_parcial = cantidadVenta * tipoVenta
            total = total_parcial * comisionVenta + total_parcial
        End If

        Return Math.Round(total, 2)
    End Function

End Module
