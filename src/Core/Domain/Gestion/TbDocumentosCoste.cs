using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbDocumentosCoste
{
    public string Id { get; set; } = null!;

    public string IdRegistro { get; set; } = null!;

    public byte[] Documento { get; set; } = null!;

    public string DescripcionDocumento { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbLineasCoste IdRegistroNavigation { get; set; } = null!;
}
