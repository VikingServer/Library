namespace Library.UI
{
    public class BookInUI
    {
        public readonly string title;
        public readonly string author;
        public readonly string publisher;
        public readonly DateOnly? yearOfPublisher;
        public readonly string readingRoom;
        public readonly bool isIssued;
        public readonly string reader;
        public readonly DateOnly? issueDate;
        public readonly DateOnly? returnDate;

        public BookInUI(string title, string author, string publisher, DateOnly? year, string readingRoom, bool isIssued, string reader, DateOnly? issueDate, DateOnly? returnDate) 
        { 
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            yearOfPublisher = year;
            this.readingRoom = readingRoom;
            this.isIssued = isIssued;
            this.reader = reader;
            this.issueDate = issueDate;
            this.returnDate = returnDate;
        }
    }
}
