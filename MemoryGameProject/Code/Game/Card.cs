using System;
using System.Windows.Forms;

namespace MemoryGameProject
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

        //Met welke picture box het verbonden is.
        [NonSerialized]
        public PictureBox pictureBox;

        //Welke ID de voorkant is.
        public int front;

        //Boolean om aan te geven of een kaart al geraden is of niet.
        public bool isGuessed;

        public Card(int x, int y, PictureBox pictures)
        {
            X = x;
            Y = y;
            pictureBox = pictures;
            isGuessed = false;
        }
    }
}
