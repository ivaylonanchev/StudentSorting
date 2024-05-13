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
    public partial class FormReadAllCompetitions : Form
    {
        public FormReadAllCompetitions()
        {
            InitializeComponent();
        }

        private void ReadAllCompetitions_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CompetitionManager CM = new CompetitionManager(ProjectDbManager.CreateContext());
                dataGridView1.DataSource = await CM.ReadAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
