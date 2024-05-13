namespace PresentationLayer
{
    partial class RatingFormUser
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
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(129, 216);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(580, 88);
            label1.TabIndex = 0;
            label1.Text = "В таблица се изготвя рейтинг за прием на ученици за въведен брой паралелки като има квоти 50% момичета и 50% момчета.\r\n";
            // 
            // RatingFormUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Name = "RatingFormUser";
            Text = "RatingFormUser";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}