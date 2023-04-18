using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Certificate : EntityBase
    {
        public int TeacherInfoID { get; set; }
        public string? CertificateName { get; set; }
        public string? ReceivedCountry { get; set; }
        public bool IsLocal { get; set; }
    }
}
