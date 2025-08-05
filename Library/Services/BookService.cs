using Library.Models;
using Library.Repositories;
using Library.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddBook(string title, string author, string publisher, DateOnly? year, string readingRoom, bool isIssued, string reader, DateOnly? issueDate, DateOnly? returnDate)
        {
            _bookRepository.AddBook(title, author, publisher, year, readingRoom, isIssued, reader, issueDate, returnDate);
        }

        public void UpdateBook(int bookId, string title, string author, string publisher, DateOnly? year, string readingRoom, bool isIssued, string reader, DateOnly? issueDate, DateOnly? returnDate)
        {
            _bookRepository.UpdateBook(bookId, title, author, publisher, year, readingRoom, isIssued, reader, issueDate, returnDate);
        }

        public void DeleteBook(int bookId)
        {
            _bookRepository.DeleteBook(bookId);
        }
    }
}
