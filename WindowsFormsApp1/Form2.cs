using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Bricks_breaker_Click(object sender, EventArgs e)
        {
            Form m = new Form4();
            m.ShowDialog();


        }

        private void Guessing_game_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to Guessing Game!");
            Form frm3 = new Guessing_Game();
            frm3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to Exit?");
            Application.Exit();
        }

        private void Flappy_bird_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to flappy bird !!");
            Form frm2 = new Flappy_Bird();
            frm2.Show();
        }

        private void timer(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                label1.Visible = true;
                Guessing_game.Visible= true;
                Tictactoe.Visible= true;
                Flappy_bird.Visible= true;
                button6.Visible= true;
                button7.Visible= true;
                label2.Visible = false;
                progressBar1.Visible = false;
            }
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            Guessing_game.Visible = false;
            label1.Visible = false;
            Tictactoe.Visible = false;
            Flappy_bird.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            label2.Visible = true;
            progressBar1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm5 = new Form5();
            frm5.Show();
        }
    }
}
