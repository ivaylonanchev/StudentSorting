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
    public partial class StudentsPointsAdmin : Form
    {
        Competition competition;
        CompetitionManager compmanager;
        public StudentsPointsAdmin()
        {
            InitializeComponent();
            numericUpDown1.Hide();
            button2.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            label1.Hide();
            manager = new ProfileManager(ProjectDbManager.CreateContext());
            competitionManager = new CompetitionManager(ProjectDbManager.CreateContext());
            ShowData();


        }
        public async Task ShowData()
        {
            compmanager = new CompetitionManager(ProjectDbManager.CreateContext());
            List<Competition> competitions = (await compmanager.ReadAllAsync()).OrderBy(c => c.Date).ToList();
            radioButton1.Text = competitions[0].Name.ToString();
            radioButton2.Text = competitions[1].Name.ToString();
            radioButton3.Text = competitions[2].Name.ToString();
        }

        private void StudentsPointsAdmin_Load(object sender, EventArgs e)
        {

        }
        ProfileManager manager;
        CompetitionManager competitionManager;
        Profile profile;


        private async void button1_Click(object sender, EventArgs e)
        {
            profile = await manager.ReadAsync(textBox1.Text);
            if (profile != null)
            {
                numericUpDown1.Show();
                button2.Show();
                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
                label1.Show();

            }
            else
            {

            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<Competition> c = (await competitionManager.ReadAllAsync()).OrderBy(c => c.Date).ToList();
            if (radioButton1.Checked)
            {
                profile.PointsCompetition1 = Convert.ToInt16(numericUpDown1.Value);
                profile.NewRating();

                //c.Students.Add(profile);
                await competitionManager.UpdateAsync(c[0], profile, 1);
            }
            else if (radioButton2.Checked)
            {
                profile.PointsCompetition2 = Convert.ToInt16(numericUpDown1.Value);
                profile.NewRating();

                //c.Students.Add(profile);
                await competitionManager.UpdateAsync(c[1], profile, 2); ;
            }
            else if (radioButton3.Checked)
            {
                profile.PointsCompetition3 = Convert.ToInt16(numericUpDown1.Value);
                profile.NewRating();

                //c.Students.Add(profile);
                await competitionManager.UpdateAsync(c[2], profile, 3);
            }

            //await manager.UpdateAsync(profile);
            MessageBox.Show("Успешно оценен");
            numericUpDown1.Hide();
            button2.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
