using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbClientesFacturacionPeriodica
{
    public string Id { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public short Mes { get; set; }

    public string? Idarticulo { get; set; }

    public string Concepto { get; set; } = null!;

    public decimal Unidades { get; set; }

    public decimal Precio { get; set; }

    public decimal Dto { get; set; }

    public short Orden { get; set; }

    public string? Iddelegacion { get; set; }

    public string? Agrupacion { get; set; }

    public decimal? Unidades2 { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbArticulo? IdarticuloNavigation { get; set; }

    public virtual TbCliente IdclienteNavigation { get; set; } = null!;

    public virtual TbClientesDelegacione? IddelegacionNavigation { get; set; }
}
