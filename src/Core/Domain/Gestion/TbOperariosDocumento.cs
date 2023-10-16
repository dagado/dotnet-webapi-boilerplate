using System;
using System.Collections.Generic;

namespace FSH.WebApi.Domain.Gestion;

public partial class TbOperariosDocumento
{
    public string IdRegistro { get; set; } = null!;

    public string IdOperario { get; set; } = null!;

    public string DescripcionDocumento { get; set; } = null!;

    public byte[] Documento { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Observaciones { get; set; }

    public virtual TbOperario IdOperarioNavigation { get; set; } = null!;
}
