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
    
    public partial class Addhstoclass : Form
    {
        HocSinhBUS HSB = new HocSinhBUS();
        public Addhstoclass()
        {
            InitializeComponent();
        }

       

        private void Addhstoclass_Load(object sender, EventArgs e)
        {
            HSB.Load();
            List<string> kl = new List<string>();
            foreach (var s in ClassDTO.khoilop)
            {
                kl.Add(s.TenK1);
            }
            
            KLcombo.DataSource = kl.ToList();

            foreach (var s in HocSinhDTO.lisths)
            {
                string gt = "";
                if (s.Gioitinh == true)
                {
                    gt = "Nam";
                }
                else 
                    gt = "Nữ";

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = s.Name;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = gt;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = s.Ngsinh;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = s.Diachi;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = s.Email;
                row.Cells.Add(cell);

                DShsgridview.Rows.Add(row);

            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KLcombo.SelectedItem != null)
            {
                List<string> l = new List<string>();
                foreach (var s in clasDTO.lop)
                {
                    string tk = KLcombo.SelectedItem.ToString();
                    char[] ar = s.TenL1.ToCharArray();
                    string test = ar[0].ToString() + ar[1].ToString();
                    if(tk == test)
                    {
                        l.Add(s.TenL1);
                    }
                    
                }
                
                Classcombo.DataSource = l.ToList();
                
                if (l.Count() == 0)
                {
                    Classcombo.Text = null;
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool erro = false ;
            DataGridViewRow row = DShsgridview.SelectedRows[0];
            string mail = row.Cells[4].Value.ToString();
            HSB.GetMaHS(mail);
            string ML = "";
            foreach(var i in clasDTO.lop)
            {
                if(Classcombo.SelectedItem.ToString() == i.TenL1)
                {
                    ML = i.MaL1;
                }
            }
            string mct = ML + HocSinhDTO.id.ToString();
            ChiTietClass ct = new ChiTietClass(mct, ML, HocSinhDTO.id, 0, 0);
            if(ML != "")
            {
                foreach(var m in ChiTietClass.ctclas)
                {
                    if (mct == m.MaCT1)
                    {
                        erro = true;
                        MessageBox.Show("mã chi tiết lớp đã tồn tại");
                        break;
                     
                    }
                    else
                    {
                        if(m.MaHS1 == HocSinhDTO.id)
                        {
                            erro = true;
                            MessageBox.Show("học sinh đã có lớp");
                            break;
                        }
                    }
                }
                if(erro == false)
                {
                    HSB.InsertCT(ct);
                    MessageBox.Show("successfull");
                    HSB.Load();
                }
             
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DShsgridview.SelectedRows[0];
            string mail = row.Cells[4].Value.ToString();
            HSB.GetMaHS(mail);
            int x = HocSinhDTO.id;
            DialogResult result = MessageBox.Show("Đồng Ý Sẽ Không Khôi Phục Được", "Xóa Học Sinh", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Yes:
                    {
                        HSB.DeleteHS(x);
                        MessageBox.Show("Successful");
                        HSB.Load();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
