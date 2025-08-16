using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class ReadingRooms
{
    [Column("IdЧитальногоЗала")]
    public int IdReadingRoom { get; set; }

    [Column("Название")]
    public string? Name { get; set; }

    public virtual ReadingRoomsInLibrary IdReadingRoomNavigation { get; set; } = null!;
}
