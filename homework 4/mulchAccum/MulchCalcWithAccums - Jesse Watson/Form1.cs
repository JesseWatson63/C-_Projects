using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulchCalcWithAccums___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//constants
        decimal truckCapacity = 4;
        decimal costYard = 30;
        decimal cubicFoot = 27;

//acumulator constants
        decimal total = 0;
        decimal totalOrders = 0;

        private void calculate_Click(object sender, EventArgs e)
        {

            //These are for the cubic yard calculator
            //cubic foot decimals
            decimal lengthInput = 0;
            decimal weidthInput = 0;
            decimal heightInput = 0;
            decimal cubicFeetTotal = 0;
            //cubic foot Parse
            try
            {

                lengthInput = decimal.Parse(feetLengthInput.Text);
                weidthInput = decimal.Parse(feetWidthInput.Text);
                heightInput = decimal.Parse(feetHeightInput.Text);

                cubicFeetTotal = (lengthInput * weidthInput * heightInput);

                feetCubicOutput.Text = cubicFeetTotal.ToString("n");
                //End of cubic yard calculator

                //Cubic yard Calculator

                decimal cubicYardTotal = 0;

                cubicYardTotal = cubicFeetTotal / cubicFoot;

                cubicYardOutput.Text = cubicYardTotal.ToString("n");
                //End of Cubic Yard

                //Calculating costs
                decimal totalCost1 = 0;


                totalCost1 = costYard * cubicYardTotal;

                priceOutput.Text = totalCost1.ToString("c");
                //End of cost calculator

                //added fun by me


                if
                (cubicYardTotal < truckCapacity) { greenDump.Visible = true; }


                else
                { redDump.Visible = true; }

                if
                    (cubicYardTotal < truckCapacity) { truckLoad.BackColor = Color.Green; }
                else
                { truckLoad.BackColor = Color.Red; }

                //end of fun by me

                //for the truck calculations
                decimal truckFill = 0;

                truckFill = truckCapacity - cubicYardTotal;

                truckLoad.Text = truckFill.ToString("n");



                //Mulch Accumulator        

                total = cubicYardTotal + total;

                totalMulchAccum.Text = total.ToString("n");

                if
                (total < 4) { totalMulchAccum.BackColor = Color.Green; }

                else
                { totalMulchAccum.BackColor = Color.Red; }

                //Order Accumulator
                totalOrders = totalOrders + 1;

                totalOrder.Text = totalOrders.ToString("n");

            }

            catch
            {
                MessageBox.Show("Please enter valid numbers");
            }
        }
        //end of truck calculations

        
        private void clear_Click(object sender, EventArgs e)
        {
            feetLengthInput.Text = "";
            feetWidthInput.Text = "";
            feetHeightInput.Text = "";
            feetCubicOutput.Text = "";
            cubicYardOutput.Text = "";
            priceOutput.Text = "";
            truckLoad.Text = "";
            redDump.Visible = false;
            greenDump.Visible = false;
            truckLoad.BackColor = Color.Transparent;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalMulchAccum.Text = "";
            totalMulchAccum.BackColor = Color.Transparent;
            totalOrder.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
