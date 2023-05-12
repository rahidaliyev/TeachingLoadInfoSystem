using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class ScientificDegreeGridForm : DevExpress.XtraEditors.XtraForm
    {
        ScientificDegree department = new ScientificDegree();
        IScientificDegreeServices _workTimeServices;
        public void RefreshGrid()
        {
            gridControl.DataSource = _workTimeServices.GetAllScientificDegrees().ToList();
        }
        public void PreviewData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                department = _workTimeServices.GetScientificDegreeByID(selectedRow);
                var SkillForm = new ScientificDegreeCRUDForm(department,_workTimeServices);
                SkillForm.ShowDialog();
                RefreshGrid();
                department = new ScientificDegree();
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
                    var selectedCode = gridView.GetFocusedRowCellValue("ScientificDegreeCode");

                    _workTimeServices.DeleteScientificDegree(selectedRow);
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
        public ScientificDegreeGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _workTimeServices = new ScientificDegreeServices(new Repository<ScientificDegree>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ScientificDegreeCRUDForm frm = new ScientificDegreeCRUDForm(department, _workTimeServices);
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