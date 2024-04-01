using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmExtraOpcional
{
    public int ExtraOpcionalId { get; set; }

    public int? CategoriaAsistenciaId { get; set; }

    public string? Descripcion { get; set; }

    public virtual TmCategoriaAsistencium? CategoriaAsistencia { get; set; }

    public virtual ICollection<TdCompraXextra> TdCompraXextras { get; set; } = new List<TdCompraXextra>();
}
