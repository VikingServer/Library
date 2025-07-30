using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ЧитальныеЗалыВместимость
{
    public int IdЧитальногоЗала { get; set; }

    public int Вместимость { get; set; }

    public virtual ЧитальныеЗалыВбиблиотеке IdЧитальногоЗалаNavigation { get; set; } = null!;
}
