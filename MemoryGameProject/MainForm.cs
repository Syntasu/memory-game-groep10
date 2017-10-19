using System;
using System.Windows.Forms;
using MemoryGameProject.Code.Pages;

namespace MemoryGameProject
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private HoofdMenuPage hoofdmenuPage;
        private SpelPage gamePage;

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox[,] playingField = new PictureBox[4, 4];
            playingField[0, 0] = spelPbKaart00;
            playingField[1, 0] = spelPbKaart10;
            playingField[2, 0] = spelPbKaart20;
            playingField[3, 0] = spelPbKaart30;
            playingField[0, 1] = spelPbKaart01;
            playingField[1, 1] = spelPbKaart11;
            playingField[2, 1] = spelPbKaart21;
            playingField[3, 1] = spelPbKaart31;
            playingField[0, 2] = spelPbKaart02;
            playingField[1, 2] = spelPbKaart12;
            playingField[2, 2] = spelPbKaart22;
            playingField[3, 2] = spelPbKaart32;
            playingField[0, 3] = spelPbKaart03;
            playingField[1, 3] = spelPbKaart13;
            playingField[2, 3] = spelPbKaart23;
            playingField[3, 3] = spelPbKaart33;

            hoofdmenuPage = new HoofdMenuPage();

            gamePage = new SpelPage(
                playingField, spelTimerTurn, 
                spelTimerUpdate,spelLvSpelers, 
                spelLblTurn, spelLblTime
            );
        }

        #region Hoofdmenu
        private void hmBtnPlayerAdd_Click(object sender, EventArgs e)
        {
            string playerName = hmTbPlayername.Text;
            bool success = hoofdmenuPage.AddPlayer(playerName);

            if(success)
            {
                hmLbPlayers.Items.Add(playerName);
            }

            hmTbPlayername.Clear();
        }

        private void hmBtnPlay_Click(object sender, EventArgs e)
        {
            if (hoofdmenuPage.CanBegin())
            {
                string[] players = hoofdmenuPage.GetPlayerNames();
                gamePage.BeginGame(players);
            }
        }

        private void hmBtnHighscore_Click(object sender, EventArgs e)
        {
            //pageControl.MoveTo(...);
        }

        private void hmBtnExplanation_Click(object sender, EventArgs e)
        {
            string title = "Uitleg";
            string message = "Speel het spel met 2 tot 4 spelers. Ben je met een grotere groep, maak dan teams." + "\n" + "\n" + "Probeer zoveel mogelijk twee dezelfde kaartjes om te draaien. Als je aan de beurt bent, draai je een kaartje naar keuze om en daarna draai je een tweede kaartje om." + "\n" + "\n" + "Als de kaartjes gelijk zijn, dan mag je nog een keer tot je twee kaartjes hebt omgedraaid die geen paar vormen." + "\n" + "\n" + "Als je twee kaartjes omdraait die niet gelijk zijn, draaien de kaartjes weer om en de volgende speler is aan de beurt. Ga zo door tot alle kaartjes op zijn. De speler met de meeste kaartjes wint." + "\n" + "\n";
            MessageBox.Show(message, title);
        }

        private void hmBtnAbout_Click(object sender, EventArgs e)
        {
            string title = "Over...";
            string message = "Gemaakt door groep 10 (Valeria, Alexander en Alex)!";
            MessageBox.Show(message, title);
        }

        private void hmBtnExit_Click(object sender, EventArgs e)
        {
            hoofdmenuPage.ExitGame();
        }

        #endregion

        #region Spel

        private void spelTimerUpdate_Tick(object sender, EventArgs e)
        {
            gamePage.Update();
        }

        private void spelTimerTurn_Tick(object sender, EventArgs e)
        {
            gamePage.ResetGuess();
        }

        private void spelPbClick(object sender, EventArgs e)
        {
            gamePage.CardClicked(sender);
        }

        #endregion
    }
}
