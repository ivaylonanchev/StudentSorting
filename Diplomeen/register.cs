using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Identity;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 10)
            {
                string firstname = textBox1.Text;
                string middlename = textBox2.Text;
                string lastname = textBox3.Text;
                string egn = textBox4.Text;
                string email = textBox5.Text;
                string hashedPassword = HashPassword(textBox6.Text);
                DateTime birthday = DateTime.Now;
                bool isAdmin = false;
                ProfileManager PM = new ProfileManager(ProjectDbManager.CreateContext());
                Profile profile = new Profile(email, hashedPassword, isAdmin, egn, firstname, middlename, lastname, birthday);
                PM.CreateAsync(profile);
                MessageBox.Show("Profile created");
            }
            else
            {
                MessageBox.Show("Невалидно ЕГН");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
