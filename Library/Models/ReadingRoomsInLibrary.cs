using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRoomsInLibrary
{
    public int? Id { get; set; }

    public int IdЧитальногоЗала { get; set; }

    public virtual LibraryModel? IdNavigation { get; set; }

    public virtual ReadingRooms? ЧитальныеЗалы { get; set; }

    public virtual ReadingRoomsCapacity? ЧитальныеЗалыВместимость { get; set; }

    public virtual ICollection<ReadingRoomsAndBooks> ЧитальныйЗалИкнигиs { get; set; } = new List<ReadingRoomsAndBooks>();

    public virtual ICollection<Readers> IdЧитателяs { get; set; } = new List<Readers>();
}
