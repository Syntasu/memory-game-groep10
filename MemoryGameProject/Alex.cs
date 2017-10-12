using MemoryGameProject.Code.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Alex : Form
    {
        private TurnControllerTest turnControllerTest;

        public Alex()
        {
            InitializeComponent();
            turnControllerTest = new TurnControllerTest(turnTimer);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Beurt:" + turnControllerTest.Get();
        }

        private void onTurnTick(object sender, EventArgs e)
        {

        }
    }
}
