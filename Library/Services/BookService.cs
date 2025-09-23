using Library.Models;
using Library.Repositories;
using Library.Repositories.Interfaces;
using System.Data;
using Library.UI;

namespace Library.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(IGenericRepository<Books> bookRepository)
        {
            _bookRepository = (BookRepository)bookRepository;
        }

        public DataTable GetBooks()
        {
            return _bookRepository.GetBooks();
        }

        public void AddBook(BookInUI book)
        {
            _bookRepository.AddBook(book);
        }

        public void UpdateBook(int bookId, BookInUI bookUI)
        {
            _bookRepository.UpdateBook(bookId, bookUI);
        }

        public void DeleteBook(int bookId)
        {
            _bookRepository.DeleteBook(bookId);
        }
    }
}
