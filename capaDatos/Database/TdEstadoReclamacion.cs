using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TdEstadoReclamacion
{
    public int EstadoReclamacionId { get; set; }

    public string? Detalle { get; set; }

    public virtual ICollection<TmReclamacion> TmReclamacions { get; set; } = new List<TmReclamacion>();
}
