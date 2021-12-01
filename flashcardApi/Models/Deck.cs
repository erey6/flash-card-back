using System.Collections.Generic;

namespace FlashcardApi.Models

{
    public class Deck
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Description {get; set;}

        public bool Private {get; set;}

        
         //navigation properties
        public List<Card> Cards { get; set; }

        public int UserId {get; set;}
        public User User {get; set;}

    }
}