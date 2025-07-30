using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ПаспортныеДанныеЧитатели
{
    public int IdЧитателя { get; set; }

    public string Серия { get; set; } = null!;

    public string Номер { get; set; } = null!;

    public string КемВыдан { get; set; } = null!;

    public DateOnly ДатаВыдачи { get; set; }

    public string АдресРегистрации { get; set; } = null!;

    public virtual Читатели IdЧитателяNavigation { get; set; } = null!;
}
