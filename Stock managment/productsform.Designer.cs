namespace Stock_managment
{
    partial class productsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productsform));
            dataGridViewproduct = new DataGridView();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            searchbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewproduct
            // 
            dataGridViewproduct.AllowUserToAddRows = false;
            dataGridViewproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewproduct.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column2, Column4, Column3 });
            dataGridViewproduct.Dock = DockStyle.Fill;
            dataGridViewproduct.Location = new Point(0, 0);
            dataGridViewproduct.Name = "dataGridViewproduct";
            dataGridViewproduct.RowHeadersWidth = 51;
            dataGridViewproduct.RowTemplate.Height = 29;
            dataGridViewproduct.Size = new Size(1099, 569);
            dataGridViewproduct.TabIndex = 1;
            dataGridViewproduct.CellContentClick += dataGridViewproduct_CellContentClick;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 15, 64);
            panel2.Controls.Add(searchbox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 521);
            panel2.Name = "panel2";
            panel2.Size = new Size(1099, 48);
            panel2.TabIndex = 29;
            panel2.Paint += panel2_Paint;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(595, 12);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(325, 27);
            searchbox.TabIndex = 5;
            searchbox.TextChanged += searchbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(516, 11);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 4;
            label2.Text = "Search :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(201, 31);
            label1.TabIndex = 3;
            label1.Text = "Manage Products";
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
            Column1.HeaderText = "Product ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 108;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Qty";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // productsform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 569);
            Controls.Add(panel2);
            Controls.Add(dataGridViewproduct);
            Name = "productsform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "productsform";
            ((System.ComponentModel.ISupportInitialize)dataGridViewproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewproduct;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox searchbox;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
    }
}