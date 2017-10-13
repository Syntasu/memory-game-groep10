using System;

namespace MemoryGameProject.Code
{
    public class TurnController
    {
        private PlayerList playerList;

        public int CurrentPlayerId = 0;

        public TurnController(PlayerList playerList)
        {
            this.playerList = playerList;
        }

        /// <summary>
        ///    Kiest een willekeurige speler om te beginn, roep deze methode aan als het spel kan beginnen.
        /// </summary>
        public void Begin()
        {
            Random rand = new Random();

            //Kies een random speler van de speler lijst en zet deze aan de beurt.
            int playerCount = playerList.GetPlayerCount();
            int startingTurn = rand.Next(0, playerCount - 1);
            CurrentPlayerId = startingTurn;
        }

        /// <summary>
        ///     Methode die het volgende beurt afhandeld.
        /// </summary>
        public void Next()
        {
            //Volgende id.
            CurrentPlayerId++;

            // Als CurrentPlayerId groter of gelijk is aan de player count, begin weer bij 0.
            if (CurrentPlayerId >= playerList.GetPlayerCount())
            {
                CurrentPlayerId = 0;
            }
        }
    }
}
