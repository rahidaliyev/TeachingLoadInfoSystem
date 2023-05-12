using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem;

namespace TeachingLoadInfoSystem
{
    public partial class ScientificNameGridForm : DevExpress.XtraEditors.XtraForm
    {
        TLDbContext db = new TLDbContext(); 
        ScientificName scientificName = new ScientificName();
        IScientificNameServices _scientificNameServices;
        public void RefreshGrid()
        {
            gridControl.DataSource = _scientificNameServices.GetAllScientificNames().ToList();
        }
        public void PreviewData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                scientificName = _scientificNameServices.GetScientificNameByID(selectedRow);
                var SkillForm = new ScientificNameCRUDForm(scientificName,db,_scientificNameServices);
                SkillForm.ShowDialog();
                scientificName = new ScientificName();
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
                    var selectedCode = gridView.GetFocusedRowCellValue("ScientificNameCode");

                    _scientificNameServices.DeleteScientificName(selectedRow);
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
        public ScientificNameGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _scientificNameServices = new ScientificNameServices(new Repository<ScientificName>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ScientificNameCRUDForm frm = new ScientificNameCRUDForm(scientificName,db, _scientificNameServices);
            frm.ShowDialog();
            RefreshGrid();
            scientificName = new ScientificName();
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