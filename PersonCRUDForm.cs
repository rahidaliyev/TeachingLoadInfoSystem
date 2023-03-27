using System;
using System.Windows.Forms;
using WindowsFormsApp1.AppDbContext;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1
{
    public partial class PersonCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        PersonInfo personInfo = new PersonInfo();
        IPersonInfoServices _personInfoServices { get; set; }
        public PersonCRUDForm(PersonInfo personInfo,TLDbContext context,IPersonInfoServices services)
        {
            InitializeComponent();
            TLDbContext db = new TLDbContext();
            _personInfoServices = new PersonInfoServices(new Repository<PersonInfo>(db));
            this.personInfo = personInfo;
            db = context;
            this._personInfoServices= services;
        }
        public void InsertData()
        {
            personInfo.Name = NameTxt.Text;
            personInfo.Surname = SurnameTxt.Text;
            personInfo.FatherName = FatherTxt.Text;
            personInfo.Description = DescriptionTxt.Text;
        }
        public void LoadData()
        {
            NameTxt.Text = personInfo.Name;
            SurnameTxt.Text = personInfo.Surname;
            FatherTxt.Text = personInfo.FatherName;
            DescriptionTxt.Text = personInfo.Description;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (personInfo.ID != 0)
            {
                try
                {
                    this._personInfoServices.UpdatePerson(personInfo);
                    MessageBox.Show("Data updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fill in the boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    this._personInfoServices.InsertPerson(personInfo);

                    MessageBox.Show("New data inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fill in the boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
