using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomGeo.QuizObjects
{
    public class Answers : Utils.OneBasedArray<string>
    {

        private string correctAnswer;

        public Answers() : base(PersistentData.MAX_ANSWERS) { }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
    }
}
