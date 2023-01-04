namespace Manager.Properties
{
    partial class Clientinfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.DATA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientidbl = new System.Windows.Forms.TextBox();
            this.clientnametbl = new System.Windows.Forms.TextBox();
            this.clientphone = new System.Windows.Forms.TextBox();
            this.clientctrycb = new System.Windows.Forms.ComboBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClientSearchtb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClientGridview = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BACK = new System.Windows.Forms.Button();
            this.telephon = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.label6.TabIndex = 7;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DATA
            // 
            this.DATA.AutoSize = true;
            this.DATA.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DATA.Location = new System.Drawing.Point(808, 61);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(62, 25);
            this.DATA.TabIndex = 1;
            this.DATA.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client information";
            // 
            // clientidbl
            // 
            this.clientidbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.clientidbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.clientidbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientidbl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientidbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientidbl.Location = new System.Drawing.Point(47, 137);
            this.clientidbl.Multiline = true;
            this.clientidbl.Name = "clientidbl";
            this.clientidbl.Size = new System.Drawing.Size(209, 35);
            this.clientidbl.TabIndex = 1;
            this.clientidbl.Text = "Client Id";
            this.clientidbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientidbl.UseSystemPasswordChar = true;
            // 
            // clientnametbl
            // 
            this.clientnametbl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.clientnametbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.clientnametbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientnametbl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientnametbl.Location = new System.Drawing.Point(47, 201);
            this.clientnametbl.Multiline = true;
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.Size = new System.Drawing.Size(209, 35);
            this.clientnametbl.TabIndex = 1;
            this.clientnametbl.Text = "ClientName";
            this.clientnametbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientnametbl.UseSystemPasswordChar = true;
            // 
            // clientphone
            // 
            this.clientphone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.clientphone.BackColor = System.Drawing.SystemColors.HighlightText;
            this.clientphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientphone.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientphone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientphone.Location = new System.Drawing.Point(47, 268);
            this.clientphone.Multiline = true;
            this.clientphone.Name = "clientphone";
            this.clientphone.Size = new System.Drawing.Size(209, 35);
            this.clientphone.TabIndex = 1;
            this.clientphone.Text = "Phone Num";
            this.clientphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientphone.UseSystemPasswordChar = true;
            // 
            // clientctrycb
            // 
            this.clientctrycb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientctrycb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientctrycb.FormattingEnabled = true;
            this.clientctrycb.Items.AddRange(new object[] {
            "RUSSIA",
            "USA",
            "SPAIN",
            "INDIA",
            "CHINA",
            "FRANCE",
            "DRC",
            "ZAMBIA",
            "NIGERIA",
            "CONGO"});
            this.clientctrycb.Location = new System.Drawing.Point(46, 339);
            this.clientctrycb.Name = "clientctrycb";
            this.clientctrycb.Size = new System.Drawing.Size(210, 29);
            this.clientctrycb.TabIndex = 2;
            this.clientctrycb.Text = "Country";
            this.clientctrycb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Addbtn.Location = new System.Drawing.Point(21, 403);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(73, 42);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(100, 403);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(73, 42);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(183, 403);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 42);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClientSearchtb
            // 
            this.ClientSearchtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.ClientSearchtb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSearchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientSearchtb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientSearchtb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClientSearchtb.Location = new System.Drawing.Point(509, 106);
            this.ClientSearchtb.Multiline = true;
            this.ClientSearchtb.Name = "ClientSearchtb";
            this.ClientSearchtb.Size = new System.Drawing.Size(215, 48);
            this.ClientSearchtb.TabIndex = 1;
            this.ClientSearchtb.Text = "Client Search";
            this.ClientSearchtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientSearchtb.UseSystemPasswordChar = true;
            this.ClientSearchtb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(721, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientGridview
            // 
            this.ClientGridview.AllowUserToAddRows = false;
            this.ClientGridview.AllowUserToDeleteRows = false;
            this.ClientGridview.AllowUserToResizeColumns = false;
            this.ClientGridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClientGridview.EnableHeadersVisualStyles = false;
            this.ClientGridview.Location = new System.Drawing.Point(329, 171);
            this.ClientGridview.Name = "ClientGridview";
            this.ClientGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClientGridview.RowHeadersVisible = false;
            this.ClientGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ClientGridview.RowTemplate.Height = 25;
            this.ClientGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClientGridview.Size = new System.Drawing.Size(568, 343);
            this.ClientGridview.TabIndex = 5;
            this.ClientGridview.UseWaitCursor = true;
            this.ClientGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridview_CellContentClick);
            this.ClientGridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientGridview_CellMouseClick);
            this.ClientGridview.Click += new System.EventHandler(this.ClientGridview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager.Properties.Resources.e8fd8d676afcaa134eed47382c24104f;
            this.pictureBox1.Location = new System.Drawing.Point(827, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BACK
            // 
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BACK.Location = new System.Drawing.Point(47, 502);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(94, 42);
            this.BACK.TabIndex = 4;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // telephon
            // 
            this.telephon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.telephon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.telephon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telephon.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telephon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.telephon.Location = new System.Drawing.Point(288, 106);
            this.telephon.Multiline = true;
            this.telephon.Name = "telephon";
            this.telephon.Size = new System.Drawing.Size(215, 48);
            this.telephon.TabIndex = 1;
            this.telephon.Text = "Phone Search";
            this.telephon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telephon.UseSystemPasswordChar = true;
            this.telephon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1.Location = new System.Drawing.Point(893, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 42);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Phone \r\nSearch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 581);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClientGridview);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.clientctrycb);
            this.Controls.Add(this.clientphone);
            this.Controls.Add(this.clientnametbl);
            this.Controls.Add(this.telephon);
            this.Controls.Add(this.ClientSearchtb);
            this.Controls.Add(this.clientidbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientinfo";
            this.Load += new System.EventHandler(this.Clientinfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Clientinfo_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox clientidbl;
        private TextBox clientnametbl;
        private TextBox clientphone;
        private ComboBox clientctrycb;
        private DataGridView ClientGridview;
        private Button Addbtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private TextBox ClientSearchtb;
        private Button button4;
        private Label DATA;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button BACK;
        private TextBox telephon;
        private CheckBox checkBox1;
    }
}