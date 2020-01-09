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
    public partial class DSclass : Form
    {
      
        HocSinhBUS HSB = new HocSinhBUS();
        public DSclass()
        {
            InitializeComponent();
        }

        private void DSclass_Load(object sender, EventArgs e)
        {
            HSB.Load();
            HSB.loadBCM();
            if (dshsgrid.SelectedRows.Count <0)
            {
                if(UsserrDTO.u.Per ==3)
                {
                    button1.Visible = false;
                  
                }
               
            }
            List<string> kl = new List<string>();
            foreach (var s in ClassDTO.khoilop)
            {
                kl.Add(s.TenK1); 
            }

            kLcombo.DataSource = kl.ToList();
            if(UsserrDTO.u.Per ==0 || UsserrDTO.u.Per == 2)
            {
                txtht.Enabled = false;
                txtdate.Enabled = false;
                txt15p.Enabled = false;
                txt1t.Enabled = false;
                txtaddr.Enabled = false;
                txtck.Enabled = false;
                txtclass.Enabled = false;
                txtdate.Enabled = false;
                txthk1.Enabled = false;
                txthk2.Enabled = false;
                txtmail.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                addsubjecttohs.Visible = false;
                updateD.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void kLcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kLcombo.SelectedItem != null)
            {
                List<string> l = new List<string>();
                foreach (var s in clasDTO.lop)
                {
                    string tk = kLcombo.SelectedItem.ToString();
                    char[] ar = s.TenL1.ToCharArray();
                    string test = ar[0].ToString() + ar[1].ToString();
                    if (tk == test)
                    {
                        l.Add(s.TenL1);
                    }

                }

                classcombo.DataSource = l.ToList();

                if (l.Count() == 0)
                {
                   classcombo.Text = null;
                }
                if(KL.Checked == true)
                {
                    dshsgrid.Rows.Clear();
                    HSB.Loadhsk(kLcombo.SelectedItem.ToString());
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
                        cell.Value = s.Clas;
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
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = s.HK11;
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = s.HK21;
                        row.Cells.Add(cell);

                        dshsgrid.Rows.Add(row);

                    }
                }
                else
                {
                    dshsgrid.Rows.Clear();
                   
                }

            }
            

        }

        private void KL_CheckedChanged(object sender, EventArgs e)
        {
           if(KL.Checked==true)
            {
                dshsgrid.Rows.Clear();
                HSB.Loadhsk(kLcombo.SelectedItem.ToString());
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
                    cell.Value = s.Clas;
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
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.HK11;
                    row.Cells.Add(cell);
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.HK21;
                    row.Cells.Add(cell);

                    dshsgrid.Rows.Add(row);

                }
            }
        }

        private void classcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classcombo.SelectedItem != null)
            {
                if (Lop.Checked == true)
            {
                dshsgrid.Rows.Clear();
                HSB.Loadhsl(classcombo.SelectedItem.ToString());
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
                    cell.Value = s.Clas;
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
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.HK11;
                    row.Cells.Add(cell);
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.HK21;
                    row.Cells.Add(cell);

                    dshsgrid.Rows.Add(row);

                }
                    subjectoffclassGrid.Rows.Clear();

                    string tt1 = classcombo.SelectedItem.ToString();

                    HSB.loadBCM();
                    var qq = from s in CTMonHoc.ctmh join c in clasDTO.lop on s.MaLop1 equals c.MaL1 join d in CTMonHoc.mh on s.MaMon1 equals d.MaMon1 join f in HocKi.HK on s.MaHK1 equals f.MaHK1 select new { s.MaHK1, s.MaMon1, f.TenHK1, c.TenL1, d.TenMon1 };
                    foreach (var kq in qq.ToList())
                    {

                        if (kq.TenL1 == tt1)
                        {
                            DataGridViewRow row = new DataGridViewRow();

                            DataGridViewCell cell = new DataGridViewTextBoxCell();
                            cell.Value = kq.TenMon1;
                            row.Cells.Add(cell);
                            cell = new DataGridViewTextBoxCell();
                            cell.Value = kq.TenHK1;
                            row.Cells.Add(cell);
                            string x = kq.MaHK1.ToString();
                            char[] ar = x.ToCharArray();
                            string nam = ar[1].ToString() + ar[2].ToString() + ar[3].ToString() + ar[4].ToString();


                            cell = new DataGridViewTextBoxCell();
                            cell.Value = nam;
                            row.Cells.Add(cell);

                            subjectoffclassGrid.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void Lop_CheckedChanged(object sender, EventArgs e)
        {
            if (Lop.Checked == true)
            {
                dshsgrid.Rows.Clear();
                HSB.Loadhsl(classcombo.SelectedItem.ToString());
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
                    cell.Value = s.Clas;
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
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.HK11;
                    row.Cells.Add(cell);
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.HK21;
                    row.Cells.Add(cell);

                    dshsgrid.Rows.Add(row);

                }
                subjectoffclassGrid.Rows.Clear();

                string tt1 = classcombo.SelectedItem.ToString();

                HSB.loadBCM();
                var qq = from s in CTMonHoc.ctmh join c in clasDTO.lop on s.MaLop1 equals c.MaL1 join d in CTMonHoc.mh on s.MaMon1 equals d.MaMon1 join f in HocKi.HK on s.MaHK1 equals f.MaHK1 select new { s.MaHK1, s.MaMon1, f.TenHK1, c.TenL1,d.TenMon1 };
                foreach (var kq in qq.ToList())
                {

                    if (kq.TenL1 == tt1)
                    {
                        DataGridViewRow row = new DataGridViewRow();

                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        cell.Value = kq.TenMon1;
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = kq.TenHK1;
                        row.Cells.Add(cell);
                        string x = kq.MaHK1.ToString();
                        char[] ar = x.ToCharArray();
                        string nam = ar[1].ToString() + ar[2].ToString() + ar[3].ToString() + ar[4].ToString();


                        cell = new DataGridViewTextBoxCell();
                        cell.Value = nam;
                        row.Cells.Add(cell);

                        subjectoffclassGrid.Rows.Add(row);
                    }
                }
            }
        }

        public class CheckTenL2 : BaseValidator
        {
            public CheckTenL2()
            {

            }
            public override bool Validate()
            {

                if (ControlToValidate.Text.Length <= 0)
                {
                    ErrorMessage = "không được để trống";
                    return false;

                }

                else
                {
                    string x = ControlToValidate.Text;
                    char[] ar = x.ToCharArray();


                    if (ar.Length > 4 || ar.Length < 4)
                    {
                        ErrorMessage = "cần nhập đúng tên lớp vd : 10A1";
                        return false;

                    }
                    else
                    {
                        string so = ar[0].ToString() + ar[1].ToString();
                        string chu = ar[2].ToString();

                        int so2 = int.Parse(ar[3].ToString());

                        if (chu == "A")
                        {
                            if (so == "10" || so == "11" || so == "12")
                            {
                                if (so == "10")
                                {

                                    if (so2 < 1 || so2 > 4)
                                    {
                                        ErrorMessage = "khối 10 chỉ có (10A1 - > 10A4)";
                                        return false;
                                    }
                                    else
                                    {
                                        if (ClassDTO.TonTai == true)
                                        {
                                            foreach (var n in clasDTO.lop)
                                            {
                                                if (x == n.TenL1)
                                                {
                                                    
                                                    return true;


                                                }

                                            }
                                            ErrorMessage = "tên lớp không tồn tại";
                                            return false;

                                        }
                                    }

                                }
                                else
                                {
                                    if (so == "11")
                                    {
                                        if (so2 < 1 || so2 > 3)
                                        {
                                            ErrorMessage = "khối 11 chỉ có (11A1 - > 11A3)";
                                            return false;
                                        }
                                        else
                                        {
                                            if (ClassDTO.TonTai == true)
                                            {
                                                foreach (var n in clasDTO.lop)
                                                {
                                                    if (x == n.TenL1)
                                                    {
                                                        
                                                        return true;


                                                    }

                                                }
                                                ErrorMessage = "tên lớp không tồn tại";
                                                return false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (so == "12")
                                        {
                                            if (so2 < 1 || so2 > 2)
                                            {
                                                ErrorMessage = "khối 12 chỉ có (12A1 - > 12A2)";
                                                return false;
                                            }
                                            else
                                            {
                                                if (ClassDTO.TonTai == true)
                                                {
                                                    foreach (var n in clasDTO.lop)
                                                    {
                                                        if (x == n.TenL1)
                                                        {
                                                            
                                                            return true;


                                                        }

                                                    }
                                                    ErrorMessage = "tên lớp không tồn tại";
                                                    return false;
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                            else
                            {
                                ErrorMessage = "Chỉ được thêm 3 khối lớp (10, 11 ,12)";
                                return false;
                            }

                        }
                        else
                        {
                            ErrorMessage = "cần nhập đúng tên lớp vd : 10A1";
                            return false;
                        }


                    }

                }
                ErrorMessage = "tên lớp phải tồn tại";
                return false;

            }
        }
        private void dshsgrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dshsgrid.SelectedRows.Count > 0)
            {
                subjectoffstudentGrid.Rows.Clear();
                if(UsserrDTO.u.Per ==3 )
                {
                    button1.Visible = true;
                    button2.Visible = true;
                }
               
                DataGridViewRow row = dshsgrid.SelectedRows[0];
                txtht.Text = row.Cells[0].Value.ToString();
                txtclass.Text = row.Cells[1].Value.ToString();
                txtdate.Text = row.Cells[3].Value.ToString();
                txtaddr.Text = row.Cells[4].Value.ToString();
                txtmail.Text = row.Cells[5].Value.ToString();
                txthk1.Text = row.Cells[6].Value.ToString();
                txthk2.Text = row.Cells[7].Value.ToString();

                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    namradio.Checked = true;
                }
                else
                {
                    nuradio.Checked = true;
                }
                HSB.GetMaHS(row.Cells[5].Value.ToString());
                txtma.Text = HocSinhDTO.id.ToString();
                HSB.getdsbd();
                var listmh2 = from l2 in CTMonHoc.mhHS select l2;
                var listmh = from l in CTMonHoc.mhHS 
                             join hk in HocKi.HK on l.MaHK1 equals hk.MaHK1
                             join m in CTMonHoc.mh on l.MaMon1 equals m.MaMon1 select new { m.TenMon1, hk.TenHK1, l.MaHK1, l.Diem15p1,l.Diem1t1,l.DiemCuoiKi1,l.MaHS1  };
                foreach(var list in listmh.ToList())
                {
                    if(list.MaHS1 == HocSinhDTO.id)
                    {
                        DataGridViewRow r = new DataGridViewRow();

                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        cell.Value = list.TenMon1;
                        r.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = list.TenHK1;
                        r.Cells.Add(cell);
                        string x = list.MaHK1.ToString();
                        char[] ar = x.ToCharArray();
                        string nam = ar[1].ToString() + ar[2].ToString() + ar[3].ToString() + ar[4].ToString();


                        cell = new DataGridViewTextBoxCell();
                        cell.Value = nam;
                        r.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = list.Diem15p1;
                        r.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = list.Diem1t1;
                        r.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = list.DiemCuoiKi1;
                        r.Cells.Add(cell);

                        subjectoffstudentGrid.Rows.Add(r);
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime oDate = Convert.ToDateTime(txtdate.Text);
            bool kt;
            if (namradio.Checked == true)
            {
                kt = true;
            }
            else { kt = false; }
            HocSinhDTO k = new HocSinhDTO(txtht.Text, txtmail.Text, txtaddr.Text,kt,oDate,txtclass.Text);
            int x = int.Parse(txtma.Text);
            HSB.UpdateHS(k, x);
            MessageBox.Show("successfull");
            if(KL.Checked ==true)
            {
                kLcombo_SelectedIndexChanged(sender, e);
            }
            else
                if(Lop.Checked==true)
            {
                classcombo_SelectedIndexChanged(sender, e);
            }
         

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtma.Text);
            DialogResult result = MessageBox.Show("Đồng Ý Sẽ Không Khôi Phục Được", "Xóa Học Sinh", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Yes:
                    {
                        HSB.DeleteHS(x);
                        MessageBox.Show("Seccessfull");
                        break;
                    }
                default:
                    break;
            }
        }

        private void addsubjecttohs_Click(object sender, EventArgs e)
        {
            if(subjectoffclassGrid.SelectedRows.Count>0)
            {
                if(dshsgrid.SelectedRows.Count>0)
                {
                    
                    DataGridViewRow row = dshsgrid.SelectedRows[0];
                    string mail = row.Cells[5].Value.ToString();
                    HSB.GetMaHS(mail);
                    DataGridViewRow row2 = subjectoffclassGrid.SelectedRows[0];
                    string two = row2.Cells[1].Value.ToString()+ row2.Cells[2].Value.ToString();
                    int mahk2 = int.Parse(two);
                    int test = 0;
                    HSB.getdsbd();
                    var mh = from m in CTMonHoc.mh where m.TenMon1 == row2.Cells[0].Value.ToString() select m.MaMon1;
                    foreach (var kt in CTMonHoc.mhHS)
                    {
                        string mamh = mh.FirstOrDefault().ToString();
                        if(kt.MaHS1==HocSinhDTO.id && kt.MaMon1==mamh)
                        {
                            test = 1;
                            MessageBox.Show("học sinh này đã học môn này");
                            break;
                        }

                    }
                    if(test ==0)
                    {
                        HSB.AddMHtoHS(HocSinhDTO.id, mahk2, row2.Cells[0].Value.ToString());
                        MessageBox.Show("successfull");
                    }
                  
                }
                else
                {
                    MessageBox.Show("vui lòng chọn học sinh ");
                }
            }
            else
            {
                MessageBox.Show("vui lòng chọn môn cần thiết");
            }
        }

        private void subjectoffstudentGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (subjectoffstudentGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = subjectoffstudentGrid.SelectedRows[0];
                txt15p.Text = row.Cells[3].Value.ToString();
                txt1t.Text = row.Cells[4].Value.ToString();
                txtck.Text = row.Cells[5].Value.ToString();
            }
        }

        private void updateD_Click(object sender, EventArgs e)
        {
            if(subjectoffstudentGrid.SelectedRows.Count>0)
            {
                DataGridViewRow row = dshsgrid.SelectedRows[0];
                string mail = row.Cells[5].Value.ToString();
                HSB.GetMaHS(mail);
                HSB.getMon();
                DataGridViewRow row2 = subjectoffstudentGrid.SelectedRows[0];
                
                var mon = from ma in CTMonHoc.mh where ma.TenMon1 == row2.Cells[0].Value.ToString() select ma.MaMon1;
                string Mamh = mon.FirstOrDefault().ToString();
                string d1 = txt15p.Text;
                string d2 = txt1t.Text;
                string d3 = txtck.Text;
                float diem1 = float.Parse(d1);
                float diem2 = float.Parse(d2);
                float diem3 = float.Parse(d3);

                if((diem1<=10 && diem1 >=0 ) && (diem1 <= 10 && diem1 >= 0) && (diem1 <= 10 && diem1 >= 0))
                {
                    HSB.CapNhatDiem(HocSinhDTO.id, Mamh, diem1, diem2, diem3);
                    HSB.TLSL();
                    MessageBox.Show("update successfull");
                    dshsgrid_SelectionChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("điểm môn không được lớn hơn 10 hoặc nhỏ hơn 0");
                }

            }
            else
            {
                MessageBox.Show("vui lòng chọn môn cần cập nhật");
            }
        }
    }
}
