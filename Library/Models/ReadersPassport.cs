using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class ReadersPassport
{
    [Column("idЧитателя")]
    public int IdReader { get; set; }

    [Column("Серия")]
    public string SerialNumber { get; set; } = null!;

    [Column("Номер")]
    public string Number { get; set; } = null!;

    [Column("КемВыдан")]
    public string IssuedBy { get; set; } = null!;

    [Column("ДатаВыдачи")]
    public DateOnly DateOfIssue { get; set; }

    [Column("АдресРегистрации")]
    public string RegisteredAddress { get; set; } = null!;

    public virtual Readers IdReaderNavigation { get; set; } = null!;
}
