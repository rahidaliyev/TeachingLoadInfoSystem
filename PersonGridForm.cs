using WindowsFormsApp1;
using WindowsFormsApp1.AppDbContext;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.Services.Intefaces;

namespace TeachingLoadInfoSystemDotNet6
{
    public partial class PersonGridForm : DevExpress.XtraEditors.XtraForm
    {
        TeacherInfo TeacherInfo = new TeacherInfo();
        TLDbContext db = new TLDbContext(); 
        ITeacherInfoServices _teacherInfoServices;
        public void RefreshGrid()
        {
            gridControl1.DataSource = _teacherInfoServices.GetAllTeacherInfos().ToList();
        }
        public PersonGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonCRUDForm frm = new PersonCRUDForm(TeacherInfo,db, _teacherInfoServices);
            frm.ShowDialog();
            RefreshGrid();
        }

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }
    }
}