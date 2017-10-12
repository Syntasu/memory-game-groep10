using MemoryGameProject.Code;
using System;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Form1 : Form
    {
        public static PlayerList SpelerLijst;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] playerNames = new string[];
            playerNames[0] = "Alex";
            playerNames[1] = "Alexander";
            playerNames[2] = "Valeria";

            SpelerLijst = new PlayerList(playerNames);
        }
    }
}
