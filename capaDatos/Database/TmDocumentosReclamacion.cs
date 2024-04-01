using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmDocumentosReclamacion
{
    public int DocumentosReclamacionId { get; set; }

    public int? ReclamacionId { get; set; }

    public string? Nombre { get; set; }

    public string? Archivo { get; set; }

    public virtual TmReclamacion? Reclamacion { get; set; }
}
