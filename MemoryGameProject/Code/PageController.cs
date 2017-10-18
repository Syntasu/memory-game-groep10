using System;
using System.Windows.Forms;

namespace MemoryGameProject.Code
{
    public class PageController
    {
        private TabControl tabControl;

        public PageController(TabControl tabControl)
        {
            this.tabControl = tabControl;
        }

        public void Move(int index)
        {
            tabControl.SelectedIndex = index;
        }

    }
}
