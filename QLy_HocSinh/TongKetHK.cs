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
using System.Globalization;
namespace QLy_HocSinh
{
    public partial class TongKetHK : Form
    {
        HocSinhBUS HSB = new HocSinhBUS();
        public TongKetHK()
        {
            InitializeComponent();
        }

        private void TongKetHK_Load(object sender, EventArgs e)
        {
            HSB.Loadkl();
            HSB.loadnohk();
            HSB.loadBCM();
            List<string> NH = new List<string>();
            foreach (var s in HocKi.HK)
            {
                int k = 1;
                string x = s.MaHK1.ToString();
                char[] ar = x.ToCharArray();
                string nam = ar[1].ToString() + ar[2].ToString() + ar[3].ToString() + ar[4].ToString();
                for (int o = 0; o < NH.Count(); o++)
                {
                    if (nam == NH[o])
                    {
                        k = 0;
                    }
                }
                if (k == 1)
                    NH.Add(nam);


            }

            namhoccombo.DataSource = NH.ToList();
            HSB.Load();
            HSB.loadBCM();


            List<string> kl = new List<string>();
            foreach (var s in ClassDTO.khoilop)
            {
                kl.Add(s.TenK1);
            }

            kLcombo.DataSource = kl.ToList();
        }

        private void HKcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            xuatdstk();
        }
        private void xuatdstk()
        {
            if (Lop.Checked == true)
            {
                TKHKgrid.Rows.Clear();
                string hk = HKcombo.SelectedItem.ToString();
                string nam = namhoccombo.SelectedItem.ToString();
                string h = "";
                int hk2 = 0;
                string mal = "";
                if (hk == "HK1")
                {
                    h = 1 + nam;
                    hk2 = int.Parse(h);
                }
                else
                {
                    h = 2 + nam;
                    hk2 = int.Parse(h);
                }
                foreach (var ss in clasDTO.lop)
                {

                    if (ss.TenL1 == classcombo.SelectedItem.ToString())
                    {
                        mal = ss.MaL1;
                    }
                }
                HSB.getBCHocKi(mal, hk2);
                foreach (var s in CTMonHoc.BaoCaoHocKi)
                {

                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = s.MaHK1;
                    row.Cells.Add(cell);
                    cell = new DataGridViewTextBoxCell();
                    foreach (var lop in clasDTO.lop)
                    {

                        if(lop.MaL1 ==s.MaLop1)
                        {
                            mal = lop.TenL1;
                        }
                    }
                    cell.Value = mal;
                    row.Cells.Add(cell);

                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.SLdat1;
                    row.Cells.Add(cell);
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = s.TLdat1;
                    row.Cells.Add(cell);


                    TKHKgrid.Rows.Add(row);

                }

            }
            else
            {
                if (hkradio.Checked == true)
                {
                    TKHKgrid.Rows.Clear();
                    string hk = HKcombo.SelectedItem.ToString();
                    string nam = namhoccombo.SelectedItem.ToString();
                    string h = "";
                    string ml = "";
                    int hk2 = 0;

                    if (hk == "HK1")
                    {
                        h = 1 + nam;
                        hk2 = int.Parse(h);
                    }
                    else
                    {
                        h = 2 + nam;
                        hk2 = int.Parse(h);
                    }

                    HSB.getBCHocKi2(hk2);
                    foreach (var s in CTMonHoc.BaoCaoHocKi)
                    {

                        DataGridViewRow row = new DataGridViewRow();

                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        cell.Value = s.MaHK1;
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        foreach (var lop in clasDTO.lop)
                        {

                            if (lop.MaL1 == s.MaLop1)
                            {
                                ml = lop.TenL1;
                            }
                        }
                        cell.Value = ml ;
                        row.Cells.Add(cell);

                        cell = new DataGridViewTextBoxCell();
                        cell.Value = s.SLdat1;
                        row.Cells.Add(cell);
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = s.TLdat1;
                        row.Cells.Add(cell);


                        TKHKgrid.Rows.Add(row);

                    }
                }
            }
        }
        private void namhoccombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> hocki = new List<string>();
            if (namhoccombo.SelectedItem != null)
            {

                foreach (var kq in HocKi.HK)
                {
                    string x = kq.MaHK1.ToString();
                    char[] ar = x.ToCharArray();
                    string nam = ar[1].ToString() + ar[2].ToString() + ar[3].ToString() + ar[4].ToString();
                    if (nam == namhoccombo.SelectedItem.ToString())
                    {
                        if (ar[0].ToString() == "1")
                        {
                            hocki.Add("HK1");
                        }
                        else
                            hocki.Add("HK2");
                    }

                }
                HKcombo.DataSource = hocki.ToList();

            }
        }

        private void classcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            xuatdstk();
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
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            xuatdstk();
        }

        private void hkradio_CheckedChanged(object sender, EventArgs e)
        {
            xuatdstk();
        }
    }
}
