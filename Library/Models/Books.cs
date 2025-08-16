using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public partial class Books
{
    [Column("idКниги")]
    public int BookId { get; set; }

    [Column("Название")]
    public string Title { get; set; } = null!;

    [Column("Издательство")]
    public string? Publisher { get; set; }

    [Column("ГодИздания")]
    public DateOnly? YearOfPublication { get; set; }

    public virtual ReadingRoomsAndBooks IdBookNavigation { get; set; } = null!;
}
