# Chart-VB.NET
Pequeña aplicación en Visual Basic.NET para el manejo de un control chart.
`Chart1` es el nombre del control chart.
`Chart1.Dock = DockStyle.Fill` Llena el grafico en toda la ventana de la aplicación.
`Chart1.Series.Add("Nombre")` Agrega una serie de nombre **Nombre** al chart.
`Chart1.Series("Nombre").ChartType = DataVisualization.Charting.SeriesChartType.Line` Setea el tipo de grafico.
`Chart1.Series("Nombre").Points.AddXY(5, 10)` Agrega un punto en las coordenadas indicadas.
`Chart1.Series("Nombre").ChartArea = "ChartArea1"` ChartArea donde se ingresará la Serie.
