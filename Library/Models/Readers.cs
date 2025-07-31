using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Readers
{
    public int IdЧитателя { get; set; }

    public string НомерТелефона { get; set; } = null!;

    public virtual ReadersPassport? ПаспортныеДанныеЧитатели { get; set; }

    public virtual ReadersFullName? Фиочитатели { get; set; }

    public virtual ICollection<ReadersAndBooks> ЧитателиИкнигиs { get; set; } = new List<ReadersAndBooks>();

    public virtual ICollection<ReadingRoomsInLibrary> IdЧитальногоЗалаs { get; set; } = new List<ReadingRoomsInLibrary>();
}
