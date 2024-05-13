using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Competition
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public bool IsConducted { get; set; } = false;
        
        public List<Profile> Students { get; set; }
        private Competition()
        {
            
        }
        
        public Competition(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
            Students = new List<Profile>();
        }


    }
}
