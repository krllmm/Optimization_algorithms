using PdfSharp.Drawing;
using Plot3D;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OPR_1
{
    internal class MethodController
    {
        public double function_calc(double x1, double y1, double x2, double y2, double x, double y)
        {
            return -x1 * x * x -(-y1) * y * y + x2 * x + y2 * y;
        }
        public double PereborPoSetke()
        {
            Label label = Application.OpenForms["Form1"].Controls["label3"] as Label;
            label.Text = "";
            Label label_res = Application.OpenForms["Form1"].Controls["label9"] as Label;
            label_res.Text = "";
            var watch = Stopwatch.StartNew();

            InputController inputController = new InputController();
            double[] func = inputController.GetFunction();
            double[] rest = inputController.GetRestrictions();
            double step = inputController.GetStep();

            DataGridView dataGridView1 = Application.OpenForms["Form1"].Controls["dataGridView1"] as DataGridView;
            ComboBox comboBox1 = Application.OpenForms["Form1"].Controls["comboBox1"] as ComboBox;
            ComboBox comboBox2 = Application.OpenForms["Form1"].Controls["comboBox2"] as ComboBox;
            dataGridView1.Rows.Clear();
                
            double[] range = inputController.GetRange();
            double[] o_r = inputController.GetRightBit();
            double x_coor = 0, y_coor = 0;
            double max = 0;
            int array_step_i = Convert.ToInt32((range[1] - range[0]) / step);
            int array_step_k = Convert.ToInt32((range[3] - range[2]) / step);
            double[,] values = new double[array_step_i + 2, array_step_k + 2];
            int array_i = 0;

            for (double i = range[0]; i <= range[1]; i += step, array_i++)
            {
                int array_k = 0;
                for (double k = range[2]; k <= range[3]; k += step, array_k++)
                {
                    double value = function_calc(func[0], func[1], func[2], func[3], i, k);
                    values[array_i, array_k] = value;
                    dataGridView1.Rows.Add(Math.Round(i, 3), Math.Round(k, 3), Math.Round(value, 3));

                    if (value >= max)
                    {
                        switch (comboBox1.Text)
                        {
                            case ">=":
                                if ((rest[0] * i + rest[1] * k) >= o_r[0])
                                {
                                    switch (comboBox2.Text)
                                    {
                                        case "<=":
                                            if ((rest[2] * i + rest[3] * k) <= o_r[1])
                                            {
                                                max = value;
                                                x_coor = i;
                                                y_coor = k;
                                            }
                                            break;
                                        case ">=":
                                            if ((rest[2] * i + rest[3] * k) >= o_r[1])
                                            {
                                                max = value;
                                                x_coor = i;
                                                y_coor = k;
                                            }
                                            break;
                                    }
                                }
                                break;
                            case "<=":
                                if ((rest[0] * i + rest[1] * k) <= o_r[0])
                                {
                                    switch (comboBox2.Text)
                                    {
                                        case "<=":
                                            if ((rest[2] * i + rest[3] * k) <= o_r[1])
                                            {
                                                max = value;
                                                x_coor = i;
                                                y_coor = k;
                                            }
                                            break;
                                        case ">=":
                                            if ((rest[2] * i + rest[3] * k) >= o_r[1])
                                            {
                                                max = value;
                                                x_coor = i;
                                                y_coor = k;
                                            }
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            label.Text = "Максимальное значение функции: " + Math.Round(max, 5) + " в точке (" + Math.Round(x_coor, 3) + "; " + Math.Round(y_coor, 3) + ")";
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            label_res.Text = "Вычисление заняло " + (elapsedMs / 1000.0).ToString() + " сек.";

            Graph3D graph = Application.OpenForms["Form1"].Controls["graph3D1"] as Graph3D;
            GraphicController graphicController = new GraphicController();
            graphicController.MakeSurface(graph);
            return 0;
        }
        public double MonteKarlo()
        {
            Label label = Application.OpenForms["Form1"].Controls["label3"] as Label;
            label.Text = "";
            Label label_res = Application.OpenForms["Form1"].Controls["label9"] as Label;
            label_res.Text = "";

            Random rnd = new Random();
            InputController inputController = new InputController();

            var watch = Stopwatch.StartNew();
            double point, point2;
            DataGridView dataGridView1 = Application.OpenForms["Form1"].Controls["dataGridView1"] as DataGridView;
            dataGridView1.Rows.Clear();

            ComboBox comboBox1 = Application.OpenForms["Form1"].Controls["comboBox1"] as ComboBox;
            ComboBox comboBox2 = Application.OpenForms["Form1"].Controls["comboBox2"] as ComboBox;
            double[] func = inputController.GetFunction();
            double[] rest = inputController.GetRestrictions();
            double[] range = inputController.GetRange();

            double[] o_r = inputController.GetRightBit();
            double x_coor = 0, y_coor = 0;
            double max = 0;

            int iter = 0;

            for (int k = 0; k <= inputController.GetIterations(); k++)
            {
                point = (rnd.Next(0, 100)/100.0) * (range[1] - range[0]) + range[0];
                point2 = (rnd.Next(0, 100)/100.0) * (range[3] - range[2]) + range[2];

                double value = function_calc(func[0], func[1], func[2], func[3], point, point2);
                dataGridView1.Rows.Add(Math.Round(point, 4), Math.Round(point2, 4), Math.Round(value, 4));

                Debug.WriteLine(point + " -- " + point2 + " -- " + value);

                switch (comboBox1.Text)
                {
                    case ">=":
                        if ((rest[0] * point + rest[1] * point2) >= o_r[0])
                        {
                            switch (comboBox2.Text)
                            {
                                case "<=":
                                    if ((rest[2] * point + rest[3] * point2) <= o_r[1])
                                    {
                                        if (value > max)
                                        {
                                            max = value;
                                            x_coor = point;
                                            y_coor = point2;
                                            iter = k;
                                        }
                                    }
                                    break;
                                case ">=":
                                    if ((rest[2] * point + rest[3] * point2) >= o_r[1])
                                    {
                                        if (value > max)
                                        {
                                            max = value;
                                            x_coor = point;
                                            y_coor = point2;
                                            iter = k;
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "<=":
                        if ((rest[0] * point + rest[1] * point2) <= o_r[0])
                        {
                            switch (comboBox2.Text)
                            {
                                case "<=":
                                    if ((rest[2] * point + rest[3] * point2) <= o_r[1])
                                    {
                                        if (value > max)
                                        {
                                            max = value;
                                            x_coor = point;
                                            y_coor = point2;
                                            iter = k;
                                        }
                                    }
                                    break;
                                case ">=":
                                    if ((rest[2] * point + rest[3] * point2) >= o_r[1])
                                    {
                                        if (value > max)
                                        {
                                            max = value;
                                            x_coor = point;
                                            y_coor = point2;
                                            iter = k;
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                }
                   
            }

            label.Text = "Максимальное значение функции: " + Math.Round(max, 5) + " в точке (" + Math.Round(x_coor, 3) + "; " + Math.Round(y_coor, 3) + ") на итерации " + iter.ToString();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            label_res.Text = "Вычисление заняло " + (elapsedMs / 1000.0).ToString() + " сек.";


            Graph3D graph = Application.OpenForms["Form1"].Controls["graph3D1"] as Graph3D;
            GraphicController graphicController = new GraphicController();
            graphicController.MakeSurface(graph);

            return 0;
        }
    }
}
