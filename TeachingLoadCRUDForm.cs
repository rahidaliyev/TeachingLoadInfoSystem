using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class TeachingLoadCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        public List<EducationPlanPerGroup> educationPlanPerGroupView = new List<EducationPlanPerGroup>();
        public static List<int> EducationPlanIDs = new List<int>();
        TeachingLoad teachingload = new TeachingLoad();
        TLDbContext db = new TLDbContext();
        EducationPlanPerGroup EducationPlanPerGroup = new EducationPlanPerGroup();
        ITeachingLoadServices _teachingLoadServices { get; set; }
        ITeacherInfoServices _teacherInfoServices { get; set; }
        ITeachingLoadSubjectServices _teachingLoadSubjectServices { get; set; }
        IEducationPlanServices _educationPlanServices { get; set; }
        IPreferedSubjectServices _preferedSubjects { get; set; }
        ITeacherLanguageServices _teacherLanguageServices { get; set; }
        ICertificateServices _certificateServices { get; set; }
        IGroupServices _groupServices { get; set; }
        IEducationPlanPerGroupServices _educationPlanPerGroupServices { get; set; }
        ITeachingLoadSubjectServices _teachingLoadSubjects { get; set; }
        ISubjectServices _subjectServices { get; set; }

        private TeacherInfo _teacherInfo { get; set; } = new TeacherInfo();
        private Subject _subject { get; set; } = new Subject();
        private TeacherLanguage _teacherLanguage { get; set; } = new TeacherLanguage();
        private TeachingLoadSubject _teachingLoadSubject { get; set; } = new TeachingLoadSubject();
        public void RefreshGrid()
        {
            var list = SelectRows();
            gridControl1.DataSource = list;
            if (list.Count != 0)
                gridView1.SelectRows(0, list.Count - 1);
        }
        public TeachingLoadCRUDForm()
        {
            InitializeComponent();
            _teachingLoadServices = new TeachingLoadServices(new Repository<TeachingLoad>(db));
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            _teachingLoadSubjectServices = new TeachingLoadSubjectServices(new Repository<TeachingLoadSubject>(db));
            _educationPlanServices = new EducationPlanServices(new Repository<EducationPlan>(db));
            _preferedSubjects = new PreferedSubjectServices(new Repository<PreferedSubject>(db));
            _teacherLanguageServices = new TeacherLanguageServices(new Repository<TeacherLanguage>(db));
            _certificateServices = new CertificateServices(new Repository<Certificate>(db));
            _educationPlanPerGroupServices = new EducationPlanPerGroupServices(new Repository<EducationPlanPerGroup>(db));
            _groupServices = new GroupServices(new Repository<Group>(db));
            _teachingLoadSubjects = new TeachingLoadSubjectServices(new Repository<TeachingLoadSubject>(db));
            _subjectServices = new SubjectServices(new Repository<Subject>(db));
            this.teachingload = teachingload;
            teacherCmb.Properties.DataSource = _teacherInfoServices.GetAllTeacherInfos().OrderByDescending(x=>x.Rating).ToList();
            subjectCmb.Properties.DataSource = _subjectServices.GetAllSubjects().ToList();
            teachingLoadYearCmb.SelectedIndex = 0;
            LoadData();
        }

        public bool InsertData()
        {
            teachingload.TeacherInfoID = _teacherInfo.ID;
            teachingload.TeacherFullName = _teacherInfo.TeacherFullName;
            teachingload.SemesterTime = teachingLoadYearCmb.Text;
            var list = SelectRows();
            if (_teacherInfo == null)
                return false;
            if (_teacherInfo.WorkTime == null)
                return false;
            if (list.Sum(x => x.TotalHours) < _teacherInfo.WorkTime.WorkTimeFactor * 650)
            {
                MessageBox.Show($"Seçilmiş müəllimin {_teacherInfo.WorkTime.WorkTimeFactor * 650} saatdan az dərs yükü ola bilməz!");
                return false;
            }
            for (int i = 0; i < list.Count; i++)
            {
                var item = new TeachingLoadSubject();
                item.ID = 0;
                item.SpecialityCode = list[i].SpecialityCode;
                item.Subjects = list[i].Subject;
                item.SubjectID = list[i].SubjectID;
                item.CreditCount = list[i].CreditCount;
                item.TotalHours = list[i].TotalHours;
                item.OutsideAuditoriumHours = list[i].OutsideAuditoriumHours;
                item.AuditoriumHours = list[i].AuditoriumHours;
                item.LectureHours = list[i].LectureHours;
                item.SeminarHours = list[i].SeminarHours;
                item.LaboratoryHours = list[i].LaboratoryHours;
                item.Semestr = list[i].Semestr;
                item.WeeklyCourseLoad = list[i].WeeklyCourseLoad;
                item.GroupName = list[i].GroupName;
                item.GroupCourse = list[i].GroupCourse;
                item.LanguageID = list[i].LanguageID;
                item.EducationPlanPerGroupID = list[i].ID;
                teachingload.TeachingLoadSubjects.Add(item);
            }
            return true;
        }
        public void LoadData()
        {
            RefreshGrid();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var answer = InsertData();
            if (answer == false)
                return;
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
                    MessageBox.Show($"{_teacherInfo.TeacherFullName}-in {_teacherInfo.WorkTime.WorkTimeName} əlavə edildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            RefreshGrid();
        }
        private void lastYearLoadBtn_Click(object sender, EventArgs e)
        {
            var listLanguage = _teacherLanguageServices.GetAllTeacherLanguages().Where(x => x.TeacherInfoID == _teacherInfo.ID).OrderByDescending(x => x.PreferenceLevel).ToList();
            var listOfSubjects = _teachingLoadSubjects.GetAllTeachingLoadSubjects().ToList(); //.Where(x => x.Subjects.DepartmentID == 1) kommentden cixar after model changed
            var frm = new EducationPlanGridPerTeacher(listOfSubjects);
            frm.Show();
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
                ratingTxt.Text = _teacherInfo.Rating.ToString();
                var listCertificates = _certificateServices.GetAllCertificates().Where(x => x.TeacherInfoID == _teacherInfo.ID).ToList();
                List<string> certificates = new List<string>();
                for (int i = 0; i < listCertificates.Count; i++)
                {
                    certificates.Add(listCertificates[i].CertificateName);
                }
                string joinedCertificates = string.Join(", ", certificates);
                certificateBox.Text = joinedCertificates;
                languageCmb.Properties.DataSource = _teacherLanguageServices.GetAllTeacherLanguages().Where(x => x.TeacherInfoID == _teacherInfo.ID).ToList();
                if (_teacherInfo.ProfessionID == 1)
                    certificateBox.Enabled = false;
                else
                    certificateBox.Enabled = true;
            }
            gridControl1.DataSource = new List<EducationPlanPerGroup>();
            subjectCmb.EditValue = null;
        }

        private void languageCmb_EditValueChanged(object sender, EventArgs e)
        {
            GetEducationPlans();
        }

        private void subjectCmb_EditValueChanged(object sender, EventArgs e)
        {
            GetEducationPlans();
        }

        private void GetEducationPlans()
        {
            var teachingloadSubjects = _teachingLoadSubjectServices.GetAllTeachingLoadSubjects().ToList();
            var previouslySelected = SelectRows();
            _subject = subjectCmb.GetSelectedDataRow() as Subject;
            if (_subject == null)
                subjectCmb.EditValue = _subjectServices.GetSubjectByID(EducationPlanPerGroup.SubjectID);
            _teacherLanguage = languageCmb.GetSelectedDataRow() as TeacherLanguage;
            var list = new List<EducationPlanPerGroup>();
            foreach (var selected in previouslySelected)
                list.Add(selected);
            if (_subject != null && _teacherLanguage != null)
                list.AddRange(_educationPlanPerGroupServices.GetAllEducationPlanPerGroups()
                    .Where(x => x.Subject.ID == _subject.ID && x.LanguageID == _teacherLanguage.LanguageID)
                    .Where(item => !teachingloadSubjects.Select(subject => subject.EducationPlanPerGroupID)
                    .Contains(item.ID)).ToList());
            gridControl1.DataSource = list;
            if (previouslySelected.Count != 0)
                gridView1.SelectRows(0, previouslySelected.Count - 1);
        }
        private List<EducationPlanPerGroup> SelectRows()
        {
            var arr = gridView1.GetSelectedRows();
            var selected = new List<EducationPlanPerGroup>();
            for (int i = 0; i < arr.Length; i++)
            {
                var educationPlanPerGroupID = Convert.ToInt32(gridView1.GetRowCellValue(arr[i], "ID"));
                var educationPlanPerGroup = _educationPlanPerGroupServices.GetEducationPlanPerGroupByID(educationPlanPerGroupID);
                selected.Add(educationPlanPerGroup);
            }
            return selected;
        }
    }
}