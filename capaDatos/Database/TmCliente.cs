using System;
using System.Collections.Generic;

namespace capaDatos.Database;

public partial class TmCliente
{
    public int ClienteId { get; set; }

    public int? DetalleViajeroId { get; set; }

    public string? NombreCliente { get; set; }

    public string? ApellidoCliente { get; set; }

    public string? NumeroTelefono { get; set; }

    public string? CorreoElectronico { get; set; }

    public virtual TdViajero? DetalleViajero { get; set; }

    public virtual ICollection<TmDependienteCliente> TmDependienteClientes { get; set; } = new List<TmDependienteCliente>();

    public virtual ICollection<TmGestionPoliza> TmGestionPolizas { get; set; } = new List<TmGestionPoliza>();

    public virtual ICollection<TmUsuario> TmUsuarios { get; set; } = new List<TmUsuario>();
}
