namespace Manager
{
    partial class StaffInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.DATA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Staffnametbl = new System.Windows.Forms.TextBox();
            this.staffidbl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StaffGridview = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StaffEditBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.staffgendercb = new System.Windows.Forms.ComboBox();
            this.StaffSearchtb = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.Staffphone = new System.Windows.Forms.TextBox();
            this.BACK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridview)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.label6.TabIndex = 5;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DATA
            // 
            this.DATA.AutoSize = true;
            this.DATA.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DATA.Location = new System.Drawing.Point(879, 60);
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
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff information";
            // 
            // Staffnametbl
            // 
            this.Staffnametbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Staffnametbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Staffnametbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staffnametbl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Staffnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Staffnametbl.Location = new System.Drawing.Point(12, 201);
            this.Staffnametbl.Multiline = true;
            this.Staffnametbl.Name = "Staffnametbl";
            this.Staffnametbl.Size = new System.Drawing.Size(209, 35);
            this.Staffnametbl.TabIndex = 3;
            this.Staffnametbl.Text = "StaffName";
            this.Staffnametbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Staffnametbl.UseSystemPasswordChar = true;
            // 
            // staffidbl
            // 
            this.staffidbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.staffidbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.staffidbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffidbl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffidbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffidbl.Location = new System.Drawing.Point(12, 137);
            this.staffidbl.Multiline = true;
            this.staffidbl.Name = "staffidbl";
            this.staffidbl.Size = new System.Drawing.Size(209, 35);
            this.staffidbl.TabIndex = 4;
            this.staffidbl.Text = "Staffid";
            this.staffidbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.staffidbl.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.e8fd8d676afcaa134eed47382c24104f;
            this.pictureBox1.Location = new System.Drawing.Point(798, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StaffGridview
            // 
            this.StaffGridview.AllowUserToAddRows = false;
            this.StaffGridview.AllowUserToDeleteRows = false;
            this.StaffGridview.AllowUserToResizeColumns = false;
            this.StaffGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.StaffGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffGridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StaffGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StaffGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffGridview.EnableHeadersVisualStyles = false;
            this.StaffGridview.Location = new System.Drawing.Point(320, 197);
            this.StaffGridview.Name = "StaffGridview";
            this.StaffGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StaffGridview.RowHeadersVisible = false;
            this.StaffGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.StaffGridview.RowTemplate.Height = 25;
            this.StaffGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StaffGridview.Size = new System.Drawing.Size(568, 343);
            this.StaffGridview.TabIndex = 14;
            this.StaffGridview.UseWaitCursor = true;
            this.StaffGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridview_CellContentClick);
            this.StaffGridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StaffGridview_CellMouseClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(170, 469);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 42);
            this.DeleteBtn.TabIndex = 10;
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
            this.StaffEditBtn.Location = new System.Drawing.Point(91, 469);
            this.StaffEditBtn.Name = "StaffEditBtn";
            this.StaffEditBtn.Size = new System.Drawing.Size(73, 42);
            this.StaffEditBtn.TabIndex = 11;
            this.StaffEditBtn.Text = "EDIT";
            this.StaffEditBtn.UseVisualStyleBackColor = true;
            this.StaffEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(692, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 12;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Addbtn.Location = new System.Drawing.Point(12, 469);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(73, 42);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // staffgendercb
            // 
            this.staffgendercb.AutoCompleteCustomSource.AddRange(new string[] {
            "Man",
            "Girl"});
            this.staffgendercb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffgendercb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.staffgendercb.FormattingEnabled = true;
            this.staffgendercb.Items.AddRange(new object[] {
            "Man",
            "Girl"});
            this.staffgendercb.Location = new System.Drawing.Point(16, 399);
            this.staffgendercb.Name = "staffgendercb";
            this.staffgendercb.Size = new System.Drawing.Size(210, 29);
            this.staffgendercb.TabIndex = 9;
            this.staffgendercb.Text = "Gender";
            // 
            // StaffSearchtb
            // 
            this.StaffSearchtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.StaffSearchtb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.StaffSearchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffSearchtb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StaffSearchtb.Location = new System.Drawing.Point(477, 102);
            this.StaffSearchtb.Multiline = true;
            this.StaffSearchtb.Name = "StaffSearchtb";
            this.StaffSearchtb.Size = new System.Drawing.Size(215, 48);
            this.StaffSearchtb.TabIndex = 7;
            this.StaffSearchtb.Text = "Staff Search";
            this.StaffSearchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StaffSearchtb.UseSystemPasswordChar = true;
            // 
            // passwordtb
            // 
            this.passwordtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.passwordtb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passwordtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.passwordtb.Location = new System.Drawing.Point(16, 326);
            this.passwordtb.Multiline = true;
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(209, 35);
            this.passwordtb.TabIndex = 2;
            this.passwordtb.Text = "Password";
            this.passwordtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordtb.UseSystemPasswordChar = true;
            // 
            // Staffphone
            // 
            this.Staffphone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.Staffphone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Staffphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staffphone.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Staffphone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Staffphone.Location = new System.Drawing.Point(16, 266);
            this.Staffphone.Multiline = true;
            this.Staffphone.Name = "Staffphone";
            this.Staffphone.Size = new System.Drawing.Size(209, 35);
            this.Staffphone.TabIndex = 2;
            this.Staffphone.Text = "Phone Num";
            this.Staffphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Staffphone.UseSystemPasswordChar = true;
            // 
            // BACK
            // 
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BACK.Location = new System.Drawing.Point(82, 517);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(94, 42);
            this.BACK.TabIndex = 16;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // StaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 581);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StaffGridview);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.StaffEditBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.staffgendercb);
            this.Controls.Add(this.StaffSearchtb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.Staffphone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Staffnametbl);
            this.Controls.Add(this.staffidbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this.StaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label DATA;
        private Label label1;
        private TextBox Staffnametbl;
        private TextBox staffidbl;
        private PictureBox pictureBox1;
        private DataGridView StaffGridview;
        private Button DeleteBtn;
        private Button StaffEditBtn;
        private Button button4;
        private Button Addbtn;
        private ComboBox staffgendercb;
        private TextBox StaffSearchtb;
        private System.Windows.Forms.Timer timer1;
        private TextBox passwordtb;
        private TextBox Staffphone;
        private Label label6;
        private Button BACK;
    }
}