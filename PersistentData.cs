using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RomGeo.QuizObjects;

namespace RomGeo
{
    public static class PersistentData
    {
        public static User user;
        public static Question currentQuestion;
        public static int currentQuestionIndex = 1;
        public static int correctAnswerCount = 0;

        #region constants
             public const int MAX_ANSWERS = 4;
        #endregion
    }
}
