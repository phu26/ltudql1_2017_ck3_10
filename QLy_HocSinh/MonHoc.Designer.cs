namespace QLy_HocSinh
{
    partial class MonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.yearcombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mhnothkgrid = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.hk2bt = new System.Windows.Forms.Button();
            this.hk1bt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namhoc = new System.Windows.Forms.TextBox();
            this.hkcombo = new System.Windows.Forms.ComboBox();
            this.checkNH1 = new QLy_HocSinh.MonHoc.CheckNH();
            this.namhoccombo = new System.Windows.Forms.ComboBox();
            this.hockicomboo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dsmhgrid = new System.Windows.Forms.DataGridView();
            this.NamH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dslopcbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.a.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mhnothkgrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsmhgrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm Học Kì";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hiện Tại chưa có học kì nào";
            // 
            // a
            // 
            this.a.Controls.Add(this.tabPage1);
            this.a.Controls.Add(this.tabPage2);
            this.a.Controls.Add(this.tabPage3);
            this.a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a.Location = new System.Drawing.Point(0, 0);
            this.a.Name = "a";
            this.a.SelectedIndex = 0;
            this.a.Size = new System.Drawing.Size(800, 450);
            this.a.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.yearcombo);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.hk2bt);
            this.tabPage2.Controls.Add(this.hk1bt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm Môn Học Vào Học Kì";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // yearcombo
            // 
            this.yearcombo.FormattingEnabled = true;
            this.yearcombo.Location = new System.Drawing.Point(305, 211);
            this.yearcombo.Name = "yearcombo";
            this.yearcombo.Size = new System.Drawing.Size(121, 21);
            this.yearcombo.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(415, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Thêm Học Kì";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mhnothkgrid);
            this.panel3.Location = new System.Drawing.Point(175, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 188);
            this.panel3.TabIndex = 8;
            // 
            // mhnothkgrid
            // 
            this.mhnothkgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mhnothkgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten});
            this.mhnothkgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mhnothkgrid.Location = new System.Drawing.Point(0, 0);
            this.mhnothkgrid.Name = "mhnothkgrid";
            this.mhnothkgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mhnothkgrid.Size = new System.Drawing.Size(392, 188);
            this.mhnothkgrid.TabIndex = 0;
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Mã Môn";
            this.Ma.Name = "Ma";
            this.Ma.Width = 150;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên Môn Học";
            this.Ten.Name = "Ten";
            this.Ten.Width = 200;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Bổ Sung Môn Học Vào Hệ Thống";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hk2bt
            // 
            this.hk2bt.Location = new System.Drawing.Point(374, 3);
            this.hk2bt.Name = "hk2bt";
            this.hk2bt.Size = new System.Drawing.Size(417, 169);
            this.hk2bt.TabIndex = 1;
            this.hk2bt.Text = "Học Kì 2";
            this.hk2bt.UseVisualStyleBackColor = true;
            this.hk2bt.Click += new System.EventHandler(this.hk2bt_Click);
            // 
            // hk1bt
            // 
            this.hk1bt.Location = new System.Drawing.Point(5, 3);
            this.hk1bt.Name = "hk1bt";
            this.hk1bt.Size = new System.Drawing.Size(363, 169);
            this.hk1bt.TabIndex = 0;
            this.hk1bt.Text = "Học Kì 1";
            this.hk1bt.UseVisualStyleBackColor = true;
            this.hk1bt.Click += new System.EventHandler(this.hk1bt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách môn học theo lớp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.a);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học Kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm học";
            // 
            // namhoc
            // 
            this.namhoc.Location = new System.Drawing.Point(286, 94);
            this.namhoc.Name = "namhoc";
            this.namhoc.Size = new System.Drawing.Size(156, 20);
            this.namhoc.TabIndex = 8;
            this.namhoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hkcombo
            // 
            this.hkcombo.FormattingEnabled = true;
            this.hkcombo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.hkcombo.Location = new System.Drawing.Point(334, 140);
            this.hkcombo.Name = "hkcombo";
            this.hkcombo.Size = new System.Drawing.Size(90, 21);
            this.hkcombo.TabIndex = 9;
            // 
            // checkNH1
            // 
            this.checkNH1.ControlToValidate = this.namhoc;
            this.checkNH1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkNH1.ErrorIcon")));
            this.checkNH1.ErrorMessage = null;
            // 
            // namhoccombo
            // 
            this.namhoccombo.FormattingEnabled = true;
            this.namhoccombo.Location = new System.Drawing.Point(256, 44);
            this.namhoccombo.Name = "namhoccombo";
            this.namhoccombo.Size = new System.Drawing.Size(182, 21);
            this.namhoccombo.TabIndex = 3;
            this.namhoccombo.SelectedIndexChanged += new System.EventHandler(this.namhoccombo_SelectedIndexChanged);
            // 
            // hockicomboo
            // 
            this.hockicomboo.FormattingEnabled = true;
            this.hockicomboo.Location = new System.Drawing.Point(256, 105);
            this.hockicomboo.Name = "hockicomboo";
            this.hockicomboo.Size = new System.Drawing.Size(182, 21);
            this.hockicomboo.TabIndex = 4;
            this.hockicomboo.SelectedIndexChanged += new System.EventHandler(this.hkcombo_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(152, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 218);
            this.panel2.TabIndex = 7;
            // 
            // dsmhgrid
            // 
            this.dsmhgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsmhgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsmhgrid.Location = new System.Drawing.Point(0, 0);
            this.dsmhgrid.Name = "dsmhgrid";
            this.dsmhgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsmhgrid.Size = new System.Drawing.Size(442, 218);
            this.dsmhgrid.TabIndex = 0;
            this.dsmhgrid.SelectionChanged += new System.EventHandler(this.dsmhgrid_SelectionChanged);
            // 
            // NamH
            // 
            this.NamH.HeaderText = "Năm Học";
            this.NamH.Name = "NamH";
            // 
            // hocki
            // 
            this.hocki.HeaderText = "Học Kì";
            this.hocki.Name = "hocki";
            // 
            // TenMH
            // 
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.Name = "TenMH";
            // 
            // MaMH
            // 
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.Name = "MaMH";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(188, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(188, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thêm Vào Lớp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dslopcbox
            // 
            this.dslopcbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dslopcbox.FormattingEnabled = true;
            this.dslopcbox.Location = new System.Drawing.Point(364, 6);
            this.dslopcbox.Name = "dslopcbox";
            this.dslopcbox.Size = new System.Drawing.Size(86, 21);
            this.dslopcbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(232, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dslopcbox);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.hockicomboo);
            this.tabPage1.Controls.Add(this.namhoccombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi Tiết Môn Học Theo Học Kì";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hkcombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.namhoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonHoc";
            this.Text = "MonHoc";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            this.a.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mhnothkgrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsmhgrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl a;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button hk2bt;
        private System.Windows.Forms.Button hk1bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namhoc;
        private System.Windows.Forms.ComboBox hkcombo;
        private CheckNH checkNH1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView mhnothkgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.ComboBox yearcombo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dslopcbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox hockicomboo;
        private System.Windows.Forms.ComboBox namhoccombo;
        private System.Windows.Forms.DataGridView dsmhgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamH;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocki;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
    }
}