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
using System.Diagnostics;

namespace OPR_1
{
    internal class GraphicController
    {
        public void MakeSurface(Graph3D graph3D1)
        {
            InputController inputController = new InputController();

            string func = inputController.GetFunctionString();
            func = func.Replace("x", "*x");
            func = func.Replace("y", "*y");

            string S2 = "x^2";
            string S3 = "pow(x,2)";
            int IndexFirst3 = func.IndexOf(S2);
            func = func.Remove(IndexFirst3, S2.Length).Insert(IndexFirst3, S3);

            string S4 = "y^2";
            string S5 = "pow(y,2)";
            int IndexSec = func.IndexOf(S4);

            func = func.Remove(IndexSec, S4.Length).Insert(IndexSec, S5);

            double[] range = inputController.GetRange();
            double step = inputController.GetStep();

            SetFormula(func, graph3D1, range, step);

            graph3D1.Raster = eRaster.Labels;
            Color[] c_Colors = Plot3D.ColorSchema.GetSchema((eSchema)1);
            graph3D1.SetColorScheme(c_Colors, 3);

        }

        private void SetFormula(string s_Formula, Graph3D graph3D1, double[] range, double step)
        {
            try
            {
                delRendererFunction f_Function = Plot3D.FunctionCompiler.Compile(s_Formula);

                // IMPORTANT: Normalize maintainig the relation between X,Y,Z values otherwise the function will be distorted.
                graph3D1.SetFunction(f_Function, new PointF((int)range[0], (int)range[2]), new PointF((int)range[1], (int)range[3]), step, eNormalize.Separate);
                //graph3D1.SetFunction(f_Function, new PointF(-5, 5), new PointF(-5, 5), 0.5, eNormalize.MaintainXYZ);
                graph3D1.AxisX_Legend = "x";
                graph3D1.AxisY_Legend = "y";
                graph3D1.AxisZ_Legend = "f(x,y)";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
