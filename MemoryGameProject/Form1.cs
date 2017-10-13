using MemoryGameProject.Code;
using System;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] playerNames = new string[3];
            playerNames[0] = "Alex";
            playerNames[1] = "Alexander";
            playerNames[2] = "Valeria";

            PlayerList spelerLijst = new PlayerList(playerNames);
            //TurnController beurtController = new TurnController(spelerLijst);
        }

    }
}
