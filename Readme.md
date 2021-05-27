<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ASwiftPlotChart/Form1.cs) (VB: [Form1.vb](./VB/ASwiftPlotChart/Form1.vb))
<!-- default file list end -->
# How to create a real-time chart

The following example demonstrates how to create a real-time chart which uses a [Swift Plot](https://docs.devexpress.com/WindowsForms/7093/controls-and-libraries/chart-control/series-views/2d-series-views/swift-plot-series-view?p=netframework) series at runtime.

Note that this series view type is associated with the [Swift Plot Diagram](https://docs.devexpress.com/WindowsForms/7177/controls-and-libraries/chart-control/diagram/swift-plot-diagram?p=netframework) type, and you should cast your [diagram](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Diagram?p=netframework) object to this type, in order to access its specific options.

Starting from v14.1, text pattern properties ([AxisLabel.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisLabel.TextPattern?p=netframework), [SeriesLabelBase.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesLabelBase.TextPattern?p=netframework), [SeriesBase.LegendTextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.LegendTextPattern?p=netframework)) have been introduced instead of point options.
