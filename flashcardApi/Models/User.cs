using System.Collections.Generic;

namespace FlashcardApi.Models

{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FirebaseID { get; set; }

        //navigation properties

        public List<Deck> Decks { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }

}