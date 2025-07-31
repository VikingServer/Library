using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Books
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Publisher { get; set; }

    public DateOnly? YearOfPublication { get; set; }

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
