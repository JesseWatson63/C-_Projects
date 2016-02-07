using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: Jesse Watson
//I.D.: 256777
//Date: 9-16-2013
//Goal Of This Program: to identifie the selected card
namespace cardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            cardIdentifier.Text = "King of Clubs";
            //Here I set it so that when the King of clubs is pushed the label.Text displays "King of Clubs"
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            cardIdentifier.Text = "Ace of Clubs";
            //Here I set it so that when the Ace of clubs is pushed the label.Text displays "Ace of Clubs".
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cardIdentifier.Text = "Queen of Clubs";
            //Here I set it so that when the Queen of clubs is pushed the label.Text displays "Queen of Clubs".
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cardIdentifier.Text = "Jack of Clubs";
            //Here I set it so that when the Jack of clubs is pushed the labe.Text displays "Jack of Clubs".
        }

        private void nineClubs_Click(object sender, EventArgs e)
        {
            cardIdentifier.Text = "You Loose";
        }

        private void redCard1_Click(object sender, EventArgs e)
        {
            redCard1.Visible = false;
        }

        private void redCard2_Click(object sender, EventArgs e)
        {
            redCard2.Visible = false;
        }

        private void redCard3_Click(object sender, EventArgs e)
        {
            redCard3.Visible = false;
        }

        private void redCard4_Click(object sender, EventArgs e)
        {
            redCard4.Visible = false;
        }

        private void redCard5_Click(object sender, EventArgs e)
        {
            redCard5.Visible = false;
        }
    }
}
