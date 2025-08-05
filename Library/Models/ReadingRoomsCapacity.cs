using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRoomsCapacity
{
    public int IdReadingRoom { get; set; }

    public int Capacity { get; set; }

    public virtual ReadingRoomsInLibrary IdReadingRoomNavigation { get; set; } = null!;
}
