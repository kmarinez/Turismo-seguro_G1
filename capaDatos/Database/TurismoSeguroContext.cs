using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace capaDatos.Database;

public partial class TurismoSeguroContext : DbContext
{
    public TurismoSeguroContext()
    {
    }

    public TurismoSeguroContext(DbContextOptions<TurismoSeguroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TdCompraXextra> TdCompraXextras { get; set; }

    public virtual DbSet<TdComunicacionReclamacion> TdComunicacionReclamacions { get; set; }

    public virtual DbSet<TdEstadoReclamacion> TdEstadoReclamacions { get; set; }

    public virtual DbSet<TdLogin> TdLogins { get; set; }

    public virtual DbSet<TdRolesxUsuario> TdRolesxUsuarios { get; set; }

    public virtual DbSet<TdViajero> TdViajeros { get; set; }

    public virtual DbSet<TmAsistencium> TmAsistencia { get; set; }

    public virtual DbSet<TmCategoriaAsistencium> TmCategoriaAsistencia { get; set; }

    public virtual DbSet<TmCliente> TmClientes { get; set; }

    public virtual DbSet<TmCobertura> TmCoberturas { get; set; }

    public virtual DbSet<TmCompraSeguro> TmCompraSeguros { get; set; }

    public virtual DbSet<TmCotizacion> TmCotizacions { get; set; }

    public virtual DbSet<TmDependienteCliente> TmDependienteClientes { get; set; }

    public virtual DbSet<TmDocumentosReclamacion> TmDocumentosReclamacions { get; set; }

    public virtual DbSet<TmExtraOpcional> TmExtraOpcionals { get; set; }

    public virtual DbSet<TmGestionPoliza> TmGestionPolizas { get; set; }

    public virtual DbSet<TmPai> TmPais { get; set; }

    public virtual DbSet<TmReclamacion> TmReclamacions { get; set; }

    public virtual DbSet<TmRecomendacione> TmRecomendaciones { get; set; }

    public virtual DbSet<TmRole> TmRoles { get; set; }

    public virtual DbSet<TmUsuario> TmUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost; Database=Turismo_Seguro; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TdCompraXextra>(entity =>
        {
            entity.HasKey(e => e.CompraXextraId).HasName("PK__TD_Compr__C3CB3FFDC114254E");

            entity.ToTable("TD_CompraXExtra");

            entity.Property(e => e.CompraXextraId).HasColumnName("CompraXExtra_ID");
            entity.Property(e => e.CompraId).HasColumnName("Compra_ID");
            entity.Property(e => e.ExtraOpcionalId).HasColumnName("ExtraOpcional_ID");

            entity.HasOne(d => d.Compra).WithMany(p => p.TdCompraXextras)
                .HasForeignKey(d => d.CompraId)
                .HasConstraintName("FK__TD_Compra__Compr__693CA210");

            entity.HasOne(d => d.ExtraOpcional).WithMany(p => p.TdCompraXextras)
                .HasForeignKey(d => d.ExtraOpcionalId)
                .HasConstraintName("FK__TD_Compra__Extra__6A30C649");
        });

        modelBuilder.Entity<TdComunicacionReclamacion>(entity =>
        {
            entity.HasKey(e => e.ComunicacionReclamacionId).HasName("PK__TD_Comun__D899AC4B72B3C2E1");

            entity.ToTable("TD_ComunicacionReclamacion");

            entity.Property(e => e.ComunicacionReclamacionId).HasColumnName("ComunicacionReclamacion_ID");
            entity.Property(e => e.Mensaje).HasColumnType("text");
            entity.Property(e => e.ReclamacionId).HasColumnName("Reclamacion_ID");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_ID");

            entity.HasOne(d => d.Reclamacion).WithMany(p => p.TdComunicacionReclamacions)
                .HasForeignKey(d => d.ReclamacionId)
                .HasConstraintName("FK__TD_Comuni__Recla__6D0D32F4");

            entity.HasOne(d => d.Usuario).WithMany(p => p.TdComunicacionReclamacions)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__TD_Comuni__Usuar__6E01572D");
        });

        modelBuilder.Entity<TdEstadoReclamacion>(entity =>
        {
            entity.HasKey(e => e.EstadoReclamacionId).HasName("PK__TD_Estad__E5C8982EF3B9D61A");

            entity.ToTable("TD_EstadoReclamacion");

            entity.Property(e => e.EstadoReclamacionId).HasColumnName("EstadoReclamacion_ID");
            entity.Property(e => e.Detalle)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TdLogin>(entity =>
        {
            entity.HasKey(e => e.LoginId).HasName("PK__TD_Login__D7886867E0808286");

            entity.ToTable("TD_Login");

            entity.Property(e => e.LoginId).HasColumnName("Login_ID");
            entity.Property(e => e.CanceladoPor)
                .HasMaxLength(25)
                .HasColumnName("canceladoPor");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(25)
                .HasColumnName("creadoPor");
            entity.Property(e => e.FechaCancelado)
                .HasColumnType("date")
                .HasColumnName("fechaCancelado");
            entity.Property(e => e.FechaCreado)
                .HasColumnType("date")
                .HasColumnName("fechaCreado");
            entity.Property(e => e.FechaModificado)
                .HasColumnType("date")
                .HasColumnName("fechaModificado");
            entity.Property(e => e.FlagActivo).HasColumnName("flagActivo");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(25)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.UrlLogin)
                .HasMaxLength(250)
                .HasColumnName("url_login");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_ID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.TdLogins)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Usuario_ID02");
        });

        modelBuilder.Entity<TdRolesxUsuario>(entity =>
        {
            entity.HasKey(e => e.IdRolxUsuario).HasName("PK__TD_Roles__A4053F92F4106ED9");

            entity.ToTable("TD_RolesxUsuarios");

            entity.Property(e => e.IdRolxUsuario).HasColumnName("idRolxUsuario");
            entity.Property(e => e.CanceladoPor)
                .HasMaxLength(25)
                .HasColumnName("canceladoPor");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(25)
                .HasColumnName("creadoPor");
            entity.Property(e => e.FechaCancelado)
                .HasColumnType("date")
                .HasColumnName("fechaCancelado");
            entity.Property(e => e.FechaCreado)
                .HasColumnType("date")
                .HasColumnName("fechaCreado");
            entity.Property(e => e.FechaModificado)
                .HasColumnType("date")
                .HasColumnName("fechaModificado");
            entity.Property(e => e.FlagActivo).HasColumnName("flagActivo");
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(25)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_ID");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.TdRolesxUsuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idRol01");

            entity.HasOne(d => d.Usuario).WithMany(p => p.TdRolesxUsuarios)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Usuario_ID01");
        });

