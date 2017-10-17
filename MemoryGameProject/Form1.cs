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

        /// <summary>
        ///     Hoeveel tijd je hebt voor elke beurt.
        /// </summary>
        private int tijdPerTurn = 60;

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
            turnController = new TurnController(tijdPerTurn, playerList);

            //Start de turn controller, normaal roepen we dit aan als het spel begint.
            turnController.BeginTurn();

            //Vul alles in (labels, listboxes) op de user interface.
            SetupUserInterface();

            Bitmap[] achterkanten = new Bitmap[8];
            achterkanten[0] = Properties.Resources.sw0;
            achterkanten[1] = Properties.Resources.sw1;
            achterkanten[2] = Properties.Resources.sw2;
            achterkanten[3] = Properties.Resources.sw3;
            achterkanten[4] = Properties.Resources.sw4;
            achterkanten[5] = Properties.Resources.sw5;
            achterkanten[6] = Properties.Resources.sw6;
            achterkanten[7] = Properties.Resources.sw7;

            Kaart[,] kaarten = new Kaart[4, 4];
            kaarten[0, 0] = new Kaart(0, 0, kaart00);
            kaarten[0, 1] = new Kaart(0, 1, kaart01);
            kaarten[0, 2] = new Kaart(0, 2, kaart02);
            kaarten[0, 3] = new Kaart(0, 3, kaart03);
            kaarten[1, 0] = new Kaart(1, 0, kaart10);
            kaarten[1, 1] = new Kaart(1, 1, kaart11);
            kaarten[1, 2] = new Kaart(1, 2, kaart12);
            kaarten[1, 3] = new Kaart(1, 3, kaart13);
            kaarten[2, 0] = new Kaart(2, 0, kaart20);
            kaarten[2, 1] = new Kaart(2, 1, kaart21);
            kaarten[2, 2] = new Kaart(2, 2, kaart22);
            kaarten[2, 3] = new Kaart(2, 3, kaart23);
            kaarten[3, 0] = new Kaart(3, 0, kaart30);
            kaarten[3, 1] = new Kaart(3, 1, kaart31);
            kaarten[3, 2] = new Kaart(3, 2, kaart32);
            kaarten[3, 3] = new Kaart(3, 3, kaart33);
            // kaarten[0, 0] = new kaart(0,0) 
            Random rand = new Random();
            int[] picked = new int[8];
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    bool haspicked = false;
                    int kaart = rand.Next(0, 8);
                    while (!haspicked)
                    {
                        if (picked[kaart] <= 1)
                        {
                            kaarten[x, y].Achterkant = kaart;
                            kaarten[x, y].Pictures.Image = achterkanten[kaart];
                            picked[kaart]++;
                            haspicked = true;
                        }
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
            //Vul de list box met all speler namen.
            for (int i = 0; i < playerList.GetPlayerCount(); i++)
            {
                Player player = playerList.GetPlayerById(i);
                lbSpelers.Items.Add(player.name);
            }

            //Vind de speler met de eerste beurt.
            Player playerWithInitialTurn = playerList.GetPlayerById(turnController.CurrentPlayerId);

            //Zet de geselecteerd index van de listbox naar de speler wie de beurt heeft.
            lbSpelers.SelectedIndex = turnController.CurrentPlayerId;

            //Zet de text van de beurt label naar wie de beurt heeft.
            lblBeurt.Text = "Beurt: " + playerWithInitialTurn.name;
        }

        /// <summary>
        ///     Update de user interface met mogelijke nieuwe waarden.
        /// </summary>
        private void UpdateUserInterface()
        {
            int playerId = turnController.CurrentPlayerId;
            Player playerWithTurn = playerList.GetPlayerById(playerId);

            //Zet de geselecteerd index van de listbox naar de speler wie de beurt heeft.
            lbSpelers.SelectedIndex = playerId;

            //Zet de text van de beurt label naar wie de beurt heeft.
            lblBeurt.Text = "Beurt: " + playerWithTurn.name;

            //Zet de tijd label naar de tijd van de beurt die nog over is.
            int tijdBeurtSeconden = turnController.GetTurnTimeInSeconds();
            string tijdBeurt = tijdBeurtSeconden.ToString();
            lblTijd.Text = "Tijd: " + tijdBeurt + " seconden";

            //Als we minder dan 10 second nog hebben, zet de kleur naar rood.
            //Zo niet, zet het terug naar zwart.
            if(tijdBeurtSeconden <= 10)
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
            if(timeLeft <= 0)
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

    }
}
