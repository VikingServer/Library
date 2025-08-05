using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class ReadersFullName
{
    [Column("idЧитателя")]
    public int IdReader { get; set; }

    [Column("Фамилия")]
    public string LastName { get; set; } = null!;

    [Column("Имя")]
    public string Name { get; set; } = null!;

    [Column("Отчество")]
    public string? MiddleName { get; set; }

    public virtual Readers IdReaderNavigation { get; set; } = null!;
}
