using System.Collections.Generic;
using System.IO;
using System.Linq;
using MemoryGameProject;
using System;
using System.Windows.Forms;

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

        public void Load()
        {

        }

        public void Save()
        {

        }

        public void Update()
        {

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

