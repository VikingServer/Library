using System;
using System.Collections.Generic;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
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

            entity.HasIndex(e => e.Название, "Библиотека_название_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Адрес)
                .HasMaxLength(255)
                .HasColumnName("адрес");
            entity.Property(e => e.Название)
                .HasMaxLength(255)
                .HasColumnName("название");
            entity.Property(e => e.Телефон)
                .HasMaxLength(14)
                .HasColumnName("телефон");
        });

        modelBuilder.Entity<WorkScheduleModel>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.ДеньНедели }).HasName("ГрафикРаботы_pkey");

            entity.ToTable("ГрафикРаботы");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ДеньНедели).HasMaxLength(255);
            entity.Property(e => e.ЧасыРаботы).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.ГрафикРаботыs)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ГрафикРаботы_id_fkey");
        });

        modelBuilder.Entity<Books>(entity =>
        {
            entity.HasKey(e => e.IdКниги).HasName("Книги_pkey");

            entity.ToTable("Книги");

            entity.Property(e => e.IdКниги)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.Издательство).HasMaxLength(255);
            entity.Property(e => e.Название).HasMaxLength(255);

            entity.HasOne(d => d.IdКнигиNavigation).WithOne(p => p.Книги)
                .HasForeignKey<Books>(d => d.IdКниги)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Книги_idКниги_fkey");
        });

        modelBuilder.Entity<BooksAuthor>(entity =>
        {
            entity.HasKey(e => e.IdКниги).HasName("КнигиИАвтор_pkey");

            entity.ToTable("КнигиИАвтор");

            entity.Property(e => e.IdКниги)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.Автор).HasMaxLength(255);

            entity.HasOne(d => d.IdКнигиNavigation).WithOne(p => p.КнигиИавтор)
                .HasForeignKey<BooksAuthor>(d => d.IdКниги)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("КнигиИАвтор_idКниги_fkey");
        });

        modelBuilder.Entity<BooksMarks>(entity =>
        {
            entity.HasKey(e => e.IdКниги).HasName("КнигиМетка_pkey");

            entity.ToTable("КнигиМетка");

            entity.Property(e => e.IdКниги)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.Метка).HasMaxLength(7);

            entity.HasOne(d => d.IdКнигиNavigation).WithOne(p => p.КнигиМетка)
                .HasForeignKey<BooksMarks>(d => d.IdКниги)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("КнигиМетка_idКниги_fkey");
        });

        modelBuilder.Entity<BookCirculation>(entity =>
        {
            entity.HasKey(e => e.IdКниги).HasName("Книгооборот_pkey");

            entity.ToTable("Книгооборот");

            entity.Property(e => e.IdКниги)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");

            entity.HasOne(d => d.IdКнигиNavigation).WithOne(p => p.Книгооборот)
                .HasForeignKey<BookCirculation>(d => d.IdКниги)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Книгооборот_idКниги_fkey");
        });

        modelBuilder.Entity<ReadersPassport>(entity =>
        {
            entity.HasKey(e => e.IdЧитателя).HasName("ПаспортныеДанныеЧитатели_pkey");

            entity.ToTable("ПаспортныеДанныеЧитатели");

            entity.Property(e => e.IdЧитателя)
                .HasDefaultValueSql("nextval('\"ПаспортныеДанныеЧита_idЧитателя_seq\"'::regclass)")
                .HasColumnName("idЧитателя");
            entity.Property(e => e.АдресРегистрации).HasMaxLength(255);
            entity.Property(e => e.КемВыдан).HasMaxLength(255);
            entity.Property(e => e.Номер).HasMaxLength(6);
            entity.Property(e => e.Серия).HasMaxLength(4);

            entity.HasOne(d => d.IdЧитателяNavigation).WithOne(p => p.ПаспортныеДанныеЧитатели)
                .HasForeignKey<ReadersPassport>(d => d.IdЧитателя)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ПаспортныеДанныеЧит_idЧитателя_fkey");
        });

        modelBuilder.Entity<ReadersFullName>(entity =>
        {
            entity.HasKey(e => e.IdЧитателя).HasName("ФИОЧитатели_pkey");

            entity.ToTable("ФИОЧитатели");

            entity.Property(e => e.IdЧитателя)
                .ValueGeneratedOnAdd()
                .HasColumnName("idЧитателя");
            entity.Property(e => e.Имя).HasMaxLength(255);
            entity.Property(e => e.Отчество).HasMaxLength(255);
            entity.Property(e => e.Фамилия).HasMaxLength(255);

            entity.HasOne(d => d.IdЧитателяNavigation).WithOne(p => p.Фиочитатели)
                .HasForeignKey<ReadersFullName>(d => d.IdЧитателя)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ФИОЧитатели_idЧитателя_fkey");
        });

        modelBuilder.Entity<ReadingRooms>(entity =>
        {
            entity.HasKey(e => e.IdЧитальногоЗала).HasName("ЧитальныеЗалы_pkey");

            entity.ToTable("ЧитальныеЗалы");

            entity.HasIndex(e => e.Название, "ЧитальныеЗалы_Название_key").IsUnique();

            entity.Property(e => e.IdЧитальногоЗала)
                .ValueGeneratedOnAdd()
                .HasColumnName("idЧитальногоЗала");
            entity.Property(e => e.Название).HasMaxLength(255);

            entity.HasOne(d => d.IdЧитальногоЗалаNavigation).WithOne(p => p.ЧитальныеЗалы)
                .HasForeignKey<ReadingRooms>(d => d.IdЧитальногоЗала)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитальныеЗалы_idЧитальногоЗала_fkey");
        });

        modelBuilder.Entity<ReadingRoomsInLibrary>(entity =>
        {
            entity.HasKey(e => e.IdЧитальногоЗала).HasName("ЧитальныеЗалыВБиблиотеке_pkey");

            entity.ToTable("ЧитальныеЗалыВБиблиотеке");

            entity.Property(e => e.IdЧитальногоЗала)
                .HasDefaultValueSql("nextval('\"ЧитальныеЗалыВ_idЧитальногоЗал_seq\"'::regclass)")
                .HasColumnName("idЧитальногоЗала");
            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.ЧитальныеЗалыВбиблиотекеs)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("ЧитальныеЗалыВБиблиотеке_id_fkey");
        });

        modelBuilder.Entity<ReadingRoomsCapacity>(entity =>
        {
            entity.HasKey(e => e.IdЧитальногоЗала).HasName("ЧитальныеЗалыВместимость_pkey");

            entity.ToTable("ЧитальныеЗалыВместимость");

            entity.Property(e => e.IdЧитальногоЗала)
                .HasDefaultValueSql("nextval('\"ЧитальныеЗалыВ_idЧитальногоЗал_seq1\"'::regclass)")
                .HasColumnName("idЧитальногоЗала");

            entity.HasOne(d => d.IdЧитальногоЗалаNavigation).WithOne(p => p.ЧитальныеЗалыВместимость)
                .HasForeignKey<ReadingRoomsCapacity>(d => d.IdЧитальногоЗала)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитальныеЗалыВ_idЧитальногоЗал_fkey");
        });

        modelBuilder.Entity<ReadingRoomsAndBooks>(entity =>
        {
            entity.HasKey(e => e.IdКниги).HasName("ЧитальныйЗалИКниги_pkey");

            entity.ToTable("ЧитальныйЗалИКниги");

            entity.Property(e => e.IdКниги).HasColumnName("idКниги");
            entity.Property(e => e.IdЧитальногоЗала)
                .HasDefaultValueSql("nextval('\"ЧитальныйЗалИК_idЧитальногоЗал_seq\"'::regclass)")
                .HasColumnName("idЧитальногоЗала");

            entity.HasOne(d => d.IdЧитальногоЗалаNavigation).WithMany(p => p.ЧитальныйЗалИкнигиs)
                .HasForeignKey(d => d.IdЧитальногоЗала)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитальныйЗалИК_idЧитальногоЗал_fkey");
        });

        modelBuilder.Entity<Readers>(entity =>
        {
            entity.HasKey(e => e.IdЧитателя).HasName("Читатели_pkey");

            entity.ToTable("Читатели");

            entity.Property(e => e.IdЧитателя).HasColumnName("idЧитателя");
            entity.Property(e => e.НомерТелефона).HasMaxLength(11);

            entity.HasMany(d => d.IdЧитальногоЗалаs).WithMany(p => p.IdЧитателяs)
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
            entity.HasKey(e => e.IdКниги).HasName("ЧитателиИКниги_pkey");

            entity.ToTable("ЧитателиИКниги");

            entity.Property(e => e.IdКниги)
                .ValueGeneratedOnAdd()
                .HasColumnName("idКниги");
            entity.Property(e => e.IdЧитателя)
                .ValueGeneratedOnAdd()
                .HasColumnName("idЧитателя");

            entity.HasOne(d => d.IdКнигиNavigation).WithOne(p => p.ЧитателиИкниги)
                .HasForeignKey<ReadersAndBooks>(d => d.IdКниги)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитателиИКниги_idКниги_fkey");

            entity.HasOne(d => d.IdЧитателяNavigation).WithMany(p => p.ЧитателиИкнигиs)
                .HasForeignKey(d => d.IdЧитателя)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ЧитателиИКниги_idЧитателя_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
