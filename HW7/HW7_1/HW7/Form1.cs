using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    public partial class HW7_1 : Form
    {
        public HW7_1()
        {
            InitializeComponent();
        }

        private void tipTen_Click(object sender, EventArgs e)
        {
            double sale;
            if (Double.TryParse(textBoxSales.Text, out sale))
            {
                textBoxTip.Text = $"{0.1 * sale}";
                textBoxTotal.Text = $"{sale + double.Parse(textBoxTip.Text)}";
            }
            else
                MessageBox.Show("Please enter a valid sale input.");
        }

        private void tipFifteen_Click(object sender, EventArgs e)
        {
            double sale;
            if (Double.TryParse(textBoxSales.Text, out sale))
            {
                textBoxTip.Text = $"{0.15 * sale}";
                textBoxTotal.Text = $"{sale + double.Parse(textBoxTip.Text)}";
            }
            else
                MessageBox.Show("Please enter a valid sale input.");
        }

        private void tipTwenty_Click(object sender, EventArgs e)
        {
            double sale;
            if (Double.TryParse(textBoxSales.Text, out sale))
            {
                textBoxTip.Text = $"{0.2 * sale}";
                textBoxTotal.Text = $"{sale + double.Parse(textBoxTip.Text)}";
            }
            else
                MessageBox.Show("Please enter a valid sale input.");
        }

        private void tipAny_Click(object sender, EventArgs e)
        {
            double sale, tip;
            if (Double.TryParse(textBoxSales.Text, out sale))
            {
                if (Double.TryParse(textBoxPercent.Text, out tip))
                {
                    textBoxTip.Text = $"{tip/100 * sale}";
                    textBoxTotal.Text = $"{sale + double.Parse(textBoxTip.Text)}";
                } else
                    MessageBox.Show("Please enter a valid tip input.");
            }
            else
                MessageBox.Show("Please enter a valid sale input.");
        }
    }
}
