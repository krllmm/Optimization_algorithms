using Plot3D;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Plot3D.ColorSchema;
using static Plot3D.Graph3D;


using delRendererFunction = Plot3D.Graph3D.delRendererFunction;
using cPoint3D = Plot3D.Graph3D.cPoint3D;
using eRaster = Plot3D.Graph3D.eRaster;
using cScatter = Plot3D.Graph3D.cScatter;
using eNormalize = Plot3D.Graph3D.eNormalize;
using eSchema = Plot3D.ColorSchema.eSchema;

namespace OPR_1
{
    internal class GraphicController
    {
        public double function_calc(double x1, double y1, double x2, double y2, double x, double y)
        {
            return -x1 * x * x - (-y1) * y * y + x2 * x + y2 * y;
        }
        public void MakeSurface(Graph3D graph3D1)
        {
            InputController inputController = new InputController();


          

            //double[] func = inputController.GetFunction();
            double[] range = inputController.GetRange();
            double step = inputController.GetStep();


            SetFormula("12 * sin(x) * cos(y) / (sqrt(sqrt(x * x + y * y)) + 0.2)", graph3D1, range, step);

            graph3D1.Raster = (eRaster)1;
            Color[] c_Colors = Plot3D.ColorSchema.GetSchema((eSchema)1);
            graph3D1.SetColorScheme(c_Colors, 3);


            //int array_step_i = Convert.ToInt32((range[1] - range[0]) / step);
            //int array_step_k = Convert.ToInt32((range[3] - range[2]) / step);
            //double[,] values = new double[array_step_i + 1, array_step_k + 1];

            //double fun_i = range[0];
            //for (int i = 0; i <= array_step_i; i++)
            //{

            //    double fun_k = range[2];

            //    for (int k = 0; k <= array_step_k; k++)
            //    {
            //        values[i, k] = function_calc(func[0], func[1], func[2], func[3], fun_i, fun_k);
            //        fun_k += step;
            //    }
            //    fun_i += step;
            //}   

            //Graph3D graph3D1 = Application.OpenForms["Form1"].Controls["graph3D1"] as Graph3D;

            //SetSurface(values, graph3D1);
            //graph3D1.Raster = (eRaster)3;
            //Color[] c_Colors = Plot3D.ColorSchema.GetSchema((eSchema)2);
            //graph3D1.SetColorScheme(c_Colors, 3);
        }

        private void SetFormula(string s_Formula, Graph3D graph3D1, double[] range, double step)
        {
            try
            {
                delRendererFunction f_Function = Plot3D.FunctionCompiler.Compile(s_Formula);

                // IMPORTANT: Normalize maintainig the relation between X,Y,Z values otherwise the function will be distorted.
                graph3D1.SetFunction(f_Function, new PointF((int)range[0], (int)range[2]), new PointF((int)range[1], (int)range[3]), step, eNormalize.MaintainXYZ);
                //graph3D1.SetFunction(f_Function, new PointF(-5, 5), new PointF(-5, 5), 0.5, eNormalize.MaintainXYZ);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetSurface(double[,] s32_Values, Graph3D graph3D1)
        {
            cPoint3D[,] i_Points3D = new cPoint3D[s32_Values.GetLength(0), s32_Values.GetLength(1)];
            for (int X = 0; X < s32_Values.GetLength(0); X++)
            {
                for (int Y = 0; Y < s32_Values.GetLength(1); Y++)
                {
                    i_Points3D[X, Y] = new cPoint3D(X * 10, Y * 500, s32_Values[X, Y]);
                }
            }

            graph3D1.AxisX_Legend = "x";
            graph3D1.AxisY_Legend = "y";
            graph3D1.AxisZ_Legend = "f(x,y)";

            //graph3D1.SetFunction();

            graph3D1.SetSurfacePoints(i_Points3D, eNormalize.Separate);
            return;
        }
    }
}
