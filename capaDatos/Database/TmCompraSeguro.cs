using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmCompraSeguro
{
    public int CompraId { get; set; }

    public int? CotizacionId { get; set; }

    public int? CoberturaId { get; set; }

    public virtual TmCobertura? Cobertura { get; set; }

    public virtual TmCotizacion? Cotizacion { get; set; }

    public virtual ICollection<TdCompraXextra> TdCompraXextras { get; set; } = new List<TdCompraXextra>();

    public virtual ICollection<TmGestionPoliza> TmGestionPolizas { get; set; } = new List<TmGestionPoliza>();
}
