' #region radchart-populating-with-data-creating-chart-in-code-behind
Imports Telerik.Windows.Controls
Imports Telerik.Windows.Controls.Charting
' #endregion
Public Class Default_Vb


    ' #region radchart-populating-with-data-creating-chart-in-code-behind_1
    Private Function CreateChart_DefaultView() As Telerik.Windows.Controls.RadChart
        Dim telerikChart As New Telerik.Windows.Controls.RadChart()
        Return telerikChart
    End Function
    ' #endregion

    ' #region radchart-populating-with-data-creating-chart-in-code-behind_3
    Private Function CreateChart_DefaultView() As Telerik.Windows.Controls.RadChart
        Dim telerikChart As New Telerik.Windows.Controls.RadChart()
        'Chart Title
        telerikChart.DefaultView.ChartTitle.Content = "Year 2009"
        telerikChart.DefaultView.ChartTitle.HorizontalAlignment = HorizontalAlignment.Center
        Return telerikChart
    End Function
    ' #endregion

    ' #region radchart-populating-with-data-creating-chart-in-code-behind_5
    Private Function CreateChart_DefaultView() As Telerik.Windows.Controls.RadChart
        Dim telerikChart As New Telerik.Windows.Controls.RadChart()
        'Chart Title
        telerikChart.DefaultView.ChartTitle.Content = "Year 2009"
        telerikChart.DefaultView.ChartTitle.HorizontalAlignment = HorizontalAlignment.Center
        Return telerikChart
    End Function
    ' #endregion

    ' #region radchart-populating-with-data-creating-chart-in-code-behind_7
    Private Function CreateChart_DefaultView() As Telerik.Windows.Controls.RadChart
        Dim telerikChart As New Telerik.Windows.Controls.RadChart()
        'Chart Title
        telerikChart.DefaultView.ChartTitle.Content = "Year 2009"
        telerikChart.DefaultView.ChartTitle.HorizontalAlignment = HorizontalAlignment.Center
        'Chart Legend
        telerikChart.DefaultView.ChartLegend.UseAutoGeneratedItems = True
        'Line Chart
        Dim lineSeries As New DataSeries()
        lineSeries.LegendLabel = "Turnover"
        lineSeries.Definition = New LineSeriesDefinition()
        telerikChart.DefaultView.ChartArea.DataSeries.Add(lineSeries)
        'Bar Chart
        Dim barSeries As New DataSeries()
        barSeries.LegendLabel = "Expenses"
        telerikChart.DefaultView.ChartArea.DataSeries.Add(barSeries)
        Return telerikChart
    End Function
    ' #endregion

    ' #region radchart-populating-with-data-creating-chart-in-code-behind_9
    Private Function CreateChart_DefaultView() As Telerik.Windows.Controls.RadChart
        Dim telerikChart As New Telerik.Windows.Controls.RadChart()
        'Chart Title
        telerikChart.DefaultView.ChartTitle.Content = "Year 2009"
        telerikChart.DefaultView.ChartTitle.HorizontalAlignment = HorizontalAlignment.Center
        'Chart Legend
        telerikChart.DefaultView.ChartLegend.UseAutoGeneratedItems = True
        'Line Chart
        Dim lineSeries As New DataSeries()
        lineSeries.LegendLabel = "Turnover"
        lineSeries.Definition = New LineSeriesDefinition()
        Dim dataPoint As New DataPoint()
        dataPoint.YValue = 154
        dataPoint.XCategory = "Jan"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 138
        dataPoint.XCategory = "Feb"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 143
        dataPoint.XCategory = "Mar"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 120
        dataPoint.XCategory = "Apr"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 135
        dataPoint.XCategory = "May"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 125
        dataPoint.XCategory = "Jun"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 179
        dataPoint.XCategory = "Jul"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 170
        dataPoint.XCategory = "Aug"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 198
        dataPoint.XCategory = "Sep"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 187
        dataPoint.XCategory = "Sep"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 193
        dataPoint.XCategory = "Nov"
        lineSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 176
        dataPoint.XCategory = "Dec"
        lineSeries.Add(dataPoint)
        telerikChart.DefaultView.ChartArea.DataSeries.Add(lineSeries)
        'Bar Chart
        Dim barSeries As New DataSeries()
        barSeries.LegendLabel = "Expenses"
        barSeries.Definition = New BarSeriesDefinition()
        dataPoint = New DataPoint()
        dataPoint.YValue = 45
        dataPoint.XCategory = "Jan"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 48
        dataPoint.XCategory = "Feb"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 53
        dataPoint.XCategory = "Mar"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 41
        dataPoint.XCategory = "Apr"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 32
        dataPoint.XCategory = "May"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 28
        dataPoint.XCategory = "Jun"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 63
        dataPoint.XCategory = "Jul"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 74
        dataPoint.XCategory = "Aug"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 77
        dataPoint.XCategory = "Sep"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 85
        dataPoint.XCategory = "Oct"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 89
        dataPoint.XCategory = "Nov"
        barSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 80
        dataPoint.XCategory = "Dec"
        barSeries.Add(dataPoint)
        telerikChart.DefaultView.ChartArea.DataSeries.Add(barSeries)
        Return telerikChart
    End Function
    ' #endregion

    ' #region radchart-populating-with-data-creating-chart-in-code-behind_11
    Private Function CreateChart_CustomLayout() As Telerik.Windows.Controls.RadChart
        Dim telerikChart As New Telerik.Windows.Controls.RadChart()
        telerikChart.Height = 362
        telerikChart.Width = 1042
        telerikChart.VerticalAlignment = VerticalAlignment.Bottom
        Dim grid__1 As New Grid()
        Dim rowDefiniton As New RowDefinition()
        rowDefiniton.Height = New GridLength(25, GridUnitType.Auto)
        grid__1.RowDefinitions.Add(rowDefiniton)
        grid__1.RowDefinitions.Add(New RowDefinition())
        grid__1.ColumnDefinitions.Add(New ColumnDefinition())
        grid__1.ColumnDefinitions.Add(New ColumnDefinition())
        Dim columnDefinition As New ColumnDefinition()
        columnDefinition.Width = New GridLength(100, GridUnitType.Auto)
        grid__1.ColumnDefinitions.Add(columnDefinition)
        telerikChart.UseDefaultLayout = False
        telerikChart.Content = grid__1
        'Monthly Sales for 2009
        'Chart Title
        Dim monthlySalesTitle As New ChartTitle()
        monthlySalesTitle.Content = "Monthly Sales for 2009"
        monthlySalesTitle.HorizontalAlignment = HorizontalAlignment.Center
        grid__1.Children.Add(monthlySalesTitle)
        'Chart Area
        Dim monthlySalesChart As New ChartArea()
        Grid.SetRow(monthlySalesChart, 1)
        grid__1.Children.Add(monthlySalesChart)
        Dim monthlySalesDataSeries As New DataSeries()
        monthlySalesDataSeries.Definition = New BarSeriesDefinition()
        Dim dataPoint As New DataPoint()
        dataPoint.YValue = 38
        dataPoint.XCategory = "Jan"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 65
        dataPoint.XCategory = "Feb"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 30
        dataPoint.XCategory = "Mar"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 63
        dataPoint.XCategory = "Apr"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 98
        dataPoint.XCategory = "May"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 47
        dataPoint.XCategory = "Jun"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 91
        dataPoint.XCategory = "Jul"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 99
        dataPoint.XCategory = "Aug"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 32
        dataPoint.XCategory = "Sep"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 77
        dataPoint.XCategory = "Oct"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 62
        dataPoint.XCategory = "Nov"
        monthlySalesDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 38
        dataPoint.XCategory = "Dec"
        monthlySalesDataSeries.Add(dataPoint)
        monthlySalesChart.DataSeries.Add(monthlySalesDataSeries)
        'Sales Per Manufacturer
        'Chart Title
        Dim perManufacturerTitle As New ChartTitle()
        perManufacturerTitle.Content = "Sales per Manufacturer"
        perManufacturerTitle.HorizontalAlignment = HorizontalAlignment.Center
        Grid.SetColumn(perManufacturerTitle, 1)
        grid__1.Children.Add(perManufacturerTitle)
        'Chart Legend
        Dim legend As New ChartLegend()
        legend.UseAutoGeneratedItems = True
        legend.Header = String.Empty
        legend.Name = "ChartLegendManufacturers"
        Grid.SetColumn(legend, 2)
        Grid.SetRow(legend, 1)
        grid__1.Children.Add(legend)
        'Chart Area
        Dim perManufacturerChart As New ChartArea()
        perManufacturerChart.LegendName = "ChartLegendManufacturers"
        'perManufacturerChart.Legend = legend;
        Grid.SetRow(perManufacturerChart, 1)
        Grid.SetColumn(perManufacturerChart, 1)
        grid__1.Children.Add(perManufacturerChart)
        Dim perManufacturerDataSeries As New DataSeries()
        perManufacturerDataSeries.Definition = New DoughnutSeriesDefinition()
        perManufacturerDataSeries.Definition.ItemLabelFormat = "p"
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.215208267
        dataPoint.LegendLabel = "Toyota"
        perManufacturerDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.192960612
        dataPoint.LegendLabel = "General Motors"
        perManufacturerDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.151830229
        dataPoint.LegendLabel = "Volkswagen"
        perManufacturerDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.125964366
        dataPoint.LegendLabel = "Ford"
        perManufacturerDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.091152353
        dataPoint.LegendLabel = "Honda"
        perManufacturerDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.079093251
        dataPoint.LegendLabel = "Nissan"
        perManufacturerDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.079093251
        dataPoint.LegendLabel = "PSA"
        perManufacturerDataSeries.Add(dataPoint)
        dataPoint = New DataPoint()
        dataPoint.YValue = 0.064697675
        dataPoint.LegendLabel = "Hyundai"
        perManufacturerDataSeries.Add(dataPoint)
        perManufacturerChart.DataSeries.Add(perManufacturerDataSeries)
        Return telerikChart
    End Function
    ' #endregion
End Class
