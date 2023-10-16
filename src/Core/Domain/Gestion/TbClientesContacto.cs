using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesContacto
{
    public string IdContacto { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string Contacto { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Movil { get; set; }

    public string? Observaciones { get; set; }

    public string? Cargo { get; set; }

    public bool Descatalogado { get; set; }

    public string? Email { get; set; }

    public bool CopiaEnvios { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;
}
