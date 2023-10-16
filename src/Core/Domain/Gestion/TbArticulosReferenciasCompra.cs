using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbArticulosReferenciasCompra
{
    public string Id { get; set; } = null!;

    public string Idarticulo { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string Idproveedor { get; set; } = null!;

    public decimal Preciocompra { get; set; }

    public decimal? Dto1 { get; set; }

    public decimal? Dto2 { get; set; }

    public decimal? Dto3 { get; set; }

    public virtual TbArticulo IdarticuloNavigation { get; set; } = null!;

    public virtual TbCliente IdproveedorNavigation { get; set; } = null!;
}
