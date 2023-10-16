using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbArticulosPack
{
    public string Id { get; set; } = null!;

    public string IdArticulo { get; set; } = null!;

    public decimal PrecioBase { get; set; }

    public string Descripcion { get; set; } = null!;

    public string CodigoIvaVenta { get; set; } = null!;

    public string CodigoIvaCompra { get; set; } = null!;

    public decimal Precioii { get; set; }

    public decimal Precioiicompra { get; set; }

    public decimal Preciobasecompra { get; set; }

    public virtual TbIva CodigoIvaCompraNavigation { get; set; } = null!;

    public virtual TbIva CodigoIvaVentaNavigation { get; set; } = null!;

    public virtual TbArticulo IdArticuloNavigation { get; set; } = null!;
}
