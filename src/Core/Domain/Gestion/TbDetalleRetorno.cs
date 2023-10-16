using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetalleRetorno
{
    public string IdRetorno { get; set; } = null!;

    public string IdDetalleAviso { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public DateTime Fecha { get; set; }

    public string? Observaciones { get; set; }

    public string? IdDetalleAlbaranCompra { get; set; }

    public virtual TbDetalle IdDetalleAvisoNavigation { get; set; } = null!;
}
