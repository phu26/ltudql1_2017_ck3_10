﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class CTMonHoc
    {
        public static float DiemDat;
        public static List<CTMonHoc> BaoCaoHocKi = new List<CTMonHoc>();
        public static List<CTMonHoc> BaocaoMon = new List<CTMonHoc>();
        public static List<CTMonHoc> haveHK = new List<CTMonHoc>();
        public static List<CTMonHoc> noneHK = new List<CTMonHoc>();
        public static List<CTMonHoc> ctmh = new List<CTMonHoc>();
        public static List<CTMonHoc> mh = new List<CTMonHoc>();
        public static List<CTMonHoc> mhHS = new List<CTMonHoc>();
        private string MaBD;
        private string MaBCMon;
        private string TenMon;
        private int MaHS;
        private int MaHK;
        private string MaMon;
        private float Diem15p;
        private float Diem1t;
        private float DiemCuoiKi;
        private int SLdat;
        private float TLdat;
        private string MaLop;
        

        public CTMonHoc(string mamh, string tenmh)
        {
            MaMon = mamh;
            TenMon = tenmh;
        }
        public CTMonHoc(string MaBC,int hk,string mamh)
        {
            MaBCMon = MaBC;
            MaMon = mamh;
           
            MaHK = hk;
        }
        public CTMonHoc(string MaBC, int hk,string malop ,string mamh,int sl,float tl )
        {
            MaBCMon = MaBC;
            MaMon = mamh;
            MaLop = malop;
            MaHK = hk;
            SLdat = sl;
            TLdat = tl;
        }
        public CTMonHoc(string MaBCHK, int hk, string malop, int sl, float tl)
        {
            MaBCMon = MaBCHK;
            
            MaLop = malop;
            MaHK = hk;
            SLdat = sl;
            TLdat = tl;
        }
        public CTMonHoc(string Mabd,int mahs,int hk,string mamon,float d15p,float d1t,float ck )
        {
            MaBD = Mabd;
            MaHS = mahs;
            MaHK = hk;
            MaMon = mamon;
            Diem15p = d15p;
            Diem1t = d1t;
            DiemCuoiKi = ck;
        }
       
        public int MaHS1 { get => MaHS; set => MaHS = value; }
        public int MaHK1 { get => MaHK; set => MaHK = value; }
        public string MaMon1 { get => MaMon; set => MaMon = value; }
        public float Diem15p1 { get => Diem15p; set => Diem15p = value; }
        public float Diem1t1 { get => Diem1t; set => Diem1t = value; }
        public float DiemCuoiKi1 { get => DiemCuoiKi; set => DiemCuoiKi = value; }
        public string TenMon1 { get => TenMon; set => TenMon = value; }
        public string MaBCMon1 { get => MaBCMon; set => MaBCMon = value; }
        public int SLdat1 { get => SLdat; set => SLdat = value; }
        public float TLdat1 { get => TLdat; set => TLdat = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string MaBD1 { get => MaBD; set => MaBD = value; }
    }
}
