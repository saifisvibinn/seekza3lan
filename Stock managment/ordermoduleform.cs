using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Stock_managment
{
    public partial class ordermoduleform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\OneDrive\Documents\newdb.mdf;Integrated Security=True;Connect Timeout=30");
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
            cmd = new SqlCommand("select username,phonenumber from userTbnew WHERE CONCAT(username,phonenumber) LIKE'%" + searchcust.Text + "%'", conn);
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

        }
        int Qty = 0;

        private void dataGridViewproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(UDQty.Value) > Qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQty.Value = UDQty.Value - 1;
                return;
            }
            if (Convert.ToInt32(UDQty.Value) > 0)
            {

                int total, newtotal, num;
                num = int.Parse(txtprice.Text);
                newtotal = Convert.ToInt32(UDQty.Value);
                total = num * newtotal;
                txttotal.Text = total.ToString();
            }
        }

        private void dataGridViewproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dataGridViewproduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpname.Text = dataGridViewproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtprice.Text = dataGridViewproduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            Qty = Convert.ToInt32(dataGridViewproduct.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void dataGridViewuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dataGridViewuser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcustname.Text = dataGridViewuser.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcustid.Text == "")
                {
                    MessageBox.Show("Please select a customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtpid.Text == "")
                {
                    MessageBox.Show("Please select a product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Insert order?", "Saving record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("insert into orderTable(odate,pid,cid,qty,price,total) values(@odate,@pid,@cid,@qty,@price,@total)", conn);
                    cmd.Parameters.AddWithValue("@odate", odatepick.Value);
                    cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(txtpid.Text));
                    cmd.Parameters.AddWithValue("@cid", Convert.ToInt32(txtcustid.Text));
                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(UDQty.Value));
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtprice.Text));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt32(txttotal.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("order inserted!");


                    cmd = new SqlCommand("update newprodTB set Qty =  (Qty-@Qty) where PID like '" + txtpid.Text + "'", conn);
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(UDQty.Value));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Clear()
        {
            txtcustid.Clear();
            txtcustname.Clear();

            txtpid.Clear();
            txtpname.Clear();

            txtprice.Clear();
            UDQty.Value = 0;
            txttotal.Clear();
            odatepick.Value = DateTime.Now;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            btninsert.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
