using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TdRolesxUsuario
{
    public int IdRolxUsuario { get; set; }

    public int IdRol { get; set; }

    public int UsuarioId { get; set; }

    public string? CreadoPor { get; set; }

    public string? CanceladoPor { get; set; }

    public string? ModificadoPor { get; set; }

    public DateTime? FechaCreado { get; set; }

    public DateTime? FechaModificado { get; set; }

    public DateTime? FechaCancelado { get; set; }

    public bool? FlagActivo { get; set; }

    public virtual TmRole IdRolNavigation { get; set; } = null!;

    public virtual TmUsuario Usuario { get; set; } = null!;
}
