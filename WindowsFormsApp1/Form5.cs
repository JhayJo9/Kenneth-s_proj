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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Do you want to exit?");
            Form frm2 = new Main_Menu();
            frm2.Show();
        }

        private void Andrei(object sender, EventArgs e)
        {
            label_drei.Visible = true;
        }

        private void Kenneth(object sender, EventArgs e)
        {
            label2.Visible = true;
        }
    }
}
