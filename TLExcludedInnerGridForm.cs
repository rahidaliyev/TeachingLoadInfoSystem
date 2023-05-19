using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class TLExcludedInnerGridForm : DevExpress.XtraEditors.XtraForm
    {
        TLDbContext db = new TLDbContext();
        TLExcluded excluded = new TLExcluded();
        ITeachingLoadServices _teachingLoadServices;
        string argument;
        public void RefreshGrid()
        {
            var teachingLoads = _teachingLoadServices.GetAllTeachingLoads().ToList();
                foreach (var item in teachingLoads)
                {
                    gridControl.DataSource = item.TeachingLoadSubjects;
                }
        }
        public void PreviewData()
        {
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
                    var selectedCode = gridView.GetFocusedRowCellValue("TLExcludedCode");

                    _teachingLoadServices.DeleteTeachingLoad(selectedRow);
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
        public TLExcludedInnerGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _teachingLoadServices = new TeachingLoadServices(new Repository<TeachingLoad>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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