using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ЧитальныеЗалыВбиблиотеке
{
    public int? Id { get; set; }

    public int IdЧитальногоЗала { get; set; }

    public virtual Библиотека? IdNavigation { get; set; }

    public virtual ЧитальныеЗалы? ЧитальныеЗалы { get; set; }

    public virtual ЧитальныеЗалыВместимость? ЧитальныеЗалыВместимость { get; set; }

    public virtual ICollection<ЧитальныйЗалИкниги> ЧитальныйЗалИкнигиs { get; set; } = new List<ЧитальныйЗалИкниги>();

    public virtual ICollection<Читатели> IdЧитателяs { get; set; } = new List<Читатели>();
}
