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
    public partial class Guessing_game : Form
    {
        Random random = new Random();
        int number = 0;
        int guesses = 0;
        Int32 i;

        public Guessing_game()
        {
            InitializeComponent();
            LoadQuestion();
        }
        private void LoadQuestion()
        {
            number = random.Next(1, 100);
        }

        private void btn_exit_gg_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Do you want to Exit?");
            Form frm3 = new Main_Menu();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Enter_number.Text == "")
            {
                MessageBox.Show("Please Enter your Guess Number");
            }
            else
            {
                i = Int32.Parse(txt_Enter_number.Text);
                    guesses += 1;
                lbl_guessed.Text = "You Guessed " + guesses + "times";
            }
            if (guesses == number)
            {
                MessageBox.Show("You got the Right Answer");
                
            }
            else if (guesses < number)
            {
                MessageBox.Show("Go Lower");
            }
            else
            {
                MessageBox.Show("Go Higher");
            }
        }

        private void txt_Enter_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guessing_game_Load(object sender, EventArgs e)
        {

        }
    }
}
