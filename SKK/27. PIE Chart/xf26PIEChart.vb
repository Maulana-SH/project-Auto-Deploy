
Imports DevExpress.XtraCharts

Public Class xf26PIEChart
    Implements IDisposable

    Private nmSeris As String = "nmSeris_01"
    Private Sub xf26PIEChart_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub cm01()

        chart_pie.Titles.Add(New ChartTitle() With {.Text = "ALOKASI BAHAN COR"})

        Dim series1 As Series = chart_pie.Series("nmSeris_01")

    End Sub

    Private Sub BindingData()

        ' Create a pie series.
        chart_pie.DataSource = Nothing
        chart_pie.RefreshData()

        Dim series1 As Series = chart_pie.Series(nmSeris)

        ' Bind the series to data.
        'series1.DataSource = Nothing
        'series1.DataSource = DataAlokasi.GetDataAlokasiBahan()
        series1.ArgumentDataMember = "Argument"
        series1.ColorDataMember = "Color"
        series1.ValueDataMembers.AddRange(New String() {"Value"})

        ' Add the series to the chart.
        chart_pie.Series.Add(series1)

        ' Format the the series labels.
        series1.Label.TextPattern = "{VP:p0} ({V:.##} Grms)"

        ' Format the series legend items.
        series1.LegendTextPattern = "{A} {V}"

        ' Adjust the position of series labels. 
        CType(series1.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns

        ' Detect overlapping of series labels.
        CType(series1.Label, PieSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

        ' Access the view-type-specific options of the series.
        ' Dim myView As PieSeriesView = CType(series1.View, PieSeriesView)

        ' Specify a data filter to explode points.
        'myView.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 9))
        'myView.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.NotEqual, "Others"))
        'myView.ExplodeMode = PieExplodeMode.UseFilters
        ''myView.ExplodedDistancePercentage = 100
        'myView.RuntimeExploding = True

        ' Customize the legend.
        chart_pie.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

        '' Add the chart to the form.
        'pieChart.Dock = DockStyle.Fill
        'Me.Controls.Add(pieChart)

        chart_pie.DataSource = Nothing
        chart_pie.DataSource = DataAlokasi.GetDataAlokasiBahan()
        chart_pie.Refresh()

    End Sub

    Private Sub Binding02()
        chart_pie.Series.Item(nmSeris).Points.Clear()
        chart_pie.RefreshData()


        chart_pie.Series.Item(nmSeris).Points.AddPoint("LM", 350.45)
        chart_pie.Series.Item(nmSeris).Points.AddPoint("SBC", 220)
        chart_pie.Series.Item(nmSeris).Points.AddPoint("ALLOy", 120)

        chart_pie.Series.Item(nmSeris).Label.TextPattern = "{A} {VP:p0} ({V:.##} Grms)"

        ' Format the series legend items.
        chart_pie.Series.Item(nmSeris).LegendTextPattern = "{A} {V}"

        ' Adjust the position of series labels. 
        CType(chart_pie.Series.Item(nmSeris).Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns

        ' Detect overlapping of series labels.
        CType(chart_pie.Series.Item(nmSeris).Label, PieSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

        chart_pie.Refresh()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Binding02()
        ' BindingData()
        ' cm01()
    End Sub

End Class

Partial Public Class DataAlokasi
    Public Property Argument() As String
    Public Property Value() As Double
    Public Property Color() As String

    Public Shared Function GetDataAlokasiBahan() As List(Of DataAlokasi)
        Return New List(Of DataAlokasi) From {
            New DataAlokasi With {.Argument = "SBC", .Value = 650, .Color = "255; 255; 0"},
            New DataAlokasi With {.Argument = "LM", .Value = 250, .Color = "255;192;0 "},
            New DataAlokasi With {.Argument = "ALLOY", .Value = 150, .Color = "198; 217; 240"}
        }
    End Function
End Class