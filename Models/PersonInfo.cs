﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PersonInfo : EntityBase
    {
        public string Name { get; set; } 
        public string Surname{ get; set; } 
        public string FatherName { get; set; }
        public string Description { get; set; }
    }
}
