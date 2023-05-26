using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Stock_managment
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdminTable;Integrated Security=True");


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBoxadmin.Text;
            pass = textBoxpass.Text;
            try
            {
                string querry = "SELECT * FROM LoginCreds_admin WHERE username = '" + textBoxadmin.Text + "' AND password = '" + textBoxpass.Text + "'";
                SqlDataAdapter adp = new SqlDataAdapter(querry, connect);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                if (tbl.Rows.Count > 0)
                {
                    user = textBoxadmin.Text;
                    pass = textBoxpass.Text;


                    textBoxadmin.Clear();
                    textBoxpass.Clear();
                    this.Hide();

                }

            }
            catch
            {
                MessageBox.Show("error invalid details, try again");


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ex_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxadmin.Text = "";
            textBoxpass.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                textBoxpass.UseSystemPasswordChar = true;
            else
                textBoxpass.UseSystemPasswordChar = false;
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if(textBoxadmin.Text=="admin" && textBoxpass.Text == "admin")
            {
                this.Hide();
                Mainform mainform = new Mainform();
                mainform.ShowDialog();
              
            }
            else
            {
                MessageBox.Show("invalid details");
            }
        }
    }
}