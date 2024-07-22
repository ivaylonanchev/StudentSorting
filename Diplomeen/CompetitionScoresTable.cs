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
    public partial class CompetitionScoresTable : Form
    {
        public CompetitionScoresTable(int ID, int p)
        {
            InitializeComponent();
            manager = new CompetitionManager(ProjectDbManager.CreateContext());
            Initialize(ID, p);
        }

        private void CompetitionScoresTable_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Competition competition;
        CompetitionManager manager;
        List<Profile> profiles;
        private async Task Initialize(int ID, int p)
        {
            //profiles = (await manager.ReadAsync(ID)).Profiles;
            await ShowDataGrid(ID, p);
        }
        private async Task ShowDataGrid(int ID, int p)
        {

            if (profiles.Count > 0)
            {
                foreach (var item in profiles)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
                    tableLayoutPanel1.Controls.Add(new Label() { Text = $"{item.FirstName}" }, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = $" {item.MiddleName}" }, 1, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = $" {item.LastName}" }, 2, tableLayoutPanel1.RowCount - 1);
                    if (p == 1)
                    {
                        tableLayoutPanel1.Controls.Add(new Label() { Text = item.PointsCompetition1.ToString() }, 3, tableLayoutPanel1.RowCount - 1);
                    }
                    else if (p == 2)
                    {
                        tableLayoutPanel1.Controls.Add(new Label() { Text = item.PointsCompetition2.ToString() }, 3, tableLayoutPanel1.RowCount - 1);
                    }
                    else if (p == 3)
                    {
                        tableLayoutPanel1.Controls.Add(new Label() { Text = item.PointsCompetition3.ToString() }, 3, tableLayoutPanel1.RowCount - 1);
                    }
                }
            }
        }
    }
}
