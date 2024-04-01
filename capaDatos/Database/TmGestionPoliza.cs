using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmGestionPoliza
{
    public int PolizaId { get; set; }

    public int? ClienteId { get; set; }

    public int? CompraId { get; set; }

    public DateTime? Renovacion { get; set; }

    public string? DocumentoPoliza { get; set; }

    public bool? Estatus { get; set; }

    public virtual TmCliente? Cliente { get; set; }

    public virtual TmCompraSeguro? Compra { get; set; }

    public virtual ICollection<TmReclamacion> TmReclamacions { get; set; } = new List<TmReclamacion>();
}
