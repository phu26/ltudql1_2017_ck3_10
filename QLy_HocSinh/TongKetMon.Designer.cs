﻿namespace QLy_HocSinh
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namhoccombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mamoncombo
            // 
            this.Mamoncombo.FormattingEnabled = true;
            this.Mamoncombo.Location = new System.Drawing.Point(336, 142);
            this.Mamoncombo.Name = "Mamoncombo";
            this.Mamoncombo.Size = new System.Drawing.Size(121, 21);
            this.Mamoncombo.TabIndex = 0;
            // 
            // HKcombo
            // 
            this.HKcombo.FormattingEnabled = true;
            this.HKcombo.Location = new System.Drawing.Point(336, 84);
            this.HKcombo.Name = "HKcombo";
            this.HKcombo.Size = new System.Drawing.Size(121, 21);
            this.HKcombo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 218);
            this.dataGridView1.TabIndex = 2;
            // 
            // namhoccombo
            // 
            this.namhoccombo.FormattingEnabled = true;
            this.namhoccombo.Location = new System.Drawing.Point(301, 24);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HKcombo);
            this.Controls.Add(this.Mamoncombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TongKetMon";
            this.Text = "TongKetMon";
            this.Load += new System.EventHandler(this.TongKetMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Mamoncombo;
        private System.Windows.Forms.ComboBox HKcombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox namhoccombo;
    }
}