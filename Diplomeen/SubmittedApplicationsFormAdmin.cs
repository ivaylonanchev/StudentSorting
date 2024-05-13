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
    public partial class SubmittedApplicationsFormAdmin : Form
    {
        public SubmittedApplicationsFormAdmin()
        {
            InitializeComponent();
            DataLoad();

        }
        private async Task DataLoad()
        {
            ProfileManager pm = new ProfileManager(ProjectDbManager.CreateContext());
            dataGridView1.DataSource = (await pm.ReadAllAsync()).Where(p => p.ApplicationSubmited == true).ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
