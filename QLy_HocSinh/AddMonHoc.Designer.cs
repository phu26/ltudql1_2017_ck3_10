namespace QLy_HocSinh
{
    partial class AddMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMonHoc));
            this.button1 = new System.Windows.Forms.Button();
            this.txtnamemh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkNameMH1 = new QLy_HocSinh.MonHoc.CheckNameMH();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm Môn Học";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnamemh
            // 
            this.txtnamemh.Location = new System.Drawing.Point(320, 133);
            this.txtnamemh.Name = "txtnamemh";
            this.txtnamemh.Size = new System.Drawing.Size(128, 20);
            this.txtnamemh.TabIndex = 1;
            this.txtnamemh.Text = "Nhập tên môn học";
            this.txtnamemh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Môn Học";
            // 
            // checkNameMH1
            // 
            this.checkNameMH1.ControlToValidate = this.txtnamemh;
            this.checkNameMH1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkNameMH1.ErrorIcon")));
            this.checkNameMH1.ErrorMessage = null;
            // 
            // AddMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnamemh);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMonHoc";
            this.Text = "AddMonHoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnamemh;
        private System.Windows.Forms.Label label1;
        private MonHoc.CheckNameMH checkNameMH1;
    }
}