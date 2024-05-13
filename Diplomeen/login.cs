using BusinessLayer;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic.ApplicationServices;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public object SystemDrawing { get; private set; }
        ProfileManager PM = new ProfileManager(ProjectDbManager.CreateContext());
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel1.BackColor = SystemColors.Control;
            textBox3.BackColor = SystemColors.Control;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string EGN = textBox3.Text;
                string password = textBox2.Text;

                if ((await PM.ReadAllAsync()).Where(P => P.IsAdmin == true).ToList().Count == 0)
                {
                    await GenerateAdmin();
                }

                Profile profile = (await PM.ReadAllAsync()).FirstOrDefault(p => p.EGN == EGN);


                // Profile profile = await PM.ReadAsync(EGN);

                if (profile != null && profile.Password == HashPassword(password))
                {
                    if (profile.IsAdmin)
                    {
                        MainFormAdmin form = new MainFormAdmin(profile);
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        MainFormUser form = new MainFormUser(profile);
                        this.Hide();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Неправилно ЕГН или парола");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task GenerateAdmin()
        {
            Profile prof = new Profile("admin@gmail.com", "admin", true, "2222222222", "admin", "admin", "admin", DateTime.Now);
            prof.IsAdmin = true;
            prof.Password = HashPassword(prof.Password);
            await PM.CreateAsync(prof);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Register form = new Register();
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Register form = new Register();
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
