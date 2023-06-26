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
        bool gameOver = false;
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
                pipebottom.Left = 820;
                score++;
            }
            if (PipeTop.Left < -80)
            {;
                PipeTop.Left = 820;
                score++;



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
            scoretext.Text += " Game Over !!! Press R to Retry";
           
            gameOver = true;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.Q && gameOver)
            {
                this.Hide();
                MessageBox.Show("Do you want to exit? ");
                Form frm3 = new Main_Menu();
                frm3.Show();
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        

        private void Flappy_Bird_Load(object sender, EventArgs e)
        {

        }

        private void BIRD_Click(object sender, EventArgs e)
        {

        }

        private void PipeTop_Click(object sender, EventArgs e)
        {

        }
        private void RestartGame()
        {
            gameOver = false;

            BIRD.Location = new Point(90, 160);
            PipeTop.Left = 800;
            pipebottom.Left = 1200;

            score = 0;
            pipespeed = 8;
            scoretext.Text = "Score: 0";
            timer1.Start();

        }
    }
}
