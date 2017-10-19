namespace MemoryGameProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kaart00 = new System.Windows.Forms.PictureBox();
            this.kaart10 = new System.Windows.Forms.PictureBox();
            this.kaart20 = new System.Windows.Forms.PictureBox();
            this.kaart30 = new System.Windows.Forms.PictureBox();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBeurt = new System.Windows.Forms.Label();
            this.kaart31 = new System.Windows.Forms.PictureBox();
            this.kaart21 = new System.Windows.Forms.PictureBox();
            this.kaart11 = new System.Windows.Forms.PictureBox();
            this.kaart01 = new System.Windows.Forms.PictureBox();
            this.kaart33 = new System.Windows.Forms.PictureBox();
            this.kaart23 = new System.Windows.Forms.PictureBox();
            this.kaart13 = new System.Windows.Forms.PictureBox();
            this.kaart03 = new System.Windows.Forms.PictureBox();
            this.kaart32 = new System.Windows.Forms.PictureBox();
            this.kaart22 = new System.Windows.Forms.PictureBox();
            this.kaart12 = new System.Windows.Forms.PictureBox();
            this.kaart02 = new System.Windows.Forms.PictureBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTijd = new System.Windows.Forms.Label();
            this.lvSpelers = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.turnEndTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hoofdMenuPage = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.lblMemoryGame = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.spelPage = new System.Windows.Forms.TabPage();
            this.gameOverPage = new System.Windows.Forms.TabPage();
            this.highScorePage = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kaart00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart02)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.hoofdMenuPage.SuspendLayout();
            this.spelPage.SuspendLayout();
            this.SuspendLayout();
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
            this.hoofdMenuPage.Controls.Add(this.button5);
            this.hoofdMenuPage.Controls.Add(this.button4);
            this.hoofdMenuPage.Controls.Add(this.button3);
            this.hoofdMenuPage.Controls.Add(this.button2);
            this.hoofdMenuPage.Controls.Add(this.button1);
            this.hoofdMenuPage.Controls.Add(this.tbUsername);
            this.hoofdMenuPage.Controls.Add(this.lblPlayers);
            this.hoofdMenuPage.Controls.Add(this.lbPlayers);
            this.hoofdMenuPage.Controls.Add(this.lblMemoryGame);
            this.hoofdMenuPage.Controls.Add(this.Play);
            this.hoofdMenuPage.Location = new System.Drawing.Point(4, 25);
            this.hoofdMenuPage.Name = "hoofdMenuPage";
            this.hoofdMenuPage.Padding = new System.Windows.Forms.Padding(3);
            this.hoofdMenuPage.Size = new System.Drawing.Size(603, 422);
            this.hoofdMenuPage.TabIndex = 1;
            this.hoofdMenuPage.Text = "Hoofdmenu";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(204, 312);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 64);
            this.button4.TabIndex = 7;
            this.button4.Text = "Afsluiten";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(24, 312);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 64);
            this.button3.TabIndex = 6;
            this.button3.Text = "Over...";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(24, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Uitleg";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(24, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Highscore Lijst";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(353, 344);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(128, 32);
            this.tbUsername.TabIndex = 4;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayers.Location = new System.Drawing.Point(355, 93);
            this.lblPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(70, 20);
            this.lblPlayers.TabIndex = 18;
            this.lblPlayers.Text = "Spelers";
            // 
            // lbPlayers
            // 
            this.lbPlayers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(353, 116);
            this.lbPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(223, 221);
            this.lbPlayers.TabIndex = 17;
            // 
            // lblMemoryGame
            // 
            this.lblMemoryGame.AutoSize = true;
            this.lblMemoryGame.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoryGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryGame.Location = new System.Drawing.Point(156, 28);
            this.lblMemoryGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemoryGame.Name = "lblMemoryGame";
            this.lblMemoryGame.Size = new System.Drawing.Size(274, 42);
            this.lblMemoryGame.TabIndex = 15;
            this.lblMemoryGame.Text = "Memory Game";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Play.Location = new System.Drawing.Point(24, 108);
            this.Play.Margin = new System.Windows.Forms.Padding(2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(312, 64);
            this.Play.TabIndex = 0;
            this.Play.Text = "Spelen";
            this.Play.UseVisualStyleBackColor = false;
            // 
            // spelPage
            // 
            this.spelPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spelPage.Controls.Add(this.lvSpelers);
            this.spelPage.Controls.Add(this.kaart00);
            this.spelPage.Controls.Add(this.lblTijd);
            this.spelPage.Controls.Add(this.kaart10);
            this.spelPage.Controls.Add(this.kaart33);
            this.spelPage.Controls.Add(this.kaart20);
            this.spelPage.Controls.Add(this.kaart23);
            this.spelPage.Controls.Add(this.kaart30);
            this.spelPage.Controls.Add(this.kaart13);
            this.spelPage.Controls.Add(this.lblBeurt);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(485, 344);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 32);
            this.button5.TabIndex = 19;
            this.button5.Text = "Voeg toe";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 451);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaart00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaart02)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.hoofdMenuPage.ResumeLayout(false);
            this.hoofdMenuPage.PerformLayout();
            this.spelPage.ResumeLayout(false);
            this.spelPage.PerformLayout();
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
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Label lblMemoryGame;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage gameOverPage;
        private System.Windows.Forms.TabPage highScorePage;
        private System.Windows.Forms.Button button5;
    }
}

