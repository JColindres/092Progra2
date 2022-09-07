<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Suma = New System.Windows.Forms.Button()
        Me.Resta = New System.Windows.Forms.Button()
        Me.Multiplicacion = New System.Windows.Forms.Button()
        Me.Division = New System.Windows.Forms.Button()
        Me.Pot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Suma
        '
        Me.Suma.Location = New System.Drawing.Point(12, 21)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(75, 23)
        Me.Suma.TabIndex = 2
        Me.Suma.Text = "Sumar"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.Location = New System.Drawing.Point(12, 50)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(75, 23)
        Me.Resta.TabIndex = 3
        Me.Resta.Text = "Restar"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Multiplicacion
        '
        Me.Multiplicacion.Location = New System.Drawing.Point(12, 79)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(75, 23)
        Me.Multiplicacion.TabIndex = 6
        Me.Multiplicacion.Text = "Multiplicar"
        Me.Multiplicacion.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.Location = New System.Drawing.Point(12, 108)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(75, 23)
        Me.Division.TabIndex = 7
        Me.Division.Text = "Dividir"
        Me.Division.UseVisualStyleBackColor = True
        '
        'Pot
        '
        Me.Pot.Location = New System.Drawing.Point(12, 138)
        Me.Pot.Name = "Pot"
        Me.Pot.Size = New System.Drawing.Size(75, 23)
        Me.Pot.TabIndex = 8
        Me.Pot.Text = "Potencia"
        Me.Pot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 211)
        Me.Controls.Add(Me.Pot)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.Multiplicacion)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Suma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Suma As Button
    Friend WithEvents Resta As Button
    Friend WithEvents Multiplicacion As Button
    Friend WithEvents Division As Button
    Friend WithEvents Pot As Button
End Class
