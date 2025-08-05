using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRooms
{
    public int IdReadingRoom { get; set; }

    public string? Name { get; set; }

    public virtual ReadingRoomsInLibrary IdReadingRoomNavigation { get; set; } = null!;
}
