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
    public partial class AcceptedStudentsFormUser : Form
    {
        ProfileManager profileManager;
        public AcceptedStudentsFormUser()
        {
            InitializeComponent();
            profileManager = new ProfileManager(ProjectDbManager.CreateContext());
            ShowDataGrid();
        }
        private async Task ShowDataGrid()
        {
            List<Profile> Students = (await profileManager.ReadAllAsync()).OrderBy(s => s.Rating).Where(s => s.Gender == 'M' && s.IsAdmin == false && s.Accepted == true).Take(14).ToList();
            Students.AddRange((await profileManager.ReadAllAsync()).OrderBy(s => s.Rating).Where(s => s.Gender == 'F' && s.IsAdmin == false && s.Accepted == true).Take(14).ToList());
            dataGridView1.DataSource = Students;
            dataGridView1.Show();
        }

        private void AcceptedStudentsFormUser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
