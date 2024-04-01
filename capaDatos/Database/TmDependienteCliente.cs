using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmDependienteCliente
{
    public int DependienteClienteId { get; set; }

    public int? ClienteId { get; set; }

    public int? DetalleViajeroId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public virtual TmCliente? Cliente { get; set; }

    public virtual TdViajero? DetalleViajero { get; set; }
}
