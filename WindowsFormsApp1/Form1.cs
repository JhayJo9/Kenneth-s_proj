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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "ITEC21" && txt_pass.Text == "12345")
            {
                this.Hide();
                MessageBox.Show("Welcome to ITEC21");
                Form frm1 = new Main_Menu();
                frm1.Show();
            }
            else if (txt_pass.Text == "12345")
            {
                MessageBox.Show("Please Enter your User ID");
            }
            else if (txt_user.Text == "ITEC21")
            {
                MessageBox.Show("Please Enter your Password");
            }
            else if (txt_user.Text == "" && txt_pass.Text == "")
            {
                MessageBox.Show("Please Fill up your Information");
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit? ");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
