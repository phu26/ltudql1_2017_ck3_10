namespace QLy_HocSinh
{
    partial class PhanQuyenf
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
            this.DsUsergrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatePer = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DelUser = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DsUsergrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DsUsergrid
            // 
            this.DsUsergrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DsUsergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsUsergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usn,
            this.Password,
            this.Permission});
            this.DsUsergrid.Location = new System.Drawing.Point(230, 122);
            this.DsUsergrid.Name = "DsUsergrid";
            this.DsUsergrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DsUsergrid.Size = new System.Drawing.Size(346, 221);
            this.DsUsergrid.TabIndex = 0;
            this.DsUsergrid.SelectionChanged += new System.EventHandler(this.DsUsergrid_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // usn
            // 
            this.usn.HeaderText = "Username";
            this.usn.Name = "usn";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Permission
            // 
            this.Permission.HeaderText = "Permission";
            this.Permission.Name = "Permission";
            // 
            // UpdatePer
            // 
            this.UpdatePer.BackColor = System.Drawing.Color.Turquoise;
            this.UpdatePer.Dock = System.Windows.Forms.DockStyle.Left;
            this.UpdatePer.Location = new System.Drawing.Point(0, 0);
            this.UpdatePer.Name = "UpdatePer";
            this.UpdatePer.Size = new System.Drawing.Size(389, 66);
            this.UpdatePer.TabIndex = 1;
            this.UpdatePer.Text = "Cập nhật quyền";
            this.UpdatePer.UseVisualStyleBackColor = false;
            this.UpdatePer.Click += new System.EventHandler(this.UpdatePer_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Turquoise;
            this.addUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.addUser.Location = new System.Drawing.Point(412, 0);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(388, 66);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Thêm user";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.addUser);
            this.panel1.Controls.Add(this.UpdatePer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 3;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(220, 70);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpass.Location = new System.Drawing.Point(353, 70);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 5;
            // 
            // txtPer
            // 
            this.txtPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPer.Location = new System.Drawing.Point(486, 70);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(100, 20);
            this.txtPer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(244, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(376, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PassWord";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(509, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Permission";
            // 
            // DelUser
            // 
            this.DelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DelUser.Location = new System.Drawing.Point(230, 341);
            this.DelUser.Name = "DelUser";
            this.DelUser.Size = new System.Drawing.Size(346, 37);
            this.DelUser.TabIndex = 10;
            this.DelUser.Text = "Xóa User";
            this.DelUser.UseVisualStyleBackColor = true;
            this.DelUser.Click += new System.EventHandler(this.DelUser_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(385, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 20);
            this.txtid.TabIndex = 11;
            // 
            // PhanQuyenf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLy_HocSinh.Properties.Resources.pngtree_blue_learning_goods_office_background_image_2341;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.DelUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPer);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DsUsergrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhanQuyenf";
            this.Text = "PhanQuyenf";
            this.Load += new System.EventHandler(this.PhanQuyenf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsUsergrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DsUsergrid;
        private System.Windows.Forms.Button UpdatePer;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DelUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permission;
        private System.Windows.Forms.TextBox txtid;
    }
}