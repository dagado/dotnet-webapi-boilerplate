using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetalleContrato
{
    public string Id { get; set; } = null!;

    public string IdContrato { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal PrecioUnidad { get; set; }

    public decimal Importe { get; set; }

    public string? Observaciones { get; set; }

    public short Orden { get; set; }

    public decimal ImporteIvaIncluido { get; set; }

    public string CodigoIva { get; set; } = null!;

    public decimal Iva { get; set; }

    public virtual TbIva CodigoIvaNavigation { get; set; } = null!;

    public virtual TbContrato IdContratoNavigation { get; set; } = null!;
}
