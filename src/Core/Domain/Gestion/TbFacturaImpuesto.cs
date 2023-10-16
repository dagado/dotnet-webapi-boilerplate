using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbFacturaImpuesto
{
    public string Id { get; set; } = null!;

    public string IdFactura { get; set; } = null!;

    public decimal Bruto { get; set; }

    public decimal Base { get; set; }

    public decimal Iva { get; set; }

    public string CodigoIva { get; set; } = null!;

    public string? CodigoRetencion { get; set; }

    public decimal TotalIva { get; set; }

    public decimal TotalRetencion { get; set; }

    public decimal RecargoEquivalencia { get; set; }

    public decimal TotalRecargo { get; set; }

    public decimal TotalFactura { get; set; }

    public virtual TbIva CodigoIvaNavigation { get; set; } = null!;

    public virtual TbRetencione? CodigoRetencionNavigation { get; set; }

    public virtual TbcabeceraFactura IdFacturaNavigation { get; set; } = null!;
}
