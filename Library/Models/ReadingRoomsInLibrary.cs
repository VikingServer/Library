using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRoomsInLibrary
{
    public int? Id { get; set; }

    public int IdReadingRoom { get; set; }

    public virtual LibraryModel? IdNavigation { get; set; }

    public virtual ReadingRooms? ReadingRooms { get; set; }

    public virtual ReadingRoomsCapacity? ReadingRoomsCapacity { get; set; }

    public virtual ICollection<ReadingRoomsAndBooks> ReadingRoomsAndBooks { get; set; } = new List<ReadingRoomsAndBooks>();

    public virtual ICollection<Readers> IdReader { get; set; } = new List<Readers>();
}
