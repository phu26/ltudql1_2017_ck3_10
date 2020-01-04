﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HocSinhBUS
    {
      
        HocSinhDAO HS = new HocSinhDAO();
        public void AVG()
        {
            HS.Average();
        }
        public void TLSL()
        {
            HS.getSLTL();
        }
        public void Load()
        {
            HS.Get();
        }
        public void loadhavehk(int mahk)
        {
            HS.gethavehk(mahk);
        }
        public void loadnohk()
        {
            HS.getnohk();
        }
        public void Loadhsk(string x)
        {
           
            HS.GetHSK(x);
        }
        public void Loadhsl(string x)
        {

            HS.GetHSL(x);
        }
        public void Loadkl()
        {
            HS.GetKL();
        }
        public void getMon()
        {
            HS.getMon();
        }
        public void loadBCM()
        {
            HS.getBCM();
        }
        public bool Insert(HocSinhDTO hs)
        {
            
            return HS.Insert(hs);
        }
        public bool InsertKL(ClassDTO KL)
        {

            return HS.InsertKL(KL);
           
        }
        public bool InsertL(clasDTO KL)
        {

            return HS.InsertL(KL);

        }
        public bool GetMaHS(string hs)
        {
            return HS.GetMaHS(hs);
        }
        public bool InsertCT(ChiTietClass ct)
        {

            return HS.InsertHStoClass(ct);

        }
        public bool UpdateHS(HocSinhDTO hs,int id)
        {

            return HS.UpdateHS(hs,id);
        }
        public bool DeleteHS(int id)
        {
            return HS.DeleteHS(id);
        }
        public bool Checkhk()
        {
            return HS.checkHK();
        }
        public bool AddHK(HocKi hk)
        {
            return HS.AddHK(hk);
        }
        public bool AddMH(CTMonHoc ct)
        {
            return HS.AddMH(ct);
        }
        public bool AddMHtoHK(CTMonHoc ct)
        {
            return HS.AddMHtoHK(ct);
        }
        public bool AddMHtoClass(string ml,string mm,int mhk)
        {
            return HS.AddMHtoClass(ml, mm, mhk);
        }
        public bool AddMHtoHS(int hs, int hk, string mh)
        {
            return HS.AddMHhs(hs, hk, mh);
        }
        public void getdsbd()
        {
            HS.dsBD();
        }

        public bool CapNhatDiem(int a,string b,float c,float d,float e)
        {
            return HS.UpDateDiem(a,b,c,d,e);
        }
        public void getBCMonHoc(string mamon,int mahk)
        {
            HS.GetBCMonHoc(mamon,mahk);
        }
        public void getBCHocKi(string mal, int mahk)
        {
            HS.GetBCHK(mal, mahk);
        }
        public void getBCHocKi2(int mahk)
        {
            HS.GetBCHK2( mahk);
        }
        public void Login(string username,string passs)
        {
            HS.Login(username, passs);
        }
        public void listAC()
        {
            HS.listaccount();
        }
    }

}
