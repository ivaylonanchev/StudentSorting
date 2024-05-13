namespace PresentationLayer
{
    partial class MainFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormAdmin));
            panel1 = new System.Windows.Forms.Panel();
            panelTitleBar = new System.Windows.Forms.Panel();
            panelMenu = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            reiting = new System.Windows.Forms.Button();
            prietiUchenici = new System.Windows.Forms.Button();
            podadeniZaqvleniq = new System.Windows.Forms.Button();
            klasirane = new System.Windows.Forms.Button();
            sustezaniq = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(240, 99);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(887, 518);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(51, 51, 70);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(240, 0);
            panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new System.Drawing.Size(887, 99);
            panelTitleBar.TabIndex = 4;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(reiting);
            panelMenu.Controls.Add(prietiUchenici);
            panelMenu.Controls.Add(podadeniZaqvleniq);
            panelMenu.Controls.Add(klasirane);
            panelMenu.Controls.Add(sustezaniq);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(240, 617);
            panelMenu.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Gainsboro;
            button1.Location = new System.Drawing.Point(0, 504);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            button1.Size = new System.Drawing.Size(240, 81);
            button1.TabIndex = 7;
            button1.Text = "Менежиране на профили";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // reiting
            // 
            reiting.Dock = System.Windows.Forms.DockStyle.Top;
            reiting.FlatAppearance.BorderSize = 0;
            reiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            reiting.ForeColor = System.Drawing.Color.Gainsboro;
            reiting.Location = new System.Drawing.Point(0, 423);
            reiting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            reiting.Name = "reiting";
            reiting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            reiting.Size = new System.Drawing.Size(240, 81);
            reiting.TabIndex = 6;
            reiting.Text = "Рейтинг";
            reiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            reiting.UseVisualStyleBackColor = true;
            reiting.Click += reiting_Click;
            // 
            // prietiUchenici
            // 
            prietiUchenici.Dock = System.Windows.Forms.DockStyle.Top;
            prietiUchenici.FlatAppearance.BorderSize = 0;
            prietiUchenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            prietiUchenici.ForeColor = System.Drawing.Color.Gainsboro;
            prietiUchenici.Location = new System.Drawing.Point(0, 342);
            prietiUchenici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            prietiUchenici.Name = "prietiUchenici";
            prietiUchenici.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            prietiUchenici.Size = new System.Drawing.Size(240, 81);
            prietiUchenici.TabIndex = 4;
            prietiUchenici.Text = "Приети ученици";
            prietiUchenici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            prietiUchenici.UseVisualStyleBackColor = true;
            prietiUchenici.Click += prietiUchenici_Click_1;
            // 
            // podadeniZaqvleniq
            // 
            podadeniZaqvleniq.Dock = System.Windows.Forms.DockStyle.Top;
            podadeniZaqvleniq.FlatAppearance.BorderSize = 0;
            podadeniZaqvleniq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            podadeniZaqvleniq.ForeColor = System.Drawing.Color.Gainsboro;
            podadeniZaqvleniq.Location = new System.Drawing.Point(0, 261);
            podadeniZaqvleniq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            podadeniZaqvleniq.Name = "podadeniZaqvleniq";
            podadeniZaqvleniq.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            podadeniZaqvleniq.Size = new System.Drawing.Size(240, 81);
            podadeniZaqvleniq.TabIndex = 3;
            podadeniZaqvleniq.Text = "Подадени заявления";
            podadeniZaqvleniq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            podadeniZaqvleniq.UseVisualStyleBackColor = true;
            podadeniZaqvleniq.Click += podadeniZaqvleniq_Click_1;
            // 
            // klasirane
            // 
            klasirane.Dock = System.Windows.Forms.DockStyle.Top;
            klasirane.FlatAppearance.BorderSize = 0;
            klasirane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            klasirane.ForeColor = System.Drawing.Color.Gainsboro;
            klasirane.Location = new System.Drawing.Point(0, 180);
            klasirane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            klasirane.Name = "klasirane";
            klasirane.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            klasirane.Size = new System.Drawing.Size(240, 81);
            klasirane.TabIndex = 2;
            klasirane.Text = "Класиране от състезания";
            klasirane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            klasirane.UseVisualStyleBackColor = true;
            klasirane.Click += klasirane_Click_1;
            // 
            // sustezaniq
            // 
            sustezaniq.Dock = System.Windows.Forms.DockStyle.Top;
            sustezaniq.FlatAppearance.BorderSize = 0;
            sustezaniq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sustezaniq.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            sustezaniq.ForeColor = System.Drawing.Color.Gainsboro;
            sustezaniq.Location = new System.Drawing.Point(0, 99);
            sustezaniq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sustezaniq.Name = "sustezaniq";
            sustezaniq.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            sustezaniq.Size = new System.Drawing.Size(240, 81);
            sustezaniq.TabIndex = 1;
            sustezaniq.Text = "Състезания";
            sustezaniq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sustezaniq.UseVisualStyleBackColor = true;
            sustezaniq.Click += sustezaniq_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(button2);
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(240, 99);
            panelLogo.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Gainsboro;
            button2.Location = new System.Drawing.Point(0, 0);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            button2.Size = new System.Drawing.Size(240, 99);
            button2.TabIndex = 3;
            button2.Text = "НАЧАЛО";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // MainFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1127, 617);
            Controls.Add(panel1);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(1920, 1080);
            MinimumSize = new System.Drawing.Size(1145, 664);
            Name = "MainFormAdmin";
            Text = "Класиране";
            Load += MainFormAdmin_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button reiting;
        private System.Windows.Forms.Button prietiUchenici;
        private System.Windows.Forms.Button podadeniZaqvleniq;
        private System.Windows.Forms.Button klasirane;
        private System.Windows.Forms.Button sustezaniq;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}