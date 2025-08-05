using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRoomsAndBooks
{
    public int IdReadingRoom { get; set; }

    public int IdBook { get; set; }

    public virtual ReadingRoomsInLibrary IdReadingRoomNavigation { get; set; } = null!;

    public virtual Books? Books { get; set; }

    public virtual BooksAuthor? BooksAuthor { get; set; }

    public virtual BooksMarks? BooksMarks { get; set; }

    public virtual BookCirculation? BookCirculation { get; set; }

    public virtual ReadersAndBooks? ReadersAndBooks { get; set; }
}
