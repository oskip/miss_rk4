using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiSS_RK4
{
    public partial class ChartForm : Form
    {
        private double x0;
        private double step;

        public ChartForm()
        {
            InitializeComponent();
        }

        private void drawChart(List<Tuple<double, double>> points, double step)
        {
            double x = 0;
            //Utworzenie serii danych
            Series s = new Series("Wykres funkcji z krokiem: " + step + " i X0 = " + x0 );
            //Typ wykresu - liniowy
            s.ChartType = SeriesChartType.Line;
            // brak oznaczeń na lini
            s.MarkerStyle = MarkerStyle.None;
            int i = 0;
            s.Points.AddXY(0, x0);
            foreach (Tuple<double, double> point in points)
            {
                s.Points.AddXY(point.Item1, point.Item2);
                
            }

            bool contains = false;
            foreach (Series serie in exampleChart.Series)
            {
                if (serie.Name == s.Name)
                {
                    contains = true;
                    break;
                }
            }
            if (!contains)
            {
                exampleChart.Series.Add(s);
            }

            exampleChart.Show();
        }

        private bool prepareData()
        {
            if (textBoxStep.Text != "" && textBoxX0.Text != "")
            {
                x0 = Double.Parse(textBoxX0.Text, CultureInfo.InvariantCulture);
                step = Double.Parse(textBoxStep.Text, CultureInfo.InvariantCulture);
                return true;
            }
            return false;
        }

        private void runRK()
        {
            //Równanie do RK4
            Func<double, double, double> expression =
                //(t, x) => 4.5*Math.Pow(x, 3) + 2*Math.Pow(x, 2) - 18.63 + Math.Exp(2*t);
                (t, x) => -0.5 * x + 4 * Math.Exp(0.8 * t);

            var results = new RungeKutta4(expression, step, x0).Go();
            List<Tuple<double, double>> resultsList = new List<Tuple<double, double>>(results.ToList());
            drawChart(resultsList, step);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //exampleChart.Series.Clear();
            if (prepareData())
            {
                runRK();
            }
        }
    }
}