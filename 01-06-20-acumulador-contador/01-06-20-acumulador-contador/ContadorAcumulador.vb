Public Class ContadorAcumulador
    Private Sub btnSolicitarOrden_Click(sender As Object, e As EventArgs) Handles btnSolicitarOrden.Click
        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = txtOrden.Text
            For i = 1 To orden Step 1 'contador
                precio = InputBox("Ingrese el precio del platillo No." & i, "precio del platillo")
                'acumulador: guarda valores ingresados previamente
                totalPagar += precio
            Next
            total = totalPagar / orden

            txtTotal.Text = totalPagar
            txtTotalIndividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtOrden.Clear()
        txtTotal.Clear()
        txtTotalIndividual.Clear()
    End Sub
End Class
