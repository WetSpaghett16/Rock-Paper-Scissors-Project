﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissors_Project
{
    public partial class frmRPS : Form
    {
        

        public frmRPS()
        {
            InitializeComponent();
            Random generator = new Random();
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Small_pair_of_blue_scissors;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblTitle2.Visible = true;
            lblTitle3.Visible = true;
            imgComputer.Visible = true;
            imgPlayer.Visible = true;
            grpChoices.Visible = true;
            lblTitle.Visible = false;
            btnPlay.Visible = false;
            btnReset.Visible = true;
            btnStart.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblReset.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
