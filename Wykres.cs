using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using org.mariuszgromada.math.mxparser;
using System.Windows.Forms.DataVisualization.Charting;


namespace Macierze_JR
{
    public partial class Wykres : Form
    {
        float wprowadzana = 1;
        float[] x_p, y_p;
        string rownanie = "";
        int p;

        public Wykres(float[] x, float[] y, int punkty)
        {
            InitializeComponent();
            x_p = x;
            y_p = y;
            p = punkty;
            tworz_wzor();
            LadujWykres();
           
        }

        void LadujWykres()
        {
            chart.Series.Clear();
            if (!chart.Series.IsUniqueName("F(x)"))
                chart.Series.Clear();

            chart.Series.Add("F(x)");
            chart.Series["F(x)"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            chart.Series["F(x)"].Color = System.Drawing.Color.Aqua;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chart.Series["F(x)"].BorderWidth = 3;

            chart.Series.Add("f(x)");
            chart.Series["f(x)"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            chart.Series["f(x)"].Color = System.Drawing.Color.Black;
            chart.Series["f(x)"].BorderWidth = 3;
            chart.Series["f(x)"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            chart.Series["f(x)"].MarkerSize = 5;

            for (int i = 0; i < p; i++)
            {
                string arg = "x = ";
                arg += x_p[i].ToString();
                Argument A = new Argument(arg);
                Expression wynik = new Expression(wzor.Text, A);

                double w = wynik.calculate();
                chart.Series["F(x)"].Points.AddXY(x_p[i], w);
                
                //for (double j = 0; j < 1; j = j + 0.2)
                //chart.Series["F(x)"].Points.AddXY(x_p[i]+j, w);
              //odkomentuj i zobacz dziwne wyniki


                chart.Series["f(x)"].Points.AddXY(x_p[i], y_p[i]);
            }
        }


        private void szukana_TextChanged(object sender, EventArgs e)
        {
          
        }

        void tworz_wzor()
        {
            for (int i = 0; i < p; i++)
            {
                string ypi = y_p[i].ToString();
                ypi.Replace(".", ",");
                rownanie = rownanie + ypi + " * ";
                
                for (int j = 0; j < p; j++)
                {
                    if(i != j)
                    {
                        string xpj = x_p[j].ToString();
                        string xpi = x_p[i].ToString();
                        xpj.Replace(",", ".");
                        xpi.Replace(",", ".");


                        rownanie += "((x - " + xpj + ")/(" + xpi + " - " + xpj + "))";
                        if (j < p - 1)
                        { rownanie += " * "; }
                    }
                    
                }
                if (i < p - 1)
                    rownanie += " + ";
            }
            rownanie = rownanie.Remove(rownanie.Length - 2);
            
            //wzor.Text = rownanie;
            wzor.Text = rownanie.Replace(",", ".");
            wzor.Text = rownanie.Replace("- -", "+");
        }

        private void Szukaj_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(szukana.Text, "^[-]?(?:[0](?:[\\,\\.][0-9]+|$)+|[1-9][0-9]*(?:[\\,\\.][0-9]+|$)$)"))
            {
                szukana.BackColor = Color.Red;
                MessageBox.Show("Dane wprowadzone nie są poprawne.", "Złe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                szukana.BackColor = Color.White;
                wprowadzana = float.Parse(szukana.Text);

                if (chart.Series.IsUniqueName("szukana"))
                {
                    chart.Series.Add("szukana");
                    chart.Series["szukana"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
                    chart.Series["szukana"].Color = System.Drawing.Color.Red;
                    chart.Series["szukana"].BorderWidth = 3;
                    chart.Series["szukana"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
                    chart.Series["szukana"].MarkerSize = 7;
                    
                    string przecinek = wprowadzana.ToString();
                    przecinek.Replace(",", ".");
                    string arg = "x = ";
                    arg += przecinek;
                    Argument A = new Argument(arg);
                    Expression wynik = new Expression(wzor.Text, A);

                    double w = wynik.calculate();

                    if (wprowadzana < x_p[0])
                       chart.Series["F(x)"].Points.Insert(0, new DataPoint(wprowadzana, w));
                    
                    if (wprowadzana > x_p[p - 1])
                        chart.Series["F(x)"].Points.AddXY(wprowadzana, w);


                    chart.Series["szukana"].Points.AddXY(wprowadzana, w);

                    szukany_wynik.Text = w.ToString();
                }
                else
                {
                    LadujWykres();

                    chart.Series.Add("szukana");
                    chart.Series["szukana"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
                    chart.Series["szukana"].Color = System.Drawing.Color.Red;
                    chart.Series["szukana"].BorderWidth = 3;
                    chart.Series["szukana"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
                    chart.Series["szukana"].MarkerSize = 7;

                    string przecinek = wprowadzana.ToString();
                    przecinek.Replace(",", ".");
                    string arg = "x = ";
                    arg += przecinek;
                    Argument A = new Argument(arg);
                    Expression wynik = new Expression(wzor.Text, A);

                    double w = wynik.calculate();

                    if (wprowadzana > x_p[p-1])
                    chart.Series["F(x)"].Points.AddXY(wprowadzana, w);

                    if (wprowadzana < x_p[0])
                    {
                        chart.Series["F(x)"].Points.Insert(0, new DataPoint(wprowadzana, w));
                    }


                        chart.Series["szukana"].Points.AddXY(wprowadzana, w);

                    szukany_wynik.Text = w.ToString();
                }

            }
        }
    }
}
