using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RomGeo.QuizObjects
{
    class GraphicQuestion : Question
    {
        private Image image;

        public GraphicQuestion(int id = 0, string text = null, Image image = null, Domain domain = 0, int difficulty = 0, Answers answers = null)
             :base(id,text,domain,difficulty,answers)
        {
            this.image = image;
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
