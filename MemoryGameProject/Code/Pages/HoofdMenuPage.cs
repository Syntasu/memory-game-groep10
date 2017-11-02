using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryGameProject.Code.Pages
{
    /// <summary>
    ///     Klass met alle functionaliteit m.b.t het hoofdmenu.
    /// </summary>
    public class HoofdMenuPage
    {
        /// <summary>
        ///     Lijst van alle spelers namen die door de spelers is ingevoerd.
        /// </summary>
        private List<string> playerNames = new List<string>();

        /// <summary>
        ///     Referentie naar de listbox in het hoofdmenu dat de speler namen bijhoud.
        /// </summary>
        private ListBox playerList;

        /// <summary>
        ///     Referentie naar de tekstbox in het hoofdmenu die de gebruiker gebruikt om de naam in te voeren.
        /// </summary>
        private TextBox playerInputBox;

        public HoofdMenuPage(ListBox playerList, TextBox playerInputBox)
        {
            this.playerList = playerList;
            this.playerInputBox = playerInputBox;
        }

        /// <summary>
        ///     Functie die controleert of het spel kan beginnen.
        /// </summary>
        public bool CanBegin()
        {
            //Controleer of we meer dan 0 spelers hebben.
            bool enoughPlayers = playerNames.Count > 0;

            return enoughPlayers;
        }

        /// <summary>
        ///     Voeg een speler toe aan de spelers lijst in het hoofdmenu.
        /// </summary>
        public void AddPlayer()
        {
            string playerName = playerInputBox.Text;
            playerInputBox.Clear();

            //Controleer of we niet meer dan 4 spelers hebben.
            if(playerNames.Count >= 4)
            {
                MessageBox.Show("Meer spelers kunnen niet toegevoegd worden! (maximaal 4)");
                return;
            }

            /*
             * Controleer of de speler naam al een keer voorkomt in de spelers lijst.
             * Trim doen we om alle spaties weg te halen en ToLower om alles kleine letters te maken.
             */
            for (int i = 0; i < playerNames.Count; i++)
            {
                if (playerNames[i].Trim().ToLower() == playerName.Trim().ToLower())
                {
                    MessageBox.Show("Naam komt al een keer voor in de spelers lijst!");
                    return;
                }
            }

            //Kijk of de naam meer dan 3 characters heeft en minder als 16.
            if (playerName.Length < 2 || playerName.Length > 16)
            {
                MessageBox.Show("Naam moet tussen 3 - 16 characters zijn.");
                return;
            }

            //Als alles correct is, voeg de speler naam toe.
            playerNames.Add(playerName);
            playerList.Items.Add(playerName);

        }

        /// <summary>
        ///     Zet de spelers lijst om in een array.
        ///     Dit gebruiken we voornamelijk om een spelers lijst te creeren.
        /// </summary>
        /// <returns>Een array van string, elke string is een spelernaam.</returns>
        public string[] GetPlayerNames()
        {
            //Zet de List om naar een array.
            return playerNames.ToArray();
        }

        /// <summary>
        ///     Functie om het spel af te sluiten vanuit het hoofdmenu.
        /// </summary>
        public void ExitGame()
        {
            //Sluit het programma.
            Application.Exit();
        }

        /// <summary>
        ///     Reset het hoofdmenu.
        /// </summary>
        public void Reset()
        {
            //Maak de input box leeg.
            playerInputBox.Clear();
            
            //Maak de player list leeg.
            playerList.Items.Clear();

            //Maak opgeslagen speler namen leeg.
            playerNames.Clear();
        }
    }
}
