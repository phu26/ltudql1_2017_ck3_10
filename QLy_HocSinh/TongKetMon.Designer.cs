namespace QLy_HocSinh
{
    partial class TongKetMon
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
            this.Mamoncombo = new System.Windows.Forms.ComboBox();
            this.HKcombo = new System.Windows.Forms.ComboBox();
            this.BCMgrid = new System.Windows.Forms.DataGridView();
            this.MHKbc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoccombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BCMgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Mamoncombo
            // 
            this.Mamoncombo.FormattingEnabled = true;
            this.Mamoncombo.Location = new System.Drawing.Point(336, 133);
            this.Mamoncombo.Name = "Mamoncombo";
            this.Mamoncombo.Size = new System.Drawing.Size(121, 21);
            this.Mamoncombo.TabIndex = 0;
            this.Mamoncombo.SelectedIndexChanged += new System.EventHandler(this.Mamoncombo_SelectedIndexChanged);
            // 
            // HKcombo
            // 
            this.HKcombo.FormattingEnabled = true;
            this.HKcombo.Location = new System.Drawing.Point(336, 95);
            this.HKcombo.Name = "HKcombo";
            this.HKcombo.Size = new System.Drawing.Size(121, 21);
            this.HKcombo.TabIndex = 1;
            this.HKcombo.SelectedIndexChanged += new System.EventHandler(this.HKcombo_SelectedIndexChanged);
            // 
            // BCMgrid
            // 
            this.BCMgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BCMgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHKbc,
            this.MaClass,
            this.subject,
            this.SLD,
            this.TLD});
            this.BCMgrid.Location = new System.Drawing.Point(130, 169);
            this.BCMgrid.Name = "BCMgrid";
            this.BCMgrid.Size = new System.Drawing.Size(537, 206);
            this.BCMgrid.TabIndex = 2;
            // 
            // MHKbc
            // 
            this.MHKbc.HeaderText = "Mã Học Kì";
            this.MHKbc.Name = "MHKbc";
            // 
            // MaClass
            // 
            this.MaClass.HeaderText = "Mã Lớp";
            this.MaClass.Name = "MaClass";
            // 
            // subject
            // 
            this.subject.HeaderText = "Mã Môn";
            this.subject.Name = "subject";
            // 
            // SLD
            // 
            this.SLD.HeaderText = "Số lượng học sinh đạt môn";
            this.SLD.Name = "SLD";
            // 
            // TLD
            // 
            this.TLD.HeaderText = "Tỉ lệ đạt môn";
            this.TLD.Name = "TLD";
            // 
            // namhoccombo
            // 
            this.namhoccombo.FormattingEnabled = true;
            this.namhoccombo.Location = new System.Drawing.Point(305, 59);
            this.namhoccombo.Name = "namhoccombo";
            this.namhoccombo.Size = new System.Drawing.Size(182, 21);
            this.namhoccombo.TabIndex = 4;
            this.namhoccombo.SelectedIndexChanged += new System.EventHandler(this.namhoccombo_SelectedIndexChanged);
            // 
            // TongKetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.namhoccombo);
            this.Controls.Add(this.BCMgrid);
            this.Controls.Add(this.HKcombo);
            this.Controls.Add(this.Mamoncombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TongKetMon";
            this.Text = "TongKetMon";
            this.Load += new System.EventHandler(this.TongKetMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BCMgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Mamoncombo;
        private System.Windows.Forms.ComboBox HKcombo;
        private System.Windows.Forms.DataGridView BCMgrid;
        private System.Windows.Forms.ComboBox namhoccombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHKbc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TLD;
    }
}