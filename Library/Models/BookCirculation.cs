using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class BookCirculation
{
    public int BookId { get; set; }

    public DateOnly? ДатаВыдачи { get; set; }

    public DateOnly? ДатаВозврата { get; set; }

    public virtual ReadingRoomsAndBooks IdКнигиNavigation { get; set; } = null!;
}
