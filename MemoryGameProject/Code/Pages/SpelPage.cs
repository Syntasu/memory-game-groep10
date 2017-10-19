using System;
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
        ///     Het plaatje van de achterkant van de kaarten.
        /// </summary>
        private Bitmap backGraphic = Properties.Resources.sw0;

        /// <summary>
        ///     Alle graphics die we gaan gebruiken in een array gezet.
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
        private PictureBox[,] pictureBoxField;

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
        /// <param name="pageController">De page controller verantwoordelijk voor paginas te switchen.</param>
        /// <param name="pictureBoxField">Een 2D array met alle pictureboxes.</param>
        /// <param name="timerTurnCountdown">Timer die verantwoordelijk voor het aftellen is.</param>
        /// <param name="timerUpdateTimer">Timer die gebruikers interface en logica update.</param>
        /// <param name="listViewPlayerList">De list view voor de spelers lijst. </param>
        /// <param name="labelTurn">De label met de naam van wie aan de beurt is.</param>
        /// <param name="labelTime">De label met de tijd die er nog over is.</param>
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

            //Start de turn controller, normaal roepen we dit aan als het spel begint.
            turnController.BeginTurn();

            //Vul alles in (labels, listboxes) op de user interface.
            SetupUserInterface();
            SetupCards();

            //Start de update timer, zodat de user interface geupdate word.
            timerUpdateTimer.Start();
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
        ///     Alle kaarten aanmaken, een picture box linken aan de coordinaten.
        ///     Daarna over alle kaarten loopen en een random voorkant geven.
        /// </summary>
        private void SetupCards()
        { 
            //Maak een nieuwe random object aan.
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
            //Update de UI, beurten en de spelers lijst.
            UpdateUserInterface();
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
    }
}
