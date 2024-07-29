using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_8
{
    public partial class Form1 : Form
    {
        private int opp = 0;
        private int v1;
        private int v2;
        private int answer; //question answer
        private int gender = 0;
        private int qs = 3; //# of question
        private int qidx = 1; //question index (which question the player is on)
        private int correctQs = 0; //# of correct qs
        private bool timer = false;
        int time = 5;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
            answerBox.Enabled = false;
        }
        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = 2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            submitButton.Enabled = true;
            answerBox.Enabled = true;
            startButton.Text = "Next";
            answerBox.Focus();

            if (additionButton.Checked)
            {
               opp = 0;
            }   
            else if (subtractionButton.Checked)
            {
                opp = 1;
            }
            else if (multiplicationButton.Checked)
            {
                opp = 2;
            }
            else if (divisionButton.Checked)
            {
                opp = 3;
            }

            if (qidx <= qs)
            {
                genQ();
            } else
            {
                displayBox.Text = $"Your score is {correctQs}/{qs}";
                submitButton.Enabled = false;
                answerBox.Enabled = false;
                startButton.Text = "Start";
                qidx = 1;
                correctQs = 0;
            }
        }

        private void genQ()
        {
            submitButton.Enabled = true;

            if (checkBox1.Checked)
            {
                timer1.Enabled = true;
                timerTextBox.Text = $"{time}";
            }

            v1 = rand.Next(1, 100);
            v2 = rand.Next(1, 100);

            switch (opp)
            {
                case 0:
                    displayBox.Text = $"{v1} + {v2} ?";
                    answer = v1 + v2;
                    break;
                case 1:
                    displayBox.Text = $"{v1} - {v2} ?";
                    answer = v1 - v2;
                    break;
                case 2:
                    displayBox.Text = $"{v1} * {v2} ?";
                    answer = v1 * v2;
                    break;
                case 3:
                    displayBox.Text = $"{v1} / {v2} ?";
                    answer = v1 / v2;
                    break;
            }

            startButton.Enabled = false;

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
                time = 5;
            }

            if (Int32.Parse(answerBox.Text) == answer)
            {
                correctQs++;
                switch (gender)
                {
                    case 1:
                        displayBox.Text = $"Good Job Sir,{Environment.NewLine}You got {correctQs} correct out of {qidx} problems.";
                        break;

                    case 2:
                        displayBox.Text = $"Good Job Madam,{Environment.NewLine}You got {correctQs} correct out of {qidx} problems.";
                        break;

                    default:
                        displayBox.Text = $"Good Job Unknown Gender,{Environment.NewLine}You got {correctQs} correct out of {qidx} problems.";
                        break;
                }
            }
            else
            {
                switch (opp)
                {
                    case 0:
                        displayBox.Text = $"{v1} + {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                    case 1:
                        displayBox.Text = $"{v1} - {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                    case 2:
                        displayBox.Text = $"{v1} * {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                    case 3:
                        displayBox.Text = $"{v1} / {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                }
            }

            submitButton.Enabled = false;
            startButton.Enabled = true;
            startButton.Focus();
            qidx++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --time;
            timerTextBox.Text = $"{time}";
            if(time == 0)
            {
                timer1.Enabled = false;
                time = 5;
                MessageBox.Show("Time Out. Enter your answer withing 5 seconds.");

                switch (opp)
                {
                    case 0:
                        displayBox.Text = $"{v1} + {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                    case 1:
                        displayBox.Text = $"{v1} - {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                    case 2:
                        displayBox.Text = $"{v1} * {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                    case 3:
                        displayBox.Text = $"{v1} / {v2} ?{Environment.NewLine}The answer is {answer}";
                        break;
                }

                submitButton.Enabled = false;
                startButton.Enabled = true;
                startButton.Focus();
                qidx++;
            }
        }
    }
}
