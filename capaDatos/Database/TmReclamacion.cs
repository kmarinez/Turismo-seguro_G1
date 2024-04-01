using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmReclamacion
{
    public int ReclamacionId { get; set; }

    public int? PolizaId { get; set; }

    public int? EstadoReclamacionId { get; set; }

    public virtual TdEstadoReclamacion? EstadoReclamacion { get; set; }

    public virtual TmGestionPoliza? Poliza { get; set; }

    public virtual ICollection<TdComunicacionReclamacion> TdComunicacionReclamacions { get; set; } = new List<TdComunicacionReclamacion>();

    public virtual ICollection<TmDocumentosReclamacion> TmDocumentosReclamacions { get; set; } = new List<TmDocumentosReclamacion>();
}
