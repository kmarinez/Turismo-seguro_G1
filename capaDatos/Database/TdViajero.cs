using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TdViajero
{
    public int DetalleViajeroId { get; set; }

    public int? CotizacionId { get; set; }

    public int? EdadViajero { get; set; }

    public virtual TmCotizacion? Cotizacion { get; set; }

    public virtual ICollection<TmCliente> TmClientes { get; set; } = new List<TmCliente>();

    public virtual ICollection<TmDependienteCliente> TmDependienteClientes { get; set; } = new List<TmDependienteCliente>();
}
