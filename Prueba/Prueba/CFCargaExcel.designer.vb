<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CFCargaExcel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGExcel = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CColumna1 = New System.Windows.Forms.ComboBox()
        Me.CColumna2 = New System.Windows.Forms.ComboBox()
        Me.CColumna3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BCargarExcel = New System.Windows.Forms.Button()
        Me.txtRutaXLS = New System.Windows.Forms.TextBox()
        Me.BuscarArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.BCargar = New System.Windows.Forms.Button()
        CType(Me.DGExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGExcel
        '
        Me.DGExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGExcel.Location = New System.Drawing.Point(5, 1)
        Me.DGExcel.Name = "DGExcel"
        Me.DGExcel.Size = New System.Drawing.Size(406, 245)
        Me.DGExcel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(424, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Detalle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor Unitario:"
        '
        'CColumna1
        '
        Me.CColumna1.FormattingEnabled = True
        Me.CColumna1.Location = New System.Drawing.Point(500, 88)
        Me.CColumna1.Name = "CColumna1"
        Me.CColumna1.Size = New System.Drawing.Size(70, 21)
        Me.CColumna1.TabIndex = 4
        '
        'CColumna2
        '
        Me.CColumna2.FormattingEnabled = True
        Me.CColumna2.Location = New System.Drawing.Point(500, 118)
        Me.CColumna2.Name = "CColumna2"
        Me.CColumna2.Size = New System.Drawing.Size(70, 21)
        Me.CColumna2.TabIndex = 5
        '
        'CColumna3
        '
        Me.CColumna3.FormattingEnabled = True
        Me.CColumna3.Location = New System.Drawing.Point(500, 150)
        Me.CColumna3.Name = "CColumna3"
        Me.CColumna3.Size = New System.Drawing.Size(70, 21)
        Me.CColumna3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(424, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cargar Archivo:"
        '
        'BCargarExcel
        '
        Me.BCargarExcel.Location = New System.Drawing.Point(516, 4)
        Me.BCargarExcel.Name = "BCargarExcel"
        Me.BCargarExcel.Size = New System.Drawing.Size(31, 27)
        Me.BCargarExcel.TabIndex = 8
        Me.BCargarExcel.Text = "..."
        Me.BCargarExcel.UseVisualStyleBackColor = True
        '
        'txtRutaXLS
        '
        Me.txtRutaXLS.Location = New System.Drawing.Point(427, 37)
        Me.txtRutaXLS.Multiline = True
        Me.txtRutaXLS.Name = "txtRutaXLS"
        Me.txtRutaXLS.ReadOnly = True
        Me.txtRutaXLS.Size = New System.Drawing.Size(186, 45)
        Me.txtRutaXLS.TabIndex = 9
        '
        'BuscarArchivo
        '
        Me.BuscarArchivo.FileName = "BuscarArchivo"
        '
        'BCargar
        '
        Me.BCargar.Location = New System.Drawing.Point(466, 186)
        Me.BCargar.Name = "BCargar"
        Me.BCargar.Size = New System.Drawing.Size(103, 35)
        Me.BCargar.TabIndex = 10
        Me.BCargar.Text = "Cargar listado"
        Me.BCargar.UseVisualStyleBackColor = True
        '
        'CFCargaExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 577)
        Me.Controls.Add(Me.BCargar)
        Me.Controls.Add(Me.txtRutaXLS)
        Me.Controls.Add(Me.BCargarExcel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CColumna3)
        Me.Controls.Add(Me.CColumna2)
        Me.Controls.Add(Me.CColumna1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGExcel)
        Me.Name = "CFCargaExcel"
        Me.Text = "Cargar archivo excel"
        CType(Me.DGExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGExcel As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CColumna1 As ComboBox
    Friend WithEvents CColumna2 As ComboBox
    Friend WithEvents CColumna3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BCargarExcel As Button
    Friend WithEvents txtRutaXLS As TextBox
    Friend WithEvents BuscarArchivo As OpenFileDialog
    Friend WithEvents BCargar As Button
End Class
