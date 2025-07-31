using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class LibraryModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public virtual ICollection<WorkScheduleModel> WorkScheduleModel { get; set; } = new List<WorkScheduleModel>();

    public virtual ICollection<ReadingRoomsInLibrary> ReadingRoomsInLibrary { get; set; } = new List<ReadingRoomsInLibrary>();
}
