using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class КнигиИавтор
{
    public int IdКниги { get; set; }

    public string Автор { get; set; } = null!;

    public virtual ЧитальныйЗалИкниги IdКнигиNavigation { get; set; } = null!;
}
