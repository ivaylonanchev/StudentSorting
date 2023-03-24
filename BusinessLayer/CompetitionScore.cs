using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class CompetitionScore
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Competition_FK")]
        public int CompetitionId { get; set; }
        public Competition Competition_FK { get; set; }

        [ForeignKey("Student_FK")]
        public string StudentEGN { get; set; } 
        public Student Student_FK { get; set; }

        public int Points { get; set; } 

    }
}
