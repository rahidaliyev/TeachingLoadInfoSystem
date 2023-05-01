using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadInfoSystem.Models
{
    public class ScientificName : EntityBase
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
}
