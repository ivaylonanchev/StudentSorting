using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CompetitionScore
    {
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile{ get; set; }
        public int Points { get; set; }

    }
}
