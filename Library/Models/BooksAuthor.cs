using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class BooksAuthor
{
    public int BookId { get; set; }

    public string Author { get; set; } = null!;

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
