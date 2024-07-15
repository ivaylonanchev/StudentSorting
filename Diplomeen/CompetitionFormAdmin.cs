using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CompetitionFormAdmin : Form
    {
        CompetitionManager competitionManager = new CompetitionManager(ProjectDbManager.CreateContext());
        public CompetitionFormAdmin()
        {
            InitializeComponent();
            ShowDataGrid();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = textBox1.Text;
                DateTime date = dateTimePicker1.Value;
                Competition competition = new Competition(Name, date);
                CompetitionManager competitionmanager = new CompetitionManager(ProjectDbManager.CreateContext());
                await competitionmanager.CreateAsync(competition);
                MessageBox.Show("Competition created");
                textBox1.ResetText();
                dateTimePicker1.ResetText();
                await ShowDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task ShowDataGrid()
        {
            dataGridView1.DataSource = await competitionManager.ReadAllAsync();
            dataGridView1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                compt = (Competition)dataGridView1.CurrentRow.DataBoundItem;
            }
        }

        private void CompetitionFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            compt = (Competition)dataGridView1.CurrentRow.DataBoundItem;
            CompetitionManager cm = new CompetitionManager(ProjectDbManager.CreateContext());
            await cm.UpdateAsync(compt);
            MessageBox.Show("Успешно променено");
            dataGridView1.DataSource = await competitionManager.ReadAllAsync();
        }
        int compID;
        Competition compt;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /* if (e.RowIndex > -1)
             {
                 compID = Convert.ToInt32(this.dataGridView1[e.ColumnIndex, e.RowIndex].Value);

             }*/

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            compt = (Competition)dataGridView1.CurrentRow.DataBoundItem;
            CompetitionManager cm = new CompetitionManager(ProjectDbManager.CreateContext());
            Competition c = await cm.ReadAsync(compt.ID);
            c.Students.Clear();
            await cm.UpdateAsync(c);
            await cm.DeleteAsync(c.ID);

            MessageBox.Show("Успешно изтрито");
            dataGridView1.DataSource = await competitionManager.ReadAllAsync();
        }
    }
}
