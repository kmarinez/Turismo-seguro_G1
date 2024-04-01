using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmRecomendacione
{
    public int RecomendacionesId { get; set; }

    public int? PaisId { get; set; }

    public string? DetalleRecomendacion { get; set; }

    public virtual TmPai? Pais { get; set; }
}
