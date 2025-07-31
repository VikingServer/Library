using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class BooksAuthor
{
    public int IdКниги { get; set; }

    public string Автор { get; set; } = null!;

    public virtual ReadingRoomsAndBooks IdКнигиNavigation { get; set; } = null!;
}
