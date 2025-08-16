using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class BooksMarks
{
    [Column("idКниги")]
    public int BookId { get; set; }

    [Column("Метка")]
    public string Mark { get; set; } = null!;

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
