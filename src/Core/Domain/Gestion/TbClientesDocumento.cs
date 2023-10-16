using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesDocumento
{
    public string Id { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string DescripcionDocumento { get; set; } = null!;

    public byte[] Documento { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;
}
