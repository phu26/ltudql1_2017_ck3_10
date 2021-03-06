﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLy_HocSinh
{
    public partial class MainGUI : Form
    {
        
        HocSinhBUS HSB = new HocSinhBUS();
        public MainGUI()
        {
            
            InitializeComponent();
            menu.Width = 70;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmd, int wmsg, int wparam, int lparam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            
            f.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        public void MainGUI_Load(object sender, EventArgs e)
        {
            HSB.TLSL();
            HSB.Loadkl();
            HSB.AVG();
           
                List<string> l = new List<string>();
                foreach (var s in clasDTO.lop)
                {

                    l.Add(s.TenL1);
                }
                dslopcbox.DataSource = l.ToList();
            
         if(UsserrDTO.u.Per != 0)
            {
                button14.Visible = true;
            }

            if (UsserrDTO.u.Per == 0 )
            {
                pictureBox3.Visible = false;
               
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button9.Visible = true;
                showinpanel(new DSclass());
            }else
            {
                if(UsserrDTO.u.Per == 1)
                {
                    pictureBox3.Visible = false;

                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = true;
                }
                else
                {
                    if(UsserrDTO.u.Per == 2)
                    {
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;
                        button8.Visible = false;
                        button9.Visible = true;
                        button11.Visible = true;
                        button12.Visible = true;
                        button13.Visible = true;

                    }
                }
            }
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(menu.Width == 250 )
            {
                menu.Width = 70;

            }
            else
            {
                menu.Width = 250;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
           if( this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void showinpanel(object fom)
        {
            if (this.mainpn.Controls.Count > 0)
                this.mainpn.Controls.RemoveAt(0);
            Form f = fom as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpn.Controls.Add(f);
            this.mainpn.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showinpanel(new Form1());
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mainpn_Paint(object sender, PaintEventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showinpanel(new AddClass());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showinpanel(new Addhstoclass());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showinpanel(new DSclass());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showinpanel(new MonHoc());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showinpanel(new TongKetMon());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showinpanel(new TongKetHK());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showinpanel(new DSclass());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showinpanel(new Login());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            showinpanel(new PhanQuyenf());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showinpanel(new TongKetMon());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showinpanel(new TongKetHK());
        }

        private void button13_Click(object sender, EventArgs e)
        {

            showinpanel(new QDf());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HSB.Logout();
            MainGUI.ActiveForm.Hide();
            MainGUI m = new MainGUI();
            m.ShowDialog();
        }
    }
}
