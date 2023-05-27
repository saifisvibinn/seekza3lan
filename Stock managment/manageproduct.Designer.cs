namespace Stock_managment
{
    partial class manageproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageproduct));
            button3 = new Button();
            button2 = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            qty = new TextBox();
            username = new TextBox();
            label7 = new Label();
            label1 = new Label();
            price = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pid = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Highlight;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(200, 339);
            button3.Name = "button3";
            button3.Size = new Size(173, 47);
            button3.TabIndex = 34;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(397, 339);
            button2.Name = "button2";
            button2.Size = new Size(185, 47);
            button2.TabIndex = 33;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.HotTrack;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(41, 239);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 31;
            label6.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HotTrack;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(41, 181);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 30;
            label4.Text = "Qty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(28, 126);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 29;
            label3.Text = "Product name";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Highlight;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(12, 339);
            button1.Name = "button1";
            button1.Size = new Size(163, 47);
            button1.TabIndex = 27;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // qty
            // 
            qty.BorderStyle = BorderStyle.None;
            qty.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            qty.Location = new Point(155, 167);
            qty.Name = "qty";
            qty.Size = new Size(413, 36);
            qty.TabIndex = 24;
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(155, 110);
            username.Name = "username";
            username.Size = new Size(413, 36);
            username.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(1199, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 38);
            label7.TabIndex = 3;
            label7.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(240, 16);
            label1.Name = "label1";
            label1.Size = new Size(326, 50);
            label1.TabIndex = 1;
            label1.Text = "Manage products";
            label1.Click += label1_Click;
            // 
            // price
            // 
            price.BorderStyle = BorderStyle.None;
            price.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(155, 225);
            price.Name = "price";
            price.Size = new Size(413, 36);
            price.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 15, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 87);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pid
            // 
            pid.BorderStyle = BorderStyle.None;
            pid.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pid.Location = new Point(155, 285);
            pid.Name = "pid";
            pid.Size = new Size(413, 36);
            pid.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(41, 299);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 36;
            label2.Text = "ID";
            // 
            // manageproduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 445);
            Controls.Add(label2);
            Controls.Add(pid);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(qty);
            Controls.Add(username);
            Controls.Add(price);
            Controls.Add(panel1);
            Name = "manageproduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "manageproduct";
            Load += manageproduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button3;
        public Button button2;
        private Label label6;
        private Label label4;
        private Label label3;
        public Button button1;
        public TextBox qty;
        public TextBox username;
        private Label label7;
        private Label label1;
        public TextBox price;
        private Panel panel1;
        public TextBox pid;
        private PictureBox pictureBox1;
        private Label label2;
    }
}