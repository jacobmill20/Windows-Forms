using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_9
{
    public partial class Form1 : Form
    {
        public static List<String> id = new List<String>();
        public static List<String> firstNames = new List<String>();
        public static List<String> lastNames = new List<String>();
        public static List<String> hobbies = new List<String>();

        public Form1()
        {
            InitializeComponent();

            label1.Text = "Student ID:";
            label3.Text = "First Name:";
            label4.Text = "Last Name:";
            label2.Text = "Hobby:";

            string[] lines = System.IO.File.ReadAllLines("class.csv");
            foreach (var line in lines.Skip(1))
            {
                string[] words = line.Split(',');

                Form1.id.Add(words[0]);
                Form1.firstNames.Add(words[1]);
                Form1.lastNames.Add(words[2]);
                Form1.hobbies.Add(words[3]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var ids in id)
                idBox.Items.Add(ids);
        }

        private void idBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = firstNames[idBox.SelectedIndex];
            textBox2.Text = lastNames[idBox.SelectedIndex];
            textBox3.Text = hobbies[idBox.SelectedIndex];

            try
            {
                pictureBox1.Image = Image.FromFile("images/" + idBox.SelectedItem + ".jpg");
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        //in the event of text change, save in memory
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstNames[idBox.SelectedIndex] = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lastNames[idBox.SelectedIndex] = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            hobbies[idBox.SelectedIndex] = textBox3.Text;
        }

        //Save to file on button click
        private void saveButton_Click(object sender, EventArgs e)
        {
            List<String> save = new List<string>();
            save.Add("Student ID,Last Name,First Name,Hobby");

            int idx = 0;
            foreach (var ids in id)
            {
                save.Add($"{ids},{firstNames[idx]},{lastNames[idx]},{hobbies[idx]}");
                idx++;
            }

            System.IO.File.WriteAllText("class.csv", String.Join("\n", save));
        }
    }
}
