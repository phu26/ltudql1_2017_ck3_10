using System;
using System.Collections.Generic;
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
    public partial class Login : Form
    {
        HocSinhBUS HSB = new HocSinhBUS();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            textBox1.Text = "UserName";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "PassWord";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            HSB.listAC();
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            int kt = 0;
            if(textBox1.Text != "UserName" && textBox2.Text!= "PassWord")
            {
                foreach (var kq in UsserrDTO.lstU)
                {
                    if (kq.Username == textBox1.Text && kq.Pass == textBox2.Text)
                    {
                        kt = 1;
                        break;
                    }
                }
                if(kt==1)
                {
                    HSB.Login(textBox1.Text, textBox2.Text);
                    MessageBox.Show("Đăng nhập thành công");
                    MainGUI.ActiveForm.Hide();
                    MainGUI m = new MainGUI();
                    m.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
               
               
            }
            else
            {
                MessageBox.Show(textBox2.Text);
            }
            
        }
    }
}
