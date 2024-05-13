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
        private async Task ShowData()
        {
            dataGridView1.DataSource = (await (new ProfileManager(ProjectDbManager.CreateContext())).ReadAllAsync()).Where(s => s.IsAdmin == false).OrderBy(s => s.Rating).ToList();
        }
        public RatingStudents()
        {
            InitializeComponent();
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
