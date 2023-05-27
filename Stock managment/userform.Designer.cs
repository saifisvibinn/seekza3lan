namespace Stock_managment
{
    partial class userform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userform));
            dataGridViewuser = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewuser
            // 
            dataGridViewuser.AllowUserToAddRows = false;
            dataGridViewuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewuser.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column2, Column3, Column4, Edit, Delete });
            dataGridViewuser.Dock = DockStyle.Fill;
            dataGridViewuser.Location = new Point(0, 0);
            dataGridViewuser.Name = "dataGridViewuser";
            dataGridViewuser.RowHeadersWidth = 51;
            dataGridViewuser.RowTemplate.Height = 29;
            dataGridViewuser.Size = new Size(1117, 611);
            dataGridViewuser.TabIndex = 0;
            dataGridViewuser.CellContentClick += dataGridViewuser_CellContentClick_1;
            // 
            // Column7
            // 
            Column7.HeaderText = "No";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "username";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 102;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "fullname";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "phonenumber";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 131;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "password";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 101;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "edit";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "delete";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 57;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(1026, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 51);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 15, 64);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 563);
            panel2.Name = "panel2";
            panel2.Size = new Size(1117, 48);
            panel2.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 10);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 3;
            label1.Text = "Manage customers";
            // 
            // userform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1117, 611);
            Controls.Add(panel2);
            Controls.Add(dataGridViewuser);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "userform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userform";
            Load += userform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewuser;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
    }
}