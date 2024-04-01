using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TdCompraXextra
{
    public int CompraXextraId { get; set; }

    public int? CompraId { get; set; }

    public int? ExtraOpcionalId { get; set; }

    public virtual TmCompraSeguro? Compra { get; set; }

    public virtual TmExtraOpcional? ExtraOpcional { get; set; }
}
