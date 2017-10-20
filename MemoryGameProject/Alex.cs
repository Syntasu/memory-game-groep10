using MemoryGameProject.Code;
using MemoryGameProject.Code.IO;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Alex : Form
    {
        public Alex()
        {
            InitializeComponent();
        }

        private GameFiles gameFiles;

        private void Alex_Load(object sender, System.EventArgs e)
        {
            gameFiles = new GameFiles();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
        }
    }
}
