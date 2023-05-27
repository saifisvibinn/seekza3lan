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
    public partial class orderform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\OneDrive\Documents\newdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public orderform()
        {
            InitializeComponent();
            loadOrder();
        }
        public void loadOrder()
        {
            int i = 0;
            dataGridViewuser.Rows.Clear();
            cmd = new SqlCommand("select * from orderTable", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewuser.Rows.Add(i, dr[0].ToString(),Convert.ToDateTime(dr[1].ToString()).ToString("dd/mm/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }
            dr.Close();
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ordermoduleform modulform = new ordermoduleform();
            modulform.btninsert.Enabled = true;
            modulform.btnupdate.Enabled = false;
            modulform.ShowDialog();
            loadOrder();
        }

        private void dataGridViewuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        }
    }
}
