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
                //this will run if condition is true
                headsUp.Visible = true;
                tails.Visible = false;

            }
            else
            {
                //this will run if false
                headsUp.Visible = false;
                tails.Visible = true;

            }
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            headsUp.Visible = false;
            tails.Visible = false;

        }
    }
}
