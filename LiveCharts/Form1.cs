using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MetroFramework;
using MetroFramework.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Windows;
using Brushes = System.Windows.Media.Brushes;

namespace LiveCharts
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Angular Gauge
            angularGauge1.Value = 160;
            angularGauge1.FromValue = 50;
            angularGauge1.ToValue = 250;
            angularGauge1.TicksForeground = Brushes.White;
            angularGauge1.Base.Foreground = Brushes.White;
            angularGauge1.Base.FontWeight = FontWeights.Bold;
            angularGauge1.Base.FontSize = 16;

            angularGauge1.Sections.Add(new AngularSection
            {
                FromValue = 50,
                ToValue = 200,
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(247, 166, 37))
            });
            angularGauge1.Sections.Add(new AngularSection
            {
                FromValue = 200,
                ToValue = 250,
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 57, 57))
            });
            #endregion

            #region Cartesian
            #region Definindo as Series
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double>{0, 68, 5, 79, 32, 49},
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double>{76, 120, 29, 9, 6, 102},
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double>{55, 8, 95, 30, 61, 74},
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                }
            };
            #endregion

            #region Defifindo os Eixos XY
            cartesianChart1.AxisX.Add(new Axis { Title = "Month", Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" } });

            cartesianChart1.AxisY.Add(new Axis { Title = "Sale", LabelFormatter = value => value.ToString("C") });
            #endregion

            cartesianChart1.LegendLocation = LegendLocation.Right;

            #region ...
            /*cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 0, 5, 19, 45, 8 },
                LineSmoothness = 0, //...
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeround = System.Windows.Media.Brushes.Gray
            });*/

            //Modificando qualquer série de valores também irá animar e atualizar o gráfico
            //cartesianChart1.Series[2].Values.Add(50);


            cartesianChart1.DataClick += CartesianChart1_DataClick;
            #endregion
            #endregion

            #region GeoMap
            var rand = new Random();
            var valu = new Dictionary<string, double>();
            var lang = new Dictionary<string, string>();

            valu["MX"] = rand.Next(0, 100);
            valu["CA"] = rand.Next(0, 100);
            valu["US"] = rand.Next(0, 100);
            valu["IN"] = rand.Next(0, 100);
            valu["CN"] = rand.Next(0, 100);
            valu["JP"] = rand.Next(0, 100);
            valu["BR"] = rand.Next(0, 100);
            valu["DE"] = rand.Next(0, 100);
            valu["FR"] = rand.Next(0, 100);
            valu["UK"] = rand.Next(0, 100);

            lang["MX"] = "Mexico"; // change the language if necessary
            lang["CA"] = "Canada"; // change the language if necessary
            lang["US"] = "United States"; // change the language if necessary
            lang["IN"] = "India"; // change the language if necessary
            lang["CN"] = "China"; // change the language if necessary
            lang["JP"] = "Japan"; // change the language if necessary
            lang["BR"] = "Brazil"; // change the language if necessary
            lang["GE"] = "Germany"; // change the language if necessary
            lang["FR"] = "France"; // change the language if necessary
            lang["UK"] = "United Kingdom"; // change the language if necessary

            geoMap1.HeatMap = valu;
            geoMap1.LanguagePack = lang;
            geoMap1.Source = @"Maps\World.xml";
            #endregion

            #region Pie
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3 },
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double>{4 },
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6 },
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederich",
                    Values = new ChartValues<double> {2 },
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
            #endregion

            #region Solid Gauge
            //360 mode enable
            solidGauge1.Uses360Mode = true;
            solidGauge1.From = 0;
            solidGauge1.To = 100;
            solidGauge1.Value = 50;

            //Rotate 90º and has an invertes clockwise fill.
            solidGauge2.Uses360Mode = true;
            solidGauge2.From = 0;
            solidGauge2.To = 100;
            solidGauge2.Value = 50;
            solidGauge2.Base.GaugeRenderTransform = new TransformGroup
            {
                Children = new TransformCollection
                {
                    new RotateTransform(90),
                    new ScaleTransform{ScaleX = -1}
                }
            };

            solidGauge3.Uses360Mode = true;
            solidGauge3.From = 0;
            solidGauge3.To = 100;
            solidGauge3.Value = 20;
            solidGauge3.HighFontSize = 60;
            solidGauge3.Base.Foreground = Brushes.White;
            solidGauge3.InnerRadius = 0;
            solidGauge3.GaugeBackground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(71, 128, 181));

            //The next gauge interpolates from color white, to color black according to the current value in the gauge.
            solidGauge4.Uses360Mode = true;
            solidGauge4.From = 0;
            solidGauge4.To = 100;
            solidGauge4.Value = 50;
            solidGauge4.HighFontSize = 60;
            solidGauge4.Base.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(66, 66, 66));
            solidGauge4.FromColor = Colors.White;
            solidGauge4.ToColor = Colors.Black;
            solidGauge4.InnerRadius = 0;
            solidGauge4.Base.Background = Brushes.Transparent;

            //Standard gauge
            solidGauge5.From = 0;
            solidGauge5.To = 100;
            solidGauge5.Value = 50;

            //Custom fill
            solidGauge6.From = 0;
            solidGauge6.To = 100;
            solidGauge6.Value = 50;
            solidGauge6.Base.LabelsVisibility = Visibility.Hidden;
            solidGauge6.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Yellow, 0),
                    new GradientStop(Colors.Orange, .5),
                    new GradientStop(Colors.Red, 1)
                }
            };
            #endregion
        }

        private void CartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            MetroMessageBox.Show(this, "You clicked (" + chartPoint.X + ", " + chartPoint.Y + ")", "Clique", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
        }
    }
}
