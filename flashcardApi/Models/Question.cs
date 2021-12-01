using System.Collections.Generic;

namespace FlashcardApi.Models

{
    public class Question
    {
        public long Id { get; set; }
        public string Query { get; set; }
        public List<string> Options { get; set; }

        //navigation properties

        public int QuizId
        {
            get; set; }
        public Quiz Quiz
        {
            get; set; }

        }
    }