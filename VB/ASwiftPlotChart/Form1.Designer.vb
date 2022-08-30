Imports DevExpress.XtraCharts

Namespace ASwiftPlotChart

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim swiftPlotDiagram1 As DevExpress.XtraCharts.SwiftPlotDiagram = New DevExpress.XtraCharts.SwiftPlotDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim swiftPlotSeriesView1 As DevExpress.XtraCharts.SwiftPlotSeriesView = New DevExpress.XtraCharts.SwiftPlotSeriesView()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((swiftPlotDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((swiftPlotSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' timer1
            ' 
            Me.timer1.Enabled = True
            Me.timer1.Interval = 10
            AddHandler Me.timer1.Tick, New System.EventHandler(AddressOf Me.timer1_Tick)
            ' 
            ' chartControl1
            ' 
            swiftPlotDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Millisecond
            swiftPlotDiagram1.AxisX.Label.TextPattern = "{A:mm:ss}"
            swiftPlotDiagram1.AxisX.WholeRange.AlwaysShowZeroLevel = True
            swiftPlotDiagram1.AxisX.WholeRange.AutoSideMargins = True
            swiftPlotDiagram1.AxisX.VisualRange.AutoSideMargins = True
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            swiftPlotDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = True
            swiftPlotDiagram1.AxisY.WholeRange.AutoSideMargins = True
            swiftPlotDiagram1.AxisY.VisualRange.AutoSideMargins = True
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            swiftPlotDiagram1.Margins.Left = 40
            swiftPlotDiagram1.Margins.Right = 30
            Me.chartControl1.Diagram = swiftPlotDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.LegendText = "Swift Plot Series"
            series1.Name = "series1"
            swiftPlotSeriesView1.Antialiasing = True
            series1.View = swiftPlotSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.Size = New System.Drawing.Size(459, 264)
            Me.chartControl1.TabIndex = 0
            chartTitle1.Text = "The Swift Plot"
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(459, 264)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((swiftPlotDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((swiftPlotSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private timer1 As System.Windows.Forms.Timer

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
