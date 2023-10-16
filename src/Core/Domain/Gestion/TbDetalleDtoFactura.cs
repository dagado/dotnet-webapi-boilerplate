using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetalleDtoFactura
{
    public string Idfactura { get; set; } = null!;

    public string Id { get; set; } = null!;

    public decimal Descuento { get; set; }

    public string Iddescuento { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual TbTiposDescuento IddescuentoNavigation { get; set; } = null!;

    public virtual TbcabeceraFactura IdfacturaNavigation { get; set; } = null!;
}
