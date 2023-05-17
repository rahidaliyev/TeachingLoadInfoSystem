using System;
using System.Windows.Forms;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class TeachingLoadCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        TeachingLoad teachingload = new TeachingLoad();
        TeachingLoadSubject teachingLoadSubject= new TeachingLoadSubject();    
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
            for (int i = 0; i < int.Parse(_teacherInfo.WorkTime.WorkTimeName) * 550; i++)
            {
                gridControl1.DataSource = teachingLoadSubject;
                teachingload.TeachingLoadSubjects.Add(teachingLoadSubject);
            }
        }
        public void InsertData()
        {
            teachingload.TeacherInfoID = _teacherInfo.ID;
            teachingload.TeacherName = _teacherInfo.TeacherName;
            teachingload.TeacherSurname = _teacherInfo.TeacherSurname;
            teachingload.SemesterTime = DateTime.ParseExact(dateTxt.Text, "dd-MM-yyyy", null);
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

        }

        private void teacherCmb_EditValueChanged(object sender, EventArgs e)
        {
            _teacherInfo = teacherCmb.GetSelectedDataRow() as TeacherInfo;

            if (_teacherInfo != null)
            {
                teacherNameTxt.Text = _teacherInfo.TeacherName + " " + _teacherInfo.TeacherSurname + " " + _teacherInfo.TeacherFather;
            }
          
        }

        private void teacherCmb_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            teacherCmb.Properties.View.Columns[4].Visible = false;
            teacherCmb.Properties.View.Columns[5].Visible = false;
            teacherCmb.Properties.View.Columns[6].Visible = false;
            teacherCmb.Properties.View.Columns[7].Visible = false;
            teacherCmb.Properties.View.Columns[8].Visible = false;
            teacherCmb.Properties.View.Columns[9].Visible = false;
            teacherCmb.Properties.View.Columns[10].Visible = false;
            teacherCmb.Properties.View.Columns[11].Visible = false;
            teacherCmb.Properties.View.Columns[12].Visible = false;
            teacherCmb.Properties.View.Columns[13].Visible = false;
            teacherCmb.Properties.View.Columns[14].Visible = false;
            teacherCmb.Properties.View.Columns[15].Visible = false;
            teacherCmb.Properties.View.Columns[16].Visible = false;
            teacherCmb.Properties.View.Columns[17].Visible = false;

            teacherCmb.Properties.View.Columns[1].Caption = "Müəllimlər haqqında";
            //teacherCmb.Properties.View.Columns[2].Visible = false;
            teacherCmb.Properties.PopupFormSize = new Size(500, 250);
        }
    }
}
