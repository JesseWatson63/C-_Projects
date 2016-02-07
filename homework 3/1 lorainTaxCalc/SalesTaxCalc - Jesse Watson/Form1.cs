using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jesse Watson
//256777
//9-27-2013
//the purpose of this program is so the user can put in a dollar amount and recieve the tax cost to him\her
//and the total cost.
namespace SalesTaxCalc___Jesse_Watson
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void taxButton_Click(object sender, EventArgs e)
        {
            
             try{
            decimal lorainTax = 0;// This is to set number type
            decimal dollar = 0;// This is to set number type
            decimal taxtotal = 0;//this is to set number amount
            decimal totaldollar = 0;//this was to set output of the multiplication amount
            dollar = decimal.Parse(dollarTextBox.Text);//this was to make VS to recognize numbers
            

            
            lorainTax = 0.0675m;//This is the fixed tax amount
            taxtotal  = dollar * lorainTax;//this is so the program multiplies the fixed tax amount
            //and the entered dollar amount.
            taxBox.Text = taxtotal.ToString("c");//this is so that the program puts the dollar amount
            //into the taxbox in currency form

            totaldollar = dollar + taxtotal;//this is so that in on click the user recieves the tax amount
            //and the dollar plus tax amount
            totalDollarAmount.Text = totaldollar.ToString("c");// this is so that the user sees the 
             }
            //total amount in the the total box in currency form
                 catch{
                     MessageBox.Show("Please Use A Valid Dollar Amount.");
                     //This was done in the case the user did not input a valid number
                 }
        }

        private void clearText_Click(object sender, EventArgs e)
        {//this was so that the user can clear all fields and start over
            dollarTextBox.Text = "";
            taxBox.Text = "";
            totalDollarAmount.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {//this is so that the user can use a close button
            this.Close();
        }
    }
}
