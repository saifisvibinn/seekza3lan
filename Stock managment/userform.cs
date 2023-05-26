using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_managment
{
    public partial class userform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdminTable;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public userform()
        {

            InitializeComponent();
            loaduser();
        }
        public void loaduser()
        {
            try
            {
                int i = 0;
                dataGridViewuser.Rows.Clear();
                cmd = new SqlCommand("select * from userTbnew", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridViewuser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void dataGridViewuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            newcustomer newusers = new newcustomer();
            newusers.button1.Enabled = true;
            newusers.button2.Enabled = false;
            newusers.ShowDialog();
        }

        private void userform_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewuser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewuser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                newcustomer newusers = new newcustomer();
                newusers.username.Text = dataGridViewuser.Rows[e.RowIndex].Cells[1].Value.ToString();
                newusers.fullname.Text = dataGridViewuser.Rows[e.RowIndex].Cells[2].Value.ToString();
                newusers.phonenumber.Text = dataGridViewuser.Rows[e.RowIndex].Cells[3].Value.ToString();
                newusers.password.Text = dataGridViewuser.Rows[e.RowIndex].Cells[4].Value.ToString();

                newusers.button1.Enabled = false;
                newusers.button2.Enabled = true;
                newusers.username.Enabled = false;
                newusers.ShowDialog();

            }
            else if (colName == "Delete")
            {
                conn.Open();
                cmd = new SqlCommand("delete from userTbnew where username like '" + dataGridViewuser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("user deleted successfully");


            }
            loaduser();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            newcustomer newusers = new newcustomer();
            this.Hide();
            newusers.Show();
        }
    }
}
