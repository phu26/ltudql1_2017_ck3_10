namespace QLy_HocSinh
{
    partial class DSclass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSclass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateD = new System.Windows.Forms.Button();
            this.addsubjecttohs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dshsgrid = new System.Windows.Forms.DataGridView();
            this.HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBHK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBHK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classcombo = new System.Windows.Forms.ComboBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.namradio = new System.Windows.Forms.RadioButton();
            this.nuradio = new System.Windows.Forms.RadioButton();
            this.txthk1 = new System.Windows.Forms.TextBox();
            this.txthk2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kLcombo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lop = new System.Windows.Forms.RadioButton();
            this.KL = new System.Windows.Forms.RadioButton();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkName1 = new Register.CheckName();
            this.requiredFieldValidator21 = new Register.RequiredFieldValidator2();
            this.checkDate1 = new QLy_HocSinh.Form1.CheckDate();
            this.checkName2 = new Register.CheckName();
            this.checkTenL21 = new QLy_HocSinh.DSclass.CheckTenL2();
            this.subjectoffclassGrid = new System.Windows.Forms.DataGridView();
            this.MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectoffstudentGrid = new System.Windows.Forms.DataGridView();
            this.MHhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HKhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt15p = new System.Windows.Forms.TextBox();
            this.txt1t = new System.Windows.Forms.TextBox();
            this.txtck = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dshsgrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectoffclassGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectoffstudentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateD);
            this.panel1.Controls.Add(this.addsubjecttohs);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dshsgrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 213);
            this.panel1.TabIndex = 0;
            // 
            // updateD
            // 
            this.updateD.Location = new System.Drawing.Point(636, 8);
            this.updateD.Name = "updateD";
            this.updateD.Size = new System.Drawing.Size(113, 23);
            this.updateD.TabIndex = 4;
            this.updateD.Text = "Cập nhật điểm";
            this.updateD.UseVisualStyleBackColor = true;
            this.updateD.Click += new System.EventHandler(this.updateD_Click);
            // 
            // addsubjecttohs
            // 
            this.addsubjecttohs.Location = new System.Drawing.Point(65, 8);
            this.addsubjecttohs.Name = "addsubjecttohs";
            this.addsubjecttohs.Size = new System.Drawing.Size(145, 23);
            this.addsubjecttohs.TabIndex = 3;
            this.addsubjecttohs.Text = "Thêm môn học cho học sinh";
            this.addsubjecttohs.UseVisualStyleBackColor = true;
            this.addsubjecttohs.Click += new System.EventHandler(this.addsubjecttohs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cập nhật chỉnh sửa thông tin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xóa Học Sinh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dshsgrid
            // 
            this.dshsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dshsgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HT,
            this.Class,
            this.Sex,
            this.Date,
            this.Addr,
            this.Mail,
            this.TBHK1,
            this.TBHK2});
            this.dshsgrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dshsgrid.Location = new System.Drawing.Point(0, 37);
            this.dshsgrid.Name = "dshsgrid";
            this.dshsgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dshsgrid.Size = new System.Drawing.Size(820, 176);
            this.dshsgrid.TabIndex = 0;
            this.dshsgrid.SelectionChanged += new System.EventHandler(this.dshsgrid_SelectionChanged);
            // 
            // HT
            // 
            this.HT.HeaderText = "Họ Tên";
            this.HT.Name = "HT";
            // 
            // Class
            // 
            this.Class.HeaderText = "Lớp";
            this.Class.Name = "Class";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Giới Tính";
            this.Sex.Name = "Sex";
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày sinh";
            this.Date.Name = "Date";
            // 
            // Addr
            // 
            this.Addr.HeaderText = "Địa chỉ";
            this.Addr.Name = "Addr";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Email";
            this.Mail.Name = "Mail";
            // 
            // TBHK1
            // 
            this.TBHK1.HeaderText = "TB HK1";
            this.TBHK1.Name = "TBHK1";
            // 
            // TBHK2
            // 
            this.TBHK2.HeaderText = "TB HK2";
            this.TBHK2.Name = "TBHK2";
            // 
            // classcombo
            // 
            this.classcombo.FormattingEnabled = true;
            this.classcombo.Location = new System.Drawing.Point(226, 33);
            this.classcombo.Name = "classcombo";
            this.classcombo.Size = new System.Drawing.Size(261, 21);
            this.classcombo.TabIndex = 1;
            this.classcombo.SelectedIndexChanged += new System.EventHandler(this.classcombo_SelectedIndexChanged);
            // 
            // txtma
            // 
            this.txtma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(66, 20);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(49, 20);
            this.txtma.TabIndex = 2;
            // 
            // txtdate
            // 
            this.txtdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdate.Location = new System.Drawing.Point(116, 57);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(77, 20);
            this.txtdate.TabIndex = 3;
            // 
            // txtaddr
            // 
            this.txtaddr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtaddr.Location = new System.Drawing.Point(477, 23);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(100, 20);
            this.txtaddr.TabIndex = 4;
            // 
            // txtclass
            // 
            this.txtclass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtclass.Location = new System.Drawing.Point(365, 23);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(30, 20);
            this.txtclass.TabIndex = 5;
            // 
            // txtht
            // 
            this.txtht.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtht.Location = new System.Drawing.Point(189, 20);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(100, 20);
            this.txtht.TabIndex = 6;
            // 
            // namradio
            // 
            this.namradio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.namradio.AutoSize = true;
            this.namradio.Location = new System.Drawing.Point(258, 59);
            this.namradio.Name = "namradio";
            this.namradio.Size = new System.Drawing.Size(47, 17);
            this.namradio.TabIndex = 7;
            this.namradio.TabStop = true;
            this.namradio.Text = "Nam";
            this.namradio.UseVisualStyleBackColor = true;
            // 
            // nuradio
            // 
            this.nuradio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nuradio.AutoSize = true;
            this.nuradio.Location = new System.Drawing.Point(319, 60);
            this.nuradio.Name = "nuradio";
            this.nuradio.Size = new System.Drawing.Size(39, 17);
            this.nuradio.TabIndex = 8;
            this.nuradio.TabStop = true;
            this.nuradio.Text = "Nữ";
            this.nuradio.UseVisualStyleBackColor = true;
            // 
            // txthk1
            // 
            this.txthk1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txthk1.Enabled = false;
            this.txthk1.Location = new System.Drawing.Point(444, 59);
            this.txthk1.Name = "txthk1";
            this.txthk1.Size = new System.Drawing.Size(100, 20);
            this.txthk1.TabIndex = 9;
            // 
            // txthk2
            // 
            this.txthk2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txthk2.Enabled = false;
            this.txthk2.Location = new System.Drawing.Point(637, 60);
            this.txthk2.Name = "txthk2";
            this.txthk2.Size = new System.Drawing.Size(100, 20);
            this.txthk2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã HS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giỡi tính";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên Lớp";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Họ Tên";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "TBHK1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "TBHK2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Chọn lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Chọn khối";
            // 
            // kLcombo
            // 
            this.kLcombo.FormattingEnabled = true;
            this.kLcombo.Location = new System.Drawing.Point(226, 6);
            this.kLcombo.Name = "kLcombo";
            this.kLcombo.Size = new System.Drawing.Size(261, 21);
            this.kLcombo.TabIndex = 20;
            this.kLcombo.SelectedIndexChanged += new System.EventHandler(this.kLcombo_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lop);
            this.panel2.Controls.Add(this.KL);
            this.panel2.Location = new System.Drawing.Point(536, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 1;
            // 
            // Lop
            // 
            this.Lop.AutoSize = true;
            this.Lop.Location = new System.Drawing.Point(36, 27);
            this.Lop.Name = "Lop";
            this.Lop.Size = new System.Drawing.Size(87, 17);
            this.Lop.TabIndex = 1;
            this.Lop.TabStop = true;
            this.Lop.Text = "Xem theo lớp";
            this.Lop.UseVisualStyleBackColor = true;
            this.Lop.CheckedChanged += new System.EventHandler(this.Lop_CheckedChanged);
            // 
            // KL
            // 
            this.KL.AutoSize = true;
            this.KL.Location = new System.Drawing.Point(36, 3);
            this.KL.Name = "KL";
            this.KL.Size = new System.Drawing.Size(110, 17);
            this.KL.TabIndex = 0;
            this.KL.TabStop = true;
            this.KL.Text = "Xem theo khối lớp";
            this.KL.UseVisualStyleBackColor = true;
            this.KL.CheckedChanged += new System.EventHandler(this.KL_CheckedChanged);
            // 
            // txtmail
            // 
            this.txtmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtmail.Location = new System.Drawing.Point(637, 22);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(590, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Email";
            // 
            // checkName1
            // 
            this.checkName1.ControlToValidate = this.txtht;
            this.checkName1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkName1.ErrorIcon")));
            this.checkName1.ErrorMessage = null;
            // 
            // requiredFieldValidator21
            // 
            this.requiredFieldValidator21.ControlToValidate = this.txtmail;
            this.requiredFieldValidator21.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator21.ErrorIcon")));
            this.requiredFieldValidator21.ErrorMessage = null;
            // 
            // checkDate1
            // 
            this.checkDate1.ControlToValidate = this.txtdate;
            this.checkDate1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkDate1.ErrorIcon")));
            this.checkDate1.ErrorMessage = null;
            // 
            // checkName2
            // 
            this.checkName2.ControlToValidate = this.txtaddr;
            this.checkName2.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkName2.ErrorIcon")));
            this.checkName2.ErrorMessage = null;
            // 
            // checkTenL21
            // 
            this.checkTenL21.ControlToValidate = this.txtclass;
            this.checkTenL21.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkTenL21.ErrorIcon")));
            this.checkTenL21.ErrorMessage = null;
            // 
            // subjectoffclassGrid
            // 
            this.subjectoffclassGrid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectoffclassGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectoffclassGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MH,
            this.HK,
            this.NHhs});
            this.subjectoffclassGrid.Location = new System.Drawing.Point(3, 196);
            this.subjectoffclassGrid.Name = "subjectoffclassGrid";
            this.subjectoffclassGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectoffclassGrid.Size = new System.Drawing.Size(307, 105);
            this.subjectoffclassGrid.TabIndex = 24;
            // 
            // MH
            // 
            this.MH.HeaderText = "Tên Môn Học";
            this.MH.Name = "MH";
            // 
            // HK
            // 
            this.HK.HeaderText = "Học Kì";
            this.HK.Name = "HK";
            // 
            // NHhs
            // 
            this.NHhs.HeaderText = "Năm Học";
            this.NHhs.Name = "NHhs";
            // 
            // subjectoffstudentGrid
            // 
            this.subjectoffstudentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectoffstudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectoffstudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHhs,
            this.HKhs,
            this.NHoc,
            this.p15,
            this.t1,
            this.ck});
            this.subjectoffstudentGrid.Location = new System.Drawing.Point(394, 196);
            this.subjectoffstudentGrid.Name = "subjectoffstudentGrid";
            this.subjectoffstudentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectoffstudentGrid.Size = new System.Drawing.Size(374, 105);
            this.subjectoffstudentGrid.TabIndex = 25;
            this.subjectoffstudentGrid.SelectionChanged += new System.EventHandler(this.subjectoffstudentGrid_SelectionChanged);
            // 
            // MHhs
            // 
            this.MHhs.HeaderText = "Tên Môn Học";
            this.MHhs.Name = "MHhs";
            // 
            // HKhs
            // 
            this.HKhs.HeaderText = "Học kì";
            this.HKhs.Name = "HKhs";
            // 
            // NHoc
            // 
            this.NHoc.HeaderText = "Năm Học";
            this.NHoc.Name = "NHoc";
            // 
            // p15
            // 
            this.p15.HeaderText = "Điểm 15p";
            this.p15.Name = "p15";
            // 
            // t1
            // 
            this.t1.HeaderText = "Điểm 1 tiết";
            this.t1.Name = "t1";
            // 
            // ck
            // 
            this.ck.HeaderText = "Điểm cuối kì";
            this.ck.Name = "ck";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Môn của lớp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(529, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Môn của học sinh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Điểm 15p";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(261, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Điểm 1 tiết";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(439, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Điểm CK";
            // 
            // txt15p
            // 
            this.txt15p.Location = new System.Drawing.Point(143, 169);
            this.txt15p.Name = "txt15p";
            this.txt15p.Size = new System.Drawing.Size(67, 20);
            this.txt15p.TabIndex = 31;
            // 
            // txt1t
            // 
            this.txt1t.Location = new System.Drawing.Point(319, 169);
            this.txt1t.Name = "txt1t";
            this.txt1t.Size = new System.Drawing.Size(67, 20);
            this.txt1t.TabIndex = 32;
            // 
            // txtck
            // 
            this.txtck.Location = new System.Drawing.Point(493, 170);
            this.txtck.Name = "txtck";
            this.txtck.Size = new System.Drawing.Size(67, 20);
            this.txtck.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Xóa Lớp";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Xóa Khối Lớp";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // DSclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtck);
            this.Controls.Add(this.txt1t);
            this.Controls.Add(this.txt15p);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.subjectoffstudentGrid);
            this.Controls.Add(this.subjectoffclassGrid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kLcombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthk2);
            this.Controls.Add(this.txthk1);
            this.Controls.Add(this.nuradio);
            this.Controls.Add(this.namradio);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.classcombo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DSclass";
            this.Text = "DSclass";
            this.Load += new System.EventHandler(this.DSclass_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dshsgrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectoffclassGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectoffstudentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dshsgrid;
        private System.Windows.Forms.ComboBox classcombo;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.RadioButton namradio;
        private System.Windows.Forms.RadioButton nuradio;
        private System.Windows.Forms.TextBox txthk1;
        private System.Windows.Forms.TextBox txthk2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox kLcombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBHK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBHK2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Lop;
        private System.Windows.Forms.RadioButton KL;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Register.CheckName checkName1;
        private Register.RequiredFieldValidator2 requiredFieldValidator21;
        private Form1.CheckDate checkDate1;
        private Register.CheckName checkName2;
        private CheckTenL2 checkTenL21;
        private System.Windows.Forms.DataGridView subjectoffclassGrid;
        private System.Windows.Forms.DataGridView subjectoffstudentGrid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHhs;
        private System.Windows.Forms.Button addsubjecttohs;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn HKhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn p15;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ck;
        private System.Windows.Forms.Button updateD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt15p;
        private System.Windows.Forms.TextBox txt1t;
        private System.Windows.Forms.TextBox txtck;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}