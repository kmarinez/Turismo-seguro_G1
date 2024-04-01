using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmCobertura
{
    public int CoberturaId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<TmCompraSeguro> TmCompraSeguros { get; set; } = new List<TmCompraSeguro>();
}
