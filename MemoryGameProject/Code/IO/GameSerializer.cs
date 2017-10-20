using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoryGameProject.Code.IO
{
    public class GameSerializer
    {
        public static byte[] SerializePlayerList(Player[] players)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, players);

                return stream.ToArray();
            }
        }

        public static Player[] DeserializePlayerList(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Player[])formatter.Deserialize(stream);
            }
        }

        public static byte[] SerializeCardController(Card[,] cards)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, cards);

                return stream.ToArray();
            }
        }

        public static Card[,] DeserializeCardController(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Card[,])formatter.Deserialize(stream);
            }
        }
    }
}
