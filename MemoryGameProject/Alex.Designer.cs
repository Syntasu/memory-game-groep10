﻿namespace MemoryGameProject
{
    partial class Alex
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
            this.components = new System.ComponentModel.Container();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hoofdMenuPage = new System.Windows.Forms.TabPage();
            this.spelPage = new System.Windows.Forms.TabPage();
            this.highScorePage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnTimer
            // 
            this.turnTimer.Interval = 1000;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hoofdMenuPage);
            this.tabControl1.Controls.Add(this.spelPage);
            this.tabControl1.Controls.Add(this.highScorePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // hoofdMenuPage
            // 
            this.hoofdMenuPage.Location = new System.Drawing.Point(4, 22);
            this.hoofdMenuPage.Name = "hoofdMenuPage";
            this.hoofdMenuPage.Size = new System.Drawing.Size(749, 561);
            this.hoofdMenuPage.TabIndex = 0;
            this.hoofdMenuPage.Text = "Hoofdmenu";
            this.hoofdMenuPage.UseVisualStyleBackColor = true;
            // 
            // spelPage
            // 
            this.spelPage.Location = new System.Drawing.Point(4, 22);
            this.spelPage.Name = "spelPage";
            this.spelPage.Size = new System.Drawing.Size(749, 561);
            this.spelPage.TabIndex = 1;
            this.spelPage.Text = "Spel";
            this.spelPage.UseVisualStyleBackColor = true;
            // 
            // highScorePage
            // 
            this.highScorePage.Location = new System.Drawing.Point(4, 22);
            this.highScorePage.Name = "highScorePage";
            this.highScorePage.Size = new System.Drawing.Size(749, 561);
            this.highScorePage.TabIndex = 2;
            this.highScorePage.Text = "Highscore";
            this.highScorePage.UseVisualStyleBackColor = true;
            // 
            // Alex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "Alex";
            this.Text = "Alex";
            this.Load += new System.EventHandler(this.Alex_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage hoofdMenuPage;
        private System.Windows.Forms.TabPage spelPage;
        private System.Windows.Forms.TabPage highScorePage;
    }
}