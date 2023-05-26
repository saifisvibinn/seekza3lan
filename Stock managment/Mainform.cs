using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_managment
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openchildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelmain.Controls.Add(childform);
            panelmain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openchildForm(new userform());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openchildForm(new orderform());
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productbutton_Click(object sender, EventArgs e)
        {
            openchildForm(new productsform());
        }
    }
}
