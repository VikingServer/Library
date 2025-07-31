using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class WorkScheduleModel
{
    public int LibraryId { get; set; }

    public string DayOfWeek { get; set; } = null!;

    public string OpeningHours { get; set; } = null!;

    public virtual LibraryModel IdNavigation { get; set; } = null!;
}
