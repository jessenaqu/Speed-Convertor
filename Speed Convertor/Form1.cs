using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //======================
            //   Close the form
            //======================
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplaySpeed_Click(object sender, EventArgs e)
        {
            //======================
            //  Declare constants
            //======================
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            //======================
            //  Declare variables
            //======================
            int kph;
            double mph;

            //======================
            //       Speeds
            //======================
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                //======================
                //  Convert kph to mph
                //======================
                mph = kph * CONVERSION_FACTOR;

                //======================
                // Display conversion
                //======================
                listBoxMiles.Items.Add(kph + " kilometers per hours is = to " + mph + " miles per hour");
            }
        }
    }
}
