using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class ReadingRoomsAndBooks
{
    [Column("idЧитальногоЗала")]
    public int IdReadingRoom { get; set; }

    [Column("idКниги")]
    public int IdBook { get; set; }

    public virtual ReadingRoomsInLibrary IdReadingRoomNavigation { get; set; } = null!;

    public virtual Books? Books { get; set; }

    public virtual BooksAuthor? BooksAuthor { get; set; }

    public virtual BooksMarks? BooksMarks { get; set; }

    public virtual BookCirculation? BookCirculation { get; set; }

    public virtual ReadersAndBooks? ReadersAndBooks { get; set; }
}
