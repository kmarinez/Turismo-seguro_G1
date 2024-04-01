using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmAsistencium
{
    public int AsistenciaId { get; set; }

    public int? PaisId { get; set; }

    public int? CategoriaAsistenciaId { get; set; }

    public string? NombreProfesional { get; set; }

    public string? Direccion { get; set; }

    public decimal? Costo { get; set; }

    public virtual TmCategoriaAsistencium? CategoriaAsistencia { get; set; }

    public virtual TmPai? Pais { get; set; }
}
