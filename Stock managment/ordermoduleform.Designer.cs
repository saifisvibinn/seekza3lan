namespace Stock_managment
{
    partial class ordermoduleform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordermoduleform));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            txtcustname = new TextBox();
            label6 = new Label();
            txtcustid = new TextBox();
            label4 = new Label();
            searchcust = new TextBox();
            label2 = new Label();
            dataGridViewuser = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            UDQty = new NumericUpDown();
            btnupdate = new Button();
            button2 = new Button();
            label13 = new Label();
            btninsert = new Button();
            odatepick = new DateTimePicker();
            label12 = new Label();
            txtpname = new TextBox();
            label11 = new Label();
            txttotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtprice = new TextBox();
            label8 = new Label();
            txtpid = new TextBox();
            label5 = new Label();
            searchprod = new TextBox();
            label3 = new Label();
            dataGridViewproduct = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UDQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 15, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1076, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 4;
            label1.Text = "Add order";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 15, 64);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtcustname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtcustid);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(searchcust);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridViewuser);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 687);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 441);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 10;
            label7.Text = "Customer Name :";
            // 
            // txtcustname
            // 
            txtcustname.Enabled = false;
            txtcustname.Location = new Point(37, 480);
            txtcustname.Name = "txtcustname";
            txtcustname.Size = new Size(286, 27);
            txtcustname.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(37, 362);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 8;
            label6.Text = "Customer ID :";
            // 
            // txtcustid
            // 
            txtcustid.Enabled = false;
            txtcustid.Location = new Point(37, 400);
            txtcustid.Name = "txtcustid";
            txtcustid.Size = new Size(286, 27);
            txtcustid.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(64, 284);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Seach box :";
            // 
            // searchcust
            // 
            searchcust.Location = new Point(160, 281);
            searchcust.Name = "searchcust";
            searchcust.Size = new Size(190, 27);
            searchcust.TabIndex = 5;
            searchcust.TextChanged += searchcust_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 325);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "CUSTOMER";
            // 
            // dataGridViewuser
            // 
            dataGridViewuser.AllowUserToAddRows = false;
            dataGridViewuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewuser.Columns.AddRange(new DataGridViewColumn[] { Column7, Column2, Column1 });
            dataGridViewuser.Dock = DockStyle.Top;
            dataGridViewuser.Location = new Point(0, 0);
            dataGridViewuser.Name = "dataGridViewuser";
            dataGridViewuser.RowHeadersVisible = false;
            dataGridViewuser.RowHeadersWidth = 51;
            dataGridViewuser.RowTemplate.Height = 29;
            dataGridViewuser.Size = new Size(363, 265);
            dataGridViewuser.TabIndex = 2;
            dataGridViewuser.CellClick += dataGridViewuser_CellClick;
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
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "customer id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 116;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(19, 15, 64);
            panel3.Controls.Add(UDQty);
            panel3.Controls.Add(btnupdate);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(btninsert);
            panel3.Controls.Add(odatepick);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtpname);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txttotal);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtprice);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtpid);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(searchprod);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dataGridViewproduct);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(384, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(733, 687);
            panel3.TabIndex = 2;
            // 
            // UDQty
            // 
            UDQty.Location = new Point(518, 412);
            UDQty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            UDQty.Name = "UDQty";
            UDQty.Size = new Size(190, 27);
            UDQty.TabIndex = 25;
            UDQty.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnupdate
            // 
            btnupdate.Cursor = Cursors.Hand;
            btnupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnupdate.ForeColor = SystemColors.Highlight;
            btnupdate.ImeMode = ImeMode.NoControl;
            btnupdate.Location = new Point(261, 607);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(173, 47);
            btnupdate.TabIndex = 24;
            btnupdate.Text = "Order Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(464, 607);
            button2.Name = "button2";
            button2.Size = new Size(185, 47);
            button2.TabIndex = 23;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(23, 538);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 21;
            label13.Text = "Order Date :";
            // 
            // btninsert
            // 
            btninsert.Cursor = Cursors.Hand;
            btninsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btninsert.ForeColor = SystemColors.Highlight;
            btninsert.ImeMode = ImeMode.NoControl;
            btninsert.Location = new Point(67, 607);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(163, 47);
            btninsert.TabIndex = 22;
            btninsert.Text = "Order Insert";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // odatepick
            // 
            odatepick.CustomFormat = "dd/mm/yyyy";
            odatepick.Format = DateTimePickerFormat.Custom;
            odatepick.Location = new Point(160, 533);
            odatepick.Name = "odatepick";
            odatepick.Size = new Size(132, 27);
            odatepick.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(23, 442);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 19;
            label12.Text = "Product Name :";
            // 
            // txtpname
            // 
            txtpname.Location = new Point(23, 480);
            txtpname.Name = "txtpname";
            txtpname.ReadOnly = true;
            txtpname.Size = new Size(190, 27);
            txtpname.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(448, 466);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 17;
            label11.Text = "Total :";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(518, 463);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(190, 27);
            txttotal.TabIndex = 16;
            txttotal.TextChanged += txttotal_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(448, 412);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 15;
            label10.Text = "Qty   :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(448, 358);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 13;
            label9.Text = "Price :";
            // 
            // txtprice
            // 
            txtprice.Location = new Point(518, 355);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(190, 27);
            txtprice.TabIndex = 12;
            txtprice.TextChanged += txtprice_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 362);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 11;
            label8.Text = "Product ID :";
            // 
            // txtpid
            // 
            txtpid.Location = new Point(23, 400);
            txtpid.Name = "txtpid";
            txtpid.ReadOnly = true;
            txtpid.Size = new Size(190, 27);
            txtpid.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(194, 284);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 7;
            label5.Text = "Seach box :";
            // 
            // searchprod
            // 
            searchprod.Location = new Point(322, 281);
            searchprod.Name = "searchprod";
            searchprod.Size = new Size(399, 27);
            searchprod.TabIndex = 6;
            searchprod.TextChanged += searchprod_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 325);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "PRODUCT";
            // 
            // dataGridViewproduct
            // 
            dataGridViewproduct.AllowUserToAddRows = false;
            dataGridViewproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewproduct.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column3, Column4 });
            dataGridViewproduct.Location = new Point(3, 0);
            dataGridViewproduct.Name = "dataGridViewproduct";
            dataGridViewproduct.RowHeadersVisible = false;
            dataGridViewproduct.RowHeadersWidth = 51;
            dataGridViewproduct.RowTemplate.Height = 29;
            dataGridViewproduct.Size = new Size(730, 265);
            dataGridViewproduct.TabIndex = 3;
            dataGridViewproduct.CellClick += dataGridViewproduct_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Product ID";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 108;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column3
            // 
            Column3.HeaderText = "price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Qty";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // ordermoduleform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 15, 64);
            ClientSize = new Size(1117, 743);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ordermoduleform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ordermoduleform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UDQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridViewuser;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Panel panel3;
        private DataGridView dataGridViewproduct;
        private Label label2;
        private TextBox searchcust;
        private TextBox searchprod;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox txtcustname;
        private Label label6;
        private TextBox txtcustid;
        private Label label12;
        private TextBox txtpname;
        private Label label11;
        private TextBox txttotal;
        private Label label10;
        private Label label9;
        private TextBox txtprice;
        private Label label8;
        private TextBox txtpid;
        private Label label13;
        private DateTimePicker odatepick;
        public Button btnupdate;
        public Button button2;
        public Button btninsert;
        private NumericUpDown UDQty;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}