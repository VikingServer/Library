using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class LibraryModel
{
    public int Id { get; set; }

    public string? Название { get; set; }

    public string Адрес { get; set; } = null!;

    public string Телефон { get; set; } = null!;

    public virtual ICollection<WorkScheduleModel> ГрафикРаботыs { get; set; } = new List<WorkScheduleModel>();

    public virtual ICollection<ReadingRoomsInLibrary> ЧитальныеЗалыВбиблиотекеs { get; set; } = new List<ReadingRoomsInLibrary>();
}
