using System;
using System.Windows.Forms;
namespace OPR_1
{
    internal class InputController
    {
        public double[] GetFunction()
        {
            TextBox t = Application.OpenForms["Form1"].Controls["textBox1"] as TextBox;
            string func = t.Text;
            int perems = 0;

            double[] indexes = new double[4];
            for (int i = 0; i < func.Length; i++)
            {
                if (func[i] == 'x' || func[i] == 'y')
                {
                    switch (perems)
                    {
                        case 0:
                            if (i != 1)
                            {
                                indexes[0] = Double.Parse(func.Substring(i - 2, 2));
                                perems++;
                                break;
                            }
                            indexes[0] = Double.Parse(func[i - 1].ToString());
                            perems++;
                            break;
                        case 1:
                            indexes[1] = Double.Parse(func.Substring(i - 2, 2));
                            perems++;
                            break;
                        case 2:
                            indexes[2] = Double.Parse(func.Substring(i - 2, 2));
                            perems++;
                            break;
                        case 3:
                            indexes[3] = Double.Parse(func.Substring(i - 2, 2));
                            perems++;
                            break;
                    }
                }
            }
            return indexes;
        }
        public double[] GetRestrictions()
        {
            TextBox tb1 = Application.OpenForms["Form1"].Controls["textBox2"] as TextBox;
            TextBox tb2 = Application.OpenForms["Form1"].Controls["textBox4"] as TextBox;

            double[] rest = new double[4];
            string limit1 = tb1.Text, limit2 = tb2.Text;
            int perems2 = 0, perems3 = 0;
            for (int i = 0; i < limit1.Length; i++)
            {
                if (limit1[i] == 'x' || limit1[i] == 'y')
                {
                    switch (perems2)
                    {
                        case 0:
                            if (i != 1)
                            {
                                rest[0] = Double.Parse(limit1.Substring(i - 2, 2));
                                perems2++;
                                break;
                            }
                            rest[0] = Double.Parse(limit1[i - 1].ToString());
                            perems2++;
                            break;
                        case 1:
                            rest[1] = Double.Parse(limit1.Substring(i - 2, 2));
                            perems2++;
                            break;
                    }
                }
            }
            for (int i = 0; i < limit2.Length; i++)
            {
                if (limit2[i] == 'x' || limit2[i] == 'y')
                {
                    switch (perems3)
                    {
                        case 0:
                            if (i != 1)
                            {
                                rest[2] = Double.Parse(limit2.Substring(i - 2, 2));
                                perems3++;
                                break;
                            }
                            rest[2] = Double.Parse(limit2[i - 1].ToString());
                            perems3++;
                            break;
                        case 1:
                            rest[3] = Double.Parse(limit2.Substring(i - 2, 2));
                            perems3++;
                            break;
                    }
                }
            }
            return rest;
        }
        public double[] GetRange()
        {
            TextBox tb1 = Application.OpenForms["Form1"].Controls["textBox7"] as TextBox;
            TextBox tb2 = Application.OpenForms["Form1"].Controls["textBox8"] as TextBox;
            TextBox tb3 = Application.OpenForms["Form1"].Controls["textBox9"] as TextBox;
            TextBox tb4 = Application.OpenForms["Form1"].Controls["textBox10"] as TextBox;

            double[] data = { Double.Parse(tb1.Text), Double.Parse(tb2.Text), Double.Parse(tb3.Text), Double.Parse(tb4.Text) };
            return data;
        }
        public double GetStep()
        {
            TextBox tb = Application.OpenForms["Form1"].Controls["textBox6"] as TextBox;
            return Double.Parse(tb.Text);
        }
        public double[] GetRightBit()
        {
            double[] o_r = new double[2];

            TextBox tb1 = Application.OpenForms["Form1"].Controls["textBox3"] as TextBox;
            TextBox tb2 = Application.OpenForms["Form1"].Controls["textBox5"] as TextBox;
            o_r[0] = Double.Parse(tb1.Text);
            o_r[1] = Double.Parse(tb2.Text);

            return o_r;
        }
        public int GetIterations()
        {
            TextBox tb = Application.OpenForms["Form1"].Controls["textBox11"] as TextBox;
            return int.Parse(tb.Text);
        }
    }
}
