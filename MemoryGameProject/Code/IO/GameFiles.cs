using System;
using System.IO;

namespace MemoryGameProject.Code.IO
{
    public class GameFiles
    {
        static string DefaultPath = AppDomain.CurrentDomain.BaseDirectory + @"memory/";
        static string SaveGameFileName = "game.sav";
        static string SaveGamePath = DefaultPath + SaveGameFileName;

        static GameFiles()
        {
            bool baseFolderExists = Directory.Exists(DefaultPath);

            if(!baseFolderExists)
            {
                Directory.CreateDirectory(DefaultPath);
            }
        }

        public static bool HasSaveGame()
        {
            return File.Exists(DefaultPath + SaveGameFileName);
        }

        public static bool WriteSaveGame(byte[] data)
        {
            try
            {
                using (FileStream file = File.Open(SaveGamePath, FileMode.OpenOrCreate))
                {
                    using (BinaryWriter writer = new BinaryWriter(file))
                    {
                        writer.Write(data);
                        return true;
                    }
                }
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static GameContext LoadSaveGame()
        {
            //try
            //{
            //    using (StreamReader fileReader = new StreamReader(DefaultPath + SaveGameFileName))
            //    {
            //        GameContext resultingContext = new GameContext();

            //        BinaryReader binaryReader = new BinaryReader(fileReader.BaseStream);
            //        byte[] data = binaryReader.ReadBytes((int)fileReader.BaseStream.Length);

            //        return resultingContext.Deserialize(data);
            //    }
            //}
            //catch(Exception)
            //{
            //}
            return null;
        }
    }
}
