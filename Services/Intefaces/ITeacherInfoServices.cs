using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ITeacherInfoServices
    {
        TeacherInfo GetTeacherInfoByID(int id);
        void InsertTeacherInfo(TeacherInfo teacherInfo);
        void UpdateTeacherInfo(TeacherInfo teacherInfo);
        void DeleteTeacherInfo(int id);
        IEnumerable<TeacherInfo> GetAllTeacherInfos();
    }
}
