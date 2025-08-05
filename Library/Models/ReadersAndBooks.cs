using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadersAndBooks
{
    public int IdBook { get; set; }

    public int IdReader { get; set; }

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;

    public virtual Readers IdReaderNavigation { get; set; } = null!;
}
