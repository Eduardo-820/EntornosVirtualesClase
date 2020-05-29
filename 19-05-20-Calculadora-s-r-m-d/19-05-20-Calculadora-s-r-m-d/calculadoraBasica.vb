Public Class calculadoraBasica
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1, valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Double
        Dim division As Double

        If txtValor1.Text = "" Then
            MsgBox("Escriba un numero en la casilla de valor 1", vbInformation)
        ElseIf txtValor2.Text = "" Then
            MsgBox("Escriba un numero en la casilla de valor 2", vbInformation)

        ElseIf Not IsNumeric(txtValor1.Text) Or Not IsNumeric(txtValor2.Text) Then
            MsgBox("Valor 1 y Valor 2 deben ser valores numericos", vbInformation)

        Else
            valor1 = Val(txtValor1.Text)
            valor2 = Val(txtValor2.Text)

            suma = valor1 + valor2
            resta = valor1 - valor2
            multiplicacion = valor1 * valor2
            division = valor1 / valor2

            txtSuma.Text = suma
            txtResta.Text = resta
            txtMultiplicar.Text = multiplicacion

            If valor2 = 0 Then
                txtDividir.Text = "Math Error"
            Else
                txtDividir.Text = division
            End If

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSuma.Clear()
        txtResta.Clear()
        txtMultiplicar.Clear()
        txtDividir.Clear()

    End Sub
End Class
