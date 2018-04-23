using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace ASwiftPlotChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        const int interval = 20;
        Random random = new Random();
        int TimeInterval = 10;
        double value1 = 10.0;

        Range AxisXRange {
            get {
                SwiftPlotDiagram diagram = chartControl1.Diagram as SwiftPlotDiagram;
                if (diagram != null)
                    return diagram.AxisX.VisualRange;
                return null;
            }
        }

        double CalculateNextValue(double value) {
            return value + (random.NextDouble() * 10.0 - 5.0);
        }

        void UpdateValues() {
            value1 = CalculateNextValue(value1);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Series series1 = chartControl1.Series[0];

            if (series1 == null)
                return;
            DateTime argument = DateTime.Now;
            SeriesPoint[] pointsToUpdate1 = new SeriesPoint[interval];
            for (int i = 0; i < interval; i++) {
                pointsToUpdate1[i] = new SeriesPoint(argument, value1);
                argument = argument.AddMilliseconds(1);
                UpdateValues();
            }
            DateTime minDate = argument.AddSeconds(-TimeInterval);
            int pointsToRemoveCount = 0;
            foreach (SeriesPoint point in series1.Points)
                if (point.DateTimeArgument < minDate)
                    pointsToRemoveCount++;
            if (pointsToRemoveCount < series1.Points.Count)
                pointsToRemoveCount--;
            series1.Points.AddRange(pointsToUpdate1);
            if (pointsToRemoveCount > 0) {
                series1.Points.RemoveRange(0, pointsToRemoveCount);
            }
            if (AxisXRange != null) {
                AxisXRange.SetMinMaxValues(minDate, argument);
            }

        }

    }
}