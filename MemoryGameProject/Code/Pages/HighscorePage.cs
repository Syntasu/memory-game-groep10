using System.Windows.Forms;
using MemoryGameProject.Code.IO;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGameProject.Code.Pages
{
    /// <summary>
    ///     Klasse die alle functionaliteit heeft met betrekking tot de highscore lijst. 
    /// </summary>
    public class  HighScorePage
    {
        /// <summary>
        ///     Referentie naar de high score list view.
        /// </summary>
        private ListView highscoreList;

        public HighScorePage(ListView highscoreList)
        {
            this.highscoreList = highscoreList;
        }

        /// <summary>
        ///     Update de highscore lijst door middel van het highscore bestand
        /// </summary>
        public void Show()
        {
            //Verkrijg de highscore data.
            HighscoreContext highscoreContext = GameFiles.LoadHighscore();

            if (highscoreContext != null)
            {
                //Sorteer met wins
                List<HighscoreListItem> sortedList = 
                    highscoreContext.HighscoreItems.OrderByDescending(x => x.wins).ToList();

                for (int i = 0; i < sortedList.Count; i++)
                {
                    HighscoreListItem item = sortedList[i];

                    //Maak een nieuwe list view item.
                    ListViewItem lvItem = new ListViewItem(new[] {
                        item.name, item.wins.ToString(), item.score.ToString()
                    });

                    //En voeg de listview item toe aan de highscore listview.
                    highscoreList.Items.Add(lvItem);
                }
            }
        }

  
        /// <summary>
        ///     Maak de highscore lijst leeg.
        /// </summary>
        public void ResetList()
        {
            highscoreList.Items.Clear();
        }
    }

}

