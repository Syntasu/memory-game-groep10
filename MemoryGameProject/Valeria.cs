using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap[] achterkanten = new Bitmap[8];
            achterkanten[0] = Properties.Resources.sw0;
            achterkanten[1] = Properties.Resources.sw1;
            achterkanten[2] = Properties.Resources.sw2;
            achterkanten[3] = Properties.Resources.sw3;
            achterkanten[4] = Properties.Resources.sw4;
            achterkanten[5] = Properties.Resources.sw5;
            achterkanten[6] = Properties.Resources.sw6;
            achterkanten[7] = Properties.Resources.sw7;

            Kaart[,] kaarten = new Kaart[4, 4];
            kaarten[0, 0] = new Kaart(0, 0, pictureBox1);
            kaarten[0, 1] = new Kaart(0, 1, pictureBox2);
            kaarten[0, 2] = new Kaart(0, 2, pictureBox3);
            kaarten[0, 3] = new Kaart(0, 3, pictureBox4);
            kaarten[1, 0] = new Kaart(1, 0, pictureBox8);
            kaarten[1, 1] = new Kaart(1, 1, pictureBox7);
            kaarten[1, 2] = new Kaart(1, 2, pictureBox6);
            kaarten[1, 3] = new Kaart(1, 3, pictureBox5);
            kaarten[2, 0] = new Kaart(2, 0, pictureBox12);
            kaarten[2, 1] = new Kaart(2, 1, pictureBox11);
            kaarten[2, 2] = new Kaart(2, 2, pictureBox10);
            kaarten[2, 3] = new Kaart(2, 3, pictureBox9);
            kaarten[3, 0] = new Kaart(3, 0, pictureBox16);
            kaarten[3, 1] = new Kaart(3, 1, pictureBox15);
            kaarten[3, 2] = new Kaart(3, 2, pictureBox14);
            kaarten[3, 3] = new Kaart(3, 3, pictureBox13);
            // kaarten[0, 0] = new kaart(0,0) 
            Random rand = new Random();
            int[] picked = new int[8];
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    bool haspicked = false;
                    int kaart = rand.Next(0, 8);
                    while (!haspicked)
                    {
                        if (picked[kaart] <= 1)
                        {
                            kaarten[x, y].Achterkant = kaart;
                            kaarten[x, y].Pictures.Image = achterkanten[kaart];
                            picked[kaart]++;
                            haspicked = true;
                        }
                        else
                        {
                            kaart = rand.Next(0, 8);
                        }
                    }

                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}

