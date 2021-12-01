using System.Collections.Generic;

namespace FlashcardApi.Models

{
    public class Card
    {
        public long Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }

        //navigation properties

        public int DeckId
        {
            get; set; }
        public Deck Deck
        {
            get; set; }

        }
    }