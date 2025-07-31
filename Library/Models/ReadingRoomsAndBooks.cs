using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class ReadingRoomsAndBooks
{
    public int IdЧитальногоЗала { get; set; }

    public int IdКниги { get; set; }

    public virtual ReadingRoomsInLibrary IdЧитальногоЗалаNavigation { get; set; } = null!;

    public virtual Books? Книги { get; set; }

    public virtual BooksAuthor? КнигиИавтор { get; set; }

    public virtual BooksMarks? КнигиМетка { get; set; }

    public virtual BookCirculation? Книгооборот { get; set; }

    public virtual ReadersAndBooks? ЧитателиИкниги { get; set; }
}
