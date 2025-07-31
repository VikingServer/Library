using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRooms
{
    public int IdЧитальногоЗала { get; set; }

    public string? Название { get; set; }

    public virtual ReadingRoomsInLibrary IdЧитальногоЗалаNavigation { get; set; } = null!;
}
