using BloodBankManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display the Login Form
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Display the Login Form
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();

            //Display the Login Form
            frmLogin login = new frmLogin();
            login.Show();

            //frmHome f = new frmHome(); 
            //f.Show();
            //Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
