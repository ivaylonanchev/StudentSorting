using BusinessLayer;
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
    public partial class MainFormAdmin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Profile profile;
        public MainFormAdmin(Profile prof)
        {
            InitializeComponent();
            profile = prof;
            random = new Random();
        }
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageProfileFormAdmin(), sender);
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void sustezaniq_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CompetitionFormAdmin(), sender);
        }

        private void klasirane_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Students(), sender);
        }

        private void podadeniZaqvleniq_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubmittedApplicationsFormAdmin(), sender);
        }

        private void prietiUchenici_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AcceptedStudentsFormAdmin(), sender);
        }

        private void profil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProfile(profile), sender);
        }

        private void profil_Click_1(object sender, EventArgs e)
        {

        }

        private void podadeniZaqvleniq_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SubmittedApplicationsFormAdmin(), sender);
        }

        private void klasirane_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentsPointsAdmin(), sender);
        }

        private void prietiUchenici_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AcceptedStudentsFormAdmin(), sender);
        }

        private void reiting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RatingStudents(), sender);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
