using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryGameProject.Code.Pages
{
    public class Hoofdmenu
    {
        private List<string> playerNames = new List<string>();

        /// <summary>
        ///     Functie om het spel te beginnen vanuit het hoofdmenu.
        /// </summary>
        public void BeginGame()
        {
            if(playerNames.Count > 0)
            {
                //Start game.
            }
        }

        /// <summary>
        ///     Voeg een speler toe aan de spelers lijst in het hoofdmenu.
        /// </summary>
        /// <param name="playerName">De naam die we willen toevoegen (in dit geval de waarde uit de textbox).</param>
        /// <returns>Een bool, true als het een valide naam is en false als dit niet zo is.</returns>
        public bool AddPlayer(string playerName)
        {
            //Controleer of we niet meer dan 4 spelers hebben.
            if(playerNames.Count >= 4)
            {
                MessageBox.Show("Meer spelers kunnen niet toegevoegd worden! (maximaal 4)");
                return false;
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
                    return false;
                }
            }

            //Kijk of de naam meer dan 3 characters heeft en minder als 16.
            if (playerName.Length < 3 || playerName.Length > 16)
            {
                MessageBox.Show("Naam moet tussen 3 - 16 characters zijn.");
                return false;
            }

            //Als alles correct is, voeg de speler naam toe.
            playerNames.Add(playerName);
            return true;
        }

        /// <summary>
        ///     Zet de spelers lijst om in een array.
        ///     Dit gebruiken we voornamelijk om een spelers lijst te creeren.
        /// </summary>
        /// <returns>Een array van string, elke string is een spelernaam.</returns>
        public string[] GetPlayerNames()
        {
            return playerNames.ToArray();
        }

        /// <summary>
        ///     Functie om het spel af te sluiten vanuit het hoofdmenu.
        /// </summary>
        public void ExitGame()
        {
            Application.Exit();
        }
    }
}
