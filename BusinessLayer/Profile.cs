using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Profile
    {
        public Student Students_FK { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public bool Accepted { get; set; }

        public List<CompetitionScore> PointsPerCompetition { get; set; }
        public double Rating { get; set; }
        public bool ApplicationSubmited { get; set; }
        private Profile()
        {

        }
        public Profile(string email, string password)
        {
            this.Email = email;
            this.Password = password;
            this.Accepted = false;
            this.Rating = 0;
            this.ApplicationSubmited = false;
        }
    }
}
