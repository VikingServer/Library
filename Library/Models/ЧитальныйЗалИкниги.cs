using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ЧитальныйЗалИкниги
{
    public int IdЧитальногоЗала { get; set; }

    public int IdКниги { get; set; }

    public virtual ЧитальныеЗалыВбиблиотеке IdЧитальногоЗалаNavigation { get; set; } = null!;

    public virtual Книги? Книги { get; set; }

    public virtual КнигиИавтор? КнигиИавтор { get; set; }

    public virtual КнигиМетка? КнигиМетка { get; set; }

    public virtual Книгооборот? Книгооборот { get; set; }

    public virtual ЧитателиИкниги? ЧитателиИкниги { get; set; }
}
