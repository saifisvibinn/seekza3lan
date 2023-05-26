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
    public partial class ordermoduleform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdminTable;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ordermoduleform()
        {
            InitializeComponent();
            loaduser();
            loadprodcut();
        }
        public void loaduser()
        {

            int i = 0;
            dataGridViewuser.Rows.Clear();
            cmd = new SqlCommand("select cid,cname from userTbnew WHERE CONCAT(cid,cname) LIKE'%" + searchcust.Text + "%'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewuser.Rows.Add(i, dr[0].ToString(), dr[1].ToString());

            }
            dr.Close();
            conn.Close();
        }
        public void loadprodcut()
        {

            int i = 0;
            dataGridViewproduct.Rows.Clear();
            cmd = new SqlCommand("select * from newprodTB where concat(PID,name,price,Qty) like '%" + searchprod.Text + "%'", conn);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void searchcust_TextChanged(object sender, EventArgs e)
        {
            loaduser();
        }

        private void searchprod_TextChanged(object sender, EventArgs e)
        {
            loadprodcut();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dataGridViewuser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcustname.Text = dataGridViewuser.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridViewproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dataGridViewuser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpname.Text = dataGridViewuser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtprice.Text = dataGridViewuser.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int total = Convert.ToInt16(txtprice.Text) * Convert.ToInt16(numericUpDown1.Value);
            txttotal.Text = total.ToString();
        }
    }
}
