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

        private void calculateButton_Click(object sender, EventArgs e)
        {//The following is for the total mileage traveled in between fillups.
            //Ive noticed unless doing something wrong that you pretty much rename 
            //everything within VS to Parse and ToString it.
            try{
            decimal fillUp1 = 0;
            decimal fillUp2 = 0;
            decimal fillUpMileage = 0;
              
            fillUp1 = decimal.Parse(fillUpMiles1.Text);
            fillUp2 = decimal.Parse(fillUpMiles2.Text);

            fillUpMileage = fillUp2 - fillUp1;

            totalMilesTraveled.Text = fillUpMileage.ToString("");




           //Mileage divided by gallonsEntry2
            decimal gallons = 0;
            decimal mpg = 0;
            
            gallons = decimal.Parse(gallonsEntry.Text);

            mpg = fillUpMileage / gallons;

            totalMPG.Text = mpg.ToString("");
        
            //ppg / totalMPG

            decimal total = 0;
            decimal ppg1 = 0;

            ppg1 = decimal.Parse(ppg.Text);

            total = ppg1/mpg;

            FuelCostPerMile.Text = total.ToString("c");
            }

                catch 
            {
            MessageBox.Show ("Please enter a valid number");
                }

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
