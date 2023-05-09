using TeachingLoadInfoSystem.AppDbContext;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Services;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem
{
    public partial class UserControlCertificate : UserControl
    {
        public Certificate certificate { get; set; } = new Certificate();
        public List<Certificate> CertificateList { get; set; } = new List<Certificate>();
        ICertificateServices _certificateServices;
        ISubjectServices _subjectServices;
        TLDbContext db = new TLDbContext();
        public UserControlCertificate(TLDbContext db)
        {
            InitializeComponent();
            this.db = db;
            _certificateServices = new CertificateServices(new Repository<Certificate>(db));
            _subjectServices = new SubjectServices(new Repository<Subject>(db));    
            layoutControl1.AutoScroll = false;
            subjectCmb.Properties.DataSource  = _subjectServices.GetAllSubjects().ToList();
        }
        public UserControlCertificate(TLDbContext db, Certificate certificates)
        {
            this.db = db;
            certificate = certificates;
            InitializeComponent();
            _certificateServices = new CertificateServices(new Repository<Certificate>(db));
            _subjectServices = new SubjectServices(new Repository<Subject>(db));
            subjectCmb.Properties.DataSource = _subjectServices.GetAllSubjects().ToList();
            layoutControl1.AutoScroll = false;
            LoadCertificates();
        }
        public void LoadCertificates()
        {
            if (certificate != null) 
            {
                certificateNameTxt.Text = certificate.CertificateName;
                subjectCmb.EditValue= certificate.Subject;
                isLocalCheck.Checked = certificate.IsLocal;
                countryTxt.Text = certificate.ReceivedCountry;
            }
        }
        private void bookNameTxt_EditValueChanged(object sender, EventArgs e)
        {
            certificate.CertificateName = certificateNameTxt.Text;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            if (certificate.ID != 0)
            {
                _certificateServices.DeleteCertificate(certificate.ID);
                CertificateList.Remove(certificate);
            }
            else if (certificate != null)
            {
                CertificateList.Remove(certificate);
            }
        }
        private void countryTxt_EditValueChanged(object sender, EventArgs e)
        {
            certificate.ReceivedCountry = countryTxt.Text;
        }
        private void subjectCmb_EditValueChanged(object sender, EventArgs e)
        {
            if (certificate.Subject == null)
                certificate.Subject = subjectCmb.GetSelectedDataRow() as Subject;
        }
        private void isLocalCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (isLocalCheck.Checked)
            {
                certificate.ReceivedCountry = "Azərbaycan";
                countryTxt.Enabled = false;
            }
            else
                certificate.ReceivedCountry = countryTxt.Text;
                countryTxt.Enabled = true;
        }
    }
}
