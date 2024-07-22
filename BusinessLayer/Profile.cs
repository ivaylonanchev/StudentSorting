using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BusinessLayer
{
    public class Profile
    {
        [Key]
        public int ID { get; set; }
        public string EGN { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        //[Required]
        public char Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        //[Required]
        public bool Accepted { get; set; }
        private Application Application { get; set; }
        public DateTime BirthDate { get; set; }


        [ForeignKey(nameof(CompetitionScoreId))]
        public int CompetitionScoreId { get; set; }
        public List<CompetitionScore> CompetitionScores { get; set; }
        public int PointsCompetition1 { get; set; }
        public int PointsCompetition2 { get; set; }
        public int PointsCompetition3 { get; set; }



        //[Required]
        [Range(0, 100)]
        public double Rating { get; set; }
        [Required]
        public bool ApplicationSubmited { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        public void NewRating()
        {
            Rating = PointsCompetition1 + PointsCompetition2 + PointsCompetition3;
        }

        private Profile()
        {

        }
        public Profile(string egn, string password, string email)
        {
            this.EGN = egn;
            this.Password = password;
            Rating = PointsCompetition1 + PointsCompetition2 + PointsCompetition3;
        }
        public Profile(string email, string password, bool isAdmin, string egn, string firstname, string middlename, string lastname, DateTime birthday)
        {
            this.Email = email;
            this.Password = password;
            this.Accepted = false;
            this.Rating = 0;
            this.ApplicationSubmited = false;
            this.IsAdmin = isAdmin;
            this.PointsCompetition1 = 0;
            this.PointsCompetition2 = 0;
            //Student
            this.EGN = egn;
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.Gender = Convert.ToInt32(this.EGN[9]) % 2 == 0 ? 'M' : 'F';
            this.BirthDate = birthday;
            Rating = PointsCompetition1 + PointsCompetition2 + PointsCompetition3;
            CompetitionScores = new List<CompetitionScore>();

        }
    }
}
