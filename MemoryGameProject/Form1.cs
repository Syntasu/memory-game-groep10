using MemoryGameProject.Code;
using System;
using System.Windows.Forms;
 using System.Drawing;

namespace MemoryGameProject
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///     Referentie naar de spelers lijst. (Wordt op Form1_load aangemaakt).
        /// </summary>
        private PlayerList playerList;

        /// <summary>
        ///     Referenctie naar de turn controller (Wordt op Form1_Load aangemaakt).
        /// </summary>
        private TurnController turnController;
        private Bitmap achterkant = Properties.Resources.sw0;
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
        private Kaart[,] cards = new Kaart[4, 4];

        /// <summary>
        ///     Hoeveel tijd je hebt voor elke beurt.
        /// </summary>
        private int timePerTurn = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: De array van speler namen generen via de user interface.
            string[] playerNames = new string[3];
            playerNames[0] = "Alex";
            playerNames[1] = "Alexander";
            playerNames[2] = "Valeria";

            /*
             * Maak een nieuwe spelers lijst en beurten controller.
             * Spelers lijst vraagt een string array met alle gebruikers namen van de spelers.
             * De turn controller vraagt de spelers lijst en hoeveel tijd je per beurt hebt.
             */
            playerList = new PlayerList(playerNames);
            turnController = new TurnController(timePerTurn, playerList);

            //Start de turn controller, normaal roepen we dit aan als het spel begint.
            turnController.BeginTurn();

            //Vul alles in (labels, listboxes) op de user interface.
            SetupUserInterface();
            SetupCards();
        }

        /// <summary>
        ///     Alle kaarten aanmaken, een picture box linken aan de coordinaten.
        ///     Daarna over alle kaarten loopen en een random voorkant geven.
        /// </summary>
        private void SetupCards()
        {
            //Maak alle kaarten aan die in het spel zitten.
            //TODO: We zouden dit ook met de on_load 
            cards[0, 0] = new Kaart(0, 0, kaart00);
            cards[0, 1] = new Kaart(0, 1, kaart01);
            cards[0, 2] = new Kaart(0, 2, kaart02);
            cards[0, 3] = new Kaart(0, 3, kaart03);
            cards[1, 0] = new Kaart(1, 0, kaart10);
            cards[1, 1] = new Kaart(1, 1, kaart11);
            cards[1, 2] = new Kaart(1, 2, kaart12);
            cards[1, 3] = new Kaart(1, 3, kaart13);
            cards[2, 0] = new Kaart(2, 0, kaart20);
            cards[2, 1] = new Kaart(2, 1, kaart21);
            cards[2, 2] = new Kaart(2, 2, kaart22);
            cards[2, 3] = new Kaart(2, 3, kaart23);
            cards[3, 0] = new Kaart(3, 0, kaart30);
            cards[3, 1] = new Kaart(3, 1, kaart31);
            cards[3, 2] = new Kaart(3, 2, kaart32);
            cards[3, 3] = new Kaart(3, 3, kaart33);

            Random rand = new Random();

            //Houd een array bij met hoe vaak een kaart gekozen is.
            int[] picked = new int[8];

            //Loop over de 2d array heen.
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
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

                            //Zet de het plaatje van de kaart
                            //TODO: We willen plaatje niet laten zien, gebruik de achterkant.
                            cards[x, y].pictureBox.Image = achterkant;

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
        }

        /// <summary>
        ///     Zet all user interface elements hun initeele waarden. (zoals spelers in de speler lijst zetten)
        /// </summary>
        private void SetupUserInterface()
        {
            //Vul de list view met all speler namen.
            for (int i = 0; i < playerList.GetPlayerCount(); i++)
            {
                Player player = playerList.GetPlayerById(i);
                ListViewItem item = new ListViewItem(new[] { player.name, player.score.ToString() });
                lvSpelers.Items.Add(item);
            }

            //Vind de speler met de eerste beurt.
            Player playerWithInitialTurn = playerList.GetPlayerById(turnController.CurrentPlayerId);

            //Selecteer de item in de listview voor de speler die aan de beurt is.
            lvSpelers.Items[playerWithInitialTurn.id].Selected = true;

            //Zet de text van de beurt label naar wie de beurt heeft.
            lblBeurt.Text = "Beurt: " + playerWithInitialTurn.name;
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

            //Zet de geselecteerd index van de list view naar de speler wie de beurt heeft.
            lvSpelers.Items[playerWithTurn.id].Selected = true;

            //Zet de text van de beurt label naar wie de beurt heeft.
            lblBeurt.Text = "Beurt: " + playerWithTurn.name;

            //Zet de tijd label naar de tijd van de beurt die nog over is.
            int tijdBeurtSeconden = turnController.GetTurnTimeInSeconds();
            string tijdBeurt = tijdBeurtSeconden.ToString();
            lblTijd.Text = "Tijd: " + tijdBeurt + " seconden";

            //Als we minder dan 10 second nog hebben, zet de kleur naar rood.
            //Zo niet, zet het terug naar zwart.
            if (tijdBeurtSeconden <= 10)
            {
                lblTijd.ForeColor = Color.Red;
            }
            else
            {
                lblTijd.ForeColor = Color.Black;
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

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            //Update de user interface en de turn controller.
            UpdateUserInterface();
            UpdateTurnController();
        }

        int aantalGeraden = 0;
        bool isWaiting = false;
        Kaart[] Geraden = new Kaart[2];


        private void kaartklikken(object sender, EventArgs e)
        {
            if (checkGuess())
            {
                return;
            }
            PictureBox box = (PictureBox)sender;
            CompareGuess(box);
            if (CheckEndGame())
            {
                MessageBox.Show("Game over");
            }
        }
        private void CompareGuess(PictureBox box)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (box == cards[x, y].pictureBox)
                    {
                        Kaart gevonden = cards[x, y];
                        gevonden.pictureBox.Image = cardGraphics[gevonden.front];
                        Geraden[aantalGeraden] = gevonden;
                        aantalGeraden++;
                    }
                }

            }
        }
        private bool checkGuess()
        {
            if (isWaiting)
            {
                return true;
            }
            if (aantalGeraden == 2)
            {
                if (Geraden[0].front == Geraden[1].front)
                {
                    int playerId = turnController.CurrentPlayerId;
                    Player player = playerList.GetPlayerById(playerId);
                    player.score = player.score + 1;
                    Geraden[0].geraden = true;
                    Geraden[1].geraden = true;
                    Geraden = new Kaart[2];
                    aantalGeraden = 0;
                    isWaiting = false;
                }

                else
                {
                    timer1.Start();
                    isWaiting = true;
                }
                turnController.NextTurn();
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckEndGame()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Kaart k = cards[x, y];
                    if (k.geraden != true)
                    {
                        return false;
                    }


                    
                }
            }
            return true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Geraden.Length; i++)
            {
                Geraden[i].pictureBox.Image = achterkant;
            }
            Geraden = new Kaart[2];
            aantalGeraden = 0;
            isWaiting = false;
            timer1.Stop();
        }
    }
}
