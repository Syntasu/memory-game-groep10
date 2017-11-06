using MemoryGameProject.Code.Game;
using MemoryGameProject.Code.IO;
using MemoryGameProject.Code.UI;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace MemoryGameProject.Code.Pages
{
    /// <summary>
    ///     Klasse die alle functionaliteit van het spel zelf heeft.
    /// </summary>
    public class SpelPage
    {
        /// <summary>
        ///     Referentie naar de spelers lijst, Spelers lijst handelt alles af m.b.t spelers.
        /// </summary>
        private PlayerList playerList;

        /// <summary>
        ///     Referentie naar de turn controllerm, Turn controller handelt alles af m.b.t. beurten.
        /// </summary>
        private TurnController turnController;

        /// <summary>
        ///     Referentie naar de card controller, Card controller handelt alles af m.b.t. kaarten.
        /// </summary>
        private CardController cardController;

        /// <summary>
        ///     Referentie naar de end game pagina.
        /// </summary>
        private EndGamePage endGamePage;

        /// <summary>
        ///     Referentie naar het speelveld.
        /// </summary>
        private PlayingField playingField;

        /// <summary>
        ///     Referentie naar de highscore pagina.
        /// </summary>
        private HighScorePage highScorePage = new HighScorePage();

        /// <summary>
        ///     Een array met de kaarten van het spel.
        /// </summary>
        private Card[,] cards = new Card[4, 4];

        /// <summary>
        ///     Hoeveel tijd je hebt voor elke beurt.
        /// </summary>
        private int timePerTurn = 60;

        /// <summary>
        ///     De page controller die alle pagina beheerd.
        /// </summary>
        private PageController pageController;

        /// <summary>
        ///     De timer die bijhoud wanneer de beurt over is.
        /// </summary>
        private Timer timerTurnCountdown;

        /// <summary>
        ///     De timer die constant alles update.
        /// </summary>
        private Timer timerUpdateTimer;

        /// <summary>
        ///     De timer die bijhoud of de kaarten weer omgedraaid moet worden.
        /// </summary>
        private Timer timerCardReset;

        /// <summary>
        ///     De control met alle spelers (list view)
        /// </summary>
        private ListView listViewPlayerList;

        /// <summary>
        ///     Label die de naam van de gene die aan de beurt is laat zien
        /// </summary>
        private Label labelTurn;

        /// <summary>
        ///     Label met de tijd die nog over is voor de beurt.
        /// </summary>
        private Label labelTime;

        /// <summary>
        ///     Contructor die alle argumenten assgined aan de variabelen.
        /// </summary>
        public SpelPage(PageController pageController, EndGamePage endGamePage, PlayingField playingField, 
                        Timer timerTurnCountdown, Timer timerUpdateTimer, Timer timerCardReset,
                        ListView listViewPlayerList, Label labelTurn, Label labelTime)
        {
            this.pageController = pageController;
            this.endGamePage = endGamePage;
            this.playingField = playingField;
            this.timerTurnCountdown = timerTurnCountdown;
            this.timerUpdateTimer = timerUpdateTimer;
            this.timerCardReset = timerCardReset;
            this.listViewPlayerList = listViewPlayerList;
            this.labelTurn = labelTurn;
            this.labelTime = labelTime;
        }

        /// <summary>
        ///     Functie die het spel laat beginnen.
        /// </summary>
        /// <param name="players">Een array van spelers namen.</param>
        public void BeginGame(string[] players)
        {
            /*
             * Maak een nieuwe spelers lijst en beurten controller.
             * Spelers lijst vraagt een string array met alle gebruikers namen van de spelers.
             * De turn controller vraagt de spelers lijst en hoeveel tijd je per beurt hebt.
             */
            playerList = new PlayerList(players);
            turnController = new TurnController(timePerTurn, playerList);
            cardController = new CardController(playingField, timerCardReset, 2, turnController, playerList);

            //Start de turn controller, normaal roepen we dit aan als het spel begint.
            turnController.BeginTurn();

            //Vul alles in (labels, listboxes) op de user interface.
            SetupUserInterface();

            //Start de update timer, zodat de user interface geupdate word.
            timerUpdateTimer.Start();
        }

        public bool SaveGame()
        {
            GameContext ctx = new GameContext(playerList, turnController, cardController, playingField);
            byte[] data = ctx.Serialize();

            if(!GameFiles.WriteSaveGame(data))
            {
                return false;
            }

            return true;
        }

        public bool LoadGame()
        {
            GameContext context = GameFiles.LoadSaveGame();
            
            if(context == null)
            {
                return false;
            }

            playerList.SetContext(context);
            turnController.SetContext(context);
            playingField.SetContext(context);

            return true;

        }

        /// <summary>
        ///     Functie die het spel stil zet of compleet beeindiged.
        /// </summary>
        public void EndGame()
        {
            //Zet de update timer en de turn timer stil.
            timerUpdateTimer.Stop();
            timerTurnCountdown.Stop();

            //Laat de "SPEL_END" pagina zien.
            pageController.ShowPage(PageController.PAGE_SPEL_END);

            Player[] players = DetermineWinner();

            if (players.Length == 1)
            {
                highScorePage.checkHighscore(players[0].name, players[0].score);
            }
            else
            {
                highScorePage.checkHighscore(players[0].name, players[0].score, players[1].name, players[1].score);
            }

            endGamePage.ShowWinners(players);
        }

        /// <summary>
        ///     Returned de winnaar van het spel, meerdere spelers als er een gelijkspel is.
        /// </summary>
        /// <returns>Een array van spelers die het spel hebben gewonnen.</returns>
        public Player[] DetermineWinner()
        {
            //Lijst met alle winnaars.
            List<Player> winners = new List<Player>();

            //Zoek uit wat de hoogste score is in het spel en welke spelers dit zijn.
            int highestScore = -1;

            for (int i = 0; i < playerList.GetPlayerCount(); i++)
            {
                //Verkrijg het speler object.
                Player p = playerList.GetPlayerById(i);

                //Als de score van de speler hoger is dan hoogste score tot nu toe...
                if(p.score > highestScore)
                {
                    //Hoogste score zetten we naar de spelers score.
                    highestScore = p.score;

                    /*
                     * En we winners list wordt geleegd, omdat we nu een speler hebben 
                     * met nog een hogere score. Daarvoor zijn de vorige winnaars geen "winnaars" meer.
                     */
                    winners.Clear();
                }

                //Als je score gelijk is aan de hoogste score, dan ben je ook een winnaar.
                if(p.score == highestScore)
                {
                    //Voeg de speler aan de winnaar lijst toe.
                    winners.Add(p);
                }
            }

            //Geef een nieuwe array terug op basis van de winnaars lijst.
            return winners.ToArray();
        }

        /// <summary>
        ///     Functie die aangeroept word waneer de speler op een kaart klikt.
        /// </summary>
        /// <param name="obj">De object die door de event word aangemaakt.</param>
        public void CardClicked(object obj)
        {
            //Stuur door naar de card controller.
            cardController.CardClicked(obj);
        }

        /// <summary>
        ///     Reset de geraden kaarten, zodat de volgende beurt kan beginnen.
        /// </summary>
        public void ResetGuess()
        {
            cardController.ResetGuesses();
        }

        /// <summary>
        ///     Zet alle user interface elements hun initeele waarden. (zoals spelers in de speler lijst zetten)
        /// </summary>
        private void SetupUserInterface()
        {
            //Vind de speler met de eerste beurt.
            Player playerWithInitialTurn = playerList.GetPlayerById(turnController.CurrentPlayerId);

            //Selecteer de item in de listview voor de speler die aan de beurt is.
            UpdatePlayerList();

            listViewPlayerList.Items[playerWithInitialTurn.id].Selected = true;

            //Zet de text van de beurt label naar wie de beurt heeft.
            labelTurn.Text = "Beurt: " + playerWithInitialTurn.name;
        }

        /// <summary>
        ///     Update alle elementen van de game.
        /// </summary>
        public void Update()
        {
            //Update de UI, beurten en de spelers lijst.
            UpdateUserInterface();
            UpdateCardController();
            UpdateTurnController();
            UpdatePlayerList();

            /*
             * Kijk of het spel over is.
             * Zo ja, roep de EndGame functie aan.
             */
            if(cardController.CheckEndOfGame())
            {
                EndGame();
            }
        }

        /// <summary>
        ///     Update de user interface met mogelijke nieuwe waarden.
        /// </summary>
        private void UpdateUserInterface()
        {
            /*
             * Verkrijg de id van de speler die aan de beurt is (playerId).
             * Vraag het spelers object op met de ID die we zojuist hebben verkregen.
             */
            int playerId = turnController.CurrentPlayerId;
            Player playerWithTurn = playerList.GetPlayerById(playerId);

            //Zet de text van de beurt label naar wie de beurt heeft.
            labelTurn.Text = "Beurt: " + playerWithTurn.name;

            //Zet de tijd label naar de tijd van de beurt die nog over is.
            int tijdBeurtSeconden = turnController.GetTurnTimeInSeconds();
            string tijdBeurt = tijdBeurtSeconden.ToString();
            labelTime.Text = "Tijd: " + tijdBeurt + " seconden";

            //Als we minder dan 10 second nog hebben, zet de kleur naar rood.
            //Zo niet, zet het terug naar zwart.
            if (tijdBeurtSeconden <= 10)
            {
                labelTime.ForeColor = Color.Red;
            }
            else
            {
                labelTime.ForeColor = Color.Black;
            }
        }

        /// <summary>
        ///     Ververs de spelers lijst met nieuwe waarden.
        /// </summary>
        private void UpdatePlayerList()
        {
            //Maak de items van de list view helemaal leeg.
            listViewPlayerList.Items.Clear();

            //Loop over alle spelers die in de klasse spelerslijst staan.
            for (int i = 0; i < playerList.GetPlayerCount(); i++)
            {
                //Vraag de speler op.
                Player player = playerList.GetPlayerById(i);

                //Maak een nieuwe ListViewItem aan met de nieuwe waarden van de speler.
                ListViewItem item = new ListViewItem(new[] { player.name, player.score.ToString() });

                //Voeg deze weer toe aan de listview.
                listViewPlayerList.Items.Add(item);
            }
        }

        /// <summary>
        ///     Logica voor het update van de turn controller
        /// </summary>
        private void UpdateTurnController()
        {
            //Check of de tijd verstreken is.
            int timeLeft = turnController.GetTurnTimeInSeconds();

            //Als er geen tijd meer over is, volgende beurt.
            if (timeLeft <= 0)
            {
                turnController.NextTurn();
            }
        }

        /// <summary>
        ///     Update de card controller.
        /// </summary>
        private void UpdateCardController()
        {
            cardController.Update();
        }

        /// <summary>
        ///     Reset/Herstart de game.
        /// </summary>
        public void ResetGame()
        {
            //Zet de spelers lijst om in een string array.
            string[] players = new string[playerList.GetPlayerCount()];

            for (int i = 0; i < players.Length; i++)
            {
                players[i] = playerList.GetPlayerById(i).name;
            }

            //Begin de game opnieuw
            BeginGame(players);
        }
    }
}
