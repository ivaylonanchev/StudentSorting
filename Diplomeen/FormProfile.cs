using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormProfile : Form
    {
        Profile profile;

        public FormProfile(Profile prof)
        {
            InitializeComponent();
            profile = prof;
            DispleyPersonInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void DispleyPersonInfo()
        {
            labelFirstName.Text = profile.FirstName;
            labelMiddleName.Text = profile.MiddleName;
            labelLastName.Text = profile.LastName;
            labelEmail.Text = profile.Email;
            labelEGN.Text = profile.EGN;

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login form = new Login();
                System.Windows.Forms.Application.ExitThread();
                form.ShowDialog();
            }
            catch(Exception ex)
            {

            }

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
