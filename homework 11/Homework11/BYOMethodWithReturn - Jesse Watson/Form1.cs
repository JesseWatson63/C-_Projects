using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMPGCalc___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal total = 0;
        decimal fillUpMileage = 0;
        

        private void calculateButton_Click(object sender, EventArgs e)
        {//The following is for the total mileage traveled in between fillups.
            //Ive noticed unless doing something wrong that you pretty much rename 
            //everything within VS to Parse and ToString it.

            decimal fillUp1 = 0;
            decimal fillUp2 = 0;

            if (decimal.TryParse(fillUpMiles1.Text, out fillUp1))
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Miles At Fillup Number");
                return;
            }

            if (decimal.TryParse(fillUpMiles2.Text, out fillUp2))
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Miles At Fillup 2 Number");
            }
            fillUpMileage = fillUp2 - fillUp1;
            totalMilesTraveled.Text = fillUpMileage.ToString("");
            //Mileage divided by gallonsEntry2
            decimal gallons = 0;
            decimal mpg = 0;

            if (decimal.TryParse(gallonsEntry.Text, out gallons))
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Gallon Amount");
            }
            mpg = fillUpMileage / gallons;
            totalMPG.Text = mpg.ToString("");
            //ppg / totalMPG
            decimal ppg1 = 0;

            if (decimal.TryParse(ppg.Text, out ppg1))
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Price Per Gallon");
            }

            if (mpg == 0)
            {
                MessageBox.Show("Please Enter valid fillup miles and gallons and retry");
            }
            else
            {
                total = ppg1 / mpg;
                FuelCostPerMile.Text = total.ToString("c");
            }
            decimal recallNumber = 0;
            recallNumber = jesseWatsonMethod(fillUpMileage , total);
            yearlyFuelCostLabel.Text = recallNumber.ToString("");
        }
        private decimal jesseWatsonMethod(decimal passIn_fillUpMileage, decimal passIn_total)
        {
            decimal local_recallNumber = 0;
            local_recallNumber = passIn_total * 12000;
            return local_recallNumber;
        }
        //this is the usual reset button.
        private void clearButton_Click(object sender, EventArgs e)
        {
            fillUpMiles1.Text = "";
            fillUpMiles2.Text = "";
            gallonsEntry.Text = "";
            ppg.Text = "";
            totalMilesTraveled.Text = "";
            totalMPG.Text = "";
            FuelCostPerMile.Text = "";
        }
        //this is the usual close button.
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

     
    }
}
