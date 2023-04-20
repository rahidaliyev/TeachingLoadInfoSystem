using System;
using System.Windows.Forms;
using WindowsFormsApp1.AppDbContext;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1
{
    public partial class PersonCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        TeacherInfo TeacherInfo = new TeacherInfo();
        ITeacherInfoServices _teacherInfoServices { get; set; }
        public PersonCRUDForm(TeacherInfo TeacherInfo,TLDbContext context,ITeacherInfoServices services)
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            this.TeacherInfo = TeacherInfo;
            db = context;
            this._teacherInfoServices= services;
        }
        public void InsertData()
        {
            //TeacherInfo.Name = NameTxt.Text;
            //TeacherInfo.Surname = SurnameTxt.Text;
            //TeacherInfo.FatherName = FatherTxt.Text;
            //TeacherInfo.Description = DescriptionTxt.Text;
        }
        public void LoadData()
        {
            //NameTxt.Text = TeacherInfo.Name;
            //SurnameTxt.Text = TeacherInfo.Surname;
            //FatherTxt.Text = TeacherInfo.FatherName;
            //DescriptionTxt.Text = TeacherInfo.Description;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (TeacherInfo.ID != 0)
            {
                try
                {
                    this._teacherInfoServices.UpdateTeacherInfo(TeacherInfo);
                    MessageBox.Show("Data updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fill in the boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    this._teacherInfoServices.InsertTeacherInfo(TeacherInfo);

                    MessageBox.Show("New data inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fill in the boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
