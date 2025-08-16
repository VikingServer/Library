using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class LibraryModel
{
    [Column("id")]
    public int Id { get; set; }

    [Column("Название")]
    public string? Name { get; set; }

    [Column("Адрес")]
    public string Address { get; set; } = null!;

    [Column("Телефон")]
    public string PhoneNumber { get; set; } = null!;

    public virtual ICollection<WorkScheduleModel> WorkScheduleModel { get; set; } = new List<WorkScheduleModel>();

    public virtual ICollection<ReadingRoomsInLibrary> ReadingRoomsInLibrary { get; set; } = new List<ReadingRoomsInLibrary>();
}
