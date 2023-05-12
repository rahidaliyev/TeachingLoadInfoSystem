using System;
using System.Windows.Forms;
using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;

namespace TeachingLoadInfoSystem
{
    public partial class SubjectCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        Subject subject = new Subject();
        TLDbContext db = new TLDbContext();
        ISubjectServices _departmanetServices { get; set; }
        public SubjectCRUDForm(Subject subject,TLDbContext context,ISubjectServices services)
        {
            InitializeComponent();
            _departmanetServices = new SubjectServices(new Repository<Subject>(db));
            this.subject = subject;
            db = context;
            this._departmanetServices= services;
            LoadData();
        }
        public void InsertData()
        {
            subject.SubjectCode = subjectCodeTxt.Text;
            subject.SubjectName = subjectNameTxt.Text;
        }
        public void LoadData()
        {
            subjectCodeTxt.Text = subject.SubjectCode;
            subjectNameTxt.Text = subject.SubjectName;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertData();
            if (subject.ID != 0)
            {
                try
                {
                    this._departmanetServices.UpdateSubject(subject);
                    MessageBox.Show("Məlumat yeniləndi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xanaları doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    this._departmanetServices.InsertSubject(subject);

                    MessageBox.Show("Yeni məlumat əlavə edildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xanaları doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
