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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\Manager\Manager\Database1.mdf;Integrated Security=True");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room_tb";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tb values(" + RoomNumber.Text + ",'" + RoomPhone.Text + "')", Con);
            cmd.ExecuteNonQuery();
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'inserting', 'Room_tb', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();
            MessageBox.Show("Room Successfully added");
            Con.Close();
            populate();
        }

       
        private void Room_Load(object sender, EventArgs e)
        {
            populate();
            DATA.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void RoomGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && RoomGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                RoomGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                RoomNumber.Text = RoomGridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                RoomPhone.Text = RoomGridview.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Room_tb where RoomId =" + RoomNumber.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'deleting', 'Room_tb', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Deleted");

            Con.Close();
            populate();
        }

        private void StaffEditBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            
            Con.Open();
            string myquery = "UPDATE Room_tb set RoomPhone = '" + RoomPhone.Text + "',"  +  "'where RoomId = " + RoomNumber.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'updating', 'Room_tb', SYSDATETIME())", Con);
            log0.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Successfully Edited");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Room_tb where RoomId = '" + RoomSearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void RoomGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomSearchtb_TextChanged(object sender, EventArgs e)
        {

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
    }
}
