using System;
using System.Collections.Generic;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LibraryModel> LibraryModel { get; set; }

    public virtual DbSet<WorkScheduleModel> WorkSchedule { get; set; }

    public virtual DbSet<Books> Books { get; set; }

    public virtual DbSet<BooksAuthor> BooksAuthor { get; set; }

    public virtual DbSet<BooksMarks> BooksMarks { get; set; }

    public virtual DbSet<BookCirculation> BookCirculation { get; set; }

    public virtual DbSet<ReadersPassport> ReadersPassport { get; set; }

    public virtual DbSet<ReadersFullName> ReadersFullName { get; set; }

    public virtual DbSet<ReadingRooms> ReadingRooms { get; set; }

    public virtual DbSet<ReadingRoomsInLibrary> ReadingRoomsInLibrary { get; set; }

    public virtual DbSet<ReadingRoomsCapacity> ReadingRoomsCapacity { get; set; }

    public virtual DbSet<ReadingRoomsAndBooks> ReadingRoomsAndBooks { get; set; }

    public virtual DbSet<Readers> Readers { get; set; }

    public virtual DbSet<ReadersAndBooks> ReadersAndBooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=Library;Username=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LibraryModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Библиотека_pkey");

            entity.ToTable("Библиотека");

            entity.HasIndex(e => e.Name, "Библиотека_название_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("адрес");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("название");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(14)
                .HasColumnName("телефон");
        });

        modelBuilder.Entity<WorkScheduleModel>(entity =>
        {
            entity.HasKey(e => new { e.LibraryId, e.DayOfWeek }).HasName("ГрафикРаботы_pkey");

            entity.ToTable("ГрафикРаботы");

            entity.Property(e => e.LibraryId).HasColumnName("id");
            entity.Property(e => e.DayOfWeek).HasMaxLength(255);
            entity.Property(e => e.OpeningHours).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.WorkScheduleModel)
                .HasForeignKey(d => d.LibraryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ГрафикРаботы_id_fkey");
        });

        modelBuilder.Entity<Books>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("Книги_pkey");

            entity.ToTable("Книги");

            entity.Property(e => e.BookId)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.Publisher).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.IdBookNavigation).WithOne(p => p.Books)
                .HasForeignKey<Books>(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Книги_idКниги_fkey");
        });

        modelBuilder.Entity<BooksAuthor>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("КнигиИАвтор_pkey");

            entity.ToTable("КнигиИАвтор");

            entity.Property(e => e.BookId)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.Author).HasMaxLength(255);

            entity.HasOne(d => d.IdBookNavigation).WithOne(p => p.BooksAuthor)
                .HasForeignKey<BooksAuthor>(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("КнигиИАвтор_idКниги_fkey");
        });

        modelBuilder.Entity<BooksMarks>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("КнигиМетка_pkey");

            entity.ToTable("КнигиМетка");

            entity.Property(e => e.BookId)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.Mark).HasMaxLength(7);

            entity.HasOne(d => d.IdBookNavigation).WithOne(p => p.BooksMarks)
                .HasForeignKey<BooksMarks>(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("КнигиМетка_idКниги_fkey");
        });

        modelBuilder.Entity<BookCirculation>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("Книгооборот_pkey");

            entity.ToTable("Книгооборот");

            entity.Property(e => e.BookId)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");

            entity.HasOne(d => d.IdBookNavigation).WithOne(p => p.BookCirculation)
                .HasForeignKey<BookCirculation>(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Книгооборот_idКниги_fkey");
        });

        modelBuilder.Entity<ReadersPassport>(entity =>
        {
            entity.HasKey(e => e.IdReader).HasName("ПаспортныеДанныеЧитатели_pkey");

            entity.ToTable("ПаспортныеДанныеЧитатели");

            entity.Property(e => e.IdReader)
                .HasDefaultValueSql("nextval('\"ПаспортныеДанныеЧита_idЧитателя_seq\"'::regclass)")
                .HasColumnName("idЧитателя");
            entity.Property(e => e.RegisteredAddress).HasMaxLength(255);
            entity.Property(e => e.IssuedBy).HasMaxLength(255);
            entity.Property(e => e.Number).HasMaxLength(6);
            entity.Property(e => e.SerialNumber).HasMaxLength(4);

            entity.HasOne(d => d.IdReaderNavigation).WithOne(p => p.Passport)
                .HasForeignKey<ReadersPassport>(d => d.IdReader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ПаспортныеДанныеЧит_idЧитателя_fkey");
        });

        modelBuilder.Entity<ReadersFullName>(entity =>
        {
            entity.HasKey(e => e.IdReader).HasName("ФИОЧитатели_pkey");

            entity.ToTable("ФИОЧитатели");

            entity.Property(e => e.IdReader)
                .ValueGeneratedOnAdd()
                .HasColumnName("idЧитателя");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);

            entity.HasOne(d => d.IdReaderNavigation).WithOne(p => p.FullName)
                .HasForeignKey<ReadersFullName>(d => d.IdReader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ФИОЧитатели_idЧитателя_fkey");
        });

        modelBuilder.Entity<ReadingRooms>(entity =>
        {
            entity.HasKey(e => e.IdReadingRoom).HasName("ЧитальныеЗалы_pkey");

            entity.ToTable("ЧитальныеЗалы");

            entity.HasIndex(e => e.Name, "ЧитальныеЗалы_Название_key").IsUnique();

            entity.Property(e => e.IdReadingRoom)
                .ValueGeneratedOnAdd()
                .HasColumnName("idЧитальногоЗала");
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.IdReadingRoomNavigation).WithOne(p => p.ReadingRooms)
                .HasForeignKey<ReadingRooms>(d => d.IdReadingRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитальныеЗалы_idЧитальногоЗала_fkey");
        });

        modelBuilder.Entity<ReadingRoomsInLibrary>(entity =>
        {
            entity.HasKey(e => e.IdReadingRoom).HasName("ЧитальныеЗалыВБиблиотеке_pkey");

            entity.ToTable("ЧитальныеЗалыВБиблиотеке");

            entity.Property(e => e.IdReadingRoom)
                .HasDefaultValueSql("nextval('\"ЧитальныеЗалыВ_idЧитальногоЗал_seq\"'::regclass)")
                .HasColumnName("idЧитальногоЗала");
            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.ReadingRoomsInLibrary)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("ЧитальныеЗалыВБиблиотеке_id_fkey");
        });

        modelBuilder.Entity<ReadingRoomsCapacity>(entity =>
        {
            entity.HasKey(e => e.IdReadingRoom).HasName("ЧитальныеЗалыВместимость_pkey");

            entity.ToTable("ЧитальныеЗалыВместимость");

            entity.Property(e => e.IdReadingRoom)
                .HasDefaultValueSql("nextval('\"ЧитальныеЗалыВ_idЧитальногоЗал_seq1\"'::regclass)")
                .HasColumnName("idЧитальногоЗала");

            entity.HasOne(d => d.IdReadingRoomNavigation).WithOne(p => p.ReadingRoomsCapacity)
                .HasForeignKey<ReadingRoomsCapacity>(d => d.IdReadingRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитальныеЗалыВ_idЧитальногоЗал_fkey");
        });

        modelBuilder.Entity<ReadingRoomsAndBooks>(entity =>
        {
            entity.HasKey(e => e.IdBook).HasName("ЧитальныйЗалИКниги_pkey");

            entity.ToTable("ЧитальныйЗалИКниги");

            entity.Property(e => e.IdBook).HasColumnName("idКниги");
            entity.Property(e => e.IdReadingRoom)
                .HasDefaultValueSql("nextval('\"ЧитальныйЗалИК_idЧитальногоЗал_seq\"'::regclass)")
                .HasColumnName("idЧитальногоЗала");

            entity.HasOne(d => d.IdReadingRoomNavigation).WithMany(p => p.ReadingRoomsAndBooks)
                .HasForeignKey(d => d.IdReadingRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитальныйЗалИК_idЧитальногоЗал_fkey");
        });

        modelBuilder.Entity<Readers>(entity =>
        {
            entity.HasKey(e => e.IdReader).HasName("Читатели_pkey");

            entity.ToTable("Читатели");

            entity.Property(e => e.IdReader).HasColumnName("idЧитателя");
            entity.Property(e => e.PhoneNumber).HasMaxLength(11);

            entity.HasMany(d => d.IdReadingRoom).WithMany(p => p.IdReader)
                .UsingEntity<Dictionary<string, object>>(
                    "ЧитальныеЗалыИчитатели",
                    r => r.HasOne<ReadingRoomsInLibrary>().WithMany()
                        .HasForeignKey("IdЧитальногоЗала")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("ЧитальныеЗалыИ_idЧитальногоЗал_fkey"),
                    l => l.HasOne<Readers>().WithMany()
                        .HasForeignKey("IdЧитателя")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("ЧитальныеЗалыИЧитат_idЧитателя_fkey"),
                    j =>
                    {
                        j.HasKey("IdЧитателя", "IdЧитальногоЗала").HasName("ЧитальныеЗалыИЧитатели_pkey");
                        j.ToTable("ЧитальныеЗалыИЧитатели");
                        j.IndexerProperty<int>("IdЧитателя")
                            .HasDefaultValueSql("nextval('\"ЧитальныеЗалыИЧитате_idЧитателя_seq\"'::regclass)")
                            .HasColumnName("idЧитателя");
                        j.IndexerProperty<int>("IdЧитальногоЗала")
                            .HasDefaultValueSql("nextval('\"ЧитальныеЗалыИ_idЧитальногоЗал_seq\"'::regclass)")
                            .HasColumnName("idЧитальногоЗала");
                    });
        });

        modelBuilder.Entity<ReadersAndBooks>(entity =>
        {
            entity.HasKey(e => e.IdBook).HasName("ЧитателиИКниги_pkey");

            entity.ToTable("ЧитателиИКниги");

            entity.Property(e => e.IdBook)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.IdReader)
                .ValueGeneratedOnAdd()
                .HasColumnName("idЧитателя");

            entity.HasOne(d => d.IdBookNavigation).WithOne(p => p.ReadersAndBooks)
                .HasForeignKey<ReadersAndBooks>(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитателиИКниги_idКниги_fkey");

            entity.HasOne(d => d.IdReaderNavigation).WithMany(p => p.ReadersBooks)
                .HasForeignKey(d => d.IdReader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитателиИКниги_idЧитателя_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
