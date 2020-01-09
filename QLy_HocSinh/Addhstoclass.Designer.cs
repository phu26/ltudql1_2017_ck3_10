namespace QLy_HocSinh
{
    partial class Addhstoclass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DShsgridview = new System.Windows.Forms.DataGridView();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Classcombo = new System.Windows.Forms.ComboBox();
            this.KLcombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DShsgridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.DShsgridview);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 113);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa học sinh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm vào lớp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DShsgridview
            // 
            this.DShsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DShsgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.Sex,
            this.Date,
            this.DC,
            this.Emailcl});
            this.DShsgridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.DShsgridview.Location = new System.Drawing.Point(3, 16);
            this.DShsgridview.Name = "DShsgridview";
            this.DShsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DShsgridview.Size = new System.Drawing.Size(794, 223);
            this.DShsgridview.TabIndex = 0;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên ";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Giới Tính";
            this.Sex.Name = "Sex";
            this.Sex.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày Sinh";
            this.Date.Name = "Date";
            // 
            // DC
            // 
            this.DC.HeaderText = "Địa Chỉ";
            this.DC.Name = "DC";
            this.DC.Width = 150;
            // 
            // Emailcl
            // 
            this.Emailcl.HeaderText = "Email";
            this.Emailcl.Name = "Emailcl";
            this.Emailcl.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Classcombo);
            this.panel1.Controls.Add(this.KLcombo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
            // 
            // Classcombo
            // 
            this.Classcombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Classcombo.FormattingEnabled = true;
            this.Classcombo.Location = new System.Drawing.Point(397, 26);
            this.Classcombo.Name = "Classcombo";
            this.Classcombo.Size = new System.Drawing.Size(165, 21);
            this.Classcombo.TabIndex = 1;
            this.Classcombo.Text = "      Chọn Lớp";
            // 
            // KLcombo
            // 
            this.KLcombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KLcombo.FormattingEnabled = true;
            this.KLcombo.Location = new System.Drawing.Point(179, 26);
            this.KLcombo.Name = "KLcombo";
            this.KLcombo.Size = new System.Drawing.Size(164, 21);
            this.KLcombo.TabIndex = 0;
            this.KLcombo.Text = "     Chọn khối lớp";
            this.KLcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Addhstoclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addhstoclass";
            this.Text = "Addhstoclass";
            this.Load += new System.EventHandler(this.Addhstoclass_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DShsgridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DShsgridview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Classcombo;
        private System.Windows.Forms.ComboBox KLcombo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailcl;
    }
}