using BusinessLayer;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
    public partial class RatingStudents : Form
    {
        Profile profile;
        public RatingStudents(Profile _profile)
        {
            profile = _profile;

        }
        //private async Task ShowData()
        //{
        //    dataGridView1.DataSource = (await (new ProfileManager(ProjectDbManager
        //        .CreateContext()))
        //        .ReadAllAsync())
        //        .Where(s => s.IsAdmin == false)
        //        .OrderBy(s => s.Rating)
        //        .ToList();
        //}
        public RatingStudents()
        {
            InitializeComponent();
            //ShowData();
        }
        private void DispleyPersonInfo()
        {
            labelFirstName.Text = profile.FirstName;
            labelMiddleName.Text = profile.MiddleName;
            labelLastName.Text = profile.LastName;
            Rating.Text = profile.Rating.ToString();
            //Competition1.Text = profile.c


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pointsCompetition1DataGridViewTextBoxColumn.HeaderText = profile.PointsCompetition1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void RatingStudents_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
