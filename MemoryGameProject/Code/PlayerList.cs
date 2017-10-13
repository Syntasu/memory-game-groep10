using System.Windows.Forms;

namespace MemoryGameProject.Code
{
    /// <summary>
    ///     Een speler object.
    /// </summary>
    public class Player
    {
        /// <summary>
        ///     Id van de speler.
        /// </summary>
        public int id;

        /// <summary>
        ///     Naam van de speler.
        /// </summary>
        public string name;
    }

    public class PlayerList
    {
        public Player[] playerList;

        /// <summary>
        ///     Constructor voor de player list. Het zet een array van strings om in een array van Player objecten.
        ///     Speler object heeft een naam en een ID.
        /// </summary>
        /// <param name="playerNames"></param>
        public PlayerList(string[] playerNames)
        {
            playerList = new Player[playerNames.Length];

            for (int i = 0; i < playerNames.Length; i++)
            {
                Player player = new Player();
                player.id = i;
                player.name = playerNames[i];

                playerList[i] = player;
            }
        }

        /// <summary>
        ///     Verkrijg de speler object door middel van een ID.
        /// </summary>
        /// <param name="id">De id van de speler die we willen verkrijgen.</param>
        /// <returns>Een instance van de speler uit de spelers lijst, null als de speler niet gevonden kan worden.</returns>
        public Player GetPlayerById(int id)
        {
            for (int i = 0; i < playerList.Length; i++)
            {
                if (playerList[i].id == id)
                {
                    return playerList[i];
                }
            }

            return null;
        }

        /// <summary>
        ///     Kijk hoeveel spelers in de player list zitten.
        /// </summary>
        /// <returns>Returned het aantal spelers.</returns>
        public int GetPlayerCount()
        {
            return playerList.Length;
        }
    }
}
