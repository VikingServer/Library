using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class ReadingRoomsInLibrary
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("idЧитальногоЗала")]
    public int IdReadingRoom { get; set; }

    public virtual LibraryModel? IdNavigation { get; set; }

    public virtual ReadingRooms IdReadingRoomNavigation { get; set; } = null!;

    public virtual ReadingRoomsCapacity? ReadingRoomsCapacity { get; set; }

    public virtual ICollection<ReadingRoomsAndBooks> ReadingRoomsAndBooks { get; set; } = new List<ReadingRoomsAndBooks>();

    public virtual ICollection<Readers> IdReader { get; set; } = new List<Readers>();
}
