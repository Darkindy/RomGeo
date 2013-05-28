using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RomGeo.Utils;
using RomGeo.QuizObjects;

namespace RomGeo
{
    public static class PersistentData
    {
        public static User user;
        public static OneBasedArray<Question> questionList;
        public static Question currentQuestion;
        public static int currentQuestionIndex = 1;
        public static int correctAnswerCount = 0;

        public static int ReliefQuestionCount = 0;
        public static int HidrografieQuestionCount = 0;
        public static int AdministrativQuestionCount = 0;
        public static int ResurseQuestionCount = 0;

        public static int correctAnswerReliefCount = 0;
        public static int correctAnswerHidrografieCount = 0;
        public static int correctAnswerAdministrativCount = 0;
        public static int correctAnswerResurseCount = 0;

        public static int[] quizQuestions = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        #region constants
             public const int MAX_ANSWERS = 4;
        #endregion
    }
}
