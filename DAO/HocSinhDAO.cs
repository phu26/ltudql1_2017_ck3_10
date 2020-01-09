using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public  class HocSinhDAO : DBConnect
    {
        public void getSS()
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var ss = from d in hdb.THAMSOs select d.SiSoToiDa;
            string siso = ss.FirstOrDefault().ToString();
            int sx = int.Parse(siso);
            clasDTO.SS = sx;
        }

        public void getSLTL()
        {

            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var diemm = from d in hdb.THAMSOs select d.DiemDatMon;
            string diemtieuchuan = diemm.FirstOrDefault().ToString();
            float dtc = float.Parse(diemtieuchuan);
            CTMonHoc.DiemDat = dtc;

            var table = hdb.bang().ToList();
            var TKM = from a in hdb.BAOCAOTONGKETMONs select a;
            foreach (var i in TKM)
            {

                foreach (var j in table)
                {
                    if (j.MaLop == i.MaLop && j.MaMonHoc == i.MaMon)
                    {
                        hdb.setup(j.MaLop, j.MaMonHoc);
                    }
                }
            }


            foreach(var i in TKM)
            {
               
                foreach (var j in table)
                {
                    if(j.MaLop == i.MaLop && j.MaMonHoc==i.MaMon)
                    {
                        var purchCount = (from purchase in table where purchase.MaLop == j.MaLop && purchase.MaMonHoc==j.MaMonHoc  select purchase).Count();
                        string d1 = j.Diem15Phut.ToString();
                        string d2 = j.Diem1Tiet.ToString() ;
                        string d3 = j.DiemCuoiKi.ToString();
                        float diem1 = float.Parse(d1);
                        float diem2 = float.Parse(d2);
                        float diem3 = float.Parse(d3);
                        float TB = (diem1 + diem2 + diem3) / 3;
                        if(TB>=CTMonHoc.DiemDat )
                        {
                            hdb.updateSL(j.MaLop,j.MaMonHoc);
                            var sl = from ss in hdb.BAOCAOTONGKETMONs where ss.MaLop == j.MaLop && ss.MaMon == j.MaMonHoc select ss.SoLuongDatMon;
                            string SL = sl.FirstOrDefault().ToString();
                            int kq = int.Parse(SL);

                            float TL = (100 * kq) / purchCount;
                            hdb.updateTL(j.MaLop, j.MaMonHoc, TL);
                        }
                    }
                   
                }
            }
        }
        public void GetHSL(string MLop)
        {
            HocSinhDTO.lisths.Clear();
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var list = hdb.TracuuhocsinhLop(MLop);

            foreach (var x in list)
            {

                DateTime oDate = Convert.ToDateTime(x.Date);
                bool kt;
                if (bool.Parse(x.Sex) == true)
                {
                    kt = true;
                }
                else { kt = false; }
                string tb1 = x.TBHocKi1.ToString();
                string tb2 = x.TBHocKi2.ToString();
                HocSinhDTO hs = new HocSinhDTO(x.Name, x.Email, x.Address, kt, oDate, x.TenLop, float.Parse(tb1), float.Parse(tb2));
                HocSinhDTO.lisths.Add(hs);
            }
        }
        public void GetHSK(string MK)
        {
            HocSinhDTO.lisths.Clear();
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var list = hdb.TracuuhocsinhKL(MK);

            foreach (var x in list)
            {

                DateTime oDate = Convert.ToDateTime(x.Date);
                bool kt;
                if (bool.Parse(x.Sex) == true)
                {
                    kt = true;
                }
                else { kt = false; }
                string tb1 = x.TBHocKi1.ToString();
                string tb2 = x.TBHocKi2.ToString();
                HocSinhDTO hs = new HocSinhDTO(x.Name, x.Email, x.Address, kt, oDate,x.TenLop,float.Parse(tb1),float.Parse(tb2));
                HocSinhDTO.lisths.Add(hs);
            }
        }
        public void Get()
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            {
                HocSinhDTO.lisths.Clear();
              
                var q0 = from s0 in hdb.Hoc_sinhs select s0;
                
                foreach (var x in q0)
                {
                    
                    DateTime oDate = Convert.ToDateTime(x.Date);
                    bool kt;
                    if(bool.Parse(x.Sex) == true)
                    {
                        kt = true;
                    }
                    else { kt = false; }
                    
                    HocSinhDTO hs = new HocSinhDTO(x.Name,x.Email,x.Address,kt,oDate);
                    HocSinhDTO.lisths.Add(hs);
                }
                var q = from s in hdb.THAMSOs select s.TuoiToiThieu;
                var kq = q.FirstOrDefault();
                HocSinhDTO.toithieu = int.Parse(kq.ToString());
                var q2 = from s in hdb.THAMSOs select s.TuoiToiDa;
                var kq2 = q2.FirstOrDefault();
                HocSinhDTO.toida = int.Parse(kq2.ToString());
                ChiTietClass.ctclas.Clear();
                var ct = from st in hdb.CHITIETDSLOPs select st;

                foreach (var x in ct)
                {
                    string tb1 = x.TBHocKi1.ToString();
                    string tb2 = x.TBHocKi2.ToString();
                    ChiTietClass hsct = new ChiTietClass(x.MaChiTietDSLop, x.MaLop, x.MaHocSinh, float.Parse(tb1), float.Parse(tb2));
                    ChiTietClass.ctclas.Add(hsct);
                }
            

            }
            catch
            {
              
            }
        }
        public void GetKL()
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            {
                HocKi.HK.Clear();
                var hocki = from hk in hdb.HOCKIs select hk;
                if(hocki != null)
                {
                    foreach (var hki in hocki)
                    {
                        HocKi lst = new HocKi(hki.MaHocKi, hki.TenHocKi);
                        HocKi.HK.Add(lst);
                    }
                }
                CTMonHoc.ctmh.Clear();
                var ct = from mh in hdb.MONHOCs select mh;
                if (ct != null)
                {
                    foreach (var b in ct)
                    {
                        CTMonHoc lst = new CTMonHoc (b.MaMonHoc,b.TenMonHoc);
                        CTMonHoc.ctmh.Add(lst);
                    }
                }
               
              



                ClassDTO.khoilop.Clear();
                clasDTO.lop.Clear();
                var kk = from l in hdb.DANHSACHLOPs select l;
                var q = from kq in hdb.KHOILOPs select kq;
                if(q == null || kk ==null)
                {
                    clasDTO.TonTail = false;
                    ClassDTO.TonTai = false;
                }
                else {
                    ClassDTO.TonTai = true;
                    clasDTO.TonTail = true;
                    foreach (var x in q)
                    {
                        ClassDTO kl = new ClassDTO(x.MaKhoiLop, x.TenKhoiLop);
                        ClassDTO.khoilop.Add(kl) ;
                    }
                    foreach (var n in kk)
                    {
                        clasDTO lop = new clasDTO(n.MaLop, n.TenLop, 0, n.MaKhoiLop);
                        clasDTO.lop.Add(lop);
                    }
                }
               
                
            }
            catch
            {

            }
        }
        DataTable dt = new DataTable();
        public  void gethavehk(int mahk)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            CTMonHoc.haveHK.Clear();
            var yesHK = from mh in hdb.BAOCAOTONGKETMONs select mh;
            if (yesHK != null)
            {
                foreach (var yes in yesHK)
                {


                    
                    string cc = yes.MaHocKi.ToString();
                    int cc2 = int.Parse(cc);
                    if(cc2 == mahk)
                    {
                        CTMonHoc ee = new CTMonHoc(yes.MaBaoCaoMon, cc2, yes.MaMon);
                        CTMonHoc.haveHK.Add(ee);
                    }
                    


                }
            }
        }
        public void getMon()
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            CTMonHoc.mh.Clear();


            var mhoc = from si in hdb.MONHOCs select si;
            foreach (var ss in mhoc.ToList())
            {






                CTMonHoc x = new CTMonHoc(ss.MaMonHoc, ss.TenMonHoc);
                CTMonHoc.mh.Add(x);
            }
        }
        public void getBCM()
        {
            CTMonHoc.ctmh.Clear();

            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var qq = from si in hdb.BAOCAOTONGKETMONs select si;
            foreach( var ss in qq.ToList())
            {
                String cc = ss.MaHocKi.ToString();
                int cc2 = int.Parse(cc);

                



                CTMonHoc x = new CTMonHoc(ss.MaBaoCaoMon,cc2,ss.MaLop,ss.MaMon,0,0);
                CTMonHoc.ctmh.Add(x);
            }
            CTMonHoc.mh.Clear();


            var mhoc = from si in hdb.MONHOCs select si;
            foreach (var ss in mhoc.ToList())
            {






                CTMonHoc x = new CTMonHoc(ss.MaMonHoc, ss.TenMonHoc);
                CTMonHoc.mh.Add(x);
            }
        }
        public void getnohk()
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            CTMonHoc.noneHK.Clear();
            var monnohk = from mh in hdb.MONHOCs select mh;
            if (monnohk != null)
            {
                foreach (var no in monnohk)
                {

                    var MHnHK = hdb.noneHK(no.MaMonHoc);
                    if (MHnHK != null)
                    {
                        foreach(var oo in MHnHK)
                        {
                            CTMonHoc ee = new CTMonHoc(oo.MaMonHoc, oo.TenMonHoc);
                            CTMonHoc.noneHK.Add(ee);
                        }
                      
                    }

                }
            }
        }
        public bool GetMaHS(string email)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var kq = from s in hdb.Hoc_sinhs select s;
            foreach(var hs in kq.ToList())
            {
                if(email == hs.Email)
                {
                    HocSinhDTO.id = hs.ID;
                    return true;
                }

            }
            return false;
        }
        
        public bool Insert(HocSinhDTO hs)
        {
            try
            {
                
                HocSinhDBDataContext hdb = new HocSinhDBDataContext();
                
                Hoc_sinh hs2 = new Hoc_sinh { Name = hs.Name, Address = hs.Diachi, Email = hs.Email, Date = (hs.Ngsinh).ToString(), Sex = hs.Gioitinh.ToString() };
                
                hdb.Hoc_sinhs.InsertOnSubmit(hs2);
                hdb.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertKL(ClassDTO kl)
        {
            try
            {

                HocSinhDBDataContext hdb = new HocSinhDBDataContext();
                KHOILOP KL = new KHOILOP { MaKhoiLop = kl.MaK1, TenKhoiLop = kl.TenK1 };

                hdb.KHOILOPs.InsertOnSubmit(KL);
                hdb.SubmitChanges();
                
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertL(clasDTO l)
        {
            try
            {

                HocSinhDBDataContext hdb = new HocSinhDBDataContext();
                DANHSACHLOP L = new DANHSACHLOP { MaLop=l.MaL1,TenLop=l.TenL1,SiSo=l.SiSo1,MaKhoiLop=l.MaK1 };

                hdb.DANHSACHLOPs.InsertOnSubmit(L);
                hdb.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertHStoClass(ChiTietClass CT)
        {
            try
            {

                HocSinhDBDataContext hdb = new HocSinhDBDataContext();
                CHITIETDSLOP L = new CHITIETDSLOP { MaChiTietDSLop= CT.MaCT1,MaLop=CT.MaL1,MaHocSinh=CT.MaHS1,TBHocKi1=CT.TB11,TBHocKi2=CT.TB21 };

                hdb.CHITIETDSLOPs.InsertOnSubmit(L);
                hdb.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string Mhs)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Hoc_sinh", cn);
                DataRow r = dt.Rows.Find(Mhs);
               
                if(r != null)
                {
                    r.Delete();
                }
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(dt);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateHS(HocSinhDTO hs,int id)
        {
            try
            {
                HocSinhDBDataContext hdb = new HocSinhDBDataContext();
                hdb.updateHS(hs.Clas, id, hs.Name, hs.Diachi, hs.Email, hs.Ngsinh.ToString(), hs.Gioitinh.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteHS(int id)
        {
            try
            {
                HocSinhDBDataContext hdb = new HocSinhDBDataContext();
                hdb.XoaHS(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool checkHK()
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            { 

                var q = from s in hdb.HOCKIs select s.MaHocKi;
                List<int> mahk = new List<int>();
                mahk = q.ToList();
                if(mahk.Count()>0)
                {
                    return true;

                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public  bool AddHK(HocKi hk)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            {
                hdb.AddHK(hk.MaHK1, hk.TenHK1);
               
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddMH(CTMonHoc mh)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            {
                hdb.AddMH(mh.MaMon1, mh.TenMon1);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddMHtoHK(CTMonHoc hk)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            {
                hdb.AddMHtoNH(hk.MaBCMon1, hk.MaHK1, hk.MaMon1);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddMHtoClass(string ml,string mm,int mhk )
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            {
                hdb.mhtoclass(ml, mm, mhk);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddMHhs(int hs,int hk,string mh)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try {
                var kq = from s in hdb.MONHOCs where s.TenMonHoc == mh select s.MaMonHoc;
                string mamh = kq.First().ToString();
                BANGDIEM bd = new BANGDIEM { MaBangDiem = hs + mamh, MaHocSinh = hs, MaHocKi = hk, MaMonHoc = mamh, Diem15Phut = 0, Diem1Tiet = 0, DiemCuoiKi = 0 };
                hdb.BANGDIEMs.InsertOnSubmit(bd);
                hdb.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
        public void dsBD()
        {
            CTMonHoc.mhHS.Clear();
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var kq = from s in hdb.BANGDIEMs select s;
            foreach(var ok in kq.ToList())
            {

                float ck = float.Parse(ok.DiemCuoiKi.ToString());
                float p15 = float.Parse(ok.Diem15Phut.ToString());
                float t1 = float.Parse(ok.Diem1Tiet.ToString());
                int mhs = int.Parse(ok.MaHocSinh.ToString());
                int mhhk = int.Parse(ok.MaHocKi.ToString());
                CTMonHoc ctmhhs = new CTMonHoc(ok.MaBangDiem.ToString(),mhs,mhhk,ok.MaMonHoc.ToString(),p15,t1,ck);
                CTMonHoc.mhHS.Add(ctmhhs);
            }

        }
        public bool UpDateDiem(int Mahs,string Mamh,float p15,float t1,float ck)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            try
            {
                hdb.updateD(Mahs, Mamh, p15, t1, ck);
                return true;
            }
            catch
            {
                return false;
            }


        }

        public void Average()
        {
        
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var kkk = from c1 in hdb.BAOCAOTONGKETMONs join c2 in hdb.DANHSACHLOPs on c1.MaLop equals c2.MaLop group new { c1, c2 } by new { c1.MaHocKi, c1.MaLop } into g select new { g.Key.MaHocKi, g.Key.MaLop };
             
            foreach(var ttk in kkk)
            {
                string MaLop = ttk.MaLop;
                string Mahk = ttk.MaHocKi.ToString();
                int MaHK = int.Parse(Mahk);
                var q = hdb.KTave(MaLop, MaHK).ToList();
                var k = hdb.ktclass(MaLop, MaHK).ToList();
                int dem = 0;
                int dem2 = 0;
                foreach (var s in k)
                {
                    int xx = 0;

                    dem2++;
                    foreach (var d in q)
                    {

                        if (d.MaHocSinh == s.MaHocSinh)
                        {


                            if (d.DiemCuoiKi < 5)
                            {

                                xx = 1;
                                break;
                            }

                        }

                    }
                    if (xx == 0)
                    {

                        DiemTK t = new DiemTK(int.Parse(s.MaHocSinh.ToString()));
                        DiemTK.DS.Add(t);
                        dem++;
                    }

                }

                float TL = (100 * dem) / dem2;
                string x = MaHK + MaLop;
                hdb.addBCHK(x, MaHK, MaLop, dem, TL);

            }



        }
        public void GetBCMonHoc(string MaMon,int MaHK)
        {
            CTMonHoc.BaocaoMon.Clear();
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var x = from xx in hdb.BAOCAOTONGKETMONs where xx.MaHocKi == MaHK && xx.MaMon==MaMon select xx;
            foreach(var kq in x)
            {
               
                CTMonHoc bcm = new CTMonHoc(kq.MaBaoCaoMon, int.Parse(kq.MaHocKi.ToString()), kq.MaLop, kq.MaMon, int.Parse(kq.SoLuongDatMon.ToString()), float.Parse(kq.TiLeDatMon.ToString()));


                CTMonHoc.BaocaoMon.Add(bcm);
            }
        }
        public void GetBCHK(string MaLop,int MaHK)
        {
            CTMonHoc.BaoCaoHocKi.Clear();
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var x = from xx in hdb.BAOCAOTONGKETHKs where xx.MaHocKi == MaHK && xx.MaLop == MaLop select xx;
            foreach (var kq in x)
            {

                CTMonHoc bcm = new CTMonHoc(kq.MaBaoCaoHK, int.Parse(kq.MaHocKi.ToString()), kq.MaLop, int.Parse(kq.SoLuongDat.ToString()), float.Parse(kq.TiLeDat.ToString()));


                CTMonHoc.BaoCaoHocKi.Add(bcm);
            }
        }
        public void GetBCHK2( int MaHK)
        {
            CTMonHoc.BaoCaoHocKi.Clear();
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var x = from xx in hdb.BAOCAOTONGKETHKs where xx.MaHocKi == MaHK  select xx;
            foreach (var kq in x)
            {

                CTMonHoc bcm = new CTMonHoc(kq.MaBaoCaoHK, int.Parse(kq.MaHocKi.ToString()), kq.MaLop, int.Parse(kq.SoLuongDat.ToString()), float.Parse(kq.TiLeDat.ToString()));


                CTMonHoc.BaoCaoHocKi.Add(bcm);
            }
        }
        public void Login(string usn,string pass)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var k = from s in hdb.Userrs where s.userName == usn && s.passWord == pass select s;
            var x = k.FirstOrDefault();
            UsserrDTO.u = new UsserrDTO(x.Id,x.userName,x.passWord,int.Parse(x.permission.ToString()));
        }
        public void listaccount()
        {
            UsserrDTO.lstU.Clear();
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            var q = from s in hdb.Userrs select s;
            foreach (var kq in q.ToList())
            {
                UsserrDTO us = new UsserrDTO(kq.Id, kq.userName.ToString(), kq.passWord, int.Parse(kq.permission.ToString()));
                UsserrDTO.lstU.Add(us);
            }
        }
        public void AddU(UsserrDTO u)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            Userr k = new Userr { userName = u.Username, passWord = u.Pass, permission = u.Per };
            hdb.AddU(u.Username, u.Pass, u.Per);
        }
        public void UpdateU(UsserrDTO u)
        {
            int a = int.Parse(u.Id.ToString());
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            Userr k = new Userr { Id = u.Id, userName = u.Username, passWord = u.Pass, permission = u.Per };
            hdb.UpdateU(a,u.Pass,u.Per);
        }
        public void DelU(UsserrDTO u)
        {
            int a = int.Parse(u.Id.ToString());
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            Userr k = new Userr { Id = u.Id, userName = u.Username, passWord = u.Pass, permission = u.Per };
            hdb.DelU(a);
        }
        public void UpdateQD(int tt,int td,int ss,float diemdat)
        {
            HocSinhDBDataContext hdb = new HocSinhDBDataContext();
            hdb.UpdateQD(tt, td, ss, diemdat);
        }
        public void Logout()
        {
            
            UsserrDTO.u = new UsserrDTO(0,"","", 0);
        }

    }
}
