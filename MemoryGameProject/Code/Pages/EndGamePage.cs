using MemoryGameProject.Code.Game;
using MemoryGameProject.Code.IO;
using System;
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

        /// <summary>
        ///     Update de highscore lijst 
        /// </summary>
        /// <param name="playerList"> De spelerslijst object </param>
        /// <param name="winners"> Array met de winnaars </param>
        public void UpdateHighscoreList(PlayerList playerList, Player[] winners)
        {
            //Vraag de highscore lijst op van de schijf.
            HighscoreContext highscoreList = GameFiles.LoadHighscore();

            // Als er abosluut niks in de highscore lijst staat, maak nieuwe aan.
            if(highscoreList == null)
            {
                highscoreList = new HighscoreContext();
            }

            //Ga over alle spelers heen in de speler lijst.
            for (int i = 0; i < playerList.GetPlayerCount(); i++)
            {
                //Verkrijg speler object.
                Player player = playerList.GetPlayerById(i);

                //Kijk of die gene een winaar is.
                bool isWinner = false;

                for (int w = 0; w < winners.Length; w++)
                {
                    if(winners[w].id == player.id)
                    {
                        isWinner = true;
                        break;
                    }
                }

                //Voeg HighScoreListItem toe als die niet bestaat:
                if(!highscoreList.ContainsPlayer(player))
                {
                    highscoreList.HighscoreItems.Add(new HighscoreListItem(player.name, 0, 0));
                }


                //Update alle waarden in de highscore lijst.
                for (int n = 0; n < highscoreList.HighscoreItems.Count; n++)
                {
                    HighscoreListItem item = highscoreList.HighscoreItems[n];
                    item.Update(player, isWinner);

                    highscoreList.HighscoreItems[n] = item;
                }

            }

            //Schrijf opnieuw naar schijf.
            GameFiles.CreateHighScoreList(highscoreList);
        }
    }
}
