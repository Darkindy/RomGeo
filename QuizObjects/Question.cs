using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomGeo.QuizObjects
{
    public enum Domain
    {
        Relief = 0,
        Hidrografie,
        Administrativ,
        Resurse
    }

    public enum Difficulty
    {
        Easy = 0,
        Medium,
        Hard
    }

    public class Question
    {
        private string text;
        private Answers answers;
        private Domain domain;
        private Difficulty difficulty;

        public Question(string text = null, Answers answers = null, Domain domain = 0, Difficulty difficulty = 0)
        {
            this.text = text;
            this.answers = answers;
            this.domain = domain;
            this.difficulty = difficulty;
        }

        #region GETTERS-SETTERS
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public Answers Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public string CorrectAnswer
        {
            get { return answers.CorrectAnswer; }
            set { answers.CorrectAnswer = value; }
        }

        public Domain Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        public Difficulty Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        #endregion
    }
}
