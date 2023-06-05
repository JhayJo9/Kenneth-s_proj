using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Guessing_Game : Form
    {
        Random Random = new Random();
        int number = 0;
        int guess = 0;
        int i;
        public Guessing_Game()
        {
            InitializeComponent();
            loadQuestion();
        }
        private void loadQuestion()
        {
            number = Random.Next(1, 100);
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please your guess number");
            }
            else
            {
                i = int.Parse(textBox1.Text);
                guess += 1;
                lblguessed.Text = "You guessed " + guess + " times";
            }

            if(i == number)
            {
                MessageBox.Show("You got it right");
            }
            else if(i < number) 
            {
                MessageBox.Show("Go higher");
            }
            else
            {
                MessageBox.Show("Go lower");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Do you want to exit?");
            Form frm2 = new Main_Menu();
            frm2.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
