using MemoryGameProject.Code.IO;
using System;
using System.Diagnostics;

namespace MemoryGameProject.Code
{

    public class TurnController
    {
        /// <summary>
        ///     Referentie naar de spelerslijst (via argumenten geassigned).
        /// </summary>
        private PlayerList playerList;

        /// <summary>
        ///     Een stopwatch object die de tijd van elke beurt bijhoud.
        /// </summary>
        private Stopwatch turnTimer;

        /// <summary>
        ///     Hoeveel tijd je hebt per beurt, default is 60 seconden. Via argumenten kan je dit overschrijven.
        /// </summary>
        private int turnTimeInSeconds = 60;

        /// <summary>
        ///     De ID van de speler die nu aan de beurt is.
        /// </summary>
        public int CurrentPlayerId = 0;

        public TurnController(int turnTimeInSeconds, PlayerList playerList)
        {
            this.playerList = playerList;

            this.turnTimeInSeconds = turnTimeInSeconds;
            this.turnTimer = new Stopwatch();
        }

        /// <summary>
        ///    Kiest een willekeurige speler om te beginn, roep deze methode aan als het spel kan beginnen.
        /// </summary>
        public void BeginTurn()
        {
            Random rand = new Random();

            //Kies een random speler van de speler lijst en zet deze aan de beurt.
            int playerCount = playerList.GetPlayerCount();
            int startingTurn = rand.Next(0, playerCount);
            CurrentPlayerId = startingTurn;

            //Beurt tijd beginnen.
            turnTimer.Start();
        }

        /// <summary>
        ///     Geeft de tijd die nog te gaan is voor de beurt.
        /// </summary>
        /// <returns>De tijd van de beurt.</returns>
        public int GetTurnTimeInSeconds()
        {
            //Maak een time span van 1 minuut en haal trek hier de tijd van de stopwatch vanaf.
            TimeSpan oneMinute = new TimeSpan(0, 0, turnTimeInSeconds);
            TimeSpan elapsed = oneMinute - turnTimer.Elapsed;
            int seconds = elapsed.Seconds;

            //Als de seconden meer is als de maximale tijd, geef de maximale tijd terug.
            if(seconds > turnTimeInSeconds)
            {
                return turnTimeInSeconds;
            }

            //Als de tijd negatief is, geef altijd 0 terug.
            if(seconds < 0)
            {
                return 0;
            }

            return seconds;
        }

        /// <summary>
        ///     Methode die het volgende beurt afhandeld.
        /// </summary>
        public void NextTurn()
        {
            //Tijd stoppen en resetten
            turnTimer.Restart();

            //Volgende id.
            CurrentPlayerId++;

            // Als CurrentPlayerId groter of gelijk is aan de player count, begin weer bij 0.
            if (CurrentPlayerId >= playerList.GetPlayerCount())
            {
                CurrentPlayerId = 0;
            }
        }

        public TurnControllerContext GetContext()
        {
            return new TurnControllerContext(turnTimeInSeconds, turnTimer, CurrentPlayerId);
        }

        public void SetContext(TurnControllerContext context)
        {
            turnTimeInSeconds = context.turnTimeInSeconds;
            turnTimer = context.turnTimer;
            CurrentPlayerId = context.currentPlayerId;
        }
    }
}
