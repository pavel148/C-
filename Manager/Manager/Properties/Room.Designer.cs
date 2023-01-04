namespace Manager.Properties
{
    partial class Room
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StaffEditBtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.RoomPhone = new System.Windows.Forms.TextBox();
            this.RoomNumber = new System.Windows.Forms.TextBox();
            this.RoomGridview = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.RoomSearchtb = new System.Windows.Forms.TextBox();
            this.BACK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label6.TabIndex = 27;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DATA
            // 
            this.DATA.AutoSize = true;
            this.DATA.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DATA.Location = new System.Drawing.Point(858, 64);
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
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rooms Informations";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(184, 452);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 42);
            this.DeleteBtn.TabIndex = 19;
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
            this.StaffEditBtn.Location = new System.Drawing.Point(105, 452);
            this.StaffEditBtn.Name = "StaffEditBtn";
            this.StaffEditBtn.Size = new System.Drawing.Size(73, 42);
            this.StaffEditBtn.TabIndex = 20;
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
            this.Addbtn.Location = new System.Drawing.Point(26, 452);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(73, 42);
            this.Addbtn.TabIndex = 21;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // RoomPhone
            // 
            this.RoomPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.RoomPhone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RoomPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomPhone.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomPhone.Location = new System.Drawing.Point(36, 184);
            this.RoomPhone.Multiline = true;
            this.RoomPhone.Name = "RoomPhone";
            this.RoomPhone.Size = new System.Drawing.Size(209, 35);
            this.RoomPhone.TabIndex = 16;
            this.RoomPhone.Text = "Room Phone";
            this.RoomPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomPhone.UseSystemPasswordChar = true;
            this.RoomPhone.TextChanged += new System.EventHandler(this.RoomPhone_TextChanged);
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.RoomNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomNumber.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomNumber.Location = new System.Drawing.Point(36, 120);
            this.RoomNumber.Multiline = true;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(209, 35);
            this.RoomNumber.TabIndex = 17;
            this.RoomNumber.Text = "Room Number";
            this.RoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomNumber.UseSystemPasswordChar = true;
            this.RoomNumber.TextChanged += new System.EventHandler(this.RoomNumber_TextChanged);
            // 
            // RoomGridview
            // 
            this.RoomGridview.AllowUserToAddRows = false;
            this.RoomGridview.AllowUserToDeleteRows = false;
            this.RoomGridview.AllowUserToResizeColumns = false;
            this.RoomGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.RoomGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomGridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.RoomGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RoomGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomGridview.EnableHeadersVisualStyles = false;
            this.RoomGridview.Location = new System.Drawing.Point(384, 174);
            this.RoomGridview.Name = "RoomGridview";
            this.RoomGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RoomGridview.RowHeadersVisible = false;
            this.RoomGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.RoomGridview.RowTemplate.Height = 25;
            this.RoomGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RoomGridview.Size = new System.Drawing.Size(568, 343);
            this.RoomGridview.TabIndex = 22;
            this.RoomGridview.UseWaitCursor = true;
            this.RoomGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridview_CellContentClick);
            this.RoomGridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomGridview_CellMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.e8fd8d676afcaa134eed47382c24104f;
            this.pictureBox1.Location = new System.Drawing.Point(808, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
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
            this.button4.Location = new System.Drawing.Point(702, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 25;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RoomSearchtb
            // 
            this.RoomSearchtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.RoomSearchtb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RoomSearchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomSearchtb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomSearchtb.Location = new System.Drawing.Point(487, 106);
            this.RoomSearchtb.Multiline = true;
            this.RoomSearchtb.Name = "RoomSearchtb";
            this.RoomSearchtb.Size = new System.Drawing.Size(215, 48);
            this.RoomSearchtb.TabIndex = 24;
            this.RoomSearchtb.Text = "Room Search";
            this.RoomSearchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomSearchtb.UseSystemPasswordChar = true;
            this.RoomSearchtb.TextChanged += new System.EventHandler(this.RoomSearchtb_TextChanged);
            // 
            // BACK
            // 
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BACK.Location = new System.Drawing.Point(84, 513);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(94, 42);
            this.BACK.TabIndex = 27;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1039, 581);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RoomSearchtb);
            this.Controls.Add(this.RoomGridview);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StaffEditBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.RoomPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label DATA;
        private Label label1;
        private Button DeleteBtn;
        private Button StaffEditBtn;
        private Button Addbtn;
        private TextBox RoomPhone;
        private TextBox RoomNumber;
        private DataGridView RoomGridview;
        private PictureBox pictureBox1;
        private Button button4;
        private TextBox RoomSearchtb;
        private Label label6;
        private Button BACK;
    }
}