using MemoryGameProject.Code.Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MemoryGameProject.Code.IO
{ 
    /// <summary>
    ///     Een klasse die alle data van een "spel" bevat.
    /// </summary>
    [Serializable]
    public class GameContext
    {
        public PlayerListContext playerListContext;
        public TurnControllerContext turnControllerContext;
        public PlayingFieldContext playingFieldContext;
        public CardControllerContext cardControllerContext;

        public GameContext() { }

        public GameContext(PlayerList playerList, TurnController 
            turnController, CardController cardController, PlayingField playingField)
        {
            playerListContext = playerList.GetContext();
            turnControllerContext = turnController.GetContext();
            playingFieldContext = playingField.GetContext();
            cardControllerContext = cardController.GetContext();
        }

        /// <summary>
        ///     Methode om de GameContext omtezetten naar iets wat kan worden opgeslagen op de schijf.
        /// </summary>
        /// <returns> Een byte array met alle data. </returns>
        public byte[] Serialize()
        {
            return GameFiles.Serialize(this);
        }

        /// <summary>
        ///     Methode om GameContext te maken vanuit de gegeven bytes.
        /// </summary>
        /// <param name="data"></param>
        public void Deserialize(byte[] data)
        {
            GameContext ctx = (GameContext)GameFiles.Deserialize(data);

            playerListContext = ctx.playerListContext;
            turnControllerContext = ctx.turnControllerContext;
            cardControllerContext = ctx.cardControllerContext;
            playingFieldContext = ctx.playingFieldContext;
        }
    }

    [Serializable]
    public class TurnControllerContext
    {
        public int turnTimeInSeconds;
        public int currentPlayerId;

        public TurnControllerContext(int turnTimeInSeconds, int currentPlayerId)
        {
            this.turnTimeInSeconds = turnTimeInSeconds;
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
    public class PlayingFieldContext
    {
        public int width;
        public int height;
        public Card[,] cards;

        public PlayingFieldContext(int width, int height, Card[,] cards)
        {
            this.width = width;
            this.height = height;
            this.cards = cards;
        }
    }

    [Serializable]
    public class CardControllerContext
    {
        public int maxGuesses;
        public List<Card> guessedCards;

        public CardControllerContext(List<Card> guessedCards, int maxGuesses)
        {
            this.guessedCards = guessedCards;
            this.maxGuesses = maxGuesses;

        }
    }


}
