using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ValueLines {
    public partial class frmMain : Form {
        Random random = new Random();

        XYDiagram Diagram { get { return ((XYDiagram)chart.Diagram); } }
        Series AreaSeries { get { return chart.Series[0]; } }
        Series LineSeries { get { return chart.Series[1]; } }

        ConstantLine ArgumentConstantLine { get { return Diagram.AxisX.ConstantLines[0]; } }
        ConstantLine AreaValueConstantLine { get { return Diagram.AxisY.ConstantLines[0]; } }
        ConstantLine LineValueConstantLine { get { return Diagram.AxisY.ConstantLines[1]; } }

        public frmMain() {
            InitializeComponent();
            bool isAreaRising = true;
            bool isLineRising = false;
            for (int i = 0; i < 100; i++) {
                AddPoint(AreaSeries, isAreaRising, i);
                AddPoint(LineSeries, isLineRising, i);
                isAreaRising = random.NextDouble() > 0.75;
                isLineRising = random.NextDouble() > 0.75;
            }
        }

        void chart_MouseMove(object sender, MouseEventArgs e) {
            DiagramCoordinates coordinates = Diagram.PointToDiagram(new Point(e.X, e.Y));
            if (coordinates == null || coordinates.IsEmpty) {
                ArgumentConstantLine.Visible = false;
                AreaValueConstantLine.Visible = false;
                LineValueConstantLine.Visible = false;
                return;
            }
            UpdateConstantLine(ArgumentConstantLine,
                coordinates.NumericalArgument);
            UpdateConstantLine(AreaValueConstantLine,
                GetSeriesValue(AreaSeries, coordinates.NumericalArgument));
            UpdateConstantLine(LineValueConstantLine,
                GetSeriesValue(LineSeries, coordinates.NumericalArgument));
        }

        void AddPoint(Series series, bool isRising, int argument) {
            double previousValue;
            if (series.Points.Count > 0)
                previousValue = series.Points[series.Points.Count - 1].Values[0];
            else
                previousValue = (random.NextDouble() + 1) * 10;

            double value = previousValue + (isRising ? random.NextDouble() : -random.NextDouble());

            series.Points.Add(new SeriesPoint(argument, value));
        }

        void UpdateConstantLine(ConstantLine constantLine, double value) {
            constantLine.Visible = true;
            constantLine.AxisValue = value;
            constantLine.Title.Text = value.ToString("00.00");
        }

        double GetSeriesValue(Series series, double argument) {
            for (int i = 0; i < series.Points.Count - 1; i++) {

                if (series.Points[i].NumericalArgument == argument)
                    return series.Points[i].Values[0];

                else if (series.Points[i].NumericalArgument < argument &&
                        series.Points[i + 1].NumericalArgument > argument) {

                    double ratio = (argument - series.Points[i].NumericalArgument) /
                        (series.Points[i + 1].NumericalArgument - series.Points[i].NumericalArgument);

                    return (series.Points[i + 1].Values[0] - series.Points[i].Values[0]) * ratio +
                        series.Points[i].Values[0];
                }
            }
            return double.NaN;
        }
    }
} 
