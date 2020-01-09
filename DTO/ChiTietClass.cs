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

    
    }
}
