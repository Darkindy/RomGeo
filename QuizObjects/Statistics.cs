using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomGeo.QuizObjects
{
    public class Statistics
    {
        public int totalqueried;
        public int totalcorrect;
        public int percentcorrect;
        public int percentrel;
        public int percenthidro;
        public int percentadmin;
        public int percentres;

        public Statistics(int totalqueried, int totalcorrect, int percentrel, int percenthidro, int percentadmin, int percentres)
        {
            this.totalqueried = totalqueried;
            this.totalcorrect = totalcorrect;
            this.percentcorrect = totalcorrect*100 / ((totalqueried>0)?totalqueried:1);
            this.percenthidro = percenthidro;
            this.percentrel = percentrel;
            this.percentres = percentres;
            this.percentadmin = percentadmin;
        }
    }
}
