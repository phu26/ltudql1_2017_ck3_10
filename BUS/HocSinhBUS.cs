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
        public void Load()
        {
            HS.Get();
        }
        public bool Insert(HocSinhDTO hs)
        {
            
            return HS.Insert(hs);
        }
    }
}