using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadInfoSystem.Models
{
    public class Certificate : EntityBase
    {
        public Certificate()
        {
            Subject = new Subject();
        }
        public int TeacherInfoID { get; set; }
        public string? CertificateName { get; set; }
        public string? ReceivedCountry { get; set; }
        public virtual Subject Subject { get; set; }
        public int SubjectID { get; set; }
        public bool IsLocal { get; set; }
    }
}
