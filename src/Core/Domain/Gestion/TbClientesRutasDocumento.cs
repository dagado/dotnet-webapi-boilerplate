using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesRutasDocumento
{
    public string IdRuta { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string DescripcionRuta { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;
}
