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
        None,
        Relief,
        Hidrografie,
        Administrativ,
        Resurse
    }

    public class Question
    {
        private int id;
        private int difficulty;
        private bool graphic;
        private string text;
        private Domain domain;
        private Answers answers;

        public Question(int id = 0, string text = null, Domain domain = 0, int difficulty = 0, bool graphic = false, Answers answers = null)
        {
            this.id = id;
            this.text = text;
            this.domain = domain;
            this.graphic = graphic;
            this.answers = answers;
            this.difficulty = difficulty;
        }

        #region GETTERS-SETTERS

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        #endregion
    }
}