        modelBuilder.Entity<TdViajero>(entity =>
        {
            entity.HasKey(e => e.DetalleViajeroId).HasName("PK__TD_Viaje__2058A341BEBD49C1");

            entity.ToTable("TD_Viajero");

            entity.Property(e => e.DetalleViajeroId).HasColumnName("DetalleViajero_ID");
            entity.Property(e => e.CotizacionId).HasColumnName("Cotizacion_ID");
            entity.Property(e => e.EdadViajero).HasColumnName("Edad_Viajero");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.TdViajeros)
                .HasForeignKey(d => d.CotizacionId)
                .HasConstraintName("FK__TD_Viajer__Cotiz__3F466844");
        });

        modelBuilder.Entity<TmAsistencium>(entity =>
        {
            entity.HasKey(e => e.AsistenciaId).HasName("PK__TM_Asist__6C86D8D51213A1D9");

            entity.ToTable("TM_Asistencia");

            entity.Property(e => e.AsistenciaId).HasColumnName("Asistencia_ID");
            entity.Property(e => e.CategoriaAsistenciaId).HasColumnName("CategoriaAsistencia_ID");
            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreProfesional)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PaisId).HasColumnName("Pais_ID");

            entity.HasOne(d => d.CategoriaAsistencia).WithMany(p => p.TmAsistencia)
                .HasForeignKey(d => d.CategoriaAsistenciaId)
                .HasConstraintName("FK__TM_Asiste__Categ__6383C8BA");

            entity.HasOne(d => d.Pais).WithMany(p => p.TmAsistencia)
                .HasForeignKey(d => d.PaisId)
                .HasConstraintName("FK__TM_Asiste__Pais___628FA481");
        });

        modelBuilder.Entity<TmCategoriaAsistencium>(entity =>
        {
            entity.HasKey(e => e.CategoriaAsistenciaId).HasName("PK__TM_Categ__01A6BF226FABD04F");

            entity.ToTable("TM_CategoriaAsistencia");

            entity.Property(e => e.CategoriaAsistenciaId).HasColumnName("CategoriaAsistencia_ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmCliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__TM_Clien__EB683FB47A8D87C4");

            entity.ToTable("TM_Cliente");

            entity.Property(e => e.ClienteId).HasColumnName("Cliente_ID");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Correo_Electronico");
            entity.Property(e => e.DetalleViajeroId).HasColumnName("DetalleViajero_ID");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTelefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.DetalleViajero).WithMany(p => p.TmClientes)
                .HasForeignKey(d => d.DetalleViajeroId)
                .HasConstraintName("FK__TM_Client__Detal__4222D4EF");
        });

        modelBuilder.Entity<TmCobertura>(entity =>
        {
            entity.HasKey(e => e.CoberturaId).HasName("PK__TM_Cober__E54E2EB7AC1A09B0");

            entity.ToTable("TM_Cobertura");

            entity.Property(e => e.CoberturaId).HasColumnName("Cobertura_ID");
            entity.Property(e => e.Descripcion).HasColumnType("text");
        });

        modelBuilder.Entity<TmCompraSeguro>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__TM_Compr__BAE9517B290A7F45");

            entity.ToTable("TM_CompraSeguro");

            entity.Property(e => e.CompraId).HasColumnName("Compra_ID");
            entity.Property(e => e.CoberturaId).HasColumnName("Cobertura_ID");
            entity.Property(e => e.CotizacionId).HasColumnName("Cotizacion_ID");

            entity.HasOne(d => d.Cobertura).WithMany(p => p.TmCompraSeguros)
                .HasForeignKey(d => d.CoberturaId)
                .HasConstraintName("FK__TM_Compra__Cober__4E88ABD4");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.TmCompraSeguros)
                .HasForeignKey(d => d.CotizacionId)
                .HasConstraintName("FK__TM_Compra__Cotiz__4D94879B");
        });

        modelBuilder.Entity<TmCotizacion>(entity =>
        {
            entity.HasKey(e => e.CotizacionId).HasName("PK__TM_Cotiz__D2B6535095E3F077");

            entity.ToTable("TM_Cotizacion");

            entity.Property(e => e.CotizacionId).HasColumnName("Cotizacion_ID");
            entity.Property(e => e.CantidadViajeros).HasColumnName("Cantidad_Viajeros");
            entity.Property(e => e.PaisId).HasColumnName("Pais_ID");

            entity.HasOne(d => d.Pais).WithMany(p => p.TmCotizacions)
                .HasForeignKey(d => d.PaisId)
                .HasConstraintName("FK__TM_Cotiza__Pais___3C69FB99");
        });

        modelBuilder.Entity<TmDependienteCliente>(entity =>
        {
            entity.HasKey(e => e.DependienteClienteId).HasName("PK__TM_Depen__A167225D8E9AC8D6");

            entity.ToTable("TM_DependienteCliente");

            entity.Property(e => e.DependienteClienteId).HasColumnName("DependienteCliente_ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClienteId).HasColumnName("Cliente_ID");
            entity.Property(e => e.DetalleViajeroId).HasColumnName("DetalleViajero_ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.TmDependienteClientes)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__TM_Depend__Clien__47DBAE45");

            entity.HasOne(d => d.DetalleViajero).WithMany(p => p.TmDependienteClientes)
                .HasForeignKey(d => d.DetalleViajeroId)
                .HasConstraintName("FK__TM_Depend__Detal__48CFD27E");
        });

        modelBuilder.Entity<TmDocumentosReclamacion>(entity =>
        {
            entity.HasKey(e => e.DocumentosReclamacionId).HasName("PK__TM_Docum__8B30F0E238A7B222");

            entity.ToTable("TM_DocumentosReclamacion");

            entity.Property(e => e.DocumentosReclamacionId).HasColumnName("DocumentosReclamacion_ID");
            entity.Property(e => e.Archivo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReclamacionId).HasColumnName("Reclamacion_ID");

            entity.HasOne(d => d.Reclamacion).WithMany(p => p.TmDocumentosReclamacions)
                .HasForeignKey(d => d.ReclamacionId)
                .HasConstraintName("FK__TM_Docume__Recla__5FB337D6");
        });

        modelBuilder.Entity<TmExtraOpcional>(entity =>
        {
            entity.HasKey(e => e.ExtraOpcionalId).HasName("PK__TM_Extra__6D2F31AB01198A6F");

            entity.ToTable("TM_ExtraOpcional");

            entity.Property(e => e.ExtraOpcionalId).HasColumnName("ExtraOpcional_ID");
            entity.Property(e => e.CategoriaAsistenciaId).HasColumnName("CategoriaAsistencia_ID");
            entity.Property(e => e.Descripcion).HasColumnType("text");

            entity.HasOne(d => d.CategoriaAsistencia).WithMany(p => p.TmExtraOpcionals)
                .HasForeignKey(d => d.CategoriaAsistenciaId)
                .HasConstraintName("FK__TM_ExtraO__Categ__534D60F1");
        });

        modelBuilder.Entity<TmGestionPoliza>(entity =>
        {
            entity.HasKey(e => e.PolizaId).HasName("PK__TM_Gesti__5CBA075816897FCA");

            entity.ToTable("TM_GestionPoliza");

            entity.Property(e => e.PolizaId).HasColumnName("Poliza_ID");
            entity.Property(e => e.ClienteId).HasColumnName("Cliente_ID");
            entity.Property(e => e.CompraId).HasColumnName("Compra_ID");
            entity.Property(e => e.DocumentoPoliza)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Renovacion).HasColumnType("date");

            entity.HasOne(d => d.Cliente).WithMany(p => p.TmGestionPolizas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__TM_Gestio__Clien__5629CD9C");

            entity.HasOne(d => d.Compra).WithMany(p => p.TmGestionPolizas)
                .HasForeignKey(d => d.CompraId)
                .HasConstraintName("FK__TM_Gestio__Compr__571DF1D5");
        });

        modelBuilder.Entity<TmPai>(entity =>
        {
            entity.HasKey(e => e.PaisId).HasName("PK__TM_Pais__6356B8530B95FC21");

            entity.ToTable("TM_Pais");

            entity.Property(e => e.PaisId).HasColumnName("Pais_ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmReclamacion>(entity =>
        {
            entity.HasKey(e => e.ReclamacionId).HasName("PK__TM_Recla__BD73AD3E86FB5A50");

            entity.ToTable("TM_Reclamacion");

            entity.Property(e => e.ReclamacionId).HasColumnName("Reclamacion_ID");
            entity.Property(e => e.EstadoReclamacionId).HasColumnName("EstadoReclamacion_ID");
            entity.Property(e => e.PolizaId).HasColumnName("Poliza_ID");

            entity.HasOne(d => d.EstadoReclamacion).WithMany(p => p.TmReclamacions)
                .HasForeignKey(d => d.EstadoReclamacionId)
                .HasConstraintName("FK__TM_Reclam__Estad__5CD6CB2B");

            entity.HasOne(d => d.Poliza).WithMany(p => p.TmReclamacions)
                .HasForeignKey(d => d.PolizaId)
                .HasConstraintName("FK__TM_Reclam__Poliz__5BE2A6F2");
        });

        modelBuilder.Entity<TmRecomendacione>(entity =>
        {
            entity.HasKey(e => e.RecomendacionesId).HasName("PK__TM_Recom__E4FCE51DF64A172F");

            entity.ToTable("TM_Recomendaciones");

            entity.Property(e => e.RecomendacionesId).HasColumnName("Recomendaciones_ID");
            entity.Property(e => e.DetalleRecomendacion).HasColumnType("text");
            entity.Property(e => e.PaisId).HasColumnName("Pais_ID");

            entity.HasOne(d => d.Pais).WithMany(p => p.TmRecomendaciones)
                .HasForeignKey(d => d.PaisId)
                .HasConstraintName("FK__TM_Recome__Pais___66603565");
        });

        modelBuilder.Entity<TmRole>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__TM_Roles__3C872F761CD1CB5C");

            entity.ToTable("TM_Roles");

            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.CanceladoPor)
                .HasMaxLength(25)
                .HasColumnName("canceladoPor");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(25)
                .HasColumnName("creadoPor");
            entity.Property(e => e.Descripcion).HasMaxLength(30);
            entity.Property(e => e.FechaCancelado)
                .HasColumnType("date")
                .HasColumnName("fechaCancelado");
            entity.Property(e => e.FechaCreado)
                .HasColumnType("date")
                .HasColumnName("fechaCreado");
            entity.Property(e => e.FechaModificado)
                .HasColumnType("date")
                .HasColumnName("fechaModificado");
            entity.Property(e => e.FlagActivo).HasColumnName("flagActivo");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(25)
                .HasColumnName("modificadoPor");
        });

        modelBuilder.Entity<TmUsuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__TM_Usuar__771113355DF2CA4D");

            entity.ToTable("TM_Usuario");

            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_ID");
            entity.Property(e => e.CanceladoPor)
                .HasMaxLength(25)
                .HasColumnName("canceladoPor");
            entity.Property(e => e.ClaveAcceso)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Clave_Acceso");
            entity.Property(e => e.ClienteId).HasColumnName("Cliente_ID");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(25)
                .HasColumnName("creadoPor");
            entity.Property(e => e.FechaCancelado)
                .HasColumnType("date")
                .HasColumnName("fechaCancelado");
            entity.Property(e => e.FechaCreado)
                .HasColumnType("date")
                .HasColumnName("fechaCreado");
            entity.Property(e => e.FechaModificado)
                .HasColumnType("date")
                .HasColumnName("fechaModificado");
            entity.Property(e => e.FlagActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("flagActivo");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(25)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Salt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.TmUsuarios)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__TM_Usuari__Clien__44FF419A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
