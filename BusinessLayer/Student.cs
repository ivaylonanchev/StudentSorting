using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Student
    {
        [Key]
        public string EGN { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public char Gender{ get; set; }
        [Required]
        
        public DateTime BirthDate { get; set; }
        public Profile Profile_Fk{ get; set; }
        public List<CompetitionScore> CompetitionScores { get; set; }
        
        private Student()
        {
            
        }
        public Student(string egn, string firstname, string middlename, string lastname, DateTime birthday)
        {
            this.EGN = egn; 
            this.FirstName = firstname; 
            this.MiddleName = middlename;   
            this.LastName = lastname;
            this.Gender = Convert.ToInt32(this.EGN[9]) % 2 == 0 ? 'M' : 'F';
            this.BirthDate = birthday;

        }

    }
    
}
