using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class TLExcludedGridForm : DevExpress.XtraEditors.XtraForm
    {
        TLDbContext db = new TLDbContext();
        TLExcluded excluded = new TLExcluded();
        ITLExcludedServices _excludedServices;
        string argument;
        public void RefreshGrid()
        {
            gridControl.DataSource = _excludedServices.GetAllTLExcludeds().ToList();
        }
        public void PreviewData()
        {
            var frm = new TLExcludedInnerGridForm();
            frm.ShowDialog();

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

                    _excludedServices.DeleteTLExcluded(selectedRow);
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
        public TLExcludedGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _excludedServices = new TLExcludedServices(new Repository<TLExcluded>(db));
            RefreshGrid();
            repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            repositoryItemButtonEdit1.Appearance.BackColor = Color.Red;
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

        private void gridControl_Click(object sender, EventArgs e)
        {
            PreviewData();
        }
    }
}