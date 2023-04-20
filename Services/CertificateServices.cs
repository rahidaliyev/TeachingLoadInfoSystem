using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1.Services
{
    public class CertificateServices : ICertificateServices
    {
        private IRepository<Certificate> _repository;
        public CertificateServices(IRepository<Certificate> repository)
        {
            _repository = repository;
        }
        public Certificate GetCertificateByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertCertificate(Certificate certificate)
        {
            _repository.Insert(certificate);
        }
        public void UpdateCertificate(Certificate certificate)
        {
            _repository.Update(certificate);
        }
        public void DeleteCertificate(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<Certificate> GetAllCertificates()
        {
            return _repository.GetAll;
        }
    }
}
