using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Manager
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\Manager\Manager\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        public static int StaffId { get; set; }
        public static string StaffName { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
           
                SqlDataAdapter sda = new SqlDataAdapter("select StaffId from Staff_tbl where Staffname='"+usernametb.Text+
                                                        "' and Staffpassword='"+passwordtb.Text+"'", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() != "")
                {

                    StaffId=Convert.ToInt32(dt.Rows[0][0].ToString());
                    StaffName = usernametb.Text;
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            
            sqlConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }
        private bool isMousePress = false;
        private Point _clickPoint;
        private Point _formStartPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
          
            isMousePress = false;
            _clickPoint = Point.Empty;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}