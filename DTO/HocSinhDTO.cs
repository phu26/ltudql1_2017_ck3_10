﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinhDTO
    {
        #region Atrributes
        public static int toithieu;
        public static int toida;
        private String _name;
        private bool _gioitinh;
        
        private DateTime _ngsinh;
        private String _diachi;
        private String _email;
  
        #endregion
        #region Default Constructor
        public HocSinhDTO( string name, string mail,string dc,bool gt ,DateTime date)
        {
            
            _name = name;
            _email = mail;
            _gioitinh = gt;
            _diachi =dc ;
            _ngsinh = date;
            
        }

        
        public string Name { get => _name; set => _name = value; }
        
     
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Ngsinh { get => _ngsinh; set => _ngsinh = value; }
        public bool Gioitinh { get => _gioitinh; set => _gioitinh = value; }
        #endregion
        #region Properties

        #endregion
    }
}
