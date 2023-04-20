using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services.Intefaces
{
    public interface ICertificateServices
    {
        Certificate GetCertificateByID(int id);
        void InsertCertificate(Certificate certificate);
        void UpdateCertificate(Certificate certificate);
        void DeleteCertificate(int id);
        IEnumerable<Certificate> GetAllCertificates();
    }
}
