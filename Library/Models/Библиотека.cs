using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Библиотека
{
    public int Id { get; set; }

    public string? Название { get; set; }

    public string Адрес { get; set; } = null!;

    public string Телефон { get; set; } = null!;

    public virtual ICollection<ГрафикРаботы> ГрафикРаботыs { get; set; } = new List<ГрафикРаботы>();

    public virtual ICollection<ЧитальныеЗалыВбиблиотеке> ЧитальныеЗалыВбиблиотекеs { get; set; } = new List<ЧитальныеЗалыВбиблиотеке>();
}
