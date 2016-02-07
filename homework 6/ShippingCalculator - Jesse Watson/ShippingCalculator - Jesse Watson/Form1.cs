using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//jesse watson
//256777
//10-18-2013
//The purpose of this program is to give a shipper a price to ship a package
namespace ShippingCalculator___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        


        private void button1_Click(object sender, EventArgs e)
        {
           //This is for the price determination on the zone.
            decimal packageDestination1 = 0;
            int shippingRate = 0;

            packageDestination1 = decimal.Parse(packageDestination.Text);
           if (packageDestination1 > 0 && packageDestination1 < 5)
            shippingRate = 0;
            if (packageDestination1 == 1)
            {
                shippingRate = 1;
            }
            else if (packageDestination1 == 2)
            {
               shippingRate = 2;
            }
            else if (packageDestination1 == 3)
            {
                shippingRate = 3;
            }
            else if (packageDestination1 == 4)

            {
               shippingRate = 4;
            }

           else 
            {MessageBox.Show("Please Enter a Validate Shipping Destination Number");
            }
            
           //end of zone
            //this is the area where the zone is used to determine what the price is going to be for shipping
    
            decimal rateToUse = 0;
            const decimal rate1 = 4.75m;
            const decimal rate2 = 6.15m;
            const decimal rate3 = 7.95m;
            const decimal rate4 = 8.45m;
            

            switch (shippingRate)
            {
                case 1:
                    rateToUse = rate1;
                    break;
                case 2:
                    rateToUse = rate2;
                    break;
                case 3:
                    rateToUse = rate3;
                    break;
                case 4:
                    rateToUse = rate4;
                    break;
                default:
                    return;
            }
            zoneCost.Text = shippingRate.ToString();


            decimal packageWeight1 = 0;

            packageWeight1 = decimal.Parse(packageWeight.Text);
            
            //end of destination information

            const decimal weightPrice = 2;
            decimal weightCost1 = 0;
            
            weightCost1 = (packageWeight1 * weightPrice);
            weightCost.Text = weightCost1.ToString("c");

            decimal shippingCost1 = 0;
            shippingCost1 = rateToUse + weightCost1;
            shippingCost.Text = shippingCost1.ToString("c");
        }
        //clear button
        private void clear_Click(object sender, EventArgs e)
        {
            packageWeight.Text = "";
            packageDestination.Text = "";
            weightCost.Text = "";
            zoneCost.Text = "";
            shippingCost.Text = "";
        }
    }
}
