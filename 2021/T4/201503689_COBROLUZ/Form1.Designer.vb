<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_watts = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_saldant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_NIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Tarifa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_Servicio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.List_PagoMora = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.List_PagoParcial = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.List_Total = New System.Windows.Forms.ListBox()
        Me.List_Mora = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.List_Desc = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.List_SaldoAnt = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.List_PagoIn = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.List_Tarifa = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.List_Servicio = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.List_Cliente = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Txt_watts)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_saldant)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_NIT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE INGRESO"
        '
        'Txt_watts
        '
        Me.Txt_watts.Location = New System.Drawing.Point(393, 77)
        Me.Txt_watts.Name = "Txt_watts"
        Me.Txt_watts.Size = New System.Drawing.Size(100, 23)
        Me.Txt_watts.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Consumo de Kilowatts"
        '
        'Txt_saldant
        '
        Me.Txt_saldant.Location = New System.Drawing.Point(393, 29)
        Me.Txt_saldant.Name = "Txt_saldant"
        Me.Txt_saldant.Size = New System.Drawing.Size(100, 23)
        Me.Txt_saldant.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese su Saldo Anterior"
        '
        'Txt_NIT
        '
        Me.Txt_NIT.Location = New System.Drawing.Point(131, 77)
        Me.Txt_NIT.Name = "Txt_NIT"
        Me.Txt_NIT.Size = New System.Drawing.Size(100, 23)
        Me.Txt_NIT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese su NIT"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(131, 29)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ComboBox_Tarifa)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Servicio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 126)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVICIO"
        '
        'ComboBox_Tarifa
        '
        Me.ComboBox_Tarifa.FormattingEnabled = True
        Me.ComboBox_Tarifa.Items.AddRange(New Object() {"Social", "No Social"})
        Me.ComboBox_Tarifa.Location = New System.Drawing.Point(173, 74)
        Me.ComboBox_Tarifa.Name = "ComboBox_Tarifa"
        Me.ComboBox_Tarifa.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_Tarifa.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Seleccione Tipo de Tarifa"
        '
        'ComboBox_Servicio
        '
        Me.ComboBox_Servicio.FormattingEnabled = True
        Me.ComboBox_Servicio.Items.AddRange(New Object() {"Residencial", "Industrial"})
        Me.ComboBox_Servicio.Location = New System.Drawing.Point(173, 28)
        Me.ComboBox_Servicio.Name = "ComboBox_Servicio"
        Me.ComboBox_Servicio.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_Servicio.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Seleccione Tipo de Servicio"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.List_PagoMora)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.List_PagoParcial)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.List_Total)
        Me.GroupBox3.Controls.Add(Me.List_Mora)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.List_Desc)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.List_SaldoAnt)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.List_PagoIn)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.List_Tarifa)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.List_Servicio)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.List_Cliente)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 325)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1453, 240)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS"
        '
        'List_PagoMora
        '
        Me.List_PagoMora.FormattingEnabled = True
        Me.List_PagoMora.ItemHeight = 15
        Me.List_PagoMora.Location = New System.Drawing.Point(861, 50)
        Me.List_PagoMora.Name = "List_PagoMora"
        Me.List_PagoMora.Size = New System.Drawing.Size(120, 184)
        Me.List_PagoMora.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(861, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 15)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Pago con Mora"
        '
        'List_PagoParcial
        '
        Me.List_PagoParcial.FormattingEnabled = True
        Me.List_PagoParcial.ItemHeight = 15
        Me.List_PagoParcial.Location = New System.Drawing.Point(1012, 50)
        Me.List_PagoParcial.Name = "List_PagoParcial"
        Me.List_PagoParcial.Size = New System.Drawing.Size(120, 184)
        Me.List_PagoParcial.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1012, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 15)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Pago Parcial"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1300, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 15)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Pago Total"
        '
        'List_Total
        '
        Me.List_Total.FormattingEnabled = True
        Me.List_Total.ItemHeight = 15
        Me.List_Total.Location = New System.Drawing.Point(1300, 50)
        Me.List_Total.Name = "List_Total"
        Me.List_Total.Size = New System.Drawing.Size(120, 184)
        Me.List_Total.TabIndex = 14
        '
        'List_Mora
        '
        Me.List_Mora.FormattingEnabled = True
        Me.List_Mora.ItemHeight = 15
        Me.List_Mora.Location = New System.Drawing.Point(718, 50)
        Me.List_Mora.Name = "List_Mora"
        Me.List_Mora.Size = New System.Drawing.Size(120, 184)
        Me.List_Mora.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1166, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Descuento"
        '
        'List_Desc
        '
        Me.List_Desc.FormattingEnabled = True
        Me.List_Desc.ItemHeight = 15
        Me.List_Desc.Location = New System.Drawing.Point(1157, 50)
        Me.List_Desc.Name = "List_Desc"
        Me.List_Desc.Size = New System.Drawing.Size(120, 184)
        Me.List_Desc.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(718, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Mora"
        '
        'List_SaldoAnt
        '
        Me.List_SaldoAnt.FormattingEnabled = True
        Me.List_SaldoAnt.ItemHeight = 15
        Me.List_SaldoAnt.Location = New System.Drawing.Point(434, 50)
        Me.List_SaldoAnt.Name = "List_SaldoAnt"
        Me.List_SaldoAnt.Size = New System.Drawing.Size(120, 184)
        Me.List_SaldoAnt.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(576, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Pago Inicial"
        '
        'List_PagoIn
        '
        Me.List_PagoIn.FormattingEnabled = True
        Me.List_PagoIn.ItemHeight = 15
        Me.List_PagoIn.Location = New System.Drawing.Point(576, 50)
        Me.List_PagoIn.Name = "List_PagoIn"
        Me.List_PagoIn.Size = New System.Drawing.Size(120, 184)
        Me.List_PagoIn.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(434, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Saldo Anterior"
        '
        'List_Tarifa
        '
        Me.List_Tarifa.FormattingEnabled = True
        Me.List_Tarifa.ItemHeight = 15
        Me.List_Tarifa.Location = New System.Drawing.Point(285, 50)
        Me.List_Tarifa.Name = "List_Tarifa"
        Me.List_Tarifa.Size = New System.Drawing.Size(120, 184)
        Me.List_Tarifa.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(285, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Tipo de Tarifa"
        '
        'List_Servicio
        '
        Me.List_Servicio.FormattingEnabled = True
        Me.List_Servicio.ItemHeight = 15
        Me.List_Servicio.Location = New System.Drawing.Point(143, 50)
        Me.List_Servicio.Name = "List_Servicio"
        Me.List_Servicio.Size = New System.Drawing.Size(120, 184)
        Me.List_Servicio.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Tipo de Servicio"
        '
        'List_Cliente
        '
        Me.List_Cliente.FormattingEnabled = True
        Me.List_Cliente.ItemHeight = 15
        Me.List_Cliente.Location = New System.Drawing.Point(6, 50)
        Me.List_Cliente.Name = "List_Cliente"
        Me.List_Cliente.Size = New System.Drawing.Size(120, 184)
        Me.List_Cliente.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CLIENTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201503689_COBROLUZ.My.Resources.Resources.Bombillo_y_bengalas
        Me.PictureBox1.Location = New System.Drawing.Point(599, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(877, 292)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(643, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(643, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 575)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SISTEMA DE RECIBO DE LUZ O.V."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_watts As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_saldant As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_NIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Servicio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_Tarifa As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents List_Servicio As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents List_Cliente As ListBox
    Friend WithEvents List_SaldoAnt As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents List_PagoIn As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents List_Tarifa As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents List_Total As ListBox
    Friend WithEvents List_Mora As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents List_Desc As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents List_PagoParcial As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents List_PagoMora As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
