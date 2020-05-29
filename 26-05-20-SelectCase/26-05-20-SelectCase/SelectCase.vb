Public Class FormCase
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim itemId As Integer
        Dim itemNombre As String

        itemId = cmbLista.SelectedIndex
        itemNombre = cmbLista.SelectedItem.ToString

        Select Case itemId
            Case 0
                MsgBox(itemNombre)
            Case 1
                MsgBox(itemNombre)
            Case 2
                MsgBox(itemNombre)
            Case 3
                MsgBox(itemNombre)
            Case Else
                MsgBox("Seleccione un valor valido")
        End Select

    End Sub
End Class
