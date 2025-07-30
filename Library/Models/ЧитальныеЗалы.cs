using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ЧитальныеЗалы
{
    public int IdЧитальногоЗала { get; set; }

    public string? Название { get; set; }

    public virtual ЧитальныеЗалыВбиблиотеке IdЧитальногоЗалаNavigation { get; set; } = null!;
}
