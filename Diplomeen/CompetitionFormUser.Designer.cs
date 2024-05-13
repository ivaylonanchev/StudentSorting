namespace PresentationLayer
{
    partial class CompetitionFormUser
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
            components = new System.ComponentModel.Container();
            competitionBindingSource = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // competitionBindingSource
            // 
            competitionBindingSource.DataSource = typeof(BusinessLayer.Competition);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(108, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(231, 20);
            label1.TabIndex = 0;
            label1.Text = "Tuk shte se opisvat 3te sustezaniq";
            // 
            // CompetitionFormUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Name = "CompetitionFormUser";
            Text = "CompetitionUserForm";
            Load += CompetitionFormUser_Load;
            ((System.ComponentModel.ISupportInitialize)competitionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.BindingSource competitionBindingSource;
        private System.Windows.Forms.Label label1;
    }
}