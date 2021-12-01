using System.Collections.Generic;

namespace FlashcardApi.Models

{
    public class Quiz
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Description {get; set;}

        public bool Private {get; set;}

        
         //navigation properties
        public List<Question> Questions { get; set; }

        public int UserId {get; set;}
        public User User {get; set;}

    }
}