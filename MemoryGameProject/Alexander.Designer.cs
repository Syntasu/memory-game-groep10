namespace MemoryGameProject
{
    partial class Alexander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alexander));
            this.Play = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.Button();
            this.HowToPlay = new System.Windows.Forms.Button();
            this.lblMemoryGame = new System.Windows.Forms.Label();
            this.submitUsername = new System.Windows.Forms.Button();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.About = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(69, 194);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(187, 38);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Leaderboard
            // 
            this.Leaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leaderboard.Location = new System.Drawing.Point(69, 238);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(187, 38);
            this.Leaderboard.TabIndex = 2;
            this.Leaderboard.Text = "Leaderboard\r\n\r\n";
            this.Leaderboard.UseVisualStyleBackColor = true;
            this.Leaderboard.Click += new System.EventHandler(this.Leaderboard_Click);
            // 
            // HowToPlay
            // 
            this.HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlay.Location = new System.Drawing.Point(69, 282);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(187, 38);
            this.HowToPlay.TabIndex = 3;
            this.HowToPlay.Text = "How To Play";
            this.HowToPlay.UseVisualStyleBackColor = true;
            this.HowToPlay.Click += new System.EventHandler(this.HowToPlay_Click);
            // 
            // lblMemoryGame
            // 
            this.lblMemoryGame.AutoSize = true;
            this.lblMemoryGame.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoryGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryGame.Location = new System.Drawing.Point(223, 80);
            this.lblMemoryGame.Name = "lblMemoryGame";
            this.lblMemoryGame.Size = new System.Drawing.Size(294, 46);
            this.lblMemoryGame.TabIndex = 5;
            this.lblMemoryGame.Text = "Memory Game";
            // 
            // submitUsername
            // 
            this.submitUsername.Location = new System.Drawing.Point(588, 295);
            this.submitUsername.Name = "submitUsername";
            this.submitUsername.Size = new System.Drawing.Size(75, 25);
            this.submitUsername.TabIndex = 6;
            this.submitUsername.Text = "Submit";
            this.submitUsername.UseVisualStyleBackColor = true;
            this.submitUsername.Click += new System.EventHandler(this.submitUsername_Click);
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(490, 221);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(173, 68);
            this.lbPlayers.TabIndex = 7;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(491, 194);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(71, 24);
            this.lblPlayers.TabIndex = 8;
            this.lblPlayers.Text = "Players";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(490, 297);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(92, 22);
            this.tbUsername.TabIndex = 9;
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(141, 407);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(139, 72);
            this.About.TabIndex = 10;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(443, 407);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 72);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Alexander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.About);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.submitUsername);
            this.Controls.Add(this.lblMemoryGame);
            this.Controls.Add(this.HowToPlay);
            this.Controls.Add(this.Leaderboard);
            this.Controls.Add(this.Play);
            this.DoubleBuffered = true;
            this.Name = "Alexander";
            this.Text = "Alexander";
            this.Load += new System.EventHandler(this.Alexander_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Leaderboard;
        private System.Windows.Forms.Button HowToPlay;
        private System.Windows.Forms.Label lblMemoryGame;
        private System.Windows.Forms.Button submitUsername;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
    }
}