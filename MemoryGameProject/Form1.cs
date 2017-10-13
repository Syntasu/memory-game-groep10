using MemoryGameProject.Code;
using System;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Form1 : Form
    {
        private PlayerList playerList;
        private TurnController turnController;

        private bool IsGameRunning = true;
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

            playerList = new PlayerList(playerNames);
            turnController = new TurnController(playerList);
            turnController.Begin();

            SetupUserInterface();
        }

        private void SetupUserInterface()
        {
            for (int i = 0; i < playerList.GetPlayerCount(); i++)
            {
                Player player = playerList.GetPlayerById(i);
                lbSpelers.Items.Add(player.name);
            }

            Player playerWithInitialTurn = playerList.GetPlayerById(turnController.CurrentPlayerId);
            lbSpelers.SelectedIndex = turnController.CurrentPlayerId;
            lblBeurt.Text = "Beurt: " + playerWithInitialTurn.name;
        }

        private void UpdateUserInterface()
        {
            lbSpelers.SelectedIndex = turnController.CurrentPlayerId;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateUserInterface();
        }
    }
}
