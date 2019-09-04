using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Biblioteka_WebApi.Database
{
    public partial class eLibraryContext : DbContext
    {
        public eLibraryContext()
        {
        }

        public eLibraryContext(DbContextOptions<eLibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autori> Autori { get; set; }
        public virtual DbSet<Clanarine> Clanarine { get; set; }
        public virtual DbSet<Knjige> Knjige { get; set; }
        public virtual DbSet<KnjigeAutori> KnjigeAutori { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Obavijesti> Obavijesti { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Recenzije> Recenzije { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<RezervacijeKnjige> RezervacijeKnjige { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Zanrovi> Zanrovi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=eLibrary;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autori>(entity =>
            {
                entity.HasKey(e => e.AutorId);

                entity.Property(e => e.AutorId).HasColumnName("AutorID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Clanarine>(entity =>
            {
                entity.HasKey(e => e.ClanarinaId);

                entity.Property(e => e.ClanarinaId).HasColumnName("ClanarinaID");

                entity.Property(e => e.DatumIsteka).HasColumnType("datetime");

                entity.Property(e => e.DatumUplate).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Clanarine)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Clanarine__Koris__46E78A0C");
            });

            modelBuilder.Entity<Knjige>(entity =>
            {
                entity.HasKey(e => e.KnjigaId);

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.DatumIzdavanja).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sadrzaj).IsRequired();

                entity.Property(e => e.Sifra).HasMaxLength(50);

                entity.Property(e => e.ZanrId).HasColumnName("ZanrID");

                entity.HasOne(d => d.Zanr)
                    .WithMany(p => p.Knjige)
                    .HasForeignKey(d => d.ZanrId)
                    .HasConstraintName("FK__Knjige__ZanrID__3B75D760");
            });

            modelBuilder.Entity<KnjigeAutori>(entity =>
            {
                entity.Property(e => e.KnjigeAutoriId).HasColumnName("KnjigeAutoriID");

                entity.Property(e => e.AutorId).HasColumnName("AutorID");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.KnjigeAutori)
                    .HasForeignKey(d => d.AutorId)
                    .HasConstraintName("FK__KnjigeAut__Autor__3F466844");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.KnjigeAutori)
                    .HasForeignKey(d => d.KnjigaId)
                    .HasConstraintName("FK__KnjigeAut__Knjig__3E52440B");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Adresa).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(30);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK__Korisnici__Uloga__440B1D61");
            });

            modelBuilder.Entity<Obavijesti>(entity =>
            {
                entity.HasKey(e => e.ObavijestId);

                entity.Property(e => e.ObavijestId).HasColumnName("ObavijestID");

                entity.Property(e => e.DatumObjave).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sadrzaj).IsRequired();

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Obavijesti)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Obavijest__Koris__5070F446");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KnjigaId)
                    .HasConstraintName("FK__Ocjene__KnjigaID__5812160E");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Ocjene__Korisnik__571DF1D5");
            });

            modelBuilder.Entity<Recenzije>(entity =>
            {
                entity.HasKey(e => e.RecenzijaId);

                entity.Property(e => e.RecenzijaId).HasColumnName("RecenzijaID");

                entity.Property(e => e.DatumObjave).HasColumnType("datetime");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Recenzija).IsRequired();

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.Recenzije)
                    .HasForeignKey(d => d.KnjigaId)
                    .HasConstraintName("FK__Recenzije__Knjig__5441852A");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Recenzije)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Recenzije__Koris__534D60F1");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId);

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.DatumPreuzimanja).HasColumnType("datetime");

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.DatumVracanja).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__Rezervaci__Koris__49C3F6B7");
            });

            modelBuilder.Entity<RezervacijeKnjige>(entity =>
            {
                entity.HasKey(e => e.RezervacijaKnjigaId);

                entity.Property(e => e.RezervacijaKnjigaId).HasColumnName("RezervacijaKnjigaID");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.RezervacijeKnjige)
                    .HasForeignKey(d => d.KnjigaId)
                    .HasConstraintName("FK__Rezervaci__Knjig__4CA06362");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.RezervacijeKnjige)
                    .HasForeignKey(d => d.RezervacijaId)
                    .HasConstraintName("FK__Rezervaci__Rezer__4D94879B");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Zanrovi>(entity =>
            {
                entity.HasKey(e => e.ZanrId);

                entity.Property(e => e.ZanrId).HasColumnName("ZanrID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
