using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRoomsCapacity
{
    public int IdЧитальногоЗала { get; set; }

    public int Вместимость { get; set; }

    public virtual ReadingRoomsInLibrary IdЧитальногоЗалаNavigation { get; set; } = null!;
}
