using System;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace OPR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MethodController methodController = new MethodController();

            if (comboBox3.SelectedIndex == 0) methodController.PereborPoSetke();
            if (comboBox3.SelectedIndex == 1) methodController.MonteKarlo();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex == 0)
            {
                textBox11.Visible = false;
                label10.Visible = false;
            }
            else
            {
                textBox11.Visible = true;
                label10.Visible = true;
            }
        }
    }
}
