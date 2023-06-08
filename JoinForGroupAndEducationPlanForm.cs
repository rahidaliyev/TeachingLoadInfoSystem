using System.Data;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class JoinForGroupAndEducationPlanForm : Form
    {
        public List<EducationPlanPerGroup> educationPlanPerGroupView = new List<EducationPlanPerGroup>();   
        TLDbContext db = new TLDbContext();
        IGroupServices _groupServices { get; set; }
        IEducationPlanPerGroupServices _educationPlanPerGroupServices { get; set; }
        IEducationPlanServices _educationPlanServices { get; set; } 
        public JoinForGroupAndEducationPlanForm()
        {
            InitializeComponent();
            _groupServices = new GroupServices(new Repository<Group>(db));
            _educationPlanPerGroupServices = new EducationPlanPerGroupServices(new Repository<EducationPlanPerGroup>(db));
            _educationPlanServices = new EducationPlanServices(new Repository<EducationPlan>(db));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listOfGroups = _groupServices.GetAllGroups().ToList();
            var listOfEducationPlans = _educationPlanServices.GetAllEducationPlans().ToList(); //.Where(x => x.Subjects.DepartmentID == 1) kommentden cixar after model changed

            var joinedList = listOfEducationPlans.Join(
                inner: listOfGroups,
                outerKeySelector: specialityCode => specialityCode.SpecialityCode,
                innerKeySelector: specialityCode2 => specialityCode2.SpecialityCode,
            resultSelector: (e, g) =>
                new { e.ID, e.SpecialityCode, e.SubjectID, e.CreditCount, e.TotalHours, e.OutsideAuditoriumHours, e.AuditoriumHours, e.LectureHours, e.SeminarHours, e.LaboratoryHours, e.Semestr, e.WeeklyCourseLoad, g.GroupName, g.GroupCourse, g.LanguageID })
                .OrderBy(cp => cp.SpecialityCode).ToList();

            foreach (var item in joinedList)
            {
                EducationPlanPerGroup educationPlanPerGroup = new EducationPlanPerGroup()
                {
                    ID = 0,
                    SpecialityCode = item.SpecialityCode,
                    SubjectID = item.SubjectID,
                    CreditCount = item.CreditCount,
                    TotalHours = item.TotalHours,
                    OutsideAuditoriumHours = item.OutsideAuditoriumHours,
                    AuditoriumHours = item.AuditoriumHours,
                    LectureHours = item.LectureHours,
                    SeminarHours = item.SeminarHours,
                    LaboratoryHours = item.LaboratoryHours,
                    Semestr = item.Semestr,
                    WeeklyCourseLoad = item.WeeklyCourseLoad,
                    GroupName = item.GroupName,
                    GroupCourse = item.GroupCourse,
                    LanguageID = item.LanguageID
                };
                educationPlanPerGroupView.Add(educationPlanPerGroup);
                if (educationPlanPerGroup.ID != 0)
                    _educationPlanPerGroupServices.UpdateEducationPlanPerGroup(educationPlanPerGroup);
                else
                    _educationPlanPerGroupServices.InsertEducationPlanPerGroup(educationPlanPerGroup);
            }
        }

    }
}
