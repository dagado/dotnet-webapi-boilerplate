using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbFacturaCertificacion
{
    public string IdFactura { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public short Certificacion { get; set; }

    public virtual TbCabeceraPresupuesto IdDocumentoNavigation { get; set; } = null!;

    public virtual TbcabeceraFactura IdFacturaNavigation { get; set; } = null!;
}
