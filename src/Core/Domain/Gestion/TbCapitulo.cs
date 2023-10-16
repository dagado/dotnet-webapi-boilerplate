using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCapitulo
{
    public string CodigoCapitulo { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public string Capitulo { get; set; } = null!;

    public string? Proyecto { get; set; }

    public bool Imprimirtotal { get; set; }

    public virtual TbCabeceraPresupuesto IdDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<TbDetallePresupuesto> TbDetallePresupuestos { get; } = new List<TbDetallePresupuesto>();

    public virtual ICollection<TbSubCapitulo> TbSubCapitulos { get; } = new List<TbSubCapitulo>();
}
