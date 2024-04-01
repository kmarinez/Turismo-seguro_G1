using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TdLogin
{
    public int LoginId { get; set; }

    public int UsuarioId { get; set; }

    public string? UrlLogin { get; set; }

    public string? CreadoPor { get; set; }

    public string? CanceladoPor { get; set; }

    public string? ModificadoPor { get; set; }

    public DateTime? FechaCreado { get; set; }

    public DateTime? FechaModificado { get; set; }

    public DateTime? FechaCancelado { get; set; }

    public bool? FlagActivo { get; set; }

    public virtual TmUsuario Usuario { get; set; } = null!;
}
