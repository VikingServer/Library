using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadersPassport
{
    public int IdReader { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string IssuedBy { get; set; } = null!;

    public DateOnly DateOfIssue { get; set; }

    public string RegisteredAddress { get; set; } = null!;

    public virtual Readers IdReaderNavigation { get; set; } = null!;
}
