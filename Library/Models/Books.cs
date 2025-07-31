using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Books
{
    public int IdКниги { get; set; }

    public string Название { get; set; } = null!;

    public string? Издательство { get; set; }

    public DateOnly? ГодИздания { get; set; }

    public virtual ReadingRoomsAndBooks IdКнигиNavigation { get; set; } = null!;
}
