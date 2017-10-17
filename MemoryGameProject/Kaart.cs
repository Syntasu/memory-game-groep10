using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public class Kaart
    {
        public int X;
        public int Y;
        public PictureBox Pictures;
        public int Achterkant;

        public Kaart(int x, int y, PictureBox pictures)
        {
            X = x;
            Y = y;
            Pictures = pictures;
        }
    }
}
