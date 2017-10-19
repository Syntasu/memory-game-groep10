using System;
using System.Windows.Forms;

namespace MemoryGameProject.Code
{
    public class PageController
    {
        public static string PAGE_HOOFDMENU = "hoofdMenuPage";
        public static string PAGE_SPEL = "spelPage";
        public static string PAGE_SPEL_END = "gameOverPage";
        public static string PAGE_HIGHSCORE = "highScorePage";

        public int CurrentSelected = 0;

        private TabControl tabControl;
        private bool allowChange;

        public PageController(TabControl tabControl, int startIndex)
        {
            this.tabControl = tabControl;
            CurrentSelected = startIndex;

            Move(CurrentSelected);
        }

        private void Move(int index)
        {
            allowChange = true;
            tabControl.SelectedIndex = index;
            allowChange = false;
        }

        public void ShowPage(string name)
        {
            int index = 0;
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if(tabControl.TabPages[i].Name == name)
                {
                    Move(i);
                    break;
                }
            }
        }

        public bool AllowChange()
        {
            return allowChange;
        }

        public void Update()
        {
            if(tabControl.SelectedIndex != CurrentSelected)
            {
                Move(CurrentSelected);
            }
        }

    }
}
