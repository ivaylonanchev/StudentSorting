using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageProfileFormAdmin : Form
    {
        public ManageProfileFormAdmin()
        {
            InitializeComponent();
        }
        Profile profile;
        ProfileManager pm;
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string egn = textBox1.Text;
                if (egn.Length == 10)
                {
                    pm = new ProfileManager(ProjectDbManager.CreateContext());
                    profile = await pm.ReadAsync(egn);
                    textBox2.Text = profile.FirstName;
                    textBox3.Text = profile.MiddleName;
                    tableLayoutPanel1.Visible = true;

                }
                else MessageBox.Show("fsd");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ManageProfileFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                profile.EGN = textBox2.Text;
                profile.FirstName = textBox3.Text;
                profile.MiddleName = textBox4.Text;
                profile.LastName = textBox5.Text;
                profile.Email = textBox6.Text;
                profile.Password = textBox7.Text;
                profile.Password = HashPassword(profile.Password);


                await pm.UpdateAsync(profile);
                tableLayoutPanel1.Visible = false;
                textBox1.Text = string.Empty;
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                await pm.DeleteAsync(profile.ID);
                tableLayoutPanel1.Visible = false;
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
