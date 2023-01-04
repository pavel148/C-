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

namespace Manager.Properties
{
    public partial class Clientinfo : Form
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\Manager\Manager\Database1.mdf;Integrated Security=True") ;
        private string Myquery="";
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Clientinfo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DATA.Text = DateTime.Now.ToLongTimeString();

        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            //DATA.Text = DateTime.Now.ToLongTimeString();
            // timer1.Start();
            DATA.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
            populate();
            if (checkBox1.Checked)
            {
                telephon.Visible = true;
            }
            else if (!checkBox1.Checked)
            {
                telephon.Visible = false;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values("+clientidbl.Text+",'"+clientnametbl.Text+"','"+clientphone.Text+"','"+clientctrycb.SelectedItem.ToString()+"')",Con);
            cmd.ExecuteNonQuery();
         
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId +",'"+ Form1.StaffName+"', 'inserting', 'Client_tbl', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();
            MessageBox.Show("Client Successfully added");
            Con.Close();
            populate();

        }

        private void ClientGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //clientidbl.Text = ClientGridview.SelectedRows[0].Cells[0].Value.ToString();
            //clientnametbl.Text = ClientGridview.SelectedRows[0].Cells[1].Value.ToString();
            //clientphone.Text = ClientGridview.SelectedRows[0].Cells[2].Value.ToString();
            //MessageBox.Show(ClientGridview.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Client_tbl set ClientName = '" + clientnametbl.Text + "',ClientPhone ='" +
                             clientphone.Text + "',ClientCountry='" + clientctrycb.SelectedItem.ToString() + "'where ClientId = "+clientidbl.Text+";" ;
            SqlCommand cmd = new SqlCommand(myquery,Con);
            cmd.ExecuteNonQuery();
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'updating', 'Client_tbl', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();

            MessageBox.Show("Client Successfully Edited");
            Con.Close();
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Client_tbl where ClientId ="+clientidbl.Text+"";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'deleting', 'Client_tbl', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted");
            Con.Close();
            populate();
        }

        private void ClientGridview_Click(object sender, EventArgs e)
        {
            
        }

        private void ClientGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>-1&& e.ColumnIndex>-1 && ClientGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ClientGridview.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
                clientidbl.Text = ClientGridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                clientnametbl.Text = ClientGridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                clientphone.Text = ClientGridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (clientctrycb.Items.Contains(ClientGridview.Rows[e.RowIndex].Cells[3].Value.ToString()))
                {
                    clientctrycb.Text = ClientGridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            
            if (checkBox1.Checked)
            {
                 this.Myquery = "select * from Client_tbl where ClientName = '" + ClientSearchtb.Text + "'and ClientPhone = '"+telephon.Text+"'";
            }
            else if (!checkBox1.Checked)
            {
                this.Myquery = "select * from Client_tbl where ClientName = '" + ClientSearchtb.Text + "'";
            }
            
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'selecting', 'Client_tbl', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            MainForm mnf = new MainForm();
            mnf.Show();
            this.Hide();
        }

        private void Clientinfo_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox1.Checked)
            {
                telephon.Visible = true;
            }
            else if (!checkBox1.Checked)
            {
                telephon.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                telephon.Visible = true;
            }
            else if (!checkBox1.Checked)
            {
                telephon.Visible = false;
            }
        }
    }
}
