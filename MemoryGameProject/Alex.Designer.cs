namespace MemoryGameProject
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
            this.hoofdMenuTab = new System.Windows.Forms.TabPage();
            this.spelTab = new System.Windows.Forms.TabPage();
            this.highscoreTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnTimer
            // 
            this.turnTimer.Interval = 1000;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hoofdMenuTab);
            this.tabControl1.Controls.Add(this.spelTab);
            this.tabControl1.Controls.Add(this.highscoreTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // hoofdMenuTab
            // 
            this.hoofdMenuTab.Location = new System.Drawing.Point(4, 22);
            this.hoofdMenuTab.Name = "hoofdMenuTab";
            this.hoofdMenuTab.Size = new System.Drawing.Size(749, 561);
            this.hoofdMenuTab.TabIndex = 0;
            this.hoofdMenuTab.Text = "Hoofdmenu";
            this.hoofdMenuTab.UseVisualStyleBackColor = true;
            // 
            // spelTab
            // 
            this.spelTab.Location = new System.Drawing.Point(4, 22);
            this.spelTab.Name = "spelTab";
            this.spelTab.Size = new System.Drawing.Size(729, 530);
            this.spelTab.TabIndex = 1;
            this.spelTab.Text = "Spel";
            this.spelTab.UseVisualStyleBackColor = true;
            // 
            // highscoreTab
            // 
            this.highscoreTab.Location = new System.Drawing.Point(4, 22);
            this.highscoreTab.Name = "highscoreTab";
            this.highscoreTab.Size = new System.Drawing.Size(729, 530);
            this.highscoreTab.TabIndex = 2;
            this.highscoreTab.Text = "Highscore";
            this.highscoreTab.UseVisualStyleBackColor = true;
            // 
            // Alex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "Alex";
            this.Text = "Alex";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage hoofdMenuTab;
        private System.Windows.Forms.TabPage spelTab;
        private System.Windows.Forms.TabPage highscoreTab;
    }
}