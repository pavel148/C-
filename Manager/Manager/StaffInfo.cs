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

namespace Manager
{
    public partial class StaffInfo : Form
    {

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\Manager\Manager\Database1.mdf;Integrated Security=True");

        public StaffInfo()
        {
            InitializeComponent();
            
        }
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Staff_tbl values(" + staffidbl.Text + ",'" + Staffnametbl.Text + "','" + Staffphone.Text + "','" + staffgendercb.SelectedItem.ToString() + "','" + passwordtb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Successfully added");
                SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'inserting',  'Staff_tbl', SYSDATETIME())", Con);
                log0.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry buddy you entered incorrect data   " + ex.Message);
                SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'error inserting', ' Staff_tbl', SYSDATETIME())", Con);
                log0.ExecuteNonQuery();
            }
            Con.Close();
            populate();
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            populate();
            DATA.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Staff_tbl set Staffname = '" + Staffnametbl.Text + "',staffphone ='" +
                             Staffphone.Text + "',gender='" + staffgendercb.SelectedItem.ToString() + "',Staffpassword ='" +
                             passwordtb.Text + "'where StaffId = " + staffidbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'updating', ' Staff_tbl', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();
            MessageBox.Show("Staff Successfully Edited");
            Con.Close();
            populate();
        }

        private void StaffGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void StaffGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && StaffGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                StaffGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                staffidbl.Text = StaffGridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                Staffnametbl.Text = StaffGridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                Staffphone.Text = StaffGridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                passwordtb.Text = StaffGridview.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (staffgendercb.Items.Contains(StaffGridview.Rows[e.RowIndex].Cells[3].Value.ToString()))
                {
                    staffgendercb.Text = StaffGridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            string query = "delete from Staff_tbl where StaffId =" + staffidbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            if (Staffnametbl.Text != "Admin")
            {
                MessageBox.Show("Staff Successfully Deleted");
                SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'deleting', ' Staff_tbl', SYSDATETIME())", Con);
                log0.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Sorry you can't delete the admin");
                SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'error deleting', ' Staff_tbl', SYSDATETIME())", Con);
                log0.ExecuteNonQuery();
            }
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Staff_tbl where StaffName = '" + StaffSearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            MainForm mnf = new MainForm();
            mnf.Show();
            this.Hide();
        }
    }
}
