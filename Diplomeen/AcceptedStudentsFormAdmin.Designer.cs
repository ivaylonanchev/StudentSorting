﻿namespace PresentationLayer
{
    partial class AcceptedStudentsFormAdmin
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
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(93, 93, 128);
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(276, 177);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(175, 44);
            button1.TabIndex = 0;
            button1.Text = "Създай класиране";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AcceptedStudentsFormAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Name = "AcceptedStudentsFormAdmin";
            Text = "AcceptedStudentsFormAdmin";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}