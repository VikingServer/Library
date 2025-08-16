using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class WorkScheduleModel
{
    [Column("id")]
    public int LibraryId { get; set; }

    [Column("ДеньНедели")]
    public string DayOfWeek { get; set; } = null!;

    [Column("ЧасыРаботы")]
    public string OpeningHours { get; set; } = null!;

    public virtual LibraryModel IdNavigation { get; set; } = null!;
}
