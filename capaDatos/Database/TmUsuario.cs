using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmUsuario
{
    public int UsuarioId { get; set; }

    public int? ClienteId { get; set; }

    public string? Usuario { get; set; }

    public string? ClaveAcceso { get; set; }

    public string? Salt { get; set; }

    public string? CreadoPor { get; set; }

    public string? ModificadoPor { get; set; }

    public string? CanceladoPor { get; set; }

    public DateTime? FechaCreado { get; set; }

    public DateTime? FechaModificado { get; set; }

    public DateTime? FechaCancelado { get; set; }

    public bool? FlagActivo { get; set; }

    public virtual TmCliente? Cliente { get; set; }

    public virtual ICollection<TdComunicacionReclamacion> TdComunicacionReclamacions { get; set; } = new List<TdComunicacionReclamacion>();

    public virtual ICollection<TdLogin> TdLogins { get; set; } = new List<TdLogin>();

    public virtual ICollection<TdRolesxUsuario> TdRolesxUsuarios { get; set; } = new List<TdRolesxUsuario>();
}
