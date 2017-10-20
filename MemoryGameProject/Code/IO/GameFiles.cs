using System;
using System.IO;
using System.Windows.Forms;

namespace MemoryGameProject.Code.IO
{
    public class GameFiles
    {
        static string DefaultPath = AppDomain.CurrentDomain.BaseDirectory + @"memory";

        public GameFiles()
        {
            bool baseFolderExists = Directory.Exists(DefaultPath);

            if(!baseFolderExists)
            {
                Directory.CreateDirectory(DefaultPath);
            }
        }

        public bool HasSaveGame()
        {
            return File.Exists(DefaultPath + "/game.sav");
        }

        public GameState ReadSaveGame()
        {
            return new GameState(new byte[0]);
        }

        public void WriteSaveGame(GameState gameState)
        {

        }
    }
}
