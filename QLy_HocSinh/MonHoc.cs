using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Globalization;

namespace QLy_HocSinh
{
    public partial class MonHoc : Form
    {
        HocSinhBUS HSB = new HocSinhBUS();
        public MonHoc()
        {
            InitializeComponent();
        }
        private void showinpanel(object fom)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = fom as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        public class CheckNH : BaseValidator
        {
            public bool IsNumber(string pText)
            {
                Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                return regex.IsMatch(pText);
            }
            public CheckNH()
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
                    if(IsNumber(ControlToValidate.Text)==false)
                    {
                        ErrorMessage = "năm học phải là số ";
                        return false;
                    }
                    else
                    {
                        int x = int.Parse(ControlToValidate.Text);
                        if(x<DateTime.Now.Year || x >2030)
                        {
                            ErrorMessage = "năm học phải trong khoảng từ "+DateTime.Now.Year+" đến 2030 vd:2019";
                            return false;
                        }
                        else
                        {
                            
                        }
                    }
                }
                ErrorMessage = null;
                return true;

            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (namhoc.Text != "" && checkNH1.ErrorMessage == null && hkcombo.SelectedItem !=null)
            {
                string mahk = hkcombo.SelectedItem.ToString() + namhoc.Text;
                int ma = int.Parse(mahk);
                int i = 0;
                foreach(var x in HocKi.HK)
                {
                    if(x.MaHK1 == ma)
                    {
                        i = 1;
                        MessageBox.Show("năm học này đã có học kì " + namhoc.Text);
                        break;
                    }
                    
                }
                if(i==0)
                {
                    HocKi h = new HocKi(ma, hkcombo.Text);
                    HSB.AddHK(h);
                    MessageBox.Show("successfull");
                    MonHoc_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("phải điền đúng và đầy đủ năm học và học kì");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            HSB.Loadkl();
            HSB.loadnohk();
            HSB.loadBCM();
            List<string> l = new List<string>();
            foreach (var s in clasDTO.lop)
            {

                l.Add(s.TenL1);
            }
            dslopcbox.DataSource = l.ToList();
            hkcombo.SelectedItem = null;
           bool i = HSB.Checkhk();
            if (i == true)
            {
                panel1.Visible = true;
                label1.Visible = false;
                button1.Visible = false;
                namhoc.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                hkcombo.Visible = false;
            }
            List<string> NH = new List<string>();
            foreach (var s in HocKi.HK)
            {
                int k = 1;
                string x = s.MaHK1.ToString();
                char[] ar = x.ToCharArray();
                string nam = ar[1].ToString() + ar[2].ToString() + ar[3].ToString() + ar[4].ToString();
                for(int o=0;o<NH.Count();o++)
                {
                    if(nam == NH[o])
                    {
                        k = 0;
                    }
                }
                if(k==1)
                    NH.Add(nam);


            }

            namhoccombo.DataSource = NH.ToList();
            yearcombo.DataSource = NH.ToList();

            foreach (var s in CTMonHoc.noneHK)
            {
              

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = s.MaMon1;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = s.TenMon1;
                row.Cells.Add(cell);
                
                mhnothkgrid.Rows.Add(row);

            }
          
        }

        private void a_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label1.Visible = true;
            button1.Visible = true;
            namhoc.Visible = true;
            
            label2.Visible = true;
            label3.Visible = true;
            hkcombo.Visible = true;
        }

        private void namhoccombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> hocki = new List<string>();
            if(namhoccombo.SelectedItem != null)
            {

                foreach(var kq in HocKi.HK)
                {
                    string x = kq.MaHK1.ToString();
                    char[] ar = x.ToCharArray();
                    string nam = ar[1].ToString() + ar[2].ToString() + ar[3].ToString() + ar[4].ToString();
                    if(nam==namhoccombo.SelectedItem.ToString())
                    {
                        if (ar[0].ToString() == "1")
                        {
                            hocki.Add("HK1");
                        }
                        else
                            hocki.Add("HK2");
                    }

                }
                hockicomboo.DataSource = hocki.ToList();

            }
        }

