using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmPai
{
    public int PaisId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<TmAsistencium> TmAsistencia { get; set; } = new List<TmAsistencium>();

    public virtual ICollection<TmCotizacion> TmCotizacions { get; set; } = new List<TmCotizacion>();

    public virtual ICollection<TmRecomendacione> TmRecomendaciones { get; set; } = new List<TmRecomendacione>();
}
