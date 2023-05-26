namespace Stock_managment
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBoxpass = new TextBox();
            textBoxadmin = new TextBox();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkBoxPass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxpass
            // 
            textBoxpass.Location = new Point(72, 328);
            textBoxpass.Name = "textBoxpass";
            textBoxpass.Size = new Size(261, 27);
            textBoxpass.TabIndex = 13;
            textBoxpass.UseSystemPasswordChar = true;
            // 
            // textBoxadmin
            // 
            textBoxadmin.Location = new Point(72, 228);
            textBoxadmin.Name = "textBoxadmin";
            textBoxadmin.Size = new Size(261, 27);
            textBoxadmin.TabIndex = 12;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.Turquoise;
            bunifuThinButton21.ActiveForecolor = Color.Transparent;
            bunifuThinButton21.ActiveLineColor = Color.Transparent;
            bunifuThinButton21.BackColor = Color.FromArgb(19, 15, 64);
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Login";
            bunifuThinButton21.Cursor = Cursors.Hand;
            bunifuThinButton21.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.Teal;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.SeaGreen;
            bunifuThinButton21.IdleLineColor = Color.SeaGreen;
            bunifuThinButton21.Location = new Point(72, 403);
            bunifuThinButton21.Margin = new Padding(6, 6, 6, 6);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(261, 58);
            bunifuThinButton21.TabIndex = 11;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(72, 294);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 10;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(72, 193);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 8;
            label2.Text = "User Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(177, 136);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 16;
            label4.Text = "Login";
            label4.Click += label4_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(359, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // checkBoxPass
            // 
            checkBoxPass.AutoSize = true;
            checkBoxPass.Cursor = Cursors.Hand;
            checkBoxPass.ForeColor = Color.White;
            checkBoxPass.Location = new Point(199, 470);
            checkBoxPass.Name = "checkBoxPass";
            checkBoxPass.Size = new Size(134, 24);
            checkBoxPass.TabIndex = 19;
            checkBoxPass.Text = "Show password";
            checkBoxPass.UseVisualStyleBackColor = true;
            checkBoxPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 15, 64);
            ClientSize = new Size(396, 570);
            Controls.Add(checkBoxPass);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(textBoxpass);
            Controls.Add(textBoxadmin);
            Controls.Add(bunifuThinButton21);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxpass;
        private TextBox textBoxadmin;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBoxPass;
    }
}