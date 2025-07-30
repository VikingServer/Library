using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Книгооборот
{
    public int IdКниги { get; set; }

    public DateOnly? ДатаВыдачи { get; set; }

    public DateOnly? ДатаВозврата { get; set; }

    public virtual ЧитальныйЗалИкниги IdКнигиNavigation { get; set; } = null!;
}
