using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager.Properties;

namespace Manager
{
    public partial class ReservationInfo : Form
    {
        private SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\Manager\Manager\Database1.mdf;Integrated Security=True");
        private DataGridViewCellMouseEventArgs Eglbl;
        private DateTime dtIn;
        private DateTime dtOut;
        private bool editing=false;
        private string idNow;
        private string resIdNow;

        public ReservationInfo()
        {
            InitializeComponent();
        }

        
      
      
        private DateTime today;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateIn.Value,today);
            if (res < 0)
                MessageBox.Show("Wrong Date For Reservation");
            dtIn=dateIn.Value.Date;
            fillRoomcombo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReservationGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ReservationGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void fillRoomcombo()
        {
            Con.Open();
            string roomfree = "";


            roomfree = "select RoomId from(select RoomId from Room_tb) t1 where " +
                       "RoomId NOT IN(select Room from Reservation_tbl where (DateIn between '" + dtIn + "' and '" +
                       dtOut + "') or (DateOut between'" + dtIn + "' and '" + dtOut + "')or" +
                       "(DateIn <= '" + dtIn + "' and DateOut >= '" + dtOut + "'))";
            SqlCommand cmd = new SqlCommand(roomfree, Con);////////////////////////////!!!!!!!!!11
            SqlDataReader rdr;
            
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);
            
            if (editing)
            {
                roomfree = "select Count(Room) from Reservation_tbl where Room = '" + idNow + "' and " + "ResId!='"+resIdNow+

                           "'and ((DateIn between '" + dtIn + "' and '" + dtOut + "') or " +
                           "(DateOut between'" + dtIn + "' and '" + dtOut + "')or" +
                           "(DateIn <= '" + dtIn + "' and DateOut >= '" + dtOut + "')) group by Room ";
                //Неправильный синтаксис рядом с '1'.
                //    Незакрытая кавычка после символьной строки ') группировать по комнатам '."
                cmd = new SqlCommand(roomfree, Con);////////////////////////////!!!!!!!!!11
                rdr = cmd.ExecuteReader();
                if (Convert.ToInt32(rdr.Read()) == 0)
                {

                    dt.Rows.Add(idNow);
                }

            }

            RoomId.Refresh();
            RoomId.ValueMember = "RoomId";
            RoomId.DataSource = dt;
            RoomId.DisplayMember = dt.Columns["RoomId"].ColumnName;
            Con.Close();
        }
        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);
            ClientName1.ValueMember = "ClientName";
            ClientName1.DataSource = dt;
            Con.Close();
        }
        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            today = dateIn.Value;
            dtIn=dateIn.Value.Date;
            dtOut=dateOut.Value.Date;
            fillRoomcombo();
            fillClientcombo();
            populate();
            DATA.Text=DateTime.Today.Day.ToString()+"-"+ DateTime.Today.Month.ToString()+"-"+ DateTime.Today.Year.ToString();
            label7.Visible=false;
        }

        private void dateOut_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateOut.Value,dateIn.Value);
            if (res < 0)
                MessageBox.Show("WrongDataout. check once more");
            dtOut = dateOut.Value.Date;
            fillRoomcombo();
        }


       
      
        private void Addbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values(" + ReserId.Text + ",'" +
                                                ClientName1.SelectedValue.ToString() + "','" + RoomId.SelectedValue.ToString() +
                                                "','" + dateIn.Value.Date + "','" + dateOut.Value.Date + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Successfully added");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry buddy you entered incorrect data "+ex.ToString());
            }
            SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'inserting', 'Reservation_tbl', SYSDATETIME()" + ")", Con);
            log0.ExecuteNonQuery();
            Con.Close();
           // updateroomstate();
            populate();
        }

        private void StaffEditBtn_Click(object sender, EventArgs e)
        {
            if (ReserId.Text == "")
            {
                MessageBox.Show("Empty ResId, Enter The reservation Id");
            }
            else
            {
                try
                {

                    Con.Open();
                    string myquery = "UPDATE Reservation_tbl set Client = '" + ClientName1.SelectedValue.ToString() +
                                     "',Room ='" + RoomId.SelectedValue.ToString() + "',DateIn='" + dateIn.Value.ToString() +
                                     "',DateOut= '" + dateOut.Value.ToString() + "'where ResId = " + ReserId.Text + ";";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Successfully Edited");
                    SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'updating', 'Reservation_tbl', SYSDATETIME()" + ")", Con);
                    log0.ExecuteNonQuery();
                    populate();
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry buddy you entered incorrect data");
                    SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'error updating', 'Reservation_tbl', SYSDATETIME()" + ")", Con);
                    log0.ExecuteNonQuery();
                }
               
               
                Con.Close();
                populate();
            }
           
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ReserId.Text != "")
            {
                try
                {
                    Con.Open();
                    string query = "delete from Reservation_tbl where ResId =" + ReserId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Successfully Deleted");
                    SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'deleting', 'Reservation_tbl', SYSDATETIME()" + ")", Con);
                    log0.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry buddy you entered incorrect data");
                    SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'error deleting', 'Reservation_tbl', SYSDATETIME()" + ")", Con);
                    log0.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Enter the Reservation to be deleted");
            }

            Con.Close();
            //updateroomondelete();
            populate();
        }

        private void ReservationGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var formats = new[]
            {
                "dd/MM/yyyy",
                "dd/MM/yyyy H:mm",
                "dd/MM/yyyy H:mm tt",
                "dd/MM/yyyy H:mm:ss",
                "dd/MM/yyyy H:mm:ss tt",
                "dd/MM/yyyy HH:mm",
                "dd/MM/yyyy HH:mm tt",
                "dd/MM/yyyy HH:mm:ss",
                "dd/MM/yyyy HH:mm:ss tt",
            };
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && ReservationGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ReservationGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ReserId.Text = ReservationGridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                Eglbl= e;
                editing = true;
                label7.Visible = true;
                idNow = ReservationGridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                resIdNow= ReservationGridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                dateIn.Value =(DateTime.ParseExact(ReservationGridview.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(".","/") , formats, CultureInfo.InvariantCulture, DateTimeStyles.None) );
                dateOut.Value = (DateTime.ParseExact(ReservationGridview.Rows[e.RowIndex].Cells[4].Value.ToString().Replace(".", "/"), formats, CultureInfo.InvariantCulture, DateTimeStyles.None));
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from Reservation_tbl where ResId = '" + ReservationSearchtb.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ReservationGridview.DataSource = ds.Tables[0];
                SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'searching', 'Reservation_tbl', SYSDATETIME()" + ")", Con);
                log0.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry buddy you entered incorrect data");
                SqlCommand log0 = new SqlCommand("insert into Logi_tb (UserId, UserName, Action, TableName, Time) values(" + Form1.StaffId + ",'" + Form1.StaffName + "', 'error searching', 'Reservation_tbl', SYSDATETIME()" + ")", Con);
                log0.ExecuteNonQuery();
            }
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

        private void RoomId_MouseClick(object sender, MouseEventArgs e)
        {
            fillRoomcombo();
        }

        private void ReservationInfo_MouseClick(object sender, MouseEventArgs e)
        {
            editing=false;
            label7.Visible=false;
        }
    }
}
