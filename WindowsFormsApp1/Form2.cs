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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Bricks_breaker_Click(object sender, EventArgs e)
        {

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
    }
}
