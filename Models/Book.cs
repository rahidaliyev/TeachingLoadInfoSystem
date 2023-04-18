using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Book : EntityBase
    {
        public int TeacherInfoID { get; set; }
        public string? BookName { get; set; }
        public bool IsTextBook { get; set; }
    }
}
