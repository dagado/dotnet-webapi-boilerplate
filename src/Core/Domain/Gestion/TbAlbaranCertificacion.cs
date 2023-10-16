using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbAlbaranCertificacion
{
    public string IdAlbaran { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public short Certificacion { get; set; }

    public virtual TbcabeceraAlbaran IdAlbaranNavigation { get; set; } = null!;

    public virtual TbCabeceraPresupuesto IdDocumentoNavigation { get; set; } = null!;
}
