using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGameProject.Code.Pages
{
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
        ///     Het plaatje van de achterkant van de kaarten.
        /// </summary>
        private Bitmap backGraphic = Properties.Resources.sw0;

        /// <summary>
        ///     Alle graphics die we gaan gebruiken.
        ///     0 is de achterkant, 1 tot 7 zijn de voorkanten.
        /// </summary>
        private Bitmap[] cardGraphics =
        {
            Properties.Resources.sw1,
            Properties.Resources.sw2,
            Properties.Resources.sw3,
            Properties.Resources.sw4,
            Properties.Resources.sw5,
            Properties.Resources.sw6,
            Properties.Resources.sw7,
            Properties.Resources.sw8,
        };

        /// <summary>
        ///     Een array met de kaarten van het spel.
        /// </summary>
        private Card[,] cards = new Card[4, 4];

        /// <summary>
        ///     Hoeveel tijd je hebt voor elke beurt.
        /// </summary>
        private int timePerTurn = 60;

        /// <summary>
        ///     Een 2D array met alle pictureboxes gerelateerd aan de coordinaten.
        /// </summary>
        private PageController pageController;
        private PictureBox[,] pictureBoxField;
        private Timer timerTurnCountdown;
        private Timer timerUpdateTimer;
        private ListView listViewPlayerList;
        private Label labelTurn;
        private Label labelTime;


        public SpelPage(PageController pageController, PictureBox[,] pictureBoxField, Timer timerTurnCountdown,
            Timer timerUpdateTimer, ListView listViewPlayerList, Label labelTurn, Label labelTime)
        {
            this.pageController = pageController;
            this.pictureBoxField = pictureBoxField;
            this.timerTurnCountdown = timerTurnCountdown;
            this.timerUpdateTimer = timerUpdateTimer;
            this.listViewPlayerList = listViewPlayerList;
            this.labelTurn = labelTurn;
            this.labelTime = labelTime;
        }


        public void BeginGame(string[] players)
        {
            /*
             * Maak een nieuwe spelers lijst en beurten controller.
             * Spelers lijst vraagt een string array met alle gebruikers namen van de spelers.
             * De turn controller vraagt de spelers lijst en hoeveel tijd je per beurt hebt.
             */
            playerList = new PlayerList(players);
            turnController = new TurnController(timePerTurn, playerList);

            //Start de turn controller, normaal roepen we dit aan als het spel begint.
            turnController.BeginTurn();

            //Vul alles in (labels, listboxes) op de user interface.
            SetupUserInterface();
            SetupCards();

            timerUpdateTimer.Start();
        }

        public void EndGame()
        {
            timerUpdateTimer.Stop();
            timerTurnCountdown.Stop();

            pageController.ShowPage(PageController.PAGE_SPEL_END);
        }

        public void CardClicked(object obj)
        {
            cardController.CardClicked(obj);
        }

        public void ResetGuess()
        {
            cardController.ResetGuesses();
        }

        /// <summary>
        ///     Alle kaarten aanmaken, een picture box linken aan de coordinaten.
        ///     Daarna over alle kaarten loopen en een random voorkant geven.
        /// </summary>
        private void SetupCards()
        { 
            Random rand = new Random();

            //Houd een array bij met hoe vaak een kaart gekozen is.
            int[] picked = new int[8];

            //Loop over de 2d array heen.
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    //Maak een nieuwe object van de kaart aan.
                    cards[x, y] = new Card(x, y, pictureBoxField[x, y]);

                    bool haspicked = false;

                    //Pak een random nummer tussen 0 en 8.
                    int kaart = rand.Next(0, 8);

                    // Zolang we nog geen kaart hebben gepakt, dan...
                    while (!haspicked)
                    {
                        //Als de kaart minder dan 2x gekozen is, gebruik deze kaart.
                        if (picked[kaart] <= 1)
                        {
                            //Zeg welke id deze kaart heeft.
                            cards[x, y].front = kaart;

                            //Plus 1 in de picked array.
                            picked[kaart] = picked[kaart] + 1;

                            //En we hebben gekozen dus we willen uit de while loop weg.
                            haspicked = true;
                        }
                        //Als de kaart al meer dan 2 keer gekozen is...
                        //Trek een nieuwe random nummer en probeer opnieuw
                        else
                        {
                            kaart = rand.Next(0, 8);
                        }
                    }

                }
            }

            //Initialiseer de card controller.
            cardController = new CardController(
                cards, cardGraphics, backGraphic,
                timerTurnCountdown, 2, turnController, playerList
            );

            //Reset alle kaarten.
            cardController.ResetCards();
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

        public void Update()
        {
            UpdateUserInterface();
            UpdateTurnController();
            UpdatePlayerList();

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
            listViewPlayerList.Items.Clear();

            for (int i = 0; i < playerList.GetPlayerCount(); i++)
            {
                Player player = playerList.GetPlayerById(i);
                ListViewItem item = new ListViewItem(new[] { player.name, player.score.ToString() });
                listViewPlayerList.Items.Add(item);

                int playerTurnId = turnController.CurrentPlayerId;

                if (i == playerTurnId)
                {
                    listViewPlayerList.Items[i].Selected = true;
                }
                else
                {
                    listViewPlayerList.Items[i].Selected = false;
                }
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
    }
}
