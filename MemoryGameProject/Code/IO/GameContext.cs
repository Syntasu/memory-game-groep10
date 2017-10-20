using MemoryGameProject.Code.Game;
using System;
using System.Diagnostics;

namespace MemoryGameProject.Code.IO
{
    [Serializable]
    public class GameContext
    {
        public PlayerListContext playerListContext;
        public TurnControllerContext turnControllerContext;
        public CardControllerContext cardControllerContext;

        public GameContext(PlayerList playerList, TurnController turnController, CardController cardController)
        {
            playerListContext = playerList.GetContext();
            turnControllerContext = turnController.GetContext();
        }
    }


    [Serializable]
    public class TurnControllerContext
    {
        public int turnTimeInSeconds;
        public Stopwatch turnTimer;
        public int currentPlayerId;

        public TurnControllerContext(int turnTimeInSeconds, Stopwatch turnTimer, int currentPlayerId)
        {
            this.turnTimeInSeconds = turnTimeInSeconds;
            this.turnTimer = turnTimer;
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
