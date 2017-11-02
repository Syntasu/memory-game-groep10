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
                using (FileStream fileStream = File.Open(SaveGamePath, FileMode.OpenOrCreate))
                {
                    using (BinaryWriter writer = new BinaryWriter(fileStream))
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
            try
            {
                using (FileStream fileStream = File.Open(SaveGamePath, FileMode.OpenOrCreate))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        GameContext context = new GameContext();

                        byte[] data = binaryReader.ReadBytes((int)fileStream.Length);
                        return context.Deserialize(data);
                    }
                }
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
