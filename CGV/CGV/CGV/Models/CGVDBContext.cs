using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CGV.Models
{
    public partial class CGVDBContext : DbContext
    {
        public CGVDBContext()
            : base("name=CGVDBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<FilmGenre> FilmGenres { get; set; }
        public virtual DbSet<FormatDetail> FormatDetails { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieFormat> MovieFormats { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Showtime> Showtimes { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
		public virtual DbSet<MovieDetails> MovieDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.IDStaff)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.IDClient)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.NumberPhoneClient)
                .IsUnicode(false);

            modelBuilder.Entity<FilmGenre>()
                .Property(e => e.IDCategory)
                .IsUnicode(false);

			//modelBuilder.Entity<FilmGenre>()
			//	.HasMany(e => e.Movies)
			//	.WithMany(e => e.FilmGenres)
			//	.Map(m => m.ToTable("MovieDetails").MapLeftKey("IDCategory").MapRightKey("IDMovie"));

			modelBuilder.Entity<FormatDetail>()
                .Property(e => e.IDFormat)
                .IsUnicode(false);

            modelBuilder.Entity<FormatDetail>()
                .Property(e => e.IDMovie)
                .IsUnicode(false);

            modelBuilder.Entity<FormatDetail>()
                .Property(e => e.IDMovieFormat)
                .IsUnicode(false);

            modelBuilder.Entity<FormatDetail>()
                .HasMany(e => e.Showtimes)
                .WithRequired(e => e.FormatDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.IDMovie)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.FormatDetails)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Movie>()
            //	.HasMany(e => e.MovieDetails)
            //	.WithRequired(x => x.Movie);

            modelBuilder.Entity<MovieDetails>()
                .HasKey(x => new { x.IDCategory, x.IDMovie });

			modelBuilder.Entity<MovieFormat>()
                .Property(e => e.IDMovieFormat)
                .IsUnicode(false);

            modelBuilder.Entity<MovieFormat>()
                .HasMany(e => e.FormatDetails)
                .WithRequired(e => e.MovieFormat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.IDRoom)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.IDMovieFormat)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Showtimes)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Showtime>()
                .Property(e => e.IDShowtimes)
                .IsUnicode(false);

            modelBuilder.Entity<Showtime>()
                .Property(e => e.IDRoom)
                .IsUnicode(false);

            modelBuilder.Entity<Showtime>()
                .Property(e => e.IDFormat)
                .IsUnicode(false);

            modelBuilder.Entity<Showtime>()
                .Property(e => e.Fare)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Staff>()
                .Property(e => e.IDStaff)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.NumberPhoneStaff)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.IDShowTimes)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.MaGheNgoi)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.IDClient)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.TienBanVe)
                .HasPrecision(19, 4);
        }
    }
}
