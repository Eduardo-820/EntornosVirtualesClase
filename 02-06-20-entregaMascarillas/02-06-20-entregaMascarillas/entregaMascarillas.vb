Public Class entregaMascarillas
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtCantDepartamentos.Text)
        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("ingrese la cantidad de mascarillas" & i, "Ingresar")
            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbCantPorDepart.Items.Add(mascarillas)
        Next
    End Sub
    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios As Integer
        Dim itemDepartamento As String
        idDepartamento = cmbCantPorDepart.SelectedIndex
        municipios = Val(txtMunicipios.Text)
        itemDepartamento = cmbCantPorDepart.SelectedItem.ToString

        Select Case idDepartamento
            Case 0
                For i = 1 To municipios Step 1
                    While (itemDepartamento > cant)
                Next
        End Select

        txtStock.Text = itemDepartamento
    End Sub
End Class
