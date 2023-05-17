using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem;

namespace TeachingLoadInfoSystem
{
    public partial class TLIncludedGridForm : DevExpress.XtraEditors.XtraForm
    {
        TLDbContext db = new TLDbContext(); 
        Department department = new Department();
        IDepartmentServices _departmentServices;
        public void RefreshGrid()
        {
            gridControl.DataSource = _departmentServices.GetAllDepartments().ToList();
        }
        public void PreviewData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                department = _departmentServices.GetDepartmentByID(selectedRow);
                var SkillForm = new DepartmentCRUDForm(department,db,_departmentServices);
                SkillForm.ShowDialog();
                department = new Department();
                RefreshGrid();
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
                    var selectedCode = gridView.GetFocusedRowCellValue("DepartmentCode");

                    _departmentServices.DeleteDepartment(selectedRow);
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
        public TLIncludedGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _departmentServices = new DepartmentServices(new Repository<Department>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DepartmentCRUDForm frm = new DepartmentCRUDForm(department,db, _departmentServices);
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