using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class Readers
{
    [Column("idЧитателя")]
    public int IdReader { get; set; }

    [Column("НомерТелефона")]
    public string PhoneNumber { get; set; } = null!;

    public virtual ReadersPassport? Passport { get; set; }

    public virtual ReadersFullName? FullName { get; set; }

    public virtual ICollection<ReadersAndBooks> ReadersBooks { get; set; } = new List<ReadersAndBooks>();

    public virtual ICollection<ReadingRoomsInLibrary> IdReadingRoom { get; set; } = new List<ReadingRoomsInLibrary>();
}
