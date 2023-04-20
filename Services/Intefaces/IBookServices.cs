using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services.Intefaces
{
    public interface IBookServices
    {
        Book GetBookByID(int id);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        IEnumerable<Book> GetAllBooks();
    }
}
