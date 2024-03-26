using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessObject.Models
{
    public partial class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext()
        {
        }

        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<HistoryBook> HistoryBooks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;database=LibraryManagement;user=sa;password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountDob).HasColumnType("datetime");

                entity.Property(e => e.AccountEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName).HasMaxLength(100);

                entity.Property(e => e.AccountPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccountSex)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountUsername)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Book__CategoryId__4D94879B");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.FeedbackContent).HasMaxLength(40);

                entity.Property(e => e.FeedbackDate).HasColumnType("datetime");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__Feedback__BookId__5070F446");
            });

            modelBuilder.Entity<HistoryBook>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK__HistoryB__4D7B4ABD35F6914B");

                entity.ToTable("HistoryBook");

                entity.Property(e => e.HistoryActual).HasColumnType("datetime");

                entity.Property(e => e.HistoryBorrow).HasColumnType("datetime");

                entity.Property(e => e.HistoryReturn).HasColumnType("datetime");

                entity.Property(e => e.HistoryStatus).HasMaxLength(40);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.HistoryBooks)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__HistoryBo__Accou__5441852A");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.HistoryBooks)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__HistoryBo__BookI__534D60F1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
