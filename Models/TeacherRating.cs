using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadInfoSystem.Models
{
    public class TeacherRating:EntityBase
    {
        public int TeacherInfoID { get; set; }
        public string TeacherFullName { get;set; } 
        public double Rating { get; set; }  
        
    }
}
