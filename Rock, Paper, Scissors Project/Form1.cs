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
        int Wins;
        int Losses;
        int Ties;
        
      

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
            //This is start menu code
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
            btnRemove.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Ties = 0;
            lblTies.Text = "0";
            Wins = 0;
            lblWins.Text = "0";
            Losses = 0;
            lblLosses.Text = "0";
            lblTaunt.Visible = false;
            number = 0;
            lblRounds.Text = "0";
            btnReset.Enabled = false;
            radRock.Checked = false;
            radPaper.Checked = false;
            radScissors.Checked = false;
            imgPlayer.Image = Properties.Resources.Colour;
            imgComputer.Image = Properties.Resources.Colour;
            btnRoll.Enabled = false;

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Ties = Ties + 1;
            Wins = Wins + 1;
            Losses = Losses + 1;
            number = number + 1;
            lblRounds.Text = number.ToString();
            btnReset.Enabled = true;

            Computer = generator.Next(1, 4);
            if (Computer == 1)
                imgComputer.Image = Properties.Resources.Rock;

            else if (Computer == 2)
                imgComputer.Image = Properties.Resources.paper;

            else if (Computer == 3)
                imgComputer.Image = Properties.Resources.Small_pair_of_blue_scissors;

            //rock
            if (radRock.Checked == true) 

            if (Computer == 1)
            {
               
               lblTies.Text = Ties.ToString();
            }
            else if (Computer == 2)
            {
                    
                    lblLosses.Text = Losses.ToString();
            }
            else if (Computer == 3)
            {
               
               lblWins.Text = Wins.ToString();
            }

            //paper
            if (radPaper.Checked == true) 

            if (Computer == 1)
            {
               
               lblWins.Text = Ties.ToString();
            }
            else if (Computer == 2)
            {
              
               lblTies.Text = Losses.ToString();
            }
            else if (Computer == 3)
            {
                    
                    lblLosses.Text = Wins.ToString();
            }

            //scissors
            if (radScissors.Checked == true) 

            if (Computer == 1)
            {
                    
                    lblLosses.Text = Ties.ToString();
            }
            else if (Computer == 2)
            {
              
              lblWins.Text = Losses.ToString();
            }
            else if (Computer == 3)
            {
              
              lblTies.Text = Wins.ToString();
            }

        }

        private void btnTaunt_Click(object sender, EventArgs e)
        {
            lblTaunt.Visible = true;
            btnReset.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnTaunt.Enabled = false;
            lblTaunt.Visible = false;
            btnRemove.Visible = false;
        }
    }
}