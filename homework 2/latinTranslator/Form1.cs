using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sinister_Click(object sender, EventArgs e)
        {
            label1.Text = "Enlgish translation: left";
        }

        private void dexter_Click(object sender, EventArgs e)
        {
            label1.Text = "English Translation: right";
        }

        private void medium_Click(object sender, EventArgs e)
        {
            label1.Text = "English translation: center";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
