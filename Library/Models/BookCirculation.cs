using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class BookCirculation
{
    [Column("idКниги")]
    public int BookId { get; set; }

    [Column("ДатаВыдачи")]
    public DateOnly? IssueDate { get; set; }

    [Column("ДатаВозврата")]
    public DateOnly? ReturnDate { get; set; }

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
