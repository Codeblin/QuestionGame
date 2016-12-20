using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{
    class Questions
    {
        public int id;
        public int type;
        public int difficulty;
        public int correctAnswer;

        public string Question;
        public string[] Answer;

        public bool alreadyDisplayed;

        //constructors
        public Questions() { return; }
        public Questions(int Id, int type, int difficulty, int correctAnswer,
            string question, string a1, string a2, string a3, string a4)
        {
            this.id = Id;
            this.type = type;
            this.difficulty = difficulty;
            this.correctAnswer = correctAnswer;
            this.Question = question;
            Answer = new string[] { a1, a2, a3, a4 };
            alreadyDisplayed = false;
        }

        //destructor
        ~Questions()
        {
            Answer = null;
            Console.WriteLine(id + " Deleted");
        }
    }
}
