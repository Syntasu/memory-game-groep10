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
    }

    [Serializable]
    public class HighscoreContext
    {
        public List<HighscoreListItem> HighscoreItems;

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
