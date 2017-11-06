using MemoryGameProject.Code.Game;
using System;
using System.Collections.Generic;

namespace MemoryGameProject.Code.IO
{
    [Serializable]
    public class HighscoreListItem
    {
        public string name;
        public int wins;
        public int score;

        public HighscoreListItem(string name, int wins, int score)
        {
            this.name = name;
            this.wins = wins;
            this.score = score;
        }

        public void Update(Player player, bool isWinner)
        {
            if(player.name.Equals(name, StringComparison.CurrentCulture))
            {
                score += player.score;

                if(isWinner)
                {
                    wins++;
                }
            }
        }
    }

    [Serializable]
    public class HighscoreContext
    {
        public List<HighscoreListItem> HighscoreItems;

        public HighscoreContext()
        {
            HighscoreItems = new List<HighscoreListItem>();
        }

        public bool ContainsPlayer(Player player)
        {
            for (int i = 0; i < HighscoreItems.Count; i++)
            {
                if(HighscoreItems[i].name.Equals(player.name, StringComparison.CurrentCulture))
                {
                    return true;
                }
            }

            return false;
        }

        public HighscoreListItem GetItem(Player player)
        {
            for (int i = 0; i < HighscoreItems.Count; i++)
            {
                if (HighscoreItems[i].name.Equals(player.name, StringComparison.CurrentCulture))
                {
                    return HighscoreItems[i];
                }
            }

            return null;
        }


        public byte[] Serialize()
        {
            return GameFiles.Serialize(this);
        }

        public void Deserialize(byte[] data)
        {
            HighscoreContext context = (HighscoreContext)GameFiles.Deserialize(data);
            HighscoreItems = context.HighscoreItems;
        }
    }
}
