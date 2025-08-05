namespace Library.Models;

public partial class BooksMarks
{
    public int BookId { get; set; }

    public string Mark { get; set; } = null!;

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
