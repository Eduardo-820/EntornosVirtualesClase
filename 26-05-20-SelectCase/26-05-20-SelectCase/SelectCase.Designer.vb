<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbLista = New System.Windows.Forms.ComboBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbLista
        '
        Me.cmbLista.FormattingEnabled = True
        Me.cmbLista.Items.AddRange(New Object() {"primero", "segundo", "tercero", "cuarto"})
        Me.cmbLista.Location = New System.Drawing.Point(20, 53)
        Me.cmbLista.Name = "cmbLista"
        Me.cmbLista.Size = New System.Drawing.Size(121, 21)
        Me.cmbLista.TabIndex = 3
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(45, 91)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'FormCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(165, 133)
        Me.Controls.Add(Me.cmbLista)
        Me.Controls.Add(Me.btnMostrar)
        Me.Name = "FormCase"
        Me.Text = "Casos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbLista As ComboBox
    Friend WithEvents btnMostrar As Button
End Class
