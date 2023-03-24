using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CompetitionScore
    {
        public Competition Competition_FK { get; set; }
        public Student Student_FK{ get; set; }
        public int Points { get; set; }

    }
}
