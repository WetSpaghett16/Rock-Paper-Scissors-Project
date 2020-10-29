using System;
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
        Random generator = new Random();
        int Computer;
        int number;

        public frmRPS()
        {
            InitializeComponent();
            
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock;
            btnRoll.Enabled = true;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
            btnRoll.Enabled = true;
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Small_pair_of_blue_scissors;
            btnRoll.Enabled = true;
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
            btnRoll.Visible = true;
            btnTaunt.Visible = true;
            btnInstructions.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblReset.Visible = true;
            lblTaunt.Visible = false;
            number = 0;
            lblRounds.Text = "0";
            btnReset.Enabled = false;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            lblReset.Visible = false;

            Computer = generator.Next(1, 4);
            if (Computer == 1)
                imgComputer.Image = Properties.Resources.Rock;

            else if (Computer == 2)
                imgComputer.Image = Properties.Resources.paper;

            else if (Computer == 3)
                imgComputer.Image = Properties.Resources.Small_pair_of_blue_scissors;

            btnReset.Enabled = true;

            number = number + 1;
            lblRounds.Text = number.ToString();
        }

        private void btnTaunt_Click(object sender, EventArgs e)
        {
            lblTaunt.Visible = true;
            btnReset.Enabled = true;
        


        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            
        }
    }
}