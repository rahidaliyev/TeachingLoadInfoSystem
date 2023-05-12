using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class SubjectGridForm : DevExpress.XtraEditors.XtraForm
    {
        TLDbContext db = new TLDbContext(); 
        Subject subject = new Subject();
        ISubjectServices _subjectServices;
        public void RefreshGrid()
        {
            gridControl.DataSource = _subjectServices.GetAllSubjects().ToList();
        }
        public void PreviewData()
        {
            var index = gridView.FocusedRowHandle;
            if (index > -1)
            {
                var selectedRow = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                subject = _subjectServices.GetSubjectByID(selectedRow);
                var SkillForm = new SubjectCRUDForm(subject,db,_subjectServices);
                SkillForm.ShowDialog();
                subject = new Subject();
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
                    var selectedCode = gridView.GetFocusedRowCellValue("SubjectCode");

                    _subjectServices.DeleteSubject(selectedRow);
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
        public SubjectGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _subjectServices = new SubjectServices(new Repository<Subject>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SubjectCRUDForm frm = new SubjectCRUDForm(subject,db, _subjectServices);
            frm.ShowDialog();
            RefreshGrid();
            subject = new Subject();
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