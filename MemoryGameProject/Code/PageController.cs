using System;
using System.Windows.Forms;

namespace MemoryGameProject.Code
{
    public class PageController
    {
        public static string PAGE_HOOFDMENU = "hoofdMenuPage";
        public static string PAGE_SPEL = "spelPage";
        public static string PAGE_HIGHSCORE = "highScorePage";

        public int CurrentSelected = 0;

        private TabControl tabControl;

        public PageController(TabControl tabControl, int startIndex)
        {
            this.tabControl = tabControl;
            CurrentSelected = startIndex;

            Move(CurrentSelected);
        }

        public void Move(int index)
        {
            tabControl.SelectedIndex = index;
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

    }
}
