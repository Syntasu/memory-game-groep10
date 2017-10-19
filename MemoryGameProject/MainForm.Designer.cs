namespace MemoryGameProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spelLblTurn = new System.Windows.Forms.Label();
            this.spelTimerUpdate = new System.Windows.Forms.Timer(this.components);
            this.spelLblTime = new System.Windows.Forms.Label();
            this.spelLvSpelers = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spelTimerTurn = new System.Windows.Forms.Timer(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.hoofdMenuPage = new System.Windows.Forms.TabPage();
            this.hmBtnPlayerAdd = new System.Windows.Forms.Button();
            this.hmBtnExit = new System.Windows.Forms.Button();
            this.hmBtnAbout = new System.Windows.Forms.Button();
            this.hmBtnExplanation = new System.Windows.Forms.Button();
            this.hmBtnHighscore = new System.Windows.Forms.Button();
            this.hmTbPlayername = new System.Windows.Forms.TextBox();
            this.hmLblPlayers = new System.Windows.Forms.Label();
            this.hmLbPlayers = new System.Windows.Forms.ListBox();
            this.hmLblTitle = new System.Windows.Forms.Label();
            this.hmBtnPlay = new System.Windows.Forms.Button();
            this.spelPage = new System.Windows.Forms.TabPage();
            this.gameOverPage = new System.Windows.Forms.TabPage();
            this.endLblWinners = new System.Windows.Forms.Label();
            this.highScorePage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.spelPbKaart00 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart10 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart33 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart20 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart23 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart30 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart13 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart03 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart01 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart32 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart11 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart22 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart21 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart12 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart31 = new System.Windows.Forms.PictureBox();
            this.spelPbKaart02 = new System.Windows.Forms.PictureBox();
            this.endPbCrown = new System.Windows.Forms.PictureBox();
            this.endBtnBack = new System.Windows.Forms.Button();
            this.endBtnAgain = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.hoofdMenuPage.SuspendLayout();
            this.spelPage.SuspendLayout();
            this.gameOverPage.SuspendLayout();
            this.highScorePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPbCrown)).BeginInit();
            this.SuspendLayout();
            // 
            // spelLblTurn
            // 
            this.spelLblTurn.AutoSize = true;
            this.spelLblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spelLblTurn.Location = new System.Drawing.Point(201, 8);
            this.spelLblTurn.Name = "spelLblTurn";
            this.spelLblTurn.Size = new System.Drawing.Size(53, 18);
            this.spelLblTurn.TabIndex = 16;
            this.spelLblTurn.Text = "Beurt:";
            // 
            // spelTimerUpdate
            // 
            this.spelTimerUpdate.Interval = 250;
            this.spelTimerUpdate.Tick += new System.EventHandler(this.spelTimerUpdate_Tick);
            // 
            // spelLblTime
            // 
            this.spelLblTime.AutoSize = true;
            this.spelLblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spelLblTime.Location = new System.Drawing.Point(391, 9);
            this.spelLblTime.Name = "spelLblTime";
            this.spelLblTime.Size = new System.Drawing.Size(86, 18);
            this.spelLblTime.TabIndex = 32;
            this.spelLblTime.Text = "Tijd: 00:00";
            // 
            // spelLvSpelers
            // 
            this.spelLvSpelers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelLvSpelers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spelLvSpelers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colScore});
            this.spelLvSpelers.FullRowSelect = true;
            this.spelLvSpelers.Location = new System.Drawing.Point(6, 27);
            this.spelLvSpelers.Name = "spelLvSpelers";
            this.spelLvSpelers.Size = new System.Drawing.Size(185, 371);
            this.spelLvSpelers.TabIndex = 33;
            this.spelLvSpelers.UseCompatibleStateImageBehavior = false;
            this.spelLvSpelers.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Speler";
            this.colName.Width = 100;
            // 
            // colScore
            // 
            this.colScore.Text = "Score";
            this.colScore.Width = 80;
            // 
            // spelTimerTurn
            // 
            this.spelTimerTurn.Interval = 1000;
            this.spelTimerTurn.Tick += new System.EventHandler(this.spelTimerTurn_Tick);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabControl.Controls.Add(this.hoofdMenuPage);
            this.mainTabControl.Controls.Add(this.spelPage);
            this.mainTabControl.Controls.Add(this.gameOverPage);
            this.mainTabControl.Controls.Add(this.highScorePage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(611, 451);
            this.mainTabControl.TabIndex = 35;
            this.mainTabControl.TabStop = false;
            this.mainTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabControl_Selecting);
            // 
            // hoofdMenuPage
            // 
            this.hoofdMenuPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hoofdMenuPage.Controls.Add(this.hmBtnPlayerAdd);
            this.hoofdMenuPage.Controls.Add(this.hmBtnExit);
            this.hoofdMenuPage.Controls.Add(this.hmBtnAbout);
            this.hoofdMenuPage.Controls.Add(this.hmBtnExplanation);
            this.hoofdMenuPage.Controls.Add(this.hmBtnHighscore);
            this.hoofdMenuPage.Controls.Add(this.hmTbPlayername);
            this.hoofdMenuPage.Controls.Add(this.hmLblPlayers);
            this.hoofdMenuPage.Controls.Add(this.hmLbPlayers);
            this.hoofdMenuPage.Controls.Add(this.hmLblTitle);
            this.hoofdMenuPage.Controls.Add(this.hmBtnPlay);
            this.hoofdMenuPage.Location = new System.Drawing.Point(4, 25);
            this.hoofdMenuPage.Name = "hoofdMenuPage";
            this.hoofdMenuPage.Padding = new System.Windows.Forms.Padding(3);
            this.hoofdMenuPage.Size = new System.Drawing.Size(603, 422);
            this.hoofdMenuPage.TabIndex = 1;
            this.hoofdMenuPage.Text = "Hoofdmenu";
            // 
            // hmBtnPlayerAdd
            // 
            this.hmBtnPlayerAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hmBtnPlayerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmBtnPlayerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtnPlayerAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hmBtnPlayerAdd.Location = new System.Drawing.Point(485, 354);
            this.hmBtnPlayerAdd.Margin = new System.Windows.Forms.Padding(2);
            this.hmBtnPlayerAdd.Name = "hmBtnPlayerAdd";
            this.hmBtnPlayerAdd.Size = new System.Drawing.Size(91, 22);
            this.hmBtnPlayerAdd.TabIndex = 19;
            this.hmBtnPlayerAdd.Text = "Voeg toe";
            this.hmBtnPlayerAdd.UseVisualStyleBackColor = false;
            this.hmBtnPlayerAdd.Click += new System.EventHandler(this.hmBtnPlayerAdd_Click);
            // 
            // hmBtnExit
            // 
            this.hmBtnExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hmBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmBtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hmBtnExit.Location = new System.Drawing.Point(204, 312);
            this.hmBtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.hmBtnExit.Name = "hmBtnExit";
            this.hmBtnExit.Size = new System.Drawing.Size(132, 64);
            this.hmBtnExit.TabIndex = 7;
            this.hmBtnExit.Text = "Afsluiten";
            this.hmBtnExit.UseVisualStyleBackColor = false;
            this.hmBtnExit.Click += new System.EventHandler(this.hmBtnExit_Click);
            // 
            // hmBtnAbout
            // 
            this.hmBtnAbout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hmBtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmBtnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtnAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hmBtnAbout.Location = new System.Drawing.Point(24, 312);
            this.hmBtnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.hmBtnAbout.Name = "hmBtnAbout";
            this.hmBtnAbout.Size = new System.Drawing.Size(176, 64);
            this.hmBtnAbout.TabIndex = 6;
            this.hmBtnAbout.Text = "Over...";
            this.hmBtnAbout.UseVisualStyleBackColor = false;
            this.hmBtnAbout.Click += new System.EventHandler(this.hmBtnAbout_Click);
            // 
            // hmBtnExplanation
            // 
            this.hmBtnExplanation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hmBtnExplanation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmBtnExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtnExplanation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hmBtnExplanation.Location = new System.Drawing.Point(24, 244);
            this.hmBtnExplanation.Margin = new System.Windows.Forms.Padding(2);
            this.hmBtnExplanation.Name = "hmBtnExplanation";
            this.hmBtnExplanation.Size = new System.Drawing.Size(312, 64);
            this.hmBtnExplanation.TabIndex = 2;
            this.hmBtnExplanation.Text = "Uitleg";
            this.hmBtnExplanation.UseVisualStyleBackColor = false;
            this.hmBtnExplanation.Click += new System.EventHandler(this.hmBtnExplanation_Click);
            // 
            // hmBtnHighscore
            // 
            this.hmBtnHighscore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hmBtnHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmBtnHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtnHighscore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hmBtnHighscore.Location = new System.Drawing.Point(24, 176);
            this.hmBtnHighscore.Margin = new System.Windows.Forms.Padding(2);
            this.hmBtnHighscore.Name = "hmBtnHighscore";
            this.hmBtnHighscore.Size = new System.Drawing.Size(312, 64);
            this.hmBtnHighscore.TabIndex = 1;
            this.hmBtnHighscore.Text = "Highscore Lijst";
            this.hmBtnHighscore.UseVisualStyleBackColor = false;
            this.hmBtnHighscore.Click += new System.EventHandler(this.hmBtnHighscore_Click);
            // 
            // hmTbPlayername
            // 
            this.hmTbPlayername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hmTbPlayername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hmTbPlayername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmTbPlayername.Location = new System.Drawing.Point(353, 359);
            this.hmTbPlayername.Margin = new System.Windows.Forms.Padding(2);
            this.hmTbPlayername.Name = "hmTbPlayername";
            this.hmTbPlayername.Size = new System.Drawing.Size(128, 17);
            this.hmTbPlayername.TabIndex = 4;
            // 
            // hmLblPlayers
            // 
            this.hmLblPlayers.AutoSize = true;
            this.hmLblPlayers.BackColor = System.Drawing.Color.Transparent;
            this.hmLblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.hmLblPlayers.Location = new System.Drawing.Point(351, 93);
            this.hmLblPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hmLblPlayers.Name = "hmLblPlayers";
            this.hmLblPlayers.Size = new System.Drawing.Size(70, 20);
            this.hmLblPlayers.TabIndex = 18;
            this.hmLblPlayers.Text = "Spelers";
            // 
            // hmLbPlayers
            // 
            this.hmLbPlayers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hmLbPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hmLbPlayers.Enabled = false;
            this.hmLbPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmLbPlayers.FormattingEnabled = true;
            this.hmLbPlayers.ItemHeight = 18;
            this.hmLbPlayers.Location = new System.Drawing.Point(353, 116);
            this.hmLbPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.hmLbPlayers.Name = "hmLbPlayers";
            this.hmLbPlayers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.hmLbPlayers.Size = new System.Drawing.Size(223, 234);
            this.hmLbPlayers.TabIndex = 17;
            // 
            // hmLblTitle
            // 
            this.hmLblTitle.AutoSize = true;
            this.hmLblTitle.BackColor = System.Drawing.Color.Transparent;
            this.hmLblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmLblTitle.Location = new System.Drawing.Point(176, 29);
            this.hmLblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hmLblTitle.Name = "hmLblTitle";
            this.hmLblTitle.Size = new System.Drawing.Size(274, 42);
            this.hmLblTitle.TabIndex = 15;
            this.hmLblTitle.Text = "Memory Game";
            // 
            // hmBtnPlay
            // 
            this.hmBtnPlay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hmBtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmBtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hmBtnPlay.Location = new System.Drawing.Point(24, 108);
            this.hmBtnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.hmBtnPlay.Name = "hmBtnPlay";
            this.hmBtnPlay.Size = new System.Drawing.Size(312, 64);
            this.hmBtnPlay.TabIndex = 0;
            this.hmBtnPlay.Text = "Spelen";
            this.hmBtnPlay.UseVisualStyleBackColor = false;
            this.hmBtnPlay.Click += new System.EventHandler(this.hmBtnPlay_Click);
            // 
            // spelPage
            // 
            this.spelPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spelPage.Controls.Add(this.spelLvSpelers);
            this.spelPage.Controls.Add(this.spelLblTime);
            this.spelPage.Controls.Add(this.spelLblTurn);
            this.spelPage.Controls.Add(this.spelPbKaart00);
            this.spelPage.Controls.Add(this.spelPbKaart10);
            this.spelPage.Controls.Add(this.spelPbKaart33);
            this.spelPage.Controls.Add(this.spelPbKaart20);
            this.spelPage.Controls.Add(this.spelPbKaart23);
            this.spelPage.Controls.Add(this.spelPbKaart30);
            this.spelPage.Controls.Add(this.spelPbKaart13);
            this.spelPage.Controls.Add(this.spelPbKaart03);
            this.spelPage.Controls.Add(this.spelPbKaart01);
            this.spelPage.Controls.Add(this.spelPbKaart32);
            this.spelPage.Controls.Add(this.spelPbKaart11);
            this.spelPage.Controls.Add(this.spelPbKaart22);
            this.spelPage.Controls.Add(this.spelPbKaart21);
            this.spelPage.Controls.Add(this.spelPbKaart12);
            this.spelPage.Controls.Add(this.spelPbKaart31);
            this.spelPage.Controls.Add(this.spelPbKaart02);
            this.spelPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spelPage.Location = new System.Drawing.Point(4, 25);
            this.spelPage.Name = "spelPage";
            this.spelPage.Padding = new System.Windows.Forms.Padding(3);
            this.spelPage.Size = new System.Drawing.Size(603, 422);
            this.spelPage.TabIndex = 0;
            this.spelPage.Text = "Spel";
            // 
            // gameOverPage
            // 
            this.gameOverPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameOverPage.Controls.Add(this.endBtnAgain);
            this.gameOverPage.Controls.Add(this.endBtnBack);
            this.gameOverPage.Controls.Add(this.endLblWinners);
            this.gameOverPage.Controls.Add(this.endPbCrown);
            this.gameOverPage.Location = new System.Drawing.Point(4, 25);
            this.gameOverPage.Name = "gameOverPage";
            this.gameOverPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameOverPage.Size = new System.Drawing.Size(603, 422);
            this.gameOverPage.TabIndex = 2;
            this.gameOverPage.Text = "Game Over";
            // 
            // endLblWinners
            // 
            this.endLblWinners.Dock = System.Windows.Forms.DockStyle.Top;
            this.endLblWinners.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLblWinners.Location = new System.Drawing.Point(3, 146);
            this.endLblWinners.Name = "endLblWinners";
            this.endLblWinners.Size = new System.Drawing.Size(597, 183);
            this.endLblWinners.TabIndex = 0;
            this.endLblWinners.Text = "Speler1";
            this.endLblWinners.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highScorePage
            // 
            this.highScorePage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.highScorePage.Controls.Add(this.label1);
            this.highScorePage.Location = new System.Drawing.Point(4, 25);
            this.highScorePage.Name = "highScorePage";
            this.highScorePage.Size = new System.Drawing.Size(603, 422);
            this.highScorePage.TabIndex = 3;
            this.highScorePage.Text = "Highscore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "HIGH_SCORE";
            // 
            // spelPbKaart00
            // 
            this.spelPbKaart00.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart00.Location = new System.Drawing.Point(202, 29);
            this.spelPbKaart00.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart00.Name = "spelPbKaart00";
            this.spelPbKaart00.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart00.TabIndex = 0;
            this.spelPbKaart00.TabStop = false;
            this.spelPbKaart00.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart10
            // 
            this.spelPbKaart10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart10.Location = new System.Drawing.Point(202, 123);
            this.spelPbKaart10.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart10.Name = "spelPbKaart10";
            this.spelPbKaart10.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart10.TabIndex = 4;
            this.spelPbKaart10.TabStop = false;
            this.spelPbKaart10.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart33
            // 
            this.spelPbKaart33.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart33.Location = new System.Drawing.Point(486, 310);
            this.spelPbKaart33.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart33.Name = "spelPbKaart33";
            this.spelPbKaart33.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart33.TabIndex = 30;
            this.spelPbKaart33.TabStop = false;
            this.spelPbKaart33.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart20
            // 
            this.spelPbKaart20.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart20.Location = new System.Drawing.Point(202, 217);
            this.spelPbKaart20.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart20.Name = "spelPbKaart20";
            this.spelPbKaart20.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart20.TabIndex = 8;
            this.spelPbKaart20.TabStop = false;
            this.spelPbKaart20.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart23
            // 
            this.spelPbKaart23.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart23.Location = new System.Drawing.Point(486, 215);
            this.spelPbKaart23.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart23.Name = "spelPbKaart23";
            this.spelPbKaart23.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart23.TabIndex = 29;
            this.spelPbKaart23.TabStop = false;
            this.spelPbKaart23.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart30
            // 
            this.spelPbKaart30.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart30.Location = new System.Drawing.Point(202, 310);
            this.spelPbKaart30.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart30.Name = "spelPbKaart30";
            this.spelPbKaart30.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart30.TabIndex = 12;
            this.spelPbKaart30.TabStop = false;
            this.spelPbKaart30.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart13
            // 
            this.spelPbKaart13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart13.Location = new System.Drawing.Point(486, 122);
            this.spelPbKaart13.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart13.Name = "spelPbKaart13";
            this.spelPbKaart13.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart13.TabIndex = 28;
            this.spelPbKaart13.TabStop = false;
            this.spelPbKaart13.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart03
            // 
            this.spelPbKaart03.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart03.Location = new System.Drawing.Point(486, 29);
            this.spelPbKaart03.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart03.Name = "spelPbKaart03";
            this.spelPbKaart03.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart03.TabIndex = 27;
            this.spelPbKaart03.TabStop = false;
            this.spelPbKaart03.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart01
            // 
            this.spelPbKaart01.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart01.Location = new System.Drawing.Point(297, 29);
            this.spelPbKaart01.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart01.Name = "spelPbKaart01";
            this.spelPbKaart01.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart01.TabIndex = 19;
            this.spelPbKaart01.TabStop = false;
            this.spelPbKaart01.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart32
            // 
            this.spelPbKaart32.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart32.Location = new System.Drawing.Point(391, 310);
            this.spelPbKaart32.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart32.Name = "spelPbKaart32";
            this.spelPbKaart32.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart32.TabIndex = 34;
            this.spelPbKaart32.TabStop = false;
            this.spelPbKaart32.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart11
            // 
            this.spelPbKaart11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart11.Location = new System.Drawing.Point(297, 123);
            this.spelPbKaart11.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart11.Name = "spelPbKaart11";
            this.spelPbKaart11.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart11.TabIndex = 20;
            this.spelPbKaart11.TabStop = false;
            this.spelPbKaart11.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart22
            // 
            this.spelPbKaart22.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart22.Location = new System.Drawing.Point(391, 215);
            this.spelPbKaart22.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart22.Name = "spelPbKaart22";
            this.spelPbKaart22.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart22.TabIndex = 25;
            this.spelPbKaart22.TabStop = false;
            this.spelPbKaart22.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart21
            // 
            this.spelPbKaart21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart21.Location = new System.Drawing.Point(297, 217);
            this.spelPbKaart21.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart21.Name = "spelPbKaart21";
            this.spelPbKaart21.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart21.TabIndex = 21;
            this.spelPbKaart21.TabStop = false;
            this.spelPbKaart21.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart12
            // 
            this.spelPbKaart12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart12.Location = new System.Drawing.Point(391, 122);
            this.spelPbKaart12.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart12.Name = "spelPbKaart12";
            this.spelPbKaart12.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart12.TabIndex = 24;
            this.spelPbKaart12.TabStop = false;
            this.spelPbKaart12.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart31
            // 
            this.spelPbKaart31.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart31.Location = new System.Drawing.Point(297, 310);
            this.spelPbKaart31.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart31.Name = "spelPbKaart31";
            this.spelPbKaart31.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart31.TabIndex = 22;
            this.spelPbKaart31.TabStop = false;
            this.spelPbKaart31.Click += new System.EventHandler(this.spelPbClick);
            // 
            // spelPbKaart02
            // 
            this.spelPbKaart02.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spelPbKaart02.Location = new System.Drawing.Point(391, 29);
            this.spelPbKaart02.Margin = new System.Windows.Forms.Padding(2);
            this.spelPbKaart02.Name = "spelPbKaart02";
            this.spelPbKaart02.Size = new System.Drawing.Size(90, 90);
            this.spelPbKaart02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spelPbKaart02.TabIndex = 23;
            this.spelPbKaart02.TabStop = false;
            this.spelPbKaart02.Click += new System.EventHandler(this.spelPbClick);
            // 
            // endPbCrown
            // 
            this.endPbCrown.BackColor = System.Drawing.Color.Transparent;
            this.endPbCrown.Dock = System.Windows.Forms.DockStyle.Top;
            this.endPbCrown.Image = global::MemoryGameProject.Properties.Resources.crown;
            this.endPbCrown.InitialImage = null;
            this.endPbCrown.Location = new System.Drawing.Point(3, 3);
            this.endPbCrown.Name = "endPbCrown";
            this.endPbCrown.Size = new System.Drawing.Size(597, 143);
            this.endPbCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.endPbCrown.TabIndex = 1;
            this.endPbCrown.TabStop = false;
            // 
            // endBtnBack
            // 
            this.endBtnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.endBtnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.endBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBtnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endBtnBack.Location = new System.Drawing.Point(3, 329);
            this.endBtnBack.Name = "endBtnBack";
            this.endBtnBack.Size = new System.Drawing.Size(597, 48);
            this.endBtnBack.TabIndex = 2;
            this.endBtnBack.Text = "Naar het hoofdmenu";
            this.endBtnBack.UseVisualStyleBackColor = false;
            this.endBtnBack.Click += new System.EventHandler(this.endBtnBack_Click);
            // 
            // endBtnAgain
            // 
            this.endBtnAgain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.endBtnAgain.Dock = System.Windows.Forms.DockStyle.Top;
            this.endBtnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBtnAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBtnAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endBtnAgain.Location = new System.Drawing.Point(3, 377);
            this.endBtnAgain.Name = "endBtnAgain";
            this.endBtnAgain.Size = new System.Drawing.Size(597, 43);
            this.endBtnAgain.TabIndex = 3;
            this.endBtnAgain.Text = "Nog een keer spelen!";
            this.endBtnAgain.UseVisualStyleBackColor = false;
            this.endBtnAgain.Click += new System.EventHandler(this.endBtnAgain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 451);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.hoofdMenuPage.ResumeLayout(false);
            this.hoofdMenuPage.PerformLayout();
            this.spelPage.ResumeLayout(false);
            this.spelPage.PerformLayout();
            this.gameOverPage.ResumeLayout(false);
            this.highScorePage.ResumeLayout(false);
            this.highScorePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPbKaart02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPbCrown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox spelPbKaart00;
        private System.Windows.Forms.PictureBox spelPbKaart10;
        private System.Windows.Forms.PictureBox spelPbKaart20;
        private System.Windows.Forms.PictureBox spelPbKaart30;
        private System.Windows.Forms.Label spelLblTurn;
        private System.Windows.Forms.PictureBox spelPbKaart31;
        private System.Windows.Forms.PictureBox spelPbKaart21;
        private System.Windows.Forms.PictureBox spelPbKaart11;
        private System.Windows.Forms.PictureBox spelPbKaart01;
        private System.Windows.Forms.PictureBox spelPbKaart33;
        private System.Windows.Forms.PictureBox spelPbKaart23;
        private System.Windows.Forms.PictureBox spelPbKaart13;
        private System.Windows.Forms.PictureBox spelPbKaart03;
        private System.Windows.Forms.PictureBox spelPbKaart32;
        private System.Windows.Forms.PictureBox spelPbKaart22;
        private System.Windows.Forms.PictureBox spelPbKaart12;
        private System.Windows.Forms.PictureBox spelPbKaart02;
        private System.Windows.Forms.Timer spelTimerUpdate;
        private System.Windows.Forms.Label spelLblTime;
        private System.Windows.Forms.ListView spelLvSpelers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;
        private System.Windows.Forms.Timer spelTimerTurn;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage spelPage;
        private System.Windows.Forms.TabPage hoofdMenuPage;
        private System.Windows.Forms.TextBox hmTbPlayername;
        private System.Windows.Forms.Label hmLblPlayers;
        private System.Windows.Forms.ListBox hmLbPlayers;
        private System.Windows.Forms.Label hmLblTitle;
        private System.Windows.Forms.Button hmBtnPlay;
        private System.Windows.Forms.Button hmBtnExit;
        private System.Windows.Forms.Button hmBtnAbout;
        private System.Windows.Forms.Button hmBtnExplanation;
        private System.Windows.Forms.Button hmBtnHighscore;
        private System.Windows.Forms.TabPage gameOverPage;
        private System.Windows.Forms.TabPage highScorePage;
        private System.Windows.Forms.Button hmBtnPlayerAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label endLblWinners;
        private System.Windows.Forms.PictureBox endPbCrown;
        private System.Windows.Forms.Button endBtnAgain;
        private System.Windows.Forms.Button endBtnBack;
    }
}

