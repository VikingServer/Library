using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadersFullName
{
    public int IdЧитателя { get; set; }

    public string Фамилия { get; set; } = null!;

    public string Имя { get; set; } = null!;

    public string? Отчество { get; set; }

    public virtual Readers IdЧитателяNavigation { get; set; } = null!;
}
