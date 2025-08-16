using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class ReadersAndBooks
{
    [Column("idКниги")]
    public int IdBook { get; set; }

    [Column("idЧитателя")]
    public int IdReader { get; set; }

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;

    public virtual Readers IdReaderNavigation { get; set; } = null!;
}
