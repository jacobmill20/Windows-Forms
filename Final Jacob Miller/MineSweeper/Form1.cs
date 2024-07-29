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
    public partial class Form1 : Form
    {
        MineBoard mBoard;

        public int time = 0;
        private int rows, cols;
        public Form1(int row, int col, String name)
        {
            InitializeComponent();
            this.Text = "Welcome " + name;
            rows = row;
            cols = col;
            this.Width = 17 + col * 30;
            this.Height = 67 + row * 31;

        }
        private void b1_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int r, c;
            int x, y;
            (r, c) = ((int, int))btn.Tag;

            timer1.Enabled = true;
            // For now, click opens blindly.
            // Use mBoard.mark(r,c) for marking or unmarking
            if (checkMark.Checked)
            {
                mBoard.mark(r, c);
                txtMines.Text = "" + mBoard.NumMines;
                if(mBoard.NumMines == 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Congradulations! You Win!");
                    this.Close();
                }
            }
            else
            {
                if (mBoard.getValue(r, c) == 9)
                {
                    timer1.Enabled = false;
                    foreach(var b in buttons)
                    {
                        (x, y) = ((int, int))b.Tag;
                        if (mBoard.getValue(x, y) == 9)
                        {
                            b.BackColor = Color.Red;
                        }
                    }
                    MessageBox.Show("Hit a mine. Game Over.");
                    this.Close();
                }
                else
                {
                    mBoard.open(r, c);
                }
            }
            refreshButtons();
        }
        void refreshButtons()
        {
            int r, c;
            foreach(var b in buttons)
            {
                (r, c) = ((int, int))b.Tag;
                b.Text = mBoard.get(r, c);
                if (b.Text == "0")
                {
                    b.Text = "";
                    b.Enabled = false;
                }
            }
        }

        List<Button> buttons = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {
            mBoard = new MineBoard(rows, cols);
            Button b1;
            int btnSize = 30, topMargin = 40;
            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < cols; c++)
                {
                    b1 = new Button();
                    b1.Width = btnSize;
                    b1.Height = btnSize;
                    b1.Left = btnSize * c;
                    b1.Top = btnSize * r + topMargin;
                    b1.Text = mBoard.get(r,c);
                    b1.Tag = (r,c);
                    b1.Font = new Font("Arial", 12);
                    b1.Click += new System.EventHandler(b1_Click);
                    buttons.Add(b1);
                    Controls.Add(b1);

                }
            }
            txtMines.Text = "" + mBoard.NumMines;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            txtTime.Text = "" + time;
        }
    }
}
