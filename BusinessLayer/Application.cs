using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Application
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public Profile Profile{ get; set; }
        public DateTime DateApplied { get; set; }
        public Application()
        {
            DateApplied = DateTime.Now;   
        }

    }
}
