using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoryGameProject.Code.IO
{
    public class GameSerializer
    {
        public static byte[] SerializePlayerList(PlayerListContext context)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, context);

                return stream.ToArray();
            }
        }

        public static PlayerListContext DeserializePlayerList(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (PlayerListContext)formatter.Deserialize(stream);
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
