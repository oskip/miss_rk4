using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            List<int> examplePoints = new List<int>();
            InitializeComponent();
            examplePoints.Add(0);
            examplePoints.Add(1);
            examplePoints.Add(2);
            examplePoints.Add(3);
            examplePoints.Add(4);
            examplePoints.Add(5);
            examplePoints.Add(4);
            examplePoints.Add(3);
            examplePoints.Add(2);
            examplePoints.Add(1);
            examplePoints.Add(0);
            drawExampleChart(examplePoints, 0.1);
        }

        private void drawExampleChart(List<int> points, double step)
        {
            double max = 0, min = 0, p, x;
            //Utworzenie serii danych
            Series s = new Series("Wykres funkcji");
            //Typ wykresu - liniowy
            s.ChartType = SeriesChartType.Line;
            // brak oznaczeń na lini
            s.MarkerStyle = MarkerStyle.None;
            int i = 0;
            for (x = 0; x <= 1; x += step)
            {
                p = points[i];
                s.Points.AddXY(x, p);
                i++;
            }
            exampleChart.Series.Add(s);
        }
    }
}
