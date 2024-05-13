using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AcceptedStudentsFormAdmin : Form
    {
        Profile profile;
        public AcceptedStudentsFormAdmin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ProfileManager pm = new ProfileManager(ProjectDbManager.CreateContext());
            List<Profile> Students = (await pm.ReadAllAsync()).OrderBy(s => s.Rating).Where(s => s.Gender == 'M' && s.IsAdmin == false && s.ApplicationSubmited == true).Take(14).ToList();
            Students.AddRange((await pm.ReadAllAsync()).OrderBy(s => s.Rating).Where(s => s.Gender == 'F' && s.IsAdmin == false && s.ApplicationSubmited == true).Take(14).ToList());
            foreach (var student in Students)
            {
                student.Accepted = true;
                await pm.UpdateAsync(student);

            }
        }
    }
}
