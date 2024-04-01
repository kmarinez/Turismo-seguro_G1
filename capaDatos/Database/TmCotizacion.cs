using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmCotizacion
{
    public int CotizacionId { get; set; }

    public int? PaisId { get; set; }

    public int? Duracion { get; set; }

    public int? CantidadViajeros { get; set; }

    public virtual TmPai? Pais { get; set; }

    public virtual ICollection<TdViajero> TdViajeros { get; set; } = new List<TdViajero>();

    public virtual ICollection<TmCompraSeguro> TmCompraSeguros { get; set; } = new List<TmCompraSeguro>();
}
