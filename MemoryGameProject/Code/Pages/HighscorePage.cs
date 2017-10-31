using System.Collections.Generic;
using System.IO;
using System.Linq;
using MemoryGameProject;
using System;

namespace MemoryGameProject.Code.Pages
{
    /// <summary>
    ///     Klasse die alle functionaliteit heeft met betrekking tot de highscore lijst. 
    /// </summary>
    public class  HighScorePage
    {
        private string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //constructor
        public HighScorePage()
        {
            LaadHighscoreLijst();
        }

        private List<KeyValuePair<string, int>> highscoreLijst = new List<KeyValuePair<string, int>>();

        public List<KeyValuePair<string, int>> HighscoreLijst { get => highscoreLijst; set => highscoreLijst = value; }

        public void LaadHighscoreLijst()
        {
            
            
            if (File.Exists(path+ "\\highscoreLijst.txt"))
            {
                
                string[] highscoreString = File.ReadAllLines(path + "\\highscoreLijst.txt");
                for (int i = 0; i < 6; i++)
                {
                    highscoreString[i] = highscoreString[i].Trim('[', ']');
                    string[] tempString = highscoreString[i].Split(',');
                    
                    highscoreLijst.Add(new KeyValuePair<string, int>(tempString[0], Convert.ToInt16(tempString[1])));
                    
                }
                MainForm.SetHighscores(HighscoreLijst);
                
            }
            else
            {

                for (int i = 0; i < 6; i++)
                {
                    HighscoreLijst.Add(new KeyValuePair<string, int>("Speler " + (i + 1), 0));
                }
                File.WriteAllLines(path + "\\highscoreLijst.txt", HighscoreLijst.Select(s => s.ToString()));
             
            }
        }

        public void checkHighscore(string player1Name, int player1Score)
        {
            foreach (KeyValuePair<string, int> keyValue in HighscoreLijst)
            {
                if (player1Score > keyValue.Value)
                {
                    HighscoreLijst.Add(new KeyValuePair<string, int>( player1Name, player1Score));
                    HighscoreLijst = HighscoreLijst.OrderByDescending(x => x.Value).ToList();
                    HighscoreLijst.RemoveAt(5);
                 
                    MainForm.SetHighscores(HighscoreLijst);
                    
                    break;
                    
                }
            }
            File.WriteAllLines(path + "\\highscoreLijst.txt", HighscoreLijst.Select(s => s.ToString()));
        }

        public void checkHighscore(string player1Name, int player1Score, string player2Name, int player2Score)
        {
            foreach (KeyValuePair<string, int> keyValue in HighscoreLijst)
            {
                if (player1Score > keyValue.Value)
                {
                    HighscoreLijst.Add(new KeyValuePair<string, int>( player1Name, player1Score));
                    HighscoreLijst = HighscoreLijst.OrderByDescending(x => x.Value).ToList();
                    HighscoreLijst.RemoveAt(5);
                    MainForm.SetHighscores(HighscoreLijst);
                    break;

                }
            }

            foreach (KeyValuePair<string, int> keyValue in HighscoreLijst)
            {
                if (player2Score > keyValue.Value)
                {
                    HighscoreLijst.Add(new KeyValuePair<string, int>(player2Name, player2Score));
                    HighscoreLijst = HighscoreLijst.OrderByDescending(x => x.Value).ToList();
                    HighscoreLijst.RemoveAt(5);
                    MainForm.SetHighscores(HighscoreLijst);
                    break;

                }
            }
            File.WriteAllLines(path + "\\highscoreLijst.txt", HighscoreLijst.Select(s => s.ToString()));
        }
    }

}

