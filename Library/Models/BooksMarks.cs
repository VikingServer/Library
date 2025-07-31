using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class BooksMarks
{
    public int IdКниги { get; set; }

    public string Метка { get; set; } = null!;

    public virtual ReadingRoomsAndBooks IdКнигиNavigation { get; set; } = null!;
}
