using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesTarifa
{
    public string Id { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string Idtarifa { get; set; } = null!;

    public short Prioridad { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? DescuentoSobreDescuentoProveedor { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbCabeceraTarifa IdtarifaNavigation { get; set; } = null!;
}
