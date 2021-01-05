'Importacion necesaria para trabajar con ficheros excel
Public Class CFCargaExcel
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BCargarExcel_Click(sender As Object, e As EventArgs) Handles BCargarExcel.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = “Seleccionar archivos”
            .Filter = “Archivos Excel(*.xls)|*.xls”
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = DialogResult.OK Then
                Dim dt As DataTable = ImportExcellToDataGridView(.FileName, "Hoja1")
                DGExcel.DataSource = dt
            End If

            For I = 1 To DGExcel.ColumnCount
                CColumna1.Items.Add(I)
                CColumna2.Items.Add(I)
                CColumna3.Items.Add(I)
            Next
        End With
    End Sub

    Private Sub CFCargaExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BCargar_Click(sender As Object, e As EventArgs) Handles BCargar.Click
        Try
            FCrear.DGDetalle.Rows.Clear()
            For I = 0 To DGExcel.RowCount - 2
                Dim Numero As Integer
                Dim TValor As Double
                Dim Total As Double
                Dim columna1 As Integer
                Dim columna2 As Integer
                Dim columna3 As Integer
                Dim GDCol1 As Double
                Dim GDCol2 As String
                Dim GDCol3 As Double
                Dim CodigoAux As Double
                'If DGExcel.Item(columna1 - 1, I).Value.ToString() <> "" Then

                Numero = FCrear.DGDetalle.Rows.Count
                columna1 = CColumna1.Text
                columna2 = CColumna2.Text
                columna3 = CColumna3.Text
                GDCol1 = DGExcel.Item(columna1 - 1, I).Value.ToString()
                GDCol2 = DGExcel.Item(columna2 - 1, I).Value.ToString()
                GDCol3 = DGExcel.Item(columna3 - 1, I).Value.ToString()
                TValor = GDCol1 * GDCol3
                'CCodAux.DataSource = CargaCombobox(CCodAux, "Select * from SIA", "ID_SIA")
                CodigoAux = FCrear.CNSia.Text

                FCrear.DGDetalle.Rows.Add(Numero, CodigoAux, GDCol1, GDCol2, GDCol3, TValor)
                Total = Total + TValor
                FCrear.LTotal.Text = Total
                'End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class