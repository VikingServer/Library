using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Читатели
{
    public int IdЧитателя { get; set; }

    public string НомерТелефона { get; set; } = null!;

    public virtual ПаспортныеДанныеЧитатели? ПаспортныеДанныеЧитатели { get; set; }

    public virtual Фиочитатели? Фиочитатели { get; set; }

    public virtual ICollection<ЧитателиИкниги> ЧитателиИкнигиs { get; set; } = new List<ЧитателиИкниги>();

    public virtual ICollection<ЧитальныеЗалыВбиблиотеке> IdЧитальногоЗалаs { get; set; } = new List<ЧитальныеЗалыВбиблиотеке>();
}
