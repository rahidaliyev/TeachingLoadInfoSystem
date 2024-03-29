﻿using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class TeacherInfoCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        TeacherInfo teacherinfo = new TeacherInfo();
        TLDbContext db = new TLDbContext();
        ITeacherInfoServices _teacherInfoServices { get; set; }
        IGenderServices _genderServices { get; set; }
        IScientificNameServices _scientificNameServices { get; set; }
        IScientificDegreeServices _degreeServices { get; set; }
        IDepartmentServices _departmentServices { get; set; }
        IWorkTimeServices _workTimeServices { get; set; }
        ILanguageServices _languageServices { get; set; }
        ITeacherLanguageServices _teacherLanguageServices { get; set; }
        IProfessionServices _professionServices { get; set; }
        private Gender _gender { get; set; } = new Gender();
        private ScientificName _scientificName { get; set; } = new ScientificName();
        private ScientificDegree _scientificDegree { get; set; } = new ScientificDegree();
        private Department _department { get; set; } = new Department();
        private WorkTime _workTime { get; set; } = new WorkTime();
        private Profession _profession { get; set; } = new Profession();
        public void LoadComboboxes()
        {
            genderCmb.Properties.DataSource = _genderServices.GetAllGenders().ToList();
            scientificNameCmb.Properties.DataSource = _scientificNameServices.GetAllScientificNames().ToList();
            degreeCmb.Properties.DataSource = _degreeServices.GetAllScientificDegrees().ToList();
            departmentCmb.Properties.DataSource = _departmentServices.GetAllDepartments().ToList();
            workTimeCmb.Properties.DataSource = _workTimeServices.GetAllWorkTimes().ToList();
            positionCmb.Properties.DataSource = _professionServices.GetAllProfessions().ToList();
        }
        public TeacherInfoCRUDForm(TeacherInfo teacherInfo, ITeacherInfoServices services)
        {
            InitializeComponent();
            this.teacherinfo = teacherInfo;
            this._teacherInfoServices = services;
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            _genderServices = new GenderServices(new Repository<Gender>(db));
            _scientificNameServices = new ScientificNameServices(new Repository<ScientificName>(db));
            _degreeServices = new ScientificDegreeServices(new Repository<ScientificDegree>(db));
            _departmentServices = new DepartmentServices(new Repository<Department>(db));
            _workTimeServices = new WorkTimeServices(new Repository<WorkTime>(db));
            _languageServices  = new LanguageServices(new Repository<Language>(db));
            _teacherLanguageServices = new TeacherLanguageServices(new Repository<TeacherLanguage>(db));
            _professionServices = new ProfessionServices(new Repository<Profession>(db));
            gridControlL.DataSource = _teacherLanguageServices.GetAllTeacherLanguages().Where(x => x.TeacherInfoID == teacherinfo.ID);
            LoadComboboxes();
            LoadData();
        }
        public void InsertData()
        {
            teacherinfo.TeacherCode = teacherCodeTxt.Text;
            teacherinfo.TeacherFullName = nameTxt.Text;
            teacherinfo.BirthDate = DateTime.ParseExact(birthDate.Text, "dd-MM-yyyy", null);
            teacherinfo.Email = mailTxt.Text;
            teacherinfo.PhoneNumber = numberTxt.Text;
            teacherinfo.Gender = _gender;
            teacherinfo.Department = _department;
            teacherinfo.ScientificDegree = _scientificDegree;
            teacherinfo.ScientificName = _scientificName;
            teacherinfo.WorkTime = _workTime;
            teacherinfo.Profession = _profession;
            teacherinfo.Books = GetBooks();
            teacherinfo.Certificates = GetCertificates();
            teacherinfo.PreviousJobs = GetPreviousJobs();
        }
        public void LoadData()
        {
            teacherCodeTxt.Text = teacherinfo.TeacherCode;
            nameTxt.Text = teacherinfo.TeacherFullName;
            birthDate.Text = teacherinfo.BirthDate.ToString("MM-dd-yyyy");
            mailTxt.Text = teacherinfo.Email;
            numberTxt.Text = teacherinfo.PhoneNumber;
            genderCmb.EditValue = teacherinfo.Gender;
            degreeCmb.EditValue = teacherinfo.ScientificDegree;
            scientificNameCmb.EditValue = teacherinfo.ScientificName;
            departmentCmb.EditValue = teacherinfo.Department;
            workTimeCmb.EditValue = teacherinfo.WorkTime;
            positionCmb.EditValue = teacherinfo.Profession;
            GetBooksToPanel(teacherinfo.Books);
            GetCertificatesToPanel(teacherinfo.Certificates);
            GetJobsToPanel(teacherinfo.PreviousJobs);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (teacherinfo.ID != 0)
            {
                try
                {
                    this._teacherInfoServices.UpdateTeacherInfo(teacherinfo);
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
                    this._teacherInfoServices.UpdateTeacherInfo(teacherinfo);

                    MessageBox.Show("Yeni məlumat əlavə edildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xanaları doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Book, Certificates and etc.
        private List<Book> GetBooks()
        {
            var books = new List<Book>();
            foreach (UserControlBook controll in bookPanelControl.Controls)
            {
                books.Add(controll.Books);
            }
            return books;
        }
        private List<Certificate> GetCertificates() 
        {
            var certificates = new List<Certificate>();
            foreach (UserControlCertificate control in certificatePanelControl.Controls)
            {
                certificates.Add(control.certificate);
            }
            return certificates;
        }
        private List<PreviousJob> GetPreviousJobs()
        {
            var jobs = new List<PreviousJob>();
            foreach (UserControlPreviousJob control in previousJobPanelControl.Controls)
            {
                jobs.Add(control.PreviousJobs);
            }
            return jobs;
        }
        private void GetJobsToPanel(List<PreviousJob> jobs)
        {
            foreach (var item in jobs)
            {
                var userControl = new UserControlPreviousJob(db, item)
                {
                    Dock = DockStyle.Top
                };
                previousJobPanelControl.AutoScroll = true;
                previousJobPanelControl.Controls.Add(userControl);
            }
        }
        private void GetBooksToPanel(List<Book> books)
        {
            foreach (var item in books)
            {
                var userControl = new UserControlBook(db, item)
                {
                    Dock = DockStyle.Top
                };
                bookPanelControl.AutoScroll = true;
                bookPanelControl.Controls.Add(userControl);
            }
        }
        private void GetCertificatesToPanel(List<Certificate> certificates) 
        {
            foreach (var item in certificates)
            {
                var userControl = new UserControlCertificate(db, item)
                {
                    Dock = DockStyle.Top
                };
                certificatePanelControl.AutoScroll = true;
                certificatePanelControl.Controls.Add(userControl);
            }
        }
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var userControl = new UserControlBook(db)
            {
                Dock = DockStyle.Fill,
            };
            //bookPanelControl.AutoScroll = true;
            bookPanelControl.Controls.Add(userControl);
        }
        private void addCertificateBtn_Click(object sender, EventArgs e)
        {
            var userControl = new UserControlCertificate(db)
            {
                Dock = DockStyle.Fill,
            };
            certificatePanelControl.Controls.Add(userControl);
        }

        private void addPreviousJobBtn_Click(object sender, EventArgs e)
        {
            var userControl = new UserControlPreviousJob(db)
            {
                Dock = DockStyle.Fill,
            };
            previousJobPanelControl.Controls.Add(userControl);
        }
        #endregion
        private void scientificNameCmb_EditValueChanged(object sender, EventArgs e)
        {
            _scientificName = scientificNameCmb.GetSelectedDataRow() as ScientificName;
            if (_scientificName == null)
                scientificNameCmb.EditValue = _scientificNameServices.GetScientificNameByID(teacherinfo.ScientificNameID);
        }

        private void departmentCmb_EditValueChanged(object sender, EventArgs e)
        {
            _department = departmentCmb.GetSelectedDataRow() as Department;
            if (_department == null)
                departmentCmb.EditValue = _departmentServices.GetDepartmentByID(teacherinfo.DepartmentID);
        }

        private void degreeCmb_EditValueChanged(object sender, EventArgs e)
        {
            _scientificDegree = degreeCmb.GetSelectedDataRow() as ScientificDegree;
            if (_scientificDegree == null)
                degreeCmb.EditValue = _degreeServices.GetScientificDegreeByID(teacherinfo.ScientificDegreeID);
        }

        private void workTimeCmb_EditValueChanged(object sender, EventArgs e)
        {
            _workTime = workTimeCmb.GetSelectedDataRow() as WorkTime;
            if (_workTime == null)
                workTimeCmb.EditValue = _workTimeServices.GetWorkTimeByID(teacherinfo.WorkTimeID);
        }

        private void genderCmb_EditValueChanged(object sender, EventArgs e)
        {
            _gender = genderCmb.GetSelectedDataRow() as Gender;
            if (_gender == null)
                genderCmb.EditValue = _genderServices.GetGenderByID(teacherinfo.GenderID);
        }

        private void positionCmb_EditValueChanged(object sender, EventArgs e)
        {
            _profession  = positionCmb.GetSelectedDataRow() as Profession;
            if (_profession == null)
                positionCmb.EditValue = _professionServices.GetProfessionByID(teacherinfo.ProfessionID);
        }
    }
}