using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TdComunicacionReclamacion
{
    public int ComunicacionReclamacionId { get; set; }

    public int? ReclamacionId { get; set; }

    public int? UsuarioId { get; set; }

    public string? Mensaje { get; set; }

    public virtual TmReclamacion? Reclamacion { get; set; }

    public virtual TmUsuario? Usuario { get; set; }
}
