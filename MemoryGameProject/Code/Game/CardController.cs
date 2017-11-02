using MemoryGameProject.Code.IO;
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
        ///     Array van kaart objecten.
        /// </summary>
        private Card[,] cards;

        /// <summary>
        ///     Array met alle voorkanten van de kaarten.
        /// </summary>
        private Bitmap[] cardFronts;

        /// <summary>
        ///     Bitmap met de achterkant van de kaarten.
        /// </summary>
        private Bitmap cardBack;

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

        public CardController(Card[,] cards, Bitmap[] cardFronts, Bitmap cardBack, Timer timeoutTimer, 
            int maxGuesses, TurnController turnController, PlayerList playerList )
        {
            this.turnController = turnController;
            this.playerList = playerList;
            this.cards = cards;
            this.cardFronts = cardFronts;
            this.cardBack = cardBack;
            this.timeoutTimer = timeoutTimer;
            this.maxGuesses = maxGuesses;
        }

        /// <summary>
        ///     Functie die aangeroepen word wanneer 
        /// </summary>
        /// <param name="obj">object die in de event word mee gegeven.</param>
        public void CardClicked(object obj)
        {
            //Speel geluid af als je op kaart klikt.
            SoundPlayer clicksound = new SoundPlayer(Properties.Resources.geluid2);
            clicksound.Play();

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
                if(card == guessedCards[i])
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
            //Controleer of we nog kaarten kunnen kiezen, of we aan de limiet voor het max aantal keer raden zitten.
            if (guessedCards.Count < maxGuesses)
            {
                //Laat de voorkant van de kaart zien.
                card.isFlipped = true;

                //Kijk of we een match hebben.
                bool match = CheckForMatch(card);

                /*
                 * Als we een match hebben...
                 * Dan willen meteen alles reseten.
                 */
                if(match)
                {

                    int playerId = turnController.CurrentPlayerId;
                    Player player = playerList.GetPlayerById(playerId);
                    player.score++;

                    ResetGuesses();
                    return;
                }
                
                //Voeg de kaart toe aan de geraden kaarten.
                guessedCards.Add(card);
            }

            //Als we het maximaal aantal keer raden hebben gedaan dan:
            if (guessedCards.Count == maxGuesses)
            {
                /*
                 * We willen een x aantal milliseconden wachten voor dat we de kaarten weer willen omdraaien.
                 * Dit doen we door timeout op true te zetten en de timer te laten starten.
                */
                timeout = true;
                timeoutTimer.Start();
            }
        }

        /// <summary>
        ///     Controleert of de gegeven kaart id (argument) al eerder is geklikt.
        /// </summary>
        /// <param name="card">De kaart die we willen controleren op een match.</param>
        /// <returns>Returned true als we een match hebben en false als we geen match hebben.</returns>
        private bool CheckForMatch(Card card)
        {
            /*
             1) Loop over de array
             2) Sla de kaart over die we willen checken.
             3) Kijk of er een kaart is met het zelfde front id als de kaart uit het argument.
             4) Zo ja, return true, want we hebben een match.
             */
            for (int i = 0; i < guessedCards.Count; i++)
            {
                if(guessedCards[i] == card)
                {
                    continue;
                }

                if(guessedCards[i].front == card.front)
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
            //TODO: Geeft error als je een obj meegeeft wat geen picturebox is.
            PictureBox pictureBox = null;

            if(obj.GetType().IsAssignableFrom(typeof(PictureBox)))
            {
                pictureBox = obj as PictureBox;
            }
            else
            {
                throw new Exception("Gegeven object is geen kaart!");
            }

            //Loop over de kaarten array.
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    //Als de kaart object het zelfde picture box heeft naar die we willen.
                    //Return dan de kaart object.
                    if(cards[x,y].pictureBox == pictureBox )
                    {
                        return cards[x, y];
                    }
                }
            }

            return null;
        }

        /// <summary>
        ///     Reset de kaarten naar de plaatje van de achterkant, behalve geraden kaartjes.
        /// </summary>
        public void ResetCards()
        {
            //Loop over de kaarten array.
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    //Sla kaart tijdelijk op.
                    Card card = cards[x, y];

                    /*
                     * Als de kaart nog niet is geraden, laat de achterkant zien.
                     * Zet anders de voorkant van de kaart als plaatje.
                     */
                    if(!card.isGuessed)
                    {
                        card.pictureBox.Image = cardBack;
                    }
                    else
                    {
                        card.pictureBox.Image = cardFronts[card.front];
                    }
                }
            }
        }

        /// <summary>
        ///     Reset de geraden kaarten en alle variabelen die er mee te maken hebben.
        /// </summary>
        public void ResetGuesses()
        {
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
                    //Als 1 kaart niet geraden is, dan is het spel niet over.
                    if(!cards[x,y].isGuessed)
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

        public void Update()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Card card = this.cards[x, y];

                    if(card.isFlipped)
                    {
                        ShowCardFront(card);
                        continue;
                    }

                    if (card.isGuessed)
                    {
                        ShowCardFront(card);
                        continue;
                    }

                    HideCardFront(card);
                }
            }
        }

        /// <summary>
        ///     Laat de voorkant van de kaart zien.
        /// </summary>
        /// <param name="card">De kaart die we willen omdraaien.</param>
        public void ShowCardFront(Card card)
        {
            //TODO: Remove, this is an result of tight coupling.
            if (card.pictureBox == null) return;

            //Zet het plaatje die we opvragen uit de graphic array.
            /*
             * TODO: Card is niet verantwoordelijk om pictureboxes bij te houden.
             *       Dit zorgt een tight coupling tussen de kaart en picturebox.
             */
   
            card.pictureBox.Image = cardFronts[card.front];
        }

        public void HideCardFront(Card card)
        {
            //TODO: Remove, this is an result of tight coupling.
            if (card.pictureBox == null) return;

            /*
             * TODO: Card is niet verantwoordelijk om pictureboxes bij te houden.
             *       Dit zorgt een tight coupling tussen de kaart en picturebox.
             */
            card.pictureBox.Image = cardBack;
        }

        public CardControllerContext GetContext()
        {
            return new CardControllerContext(cards);
        }

        public void SetContext(GameContext context)
        {
            cards = context.cardControllerContext.cards;
        }

    }
}
