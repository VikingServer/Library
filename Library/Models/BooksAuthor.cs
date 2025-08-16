using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class BooksAuthor
{
    [Column("idКниги")]
    public int BookId { get; set; }

    [Column("Автор")]
    public string Author { get; set; } = null!;

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
