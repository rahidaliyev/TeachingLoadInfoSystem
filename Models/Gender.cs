using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Gender : EntityBase
    {
        public string GenderCode { get; set; }
        public string GenderName{ get; set; } 
    }
}