        public static string VietHoa(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;

            string result = "";

            //lấy danh sách các từ  

            string[] words = s.Split(' ');

            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
                }

            }
            return result.Trim();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            showinpanel(new AddMonHoc());
        }
        public class CheckNameMH : BaseValidator
        {
            public CheckNameMH()
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
                    string mh = ControlToValidate.Text;
                    string c = mh.ToLower();
                    string d = VietHoa(c);
                    if (c =="toan" || c == "ly" || c == "hoa" || c == "sinh" || c == "su" || c == "dia" || c == "van" || c == "dao duc" || c == "the duc" )
                    {
                        
                        foreach(var s in CTMonHoc.ctmh)
                        {
                            if(d==s.TenMon1)
                            {
                                ErrorMessage = "môn học đã có trong hệ thống";
                                return false;
                            }
                        }
                    }
                    else
                    {
                        ErrorMessage = "chỉ được thêm trong 9 môn {toan, ly, hoa, sinh , su ,dia,van,dao duc,the duc}";
                        return false;
                    }
                }
                ErrorMessage = null;
                return true;

            }
        }

        private void hkcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsmhgrid.Rows.Clear();
            string tt1 = namhoccombo.SelectedItem.ToString();
            string tt2 = hockicomboo.SelectedItem.ToString();
            string tt3 = "";
            if(tt2 == "HK1")
            {
                tt3 = 1 + tt1;
            }
            else if(tt2 == "HK2") { tt3 = 2 + tt1; }
            int kq = int.Parse(tt3);
            HSB.loadhavehk(kq);
            foreach (var s in CTMonHoc.haveHK)
            {


                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = s.MaMon1;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = s.TenMon1;
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = hockicomboo.SelectedItem.ToString();
                row.Cells.Add(cell);
                cell = new DataGridViewTextBoxCell();
                cell.Value = namhoccombo.SelectedItem.ToString();

                row.Cells.Add(cell);


                dsmhgrid.Rows.Add(row);

            }
        }

        private void hk1bt_Click(object sender, EventArgs e)
        {
            string x = yearcombo.SelectedItem.ToString();
            string y = "1" + x;
            int z = int.Parse(y);
            int i = 0;
            if(mhnothkgrid.SelectedRows.Count > 0)
            {
                foreach (var nh in HocKi.HK)
                {

                    if (nh.MaHK1 == z && mhnothkgrid.SelectedRows.Count > 0)
                    {
                        i = 1;
                        DataGridViewRow row = mhnothkgrid.SelectedRows[0];

                        string mabc = nh.MaHK1 + row.Cells[0].Value.ToString();
                        CTMonHoc chitiet = new CTMonHoc(mabc, nh.MaHK1, row.Cells[0].Value.ToString());
                        HSB.AddMHtoHK(chitiet);
                        MessageBox.Show("successfull");
                    }
                }
                if (i == 0)
                {
                    MessageBox.Show("năm học này chưa có học kì này");
                }
            }
            else
            {
                MessageBox.Show("chưa chọn môn cần thêm vào học kì");
            }
           
           
        }

        private void hk2bt_Click(object sender, EventArgs e)
        {
            string x = yearcombo.SelectedItem.ToString();
            string y = "2" + x;
            int z = int.Parse(y);
            int i = 0;
            if (mhnothkgrid.SelectedRows.Count > 0)
            {
                foreach (var nh in HocKi.HK)
                {

                    if (nh.MaHK1 == z && mhnothkgrid.SelectedRows.Count > 0)
                    {
                        i = 1;
                        DataGridViewRow row = mhnothkgrid.SelectedRows[0];

                        string mabc = nh.MaHK1 + row.Cells[0].Value.ToString();
                        CTMonHoc chitiet = new CTMonHoc(mabc, nh.MaHK1, row.Cells[0].Value.ToString());
                        HSB.AddMHtoHK(chitiet);
                        MessageBox.Show("successfull");
                    }
                }
                if (i == 0)
                {
                    MessageBox.Show("năm học này chưa có học kì này");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn môn học cần thêm vào học kì");
            }

        }

        private void dsmhgrid_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenlopx = dslopcbox.SelectedItem.ToString();
            string malopy = "";
            DataGridViewRow row = dsmhgrid.SelectedRows[0];

            string hkz= row.Cells[2].Value.ToString();
            string namhoc = row.Cells[3].Value.ToString();
            string mamhz2= row.Cells[0].Value.ToString();
            string mahocki = "";
            foreach (var i in clasDTO.lop)
            {
                if(i.TenL1 == tenlopx)
                {
                    malopy = i.MaL1;
                }
            }
            int checktt = 0;
            if (dsmhgrid.SelectedRows.Count > 0)
            {
                if(dslopcbox.SelectedItem.ToString() != "")
                {
                    foreach(var ok in CTMonHoc.ctmh)
                    {
                        if( ok.MaLop1 == malopy )
                        {
                            if(ok.MaMon1 == mamhz2)
                            {
                                checktt = 1;
                                MessageBox.Show("môn học đã tồn tại trong lớp");
                                break;
                            }
                            else
                            {
                                checktt = 0;
                            }
                        }
                        
                      
                    }
                    if (hkz == "HK1")
                    {
                        mahocki = 1 + namhoc;
                    }
                    else
                    {
                        mahocki = 2 + namhoc;
                    }

                    int mhk = int.Parse(mahocki);
                    if(checktt ==0)
                    {
                       
                       HSB.AddMHtoClass(malopy, mamhz2, mhk);
                        MessageBox.Show("successfull");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dsmhgrid.SelectedRows[0];
            string mh = row.Cells[0].Value.ToString();
            



            DialogResult result = MessageBox.Show("Đồng Ý Sẽ Không Khôi Phục Được", "Xóa Môn Học", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Yes:
                    {
                        HSB.DelMH(mh);
                        MessageBox.Show("Successful");
                        MonHoc_Load(sender, e);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
