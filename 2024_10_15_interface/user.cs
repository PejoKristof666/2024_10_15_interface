﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_15_interface
{
    public class user
    {
        public static List<user> allUser = new List<user>();
        public string username { get; set; }
        public string password { get; set; }
        public int point { get; set; }
        public int id { get; set; }
    }
}
