using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;
using TeachingLoadInfoSystem.Repositories;

namespace TeachingLoadInfoSystem.Services
{
    public class BookServices : IBookServices
    {
        private IRepository<Book> _repository;

        public BookServices(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public Book GetBookByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertBook(Book Book)
        {
            _repository.Insert(Book);
        }
        public void UpdateBook(Book Book)
        {
            _repository.Update(Book);
        }
        public void DeleteBook(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.GetAll;
        }
    }
}
