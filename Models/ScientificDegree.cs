﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ScientificDegree : EntityBase
    {
        public string DegreeCode { get; set; } 
        public string DegreeName{ get; set; } 
    }
}
