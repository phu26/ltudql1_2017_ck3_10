namespace QLy_HocSinh
{
    partial class TongKetHK
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
            this.TKHKgrid = new System.Windows.Forms.DataGridView();
            this.MHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLDHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoccombo = new System.Windows.Forms.ComboBox();
            this.HKcombo = new System.Windows.Forms.ComboBox();
            this.hkradio = new System.Windows.Forms.RadioButton();
            this.Lop = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.kLcombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.classcombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TKHKgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TKHKgrid
            // 
            this.TKHKgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TKHKgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHK,
            this.ML,
            this.SLDHK,
            this.TLDHK});
            this.TKHKgrid.Location = new System.Drawing.Point(161, 206);
            this.TKHKgrid.Name = "TKHKgrid";
            this.TKHKgrid.Size = new System.Drawing.Size(441, 244);
            this.TKHKgrid.TabIndex = 0;
            // 
            // MHK
            // 
            this.MHK.HeaderText = "Mã học kì ";
            this.MHK.Name = "MHK";
            // 
            // ML
            // 
            this.ML.HeaderText = "Mã Lớp";
            this.ML.Name = "ML";
            // 
            // SLDHK
            // 
            this.SLDHK.HeaderText = "Số Lượng Đạt";
            this.SLDHK.Name = "SLDHK";
            // 
            // TLDHK
            // 
            this.TLDHK.HeaderText = "Tỉ Lệ Đạt";
            this.TLDHK.Name = "TLDHK";
            // 
            // namhoccombo
            // 
            this.namhoccombo.FormattingEnabled = true;
            this.namhoccombo.Location = new System.Drawing.Point(276, 52);
            this.namhoccombo.Name = "namhoccombo";
            this.namhoccombo.Size = new System.Drawing.Size(182, 21);
            this.namhoccombo.TabIndex = 7;
            this.namhoccombo.SelectedIndexChanged += new System.EventHandler(this.namhoccombo_SelectedIndexChanged);
            // 
            // HKcombo
            // 
            this.HKcombo.FormattingEnabled = true;
            this.HKcombo.Location = new System.Drawing.Point(311, 112);
            this.HKcombo.Name = "HKcombo";
            this.HKcombo.Size = new System.Drawing.Size(121, 21);
            this.HKcombo.TabIndex = 6;
            this.HKcombo.SelectedIndexChanged += new System.EventHandler(this.HKcombo_SelectedIndexChanged);
            // 
            // hkradio
            // 
            this.hkradio.AutoSize = true;
            this.hkradio.Location = new System.Drawing.Point(530, 112);
            this.hkradio.Name = "hkradio";
            this.hkradio.Size = new System.Drawing.Size(102, 17);
            this.hkradio.TabIndex = 8;
            this.hkradio.TabStop = true;
            this.hkradio.Text = "Xem theo học kì";
            this.hkradio.UseVisualStyleBackColor = true;
            this.hkradio.CheckedChanged += new System.EventHandler(this.hkradio_CheckedChanged);
            // 
            // Lop
            // 
            this.Lop.AutoSize = true;
            this.Lop.Location = new System.Drawing.Point(530, 168);
            this.Lop.Name = "Lop";
            this.Lop.Size = new System.Drawing.Size(134, 17);
            this.Lop.TabIndex = 9;
            this.Lop.TabStop = true;
            this.Lop.Text = "Xem theo lớp và học kì";
            this.Lop.UseVisualStyleBackColor = true;
            this.Lop.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Chọn khối";
            // 
            // kLcombo
            // 
            this.kLcombo.FormattingEnabled = true;
            this.kLcombo.Location = new System.Drawing.Point(242, 147);
            this.kLcombo.Name = "kLcombo";
            this.kLcombo.Size = new System.Drawing.Size(261, 21);
            this.kLcombo.TabIndex = 24;
            this.kLcombo.SelectedIndexChanged += new System.EventHandler(this.kLcombo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Chọn lớp";
            // 
            // classcombo
            // 
            this.classcombo.FormattingEnabled = true;
            this.classcombo.Location = new System.Drawing.Point(242, 179);
            this.classcombo.Name = "classcombo";
            this.classcombo.Size = new System.Drawing.Size(261, 21);
            this.classcombo.TabIndex = 22;
            this.classcombo.SelectedIndexChanged += new System.EventHandler(this.classcombo_SelectedIndexChanged);
            // 
            // TongKetHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kLcombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.classcombo);
            this.Controls.Add(this.Lop);
            this.Controls.Add(this.hkradio);
            this.Controls.Add(this.namhoccombo);
            this.Controls.Add(this.HKcombo);
            this.Controls.Add(this.TKHKgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TongKetHK";
            this.Text = "TongKetHK";
            this.Load += new System.EventHandler(this.TongKetHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TKHKgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TKHKgrid;
        private System.Windows.Forms.ComboBox namhoccombo;
        private System.Windows.Forms.ComboBox HKcombo;
        private System.Windows.Forms.RadioButton hkradio;
        private System.Windows.Forms.RadioButton Lop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox kLcombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox classcombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ML;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TLDHK;
    }
}