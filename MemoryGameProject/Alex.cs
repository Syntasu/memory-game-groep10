using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Alex : Form
    {
        public Alex()
        {
            InitializeComponent();
        }

        private void Alex_Load(object sender, System.EventArgs e)
        {

        }

        private void Alex_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                MovePageRight();
            }
            else if(e.KeyCode == Keys.A)
            {
                MovePageLeft();
            }
        }

        private void MovePageLeft()
        {

        }

        private void MovePageRight()
        {

        }



    }
}
