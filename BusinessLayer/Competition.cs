using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Competition
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<CompetitionScore> StudentsScore{ get; set; }
        private Competition()
        {
            
        }
        public Competition(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
        }


    }
}
