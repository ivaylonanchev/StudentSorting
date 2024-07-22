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
    public partial class MainFormUser : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Profile profile;
        private Label fancylabel;

        //Constructor
        public MainFormUser(Profile prof)
        {
            InitializeComponent();
            profile = prof;
            random = new Random();
        }


        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousbtn in panelMenu.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousbtn.ForeColor = Color.Gainsboro;
                    previousbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void sustezaniq_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CompetitionFormUser(), sender);
        }

        private void klasirane_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CompetitionStandingsFormUser(), sender);
        }

        private void podadeniZaqvleniq_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubmittedApplicationsFormUser(profile), sender);
        }

        private void prietiUchenici_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AcceptedStudentsFormUser(), sender);
        }

        private void reiting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RatingStudents(profile), sender);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void model_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new HomeScreen(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profil_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormProfile(profile), sender);
        }
    }
}
