
namespace PresentationLayer
{
    partial class MainFormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormUser));
            panelMenu = new System.Windows.Forms.Panel();
            prietiUchenici = new System.Windows.Forms.Button();
            podadeniZaqvleniq = new System.Windows.Forms.Button();
            klasirane = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            panelTitleBar = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            reiting = new System.Windows.Forms.Button();
            profil = new System.Windows.Forms.Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(profil);
            panelMenu.Controls.Add(reiting);
            panelMenu.Controls.Add(prietiUchenici);
            panelMenu.Controls.Add(podadeniZaqvleniq);
            panelMenu.Controls.Add(klasirane);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(210, 469);
            panelMenu.TabIndex = 0;
            // 
            // prietiUchenici
            // 
            prietiUchenici.Dock = System.Windows.Forms.DockStyle.Top;
            prietiUchenici.FlatAppearance.BorderSize = 0;
            prietiUchenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            prietiUchenici.ForeColor = System.Drawing.Color.Gainsboro;
            prietiUchenici.Location = new System.Drawing.Point(0, 135);
            prietiUchenici.Name = "prietiUchenici";
            prietiUchenici.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            prietiUchenici.Size = new System.Drawing.Size(210, 61);
            prietiUchenici.TabIndex = 4;
            prietiUchenici.Text = "Приети ученици";
            prietiUchenici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            prietiUchenici.UseVisualStyleBackColor = true;
            prietiUchenici.Click += prietiUchenici_Click;
            // 
            // podadeniZaqvleniq
            // 
            podadeniZaqvleniq.Dock = System.Windows.Forms.DockStyle.Fill;
            podadeniZaqvleniq.FlatAppearance.BorderSize = 0;
            podadeniZaqvleniq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            podadeniZaqvleniq.ForeColor = System.Drawing.Color.Gainsboro;
            podadeniZaqvleniq.Location = new System.Drawing.Point(0, 135);
            podadeniZaqvleniq.Name = "podadeniZaqvleniq";
            podadeniZaqvleniq.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            podadeniZaqvleniq.Size = new System.Drawing.Size(210, 334);
            podadeniZaqvleniq.TabIndex = 3;
            podadeniZaqvleniq.Text = "Подадени заявления";
            podadeniZaqvleniq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            podadeniZaqvleniq.UseVisualStyleBackColor = true;
            podadeniZaqvleniq.Click += podadeniZaqvleniq_Click;
            // 
            // klasirane
            // 
            klasirane.Dock = System.Windows.Forms.DockStyle.Top;
            klasirane.FlatAppearance.BorderSize = 0;
            klasirane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            klasirane.ForeColor = System.Drawing.Color.Gainsboro;
            klasirane.Location = new System.Drawing.Point(0, 74);
            klasirane.Name = "klasirane";
            klasirane.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            klasirane.Size = new System.Drawing.Size(210, 61);
            klasirane.TabIndex = 2;
            klasirane.Text = "Класиране от състезания";
            klasirane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            klasirane.UseVisualStyleBackColor = true;
            klasirane.Click += klasirane_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(button1);
            panelLogo.Controls.Add(lblTitle);
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(210, 74);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Gainsboro;
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            button1.Size = new System.Drawing.Size(210, 74);
            button1.TabIndex = 2;
            button1.Text = "НАЧАЛО";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblTitle.Location = new System.Drawing.Point(10, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(129, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "НАЧАЛО";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(51, 51, 70);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(210, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new System.Drawing.Size(778, 74);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(210, 74);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(776, 388);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(129, 110);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(500, 125);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(273, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(210, 31);
            label2.TabIndex = 1;
            label2.Text = "ДОБРЕ ДОШЛИ";
            // 
            // reiting
            // 
            reiting.Dock = System.Windows.Forms.DockStyle.Top;
            reiting.FlatAppearance.BorderSize = 0;
            reiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            reiting.ForeColor = System.Drawing.Color.Gainsboro;
            reiting.Location = new System.Drawing.Point(0, 196);
            reiting.Name = "reiting";
            reiting.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            reiting.Size = new System.Drawing.Size(210, 61);
            reiting.TabIndex = 6;
            reiting.Text = "Рейтинг";
            reiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            reiting.UseVisualStyleBackColor = true;
            reiting.Click += reiting_Click;
            // 
            // profil
            // 
            profil.Dock = System.Windows.Forms.DockStyle.Top;
            profil.FlatAppearance.BorderSize = 0;
            profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            profil.ForeColor = System.Drawing.Color.Gainsboro;
            profil.Location = new System.Drawing.Point(0, 257);
            profil.Name = "profil";
            profil.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            profil.Size = new System.Drawing.Size(210, 61);
            profil.TabIndex = 7;
            profil.Text = "Профил";
            profil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            profil.UseVisualStyleBackColor = true;
            profil.Click += profil_Click_1;
            // 
            // MainFormUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(988, 469);
            Controls.Add(panel1);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(1004, 508);
            Name = "MainFormUser";
            Text = "Класиране";
            Load += model_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button prietiUchenici;
        private System.Windows.Forms.Button podadeniZaqvleniq;
        private System.Windows.Forms.Button klasirane;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reiting;
        private System.Windows.Forms.Button profil;
    }
}