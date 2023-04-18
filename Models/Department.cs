using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Department : EntityBase
    {
        public string? DepartmentCode { get; set; }
        public string? DepartmentName{ get; set; } 
    }
}
