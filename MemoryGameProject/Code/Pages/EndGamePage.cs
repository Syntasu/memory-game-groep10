using System.Windows.Forms;

namespace MemoryGameProject.Code.Pages
{
    /// <summary>
    ///     Klasse met alle functionaliteit met betrekking tot de eind pagina.
    /// </summary>
    public class EndGamePage
    {
        /// <summary>
        ///     De label wat de winnaars laat zien.
        /// </summary>
        private Label labelWinners;

        public EndGamePage(Label labelWinners)
        {
            this.labelWinners = labelWinners;
        }

        /// <summary>
        ///     Laat de winnaars zien  op het scherm, kan meerdere spelers zijn.
        /// </summary>
        /// <param name="players"></param>
        public void ShowWinners(Player[] players)
        {
            //Maak een string waar bij je de spelers met punten bevat.
            string message = "De winnaars: \n\r";
            for (int i = 0; i < players.Length; i++)
            {
                message += players[i].name + " met " + players[i].score.ToString() + " punten \n\r";
            }

            //Laat de tekst zien op de label.
            labelWinners.Text = message;
        }
    }
}
