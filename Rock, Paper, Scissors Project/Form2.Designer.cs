namespace Rock__Paper__Scissors_Project
{
    partial class frmInstructions
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
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRule4 = new System.Windows.Forms.Label();
            this.lblRule5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule1.Location = new System.Drawing.Point(82, 9);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(404, 22);
            this.lblRule1.TabIndex = 0;
            this.lblRule1.Text = "YOU CANNOT ROLL UNTIL YOU PICK YOUR TURN";
            // 
            // lblRule3
            // 
            this.lblRule3.AutoSize = true;
            this.lblRule3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule3.Location = new System.Drawing.Point(216, 77);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(181, 20);
            this.lblRule3.TabIndex = 1;
            this.lblRule3.Text = "ROCK BEATS SCISSORS";
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule2.Location = new System.Drawing.Point(63, 37);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(476, 26);
            this.lblRule2.TabIndex = 2;
            this.lblRule2.Text = "YOU MAY RESET ROUNDS PLAYED AT ANY TIME";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(240, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 53);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRule4
            // 
            this.lblRule4.AutoSize = true;
            this.lblRule4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule4.Location = new System.Drawing.Point(216, 97);
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.Size = new System.Drawing.Size(184, 20);
            this.lblRule4.TabIndex = 4;
            this.lblRule4.Text = "SCISSORS BEATS PAPER";
            // 
            // lblRule5
            // 
            this.lblRule5.AutoSize = true;
            this.lblRule5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule5.Location = new System.Drawing.Point(216, 117);
            this.lblRule5.Name = "lblRule5";
            this.lblRule5.Size = new System.Drawing.Size(154, 20);
            this.lblRule5.TabIndex = 5;
            this.lblRule5.Text = "PAPER BEATS ROCK";
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(612, 317);
            this.Controls.Add(this.lblRule5);
            this.Controls.Add(this.lblRule4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRule2);
            this.Controls.Add(this.lblRule3);
            this.Controls.Add(this.lblRule1);
            this.Name = "frmInstructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRule4;
        private System.Windows.Forms.Label lblRule5;
    }
}