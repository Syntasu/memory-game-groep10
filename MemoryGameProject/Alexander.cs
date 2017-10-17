using MemoryGameProject.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Alexander : Form
    {
        public Alexander()
        {
            InitializeComponent();
        }

        private void Alexander_Load(object sender, EventArgs e)
        {

        }

        private void submitUsername_Click(object sender, EventArgs e)
        {
            List<string> Names = new List<string>();

            if (tbUsername.TextLength < 3 || tbUsername.TextLength > 20)
            {
                MessageBox.Show("Naam moet tussen 3 - 20 characters zijn.");
                tbUsername.Clear();
            }
            else
            {
                lbPlayers.Items.Add(Names);
                Names.Add(tbUsername.Text);
                tbUsername.Clear();
            }
        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            string title = "How To Play";
            string message = "Speel het spel met 2 tot 4 spelers. Ben je met een grotere groep, maak dan teams." + "\n" + "\n" + "Probeer zoveel mogelijk twee dezelfde kaartjes om te draaien. Als je aan de beurt bent, draai je een kaartje naar keuze om en daarna draai je een tweede kaartje om." + "\n" + "\n" + "Als de kaartjes gelijk zijn, dan mag je nog een keer tot je twee kaartjes hebt omgedraaid die geen paar vormen." + "\n" + "\n" + "Als je twee kaartjes omdraait die niet gelijk zijn, draaien de kaartjes weer om en de volgende speler is aan de beurt. Ga zo door tot alle kaartjes op zijn. De speler met de meeste kaartjes wint." + "\n" + "\n";
            MessageBox.Show(message, title);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            //TO DO Functie om het spel op te starten.
        }

        private void Leaderboard_Click(object sender, EventArgs e)
        {
            //TO DO Lijst met de beste scores van de spelers.
        }

        private void About_Click(object sender, EventArgs e)
        {
            //TO DO Algemene info over spel etc.
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
