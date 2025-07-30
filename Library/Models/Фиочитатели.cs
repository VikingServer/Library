using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Фиочитатели
{
    public int IdЧитателя { get; set; }

    public string Фамилия { get; set; } = null!;

    public string Имя { get; set; } = null!;

    public string? Отчество { get; set; }

    public virtual Читатели IdЧитателяNavigation { get; set; } = null!;
}
