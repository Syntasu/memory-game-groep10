using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check every icon to see if it is matched, by 
        /// comparing its foreground picture to its background picture. 
        /// If all of the icons are matched, the player wins
        /// </summary>
        private void CheckForWinner()
        {
            // Go through all of the labels in the Memory Game Project, 
            // checking each one to see if its icon is matched
            //foreach (Control control in MemoryGameProject.Controls)
            //{
            //    Label iconLabel = control as Label;

            //    if (iconLabel != null)
            //    {
            //        if (iconLabel.ForeColor == iconLabel.BackColor)
            //            return;
            //    }
            //}

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            MessageBox.Show("Je bent de winnaar!", "Gefeliciteerd!");

        }
    }
}

   
