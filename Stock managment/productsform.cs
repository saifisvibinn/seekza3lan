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
    public partial class productsform : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\OneDrive\Documents\newdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public productsform()
        {
            InitializeComponent();
            loadprodcut();
        }
        public void loadprodcut()
        {
            try
            {
                int i = 0;
                dataGridViewproduct.Rows.Clear();
                cmd = new SqlCommand("select * from newprodTB where concat(PID,name,price,Qty) like '%" + searchbox.Text + "%'", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridViewproduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            manageproduct manageproduct = new manageproduct();
            manageproduct.button1.Enabled = true;
            manageproduct.button3.Enabled = false;
            manageproduct.ShowDialog();
            this.Dispose();
            loadprodcut();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewproduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                manageproduct manageproduct = new manageproduct();
                manageproduct.username.Text = dataGridViewproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                manageproduct.qty.Text = dataGridViewproduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                manageproduct.price.Text = dataGridViewproduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                manageproduct.pid.Text = dataGridViewproduct.Rows[e.RowIndex].Cells[1].Value.ToString();

                manageproduct.button1.Enabled = false;
                manageproduct.button2.Enabled = true;
                manageproduct.username.Enabled = false;
                manageproduct.ShowDialog();

            }
            else if (colName == "Delete")
            {
                conn.Open();
                cmd = new SqlCommand("delete from newprodTB where PID like '" + dataGridViewproduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("user deleted successfully");


            }
            loadprodcut();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            loadprodcut();
        }
    }
}
