using TeachingLoadInfoSystem;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Controllers;
using DevExpress.Charts.Native;

namespace TeachingLoadInfoSystem
{
    public partial class TeacherInfoGridForm : DevExpress.XtraEditors.XtraForm
    {
        TeacherInfo teacherinfo = new TeacherInfo();
        Models.LayoutInfo layoutInfo = new Models.LayoutInfo();
        ITeacherInfoServices _teacherInfoServices;
        public void RefreshGrid()
        {
            gridControl.DataSource = _teacherInfoServices.GetAllTeacherInfos().ToList();
        }
        private void TeacherInfoGridForm_Load(object sender, EventArgs e)
        {
            gridControl.ForceInitialize();
            LayoutController.RestoreLayout(1, "TeacherGrid", "TeacherForm", gridControl, layoutInfo);
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
                    RefreshGrid();

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
            teacherinfo = new TeacherInfo();
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
        private void ExcelTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToExcel("TeacherInfo", gridControl);
        }

        private void WordBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToWord("TeacherInfo", gridControl);
        }

        private void PDFBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToPDF("TeacherInfo", gridControl);
        }

        private void HTMLBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportDocument.ToHTML("TeacherInfo", gridControl);
        }

        private void saveLayoutBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LayoutController.SaveLayout(1, "TeacherGrid", "TeacherForm", gridView, layoutInfo);
        }

        private void downloadTemplateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void importBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}