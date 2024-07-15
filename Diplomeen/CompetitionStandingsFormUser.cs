using BusinessLayer;
using ServiceLayer;
using ServiceLayer.EntityManager;
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
    public partial class CompetitionStandingsFormUser : Form
    {
        Competition competition;
        CompetitionManager manager;
        List<Competition> competitions;
        public CompetitionStandingsFormUser()
        {
            InitializeComponent();
            ShowData();

        }
        public async Task ShowData()
        {
            manager = new CompetitionManager(ProjectDbManager.CreateContext());
            competitions = (await manager.ReadAllAsync()).OrderBy(c=>c.Date).ToList();
            label13.Text = competitions[0].Date.ToString();
            label5.Text = competitions[0].Name.ToString();
            label4.Text = competitions[1].Date.ToString();
            label3.Text = competitions[1].Name.ToString();
            label2.Text = competitions[2].Date.ToString();
            label6.Text = competitions[2].Name.ToString();

        }


        private void labelThirdCompetition_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstCompetition_Click(object sender, EventArgs e)
        {

        }

        private void CompetitionStandingsFormUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (competitions != null && competitions.Count > 0)
            {
                CompetitionScoresTable form = new CompetitionScoresTable(competitions[0].ID, 1);
                form.ShowDialog();
            }
            else MessageBox.Show("Не са въведени резултати");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (competitions != null && competitions.Count > 0)
            {
                CompetitionScoresTable form = new CompetitionScoresTable(competitions[1].ID, 2);
                form.ShowDialog();
            }
            else MessageBox.Show("Не са въведени резултати");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (competitions != null && competitions.Count > 0)
            {
                CompetitionScoresTable form = new CompetitionScoresTable(competitions[2].ID, 3);
                form.ShowDialog();
            }
            else MessageBox.Show("Не са въведени резултати");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
