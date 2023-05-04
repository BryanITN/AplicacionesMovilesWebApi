using Microsoft.EntityFrameworkCore;

namespace AplicacionesMoviles.WebApi.Entidades;

public partial class BaseDatosContext : DbContext
{
    public BaseDatosContext()
    {
    }

    public BaseDatosContext(DbContextOptions<BaseDatosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Contraseña> Contraseñas { get; set; }

    public virtual DbSet<Informacion> Informacions { get; set; }

    public virtual DbSet<Linea> Lineas { get; set; }

    public virtual DbSet<Prueba> Pruebas { get; set; }

    public virtual DbSet<Rango> Rangos { get; set; }

    public virtual DbSet<Tecnico> Tecnicos { get; set; }

    public virtual DbSet<Variacion> Variacions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.NumOrden);

            entity.Property(e => e.NumOrden).HasColumnName("Num_Orden");
            entity.Property(e => e.Cliente1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cliente");
            entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");
        });

        modelBuilder.Entity<Contraseña>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Contraseña");

            entity.Property(e => e.Contraseña1).HasColumnName("Contraseña");
            entity.Property(e => e.IdTecnico).HasColumnName("ID_Tecnico");

            entity.HasOne(d => d.IdTecnicoNavigation).WithMany()
                .HasForeignKey(d => d.IdTecnico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contraseña_Tecnico");
        });

        modelBuilder.Entity<Informacion>(entity =>
        {
            entity.HasKey(e => e.NumVariacion).HasName("PK_Informacion_1");

            entity.ToTable("Informacion");

            entity.Property(e => e.NumVariacion).HasColumnName("Num_Variacion");
            entity.Property(e => e.Especificaciones)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdInfo).HasColumnName("Id_Info");
            entity.Property(e => e.ListaDePartes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lista de partes");
            entity.Property(e => e.NP).HasColumnName("N_P");
            entity.Property(e => e.NumOrden).HasColumnName("Num_Orden");
            entity.Property(e => e.NumRango)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Num_Rango");
            entity.Property(e => e.Procedimiento)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.NumOrdenNavigation).WithMany(p => p.Informacions)
                .HasForeignKey(d => d.NumOrden)
                .HasConstraintName("FK_Informacion_Clientes");

            entity.HasOne(d => d.NumRangoNavigation).WithMany(p => p.Informacions)
                .HasForeignKey(d => d.NumRango)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Informacion_Rango");
        });

        modelBuilder.Entity<Linea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Linea");

            entity.Property(e => e.Equipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdTecnico).HasColumnName("ID_Tecnico");
            entity.Property(e => e.NumEstacion).HasColumnName("Num_Estacion");
            entity.Property(e => e.NumPrueba).HasColumnName("Num_Prueba");

            entity.HasOne(d => d.IdTecnicoNavigation).WithMany()
                .HasForeignKey(d => d.IdTecnico)
                .HasConstraintName("FK_Linea_Tecnico");
        });

        modelBuilder.Entity<Prueba>(entity =>
        {
            entity.HasKey(e => e.IdInfo);

            entity.ToTable("Prueba");

            entity.Property(e => e.IdInfo).HasColumnName("Id_Info");
            entity.Property(e => e.Bandera)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NP).HasColumnName("N_P");
            entity.Property(e => e.NumPrueba).HasColumnName("Num_Prueba");
        });

        modelBuilder.Entity<Rango>(entity =>
        {
            entity.HasKey(e => e.NumRango);

            entity.ToTable("Rango");

            entity.Property(e => e.NumRango)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Num_Rango");
            entity.Property(e => e.RangoMayor)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Rango_Mayor");
            entity.Property(e => e.RangoMenor)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Rango_Menor");
            entity.Property(e => e.Unidad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tecnico>(entity =>
        {
            entity.HasKey(e => e.IdTecnico);

            entity.ToTable("Tecnico");

            entity.Property(e => e.IdTecnico)
                .ValueGeneratedNever()
                .HasColumnName("ID_Tecnico");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Variacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Variacion");

            entity.Property(e => e.Desviaciones)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ecn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ECN");
            entity.Property(e => e.NumModelo).HasColumnName("Num_Modelo");
            entity.Property(e => e.NumVariacion).HasColumnName("Num_Variacion");

            entity.HasOne(d => d.NumVariacionNavigation).WithMany()
                .HasForeignKey(d => d.NumVariacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Variacion_Informacion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
