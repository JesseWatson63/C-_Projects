using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Flipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flip1_Click(object sender, EventArgs e)
        {
            int myInt;

            Random myObjRandom = new Random();

            myInt = myObjRandom.Next(2);

            if (myInt == 0)
            {
                //headsup will be visible if true
                headsUp.Visible = true;
                tails.Visible = false;

            }
            else
            {
                //Tails will be visible if true
                headsUp.Visible = false;
                tails.Visible = true;

            }
            /*This part is so that when the button is clicked it can not be clicked again until
             the reset button is clicked*/
            flip1.Enabled = false;
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            headsUp.Visible = false;
            tails.Visible = false;
            /*this is so that the reset button enables the flip1 button again*/
            flip1.Enabled = true;
        }
        //I created the close button to make it easier for the user to close out of the program
        private void dontQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
