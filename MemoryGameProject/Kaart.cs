using System.Windows.Forms;

namespace MemoryGameProject
{
    /// <summary>
    ///     De object kaart.
    /// </summary>
    public class Kaart
    {
        //De positie van de kaart op de X as.
        public int X;

        //De positie van de kaart op de Y as.
        public int Y;

        //Met welke picture box het verbonden is.
        public PictureBox pictureBox;

        //Welke ID de voorkant is.
        public int front;
        public bool geraden;

        public Kaart(int x, int y, PictureBox pictures)
        {
            X = x;
            Y = y;
            pictureBox = pictures;
        }
    }
}
