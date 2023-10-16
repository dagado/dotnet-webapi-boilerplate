using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDetalleCertificacion
{
    public string IdDetallePresupuesto { get; set; } = null!;

    public string IdDetalleFactura { get; set; } = null!;

    public short Certificacion { get; set; }

    public virtual TbDetalle IdDetalleFacturaNavigation { get; set; } = null!;

    public virtual TbDetallePresupuesto IdDetallePresupuestoNavigation { get; set; } = null!;
}
