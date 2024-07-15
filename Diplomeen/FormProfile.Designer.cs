namespace PresentationLayer
{
    partial class FormProfile
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
            //mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel5 = new System.Windows.Forms.Panel();
            labelEGN = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            labelMiddleName = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            labelFirstName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            labelLastName = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            ////mySqlCommand1.CacheAge = 0;
            ////mySqlCommand1.Connection = null;
            ////mySqlCommand1.EnableCaching = false;
            ////mySqlCommand1.Transaction = null;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.Control;
            tableLayoutPanel1.SetColumnSpan(panel5, 3);
            panel5.Controls.Add(labelEGN);
            panel5.Controls.Add(label5);
            panel5.Location = new System.Drawing.Point(3, 159);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(469, 46);
            panel5.TabIndex = 9;
            // 
            // labelEGN
            // 
            labelEGN.AutoSize = true;
            labelEGN.Location = new System.Drawing.Point(172, 10);
            labelEGN.Name = "labelEGN";
            labelEGN.Size = new System.Drawing.Size(50, 20);
            labelEGN.TabIndex = 1;
            labelEGN.Text = "label6";
            labelEGN.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(25, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 20);
            label5.TabIndex = 0;
            label5.Text = "ЕГН :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(25, 8);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "Имейл :";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            labelEmail.Location = new System.Drawing.Point(172, 8);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(50, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "label5";
            labelEmail.Click += labelEmail_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(93, 93, 128);
            tableLayoutPanel1.SetColumnSpan(panel4, 3);
            panel4.Controls.Add(labelEmail);
            panel4.Controls.Add(label4);
            panel4.Location = new System.Drawing.Point(3, 211);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(469, 49);
            panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Презиме :";
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Location = new System.Drawing.Point(172, 14);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new System.Drawing.Size(50, 20);
            labelMiddleName.TabIndex = 1;
            labelMiddleName.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            tableLayoutPanel1.SetColumnSpan(panel2, 3);
            panel2.Controls.Add(labelMiddleName);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(3, 55);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(469, 45);
            panel2.TabIndex = 7;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            labelFirstName.Location = new System.Drawing.Point(172, 10);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new System.Drawing.Size(50, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "label1";
            labelFirstName.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(25, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Име :";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(93, 93, 128);
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelFirstName);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(469, 46);
            panel1.TabIndex = 6;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            labelLastName.Location = new System.Drawing.Point(172, 9);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new System.Drawing.Size(50, 20);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(25, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 20);
            label3.TabIndex = 5;
            label3.Text = "Фамилия :";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(93, 93, 128);
            tableLayoutPanel1.SetColumnSpan(panel3, 3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelLastName);
            panel3.Location = new System.Drawing.Point(3, 107);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(469, 45);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 4);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 263);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(93, 93, 128);
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(12, 393);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(137, 45);
            button1.TabIndex = 11;
            button1.Text = "Изход от акаунт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "FormProfile";
            Text = "Profile";
            Load += Profile_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEGN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}