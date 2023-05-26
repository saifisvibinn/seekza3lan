namespace Stock_managment
{
    partial class newcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newcustomer));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            username = new TextBox();
            fullname = new TextBox();
            phonenumber = new TextBox();
            password = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 15, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            resources.ApplyResources(username, "username");
            username.Name = "username";
            // 
            // fullname
            // 
            fullname.BorderStyle = BorderStyle.None;
            resources.ApplyResources(fullname, "fullname");
            fullname.Name = "fullname";
            // 
            // phonenumber
            // 
            phonenumber.BorderStyle = BorderStyle.None;
            resources.ApplyResources(phonenumber, "phonenumber");
            phonenumber.Name = "phonenumber";
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            resources.ApplyResources(password, "password");
            password.Name = "password";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.Highlight;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.HotTrack;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.HotTrack;
            label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = SystemColors.HotTrack;
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.HotTrack;
            label5.Name = "label5";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = SystemColors.Highlight;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = SystemColors.Highlight;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // newcustomer
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(phonenumber);
            Controls.Add(fullname);
            Controls.Add(username);
            Controls.Add(panel1);
            Name = "newcustomer";
            Load += newusers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        public Button button1;
        public Button button2;
        public TextBox username;
        public TextBox fullname;
        public TextBox phonenumber;
        public TextBox password;
        public Button button3;
        private PictureBox pictureBox1;
    }
}