using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesTarifaDto
{
    public string Id { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string Iddescuento { get; set; } = null!;

    public string? Observaciones { get; set; }

    public decimal Descuento { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbTiposDescuento IddescuentoNavigation { get; set; } = null!;
}
