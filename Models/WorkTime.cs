using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadInfoSystem.Models
{
    public class WorkTime : EntityBase
    {
        public string? WorkTimeCode { get; set; }
        public string? WorkTimeName { get; set; }
        //tam stat yarim stat 0.25 stat cedveli
    }
}
