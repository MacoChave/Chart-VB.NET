Public Class Grafica

    Private Sub Grafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Chart1.Dock = DockStyle.Fill
        Chart1.Series.Add("Nombre")
        Chart1.Series("Nombre").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("Nombre").Points.AddXY(5, 10)
        Chart1.Series("Nombre").Points.AddXY(10, 5)
        Chart1.Series("Nombre").Points.AddXY(15, 20)
        Chart1.Series("Nombre").Points.AddXY(20, 5)
        Chart1.Series("Nombre").ChartArea = "ChartArea1"

    End Sub
End Class
