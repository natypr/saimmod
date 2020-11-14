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

namespace lab1
{
    public partial class Form1 : Form
    {
        const int countOfIntervals = 20; 
        const double xMin = 0;
        const double xMax = 1;
        const double yMin = 0;
        const double yMax = 0.1;
        const double delta = 1 / (double)countOfIntervals;
        const int N = 200000;

        public Form1()
        {
            InitializeComponent();
            radioButton_uniform.Checked = true;
        }


        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidNumber(M.Text) && IsValidNumber(A.Text) && IsValidNumber(R0.Text))
                {

                    double a = Convert.ToDouble(A.Text);
                    double m = Convert.ToDouble(M.Text);
                    double r0 = Convert.ToDouble(R0.Text);

                    if (m <= a)
                    {
                        MessageBox.Show("Параметр M должен быть больше A");
                        return;
                    }

                    Lehmer l = new Lehmer(a, m, r0);
                    List<double> xValues = l.getValues(N);


                    Calculations calc = new Calculations(xValues);
                    Mx.Text = (calc.getMx()).ToString("0.0000000");
                    Dx.Text = (calc.getDx()).ToString("0.0000000");
                    Sigma.Text = (calc.getSigma()).ToString("0.0000000");

                    DrawDiagrams(xValues);

                    p.Text = (calc.getPeriod()).ToString();
                    La.Text = (calc.getAperiodLength()).ToString();
                    check.Text = (calc.check()).ToString();

                }
                else
                {
                    MessageBox.Show("Некорректные входные параметры");
                }
            }
            catch
            {
                MessageBox.Show("Извините, произошла ошибка");
            }
        }

        private bool IsValidNumber(string text)
        {
            int number;
            return (int.TryParse(text, out number) && number > 0) ? true : false;
            
        }

        private void DrawDiagrams(List<double> xValues)
        {
            DrawDiagramWithValues(xValues);
            DrawEvaluationDiagram(xValues);
        }

        private void DrawDiagramWithValues(List<double> xValues)
        {
            chart1.Series["Xi"].Points.Clear();
            chart1.Series["Xi"].ChartType = SeriesChartType.Point;

            int max = N;
            //int delta = max / 10000;
            int delta = 100;

            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = max;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            //foreach (double x in xValues)
            for (int i = 0; i < max; i += delta)
            {
                chart1.Series["Xi"].Points.AddXY(i, xValues[i]);
            }
        }

        private void DrawEvaluationDiagram(List<double> xValues)
        {
            chart2.Series["Ci"].Points.Clear();

            chart2.ChartAreas[0].AxisY.Maximum = yMax;
            chart2.ChartAreas[0].AxisY.Minimum = yMin;
            chart2.ChartAreas[0].AxisX.Maximum = xMax;
            chart2.ChartAreas[0].AxisX.Minimum = yMin;

            int[] countInIntervals = new int[countOfIntervals];
            int intervalNumber;

            foreach (double x in xValues)
            {
                intervalNumber = (int)Math.Truncate(x / delta);
                countInIntervals[intervalNumber]++;
            }


            for (int i = 0; i < countInIntervals.Length; i++)
            {
                chart2.Series["Ci"].Points.AddXY(i * delta + delta / 2, (double)countInIntervals[i] / N);
            }

            StripLine stripline = new StripLine();
            stripline.StripWidth = 0.0001;
            stripline.BackColor = Color.Aquamarine;
            stripline.IntervalOffset = 1 / (double)countOfIntervals;

            chart2.ChartAreas[0].AxisY.StripLines.Add(stripline);
        }

        private void DrawEvaluationDiagram2(List<double> xValues, double? minX = null, double? maxX = null, double? maxY = null)
        {
            xValues.Sort();

            chart2.Series["Ci"].Points.Clear();
            chart1.Series["Xi"].Points.Clear();

            int[] countInIntervals = new int[countOfIntervals + 1];
            int intervalNumber;
            int max = 0;

            double delta = (xValues.Last() - xValues.First()) / countOfIntervals;

            foreach (double x in xValues)
            {
                intervalNumber = (int)Math.Truncate((x - xValues.First()) / delta) % 20;
                countInIntervals[intervalNumber]++;
            }

            foreach (int i in countInIntervals)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            chart2.ChartAreas[0].AxisY.Maximum = (maxY != null) ? maxY.Value : (1.5 * ((double)max / xValues.Count));
            chart2.ChartAreas[0].AxisY.Minimum = yMin;
            chart2.ChartAreas[0].AxisX.Maximum = (maxX != null) ? maxX.Value : xValues.Last();
            chart2.ChartAreas[0].AxisX.Minimum = (minX != null) ? minX.Value : xValues.First();

            for (int i = 0; i < countInIntervals.Length; i++)
            {
                chart2.Series["Ci"].Points.AddXY(xValues.First() + i * delta + delta / 2, (double)countInIntervals[i] / xValues.Count);
                Console.WriteLine((double)countInIntervals[i] / xValues.Count);
            }
        }

        private void RadioButton_uniform_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_uniform.Checked) return;
            label1.Text = "a = "; textBox1.Text = "5000";
            label2.Text = "b = "; textBox2.Text = "10000";
            label3.Text = "N = "; textBox3.Text = "130000";
        }

        private void RadioButton_gauss_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_gauss.Checked)
            {
                label1.Text = "m = ";
                textBox1.Text = "500";
                label2.Text = "σ = ";
                textBox2.Text = "100";
                label3.Text = "N = ";
                textBox3.Text = "130000";
            }
        }

        private void RadioButton_exp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_exp.Checked)
            {
                label1.Text = "λ = "; textBox1.Text = "100";
                label2.Text = "N = "; textBox2.Text = "130000";
                label3.Visible = false;
                textBox3.Visible = false;
            }
            else
            {
                label3.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void RadioButton_gamma_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_gamma.Checked) return;
            label1.Text = "η = "; textBox1.Text = "10";
            label2.Text = "λ = "; textBox2.Text = "400";
            label3.Text = "N = "; textBox3.Text = "130000";
        }

        private void RadioButton_triangle_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_triangle.Checked) return;
            label1.Text = "a = "; textBox1.Text = "1";
            label2.Text = "b = "; textBox2.Text = "50";
            label3.Text = "N = "; textBox3.Text = "130000";
        }

        private void RadioButton_simpson_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_simpson.Checked) return;
            label1.Text = "a = "; textBox1.Text = "20";
            label2.Text = "b = "; textBox2.Text = "100";
            label3.Text = "N = "; textBox3.Text = "130000";
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidNumber(M.Text) && IsValidNumber(A.Text) && IsValidNumber(R0.Text))
                {

                    double a = Convert.ToDouble(A.Text);
                    double m = Convert.ToDouble(M.Text);
                    double r0 = Convert.ToDouble(R0.Text);

                    if (m <= a)
                    {
                        MessageBox.Show("Параметр M должен быть больше A");
                        return;
                    }

                    Lehmer l = new Lehmer(a, m, r0);
                    List<double> rValues = l.getValues(N);
                    List<double> xValues = new List<double>();

                    if (radioButton_uniform.Checked)
                    {
                        xValues = Distribution.UniformDistribution(rValues, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                        DrawEvaluationDiagram2(xValues, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), 0.06);
                    }
                    else if (radioButton_gauss.Checked)
                    {
                        xValues = Distribution.GaussDistribution(rValues, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                        xValues.Sort();
                        DrawEvaluationDiagram2(xValues, Math.Truncate(xValues.First()) - 1, Math.Truncate(xValues.Last()) + 1, 0.3);
                    }
                    else if (radioButton_exp.Checked)
                    {
                        xValues = Distribution.ExponentialDistribution(rValues, Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox1.Text));
                        xValues.Sort();
                        DrawEvaluationDiagram2(xValues, Math.Round(xValues.First(), 3), Math.Round(xValues.Last(), 3), 0.6);
                    }
                    else if (radioButton_gamma.Checked)
                    {
                        xValues = Distribution.GammaDistribution(rValues, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                        xValues.Sort();
                        DrawEvaluationDiagram2(xValues, Math.Round(xValues.First(), 3), Math.Round(xValues.Last(), 3), 0.6);
                    }
                    else if (radioButton_triangle.Checked)
                    {
                        xValues = Distribution.TriangleDistribution(rValues, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                        xValues.Sort();
                        DrawEvaluationDiagram2(xValues, Math.Round(xValues.First(), 3), Math.Round(xValues.Last(), 3), 0.2);
                    }
                    else if (radioButton_simpson.Checked)
                    {
                        xValues = Distribution.SimpsonDistribution(rValues, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                        xValues.Sort();
                        DrawEvaluationDiagram2(xValues, Math.Round(xValues.First(), 3), Math.Round(xValues.Last(), 3), 0.2);
                    }

                    Calculations calc = new Calculations(xValues);
                    Mx2.Text = (calc.getMx()).ToString("0.0000000");
                    Dx2.Text = (calc.getDx()).ToString("0.0000000");
                    Sigma2.Text = (calc.getSigma()).ToString("0.0000000");

                }
                else
                {
                    MessageBox.Show("Некорректные входные параметры");
                }
            }
            catch
            {
                MessageBox.Show("Извините, произошла ошибка");
            }
        }
    }
}
