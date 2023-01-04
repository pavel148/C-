namespace Manager
{
    partial class ReservationInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.DATA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ReservationSearchtb = new System.Windows.Forms.TextBox();
            this.ReservationGridview = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StaffEditBtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.ReserId = new System.Windows.Forms.TextBox();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.ClientName1 = new System.Windows.Forms.ComboBox();
            this.RoomId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DATA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 100);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(1004, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DATA
            // 
            this.DATA.AutoSize = true;
            this.DATA.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DATA.Location = new System.Drawing.Point(846, 59);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(62, 25);
            this.DATA.TabIndex = 1;
            this.DATA.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.e8fd8d676afcaa134eed47382c24104f;
            this.pictureBox1.Location = new System.Drawing.Point(952, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(846, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 34;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReservationSearchtb
            // 
            this.ReservationSearchtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.ReservationSearchtb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ReservationSearchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationSearchtb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReservationSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReservationSearchtb.Location = new System.Drawing.Point(631, 113);
            this.ReservationSearchtb.Multiline = true;
            this.ReservationSearchtb.Name = "ReservationSearchtb";
            this.ReservationSearchtb.Size = new System.Drawing.Size(215, 48);
            this.ReservationSearchtb.TabIndex = 33;
            this.ReservationSearchtb.Text = "Reservation Search";
            this.ReservationSearchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReservationSearchtb.UseSystemPasswordChar = true;
            // 
            // ReservationGridview
            // 
            this.ReservationGridview.AllowUserToAddRows = false;
            this.ReservationGridview.AllowUserToDeleteRows = false;
            this.ReservationGridview.AllowUserToResizeColumns = false;
            this.ReservationGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.ReservationGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReservationGridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ReservationGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ReservationGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReservationGridview.EnableHeadersVisualStyles = false;
            this.ReservationGridview.Location = new System.Drawing.Point(384, 180);
            this.ReservationGridview.Name = "ReservationGridview";
            this.ReservationGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ReservationGridview.RowHeadersVisible = false;
            this.ReservationGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ReservationGridview.RowTemplate.Height = 25;
            this.ReservationGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReservationGridview.Size = new System.Drawing.Size(568, 343);
            this.ReservationGridview.TabIndex = 32;
            this.ReservationGridview.UseWaitCursor = true;
            this.ReservationGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridview_CellContentClick);
            this.ReservationGridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ReservationGridview_CellMouseClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(184, 458);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 42);
            this.DeleteBtn.TabIndex = 29;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // StaffEditBtn
            // 
            this.StaffEditBtn.FlatAppearance.BorderSize = 0;
            this.StaffEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffEditBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffEditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StaffEditBtn.Location = new System.Drawing.Point(105, 458);
            this.StaffEditBtn.Name = "StaffEditBtn";
            this.StaffEditBtn.Size = new System.Drawing.Size(73, 42);
            this.StaffEditBtn.TabIndex = 30;
            this.StaffEditBtn.Text = "EDIT";
            this.StaffEditBtn.UseVisualStyleBackColor = true;
            this.StaffEditBtn.Click += new System.EventHandler(this.StaffEditBtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Addbtn.Location = new System.Drawing.Point(26, 458);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(73, 42);
            this.Addbtn.TabIndex = 31;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // ReserId
            // 
            this.ReserId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.ReserId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ReserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReserId.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReserId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReserId.Location = new System.Drawing.Point(36, 126);
            this.ReserId.Multiline = true;
            this.ReserId.Name = "ReserId";
            this.ReserId.Size = new System.Drawing.Size(209, 35);
            this.ReserId.TabIndex = 28;
            this.ReserId.Text = "Reservation id";
            this.ReserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReserId.UseSystemPasswordChar = true;
            // 
            // dateIn
            // 
            this.dateIn.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateIn.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIn.Location = new System.Drawing.Point(143, 302);
            this.dateIn.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateIn.MinDate = new System.DateTime(1933, 1, 1, 0, 0, 0, 0);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(165, 27);
            this.dateIn.TabIndex = 36;
            this.dateIn.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(26, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DateLn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(26, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "DateOut";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateOut
            // 
            this.dateOut.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateOut.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOut.Location = new System.Drawing.Point(143, 361);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(165, 27);
            this.dateOut.TabIndex = 36;
            this.dateOut.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            this.dateOut.ValueChanged += new System.EventHandler(this.dateOut_ValueChanged);
            // 
            // ClientName1
            // 
            this.ClientName1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientName1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientName1.FormattingEnabled = true;
            this.ClientName1.Location = new System.Drawing.Point(101, 191);
            this.ClientName1.Name = "ClientName1";
            this.ClientName1.Size = new System.Drawing.Size(207, 27);
            this.ClientName1.TabIndex = 38;
            this.ClientName1.Text = "ClientName";
            // 
            // RoomId
            // 
            this.RoomId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomId.FormattingEnabled = true;
            this.RoomId.Location = new System.Drawing.Point(101, 246);
            this.RoomId.Name = "RoomId";
            this.RoomId.Size = new System.Drawing.Size(207, 27);
            this.RoomId.TabIndex = 38;
            this.RoomId.Text = "RoomId";
            this.RoomId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RoomId_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(26, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Client";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(26, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // BACK
            // 
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BACK.Location = new System.Drawing.Point(84, 506);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(94, 42);
            this.BACK.TabIndex = 39;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(271, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "editing";
            // 
            // ReservationInfo
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1039, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.RoomId);
            this.Controls.Add(this.ClientName1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ReservationSearchtb);
            this.Controls.Add(this.ReservationGridview);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.StaffEditBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ReserId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInfo";
            this.Load += new System.EventHandler(this.ReservationInfo_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReservationInfo_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label DATA;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button4;
        private TextBox ReservationSearchtb;
        private DataGridView ReservationGridview;
        private Button DeleteBtn;
        private Button StaffEditBtn;
        private Button Addbtn;
        private TextBox ReserId;
        private TextBox ClientName;
        private DateTimePicker dateIn;
        private Label label2;
        private Label label3;
        private DateTimePicker dateOut;
        private ComboBox ClientName1;
        private ComboBox RoomId;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BACK;
        private Label label7;
    }
}