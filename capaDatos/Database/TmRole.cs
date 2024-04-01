using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmRole
{
    public int IdRol { get; set; }

    public string? Descripcion { get; set; }

    public string? CreadoPor { get; set; }

    public string? CanceladoPor { get; set; }

    public string? ModificadoPor { get; set; }

    public DateTime? FechaCreado { get; set; }

    public DateTime? FechaModificado { get; set; }

    public DateTime? FechaCancelado { get; set; }

    public bool? FlagActivo { get; set; }

    public virtual ICollection<TdRolesxUsuario> TdRolesxUsuarios { get; set; } = new List<TdRolesxUsuario>();
}
