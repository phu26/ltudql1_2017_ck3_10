﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class CTMonHoc
    {
        
        private string TenMon;
        private int MaHS;
        private int MaHK;
        private string MaMon;
        private float Diem15p;
        private float Diem1t;
        private float DiemCuoiKi;

        public CTMonHoc(string mamh, string tenmh)
        {
            MaMon = mamh;
            TenMon = tenmh;
        }
        public CTMonHoc(int mahs,int hk,string mamon,float d15p,float d1t,float ck )
        {
            MaHS = mahs;
            MaHK = hk;
            MaMon = mamon;
            Diem15p = d15p;
            Diem1t = d1t;
            DiemCuoiKi = ck;
        }
        public int MaHS1 { get => MaHS; set => MaHS = value; }
        public string MaHK1 { get => MaHK; set => MaHK = value; }
        public string MaMon1 { get => MaMon; set => MaMon = value; }
        public float Diem15p1 { get => Diem15p; set => Diem15p = value; }
        public float Diem1t1 { get => Diem1t; set => Diem1t = value; }
        public float DiemCuoiKi1 { get => DiemCuoiKi; set => DiemCuoiKi = value; }
        public string TenMon1 { get => TenMon; set => TenMon = value; }
    }
}