using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadersAndBooks
{
    public int IdКниги { get; set; }

    public int IdЧитателя { get; set; }

    public virtual ReadingRoomsAndBooks IdКнигиNavigation { get; set; } = null!;

    public virtual Readers IdЧитателяNavigation { get; set; } = null!;
}
