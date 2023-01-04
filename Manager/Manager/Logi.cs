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
    public partial class Logi : Form
    {
        private bool isMousePress = false;
        private Point _clickPoint;
        private Point _formStartPoint;

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\Manager\Manager\Database1.mdf;Integrated Security=True");

        //private int label = Form1.StaffId;
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Logi_tb";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LogiGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Logi()
        {
            InitializeComponent();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress)
            {
                var cursorOffsetPoint = new Point( //считаем смещение курсора от старта
                    Cursor.Position.X - _clickPoint.X,
                    Cursor.Position.Y - _clickPoint.Y);

                Location = new Point( //смещаем форму от начальной позиции в соответствии со смещением курсора
                    _formStartPoint.X + cursorOffsetPoint.X,
                    _formStartPoint.Y + cursorOffsetPoint.Y);
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DATA.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
            
            populate();

            LogiGridview.Columns["IdRecord"].Visible = false;
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            MainForm mnForm = new MainForm();
            this.Hide();
            mnForm.Show();
        }

        private void LogiGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1 && LogiGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                LogiGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
               
            }
        }

        private void LogiGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DATA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Logi_tb";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("The history of changes has been cleared");
            Con.Close();
            populate();
        }
    }
}
