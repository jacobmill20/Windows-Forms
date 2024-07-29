using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form2 : Form
    {
        String name = "Anonymous";
        public Form2()
        {
            InitializeComponent();
            for(int i = 9; i <= 15;i = i +3)
            {
                comboRows.Items.Add(i);
            }

            for (int i = 9; i <= 30;i = i + 3)
            {
                comboCol.Items.Add(i);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1((int)comboRows.SelectedItem, (int)comboCol.SelectedItem, name);
            game.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }
    }
}
