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
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBeurt = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTijd = new System.Windows.Forms.Label();
            this.lvSpelers = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.turnEndTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.kaart00 = new System.Windows.Forms.PictureBox();
            this.kaart10 = new System.Windows.Forms.PictureBox();
            this.kaart33 = new System.Windows.Forms.PictureBox();
            this.kaart20 = new System.Windows.Forms.PictureBox();
            this.kaart23 = new System.Windows.Forms.PictureBox();
            this.kaart30 = new System.Windows.Forms.PictureBox();
            this.kaart13 = new System.Windows.Forms.PictureBox();
            this.kaart03 = new System.Windows.Forms.PictureBox();
            this.kaart01 = new System.Windows.Forms.PictureBox();
            this.kaart32 = new System.Windows.Forms.PictureBox();
            this.kaart11 = new System.Windows.Forms.PictureBox();
            this.kaart22 = new System.Windows.Forms.PictureBox();
            this.kaart21 = new System.Windows.Forms.PictureBox();
            this.kaart12 = new System.Windows.Forms.PictureBox();
            this.kaart31 = new System.Windows.Forms.PictureBox();
            this.kaart02 = new System.Windows.Forms.PictureBox();
            this.gameOverPage = new System.Windows.Forms.TabPage();
            this.highScorePage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.hoofdMenuPage.SuspendLayout();
            this.spelPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaart00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart02)).BeginInit();
            this.SuspendLayout();
            // 
            // turnTimer
            // 
            this.turnTimer.Interval = 1000;
            // 
            // lblBeurt
            // 
            this.lblBeurt.AutoSize = true;
            this.lblBeurt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeurt.Location = new System.Drawing.Point(201, 8);
            this.lblBeurt.Name = "lblBeurt";
            this.lblBeurt.Size = new System.Drawing.Size(47, 18);
            this.lblBeurt.TabIndex = 16;
            this.lblBeurt.Text = "Beurt:";
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 250;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // lblTijd
            // 
            this.lblTijd.AutoSize = true;
            this.lblTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijd.Location = new System.Drawing.Point(391, 9);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(75, 18);
            this.lblTijd.TabIndex = 32;
            this.lblTijd.Text = "Tijd: 00:00";
            // 
            // lvSpelers
            // 
            this.lvSpelers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvSpelers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSpelers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colScore});
            this.lvSpelers.FullRowSelect = true;
            this.lvSpelers.Location = new System.Drawing.Point(6, 27);
            this.lvSpelers.Name = "lvSpelers";
            this.lvSpelers.Size = new System.Drawing.Size(185, 371);
            this.lvSpelers.TabIndex = 33;
            this.lvSpelers.UseCompatibleStateImageBehavior = false;
            this.lvSpelers.View = System.Windows.Forms.View.Details;
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
            // turnEndTimer
            // 
            this.turnEndTimer.Interval = 1000;
            this.turnEndTimer.Tick += new System.EventHandler(this.turnEndTimer_tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.hoofdMenuPage);
            this.tabControl1.Controls.Add(this.spelPage);
            this.tabControl1.Controls.Add(this.gameOverPage);
            this.tabControl1.Controls.Add(this.highScorePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 451);
            this.tabControl1.TabIndex = 35;
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
            this.hmBtnPlayerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmBtnPlayerAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hmBtnPlayerAdd.Location = new System.Drawing.Point(485, 344);
            this.hmBtnPlayerAdd.Margin = new System.Windows.Forms.Padding(2);
            this.hmBtnPlayerAdd.Name = "hmBtnPlayerAdd";
            this.hmBtnPlayerAdd.Size = new System.Drawing.Size(91, 32);
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
            this.hmTbPlayername.Location = new System.Drawing.Point(353, 344);
            this.hmTbPlayername.Margin = new System.Windows.Forms.Padding(2);
            this.hmTbPlayername.Multiline = true;
            this.hmTbPlayername.Name = "hmTbPlayername";
            this.hmTbPlayername.Size = new System.Drawing.Size(128, 32);
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
            this.hmLbPlayers.Size = new System.Drawing.Size(223, 216);
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
            this.spelPage.Controls.Add(this.lvSpelers);
            this.spelPage.Controls.Add(this.lblTijd);
            this.spelPage.Controls.Add(this.lblBeurt);
            this.spelPage.Controls.Add(this.kaart00);
            this.spelPage.Controls.Add(this.kaart10);
            this.spelPage.Controls.Add(this.kaart33);
            this.spelPage.Controls.Add(this.kaart20);
            this.spelPage.Controls.Add(this.kaart23);
            this.spelPage.Controls.Add(this.kaart30);
            this.spelPage.Controls.Add(this.kaart13);
            this.spelPage.Controls.Add(this.kaart03);
            this.spelPage.Controls.Add(this.kaart01);
            this.spelPage.Controls.Add(this.kaart32);
            this.spelPage.Controls.Add(this.kaart11);
            this.spelPage.Controls.Add(this.kaart22);
            this.spelPage.Controls.Add(this.kaart21);
            this.spelPage.Controls.Add(this.kaart12);
            this.spelPage.Controls.Add(this.kaart31);
            this.spelPage.Controls.Add(this.kaart02);
            this.spelPage.Location = new System.Drawing.Point(4, 25);
            this.spelPage.Name = "spelPage";
            this.spelPage.Padding = new System.Windows.Forms.Padding(3);
            this.spelPage.Size = new System.Drawing.Size(603, 422);
            this.spelPage.TabIndex = 0;
            this.spelPage.Text = "Spel";
            // 
            // kaart00
            // 
            this.kaart00.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart00.Location = new System.Drawing.Point(202, 29);
            this.kaart00.Margin = new System.Windows.Forms.Padding(2);
            this.kaart00.Name = "kaart00";
            this.kaart00.Size = new System.Drawing.Size(90, 90);
            this.kaart00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart00.TabIndex = 0;
            this.kaart00.TabStop = false;
            this.kaart00.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart10
            // 
            this.kaart10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart10.Location = new System.Drawing.Point(202, 123);
            this.kaart10.Margin = new System.Windows.Forms.Padding(2);
            this.kaart10.Name = "kaart10";
            this.kaart10.Size = new System.Drawing.Size(90, 90);
            this.kaart10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart10.TabIndex = 4;
            this.kaart10.TabStop = false;
            this.kaart10.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart33
            // 
            this.kaart33.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart33.Location = new System.Drawing.Point(486, 310);
            this.kaart33.Margin = new System.Windows.Forms.Padding(2);
            this.kaart33.Name = "kaart33";
            this.kaart33.Size = new System.Drawing.Size(90, 90);
            this.kaart33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart33.TabIndex = 30;
            this.kaart33.TabStop = false;
            this.kaart33.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart20
            // 
            this.kaart20.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart20.Location = new System.Drawing.Point(202, 217);
            this.kaart20.Margin = new System.Windows.Forms.Padding(2);
            this.kaart20.Name = "kaart20";
            this.kaart20.Size = new System.Drawing.Size(90, 90);
            this.kaart20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart20.TabIndex = 8;
            this.kaart20.TabStop = false;
            this.kaart20.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart23
            // 
            this.kaart23.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart23.Location = new System.Drawing.Point(486, 215);
            this.kaart23.Margin = new System.Windows.Forms.Padding(2);
            this.kaart23.Name = "kaart23";
            this.kaart23.Size = new System.Drawing.Size(90, 90);
            this.kaart23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart23.TabIndex = 29;
            this.kaart23.TabStop = false;
            this.kaart23.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart30
            // 
            this.kaart30.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart30.Location = new System.Drawing.Point(202, 310);
            this.kaart30.Margin = new System.Windows.Forms.Padding(2);
            this.kaart30.Name = "kaart30";
            this.kaart30.Size = new System.Drawing.Size(90, 90);
            this.kaart30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart30.TabIndex = 12;
            this.kaart30.TabStop = false;
            this.kaart30.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart13
            // 
            this.kaart13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart13.Location = new System.Drawing.Point(486, 122);
            this.kaart13.Margin = new System.Windows.Forms.Padding(2);
            this.kaart13.Name = "kaart13";
            this.kaart13.Size = new System.Drawing.Size(90, 90);
            this.kaart13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart13.TabIndex = 28;
            this.kaart13.TabStop = false;
            this.kaart13.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart03
            // 
            this.kaart03.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart03.Location = new System.Drawing.Point(486, 29);
            this.kaart03.Margin = new System.Windows.Forms.Padding(2);
            this.kaart03.Name = "kaart03";
            this.kaart03.Size = new System.Drawing.Size(90, 90);
            this.kaart03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart03.TabIndex = 27;
            this.kaart03.TabStop = false;
            this.kaart03.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart01
            // 
            this.kaart01.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart01.Location = new System.Drawing.Point(297, 29);
            this.kaart01.Margin = new System.Windows.Forms.Padding(2);
            this.kaart01.Name = "kaart01";
            this.kaart01.Size = new System.Drawing.Size(90, 90);
            this.kaart01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart01.TabIndex = 19;
            this.kaart01.TabStop = false;
            this.kaart01.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart32
            // 
            this.kaart32.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart32.Location = new System.Drawing.Point(391, 310);
            this.kaart32.Margin = new System.Windows.Forms.Padding(2);
            this.kaart32.Name = "kaart32";
            this.kaart32.Size = new System.Drawing.Size(90, 90);
            this.kaart32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart32.TabIndex = 34;
            this.kaart32.TabStop = false;
            this.kaart32.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart11
            // 
            this.kaart11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart11.Location = new System.Drawing.Point(297, 123);
            this.kaart11.Margin = new System.Windows.Forms.Padding(2);
            this.kaart11.Name = "kaart11";
            this.kaart11.Size = new System.Drawing.Size(90, 90);
            this.kaart11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart11.TabIndex = 20;
            this.kaart11.TabStop = false;
            this.kaart11.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart22
            // 
            this.kaart22.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart22.Location = new System.Drawing.Point(391, 215);
            this.kaart22.Margin = new System.Windows.Forms.Padding(2);
            this.kaart22.Name = "kaart22";
            this.kaart22.Size = new System.Drawing.Size(90, 90);
            this.kaart22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart22.TabIndex = 25;
            this.kaart22.TabStop = false;
            this.kaart22.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart21
            // 
            this.kaart21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart21.Location = new System.Drawing.Point(297, 217);
            this.kaart21.Margin = new System.Windows.Forms.Padding(2);
            this.kaart21.Name = "kaart21";
            this.kaart21.Size = new System.Drawing.Size(90, 90);
            this.kaart21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart21.TabIndex = 21;
            this.kaart21.TabStop = false;
            this.kaart21.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart12
            // 
            this.kaart12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart12.Location = new System.Drawing.Point(391, 122);
            this.kaart12.Margin = new System.Windows.Forms.Padding(2);
            this.kaart12.Name = "kaart12";
            this.kaart12.Size = new System.Drawing.Size(90, 90);
            this.kaart12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart12.TabIndex = 24;
            this.kaart12.TabStop = false;
            this.kaart12.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart31
            // 
            this.kaart31.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart31.Location = new System.Drawing.Point(297, 310);
            this.kaart31.Margin = new System.Windows.Forms.Padding(2);
            this.kaart31.Name = "kaart31";
            this.kaart31.Size = new System.Drawing.Size(90, 90);
            this.kaart31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart31.TabIndex = 22;
            this.kaart31.TabStop = false;
            this.kaart31.Click += new System.EventHandler(this.kaartklikken);
            // 
            // kaart02
            // 
            this.kaart02.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaart02.Location = new System.Drawing.Point(391, 29);
            this.kaart02.Margin = new System.Windows.Forms.Padding(2);
            this.kaart02.Name = "kaart02";
            this.kaart02.Size = new System.Drawing.Size(90, 90);
            this.kaart02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaart02.TabIndex = 23;
            this.kaart02.TabStop = false;
            this.kaart02.Click += new System.EventHandler(this.kaartklikken);
            // 
            // gameOverPage
            // 
            this.gameOverPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameOverPage.Location = new System.Drawing.Point(4, 25);
            this.gameOverPage.Name = "gameOverPage";
            this.gameOverPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameOverPage.Size = new System.Drawing.Size(603, 422);
            this.gameOverPage.TabIndex = 2;
            this.gameOverPage.Text = "Game Over";
            // 
            // highScorePage
            // 
            this.highScorePage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.highScorePage.Location = new System.Drawing.Point(4, 25);
            this.highScorePage.Name = "highScorePage";
            this.highScorePage.Size = new System.Drawing.Size(603, 422);
            this.highScorePage.TabIndex = 3;
            this.highScorePage.Text = "Highscore";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 451);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.hoofdMenuPage.ResumeLayout(false);
            this.hoofdMenuPage.PerformLayout();
            this.spelPage.ResumeLayout(false);
            this.spelPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaart00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart02)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kaart00;
        private System.Windows.Forms.PictureBox kaart10;
        private System.Windows.Forms.PictureBox kaart20;
        private System.Windows.Forms.PictureBox kaart30;
        private System.Windows.Forms.Timer turnTimer;
        private System.Windows.Forms.Label lblBeurt;
        private System.Windows.Forms.PictureBox kaart31;
        private System.Windows.Forms.PictureBox kaart21;
        private System.Windows.Forms.PictureBox kaart11;
        private System.Windows.Forms.PictureBox kaart01;
        private System.Windows.Forms.PictureBox kaart33;
        private System.Windows.Forms.PictureBox kaart23;
        private System.Windows.Forms.PictureBox kaart13;
        private System.Windows.Forms.PictureBox kaart03;
        private System.Windows.Forms.PictureBox kaart32;
        private System.Windows.Forms.PictureBox kaart22;
        private System.Windows.Forms.PictureBox kaart12;
        private System.Windows.Forms.PictureBox kaart02;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label lblTijd;
        private System.Windows.Forms.ListView lvSpelers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;
        private System.Windows.Forms.Timer turnEndTimer;
        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

