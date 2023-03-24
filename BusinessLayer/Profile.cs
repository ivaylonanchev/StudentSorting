using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BusinessLayer
{
    public class Profile
    {
        [Key] 
        public int ID { get; set; }
        /*public Student Students_FK { get; set; }*/
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Accepted { get; set; }

        public List<CompetitionScore> PointsPerCompetition { get; set; }
        [Required]
        [Range(0, 100)]
        public double Rating { get; set; }
        [Required]
        public bool ApplicationSubmited { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        private Profile()
        {

        }
        public Profile(string email, string password, bool isAdmin)
        {
            this.Email = email;
            this.Password = password;
            this.Accepted = false;
            this.Rating = 0;
            this.ApplicationSubmited = false;
            this.IsAdmin = isAdmin;

        }
    }
}
