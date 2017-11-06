using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoryGameProject.Code.IO
{
    public class GameFiles
    {
        /// <summary>
        ///     De path naar al onze data.
        /// </summary>
        static string DefaultPath = AppDomain.CurrentDomain.BaseDirectory + @"memory/";

        /// <summary>
        ///     Volledige path naar de save game file.
        /// </summary>
        static string SaveGamePath = DefaultPath + "game.sav";

        /// <summary>
        ///     Volledige path naar de highscore lijst
        /// </summary>
        static string HighScoreListPath = DefaultPath + "highscores.sav";

        /// <summary>
        ///     Static constructor die er voor zorgt dat save game path bestaat of aanmaakt.
        /// </summary>
        static GameFiles()
        {
            //Check if the file exists.
            bool baseFolderExists = Directory.Exists(DefaultPath);

            if(!baseFolderExists)
            {
                Directory.CreateDirectory(DefaultPath);
            }
        }

        /// <summary>
        ///     Controleert of de save game al bestaat.
        /// </summary>
        public static bool HasSaveGame()
        {
            return File.Exists(SaveGamePath);
        }

        /// <summary>
        ///     Controleert of de highscore lijst al bestaat.
        /// </summary>
        public static bool HasHighscoreList()
        {
            return File.Exists(HighScoreListPath);
        }

        /// <summary>
        ///     Maak of overschrijf de huidige save game bestand.
        /// </summary>
        /// <param name="data"> De data die we willen schrijven naar de schijf. </param>
        /// <returns>Een boolean, true = OK, false = FAIL.</returns>
        public static bool CreateSaveGame(GameContext context)
        {
            return WriteBinaryFile(SaveGamePath, context.Serialize());
        }

        /// <summary>
        ///     Maak of overschrijf de highscore bestand.
        /// </summary>
        /// <param name="data"> Data van de highscore lijst. </param>
        /// <returns>Een boolean, true = OK, false = FAIL.</returns>
        public static bool CreateHighScoreList(HighscoreContext context)
        {
            return WriteBinaryFile(HighScoreListPath, context.Serialize());
        }

        /// <summary>
        ///     Laad data in van de schijf.
        /// </summary>
        /// <returns> De game context die van de schijf gelezen is.</returns>
        public static GameContext LoadSaveGame()
        {
            //Vraag byte data op.
            byte[] data = LoadBinaryFile(SaveGamePath);

            //Decodeer de bytes die we hebben opgevraagt
            return (GameContext)Deserialize(data);
        }

        /// <summary>
        ///     Laad de highscore context vanaf de schijf.
        /// </summary>
        /// <returns></returns>
        public static HighscoreContext LoadHighscore()
        {
            //Vraag byte data op.
            byte[] data = LoadBinaryFile(HighScoreListPath);

            //Decodeer de bytes die we hebben opgevraagt
            return (HighscoreContext)Deserialize(data);
        }

        /// <summary>
        ///     Leest een binaire bestand van schijf.
        /// </summary>
        /// <param name="path">De path waar het bestand is.</param>
        /// <returns>De byte data.</returns>
        private static byte[] LoadBinaryFile(string path)
        {
            try
            {
                //Lees de data vanuit de file stream.
                using (FileStream fileStream = File.Open(path, FileMode.OpenOrCreate))
                {
                    //Gebruik de BinaryReader om de data uit te lezen.
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        //Verkrijg de data en gebruik de aangemaakte context om de deserializen.
                        return binaryReader.ReadBytes((int)fileStream.Length);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///     Schrijft een binair bestand.
        /// </summary>
        /// <param name="path"> De path waar het bestand komt te staan. </param>
        /// <param name="data"> De data die in het bestand moet.</param>
        /// <returns>True of false op basis of deze operatie is gelukt.</returns>
        private static bool WriteBinaryFile(string path, byte[] data)
        {
            try
            {
                //Open of maak een nieuwe bestand aan d.m.v. een file stream./
                using (FileStream fileStream = File.Open(path, FileMode.OpenOrCreate))
                {
                    // Gebruik de binary writer om alle data in binair naar de file stream te schrijven.
                    using (BinaryWriter writer = new BinaryWriter(fileStream))
                    {
                        writer.Write(data);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        ///     Zet een klasse om in bytes die we naar de schijf kunnen scrhijven.
        /// </summary>
        /// <param name="objToSerialize"> Het object die we willen omzetten. </param>
        /// <returns> De bytes van het object. </returns>
        public static byte[] Serialize(object objToSerialize)
        {
            try
            {
                //Maak een nieuwe stream...
                using (MemoryStream stream = new MemoryStream())
                {
                    //Gebruik de binary formatter om de byte array te genereren die we kunnen opslaan.
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, objToSerialize);
                    return stream.ToArray();
                }
            }
            catch (Exception)
            {
                return new byte[0];
            }
        }

        /// <summary>
        ///     Zet de gegeven bytes om in een object.
        /// </summary>
        /// <param name="data"> De data die we willen om zetten.</param>
        /// <returns>Het object wat uit de bytes komt.</returns>
        public static object Deserialize(byte[] data)
        {
            try
            {
                //Maak een nieuwe stream aan en zet de bytes die we van de file geladen hebben er in.
                using (MemoryStream stream = new MemoryStream(data))
                {
                    //Gebruik de binaryformatter om de bytes om te zetten naar een GameContext.
                    BinaryFormatter formatter = new BinaryFormatter();
                    return formatter.Deserialize(stream);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
