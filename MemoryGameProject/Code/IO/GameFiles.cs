using System;
using System.IO;

namespace MemoryGameProject.Code.IO
{
    public class GameFiles
    {
        /// <summary>
        ///     De path naar al onze data.
        /// </summary>
        static string DefaultPath = AppDomain.CurrentDomain.BaseDirectory + @"memory/";

        /// <summary>
        ///     De naam en extensie van onze savegame file.
        /// </summary>
        static string SaveGameFileName = "game.sav";

        /// <summary>
        ///     Volledige path naar de save game file.
        /// </summary>
        static string SaveGamePath = DefaultPath + SaveGameFileName;

        /// <summary>
        ///     Static constructor die er voor zorgt dat save game path bestaat of aanmaakt.
        /// </summary>
        static GameFiles()
        {
            bool baseFolderExists = Directory.Exists(DefaultPath);

            if(!baseFolderExists)
            {
                Directory.CreateDirectory(DefaultPath);
            }
        }

        /// <summary>
        ///     Controleert of de save game al bestaat.
        /// </summary>
        /// <returns></returns>
        public static bool HasSaveGame()
        {
            return File.Exists(DefaultPath + SaveGameFileName);
        }

        /// <summary>
        ///     Maakt of overschrijf de huidige save game bestand.
        /// </summary>
        /// <param name="data"> De data die we willen schrijven naar de schijf. </param>
        /// <returns>Een boolean, true = OK, false = FAIL.</returns>
        public static bool WriteSaveGame(byte[] data)
        {
            try
            {
                //Open of maak een nieuwe bestand aan d.m.v. een file stream./
                using (FileStream fileStream = File.Open(SaveGamePath, FileMode.OpenOrCreate))
                {
                    // Gebruik de binary writer om alle data in binair naar de file stream te schrijven.
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

        /// <summary>
        ///     Laad data in van de schijf.
        /// </summary>
        /// <returns> De game context die van de schijf gelezen is.</returns>
        public static GameContext LoadSaveGame()
        {
            try
            {
                //Lees de data vanuit de file stream.
                using (FileStream fileStream = File.Open(SaveGamePath, FileMode.OpenOrCreate))
                {
                    //Gebruik de BinaryReader om de data uit te lezen.
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        //Maak een nieuwe context
                        GameContext context = new GameContext();

                        //Verkrijg de data en gebruik de aangemaakte context om de deserializen.
                        byte[] data = binaryReader.ReadBytes((int)fileStream.Length);
                        return context.Deserialize(data);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
