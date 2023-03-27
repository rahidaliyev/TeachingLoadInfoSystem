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
        PersonInfo personInfo = new PersonInfo();
        TLDbContext db = new TLDbContext(); 
        IPersonInfoServices _personServices;
        public void RefreshGrid()
        {
            gridControl1.DataSource = _personServices.GetAllPersons().ToList();
        }
        public PersonGridForm()
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _personServices = new PersonInfoServices(new Repository<PersonInfo>(db));
            RefreshGrid();
        }

        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonCRUDForm frm = new PersonCRUDForm(personInfo,db, _personServices);
            frm.ShowDialog();
            RefreshGrid();
        }

        private void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }
    }
}