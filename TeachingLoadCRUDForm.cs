﻿using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class TeachingLoadCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        TeachingLoad teachingload = new TeachingLoad();
        TeachingLoadSubject teachingLoadSubject = new TeachingLoadSubject();
        TLDbContext db = new TLDbContext();
        ITeachingLoadServices _teachingLoadServices { get; set; }
        ITeacherInfoServices _teacherInfoServices { get; set; }
        private TeacherInfo _teacherInfo { get; set; } = new TeacherInfo();
        public TeachingLoadCRUDForm()
        {
            InitializeComponent();
            _teachingLoadServices = new TeachingLoadServices(new Repository<TeachingLoad>(db));
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            this.teachingload = teachingload;
            teacherCmb.Properties.DataSource = _teacherInfoServices.GetAllTeacherInfos().ToList();
            LoadData();
        }
        public void AddSubjects()
        {
            for (int i = 0; i < _teacherInfo.WorkTime.WorkTimeFactor * 550; i++)
            {
                int updateIndex = teachingload.TeachingLoadSubjects.IndexOf(teachingLoadSubject);
                if (updateIndex != -1)
                    teachingload.TeachingLoadSubjects[updateIndex] = teachingLoadSubject;
                else
                    teachingload.TeachingLoadSubjects.Add(teachingLoadSubject);
                teachingLoadSubject = new TeachingLoadSubject();
                //teachingload.TeachingLoadSubjects.Add(new TeachingLoadSubject()
                //{
                //    SubjectID = i,
                //    TeachingLoadID = 0,
                //    Thesis = 0,
                //    EPedTETedTTKITA = 0,
                //    Doctorate = 0,
                //});
                //gridControl1.DataSource = teachingLoadSubject;
            }
        }
        public void InsertData()
        {
            teachingload.TeacherInfoID = _teacherInfo.ID;
            teachingload.TeacherName = _teacherInfo.TeacherName;
            teachingload.TeacherSurname = _teacherInfo.TeacherSurname;
            teachingload.SemesterTime = DateTime.ParseExact(dateLbl.Text, "dd-MM-yyyy", null);
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

        private void teacherCmb_EditValueChanged(object sender, EventArgs e)
        {
            _teacherInfo = teacherCmb.GetSelectedDataRow() as TeacherInfo;
            if (_teacherInfo != null)
                teacherNameTxt.Text = _teacherInfo.TeacherName + " " + _teacherInfo.TeacherSurname + " " + _teacherInfo.TeacherFather;
        }

        private void teacherCmb_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            for (int i = 4; i <= 19; i++)
                teacherCmb.Properties.View.Columns[i].Visible = false;
            teacherCmb.Properties.View.Columns[1].Caption = "Müəllimlər haqqında";
            teacherCmb.Properties.PopupFormSize = new Size(500, 250);
        }
    }
}
