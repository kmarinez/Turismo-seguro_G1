using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmCategoriaAsistencium
{
    public int CategoriaAsistenciaId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<TmAsistencium> TmAsistencia { get; set; } = new List<TmAsistencium>();

    public virtual ICollection<TmExtraOpcional> TmExtraOpcionals { get; set; } = new List<TmExtraOpcional>();
}
