﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        int move = 0;

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //Write the code to show Loading Animation
            timerSplash.Interval = 20;
            panelMovable.Width += 5;

            move += 5;

            //If the loading is complete then display login form and close this form
            if(move==640)
            {
                //Stop the Timer and Close this Form
                timerSplash.Stop();
                Form1 f = new Form1();
                f.Show();
                Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Load the Timer
            timerSplash.Start();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelBG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
