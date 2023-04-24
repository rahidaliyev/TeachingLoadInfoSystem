using TeachingLoadInfoSystem;
using WindowsFormsApp1.AppDbContext;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.Services.Intefaces;

namespace TeachingLoadInfoSystemDotNet6
{
    public partial class TeacherInfoGridForm : DevExpress.XtraEditors.XtraForm
    {
        TeacherInfo teacherinfo = new TeacherInfo();
        ITeacherInfoServices _teacherInfoServices;
        public void RefreshGrid()
        {
            gridControl.DataSource = _teacherInfoServices.GetAllTeacherInfos().ToList();
        }
        public void PreviewData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                teacherinfo = _teacherInfoServices.GetTeacherInfoByID(selectedRow);
                var SkillForm = new TeacherInfoCRUDForm(teacherinfo, _teacherInfoServices);
                SkillForm.ShowDialog();
                RefreshGrid();
                teacherinfo = new TeacherInfo();
            }
            else
            {
                MessageBox.Show("Hər hansı bir sətri seçin!");
            }
            RefreshGrid();
        }
        public void RemoveData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var message = MessageBox.Show("Məlumatı silməyə əminsiniz?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                    var selectedCode = gridView.GetFocusedRowCellValue("WorkTimeCode");

                    _teacherInfoServices.DeleteTeacherInfo(selectedRow);
                    Refresh();

                    MessageBox.Show(selectedCode + " kodlu məlumat uğurla silindi.");
                }
                else
                {
                    MessageBox.Show("Hər hansı bir sətri seçin.");
                }
                RefreshGrid();
            }
        }
        public TeacherInfoGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _teacherInfoServices = new TeacherInfoServices(new Repository<TeacherInfo>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TeacherInfoCRUDForm frm = new TeacherInfoCRUDForm(teacherinfo, _teacherInfoServices);
            frm.ShowDialog();
            RefreshGrid();
        }

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void previewBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreviewData();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            PreviewData();
        }

        private void DeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RemoveData();
        }
    }
}