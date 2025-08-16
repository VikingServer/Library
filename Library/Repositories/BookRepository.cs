using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace Library.Repositories
{
    public class BookRepository : GenericRepository<Books>
    {
        public BookRepository(LibraryContext context) : base(context)
        {
        }

        public DataTable GetBooks()
        {
            var query = from book in _context.Books
                        join bookAuthor in _context.BooksAuthor on book.BookId equals bookAuthor.BookId into baGroup
                        from bookAuthor in baGroup.DefaultIfEmpty()
                        join roomBook in _context.ReadingRoomsAndBooks on book.BookId equals roomBook.IdBook into rbGroup
                        from roomBook in rbGroup.DefaultIfEmpty()
                        join readingRoom in _context.ReadingRooms on roomBook.IdReadingRoom equals readingRoom.IdReadingRoom into rrGroup
                        from readingRoom in rrGroup.DefaultIfEmpty()
                        join bookMark in _context.BooksMarks on book.BookId equals bookMark.BookId into bmGroup
                        from bookMark in bmGroup.DefaultIfEmpty()
                        join circulation in _context.BookCirculation on book.BookId equals circulation.BookId into bcGroup
                        from circulation in bcGroup.DefaultIfEmpty()
                        join readerBook in _context.ReadersAndBooks on book.BookId equals readerBook.IdBook into rbkGroup
                        from readerBook in rbkGroup.DefaultIfEmpty()
                        join reader in _context.Readers on readerBook.IdReader equals reader.IdReader into rGroup
                        from reader in rGroup.DefaultIfEmpty()
                        join readerFullName in _context.ReadersFullName on reader.IdReader equals readerFullName.IdReader into rfnGroup
                        from readerFullName in rfnGroup.DefaultIfEmpty()
                        select new
                        {
                            book.Title,
                            Author = bookAuthor != null ? bookAuthor.Author : null,
                            ReadingRoom = readingRoom != null ? readingRoom.Name : null,
                            Publisher = book.Publisher,
                            PublicationYear = book.YearOfPublication.HasValue ? book.YearOfPublication.Value.ToString("yyyy") : null,
                            Status = bookMark != null && bookMark.Mark == "Выдана" ? "Выдана" : "Доступна",
                            IssueDate = circulation != null && circulation.IssueDate.HasValue ? circulation.IssueDate.Value.ToString("dd.MM.yyyy") : null,
                            ReturnDate = circulation != null && circulation.ReturnDate.HasValue ? circulation.ReturnDate.Value.ToString("dd.MM.yyyy") : null,
                            Reader = bookMark != null && bookMark.Mark == "Выдана" && readerFullName != null
                                ? $"{readerFullName.LastName} {readerFullName.Name[0]}. {(readerFullName.MiddleName != null ? readerFullName.MiddleName[0] + "." : "")}"
                                : ""
                        };

            var orderedQuery = query.OrderBy(x => x.Title);

            DataTable booksData = new DataTable();
            booksData.Columns.Add("Название", typeof(string));
            booksData.Columns.Add("Автор", typeof(string));
            booksData.Columns.Add("Читальный зал", typeof(string));
            booksData.Columns.Add("Издательство", typeof(string));
            booksData.Columns.Add("Год издания", typeof(string));
            booksData.Columns.Add("Статус", typeof(string));
            booksData.Columns.Add("Дата выдачи", typeof(string));
            booksData.Columns.Add("Дата возврата", typeof(string));
            booksData.Columns.Add("Читатель", typeof(string));

            foreach (var item in orderedQuery.ToList())
            {
                booksData.Rows.Add(
                    item.Title,
                    item.Author,
                    item.ReadingRoom,
                    item.Publisher,
                    item.PublicationYear,
                    item.Status,
                    item.IssueDate,
                    item.ReturnDate,
                    item.Reader);
            }

            return booksData;
        }

        public void AddBook(string title, string author, string publisher, DateOnly? year, string readingRoom, bool isIssued, string reader, DateOnly? issueDate, DateOnly? returnDate)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(readingRoom))
                throw new ArgumentException("Обязательные поля: Название, Автор, Читальный зал");

            int readingRoomId = GetReadingRoomId(readingRoom);
            if (readingRoomId == -1)
                throw new ArgumentException("Читальный зал не найден");

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var book = new Books
                    {
                        Title = title,
                        Publisher = publisher,
                        YearOfPublication = year
                    };
                    Add(book);
                    Save();

                    _context.BooksAuthor.Add(new BooksAuthor { BookId = book.BookId, Author = author });
                    _context.ReadingRoomsAndBooks.Add(new ReadingRoomsAndBooks { IdBook = book.BookId, IdReadingRoom = readingRoomId });

                    if (isIssued)
                    {
                        int readerId = GetReaderId(reader);
                        if (readerId == -1)
                            throw new ArgumentException("Читатель не найден");

                        if (issueDate.HasValue && returnDate.HasValue && returnDate < issueDate)
                            throw new ArgumentException("Дата возврата не может быть раньше даты выдачи");

                        _context.BookCirculation.Add(new BookCirculation
                        {
                            BookId = book.BookId,
                            IssueDate = issueDate,
                            ReturnDate = returnDate
                        });

                        _context.ReadersAndBooks.Add(new ReadersAndBooks { IdBook = book.BookId, IdReader = readerId });
                        _context.BooksMarks.Add(new BooksMarks { BookId = book.BookId, Mark = "Выдана" });
                    }
                    else
                    {
                        _context.BooksMarks.Add(new BooksMarks { BookId = book.BookId, Mark = "Нет" });
                    }

                    Save();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdateBook(int bookId, string title, string author, string publisher, DateOnly? year, string readingRoom, bool isIssued, string reader, DateOnly? issueDate, DateOnly? returnDate)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(readingRoom))
                throw new ArgumentException("Обязательные поля: Название, Автор, Читальный зал");

            int readingRoomId = GetReadingRoomId(readingRoom);
            if (readingRoomId == -1)
                throw new ArgumentException("Читальный зал не найден");

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var book = GetById(bookId);
                    if (book == null)
                        throw new ArgumentException("Книга не найдена");

                    book.Title = title;
                    book.Publisher = publisher;
                    book.YearOfPublication = year;

                    var bookAuthor = _context.BooksAuthor.FirstOrDefault(ba => ba.BookId == bookId);
                    if (bookAuthor != null)
                        bookAuthor.Author = author;
                    else
                        _context.BooksAuthor.Add(new BooksAuthor { BookId = bookId, Author = author });

                    var roomBook = _context.ReadingRoomsAndBooks.FirstOrDefault(rrb => rrb.IdBook == bookId);
                    if (roomBook != null)
                        roomBook.IdReadingRoom = readingRoomId;
                    else
                        _context.ReadingRoomsAndBooks.Add(new ReadingRoomsAndBooks { IdBook = bookId, IdReadingRoom = readingRoomId });

                    if (isIssued)
                    {
                        int readerId = GetReaderId(reader);
                        if (readerId == -1)
                            throw new ArgumentException("Читатель не найден");

                        if (issueDate.HasValue && returnDate.HasValue && returnDate < issueDate)
                            throw new ArgumentException("Дата возврата не может быть раньше даты выдачи");

                        var circulation = _context.BookCirculation.FirstOrDefault(bc => bc.BookId == bookId);
                        if (circulation != null)
                        {
                            circulation.IssueDate = issueDate;
                            circulation.ReturnDate = returnDate;
                        }
                        else
                        {
                            _context.BookCirculation.Add(new BookCirculation { BookId = bookId, IssueDate = issueDate, ReturnDate = returnDate });
                        }

                        var readerBook = _context.ReadersAndBooks.FirstOrDefault(rb => rb.IdBook == bookId);
                        if (readerBook != null)
                            readerBook.IdReader = readerId;
                        else
                            _context.ReadersAndBooks.Add(new ReadersAndBooks { IdBook = bookId, IdReader = readerId });

                        var mark = _context.BooksMarks.FirstOrDefault(bm => bm.BookId == bookId);
                        if (mark != null)
                            mark.Mark = "Выдана";
                        else
                            _context.BooksMarks.Add(new BooksMarks { BookId = bookId, Mark = "Выдана" });
                    }
                    else
                    {
                        var circulation = _context.BookCirculation.FirstOrDefault(bc => bc.BookId == bookId);
                        if (circulation != null)
                            _context.BookCirculation.Remove(circulation);

                        var readerBook = _context.ReadersAndBooks.FirstOrDefault(rb => rb.IdBook == bookId);
                        if (readerBook != null)
                            _context.ReadersAndBooks.Remove(readerBook);

                        var mark = _context.BooksMarks.FirstOrDefault(bm => bm.BookId == bookId);
                        if (mark != null)
                            mark.Mark = "Нет";
                        else
                            _context.BooksMarks.Add(new BooksMarks { BookId = bookId, Mark = "Нет" });
                    }

                    Save();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DeleteBook(int bookId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var readerBook = _context.ReadersAndBooks.FirstOrDefault(rb => rb.IdBook == bookId);
                    if (readerBook != null)
                        _context.ReadersAndBooks.Remove(readerBook);

                    var circulation = _context.BookCirculation.FirstOrDefault(bc => bc.BookId == bookId);
                    if (circulation != null)
                        _context.BookCirculation.Remove(circulation);

                    var mark = _context.BooksMarks.FirstOrDefault(bm => bm.BookId == bookId);
                    if (mark != null)
                        _context.BooksMarks.Remove(mark);

                    var author = _context.BooksAuthor.FirstOrDefault(ba => ba.BookId == bookId);
                    if (author != null)
                        _context.BooksAuthor.Remove(author);

                    var book = GetById(bookId);
                    if (book != null)
                        Delete(book);

                    var roomBook = _context.ReadingRoomsAndBooks.FirstOrDefault(rrb => rrb.IdBook == bookId);
                    if (roomBook != null)
                        _context.ReadingRoomsAndBooks.Remove(roomBook);

                    Save();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public int GetReadingRoomId(string roomName)
        {
            var room = _context.ReadingRooms
                .FirstOrDefault(rr => rr.Name == roomName);
            return room?.IdReadingRoom ?? -1;
        }

        public int GetReaderId(string readerName)
        {
            if (string.IsNullOrWhiteSpace(readerName))
                return -1;

            var names = readerName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length < 2)
                return -1;

            var reader = _context.ReadersFullName
                .Join(_context.Readers,
                      rf => rf.IdReader,
                      r => r.IdReader,
                      (rf, r) => new { FullName = rf, Reader = r })
                .FirstOrDefault(x => x.FullName.LastName == names[0] && x.FullName.Name.StartsWith(names[1]))
                ?.Reader;

            return reader?.IdReader ?? -1;
        }
    }
}