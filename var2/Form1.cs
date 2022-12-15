using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create a random number generator
            Random rnd = new Random();

            // Loop through each day of the week
            for (int i = 1; i <= 7; i++)
            {
                // Add the day of the week to the list box
                listBox1.Items.Add("Day " + i);
                int sum = 0;
                int max = int.MinValue;
                int min = int.MaxValue;
                // Loop through 10 examples for the current day
                for (int j = 1; j <= 10; j++)
                {
                    // Generate a random temperature between -80 and 80 degrees
                    int temp = rnd.Next(-80, 81);
                    sum+= temp;
                    if(temp > max) max = temp;
                    if (temp < min) min = temp;

                    // Add the temperature to the list box
                    listBox1.Items.Add("Example " + j + ": " + temp + " degrees");
                }
                double avg = (double)sum / 10;
                listBox1.Items.Add("Average temperature: " + avg + " degrees");
                listBox1.Items.Add("Maximum temperature: " + max + " degrees");
                listBox1.Items.Add("Minimum temperature: " + min + " degrees");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
