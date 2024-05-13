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
    public partial class SubmittedApplicationsFormUser : Form
    {
        Profile profile;
        public SubmittedApplicationsFormUser(Profile _profile)
        {
            InitializeComponent();
            profile = _profile;
            if (profile.ApplicationSubmited == true)
            {
                label2.Visible = true;
                label1.Visible = false;
                button1.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label1.Visible = true;
                button1.Visible = true;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileManager pm = new ProfileManager(ProjectDbManager.CreateContext());
                profile.ApplicationSubmited = true;
                await pm.UpdateAsync(profile);
                MessageBox.Show("Submitted");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void SubmittedApplicationsFormUser_Load(object sender, EventArgs e)
        {

        }
    }
}
