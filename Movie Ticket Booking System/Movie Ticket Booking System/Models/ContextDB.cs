using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Movie_Ticket_Booking_System.Models
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<CHAIR> CHAIRs { get; set; }
        public virtual DbSet<DISCOUNT> DISCOUNTs { get; set; }
        public virtual DbSet<MOVIE> MOVIEs { get; set; }
        public virtual DbSet<ROOM> ROOMs { get; set; }
        public virtual DbSet<SHOWTIME> SHOWTIMEs { get; set; }
        public virtual DbSet<TICKET> TICKETs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.Balance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .HasMany(e => e.TICKETs)
                .WithRequired(e => e.ACCOUNT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHAIR>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DISCOUNT>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<DISCOUNT>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<MOVIE>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MOVIE>()
                .HasMany(e => e.SHOWTIMEs)
                .WithRequired(e => e.MOVIE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROOM>()
                .HasMany(e => e.SHOWTIMEs)
                .WithRequired(e => e.ROOM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SHOWTIME>()
                .HasMany(e => e.TICKETs)
                .WithRequired(e => e.SHOWTIME)
                .HasForeignKey(e => new { e.ShowTimeID, e.RoomID, e.MovieID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TICKET>()
                .Property(e => e.SubTotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TICKET>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TICKET>()
                .Property(e => e.AccountID)
                .IsUnicode(false);
        }
    }
}
