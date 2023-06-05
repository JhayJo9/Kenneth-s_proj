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
    public partial class Flappy_Bird : Form
    {
        int pipespeed = 8;
        int gravity = 15;
        int score = 0;
        public Flappy_Bird()
        {
            InitializeComponent();
        }

       

        private void gametimerevent(object sender, EventArgs e)
        {
            BIRD.Top += gravity;
            pipebottom.Left -= pipespeed;
            PipeTop.Left-= pipespeed;
            scoretext.Text = "Score: " + score;
            if(pipebottom.Left < -150)
            {
                pipebottom.Left = 818;
                score++;
            }
            if (pipebottom.Left < -80)
            {
                PipeTop.Left = 818;


            }
            if(BIRD.Bounds.IntersectsWith(pipebottom.Bounds) 
                || BIRD.Bounds.IntersectsWith(PipeTop.Bounds)
                || BIRD.Bounds.IntersectsWith(ground.Bounds) 
               )
            {
                endgame();
            }
            if(score > 5)
            {
                pipespeed = 15;
            }
            if(BIRD.Top < -25)
            {
                endgame();
            }

        }
        private void endgame()
        {
            timer1.Stop();
            scoretext.Text += " Game Over !!!";
            btn_exit.Show();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
           
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Do you want to exit? ");
            Form frm3 = new Main_Menu();
            frm3.Show();
        }

        private void Flappy_Bird_Load(object sender, EventArgs e)
        {

        }
    }
}
