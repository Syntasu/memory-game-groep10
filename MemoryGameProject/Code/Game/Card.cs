using System;

namespace MemoryGameProject.Code.Game
{
    /// <summary>
    ///     De object kaart.
    /// </summary>
    [Serializable]
    public class Card
    {
        //De positie van de kaart op de X as.
        public int X;

        //De positie van de kaart op de Y as.
        public int Y;

        //Welke ID de voorkant is.
        public int front;

        //Boolean om aan te geven of een kaart al geraden is of niet.
        public bool isGuessed;

        //Bool die aangeeft of een kaart omgeflipt is door een gebruiker
        public bool isFlipped;

        /// <summary>
        ///     Constructor voor Card de klasse
        /// </summary>
        /// <param name="x"> De x axis van de kaart.</param>
        /// <param name="y"> De y axis van de kaart.</param>
        public Card(int x, int y)
        {
            X = x;
            Y = y;
            isGuessed = false;
            isFlipped = false;
        }
    }
}
