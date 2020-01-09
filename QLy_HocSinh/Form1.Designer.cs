namespace QLy_HocSinh
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkgirl = new System.Windows.Forms.RadioButton();
            this.checkboy = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkName1 = new QLy_HocSinh.Form1.CheckName();
            this.checkName2 = new QLy_HocSinh.Form1.CheckName();
            this.requiredFieldValidator21 = new QLy_HocSinh.Form1.RequiredFieldValidator2();
            this.checkDate1 = new QLy_HocSinh.Form1.CheckDate();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(332, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tiếp nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(223, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ Tên";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(29, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Địa Chỉ";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.BackColor = System.Drawing.Color.Transparent;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmail.Location = new System.Drawing.Point(38, 123);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(37, 13);
            this.lblmail.TabIndex = 3;
            this.lblmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới Tính";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(88, 79);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(201, 20);
            this.txtdc.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(282, 73);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(201, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(87, 120);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(201, 20);
            this.txtmail.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkgirl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkboy);
            this.panel1.Controls.Add(this.txtdc);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblmail);
            this.panel1.Location = new System.Drawing.Point(194, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 266);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkgirl
            // 
            this.checkgirl.AutoSize = true;
            this.checkgirl.Location = new System.Drawing.Point(196, 238);
            this.checkgirl.Name = "checkgirl";
            this.checkgirl.Size = new System.Drawing.Size(39, 17);
            this.checkgirl.TabIndex = 25;
            this.checkgirl.Text = "Nữ";
            this.checkgirl.UseVisualStyleBackColor = true;
            // 
            // checkboy
            // 
            this.checkboy.AutoSize = true;
            this.checkboy.Checked = true;
            this.checkboy.Location = new System.Drawing.Point(122, 238);
            this.checkboy.Name = "checkboy";
            this.checkboy.Size = new System.Drawing.Size(47, 17);
            this.checkboy.TabIndex = 24;
            this.checkboy.TabStop = true;
            this.checkboy.Text = "Nam";
            this.checkboy.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // checkName1
            // 
            this.checkName1.ControlToValidate = this.txtname;
            this.checkName1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkName1.ErrorIcon")));
            this.checkName1.ErrorMessage = null;
            // 
            // checkName2
            // 
            this.checkName2.ControlToValidate = this.txtdc;
            this.checkName2.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkName2.ErrorIcon")));
            this.checkName2.ErrorMessage = null;
            // 
            // requiredFieldValidator21
            // 
            this.requiredFieldValidator21.ControlToValidate = this.txtmail;
            this.requiredFieldValidator21.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator21.ErrorIcon")));
            this.requiredFieldValidator21.ErrorMessage = null;
            // 
            // checkDate1
            // 
            this.checkDate1.ControlToValidate = this.dateTimePicker1;
            this.checkDate1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("checkDate1.ErrorIcon")));
            this.checkDate1.ErrorMessage = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLy_HocSinh.Properties.Resources.equipo_escuela_sobre_fondo_azul_23_2147656034;
            this.ClientSize = new System.Drawing.Size(750, 603);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CheckName checkName1;
        private CheckName checkName2;
        private RequiredFieldValidator2 requiredFieldValidator21;
        private System.Windows.Forms.RadioButton checkgirl;
        private System.Windows.Forms.RadioButton checkboy;
        private CheckDate checkDate1;
    }
}

