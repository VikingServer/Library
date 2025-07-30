using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ГрафикРаботы
{
    public int Id { get; set; }

    public string ДеньНедели { get; set; } = null!;

    public string ЧасыРаботы { get; set; } = null!;

    public virtual Библиотека IdNavigation { get; set; } = null!;
}
