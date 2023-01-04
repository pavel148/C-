namespace Manager
{
    partial class SplachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplachForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.egoldsProgressBar1 = new Manager.Properties.EgoldsProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(168, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.egoldsProgressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 46);
            this.panel2.TabIndex = 1;
            // 
            // egoldsProgressBar1
            // 
            this.egoldsProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.egoldsProgressBar1.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.egoldsProgressBar1.BackColorProgressRight = System.Drawing.Color.DodgerBlue;
            this.egoldsProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.egoldsProgressBar1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.egoldsProgressBar1.Location = new System.Drawing.Point(3, 3);
            this.egoldsProgressBar1.Name = "egoldsProgressBar1";
            this.egoldsProgressBar1.Size = new System.Drawing.Size(743, 43);
            this.egoldsProgressBar1.Step = 10;
            this.egoldsProgressBar1.TabIndex = 3;
            this.egoldsProgressBar1.Text = "egoldsProgressBar1";
            this.egoldsProgressBar1.Value = 0;
            this.egoldsProgressBar1.ValueMaximum = 100;
            this.egoldsProgressBar1.ValueMinimum = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(281, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Prepared by Pavel Korobkin\r\n Group 3013\r\n On the subject of database application" +
    " development";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SplachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplachForm";
            this.Load += new System.EventHandler(this.SplachForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplachForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplachForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SplachForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        public ProgressBar progressBar1;
        private Properties.EgoldsProgressBar egoldsProgressBar1;
        private PictureBox pictureBox1;
    }
}