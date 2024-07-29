using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionLenUnit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxMeter_Leave(object sender, EventArgs e)
        {
            double meter, inch;
            if (Double.TryParse(textBoxMeter.Text, out meter))
            {
                inch = meter * 39.37;
                textBoxMillimeter.Text = $"{meter * 1000}";
                textBoxCentimeter.Text = $"{meter * 100}";
                textBoxKilometer.Text = $"{meter / 1000}";
                textBoxInch.Text = $"{inch}";
                textBoxYard.Text = $"{inch / 36}";
                textBoxFoot.Text = $"{inch / 12}";
                textBoxMile.Text = $"{inch / 63360}";
            } else
                MessageBox.Show("Please enter a valid input.");
        }

        private void textBoxMillimeter_Leave(object sender, EventArgs e)
        {
            double meter, millimeter, inch;
            if (Double.TryParse(textBoxMillimeter.Text, out millimeter))
            {
                inch = millimeter / 25.4;
                meter = millimeter / 1000;
                textBoxMeter.Text = $"{meter}";
                textBoxCentimeter.Text = $"{meter * 100}";
                textBoxKilometer.Text = $"{meter / 1000}";
                textBoxInch.Text = $"{inch}";
                textBoxYard.Text = $"{inch / 36}";
                textBoxFoot.Text = $"{inch / 12}";
                textBoxMile.Text = $"{inch / 63360}";
            }
            else
                MessageBox.Show("Please enter a valid input.");
        }

        private void textBoxCentimeter_Leave(object sender, EventArgs e)
        {
            double meter, centimeter, inch;
            if (Double.TryParse(textBoxCentimeter.Text, out centimeter))
            {
                inch = centimeter / 2.54;
                meter = centimeter / 100;
                textBoxMeter.Text = $"{meter}";
                textBoxMillimeter.Text = $"{meter * 1000}";
                textBoxKilometer.Text = $"{meter / 1000}";
                textBoxInch.Text = $"{inch}";
                textBoxYard.Text = $"{inch / 36}";
                textBoxFoot.Text = $"{inch / 12}";
                textBoxMile.Text = $"{inch / 63360}";
            }
            else
                MessageBox.Show("Please enter a valid input.");
        }

        private void textBoxKilometer_Leave(object sender, EventArgs e)
        {
            double meter, kilometer, inch;
            if (Double.TryParse(textBoxKilometer.Text, out kilometer))
            {
                inch = kilometer * 39370;
                meter = kilometer / 1000;
                textBoxMeter.Text = $"{meter}";
                textBoxMillimeter.Text = $"{meter * 1000}";
                textBoxCentimeter.Text = $"{meter * 100}";
                textBoxInch.Text = $"{inch}";
                textBoxYard.Text = $"{inch / 36}";
                textBoxFoot.Text = $"{inch / 12}";
                textBoxMile.Text = $"{inch / 63360}";
            }
            else
                MessageBox.Show("Please enter a valid input.");
        }

        private void textBoxInch_Leave(object sender, EventArgs e)
        {
            double meter, inch;
            if (Double.TryParse(textBoxInch.Text, out inch))
            {
                meter = inch / 39.37;
                textBoxMeter.Text = $"{meter}";
                textBoxMillimeter.Text = $"{meter * 1000}";
                textBoxCentimeter.Text = $"{meter * 100}";
                textBoxKilometer.Text = $"{meter / 1000}";
                textBoxYard.Text = $"{inch / 36}";
                textBoxFoot.Text = $"{inch / 12}";
                textBoxMile.Text = $"{inch / 63360}";
            }
            else
                MessageBox.Show("Please enter a valid input.");
        }

        private void textBoxYard_Leave(object sender, EventArgs e)
        {
            double meter, yard, inch;
            if (Double.TryParse(textBoxYard.Text, out yard))
            {
                inch = yard * 36;
                meter = yard / 1.094;
                textBoxMeter.Text = $"{meter}";
                textBoxMillimeter.Text = $"{meter * 1000}";
                textBoxCentimeter.Text = $"{meter * 100}";
                textBoxKilometer.Text = $"{meter / 1000}";
                textBoxInch.Text = $"{inch}";
                textBoxFoot.Text = $"{inch / 12}";
                textBoxMile.Text = $"{inch / 63360}";
            }
            else
                MessageBox.Show("Please enter a valid input.");
        }

        private void textBoxFoot_Leave(object sender, EventArgs e)
        {
            double meter, foot, inch;
            if (Double.TryParse(textBoxFoot.Text, out foot))
            {
                inch = foot * 12 ;
                meter = foot / 3.281;
                textBoxMeter.Text = $"{meter}";
                textBoxMillimeter.Text = $"{meter * 1000}";
                textBoxCentimeter.Text = $"{meter * 100}";
                textBoxKilometer.Text = $"{meter / 1000}";
                textBoxInch.Text = $"{inch}";
                textBoxYard.Text = $"{inch / 36}";
                textBoxMile.Text = $"{inch / 63360}";
            }
            else
                MessageBox.Show("Please enter a valid input.");
        }

        private void textBoxMile_Leave(object sender, EventArgs e)
        {
            double meter, mile, inch;
            if (Double.TryParse(textBoxMile.Text, out mile))
            {
                inch = mile * 63360;
                meter = mile * 1609;
                textBoxMeter.Text = $"{meter}";
                textBoxMillimeter.Text = $"{meter * 1000}";
                textBoxCentimeter.Text = $"{meter * 100}";
                textBoxKilometer.Text = $"{meter / 1000}";
                textBoxInch.Text = $"{inch}";
                textBoxYard.Text = $"{inch / 36}";
                textBoxFoot.Text = $"{inch / 12}";
            }
            else
                MessageBox.Show("Please enter a valid input.");
        }
    }
}
