using MemoryGameProject.Code.Game;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MemoryGameProject.Code.IO
{ 

    [Serializable]
    public class GameContext
    {
        public PlayerListContext playerListContext;
        public TurnControllerContext turnControllerContext;
        public CardControllerContext cardControllerContext;

        public GameContext() { }

        public GameContext(PlayerList playerList, TurnController turnController, CardController cardController)
        {
            playerListContext = playerList.GetContext();
            turnControllerContext = turnController.GetContext();
            cardControllerContext = cardController.GetContext();
        }

        public byte[] Serialize()
        {
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    return stream.ToArray();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Kan het spel niet opslaan: " + e.Message, "Woops");
                throw;
            }
        }

        public GameContext Deserialize(byte[] data)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream(data))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (GameContext)formatter.Deserialize(stream);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Kan het opgeslagen spel niet laden: " + e.Message, "Woops");
                return null;
            }
        }
    }

    [Serializable]
    public class TurnControllerContext
    {
        public int turnTimeInSeconds;
        //public Stopwatch turnTimer;
        public int currentPlayerId;

        public TurnControllerContext(int turnTimeInSeconds, int currentPlayerId)
        {
            this.turnTimeInSeconds = turnTimeInSeconds;
            //this.turnTimer = turnTimer;
            this.currentPlayerId = currentPlayerId;
        }
    }

    [Serializable]
    public class PlayerListContext
    {
        public Player[] players;

        public PlayerListContext(Player[] players)
        {
            this.players = players;
        }
    }

    [Serializable]
    public class CardControllerContext
    {
        public Card[,] cards;

        public CardControllerContext(Card[,] cards)
        {
            this.cards = cards;
        }
    }
}
