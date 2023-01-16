using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BuzonDeSugerencias.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Solicitud> Solicituds { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BuzonDeSugerencias;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.ToTable("Solicitud");

                entity.Property(e => e.ApellidoPaterno).IsRequired();

                entity.Property(e => e.BienContratado).IsRequired();

                entity.Property(e => e.Correo).IsRequired();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Domicilio).IsRequired();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaDeRespuesta).HasColumnType("datetime");

                entity.Property(e => e.MontoReclamado).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombreDelBienContratado).IsRequired();

                entity.Property(e => e.PadreNombre).IsRequired();

                entity.Property(e => e.Respuesta).HasColumnType("ntext");

                entity.Property(e => e.TipoDeInforme).IsRequired();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.CellPhone).IsRequired();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastAccess).HasColumnType("datetime");

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.NumberDoc)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeDoc)
                    .IsRequired()
                    .HasMaxLength(18);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
