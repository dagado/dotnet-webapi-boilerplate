using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbSubCapitulo
{
    public string CodigoCapitulo { get; set; } = null!;

    public string CodigoSubCapitulo { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public string SubCapitulo { get; set; } = null!;

    public virtual TbCapitulo TbCapitulo { get; set; } = null!;

    public virtual ICollection<TbDetallePresupuesto> TbDetallePresupuestos { get; } = new List<TbDetallePresupuesto>();
}
