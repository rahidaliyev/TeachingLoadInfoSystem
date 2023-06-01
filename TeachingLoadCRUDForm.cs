using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeachingLoadInfoSystem
{
    public partial class TeachingLoadCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        TeachingLoad teachingload = new TeachingLoad();
        TeachingLoadSubject teachingLoadSubject = new TeachingLoadSubject();
        TLDbContext db = new TLDbContext();
        ITeachingLoadServices _teachingLoadServices { get; set; }
        ITeacherInfoServices _teacherInfoServices { get; set; }
        ITeachingLoadSubjectServices _teachingLoadSubjectServices { get; set; }
        IEducationPlanServices _educationPlanServices { get; set; }
        IPreferedSubjectServices _preferedSubjects { get; set; }
        ITeacherLanguageServices _teacherLanguage { get; set; }
        ICertificateServices _certificateServices { get; set; }
        private TeacherInfo _teacherInfo { get; set; } = new TeacherInfo();
        public TeachingLoadCRUDForm()
        {
            InitializeComponent();
            _teachingLoadServices = new TeachingLoadServices(new Repository<TeachingLoad>(db));
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            _teachingLoadSubjectServices = new TeachingLoadSubjectServices(new Repository<TeachingLoadSubject>(db));
            _educationPlanServices = new EducationPlanServices(new Repository<EducationPlan>(db));
            _preferedSubjects = new PreferedSubjectServices(new Repository<PreferedSubject>(db));
            _teacherLanguage = new TeacherLanguageServices(new Repository<TeacherLanguage>(db));
            _certificateServices = new CertificateServices(new Repository<Certificate>(db));
            this.teachingload = teachingload;
            teacherCmb.Properties.DataSource = _teacherInfoServices.GetAllTeacherInfos().ToList();
            LoadData();
        }
        public void AddSubjects()
        {
            var subjects = _preferedSubjects.GetAllPreferedSubjects().ToList();
            var educationPlans = _educationPlanServices.GetAllEducationPlans().ToList();
            for (int i = 0; i < _teacherInfo.WorkTime.WorkTimeFactor * 550; i++)
            {
                var list = educationPlans.Join(subjects, e => e.SubjectID, p => p.SubjectID, (e, p) => new EducationPlan
                {
                    SubjectID = p.SubjectID,
                    SeminarHours = e.SeminarHours,
                    CreditCount = e.CreditCount,
                    TotalHours = e.TotalHours,
                    OutsideAuditoriumHours = e.OutsideAuditoriumHours,
                    AuditoriumHours = e.AuditoriumHours,
                    LectureHours = e.LectureHours,
                    LaboratoryHours = e.LaboratoryHours,
                    Semestr = e.Semestr,
                    WeeklyCourseLoad = e.WeeklyCourseLoad,
                    SpecialityCode = e.SpecialityCode,
                    Subjects = e.Subjects,
                }).ToList();
                gridControl1.DataSource = list;
                //teachingload.TeachingLoadSubjects.Add(teachingLoadSubject);
            }
        }
        public void InsertData()
        {
            teachingload.TeacherInfoID = _teacherInfo.ID;
            //teachingload.TeacherName = _teacherInfo.TeacherName;
            //teachingload.TeacherSurname = _teacherInfo.TeacherSurname;
            //teachingload.SemesterTime = dateTxt.Text;
        }
        public void LoadData()
        {
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (teachingload.ID != 0)
            {
                try
                {
                    this._teachingLoadServices.UpdateTeachingLoad(teachingload);
                    MessageBox.Show("Məlumat yeniləndi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xanaları doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    this._teachingLoadServices.InsertTeachingLoad(teachingload);

                    MessageBox.Show("Yeni məlumat əlavə edildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xanaları doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTeachingLoad_Click(object sender, EventArgs e)
        {
            AddSubjects();
        }
        private void lastYearLoadBtn_Click(object sender, EventArgs e)
        {
            var frm = new LastYearTeachinLoadGridForm();
            frm.ShowDialog();
        }
        private void teacherCmb_EditValueChanged_1(object sender, EventArgs e)
        {
            _teacherInfo = teacherCmb.GetSelectedDataRow() as TeacherInfo;
            if (_teacherInfo != null)
            {
                scientificDegreeTxt.Text = _teacherInfo.ScientificDegree.DegreeName;
                scientificName.Text = _teacherInfo.ScientificName.Name;
                workHourTxt.Text = _teacherInfo.WorkTime.WorkTimeName;
                positionTxt.Text = _teacherInfo.Profession.Name;
                var listLanguage = _teacherLanguage.GetAllTeacherLanguages().Where(x => x.TeacherInfoID == _teacherInfo.ID).ToList();
                List<string> languageNames = new List<string>();
                for (int i = 0; i < listLanguage.Count; i++)
                {
                    languageNames.Add(listLanguage[i].Language.LanguageName);
                }
                string joinedLanguages = string.Join(", ", languageNames);
                languageTxt.Text = joinedLanguages;

                var listCertificates = _certificateServices.GetAllCertificates().Where(x => x.TeacherInfoID == _teacherInfo.ID).ToList();
                List<string> certificates = new List<string>();
                for (int i = 0; i < listCertificates.Count; i++)
                {
                    certificates.Add(listCertificates[i].CertificateName);
                }
                string joinedCertificates = string.Join(", ", certificates);
                certificateBox.Text = joinedCertificates;
            }
        }
    }
}
