using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            decimal ncc1701A = 100000;
            decimal ncc1701DB = 150000;
            decimal longRangePhoton = 100;
            decimal leatherWrapped = 150;
            decimal hollowDeck1 = 250;
            decimal starShipCost1 = 0;



            if (ncc1701.Checked)
            { starShipCost1 = + ncc1701A; }
            if (ncc1701D.Checked)
            { starShipCost1 = + ncc1701DB; }
            if (photonTorpedo.Checked)
            { starShipCost1 = starShipCost1 + longRangePhoton;
                cptGoodies.Text =   "Photon Torpedos $100" + " " + cptGoodies.Text;
            }
            if (leatherSeat.Checked)
            { starShipCost1 = starShipCost1 + leatherWrapped;
            cptGoodies.Text = "Leather Wrapped Cpt Chair $150" + " " + cptGoodies.Text;
            }
            if (hollowDeck.Checked)
            { starShipCost1 = starShipCost1 + hollowDeck1;
            cptGoodies.Text = "Hollow Deck $250" + " " + cptGoodies.Text;
            }




            starShipCost.Text = starShipCost1.ToString("c");


        }

       private void button2_Click(object sender, EventArgs e)
        {
            starShipCost.Text = "";
            cptGoodies.Text = "";
            photonTorpedo.Checked = false;
            leatherSeat.Checked = false;
            hollowDeck.Checked = false;
            ncc1701.Checked = false;
            ncc1701D.Checked = false;
        }

       private void button3_Click(object sender, EventArgs e)
       {
           this.Close();
       }
    }
}
