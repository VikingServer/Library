using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ЧитателиИкниги
{
    public int IdКниги { get; set; }

    public int IdЧитателя { get; set; }

    public virtual ЧитальныйЗалИкниги IdКнигиNavigation { get; set; } = null!;

    public virtual Читатели IdЧитателяNavigation { get; set; } = null!;
}
