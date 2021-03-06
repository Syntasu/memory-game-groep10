﻿using System;
using System.Windows.Forms;
using MemoryGameProject.Code.Pages;
using MemoryGameProject.Code;
using MemoryGameProject.Code.UI;
using System.Collections.Generic;
using MemoryGameProject.Code.Game;
using MemoryGameProject.Code.IO;

namespace MemoryGameProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     De page controller die verantwoordelijk is voor het veranderen van de paginas.
        /// </summary>
        private PageController pageController;

        /// <summary>
        ///     De hoofdmenu pagina instantie.
        /// </summary>
        private HoofdMenuPage hoofdmenuPage;

        /// <summary>
        ///     De spel pagina instantie.
        /// </summary>
        private SpelPage gamePage;

        /// <summary>
        ///     De eind spel pagina instantie.
        /// </summary>
        private EndGamePage endGamePage;
        
        /// <summary>
        ///     Pagina van de highscore lijst
        /// </summary>
        private HighScorePage highscorePage;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            //Maak een 2D array die alle pictueboxes aan een index linkt.
            PictureBox[,] pictureBoxes = new PictureBox[4, 4];
            pictureBoxes[0, 0] = spelPbKaart00;
            pictureBoxes[1, 0] = spelPbKaart10;
            pictureBoxes[2, 0] = spelPbKaart20;
            pictureBoxes[3, 0] = spelPbKaart30;
            pictureBoxes[0, 1] = spelPbKaart01;
            pictureBoxes[1, 1] = spelPbKaart11;
            pictureBoxes[2, 1] = spelPbKaart21;
            pictureBoxes[3, 1] = spelPbKaart31;
            pictureBoxes[0, 2] = spelPbKaart02;
            pictureBoxes[1, 2] = spelPbKaart12;
            pictureBoxes[2, 2] = spelPbKaart22;
            pictureBoxes[3, 2] = spelPbKaart32;
            pictureBoxes[0, 3] = spelPbKaart03;
            pictureBoxes[1, 3] = spelPbKaart13;
            pictureBoxes[2, 3] = spelPbKaart23;
            pictureBoxes[3, 3] = spelPbKaart33;


            //Maak een nieuwe page controller aan.
            pageController = new PageController(mainTabControl, 0);

            //Maak een nieuwe hoofdmenu aan.
            hoofdmenuPage = new HoofdMenuPage(hmLbPlayers, hmTbPlayername);

            //Maak een eind pagina aan.
            endGamePage = new EndGamePage(endLblWinners);

            PlayingField playingField = new PlayingField(pictureBoxes, 4, 4, 2);

            //Maak een nieuwe spel pagina aan.
            gamePage = new SpelPage(
                pageController, endGamePage,
                playingField, spelTimerTurn, 
                spelTimerUpdate, spelTimerResetCards,
                spelLvSpelers,spelLblTurn, spelLblTime
            );

            highscorePage = new HighScorePage(hsLvList);
        }

        /// <summary>
        ///     Event die word aangeroepen wanneer iets een andere tab/pagina wil/
        /// </summary>
        /// <param name="sender">De object die de event heeft aangeroepen.</param>
        /// <param name="e">De event argumenten.</param>
        private void mainTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Als we de pagina niet mogen veranderen, dan willen we het event negeren.
            if (!pageController.AllowChange())
            {
                e.Cancel = true;
            }
        }

        #region Hoofdmenu
        /// <summary>
        ///     Event voor de "voeg toe" button wanneer je hier op klikt.
        /// </summary>
        private void hmBtnPlayerAdd_Click(object sender, EventArgs e)
        {
            hoofdmenuPage.AddPlayer();
        }

        /// <summary>
        ///     Event voor de play button wanneer je hier op klikt.
        /// </summary>
        private void hmBtnPlay_Click(object sender, EventArgs e)
        {
            //Controleer of het spel kan beginnen.
            if (hoofdmenuPage.CanBegin())
            {
                //Verkrijg een array met alle speler namen.
                string[] players = hoofdmenuPage.GetPlayerNames();

                //Start het spel.
                gamePage.BeginGame(players);

                //Controleer of we al een save game hebben..
                if (GameFiles.HasSaveGame())
                {
                    //Vraag om gebruikers input
                    DialogResult result = MessageBox.Show(
                        "Er is al een bestaande game opgeslagen, wil je deze laden?", 
                        "Game Laden", MessageBoxButtons.YesNo
                    );

                    if(result == DialogResult.Yes)
                    {
                        //Laad het spel van schijf.
                        gamePage.LoadGame();
                    }
                }
              
                //Laat het spel pagina zien.
                pageController.ShowPage(PageController.PAGE_SPEL);
            }
            else
            {
                MessageBox.Show("Er zijn te weinig spelers om het spel te starten!", "Woops", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        ///    Event voor de highscore button wanneer je hier op klikt. 
        /// </summary>
        private void hmBtnHighscore_Click(object sender, EventArgs e)
        {
            highscorePage.Show();

            //Laat de highscore lijst pagina zien.
            pageController.ShowPage(PageController.PAGE_HIGHSCORE);

        }

        /// <summary>
        ///    Event voor de "uitleg" button wanneer je hier op klikt. 
        /// </summary>
        private void hmBtnExplanation_Click(object sender, EventArgs e)
        {
            //Laat een message box zien.
            string title = "Uitleg";
            string message = "Speel het spel met 2 tot 4 spelers. Ben je met een grotere groep, maak dan teams." + "\n" + "\n" + "Probeer zoveel mogelijk twee dezelfde kaartjes om te draaien. Als je aan de beurt bent, draai je een kaartje naar keuze om en daarna draai je een tweede kaartje om." + "\n" + "\n" + "Als de kaartjes gelijk zijn, dan mag je nog een keer tot je twee kaartjes hebt omgedraaid die geen paar vormen." + "\n" + "\n" + "Als je twee kaartjes omdraait die niet gelijk zijn, draaien de kaartjes weer om en de volgende speler is aan de beurt. Ga zo door tot alle kaartjes op zijn. De speler met de meeste kaartjes wint." + "\n" + "\n";
            MessageBox.Show(message, title);
        }

        /// <summary>
        ///    Event voor de "over" button wanneer je hier op klikt. 
        /// </summary>
        private void hmBtnAbout_Click(object sender, EventArgs e)
        {
            //Laat textbox zien.
            string title = "Over...";
            string message = "Gemaakt door groep 10 \n\rDoor Valeria, Alexander en Alex.";
            MessageBox.Show(message, title);
        }

        /// <summary>
        ///    Event voor de exit button wanneer je hier op klikt. 
        /// </summary>
        private void hmBtnExit_Click(object sender, EventArgs e)
        {
            //Roep de functie aan om de game te stoppen.
            hoofdmenuPage.ExitGame();
        }

        #endregion

        #region Spel

        /// <summary>
        ///    Event voor elke keer dat de timer afloopt.
        /// </summary>
        private void spelTimerUpdate_Tick(object sender, EventArgs e)
        {
            //Update het spel.
            gamePage.Update();
        }

        /// <summary>
        ///    Event voor elke keer dat de timer afloopt.
        /// </summary>
        private void spelTimerTurn_Tick(object sender, EventArgs e)
        {
            //Reset de beurt als je beurt over is.
            gamePage.ResetGuess();
        }

        /// <summary>
        ///     De timer die verantwoordelijk is voor het resetten van de kaarten.
        /// </summary>
        private void spelTimerResetCards_Tick(object sender, EventArgs e)
        {
            //Reset de beurt als kaarten gekozen of geraden zijn.
            gamePage.ResetGuess();
        }

        /// <summary>
        ///    Globale event voor alle klikken op de kaarten van het spel.
        /// </summary>
        private void spelPbClick(object sender, EventArgs e)
        {
            //Zeg tegen het systeem dat er een kaart geklikt is.
            gamePage.CardClicked(sender);
        }

        /// <summary>
        ///     Knop om het spel op te slaan.
        /// </summary>
        private void spelBtnSave_Click(object sender, EventArgs e)
        {
            if (gamePage.SaveGame())
            {
                MessageBox.Show("Het spel is opgeslagen.", "Success");
            }
            else
            {
                MessageBox.Show("Kan spel niet opslaan", "Woops...");
            }
        }

        //TODO: Load button should be on the main page.
        /// <summary>
        ///     Knop om een spel inte laden.
        /// </summary>
        private void spelBtnLoad_Click(object sender, EventArgs e)
        {
            if (gamePage.LoadGame())
            {
                MessageBox.Show("Het spel is geladen.", "Success");
            }
            else
            {
                MessageBox.Show("Kan save game niet laden!", "Woops...");
            }
        }

        #endregion

        #region End game 
        
        /// <summary>
        ///     Terug naar hoofmenu knop.
        /// </summary>
        private void endBtnBack_Click(object sender, EventArgs e)
        {
            //Naar het hoofdmenu.
            pageController.ShowPage(PageController.PAGE_HOOFDMENU);

            //Reset de hoofdmenu.
            hoofdmenuPage.Reset();
        }

        /// <summary>
        ///     Knop om het spel te herstarten.
        /// </summary>
        private void endBtnAgain_Click(object sender, EventArgs e)
        {
            //Reset de game.
            gamePage.RestartGame();

            //Laat de spel pagina zien.
            pageController.ShowPage(PageController.PAGE_SPEL);
        }


        /// <summary>
        ///     Knop om naar de high score lijst te gaan.
        /// </summary>
        private void endBtnHighscores_Click(object sender, EventArgs e)
        {
            highscorePage.Show();
            pageController.ShowPage(PageController.PAGE_HIGHSCORE);
        }

        #endregion


        #region Highscore page

        private void hsBtnBack_Click(object sender, EventArgs e)
        {
            highscorePage.ResetList();
            pageController.ShowPage(PageController.PAGE_HOOFDMENU);
        }

        #endregion
    }
}
