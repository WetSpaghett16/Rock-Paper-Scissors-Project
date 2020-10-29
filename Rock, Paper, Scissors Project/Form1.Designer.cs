namespace Rock__Paper__Scissors_Project
{
    partial class frmRPS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgComputer = new System.Windows.Forms.PictureBox();
            this.grpChoices = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnTaunt = new System.Windows.Forms.Button();
            this.lblTaunt = new System.Windows.Forms.Label();
            this.lblRoundsText = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.btnInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputer)).BeginInit();
            this.grpChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(201, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ROCK, PAPER, SCISSORS";
            // 
            // imgPlayer
            // 
            this.imgPlayer.Location = new System.Drawing.Point(31, 110);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(241, 203);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            this.imgPlayer.Visible = false;
            // 
            // imgComputer
            // 
            this.imgComputer.Location = new System.Drawing.Point(533, 110);
            this.imgComputer.Name = "imgComputer";
            this.imgComputer.Size = new System.Drawing.Size(241, 203);
            this.imgComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComputer.TabIndex = 3;
            this.imgComputer.TabStop = false;
            this.imgComputer.Visible = false;
            // 
            // grpChoices
            // 
            this.grpChoices.Controls.Add(this.radScissors);
            this.grpChoices.Controls.Add(this.radPaper);
            this.grpChoices.Controls.Add(this.radRock);
            this.grpChoices.Location = new System.Drawing.Point(337, 329);
            this.grpChoices.Name = "grpChoices";
            this.grpChoices.Size = new System.Drawing.Size(151, 94);
            this.grpChoices.TabIndex = 4;
            this.grpChoices.TabStop = false;
            this.grpChoices.Text = "Player Choice";
            this.grpChoices.Visible = false;
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(7, 66);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 2;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(7, 44);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 1;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.radRock.Location = new System.Drawing.Point(7, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 0;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = false;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(116, 71);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(63, 23);
            this.lblTitle2.TabIndex = 5;
            this.lblTitle2.Text = "USER";
            this.lblTitle2.Visible = false;
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(587, 71);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(123, 23);
            this.lblTitle3.TabIndex = 6;
            this.lblTitle3.Text = "COMPUTER";
            this.lblTitle3.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(316, 71);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(190, 35);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Open Play Menu";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(31, 381);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(44, 407);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(99, 16);
            this.lblReset.TabIndex = 9;
            this.lblReset.Text = "Keep playing....";
            this.lblReset.Visible = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Enabled = false;
            this.btnRoll.Location = new System.Drawing.Point(353, 112);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(116, 23);
            this.btnRoll.TabIndex = 10;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Visible = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(394, 238);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 21);
            this.lblWinner.TabIndex = 11;
            // 
            // btnTaunt
            // 
            this.btnTaunt.Location = new System.Drawing.Point(353, 141);
            this.btnTaunt.Name = "btnTaunt";
            this.btnTaunt.Size = new System.Drawing.Size(116, 23);
            this.btnTaunt.TabIndex = 12;
            this.btnTaunt.Text = "Taunt";
            this.btnTaunt.UseVisualStyleBackColor = true;
            this.btnTaunt.Visible = false;
            this.btnTaunt.Click += new System.EventHandler(this.btnTaunt_Click);
            // 
            // lblTaunt
            // 
            this.lblTaunt.AutoSize = true;
            this.lblTaunt.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaunt.Location = new System.Drawing.Point(546, 339);
            this.lblTaunt.Name = "lblTaunt";
            this.lblTaunt.Size = new System.Drawing.Size(228, 26);
            this.lblTaunt.TabIndex = 13;
            this.lblTaunt.Text = "You can\'t beat me human.";
            this.lblTaunt.Visible = false;
            // 
            // lblRoundsText
            // 
            this.lblRoundsText.AutoSize = true;
            this.lblRoundsText.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsText.Location = new System.Drawing.Point(27, 339);
            this.lblRoundsText.Name = "lblRoundsText";
            this.lblRoundsText.Size = new System.Drawing.Size(116, 22);
            this.lblRoundsText.TabIndex = 14;
            this.lblRoundsText.Text = "Rounds Played:";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.Location = new System.Drawing.Point(149, 339);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(20, 22);
            this.lblRounds.TabIndex = 15;
            this.lblRounds.Text = "0";
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(353, 170);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(116, 23);
            this.btnInstructions.TabIndex = 16;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Visible = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(831, 449);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.lblRoundsText);
            this.Controls.Add(this.lblTaunt);
            this.Controls.Add(this.btnTaunt);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.grpChoices);
            this.Controls.Add(this.imgComputer);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmRPS";
            this.Text = "Rock, Paper, Scissors Project";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputer)).EndInit();
            this.grpChoices.ResumeLayout(false);
            this.grpChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgComputer;
        private System.Windows.Forms.GroupBox grpChoices;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnTaunt;
        private System.Windows.Forms.Label lblTaunt;
        private System.Windows.Forms.Label lblRoundsText;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Button btnInstructions;
    }
}

