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
    }
}
