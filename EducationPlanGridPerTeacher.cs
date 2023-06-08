using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace TeachingLoadInfoSystem
{
    public partial class EducationPlanGridPerTeacher : DevExpress.XtraEditors.XtraForm
    {
        TLDbContext db = new TLDbContext();
        List<EducationPlan> educationPlan;
        List<EducationPlanPerGroup> educationPlanPerGroupView;
        List<TeachingLoadSubject> teachingLoadSubjects;
        IEducationPlanPerGroupServices _educationPlanPerGroupServices { get; set; }
        ITeachingLoadSubjectServices _teachingLoadSubjects { get; set; } 
        public EducationPlanGridPerTeacher(List<EducationPlanPerGroup> list)
        {
            InitializeComponent();
            _educationPlanPerGroupServices = new EducationPlanPerGroupServices(new Repository<EducationPlanPerGroup>(db));
            this.educationPlanPerGroupView = list;
            gridControl1.DataSource = educationPlanPerGroupView;
        }
        public EducationPlanGridPerTeacher(List<TeachingLoadSubject> teachingLoadSubjects)
        {
            InitializeComponent();
            _teachingLoadSubjects = new TeachingLoadSubjectServices(new Repository<TeachingLoadSubject>(db));
            this.teachingLoadSubjects = teachingLoadSubjects;
            gridControl1.DataSource = teachingLoadSubjects;
        }

        private void selectBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();
            List<int> positiveRows = new List<int>();
            for (int i = 0; i < selectedRows.Length; i++)
            {
                if (selectedRows[i] >= 0)
                    positiveRows.Add(selectedRows[i]);
            }
            for (int i = 0; i < positiveRows.Count; i++)
                TeachingLoadCRUDForm.EducationPlanIDs.Add(Convert.ToInt32(gridView1.GetRowCellValue(positiveRows[i], "ID")));
            Close();
        }
    }
}
