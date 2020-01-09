using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietClass
    {
        public static List<ChiTietClass> ctclas = new List<ChiTietClass>();
        private string MaCT;
        private string MaL;
        private int MaHS;
        private float TB1;
        private float TB2; 

        public ChiTietClass(string mact, string mal,int mahs, float tb1,float tb2)
        {
            MaCT = mact;
            MaL = mal;
            MaHS = mahs;
            TB1 = tb1;
            TB2 = tb2;
        }

        public string MaCT1 { get => MaCT; set => MaCT = value; }
        public string MaL1 { get => MaL; set => MaL = value; }
        public int MaHS1 { get => MaHS; set => MaHS = value; }
        public float TB11 { get => TB1; set => TB1 = value; }
        public float TB21 { get => TB2; set => TB2 = value; }
    }
}
