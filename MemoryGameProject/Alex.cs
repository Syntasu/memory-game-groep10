using MemoryGameProject.Code;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Alex : Form
    {
        public Alex()
        {
            InitializeComponent();
        }

        private PageController pageController;

        private void Alex_Load(object sender, System.EventArgs e)
        {
            pageController = new PageController(tabControl1, 0);
            pageController.ShowPage("BANANAS");
        }

    }
}
