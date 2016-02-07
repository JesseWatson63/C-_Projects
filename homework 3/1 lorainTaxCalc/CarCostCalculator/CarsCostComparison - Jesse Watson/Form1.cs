using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsCostComparison___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal mpg = 12000;
                decimal pricePerGallon = 3.50m;
                decimal inputCar1 = 0;
                decimal total1 = 0;

                inputCar1 = int.Parse(mpgCar1.Text);

                total1 = (mpg / inputCar1) * pricePerGallon;
                fuelCostCar1.Text = total1.ToString("c");

                decimal inputCar2 = 0;
                decimal total2 = 0;

                inputCar2 = int.Parse(mpgCar2.Text);

                total2 = (mpg / inputCar2) * pricePerGallon;
                fuelCostCar2.Text = total2.ToString("c");




                decimal CarCost1 = 0;
                decimal total3 = 0;

                CarCost1 = decimal.Parse(ippCar1.Text);
                total3 = ((mpg / inputCar1) * pricePerGallon) + CarCost1;
                tcCar1.Text = total3.ToString("c");

                decimal CarCost2 = 0;
                decimal total4 = 0;
                CarCost2 = decimal.Parse(ippCar2.Text);
                total4 = ((mpg / inputCar2) * pricePerGallon) + CarCost2;
                tcCar2.Text = total4.ToString("c");
            }
            catch
            {
                MessageBox.Show("Please place value in all blank areas");
            }



         
        }

        private void resetCar1_Click(object sender, EventArgs e)
        {
            yearCar1.Text = "";
            makeCar1.Text = "";
            modelCar1.Text = "";
            mpgCar1.Text = "";
            ippCar1.Text = "";
            arpCar1.Text = "";
            aicCar1.Text = "";
            fuelCostCar1.Text = "";
            tcCar1.Text = "";
        }

        private void resetCar2_Click(object sender, EventArgs e)
        {
            yearCar2.Text = "";
            makeCar2.Text = "";
            modelCar2.Text = "";
            mpgCar2.Text = "";
            ippCar2.Text = "";
            arpCar2.Text = "";
            aicCar2.Text = "";
            fuelCostCar2.Text = "";
            tcCar2.Text = ""; 
        }

        private void resetAll_Click(object sender, EventArgs e)
        {
            yearCar1.Text = "";
            makeCar1.Text = "";
            modelCar1.Text = "";
            mpgCar1.Text = "";
            ippCar1.Text = "";
            arpCar1.Text = "";
            aicCar1.Text = "";
            fuelCostCar1.Text = "";
            tcCar1.Text = "";
            yearCar2.Text = "";
            makeCar2.Text = "";
            modelCar2.Text = "";
            mpgCar2.Text = "";
            ippCar2.Text = "";
            arpCar2.Text = "";
            aicCar2.Text = "";
            fuelCostCar2.Text = "";
            tcCar2.Text = ""; 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
