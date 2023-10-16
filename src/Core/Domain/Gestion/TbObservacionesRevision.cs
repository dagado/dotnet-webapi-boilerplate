using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbObservacionesRevision
{
    public string IdObservaciones { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public string Revision { get; set; } = null!;

    public virtual TbCabeceraPresupuesto IdDocumentoNavigation { get; set; } = null!;
}
