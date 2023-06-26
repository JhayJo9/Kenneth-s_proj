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
    public partial class Form4 : Form
    {
        char who = 'O';
        short movement = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'O';
            movement = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.White;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.White;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.White;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.White;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.White;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.White;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.White;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is tic tac toe and the author of this game is Ken and Drei");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.Orange;
            if (who == 'O')
            {
                bt.Text = "O";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "" ||
                    b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "" ||
                     b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "" ||
                      b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "" ||
                       b2.Text == b5.Text && b5.Text == b8.Text && b8.Text != "" ||
                        b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "" ||
                          b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "" ||
                            b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"The winner is {who.ToString().ToUpper()} !!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw !!!");
                }
                who = 'X';


            }
            else if (who == 'X')
            {
                bt.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "" ||
                    b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "" ||
                     b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "" ||
                      b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "" ||
                       b2.Text == b5.Text && b5.Text == b8.Text && b8.Text != "" ||
                        b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "" ||
                          b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "" ||
                            b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"The winner is {who.ToString().ToUpper()} !!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                who = 'O';

            }
            movement++;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Do you want to exit?");
            Form frm2 = new Main_Menu();
            frm2.Show();
        }
    }
}
