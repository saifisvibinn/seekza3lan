namespace Stock_managment
{
    partial class orderform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderform));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dataGridViewuser = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 15, 64);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 474);
            panel2.Name = "panel2";
            panel2.Size = new Size(1081, 48);
            panel2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(30, 8);
            label1.Name = "label1";
            label1.Size = new Size(177, 31);
            label1.TabIndex = 33;
            label1.Text = "Manage Orders";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1026, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 51);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridViewuser
            // 
            dataGridViewuser.AllowUserToAddRows = false;
            dataGridViewuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewuser.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column8, Column2, Column4, Column3, Column5, Column6 });
            dataGridViewuser.Dock = DockStyle.Fill;
            dataGridViewuser.Location = new Point(0, 0);
            dataGridViewuser.Name = "dataGridViewuser";
            dataGridViewuser.RowHeadersVisible = false;
            dataGridViewuser.RowHeadersWidth = 51;
            dataGridViewuser.RowTemplate.Height = 29;
            dataGridViewuser.Size = new Size(1081, 474);
            dataGridViewuser.TabIndex = 32;
            dataGridViewuser.CellContentClick += dataGridViewuser_CellContentClick;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "No";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 58;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Order id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 93;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Order date";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 110;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "product id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 107;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Customer id";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 118;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Qty";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 61;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 70;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Total amount";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // orderform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 522);
            Controls.Add(dataGridViewuser);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "orderform";
            Text = "orderform";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private DataGridView dataGridViewuser;
        private Label label1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}