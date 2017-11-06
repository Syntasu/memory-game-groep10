using MemoryGameProject.Properties;
using System.Drawing;
using System.Windows.Forms;
using System;
using MemoryGameProject.Code.IO;

namespace MemoryGameProject.Code.Game
{
    /// <summary>
    ///     Klasse die alles m.b.t. het speelveld afhandeld.
    /// </summary>
    public class PlayingField
    {
        /// <summary>
        ///     Hoe breed het spelveld is.
        /// </summary>
        private int width = 4;

        /// <summary>
        ///     Hoe hoog het spelveld is.
        /// </summary>
        private int height = 4;

        /// <summary>
        ///     Hoeveel power ups we generen per veld.
        /// </summary>
        private int powerUpCount;

        /// <summary>
        ///     Array van alle pictureboxes die gevonden zijn.
        /// </summary>
        private PictureBox[,] cardPictureBoxes;

        /// <summary>
        ///     Alle kaarten die in het spel bestaan.
        /// </summary>
        private Card[,] cards;

        /// <summary>
        ///     Alle plaatjes met de achterkant (sw0) en alle voorkanten (sw1 t/m sw8).
        /// </summary>
        private Bitmap[] playingCardsSet = 
        {
            Resources.sw0,
            Resources.sw1,
            Resources.sw2,
            Resources.sw3,
            Resources.sw4,
            Resources.sw5,
            Resources.sw6,
            Resources.sw7,
            Resources.sw8,
        };
    
        /// <summary>
        ///     Constructor...
        /// </summary>
        /// <param name="form">De MainForm met de controls van het spel.</param>
        /// <param name="pictureBoxName">De default naam van de kaarten.</param>
        /// <param name="width">De breedte van het spelveld.</param>
        /// <param name="height">Hoe hoog het spel veld is.</param>
        public PlayingField(PictureBox[,] pictureBoxes, int width, int height, int powerUpCount)
        {
            this.width = width;
            this.height = height;
            this.powerUpCount = powerUpCount;

            cards = new Card[width, height];
            cardPictureBoxes = new PictureBox[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cardPictureBoxes[x,y] = pictureBoxes[x, y];
                    cards[x, y] = new Card(x, y);
                }
            }
        }

        #region Graphics

        /// <summary>
        ///     Vind de corresponderende picturebox via de coordinaten.
        /// </summary>
        /// <param name="x"> De X axis van de kaart.</param>
        /// <param name="y"> De Y axis van de kaart.</param>
        /// <returns> De picturebox die gevonden is met de gegeven coordinaat.</returns>
        public PictureBox GetPictureBox(int x, int y)
        {
            return cardPictureBoxes[x, y];
        }

        /// <summary>
        ///     Vind de coordinaten op basis van een picturebox.
        /// </summary>
        /// <param name="pictureBox"> De picturebox object.</param>
        /// <param name="x">De x axis van de gegeven picturebox.</param>
        /// <param name="y">De y axis van de gegeven picturebox.</param>
        public void GetCoordinates(PictureBox pictureBox, out int x, out int y)
        {
            for (int ix = 0; ix < width; ix++)
            {
                for (int iy = 0; iy < height; iy++)
                {
                    if (cardPictureBoxes[ix, iy] == pictureBox)
                    {
                        x = ix;
                        y = iy;

                        return;
                    }
                }
            }

            x = 0;
            y = 0;
        }

        /// <summary>
        ///     Vind de voorkant van een kaart op basis van een id.
        /// </summary>
        /// <param name="id">De ID die we willen opvragen.</param>
        /// <returns>Returns een bitmap die we gevonden hebben.</returns>
        public Bitmap GetFrontImageById(int id)
        {
            return playingCardsSet[id];
        }

        /// <summary>
        ///     Vind het plaatje wat de achterkant is.
        /// </summary>
        /// <returns>De achterkant plaatje van de kaarten.</returns>
        public Bitmap GetBackImage()
        {
            return playingCardsSet[0];
        }

        #endregion

        #region Cards

        /// <summary>
        ///     Geef alle kaarten een willekeurige achterkant.
        /// </summary>
        public void Shuffle()
        {
            //Maak een nieuwe random object aan.
            Random rand = new Random();

            //Kies een willekeurige kaart die een power up krijgt.
            for (int i = 0; i < powerUpCount; i++)
            {
                int x = rand.Next(0, width);
                int y = rand.Next(0, height);

                cards[x, y].hasPowerUp = true;
            }

            //Houd een array bij met hoe vaak een kaart gekozen is.
            int[] picked = new int[8];

            //Loop over de 2d array heen.
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    int powerUpRandom = rand.Next(0, 4);
                    bool haspicked = false;

                    //Pak een random nummer tussen 0 en 8.
                    int kaart = rand.Next(1, 9);

                    // Zolang we nog geen kaart hebben gepakt, dan...
                    while (!haspicked)
                    {
                        //Als de kaart minder dan 2x gekozen is, gebruik deze kaart.
                        if (picked[kaart-1] <= 1)
                        {
                            //Zeg welke id deze kaart heeft.
                            cards[x, y].front = kaart;

                            //Plus 1 in de picked array.
                            picked[kaart-1] = picked[kaart-1] + 1;

                            //En we hebben gekozen dus we willen uit de while loop weg.
                            haspicked = true;
                        }
                        //Als de kaart al meer dan 2 keer gekozen is...
                        //Trek een nieuwe random nummer en probeer opnieuw
                        else
                        {
                            kaart = rand.Next(1, 9);
                        }
                    }

                }
            }
        }

        /// <summary>
        ///     Vind een kaart op een bepaald coordinaat.
        /// </summary>
        /// <param name="x"> De x as van de gewenste kaart.</param>
        /// <param name="y"> De y as van de gewenste kaart.</param>
        /// <returns></returns>
        public Card GetCardAt(int x, int y)
        {
            //Controleer of we niet buiten de grensen een kaart proberen te pakken.
            if(x >= width || x < 0 || y >= height || y < 0)
            {
                return null;
            }

            return cards[x, y];
        }

        #endregion

        #region Saving/Loading context

        /// <summary>
        ///     Maak de "context" van de PlayingField class.
        ///     Maakt een copy met alleen de data van PlayingField
        /// </summary>
        /// <returns>Returned de context</returns>
        public PlayingFieldContext GetContext()
        {
            return new PlayingFieldContext(width, height, cards);
        }

        /// <summary>
        ///     Gebruik de geladen data (de gamecontext) om de playing field weer in te stellen.
        /// </summary>
        public void SetContext(GameContext context)
        {
            width = context.playingFieldContext.width;
            height = context.playingFieldContext.height;
            cards = context.playingFieldContext.cards;
        }

        #endregion

        public void Reset()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cards[x, y].isFlipped = false;
                    cards[x, y].isGuessed = false;
                }
            }
        }
    }
}
