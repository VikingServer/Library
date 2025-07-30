using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class КнигиМетка
{
    public int IdКниги { get; set; }

    public string Метка { get; set; } = null!;

    public virtual ЧитальныйЗалИкниги IdКнигиNavigation { get; set; } = null!;
}
