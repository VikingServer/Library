using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class ReadingRoomsCapacity
{
    [Column("idЧитальногоЗала")]
    public int IdReadingRoom { get; set; }

    [Column("Вместимость")]
    public int Capacity { get; set; }

    public virtual ReadingRoomsInLibrary IdReadingRoomNavigation { get; set; } = null!;
}
