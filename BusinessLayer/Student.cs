using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Student
    {
        public string EGN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public char Gender{ get; set; }
        public DateTime BirthDate { get; set; }
        public Profile Profile_FK{ get; set; }
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
