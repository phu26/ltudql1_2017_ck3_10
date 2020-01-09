using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ClassDTO
    {
        public static List<ClassDTO> khoilop = new List<ClassDTO>();

        public static bool TonTai;
        private string MaK;
        private string TenK;

        public ClassDTO(string x, string y)
        {
            MaK = x;
            TenK = y;
        }
        public string MaK1 { get => MaK; set => MaK = value; }
        public string TenK1 { get => TenK; set => TenK = value; }
    }
}
