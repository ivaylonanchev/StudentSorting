namespace PresentationLayer
{
    partial class AcceptedStudentsFormUser
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            profileBindingSource = new System.Windows.Forms.BindingSource(components);
            firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            applicationSubmitedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            pointsCompetition1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pointsCompetition2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pointsCompetition3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn, applicationSubmitedDataGridViewCheckBoxColumn, pointsCompetition1DataGridViewTextBoxColumn, pointsCompetition2DataGridViewTextBoxColumn, pointsCompetition3DataGridViewTextBoxColumn });
            dataGridView1.DataSource = profileBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(800, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // profileBindingSource
            // 
            profileBindingSource.DataSource = typeof(BusinessLayer.Profile);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Име";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "Презиме";
            middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            middleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.ReadOnly = true;
            ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicationSubmitedDataGridViewCheckBoxColumn
            // 
            applicationSubmitedDataGridViewCheckBoxColumn.DataPropertyName = "ApplicationSubmited";
            applicationSubmitedDataGridViewCheckBoxColumn.HeaderText = "ApplicationSubmited";
            applicationSubmitedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            applicationSubmitedDataGridViewCheckBoxColumn.Name = "applicationSubmitedDataGridViewCheckBoxColumn";
            applicationSubmitedDataGridViewCheckBoxColumn.ReadOnly = true;
            applicationSubmitedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pointsCompetition1DataGridViewTextBoxColumn
            // 
            pointsCompetition1DataGridViewTextBoxColumn.DataPropertyName = "PointsCompetition1";
            pointsCompetition1DataGridViewTextBoxColumn.HeaderText = "Състезание 1";
            pointsCompetition1DataGridViewTextBoxColumn.MinimumWidth = 6;
            pointsCompetition1DataGridViewTextBoxColumn.Name = "pointsCompetition1DataGridViewTextBoxColumn";
            pointsCompetition1DataGridViewTextBoxColumn.ReadOnly = true;
            pointsCompetition1DataGridViewTextBoxColumn.Width = 125;
            // 
            // pointsCompetition2DataGridViewTextBoxColumn
            // 
            pointsCompetition2DataGridViewTextBoxColumn.DataPropertyName = "PointsCompetition2";
            pointsCompetition2DataGridViewTextBoxColumn.HeaderText = "Състезание 2";
            pointsCompetition2DataGridViewTextBoxColumn.MinimumWidth = 6;
            pointsCompetition2DataGridViewTextBoxColumn.Name = "pointsCompetition2DataGridViewTextBoxColumn";
            pointsCompetition2DataGridViewTextBoxColumn.ReadOnly = true;
            pointsCompetition2DataGridViewTextBoxColumn.Width = 125;
            // 
            // pointsCompetition3DataGridViewTextBoxColumn
            // 
            pointsCompetition3DataGridViewTextBoxColumn.DataPropertyName = "PointsCompetition3";
            pointsCompetition3DataGridViewTextBoxColumn.HeaderText = "Състезание 3";
            pointsCompetition3DataGridViewTextBoxColumn.MinimumWidth = 6;
            pointsCompetition3DataGridViewTextBoxColumn.Name = "pointsCompetition3DataGridViewTextBoxColumn";
            pointsCompetition3DataGridViewTextBoxColumn.ReadOnly = true;
            pointsCompetition3DataGridViewTextBoxColumn.Width = 125;
            // 
            // AcceptedStudentsFormUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "AcceptedStudentsFormUser";
            Text = "AcceptedStudentsFormUser";
            Load += AcceptedStudentsFormUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn applicationSubmitedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsCompetition1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsCompetition2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsCompetition3DataGridViewTextBoxColumn;
    }
}