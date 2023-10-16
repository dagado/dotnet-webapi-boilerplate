using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbCabeceraPresupuestoDocumento
{
    public string Id { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public string DescripcionDocumento { get; set; } = null!;

    public byte[] Documento { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbCabeceraPresupuesto IdDocumentoNavigation { get; set; } = null!;
}
