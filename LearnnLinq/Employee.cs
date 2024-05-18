﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnnLinq
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Techs> Programming { get; set; }
    }

    public class Techs
    {
        public string Technology { get; set; }
    }
}
