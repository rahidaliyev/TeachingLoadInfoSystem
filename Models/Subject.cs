﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Subject : EntityBase
    {
        public string? SubjectCode { get; set; }
        public string? SubjectName { get; set; }
        public int DepartmentID { get; set; }
    }
}
