Module Module1

    Public index = 0
    'Vectores de entrada
    Public paciente(5)
    Public nit(5)
    Public dias_hosp(5)
    Public honorarios(5)
    Public habitacion(5)
    Public Servicio(5)

    'Vectores para el calculo
    Public pago(5)
    Public descuento(5)
    Public recargo(5)
    Public total(5)


    Sub limpiar_vectores()
        ReDim pago(5)
        ReDim descuento(5)
        ReDim recargo(5)

        index = 0
    End Sub

    Sub limpiar_entradas()
        limpiar_vectores()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.DataGridView1.Rows.Clear()

        index = 0
    End Sub

    Sub limpiar_vectores2()

        For contador = 0 To index - 1
            pago(contador) = Nothing
            descuento(contador) = Nothing
            recargo(contador) = Nothing
        Next

        index = 0
    End Sub
End Module
