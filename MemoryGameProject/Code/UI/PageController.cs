using System.Windows.Forms;

namespace MemoryGameProject.Code.UI
{
    public class PageController
    {
        //Alle paginas gelinkt aan de naam van de pagina.
        public static string PAGE_HOOFDMENU = "hoofdMenuPage";
        public static string PAGE_SPEL = "spelPage";
        public static string PAGE_SPEL_END = "gameOverPage";
        public static string PAGE_HIGHSCORE = "highScorePage";

        /// <summary>
        ///     De index van de pagina die op dit moment geselecteerd is.
        /// </summary>
        public int CurrentSelected = 0;

        /// <summary>
        ///     De tab control die we willen gebruiken voor de PageController.
        /// </summary>
        private TabControl tabControl;

        /// <summary>
        ///     Een boolean die voorkomt dat de gebruiker zelf paginas kan switchen.
        /// </summary>
        private bool allowChange;

        /// <summary>
        ///     Constructor, gebruik de arugmenten om de variabelen een waarde te geven.
        /// </summary>
        /// <param name="tabControl"> De tab control die we voor de page controller willen gaan gebruiken.</param>
        /// <param name="startIndex"> De index van de pagina die we als eerste willen laten zien.</param>
        public PageController(TabControl tabControl, int startIndex)
        {
            this.tabControl = tabControl;
            CurrentSelected = startIndex;

            //Laat de eerste pagina zien.
            Move(CurrentSelected);
        }

        /// <summary>
        ///     Laat een pagina zien op basis van een index.
        /// </summary>
        /// <param name="index">De index die we willen laten zien.</param>
        private void Move(int index)
        {
            //Laat het systeem weten dat we de pagina mogen veranderen.
            allowChange = true;

            //Zet de geselecteerde pagina naar de index.
            tabControl.SelectedIndex = index;

            //En zet dit weer naar false, zodat de gebruiker het niet meer kan veranderen.
            allowChange = false;
        }

        /// <summary>
        ///     Laat een pagina zien op basis van zijn naam.
        /// </summary>
        /// <param name="name"> De naam van de pagina. </param>
        public void ShowPage(string name)
        {
            //Loop over alle paginas in de tab control.
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                //Als de naam overeen komt met de naam die we willen...
                if (tabControl.TabPages[i].Name == name)
                {
                    //Zet de pagina naar de index i.
                    Move(i);

                    //Stop de loop, want we hebben de goede pagina gevonden.
                    break;
                }
            }
        }


        /// <summary>
        ///     Functie die kijkt of de pagina veranderd mag worden. 
        ///     Geeft de interne variable terug, zodat de gebruiker dit niet handmatig kan aanpassen).
        /// </summary>
        /// <returns>De interne variabel allowChange</returns>
        public bool AllowChange()
        {
            return allowChange;
        }
    }
}
