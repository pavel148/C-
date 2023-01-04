using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager.Properties;

namespace Manager
{
    public partial class SplachForm : Form
    {
       
        private bool isMousePress = false;
        private Point _clickPoint;
        private Point _formStartPoint;

        public SplachForm()
        {
            InitializeComponent();
        }

        private int STARTPOINT = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            STARTPOINT++;
            egoldsProgressBar1.Value = STARTPOINT;
            if (egoldsProgressBar1.Value == 100)
            {
                egoldsProgressBar1.Value = 0;
                timer1.Stop();
                Form1 Login = new Form1();
                Login.Show();
                this.Hide();
            }
        }

        private void SplachForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void SplachForm_MouseMove(object sender, MouseEventArgs e)
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

        private void SplachForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
        }

        private void SplachForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
        }
    }
}
