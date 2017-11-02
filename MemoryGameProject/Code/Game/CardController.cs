using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace MemoryGameProject.Code.Game
{
    /// <summary>
    ///     Klasse die alle functionaliteit van de kaarten heeft.
    /// </summary>
    public class CardController
    {
        /// <summary>
        ///     Referentie naar de turn controller.
        /// </summary>
        private TurnController turnController;

        /// <summary>
        ///     Referentie naar de turn controller.
        /// </summary>
        private PlayerList playerList;

        /// <summary>
        ///     Referntie naar het speelveld.
        /// </summary>
        private PlayingField playingField;

        /// <summary>
        ///     De timeout zorgt er voor dat de kaarten even op het scherm blijven staan.
        ///     Als de timeout true is, dan zijn we aan het wachten tot dat de kaarten weer omgedraaid worden.
        /// </summary>
        private bool timeout;

        /// <summary>
        ///     De timer control die we gebruiken om de tijd te laten verstrijken. 
        /// </summary>
        private Timer timeoutTimer;

        /// <summary>
        ///     Variable die zegt hoevaak per beurt je een kaart mag omdraaien.
        /// </summary>
        private int maxGuesses = 2;

        /// <summary>
        ///     Een lijst met alle kaarten die zij geraden tijdens een beurt.
        /// </summary>
        private List<Card> guessedCards = new List<Card>();

        public CardController(PlayingField playingField, Timer timeoutTimer,
            int maxGuesses, TurnController turnController, PlayerList playerList)
        {
            this.playingField = playingField;
            this.playingField.Shuffle();

            this.turnController = turnController;
            this.playerList = playerList;
            this.timeoutTimer = timeoutTimer;
            this.maxGuesses = maxGuesses;

            Update();
        }

        /// <summary>
        ///     Functie die aangeroepen word wanneer 
        /// </summary>
        /// <param name="obj">object die in de event word mee gegeven.</param>
        public void CardClicked(object obj)
        {
            //Zoek de kaart via de FindCard methode.
            Card card = FindCard(obj);

            /*
             * Als de kaart null is willen een exceptie geven.
             * Dit betekend dat de picture box die we willen opvragen,
             * niet gelinkt is aan een kaart object.
             */
            if (card == null)
            {
                throw new Exception("Gegeven object is niet een onderdeel van de kaart array.");
            }

            //Als de kaart is geraden, dan moet je een nieuwe kaart pakken.
            if (card.isGuessed)
            {
                MessageBox.Show("De kaart is al geraden, probeer opnieuw");
                return;
            }

            //Controleer of de kaart al omgedraaid is.
            for (int i = 0; i < guessedCards.Count; i++)
            {
                if (card == guessedCards[i])
                {
                    MessageBox.Show("De kaart is al omgedraaid, probeer opnieuw");
                    return;
                }
            }

            /*
             * Als timeout true is, dan zijn we aan het wachten tot de kaarten weer worden omgedraaid
             * Dat betekent ook dat er geen kaart kan gekozen worden.
             */
            if (timeout)
            {
                return;
            }

            //Voer alle logica uit m.b.t. kaart klik.
            HandleCardClick(card);
        }

        /// <summary>
        ///     Methode die de logica van kaarten klikken afhandelt.
        /// </summary>
        /// <param name="card">De kaart die geklikt is.</param>
        private void HandleCardClick(Card card)
        {
            Console.WriteLine("CLICK");

            //Controleer of we nog kaarten kunnen kiezen, of we aan de limiet voor het max aantal keer raden zitten.
            if (guessedCards.Count < maxGuesses)
            {
                //Laat de voorkant van de kaart zien.
                card.isFlipped = true;

                //Speel geluid af als je op kaart klikt.
                SoundPlayer clicksound = new SoundPlayer(Properties.Resources.geluid2);
                clicksound.Play();

                //Kijk of we een match hebben.
                bool match = CheckForMatch(card);

                /*
                 * Als we een match hebben...
                 * Dan willen meteen alles reseten.
                 */
                if (match)
                {
                    int playerId = turnController.CurrentPlayerId;
                    Player player = playerList.GetPlayerById(playerId);
                    player.score++;
                }

                //Voeg de kaart toe aan de geraden kaarten.
                guessedCards.Add(card);
            }
            
            //Controleer of we de maximaal aantal geraden is bereikt.
            if(guessedCards.Count == maxGuesses)
            {
                /*
                 * We willen een x aantal milliseconden wachten voor dat we de kaarten weer willen omdraaien.
                 * Dit doen we door timeout op true te zetten en de timer te laten starten.
                */
                timeout = true;
                timeoutTimer.Start();
                Console.WriteLine("WAIT");
            }
        }

        /// <summary>
        ///     Controleert of de gegeven kaart id (argument) al eerder is geklikt.
        /// </summary>
        /// <param name="card">De kaart die we willen controleren op een match.</param>
        /// <returns>Returned true als we een match hebben en false als we geen match hebben.</returns>
        private bool CheckForMatch(Card card)
        {
            //Als we 1 kaart hebben kunnen we nooit een match hebben.
            if (guessedCards.Count == 0) return false;

            /*
             1) Loop over de array
             2) Sla de kaart over die we willen checken.
             3) Kijk of er een kaart is met het zelfde front id als de kaart uit het argument.
             4) Zo ja, return true, want we hebben een match.
             */
            for (int i = 0; i < guessedCards.Count; i++)
            {
                if (guessedCards[i] == card)
                {
                    continue;
                }

                if (guessedCards[i].front == card.front)
                {
                    //Zet beide kaarten naar geraden.
                    card.isGuessed = true;
                    guessedCards[i].isGuessed = true;

                    //Speel geluid af als je goed geraden hebt.
                    SoundPlayer matchsound = new SoundPlayer(Properties.Resources.geluid1);
                    matchsound.Play();

                    return true;
                }
            }

            //We zijn door de hele array heen gegaan en hebben geen matchende kaarten gevonden. 
            return false;
        }

        /// <summary>
        ///     Zoek een kaart uit de kaarten array met een gegeven picturebox.
        /// </summary>
        /// <param name="obj">De picturebox waarnaar we willen zoeken.</param>
        /// <returns>Geeft een kaart object terug als er iets gevonden is. Null als er niks gevonden word.</returns>
        public Card FindCard(object obj)
        {
            //Zet obj om in een picture box.
            PictureBox pictureBox = null;

            //Controleer of het "object" van de type "PictureBox" is.
            if (obj.GetType().IsAssignableFrom(typeof(PictureBox)))
            {
                pictureBox = obj as PictureBox;
            }
            else
            {
                throw new Exception("Gegeven object is geen kaart!");
            }

            int x = -1;
            int y = -1;

            playingField.GetCoordinates(pictureBox, out x, out y);
            return playingField.GetCardAt(x, y);
        }


        /// <summary>
        ///     Reset de geraden kaarten en alle variabelen die er mee te maken hebben.
        /// </summary>
        public void ResetGuesses()
        {
            Console.WriteLine("RESET");

            //Flip alle kaarten weer op die de gebruiker heeft geraden.
            for (int i = 0; i < guessedCards.Count; i++)
            {
                guessedCards[i].isFlipped = false;
            }

            //Reset alle geraden kaarten.
            guessedCards.Clear();

            //Ga naar de volgende beurt.
            turnController.NextTurn();

            //Zeg dat we hebben gewacht totdat de timer afgelopen is.
            timeout = false;

            //Stop de timer.
            timeoutTimer.Stop();
        }

        /// <summary>
        ///     Functie die controleert of het spel uitgespeeld is.
        /// </summary>
        /// <returns>Een bool, true als alle kaarten geraden zijn en false als dit niet zo is.</returns>
        public bool CheckEndOfGame()
        {
            //Loop over alle kaarten heen.
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Card card = playingField.GetCardAt(x, y);

                    //Als 1 kaart niet geraden is, dan is het spel niet over.
                    if (!card.isGuessed)
                    {
                        return false;
                    }
                }
            }

            // geluid bij het uitspelen van het spel
            SoundPlayer Finishsound = new SoundPlayer(Properties.Resources.geluid6);
            Finishsound.Play();

            return true;
        }

        /// <summary>
        ///     Update alle kaarten.
        /// </summary>
        public void Update()
        {
            //Loop over de kaarten heen.
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    //Vind de kaart op de coordinaat.
                    Card card = playingField.GetCardAt(x,y);

                    //Als de kaart null is, sla over.
                    if(card == null)
                    {
                        continue;
                    }

                    //Als de kaart geflipt is, laat de voorkant zien.
                    if(card.isFlipped)
                    {
                        ShowCardFront(card);
                        continue;
                    }

                    //Als de kaart geraden is, laat de voorkant zien.
                    if (card.isGuessed)
                    {
                        ShowCardFront(card);
                        continue;
                    }

                    //Anders laat de achterkant zien.
                    ShowCardBack(card);
                }
            }
        }

        /// <summary>
        ///     Laat de voorkant van de kaart zien.
        /// </summary>
        /// <param name="card">De kaart die we willen omdraaien.</param>
        public void ShowCardFront(Card card)
        {
            //Vind de picture box die bij de kaart hoort.
            PictureBox pb = playingField.GetPictureBox(card.X, card.Y);

            //Vind de voorkant van de kaart d.m.v. een id.
            Bitmap front = playingField.GetFrontImageById(card.front);

            //Zet het plaatje naar de voorkant.
            pb.Image = front;
        }

        /// <summary>
        ///     Laat de achterkant van de kaart zien.
        /// </summary>
        /// <param name="card"> De kaart die we de achterkant willen laten zien.</param>
        public void ShowCardBack(Card card)
        {
            //Vind de picture box die bij de kaart hoort.
            PictureBox pb = playingField.GetPictureBox(card.X, card.Y);

            //Vind de achterkant van de kaart.
            Bitmap back = playingField.GetBackImage();

            //Zet het plaatje naar de achterkant.
            pb.Image = back;
        }
    }
}
