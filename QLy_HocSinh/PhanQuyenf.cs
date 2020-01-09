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
    public partial class PhanQuyenf : Form
    {
        HocSinhBUS HSB = new HocSinhBUS();
        public PhanQuyenf()
        {
            InitializeComponent();
        }

        private void PhanQuyenf_Load(object sender, EventArgs e)
        {
            HSB.listAC();
            DsUsergrid.Rows.Clear();
            foreach(var q in UsserrDTO.lstU)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = q.Id;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = q.Username;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = q.Pass;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = q.Per;
                row.Cells.Add(cell);
               


                DsUsergrid.Rows.Add(row);
            }
              
        }

        private void DsUsergrid_SelectionChanged(object sender, EventArgs e)
        {
            if(DsUsergrid.SelectedRows.Count >0)
            {
                DataGridViewRow row = DsUsergrid.SelectedRows[0];
                txtid.Text = row.Cells[0].Value.ToString();
                txtusername.Text = row.Cells[1].Value.ToString();
                txtpass.Text = row.Cells[2].Value.ToString();
                txtPer.Text = row.Cells[3].Value.ToString();
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach(var kq in UsserrDTO.lstU)
            {
                if(kq.Username == txtusername.Text)
                {
                    kt = 1;
                    break;
                }
            }
           if(kt==0)
            {
                UsserrDTO n = new UsserrDTO(int.Parse(txtid.Text), txtusername.Text, txtpass.Text, int.Parse(txtPer.Text));

                HSB.AddU(n);
                MessageBox.Show("Thêm thành công");
                PhanQuyenf_Load(sender, e); 
            }
            else
            {
                MessageBox.Show("tài khoản đã tồn tại");
            }
        }

        private void UpdatePer_Click(object sender, EventArgs e)
        {
            UsserrDTO n = new UsserrDTO(int.Parse(txtid.Text), txtusername.Text, txtpass.Text, int.Parse(txtPer.Text));
            HSB.UpU(n);
            MessageBox.Show("update thành công");
            PhanQuyenf_Load(sender, e);
        }

        private void DelUser_Click(object sender, EventArgs e)
        {
            UsserrDTO n = new UsserrDTO(int.Parse(txtid.Text), txtusername.Text, txtpass.Text, int.Parse(txtPer.Text));
            HSB.DelU(n);
            MessageBox.Show("Xóa thành công");
            PhanQuyenf_Load(sender,e);
        }

    }
}
