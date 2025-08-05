using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class BookCirculation
{
    public int BookId { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
